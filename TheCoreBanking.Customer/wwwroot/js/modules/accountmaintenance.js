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

    /*$("#frmCustomer").validate({
        messages: {
            customerid: {
                required: "You must select a customer to proceed",
            }
        }, ignore: false
    });

    if (!window.location.href == "http://localhost:1659/Account") {
        $("#frmProduct").validate({
            messages: {
                productid: {
                    required: "You must select a product to proceed",
                }
            },
            ignore: false
        });
    }

    $("#frmAccountUpdate").each(function () {
        $(this).validate({
            messages: {
                accountname: {
                    required: "Account name is required"
                },
                lastupdatecomment: {
                    required: "Update comment is required"
                }
            }
        });
    });

    $("#frmMandate, #mandate-update-form").each(function () {
        $(this).validate({
            messages: {
                signatoryclass: {
                    required: "Signatory class is required"
                },
                signatorysurname: {
                    required: "Signatory surname is required"
                },
                bvn: {
                    required: "Signatory BVN is required"
                }
            }
        });
    });

*/

    $("#frmrefereeUpdate").each(function () {
        $(this).validate({
            messages: {
                fullname: {
                    required: "Referee's full name is required"
                },
                address: {
                    required: "Referee's address is required"
                },
                phone: {
                    required: "Referee's phone number is required"
                },
                relationship: {
                    required: "Referee's relationship is required"
                },
                accountname: {
                    required: "Referee's account name is required"
                },
                accountno: {
                    required: "Referee's account number is required"
                },
                bankid: {
                    required: "Referee's bank is required"
                },
                bankaddress: {
                    required: "Referee's bank address is required"
                },
                "referee-file": {
                    required: "Referee's document is required"
                }
            }
        });
    });

}

function initDataTable() {

    debugger

    $("#data-table").bootstrapTable('showLoading');


    $("#data-table").bootstrapTable({
        search: true,
        searchAlign: "right",
        detailView: true,
        detailFormatter: utilities.mandateDetailTableFormatter,
        url: "../Account/LoadAccounts",
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
                field: "postnostatusid",
                title: "Status",
                sortable: true,
            },
            {
                field: null,
                align: "center",
                width: "5%",
                formatter: utilities.dropDownFormatter,
            },

        ],
    });
    // $("#data-table").bootstrapTable("hideLoading");

   
}


function mandateUpdate(self) {

    debugger
    casaaccountNumber = self;
    UpdateAccount = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self);

    utilities.updateWizardHeader("#mandateUpdateModal");

    $("#mandateImage").empty();

    $.ajax("../Account/LoadAccountMandateMaintenance/" + self)
        .then(function (response) {

            if (!response) {

                swal({
                    title: "View Mandate",
                    text: "No Mandate Available for Account Yet",
                    type: "error",
                    allowOutsideClick: false,
                    allowEscapeKey: false
                })

            } else {
                $("#mandateUpdateTable").bootstrapTable("load", response);
                $("#mandateUpdateTable").bootstrapTable("hideLoading");

                // show/hide form/table
                $("#frmMandateUpdate").closest("div.row").hide();
                $("#mandateUpdateTable").closest("div.row").show();
                $("#mandate-toolbar").show();
                // swap title text
                $("#mandateUpdateTable #title").text("Account Mandate(es)");

                // Show modal
                $("#mandateUpdateModal").modal("show");
            }
        });

}

function handleRefereeUpdate(self) {

    debugger
    casaaccountNumber = self;
    UpdateAccount = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self);

    utilities.updateWizardHeaderReferee("#refereeUpdateModal");
    $("#refereeUpdateModal #status").text(" ");
   

        $.ajax("../Account/LoadAccountReferees/" + self)
            .then(function (response) {
                console.log(response);
                if (!response) {

                } else {
                    $("#refereeUpdateTable").bootstrapTable("load", response);
                    $("#refereeUpdateTable").bootstrapTable("hideLoading");

                    // show/hide form/table
                    $("#frmrefereeUpdate").closest("div.row").hide();
                    $("#refereeUpdateTable").closest("div.row").show();
                    $("#referee-toolbar").show();
                    // swap title text
                    $("#refereeUpdateTable #title").text("Account Referee(s)");

                    // Show modal
                    $("#refereeUpdateModal").modal("show");
                }
            });

   

}

function productConversionHandler(self) {

    debugger
    casaaccountNumber = self;
    UpdateAccount = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self);

    utilities.updateWizardHeaderProductConversion("#productConversionModal");
    utilities.updateWizardHeaderProductConversion2("#productConversionModal");

   // $("#refereeUpdateModal #status").text(" ");

   // $(container + ".headerProductConversionDetails2")

     //   .text("Account Product Name: " + UpdateAccount.productid

    $.ajax("../Account/LoadProducts/")
        .then(function (response) {
            console.log(response);
            if (!response) {

            } else {
                $("#productListTable").bootstrapTable("load", response);
                $("#productListTable").bootstrapTable("hideLoading");

                // show/hide form/table
                //$("#frmrefereeUpdate").closest("div.row").hide();
                $("#productListTable").closest("div.row").show();
                //$("#referee-toolbar").show();
                // swap title text
               // $("#productListTable #title").text("Account Referee(s)");

                // Show modal
                $("#productConversionModal").modal("show");
            }
        });



}


function emailMaintenanceHandler(self) {

    debugger
    casaaccountNumber = self;
    updateEmail = $("#data-table").bootstrapTable('getRowByUniqueId', self);

   // utilities.updateWizardHeaderProductConversion("#productConversionModal");
    //utilities.updateWizardHeaderProductConversion2("#productConversionModal");

    $("#frmEmailUpdate").closest("div.row").hide();
    $("#emailUpdateTable").closest("div.row").show();

    // swap title text
    $("#emailUpdateModal #title").text("Customer E-mail(s)");

    // Show modal
    $("#emailUpdateModal").modal("show");

   /* $.ajax("../Account/LoadEmail/")
        .then(function (response) {
            console.log(response);
            if (!response) {

            } else {
               
                $("#emailUpdateTable").bootstrapTable("load", response);
                $("#emailUpdateTable").bootstrapTable("hideLoading");

                // show/hide form/table
                $("#frmEmailUpdate").closest("div.row").hide();
                $("#emailUpdateTable").closest("div.row").show();

                // swap title text
                $("#emailUpdateModal #title").text("Customer E-mail(s)");

                // Show modal
                $("#emailUpdateModal").modal("show");
            }
        });*/




}

//function approvalStatusFormatter(value) {

//    debugger

//    $.ajax("../Account/LoadAccountMandateMaintenanceApprovalStatus/" + value)
//        .then(function (response) {

//            $.each(response, function (index, value) {

//                console.log(value);
//                approvalStatus.push(value);
             
//            });
            
           
        
//        });

//    console.log(approvalStatus[0])
//    return approvalStatus[0];
//    //if (value == 1) {
//    //console.log(approvalStatus)

    

//    //} else {
//    //    return "Pending";
//    //}
//}

function feeMaintenanceHandler(self) {

    debugger


    approvalStatusLogOut = " ";
    
    casaAccountId = self;

    casaRowContent = $("#data-table").bootstrapTable('getRowByUniqueId', self);

    casaaccountNumber = casaRowContent.accountnumber;

    productId = casaRowContent.productid;
   
    utilities.updateWizardHeaderFeeMaintenance("#accountFeeUpdateModal");

    $("#formproductMappingFeesUpdate").closest("div.row").hide();
    $("#productMappingFeesTable").closest("div.row").show();

   // $table.bootstrapTable('uncheckAll');
   // swap title text
    $("#accountFeeUpdateModal #title").text("Customer E-mail(s)");

    // Show modal
    

    var $table = $('#productMappingFeesTable');

    $table.bootstrapTable('uncheckAll');

    productFeeList = [];
    productFeeListId = [];
    productFeeListOriginal = [];
    productFeeListIdOriginal = [];
    productFeeListIdExtra = [];
    productFeeListExtra = [];
    $.ajax({
        type: 'GET',
        url: url_path + '/../GetFeeName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
        success: function (result) {
            console.log(result);
            $.each(result, function (index, value) {

                
               // approvalStatusLogOut = value.approvalstatus;
                //console.log(approvalStatusLogOut);
                productFeeListId.push(value.id);
                productFeeList.push(value.feeId);
                productFeeListOriginal.push(value.feeId);
                productFeeListIdOriginal.push(value.id);
                
            });

            //console.log(productFeeListId);
           // console.log(productFeeList);
            $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });
           
        },
    });

    $.ajax({
        type: 'GET',
        url: url_path + '/../GetFeeExtraName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
        success: function (result) {
            console.log(result);
            $.each(result, function (index, value) {

               // console.log(value.feeId);
                approvalStatusLogOut = value.approvalstatus;
                console.log(approvalStatusLogOut);
                productFeeListId.push(value.id);
                productFeeList.push(value.feeId);
                productFeeListIdExtra.push(value.id);
                productFeeListExtra.push(value.feeId);
            });

           // console.log(productFeeListId);
           // console.log(productFeeList);
            $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });

        },
    });

    setTimeout(function () {

        debugger

        if (approvalStatusLogOut == "New Copy Sent for Approval") {

        $("#accountFeeUpdateModal" + " .ApprovalDetails")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("New Copy Sent for Approval");

        // return
        } else if (approvalStatusLogOut == "Pending") {

            $("#accountFeeUpdateModal" + " .ApprovalDetails")
                /* .text(UpdateAccount.surname + " "
                     + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                     + UpdateCustomer.customercode);*/
                .text("Pending Approval");

            // return
        }

        else {
        $("#accountFeeUpdateModal" + " .ApprovalDetails")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("");

    }

    }, 500);

    setTimeout(function () {

        $("#accountFeeUpdateModal").modal("show");

    }, 800);
}

function  updateLinkedFees() {

    debugger

    if (approvalStatusLogOut == "New Copy Sent for Approval" || approvalStatusLogOut == "Pending") {

        swal({ title: 'Product Fee Approval', text: 'Transaction Awaiting Approval', type: 'error' })

        return
    }

    debugger;
    var $table = $('#productMappingFeesTable');

    //casaRowContent.productName
    casaaccountNumber = casaRowContent.accountnumber;
    var selectionData = $table.bootstrapTable('getAllSelections');


    //productFeeListOriginal = [];
    //productFeeListIdOriginal = [];

    //productFeeListExtra = [];
    //productFeeListIdExtra = [];

    //console.log(productFeeListExtra);

    productFeeListNew = [];
    var newselectionData = [];
    $.each(selectionData, function (index, itemData) {

        if (!productFeeListOriginal.includes(itemData.pdFeesId)) {
            productFeeListNew.push(itemData.pdFeesId);
            newselectionData.push(itemData);
        }

    });


    /*$.each(selectionData, function (index, itemData) {

        if (!productFeeListIdOriginal.includes(itemData.PdFeesId)) {
            newselectionData.push(itemData);
        }

    });*/

   // console.log(newselectionData);

    var counter = 0;
    // $.each(newselectionData, function (index, itemData) {
    $.each(productFeeListExtra, function (index, itemData) {
        debugger;

        console.log(itemData);


        //   if (productFeeListId.includes(itemData.PdFeesId) && productFeeListIdNew.includes(itemData.PdFeesId)) {
        if (productFeeListExtra.includes(itemData) && productFeeListNew.includes(itemData)) {


            console.log("Do Nothing");
            console.log(itemData);
        }
        //else if (!productFeeListId.includes(itemData.PdFeesId) && productFeeListIdNew.includes(itemData.PdFeesId)) {
        else if (!productFeeListExtra.includes(itemData) && productFeeListNew.includes(itemData)) {

            console.log("Insert Into Database");

            

            console.log(itemData);

            // } else if (productFeeListId.includes(itemData.PdFeesId) && !productFeeListIdNew.includes(itemData.PdFeesId)) {
        } else if (productFeeListExtra.includes(itemData) && !productFeeListNew.includes(itemData)) {

            console.log("Delete from Database");

            $.ajax({
                url: '../Account/DeleteProductFeesList',
                type: 'POST',
                data: {
                    Id: productFeeListIdExtra[counter], PdFeesId: "", productId: productId, PdFeesName: "",
                    PdRate: ""
                },
                success: function (data) {
                  
                },
                error: function (e) {
                 

                }
            });

            console.log(itemData);
            console.log(productFeeListIdExtra[counter]);
        }

        counter++;
    });


    counter = 0;
    //  $.each(productFeeListNew, function (index, itemData) {
        var detectforapproval = false;
  //  setTimeout(function () {
        $.each(newselectionData, function (index, itemData) {
        debugger;

          // detect wheteher to make an approval copy
       // console.log(itemData);

        if (productFeeListNew.includes(itemData.pdFeesId) && productFeeListExtra.includes(itemData.pdFeesId)) {
            //  if (productFeeListId.includes(itemData) && productFeeListIdNew.includes(itemData)) {

            console.log("Do Nothing");
            console.log(itemData);
        }
        else if (productFeeListNew.includes(itemData.pdFeesId) && !productFeeListExtra.includes(itemData.pdFeesId)) {
            // else if (!productFeeListId.includes(itemData) && productFeeListIdNew.includes(itemData)) {
            //detectforapproval = true;
            //console.log("Insert Into Database");
            $.ajax({
                url: '../Account/AddProductFeesList',
                type: 'POST',
                data: {
                    Id: 1, PdFeesId: newselectionData[counter].pdFeesId, casaAccountId: casaAccountId, productId: productId, PdFeesName: newselectionData[counter].pdFeesName,
                    PdRate: newselectionData[counter].pdRate
                },
                success: function (data) {
                   // $table.bootstrapTable('refresh');
                //    swal({ title: 'Add Fees to Product', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () { });

                    // $('#ddlProductname').val(null).trigger('change');
                },
                error: function (e) {
                //    swal({ title: 'Fee Mapping', text: 'CASA Fees Addition/Deletion encountered an error', type: 'error' }).then(function () { });

                }
            });

            //console.log(itemData);

        } else if (!productFeeListNew.includes(itemData.pdFeesId) && productFeeListExtra.includes(itemData.pdFeesId)) {
            // } else if (productFeeListId.includes(itemData) && !productFeeListIdNew.includes(itemData)) {

           // console.log("Delete from Database");
           // console.log(itemData);
        }

        counter++;
        });
   // }, 1500);

    setTimeout(function () {
        if (detectforapproval == false) {

            $.ajax({
                url: '../Account/AddProductFeesListForApprovalOnly',
                type: 'POST',
                data: {
                    casaAccountId: casaAccountId
                },
                success: function (data) {
                    // $table.bootstrapTable('refresh');
                    //    swal({ title: 'Add Fees to Product', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () { });

                    // $('#ddlProductname').val(null).trigger('change');
                },
                error: function (e) {
                    //    swal({ title: 'Fee Mapping', text: 'CASA Fees Addition/Deletion encountered an error', type: 'error' }).then(function () { });

                }
            });

        }
    }, 3000);


    swal({ title: 'Add Fees to Product', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () { });
    debugger

     casaRowContent = $("#data-table").bootstrapTable('getRowByUniqueId', casaAccountId);

     casaaccountNumber = casaRowContent.accountnumber;

    // var $table = $('#productMappingFeesTable');

     $table.bootstrapTable('uncheckAll');

     productFeeList = [];
     productFeeListId = [];
     productFeeListOriginal = [];
     productFeeListIdOriginal = [];
     productFeeListIdExtra = [];
     productFeeListExtra = [];
     $.ajax({
         type: 'GET',
         url: '../Account/GetFeeName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
         success: function (result) {
            // console.log(result);
             $.each(result, function (index, value) {

               //  console.log(value.feeId);
                 productFeeListId.push(value.id);
                 productFeeList.push(value.feeId);
                 productFeeListOriginal.push(value.feeId);
                 productFeeListIdOriginal.push(value.id);

             });

           //  console.log(productFeeListId);
           //  console.log(productFeeList);
           // $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });

         },
     });

     $.ajax({
         type: 'GET',
         url: '../Account/GetFeeExtraName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
         success: function (result) {
            // console.log(result);
             $.each(result, function (index, value) {

             //    console.log(value.feeId);
                 productFeeListId.push(value.id);
                 productFeeList.push(value.feeId);
                 productFeeListIdExtra.push(value.id);
                 productFeeListExtra.push(value.feeId);
             });

           //  console.log(productFeeListId);
           //  console.log(productFeeList);
           //  $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });

         },
     });

    $("#accountFeeUpdateModal").modal("hide");
   // $table.bootstrapTable('refresh');
   // $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });
   // $("#accountFeeUpdateModal").modal("show");
    

}

$('#mandateUpdateTable').on('check.bs.table', function (row, $element) {
    
    debugger 

    if ($element.approvalstatus == "New Copy Awaiting Approval")
    {
        swal({
            title: 'Update Mandate',
            text: 'Mandate has an existing entry awaiting approval',
            type: 'error',
            allowOutsideClick: false,
            allowEscapeKey: false
        }).then(function () {
            return;
        });

        return;
    }

    var mandateUpdateForm = $("#frmMandateUpdate");
    mandateUpdateForm.find("[name=mandateid]").val($element.mandateId);
    mandateUpdateForm.find("[name=mandatedescription]").val($element.description);
    mandateUpdateForm.find("[name=mandateType]").text($element.description);
    mandateUpdateForm.find("[name=fileid]").val($element.fileId);
    
    // swap out title text + hide/show buttons
    $("#mandateUpdateModal #title").text("Edit Mandate");
    $("#frmMandateUpdate #saveBtn").hide();
    $("#frmMandateUpdate #updateBtn").show();
    $("#frmMandateUpdate #doneBtn").hide();
    //$("#frmMandateUpdate #doneBtn").hide();

    var bottom_row = $("#mandateImage");


   // if ($element.length == 0) {
   //     var address_col = $("<div class='col-sm-12 col-md-6'></div>");
   //     address_col.append("<p>No Mandate Record Found.</p>");
   // } else {
   //     $.each($element, function (index, value) {
            //console.log(value.byte);
           // var address_col = $("<div class='col-sm-12 col-md-6'></div>");
           // address_col.append("<p>&nbsp;</p>");
           // address_col.append("<h6 class='detail-primary d-inline-block mb-3'>" + value.description + "</h6>");
           // address_col.append("<p>&nbsp;</p>");
            var html = [];
            html.push("<p><img src='data:" + $element.mime + ";base64," + $element.byte + " ' alt='Trulli' width='400' height='233'></p>");
            /*html.push(value.address + ", " + value.city + ", " + value.state.statename);
            html.push(", " + value.country.name + ".</p>");*/
           // address_col.append(html.join(""));
             bottom_row.append(html.join(""));
    //    });
   // }

    // form-enter/table-leave animation goes here
    $("#mandateUpdateTable").closest("div.row")
        .slideToggle({
            duration: utilities.animDuration,
            queue: false
        });
    $("#frmMandateUpdate").closest("div.row")
        .slideToggle({
            duration: utilities.animDuration,
            queue: false
        });


})



var utilities = {

    animDuration: 400,


    mandateDetailTableFormatter: function (index, row, detail) {
        detail.html("Loading...");
        var mandates, bvn, phones = [], emails = [];

        debugger

        bvn = row.bvn;
        $.when(
            $.ajax("../Account/LoadAccountMandate/" + row.casaaccountid)
                .then(function (response) {
                    mandates = response;
                    console.log(mandates);
                })
           /* $.ajax("../Profile/LoadCustomerEmails/" + row.customerid)
                .then(function (response) {
                    emails = response;
                }),
            $.ajax(url_path + "/Profile/LoadCustomerPhones/" + row.customerid)
                .then(function (response) {
                    phones = response;
                })*/
        ).then(function () {
            var top_row = $("<div class='row'></div>");
            var bottom_row = $("<div class='row'></div>");
            var bvn_col = $("<div class='col-sm-12 col-md-6'></div>");
            var phone_col = $("<div class='col-sm-12 col-md-6'></div>");
            var email_col = $("<div class='col-sm-12 col-md-6'></div>");
            
            //var address_col = $("<div class='col'></div>");

           
            if (mandates.length == 0 || mandates == false) {
                var mandates_col = $("<div class='col-sm-12 col-md-6'></div>");
                mandates_col.append("<p>No Mandate Record Found.</p>");
                bottom_row.append(mandates_col);
            } else {
                $.each(mandates, function (index, value) {
                    //console.log(value.byte);
                    var mandates_col = $("<div class='col-sm-12 col-md-6'></div>");
                    mandates_col.append("<p>&nbsp;</p>");
                    mandates_col.append("<h6 class='detail-primary d-inline-block mb-3'>" + value.description + "</h6>");
                    mandates_col.append("<p>&nbsp;</p>");
                    var html = [];
                    html.push("<p><img src='data:" + value.mime + ";base64," + value.byte + " ' alt='Mandates Image' width='300' height='233'></p>");
                    /*html.push(value.address + ", " + value.city + ", " + value.state.statename);
                    html.push(", " + value.country.name + ".</p>");*/
                    mandates_col.append(html.join(""));
                    bottom_row.append(mandates_col);
                });
            }

           /* phone_col.append("<h6 class='detail-primary d-inline-block mb-3'>PHONE</h6>");
            if (phones.length == 0) {
                phone_col.append("<p>No phone record.</p>");
            } else {
                $.each(phones, function (index, value) {
                    phone_col.append("<p><b>Phone</b>: " + value.phone + "</p>");
                });
            }

            email_col.append("<h6 class='detail-primary d-inline-block mb-3'>E-mail(s)</h6>");
            if (emails.length == 0) {
                email_col.append("<p>No e-mail record.</p>");
            } else {
                $.each(emails, function (index, value) {
                    email_col.append("<p><b>E-mail</b>: " + value.email + "</p>");
                });
            }

            bvn_col.append("<h6 class='detail-primary d-inline-block mb-3'>BVN</h6>");
            if (bvn == null) {
                bvn_col.append("<p>No BVN record.</p>");
            } else {

                bvn_col.append("<p><b>BVN</b>: " + bvn + "</p>");

            }*/

           // top_row.append(bvn_col, phone_col, email_col);
           // bottom_row.append(address_col);
            detail.empty();
            detail.append(top_row, bottom_row);
        });
    },
    showNewAddFrm: function () {
        // clear form
        $("#frmAddressUpdate").trigger("reset");
        $("#frmAddressUpdate select").val(null)
            .change();

        // swap out title text + hide/show buttons
        $("#addressUpdateModal #title").text("Add New Address");
        $("#frmAddressUpdate #saveBtn").show();
        $("#frmAddressUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#addressUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmAddressUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    /*deleteMandateBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='utilities.removeMandate(" + row.tracker + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    deleteRefereeBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='utilities.removeReferee(" + row.tracker + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    deleteMandateUpdateBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='deleteMandateUpdate(" + row.mandateid + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    deleteRefereeUpdateBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='deleteRefereeUpdate(" + row.refereeid + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    productNameFormatter: function (value) {
        var name = null;
        name = productData[value];
        if (!name) return "-";
        return name;
    },*/
    dropDownFormatter: function (value, row) {
        //debugger
        
        return [
            "<div class='dropdown'>",
            "<button class='btn btn-warning btn-icon' ",
            "data-toggle='dropdown' type='button'>",
            "<i class='now-ui-icons ui-2_settings-90'></i>",
            "</button>",
            "<div class='dropdown-menu dropdown-menu-right'>",
            "<h6 class='dropdown-header'>Maintain</h6>",
            "<a class='dropdown-item'",
            " onclick='mandateUpdate(" + row.casaaccountid + ")'>",
            "Mandate Maintenance",
            "</a>",
            "<a class='dropdown-item'",
            " onclick='productConversionHandler(" + row.casaaccountid + ")'>",
            "Product Conversion",
            "</a>",
            "<a class='dropdown-item'",
            " onclick='handleRefereeUpdate(" + row.casaaccountid + ")'>",
            "Refree Maintenance",
            "</a>",
            "<a class='dropdown-item'",
            " onclick='feeMaintenanceHandler(" + row.casaaccountid + ")'>",
            "Account Fee Maintenance",
            "</a>",
            "</div>",
            "</div>"
        ].join("");
    },
    editMandateBtnFormatter: function (val, row, index) {
       // debugger

        mandateRowObject = row;

        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populateMandateFrm()'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    populateMandateFrm: function () {

        var $table = $('#mandateUpdateTable')
        console.log('getSelections: ' + JSON.stringify($table.bootstrapTable('getSelections')));

        debugger

      //  var row = $("#mandateUpdateTable")
      //      .bootstrapTable("getRowByUniqueId", mandateid);

        var mandateUpdateForm = $("#frmMandateUpdate");
        mandateUpdateForm.find("[name=mandateid]").val(mandateId);
        mandateUpdateForm.find("[name=mandatedescription]").val(description);
        mandateUpdateForm.find("[name=fileid]").val(description);
        
        mandateUpdateForm.find("[name=mandateType]").text(description);

        // Populate individual form fields
        /*var addressForm = $("#frmAddressUpdate");
        
        addressForm.find("[name=address]").val(row.address);
        addressForm.find("[name=addresstypeid]")
            .val(row.addresstypeid).change();
        addressForm.find("[name=city]").val(row.city);
        addressForm.find("[name=stateid]")
            .val(row.stateid).change();
        addressForm.find("[name=countryid]")
            .val(row.countryid).change();*/

        // swap out title text + hide/show buttons
        $("#mandateUpdateModal #title").text("Edit Mandate");
        $("#frmMandateUpdate #saveBtn").hide();
        $("#frmMandateUpdate #updateBtn").show();

        // form-enter/table-leave animation goes here
        $("#mandateUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmMandateUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    showMandateTable: function () {
        // animations + changes
        $("#mandateUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmMandateUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
       // $("#addressUpdateModal #title").text("Customer Phone(s)");
        $("#mandateImage").empty();
        // clear form values
        $("#frmMandateUpdate").trigger("reset");

    },
    updateWizardHeader: function (container) {
        $(container + " .headerAcctDetails")
           /* .text(UpdateAccount.surname + " "
                + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                + UpdateCustomer.customercode);*/
            .text("Account Number: " + UpdateAccount.accountnumber
                );
    },
    updateWizardHeaderReferee: function (container) {
        $(container + " .headerrefereeDetails")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("Account Number: " + UpdateAccount.accountnumber
            );
    },
    updateWizardHeaderProductConversion: function (container) {
        $(container + " .headerProductConversionDetails")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("Account Number: " + UpdateAccount.accountnumber
            );
    },

    updateWizardHeaderProductConversion2: function (container) {
        $(container + " .headerProductConversionDetails2")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("Account Product Name: " + UpdateAccount.productName
            );
    },

    updateWizardHeaderFeeMaintenance: function (container) {

       // debugger

        $(container + " .headerAcctFeeDetails")
            /* .text(UpdateAccount.surname + " "
                 + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                 + UpdateCustomer.customercode);*/
            .text("CASA Account Number: " + casaaccountNumber
            );
    },
    
    updateMandate: function () {
        debugger
        var form = $("#frmMandateUpdate");
        if (!form.valid()) return;

        swal({
            title: "Are you sure?",
            text: "Mandate data will be updated",
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

                    var form_array = form.serializeArray();
                    // remove empty entries
                    form_array = $.map(form_array, function (item) {
                        if ($.trim(item.value).length !== 0)
                            return item;
                        return null;
                    });

                    // flatten form
                    var form_data = {};
                    $.each(form_array, function (index, item) {
                        form_data[item.name] = item.value;
                    });

                    var mandateUpdateImage = form.find("input[name=mandate-image]").get(0).files;
                    

                    var form_bag = new FormData();
                    form_bag.append("Data", JSON.stringify(form_data));
                    if (mandateUpdateImage.length) {
                        form_bag.append("Mandate", mandateUpdateImage[0]);
                    }

                    var id = form.find("[name=mandatedescription]").val();
                    var fileid = form.find("[name=fileid]").val();
                    var mandateid = form.find("[name=mandateid]").val();
                    
                    // send ajax request
                    $.ajax("../Account/AddMandateUpdate/" +
                        id + "/?fileid=" + fileid + "&mandateid=" + mandateid ,
                        {
                            method: "POST",
                            contentType: false,
                            processData: false,
                            data: form_bag
                        }).then(function (response) {
                            console.log(response);
                            $("#mandateImage").empty();
                            var bottom_row = $("#mandateImage");

                            var html = [];
                            html.push("<p><img src='data:" + response.mime + ";base64," + response.byte + " ' alt='Mandate Image' width='400' height='233'></p>");
                            
                            bottom_row.append(html.join(""));

                            
                            $("#mandateUpdateTable")
                                .bootstrapTable('refresh', {
                                    url: '../Account/LoadAccountMandateMaintenance/' + casaaccountNumber
                                });

                            $("#frmMandateUpdate #doneBtn").show();
                            // refresh data-table
                           // $("#mandate-update-data-table")
                           //     .bootstrapTable("load", response);
                            
                            swal({
                                title: "Update Mandate",
                                text: "Account Mandate succesfully sent for Approval",
                                type: "success",
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                
                                
                                // unfreeze save button
                                //$(button).removeAttr("disabled");
                                // Clear form + return to table
                               // utilities.showMandateUpdateTable();
                               // form.trigger("reset");
                               // form.find("select").val(null)
                               //     .trigger("change"); // for s
                            });

                           
                        }, function (error) {
                            swal({
                                title: 'Update Mandate',
                                text: 'An error was encountered while adding Mandate',
                                type: 'error',
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                // unfreeze save button
                               // $(button).removeAttr("disabled");
                            });
                        });
                }
            },
            function (isRejected) {
                return;
            }

        );


    },

    showNewRefreeFrm: function () {
        // clear form
        $("#frmrefereeUpdate").trigger("reset");
        $("#frmrefereeUpdate select").val(null)
            .change();

        // swap out title text + hide/show buttons
        $("#refereeUpdateModal #status").text("Add New Referee");
        $("#frmrefereeUpdate #saveBtn").show();
        $("#frmrefereeUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#refereeUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmrefereeUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },

    editRefereeBtnFormatter: function (val, row, index) {


        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populateRefereeFrm(" + row.refereeid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");


    },

    populateRefereeFrm: function (refereeid) {

        debugger
        var row = $("#refereeUpdateTable")
            .bootstrapTable("getRowByUniqueId", refereeid);
        if (row.approvalstatus == "Pending" || row.approvalstatus == "New Copy Sent for Approval") {
        // Populate individual form fields

            swal({
                title: 'Update Referee',
                text: 'Referee has an existing entry awaiting approval',
                type: 'error',
                allowOutsideClick: false,
                allowEscapeKey: false
            }).then(function () {
                return;
            });

        

        } else {
            var refereeForm = $("#frmrefereeUpdate");
            refereeForm.find("[name=casaaccountid]").val(row.casaaccountid);
            refereeForm.find("[name=refereeid]").val(row.refereeid);
            refereeForm.find("[name=fullname]").val(row.fullname);
            refereeForm.find("[name=address]").val(row.address);
            refereeForm.find("[name=phone]").val(row.phone);
            refereeForm.find("[name=city]").val(row.accountno);
            refereeForm.find("[name=relationship]").val(row.relationship);
            refereeForm.find("[name=accountname]").val(row.accountname);
            refereeForm.find("[name=accountno]").val(row.accountno);
            refereeForm.find("[name=bankid]").val(row.bankid).change();
            refereeForm.find("[name=bankaddress]").val(row.bankaddress);
            refereeForm.find("[name=datecreated]").val(row.datecreated);
            //.find("[name=countryid]").val(row.countryid).change();
            debugger
            // swap out title text + hide/show buttons
            $("#refereeUpdateModal #status").text("Edit Referee");
            $("#frmrefereeUpdate #saveBtn").hide();
            $("#frmrefereeUpdate #updateBtn").show();

            // form-enter/table-leave animation goes here
            $("#refereeUpdateTable").closest("div.row")
                .slideToggle({
                    duration: utilities.animDuration,
                    queue: false
                });
            $("#frmrefereeUpdate").closest("div.row")
                .slideToggle({
                    duration: utilities.animDuration,
                    queue: false
                });

        }

    },
    showRefereeTable: function () {
        // animations + changes
        $("#refereeUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmrefereeUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
       // $("#refereeUpdateModal #title").text("Customer Phone(s)");
        $("#refereeUpdateModal #status").text(" ");
        // clear form values
        $("#frmrefereeUpdate").trigger("reset");

    },
    addNewReferee: function () {
        debugger
        var form = $("#frmrefereeUpdate");
        if (!form.valid()) return;

        swal({
            title: "Are you sure?",
            text: "Referee data will be submitted",
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
                   // $(button).attr("disabled", "true");

                    var form_array = form.serializeArray();
                    // remove empty entries
                    form_array = $.map(form_array, function (item) {
                        if ($.trim(item.value).length !== 0)
                            return item;
                        return null;
                    });

                    // flatten form
                    var form_data = {};
                    $.each(form_array, function (index, item) {
                        form_data[item.name] = item.value;
                    });

                    var document = form.find("input[name=referee-file]").get(0).files[0];
                    var form_bag = new FormData();
                    form_bag.append("Document", document);
                    form_bag.append("Data", JSON.stringify(form_data));

                    // send ajax request
                    $.ajax(
                        "../Account/AddAccountReferee/" +
                        UpdateAccount.casaaccountid + "/?sendall=true",
                        {
                            method: "POST",
                            contentType: false,
                            processData: false,
                            data: form_bag
                        }).then(function (response) {
                            // refresh data-table
                            $("#refereeUpdateTable")
                                .bootstrapTable("load", response);
                            swal({
                                title: "Add Referee",
                                text: "Account referee succesfully added",
                                type: "success",
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                // unfreeze save button
                               // $(button).removeAttr("disabled");
                                // Clear form + return to table
                                utilities.showRefereeUpdateTable();
                                form.trigger("reset");
                                form.find("select").val(null)
                                    .trigger("change"); // for select2
                            });
                        }, function (error) {
                            swal({
                                title: 'Add Referee',
                                text: 'An error was encountered while adding new referee',
                                type: 'error',
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                // unfreeze save button
                               // $(button).removeAttr("disabled");
                            });
                        });
                }
            },
            function (isRejected) {
                return;
            }
        );
    },
    updateRefereeInfo: function () {

        debugger
        var form = $("#frmrefereeUpdate");
        if (!form.valid()) return;

        swal({
            title: "Are you sure?",
            text: "Referee data will be Updated",
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
                   // $(button).attr("disabled", "true");

                    var form_array = form.serializeArray();
                    // remove empty entries
                    form_array = $.map(form_array, function (item) {
                        if ($.trim(item.value).length !== 0)
                            return item;
                        return null;
                    });

                    // flatten form
                    var form_data = {};
                    $.each(form_array, function (index, item) {
                        form_data[item.name] = item.value;
                    });

                    var document = form.find("input[name=referee-file]").get(0).files[0];
                    var form_bag = new FormData();
                    form_bag.append("Document", document);
                    form_bag.append("Data", JSON.stringify(form_data));

                    // send ajax request
                    $.ajax(
                        "../Account/UpdateAccountReferee/" +
                        UpdateAccount.casaaccountid + "/?sendall=true",
                        {
                            method: "POST",
                            contentType: false,
                            processData: false,
                            data: form_bag
                        }).then(function (response) {
                            // refresh data-table
                            $("#refereeUpdateTable")
                                .bootstrapTable("load", response);
                            swal({
                                title: "Update Referee",
                                text: "Account referee updated sucessfully",
                                type: "success",
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                // unfreeze save button
                                //$(button).removeAttr("disabled");
                                // Clear form + return to table
                                utilities.showRefereeUpdateTable();
                                form.trigger("reset");
                                form.find("select").val(null)
                                    .trigger("change"); // for select2
                            });
                        }, function (error) {
                            swal({
                                title: 'Add Referee',
                                text: 'An error was encountered while adding new referee',
                                type: 'error',
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(function () {
                                // unfreeze save button
                                $(button).removeAttr("disabled");
                            });
                        });
                }
            },
            function (isRejected) {
                return;
            }
        );

    },
    showRefereeUpdateTable: function () {
        // form-leave/table-enter animation
        $("#refereeUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmrefereeUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Show wizard nav buttons
        $("#frmrefereeUpdate").closest(".card-wizard")
            .find(".card-footer").show();
    },

    editEmailBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populateEmailForm(" + row.emailcontactid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    populateEmailForm: function (emailid) {
        var row = $("#emailUpdateTable")
            .bootstrapTable("getRowByUniqueId", emailid);

        // Populate individual form fields
        var emailForm = $("#frmEmailUpdate");
        emailForm.find("[name=emailcontactid]").val(row.emailcontactid);
        emailForm.find("[name=customerid]").val(row.customerid);
        emailForm.find("[name=email]").val(row.email);

        // swap out title text + hide/show buttons
        $("#emailUpdateModal #title").text("Edit E-mail");
        $("#frmEmailUpdate #saveBtn").hide();
        $("#frmEmailUpdate #updateBtn").show();

        // form-enter/table-leave animation goes here
        $("#emailUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmEmailUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    showNewEmailFrm: function () {
        // clear form
        $("#frmEmailUpdate").trigger("reset");
        debugger
        // swap out title text + hide/show buttons
        $("#emailUpdateModal #title").text("Add New E-mail");
        $("#frmEmailUpdate #saveBtn").show();
        $("#frmEmailUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#emailUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmEmailUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    updateLinkedFees2: function () {

        debugger;
        var $table = $('#productMappingFeesTable');

        //casaRowContent.productName
        casaaccountNumber = casaRowContent.accountnumber;
        var selectionData = $table.bootstrapTable('getAllSelections');
        

        //productFeeListOriginal = [];
        //productFeeListIdOriginal = [];
        
        //productFeeListExtra = [];
        //productFeeListIdExtra = [];

        console.log(productFeeListExtra);

        productFeeListNew = [];
        var newselectionData = [];
        $.each(selectionData, function (index, itemData) {

            if (!productFeeListOriginal.includes(itemData.pdFeesId)) {
                productFeeListNew.push(itemData.pdFeesId);
                newselectionData.push(itemData);
            }

        });

       
        /*$.each(selectionData, function (index, itemData) {

            if (!productFeeListIdOriginal.includes(itemData.PdFeesId)) {
                newselectionData.push(itemData);
            }

        });*/

        console.log(newselectionData);

        var counter = 0;
       // $.each(newselectionData, function (index, itemData) {
        $.each(productFeeListExtra, function (index, itemData) {
            debugger;

             console.log(itemData);
           

            //   if (productFeeListId.includes(itemData.PdFeesId) && productFeeListIdNew.includes(itemData.PdFeesId)) {
            if (productFeeListExtra.includes(itemData) && productFeeListNew.includes(itemData)) {


                console.log("Do Nothing");
                console.log(itemData);
            }
            //else if (!productFeeListId.includes(itemData.PdFeesId) && productFeeListIdNew.includes(itemData.PdFeesId)) {
            else if (!productFeeListExtra.includes(itemData) && productFeeListNew.includes(itemData)) {

                console.log("Insert Into Database");

                //$.ajax({
                //    url: 'ProductMapping/AddProductFeesList',
                //    type: 'POST',
                //    data: {
                //        Id: 1, PdFeesId: itemData.PdFeesId, productCode: productId, PdFeesName: itemData.PdFeesName,
                //        PdRate: itemData.PdRate
                //    },
                //    success: function (data) {
                //        $table.bootstrapTable('refresh');
                //        swal({ title: 'Add Fees to Product', text: 'Product Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () { clearFee(); });
                        
                //        $('#ddlProductname').val(null).trigger('change');
                //    },
                //    error: function (e) {
                //        swal({ title: 'Fee Mapping', text: 'Fee Mapping to Product encountered an error', type: 'error' }).then(function () { clearFee(); });
                        
                //    }
                //});

                console.log(itemData);

                // } else if (productFeeListId.includes(itemData.PdFeesId) && !productFeeListIdNew.includes(itemData.PdFeesId)) {
            } else if (productFeeListExtra.includes(itemData) && !productFeeListNew.includes(itemData)) {

                console.log("Delete from Database");

                $.ajax({
                    url: '../Account/DeleteProductFeesList',
                    type: 'POST',
                    data: {
                        Id: productFeeListIdExtra[counter], PdFeesId: "", productId: productId, PdFeesName: "",
                        PdRate: ""
                    },
                    success: function (data) {
                        $table.bootstrapTable('refresh');
                        swal({ title: 'Add Fees to Product', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () {  });
                        
                        $('#ddlProductname').val(null).trigger('change');
                    },
                    error: function (e) {
                        swal({ title: 'Fee Mapping', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'error' }).then(function () {  });
                        
                    }
                });

                console.log(itemData);
                console.log(productFeeListIdExtra[counter]);
            }

            counter++;
        });


        counter = 0;
      //  $.each(productFeeListNew, function (index, itemData) {
        $.each(newselectionData, function (index, itemData) {
            debugger;

            console.log(itemData);

            if (productFeeListNew.includes(itemData.pdFeesId) && productFeeListExtra.includes(itemData.pdFeesId)) {
                //  if (productFeeListId.includes(itemData) && productFeeListIdNew.includes(itemData)) {

                console.log("Do Nothing");
                console.log(itemData);
            }
            else if (productFeeListNew.includes(itemData.pdFeesId) && !productFeeListExtra.includes(itemData.pdFeesId)) {
                // else if (!productFeeListId.includes(itemData) && productFeeListIdNew.includes(itemData)) {

                console.log("Insert Into Database");
                $.ajax({
                    url: '../Account/AddProductFeesList',
                    type: 'POST',
                    data: {
                        Id: 1, PdFeesId: newselectionData[counter].pdFeesId, casaAccountId: casaAccountId, productId: productId, PdFeesName: newselectionData[counter].pdFeesName,
                        PdRate: newselectionData[counter].pdRate
                    },
                    success: function (data) {
                        $table.bootstrapTable('refresh');
                        swal({ title: 'Add Fees to Product', text: 'CASA Fees Addition/Deletion Completed successfully!', type: 'success' }).then(function () {  });

                       // $('#ddlProductname').val(null).trigger('change');
                    },
                    error: function (e) {
                        swal({ title: 'Fee Mapping', text: 'CASA Fees Addition/Deletion encountered an error', type: 'error' }).then(function () {  });

                    }
                });

                console.log(itemData);

            } else if (!productFeeListNew.includes(itemData.pdFeesId) && productFeeListExtra.includes(itemData.pdFeesId)) {
                // } else if (productFeeListId.includes(itemData) && !productFeeListIdNew.includes(itemData)) {

                console.log("Delete from Database");
                console.log(itemData);
            }

              counter++;
        });


        debugger

       /* casaRowContent = $("#data-table").bootstrapTable('getRowByUniqueId', casaAccountId);

        casaaccountNumber = casaRowContent.accountnumber;

        var $table = $('#productMappingFeesTable');

         $table.bootstrapTable('uncheckAll');

        productFeeList = [];
        productFeeListId = [];
        productFeeListOriginal = [];
        productFeeListIdOriginal = [];
        productFeeListIdExtra = [];
        productFeeListExtra = [];
        $.ajax({
            type: 'GET',
            url: '../Account/GetFeeName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
            success: function (result) {
                console.log(result);
                $.each(result, function (index, value) {

                    console.log(value.feeId);
                    productFeeListId.push(value.id);
                    productFeeList.push(value.feeId);
                    productFeeListOriginal.push(value.feeId);
                    productFeeListIdOriginal.push(value.id);

                });

                console.log(productFeeListId);
                console.log(productFeeList);
                $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });

            },
        });

        $.ajax({
            type: 'GET',
            url: '../Account/GetFeeExtraName?productName=' + casaRowContent.productName + '&casaAccountId=' + casaAccountId,
            success: function (result) {
                console.log(result);
                $.each(result, function (index, value) {

                    console.log(value.feeId);
                    productFeeListId.push(value.id);
                    productFeeList.push(value.feeId);
                    productFeeListIdExtra.push(value.id);
                    productFeeListExtra.push(value.feeId);
                });

                console.log(productFeeListId);
                console.log(productFeeList);
                $table.bootstrapTable('checkBy', { field: 'pdFeesId', values: productFeeList });

            },
        });*/

        $("#accountFeeUpdateModal").modal("hide");

    },
    updateProduct: function () {
        debugger
        var $table = $('#productListTable');
        alert('getSelections: ' + JSON.stringify($table.bootstrapTable('getSelections')));

       

    },
    /*approvalStatusFormatter: function (value) {

        debugger
        
        $.ajax("../Account/LoadAccountMandateMaintenanceApprovalStatus/" + value)
            .then(function (response) {

              //  if (response) {
                    console.log(response)
                approvalStatus = response;

              //  } 
            });
      
        //if (value == 1) {
        console.log(approvalStatus)

        return approvalStatus;

        //} else {
        //    return "Pending";
        //}
    },*/

   /* clearWizard: function () {
        clear();
        $('#account-data-table').bootstrapTable('refresh', {
            silent: true
        });
        // Clear data-tables' objects
        $("#mandate-data-table").bootstrapTable("removeAll");
        $("#referee-data-table").bootstrapTable("removeAll");
        $('#wizardModal').modal('hide');
        // Unfreeze finish button
        $("#accountWizard .btn-finish").removeAttr("disabled");
    },
    clearUpdateWizard: function () {
        clear();
        $('#account-data-table').bootstrapTable('refresh', {
            silent: true
        });
        // Clear update data-tables
        $("#mandate-update-data-table").bootstrapTable("removeAll");
        $("#referee-update-data-table").bootstrapTable("removeAll");
        $('#wizardModal').modal("hide");
        // Unfreeze finish button
        $("#accountUpdateWizard .btn-finish").removeAttr("disabled");
    },
    showMandateForm: function () {
        // TODO: clear mandate form (trigger reset)

        // form-enter/table-leave animation
        $("#mandate-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmMandate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Hide wizard nav buttons
        $("#frmMandate").closest(".card-wizard").find(".card-footer").hide();
    },
    showMandateUpdateForm: function () {
        // TODO: clear mandate form (trigger reset)

        // form-enter/table-leave animation
        $("#mandate-update-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#mandate-update-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Hide wizard nav buttons
        $("#mandate-update-form").closest(".card-wizard").find(".card-footer").hide();
    },
    showRefereeForm: function () {
        // form-enter/table-leave animation
        $("#referee-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#referee-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Hide wizard nav buttons
        $("#referee-form").closest(".card-wizard")
            .find(".card-footer").hide();
    },
    showRefereeUpdateForm: function () {
        // form-enter/table-leave animation
        $("#referee-update-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#referee-update-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Hide wizard nav buttons
        $("#referee-update-form").closest(".card-wizard")
            .find(".card-footer").hide();
    },
    showMandateTable: function () {
        // form-leave/table-enter animation
        $("#mandate-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmMandate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Show wizard nav buttons
        $("#frmMandate").closest(".card-wizard").find(".card-footer").show();

        // TODO: clear mandate form (trigger reset)
    },
    showMandateUpdateTable: function () {
        // form-leave/table-enter animation
        $("#mandate-update-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#mandate-update-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Show wizard nav buttons
        $("#mandate-update-form").closest(".card-wizard").find(".card-footer").show();
    },
    showRefereeTable: function () {
        // form-leave/table-enter animation
        $("#referee-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#referee-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Show wizard nav buttons
        $("#referee-form").closest(".card-wizard")
            .find(".card-footer").show();
    },
    showRefereeUpdateTable: function () {
        // form-leave/table-enter animation
        $("#referee-update-data-table").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#referee-update-form").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });

        // Show wizard nav buttons
        $("#referee-update-form").closest(".card-wizard")
            .find(".card-footer").show();
    },
    previewUpload: function (el) {
        if (!el.files.length) {
            $(el).parent(".btn-file").nextAll('.image-box').addClass("d-none");
            return;
        }
        var blob = window.URL.createObjectURL(el.files[0]);
        $(el).parent(".btn-file").nextAll('.image-box').removeClass("d-none");
        $(el).parent(".btn-file").nextAll('.image-box')
            .css('background-image', 'url(' + blob + ')');
    },
    addMandate: function () {
        var form = $("#frmMandate");
        if (!form.valid()) {
            return;
        }

        var form_array = form.serializeArray();

        // remove empty entries
        form_array = $.map(form_array, function (item) {
            if ($.trim(item.value).length !== 0)
                return item;
            return null;
        });

        // flatten form
        var form_data = {};
        $.each(form_array, function (index, item) {
            form_data[item.name] = item.value;
        });

        var passport = form.find("input[name=mandate-passport]").get(0).files;
        var signature = form.find("input[name=mandate-signature]").get(0).files;
        var thumbprint = form.find("input[name=mandate-thumbprint]").get(0).files;

        var form_bag = new FormData();
        if (passport.length) {
            form_bag.append("passport", passport[0]);
        }
        if (signature.length) {
            form_bag.append("signature", signature[0]);
        }
        if (thumbprint.length) {
            form_bag.append("thumbprint", thumbprint[0]);
        }

        // set form data, increment counter + set fake id (tracker)
        $("#mandate-data-table")
            .bootstrapTable(
                "append", {
                tracker: ++mandate_count,
                data: form_data,
                images: form_bag
            });

        // Clear form + return to table
        form.trigger("reset");
        form.find("select").val(null).trigger("change"); // for select2
        utilities.showMandateTable();
    },
    addReferee: function () {
        var form = $("#referee-form");
        if (!form.valid()) {
            return;
        }

        var form_array = form.serializeArray();

        // remove empty entries
        form_array = $.map(form_array, function (item) {
            if ($.trim(item.value).length !== 0)
                return item;
            return null;
        });

        // flatten form
        var form_data = {};
        $.each(form_array, function (index, item) {
            form_data[item.name] = item.value;
        });

        var document = form.find("input[name=referee-file]").get(0).files[0];
        var form_bag = new FormData();
        form_bag.append("Document", document);

        // set form data, increment counter + set fake id (tracker)
        $("#referee-data-table")
            .bootstrapTable(
                "append", {
                tracker: ++referee_counter,
                data: form_data,
                form: form_bag
            });

        // Clear form + return to table
        form.trigger("reset");
        form.find("select").val(null).trigger("change"); // for select2
        utilities.showRefereeTable();

    },
    removeMandate: function (tracker) {
        $("#mandate-data-table")
            .bootstrapTable("remove", {
                field: "tracker",
                values: [tracker]
            });
    },
    removeReferee: function (tracker) {
        $("#referee-data-table")
            .bootstrapTable("remove", {
                field: "tracker",
                values: [tracker]
            });
    },
    objectAppendHelper: function (item, container, append = true) {
        if ($.trim(item.value).length !== 0) {
            if (append) {
                container[item.name] = item.value;
            } else {
                var model = {};
                model[item.name] = item.value;
                return model;
            }
        }
        return null;
    },*/
};