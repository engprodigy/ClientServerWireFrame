using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace TheCoreBanking.Customer.ModelBinders
{
    public class FormJsonBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            string field = bindingContext.FieldName;
            var providerResult = bindingContext.ValueProvider.GetValue(field);

            if (providerResult == ValueProviderResult.None)
                return Task.CompletedTask;
            else
                bindingContext.ModelState.SetModelValue(field, providerResult);

            string value = providerResult.FirstValue;
            if (string.IsNullOrEmpty(value))
                return Task.CompletedTask;

            try {
                object result = JsonConvert.DeserializeObject(value, bindingContext.ModelType);
                bindingContext.Result = ModelBindingResult.Success(result);
            } catch(JsonException)
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }

            return Task.CompletedTask;
        }
    }
}
