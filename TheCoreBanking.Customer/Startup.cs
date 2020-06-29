using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using TheCoreBanking.Customer.Data;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Helpers;

namespace TheCoreBanking.Customer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc(options => options.EnableEndpointRouting = false);
                //.AddJsonOptions(
                //    options => options.SerializerSettings.ReferenceLoopHandling
                //        = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                //);
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = "Main.Cookies";
                    options.DefaultChallengeScheme = "oidc";
                    options.DefaultAuthenticateScheme = "oidc";
                })
                .AddCookie("Main.Cookies",
                    options => { options.AccessDeniedPath = "/account/accessdenied"; })
                #if DEBUG
                ;
                #else
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = "http://bankingplatform:8042";
                    options.RequireHttpsMetadata = false;
                    options.ClientId = "TheCoreBanking.Customers";
                    options.SignInScheme = "Main.Cookies";
                    options.ResponseType = "code id_token";
                    options.Scope.Clear();
                    options.Scope.Add("openid");
                    options.Scope.Add("profile");
                    options.Scope.Add("email");
                    options.Scope.Add("roles");
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.SaveTokens = true;
                    options.ClientSecret = "secret";
                    options.Events = new OpenIdConnectEvents()
                    {
                        OnTokenValidated = tokenValidatedContext =>
                        {
                            return Task.FromResult(0);
                        },
                        OnUserInformationReceived = (context) =>
                        {
                            ClaimsIdentity claimsId = context.Principal.Identity as ClaimsIdentity;
                            try
                            {

                                dynamic userClaim = JObject.Parse(context.User.ToString());
                                var roles = userClaim.role;
                                foreach (string role in roles)
                                {
                                    claimsId.AddClaim(new Claim("role", role));
                                }
                            }
                            catch (Exception)
                            {
                                //Users does not have roles
                            }
                            return Task.FromResult(0);
                        }

                    };
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = JwtClaimTypes.Name,
                        RoleClaimType = JwtClaimTypes.Role
                    };
                })
                ;
             #endif
            //services
            //    .AddDbContext<TCBCustomerContext>(
            //        options => options.UseSqlServer(
            //            Configuration.GetConnectionString("TheCoreBanking")
            //        )
            //    );
            services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
            services.AddScoped<IRepositoryProvider, RepositoryProvider>();
            services.AddSingleton<RepositoryFactories>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Profile}/{action=Index}/{id?}");
            });
        }
    }
}