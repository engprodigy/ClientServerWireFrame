var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}
var CustomerType;
var UpdateCustomer;
var UpdateAccount;
var AddressTypes;
var LGAs = [];
var Industries = [];
var tracker = 0;
var mandateRowObject;
var casaaccountNumber;
var updateEmail;
var casaAccountId;
var casaRowContent;
var productId;
var productFeeList = [];
var productFeeListId = [];
var productFeeListOriginal = [];
var productFeeListIdOriginal = [];
var productFeeListExtra = [];
var productFeeListIdExtra = [];
var approvalStatus = [];
var approvalStatusLogOut;
var approvalstatusBoolean;



$(document).ready(function () {
    
    initDataTable();
    initSelectTwoConfig();
    //initDatePicker(".datepicker");
    initFormValidations();
    //initWizards();
    $(".modal").perfectScrollbar();
   // prepareKYCTables();

    
});

function initSelectTwoConfig() {
    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);

    debugger

    $.ajax("../Profile/LoadBanks")
        .then(function (response) {
           // console.log(response);
            $("#ddlUBank").select2({
                placeholder: "Select bank",
                dropdownParent: $("#refereeUpdateModal.modal"),
                data: response
            });
        });

}

function initFormValidations() {
    // defaults
    jQuery.validator.setDefaults({
        onfocusout: false,
        onkeyup: false,
        onclick: false,
        normalizer: function (value) {
            // Trim the value of every element
            // before validation
            return $.trim(value);
        },
        errorPlacement: function (error, element) {
            $.notify({
                icon: "now-ui-icons travel_info",
                message: error.text()
            }, {
                type: "danger",
                placement: {
                    from: "top",
                    align: "right"
                }
            });
        }
    });


   

}

function initDataTable() {

    debugger

    $("#data-table").bootstrapTable('showLoading');


    $("#data-table").bootstrapTable({
        search: true,
        searchAlign: "right",
        //detailView: true,
        //detailFormatter: utilities.mandateDetailTableFormatter,
        url: "../Account/LoadDormantAccounts",
        // url: url_path + "/Profile/LoadCustomers",
        showPaginationSwitch: true,
        pagination: true,
        mobileResponsive: true,
        checkOnInit: true,
        minWidth: 626,
        toolbar: "#custom-toolbar",
        showRefresh: true,
        showToggle: true,
        uniqueId: "casaaccountid",
        buttonsClass: "danger",
        columns: [
            {
                field: "accountnumber",
                title: "Account Number",
                sortable: true
            },
            {
                field: "accountname",
                title: "Account Name",
                sortable: true
            }, {
                field: "productName",
                title: "Product",
                sortable: true,

            }, {
                field: "accountstatusid",
                title: "Status",
                sortable: true,
                formatter: utilities.activationStatusFormatter,
            },
            {
                field: null,
                title: "Activate",
                align: "center",
                width: "5%",
                formatter: utilities.activateAccountBtnFormatter,
            },

        ],
    });
    // $("#data-table").bootstrapTable("hideLoading");

   
}








var utilities = {

    animDuration: 400,

    activateAccountBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-info btn-icon' ",
            "onclick='utilities.activateAccount(" + row.casaaccountid + ")'>",
            "<i class='fas fa-edit'>",
            "</i></button>"
        ].join("");
    },

    activationStatusFormatter: function (value) {
    //var name = null;
    //name = productData[value];
    //if(!name) return "-";
    return "Dormant";
   
    },
    mandateDetailTableFormatter: function (index, row, detail) {
        detail.html("Loading...");
        var mandates, bvn, phones = [], emails = [];

        debugger

        bvn = row.bvn;
        
    },

    activateAccount: function (casaaccountid) {

        debugger

        var row = $("#data-table")
            .bootstrapTable("getRowByUniqueId", casaaccountid);

        // Populate individual form fields

        swal({
            title: "Are you sure?",
            text: "Dormant Account will be Activated",
            type: "question",
            showCancelButton: true,
            confirmButtonColor: "#34D027",
            confirmButtonText: "Yes, continue",
            cancelButtonText: "No, stop!",
            cancelButtonColor: "#ff9800",
            showLoaderOnConfirm: true,
            preConfirm: function () {
                return new Promise(function (resolve) {
                    setTimeout(function () {
                        resolve();
                    }, 1000);
                });
            }
        }).then(
            function (isConfirm) {
                if (isConfirm) {
                    // freeze save button
                    //$(button).attr("disabled", "true");

                    

                    // send ajax request
                    $.ajax({
                        url: '../Account/ReactivateAccountByCasaAccountId',
                        type: 'POST',
                        data: {
                            Id: casaaccountid
                        },
                        success: function (data) {
                            //$table.bootstrapTable('refresh');
                            swal({ title: 'Dormant Account Activation', text: 'Dormant Account Activation Completed successfully!', type: 'success' })
                                .then(function () { });

                            $("#data-table")
                                .bootstrapTable('refresh', {
                                    url: '../Account/LoadDormantAccounts/'
                                });
                        },
                        error: function (e) {
                            swal({ title: 'Dormant Account Activation', text: 'Dormant Account Activation Encountered An Error', type: 'error' }).then(function () { });

                        }
                    });

                }
            },
            function (isRejected) {
                return;
            }

        );
    },

    
    
   
};