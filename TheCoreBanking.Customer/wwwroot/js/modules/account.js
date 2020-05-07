debugger
var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}
if (window.location.href == "http://localhost:1659/Account") {

   // alert("VALID");
}

console.log(url_path + "/../AddAccount");
var departments, productData = {}, productDataArray = [], updateAccount, iscurrentaccount = false;
var customer, product, mandate_count = 0, referee_counter = 0;

$(document).ready(function () {
    //debugger
    initDataTable();
    setDataTableEventHandlers();
    initDatePicker();
    initSelectTwoConfig();
    initFormValidations();
    initWizard();
    $(".modal").perfectScrollbar();
});

function openModal() {
    // show/hide mandate form/table
    $("#frmMandate").closest("div.row").hide();
    $("#mandate-data-table").closest("div.row").show();

    // show/hide referee form/table
    $("#referee-form").closest("div.row").hide();
    $("#referee-data-table").closest("div.row").show();

    // Show wizard nav buttons
    $("#frmMandate").closest(".card-wizard").find(".card-footer").show();

    // Reset wizard & show modal
    $('#accountWizard').bootstrapWizard("resetWizard");
    $('#wizardModal').modal('show');
    $("#accountUpdateWizard").removeClass("active").hide();
    $("#accountWizard").addClass("active").show();
}

function clear() {
    $("#customer-data-table").bootstrapTable("uncheckAll");
    $("#product-data-table").bootstrapTable("uncheckAll");

    $(".wizard-container form select").val(null)
        .trigger("select2:unselect")
        .trigger("change");
    $(".wizard-container form").trigger("reset");
}

function initDataTable() {

    debugger

    /*$.ajax(url_path + "/LoadAccounts")
        .then(function (response) {
            $("#account-data-table").bootstrapTable('showLoading');
            $('#//').bootstrapTable('load', response);
            $("#product-data-table").bootstrapTable('hideLoading');*/
           // debugger
          //  $.each(response, function (index, value) {
          //      productData[value.id] = value.productName;
          //  });
            // Let data table load its data / refresh with url
           // $("#account-data-table")
           //     .bootstrapTable("refresh", {
           //         url: url_path + "/LoadAccounts"
           //     });
           // $('#product-data-table')
            //    .bootstrapTable('load', response);
     //   });


    $.ajax(url_path + "/LoadProducts")
        .then(function (response) {

            console.log(response);

            $("#product-data-table").bootstrapTable('hideLoading');

            $('#product-data-table').bootstrapTable('load', response);

            var counter = 0;

            $.each(response, function (index, value) {

              //  array.splice(2, 0, "three");

                productData[value.id] = value.productName;
                console.log(productData);
            });

        });

    
}

function saveAccount(postdata) {
    // build referees & signatories (when present)
    debugger
    console.log(postdata);

    var mandate_data = $("#mandate-data-table").bootstrapTable("getData");
    var referee_data = $("#referee-data-table").bootstrapTable("getData");
    if (mandate_data.length !== 0) {
        mandate_data = $.map(mandate_data, function (item, index) {
            var formData = item.images;
            formData.append("data", JSON.stringify(item.data));
            return formData;
        });
    }
    if (referee_data.length !== 0) {
        referee_data = $.map(referee_data, function (item, index) {
            item.form.append("Data", JSON.stringify(item.data));
            return item.form;
        });
    }

    debugger

    

    $.ajax(url_path +  "/AddAccount", {
        data: JSON.stringify(postdata),
        method: "POST",
        contentType: "application/json"
    }).then(
        function (response) {
            function accountSuccess() {
                swal({
                    title: "Open Account",
                    text: "Account saved successfully!",
                    type: 'success',
                    allowOutsideClick: false,
                    allowEscapeKey: false
                }).then(utilities.clearWizard);
            }
            if (mandate_data.length || referee_data.length) {
                var ajaxRequests = [];
                if (mandate_data.length !== 0) {
                    // run and store mandate ajax requests
                    ajaxRequests.push.apply(ajaxRequests, $.map(mandate_data,
                        function (item) {
                            return $.ajax(
                                url_path + "/AddAccountSignatory/" + response,
                                {
                                    method: "POST",
                                    contentType: false,
                                    processData: false,
                                    data: item,
                                }
                            );
                        }
                    ));
                    
                }
                if (referee_data !== 0) {
                    // run and store referee ajax requests
                    ajaxRequests.push.apply(ajaxRequests, $.map(referee_data,
                        function (item) {
                            return $.ajax(
                                url_path + "/AddAccountReferee/" + response,
                                {
                                    method: "POST",
                                    contentType: false,
                                    processData: false,
                                    data: item
                                }
                            );
                        }
                    ));
                }

                // observe all requests
                $.when.apply($, ajaxRequests)
                    .then(function (response) {
                        accountSuccess();
                    }, function (error) {
                        swal({
                            title: "Open Account",
                            text:
                                "Account data saved successfully but one" +
                                " or more signatory/referee data weren't submitted." +
                                " Edit the account signatories to observe specifics.",
                            type: 'warning',
                            allowOutsideClick: false,
                            allowEscapeKey: false
                        }).then(utilities.clearWizard);
                    });
            } else {
                accountSuccess();
            }
        },
        function (error) {
            swal({
                title: 'Open Account',
                text: 'Account submission encountered an error',
                type: 'error',
                allowOutsideClick: false,
                allowEscapeKey: false
            }).then(function () {
                // Unfreeze finish button
                $("#accountWizard .btn-finish").removeAttr("disabled");
            });
        }
    );
}

function editAccount(postdata) {
    $.ajax(url_path + "/UpdateAccount", {
        method: "POST",
        data: JSON.stringify(postdata),
        contentType: "application/json"
    }).then(
        function (response) {
            swal({
                title: "Update Account",
                text: "Account updated successfully!",
                type: 'success',
                allowOutsideClick: false,
                allowEscapeKey: false
            }).then(utilities.clearUpdateWizard);
        },
        function (error) {
            swal({
                title: 'Update Account',
                text: 'Account update encountered an error',
                type: 'error',
                allowOutsideClick: false,
                allowEscapeKey: false
            }).then(function () {
                // Unfreeze finish button
                $("#accountUpdateWizard .btn-finish").removeAttr("disabled");
            });
        }
    );
}

function addRefereeUpdate(button) {
    var form = $("#referee-update-form");
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
                $(button).attr("disabled", "true");

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
                    url_path + "/AddAccountReferee/" +
                    updateAccount.casaaccountid + "/?sendall=true",
                    {
                        method: "POST",
                        contentType: false,
                        processData: false,
                        data: form_bag
                    }).then(function (response) {
                        // refresh data-table
                        $("#referee-update-data-table")
                            .bootstrapTable("load", response);
                        swal({
                            title: "Add Referee",
                            text: "Account referee succesfully added",
                            type: "success",
                            allowOutsideClick: false,
                            allowEscapeKey: false
                        }).then(function () {
                            // unfreeze save button
                            $(button).removeAttr("disabled");
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
}

function deleteRefereeUpdate(refereeid) {
    if (!refereeid) return;

    swal({
        title: "Are you sure?",
        text: "Referee data will be deleted",
        type: "warning",
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
            $.ajax(
                url_path + "/DeleteAccountReferee/" + refereeid,
                { method: "POST" }
            ).then(
                function (response) {
                    // refresh data-table
                    $("#referee-update-data-table")
                        .bootstrapTable("load", response);
                    swal({
                        title: "Delete Referee",
                        text: "Account referee deleted succesfully",
                        type: "success",
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    });
                },
                function (error) {
                    swal({
                        title: 'Delete Referee',
                        text: 'An error was encountered while deleting referee',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    });
                }
            );
        },
        function (isRejected) { return; }
    );
}

function deleteMandateUpdate(mandateid) {
    if (!mandateid) return;

    swal({
        title: "Are you sure?",
        text: "Signatory data will be deleted",
        type: "warning",
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
            $.ajax(
                url_path + "/DeleteAccountMandate/" + mandateid,
                { method: "POST" }
            ).then(
                function (response) {
                    // refresh data-table
                    $("#mandate-update-data-table")
                        .bootstrapTable("load", response);
                    swal({
                        title: "Delete Signatory",
                        text: "Account signatory deleted succesfully",
                        type: "success",
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    });
                },
                function (error) {
                    swal({
                        title: 'Delete Signatory',
                        text: 'An error was encountered while deleting signatory',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    });
                }
            );
        },
        function (isRejected) { return; }
    );
}

function addMandateUpdate(button) {
    var form = $("#mandate-update-form");
    if (!form.valid()) return;

    swal({
        title: "Are you sure?",
        text: "Signatory data will be submitted",
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
                $(button).attr("disabled", "true");

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
                form_bag.append("Data", JSON.stringify(form_data));
                if (passport.length) {
                    form_bag.append("Passport", passport[0]);
                }
                if (signature.length) {
                    form_bag.append("Signature", signature[0]);
                }
                if (thumbprint.length) {
                    form_bag.append("Thumbprint", thumbprint[0]);
                } 

                // send ajax request
                $.ajax(
                    url_path + "/AddAccountSignatory/" +
                    updateAccount.casaaccountid + "/?sendall=true",
                    {
                        method: "POST",
                        contentType: false,
                        processData: false,
                        data: form_bag
                    }).then(function (response) {
                        // refresh data-table
                        $("#mandate-update-data-table")
                            .bootstrapTable("load", response);
                        swal({
                            title: "Add Signatory",
                            text: "Account signatory succesfully added",
                            type: "success",
                            allowOutsideClick: false,
                            allowEscapeKey: false
                        }).then(function () {
                            // unfreeze save button
                            $(button).removeAttr("disabled");
                            // Clear form + return to table
                            utilities.showMandateUpdateTable();
                            form.trigger("reset");
                            form.find("select").val(null)
                                .trigger("change"); // for select2
                        });
                    }, function (error) {
                        swal({
                            title: 'Add Signatory',
                            text: 'An error was encountered while adding new signatory',
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
}

function populateUpdate(row_data) {
    var account_form = $("#frmAccountUpdate");
    var referee_update_table = $("#referee-update-data-table");
    var mandate_update_table = $("#mandate-update-data-table");

    // account tab
    account_form.find("[name=accountname]").val(row_data.accountname);
    account_form.find("[name=interestrate]").val(row_data.interestrate);
    account_form.find("[name=postnostatusid]").val(row_data.postnostatusid).change();
    account_form.find("[name=mandate]").val(row_data.mandate);
    account_form.find("[name=productid]").val(row_data.productid);
    account_form.find("[name=accountofficerid]").val(row_data.accountofficerid).change();
    account_form.find("[name=relationshipofficerid]").val(row_data.relationshipofficerid).change();
    account_form.find("[name=relationshipmanagerid]").val(row_data.relationshipmanagerid).change();
    account_form.find("#product-name").val(utilities.productNameFormatter(row_data.productid));
    if (row_data.tblCustomeraccountservice[0].cardtypeid) {
        account_form.find("[name=cardtypeid]")
            .val(row_data.tblCustomeraccountservice[0].cardtypeid).change();
    }
    account_form.find("[name=nameoncard]")
        .val(row_data.tblCustomeraccountservice[0].nameoncard);
    if (row_data.tblCustomeraccountservice[0].statementfrequencyid) {
        account_form.find("[name=statementfrequencyid]")
            .val(row_data.tblCustomeraccountservice[0].statementfrequencyid).change();
    }
    account_form.find("[name=minbalance]")
        .val(row_data.tblCustomeraccountservice[0].minbalance);

    if (row_data.acctofficerdept) {
        account_form.find("[name=acctofficerdept]")
            .val(row_data.acctofficerdept).change();
    }

    if (row_data.accountofficerdeptid) {
        account_form.find("[name=accountofficerdeptid]")
            .val(row_data.accountofficerdeptid).change();
        // TODO: filter accountofficerid ddl & value
    }

    if (row_data.relationshipofficerdeptid) {
        account_form.find("[name=relationshipofficerdeptid]")
            .val(row_data.relationshipofficerdeptid).change();
        // TODO: filter relationship officer & manager ddl and values
    }

    if (row_data.tblCustomeraccountservice[0]
        .tblCustomeraccountstmntmedium.length) {
        account_form.find("[name=statementmediumid]")
            .val($.map(row_data.tblCustomeraccountservice[0]
                .tblCustomeraccountstmntmedium, function (item) {
                    return item.statementmediumid;
                }))
            .change();
    }
    if (row_data.tblCustomeraccountservice[0]
        .tblCustomeraccountbankingservice.length) {
        account_form.find("[name=bankingserviceid]")
            .val($.map(row_data.tblCustomeraccountservice[0]
                .tblCustomeraccountbankingservice, function (item) {
                    return item.bankingserviceid;
                }))
            .change();
    }

    debugger
   
    var countBoolean = false;

    account_form.find("[name=alertmediumid]").removeAttr("disabled");

    $("#approvalStatusInd").text(" ");

    if (row_data.tblCustomeraccountservice[0]) {

        $.ajax(url_path + "/LoadCustomerAccountAlertMedium/" + row_data.tblCustomeraccountservice[0].id)
            .then(function (response) {
                var count = 0;
                var countDisapproved = 0;
                console.log(response);

                account_form.find("[name=alertmediumid]")
                    .val($.map(response, function (item) {

                        if (item.isapproved == true && item.alertmediumid == 1 && item.isdeleted == false) {
                                account_form.find("[name=alertmediumid]").removeAttr("disabled");
                            $("#approvalStatusInd").text(" ");
                            
                                return item.alertmediumid;
                        } 

                        if (item.isapproved == true && item.alertmediumid == 2 && item.isdeleted == false) {
                            account_form.find("[name=alertmediumid]").removeAttr("disabled");
                            $("#approvalStatusInd").text(" ");
                            
                            return item.alertmediumid;
                        } 

                        if (item.isdisapproved == true && item.isapproved == false && item.alertmediumid == 1 && item.isdeleted == true) {
                            account_form.find("[name=alertmediumid]").removeAttr("disabled");
                            $("#approvalStatusInd").text(" ");
                            countDisapproved++;
                           // return item.alertmediumid;
                        }

                        if (item.isdisapproved == true && item.isapproved == false &&  item.alertmediumid == 2 && item.isdeleted == true) {
                            account_form.find("[name=alertmediumid]").removeAttr("disabled");
                            $("#approvalStatusInd").text(" ");

                           // return item.alertmediumid;
                            countDisapproved++;
                        } 

                        if (item.isapproved == false && item.isdisapproved == false && item.alertmediumid == 1 && item.isdeleted == true) {
                            //account_form.find("[name=alertmediumid]").attr("disabled", "true");
                            //$("#approvalStatusInd").text("* Pending Approval")
                            count++;
                        }

                        if (item.isapproved == false && item.isdisapproved == false &&  item.alertmediumid == 2 && item.isdeleted == true) {
                            //account_form.find("[name=alertmediumid]").attr("disabled", "true");
                            //$("#approvalStatusInd").text("* Pending Approval")
                            count++;
                        } 


                        }))
                    .change();

                if (count > 0) {
                    account_form.find("[name=alertmediumid]").attr("disabled", "true");
                    $("#approvalStatusInd").text("* Pending Approval");
                }

                if (countDisapproved > 0) {
                   // account_form.find("[name=alertmediumid]").attr("disabled", "true");
                    if (count > 0) {
                        $("#approvalStatusInd").text("* Last Transaction was Disapproved");
                    } else {
                        $("#approvalStatusInd").text(" ");
                        $("#approvalStatusInd").text("* Last Transaction was Disapproved");
                    }
                }

            });

    }
    //count++;
   

    /*if (row_data.tblCustomeraccountservice[0]
        .tblCustomeraccountalertmedium.length) {
        account_form.find("[name=alertmediumid]")
            .val($.map(row_data.tblCustomeraccountservice[0]
                .tblCustomeraccountalertmedium, function (item) {
                    if (item.isapproved == true) {
                        account_form.find("[name=alertmediumid]").removeAttr("disabled");
                        $("#approvalStatusInd").text(" ");
                        return item.alertmediumid;
                    } else {
                        account_form.find("[name=alertmediumid]").attr("disabled", "true");
                        $("#approvalStatusInd").text("* Pending Approval");
                    }
                }))
            .change();
    }*/

   // $("#outer").mouseenter(function () {
    
}

$("#frmAccountUpdate #UddlAlerts").mouseenter(function () {
    debugger
    $.notify({
        icon: "now-ui-icons travel_info",
        message: "Pending approval"
    }, {
        type: "danger",
        placement: {
            from: "top",
            align: "right"
        }
    });
});

$("#frmAccountUpdate #UddlAlerts").click(function () {
    alert("The paragraph was clicked.");

    $.notify({
        icon: "now-ui-icons travel_info",
        message: "Pending approval"
    }, {
        type: "danger",
        placement: {
            from: "top",
            align: "right"
        }
    });
});

function initUpdate(casaaccountid) {
    clear();

    debugger

    var row_data = $("#account-data-table")
        .bootstrapTable("getRowByUniqueId", casaaccountid);

    $.ajax(url_path + "/LoadAccountReferees/" + casaaccountid)
        .then(function (response) {
            $("#referee-update-data-table")
                .bootstrapTable("load", response);
        });

    $.ajax(url_path + "/LoadAccountMandates/" + casaaccountid)
        .then(function (response) {
            $("#mandate-update-data-table")
                .bootstrapTable("load", response);
        });

    // show/hide mandate form/table
    $("#mandate-update-form").closest("div.row").hide();
    $("#mandate-update-data-table").closest("div.row").show();
    // show/hide referee form/table
    $("#referee-update-form").closest("div.row").hide();
    $("#referee-update-data-table").closest("div.row").show();
    // Show wizard nav buttons
    $("#referee-update-form").closest(".card-wizard")
        .find(".card-footer").show();

    // update wizard header with account details
    $("#accountUpdateWizard").find(".account-header-details")
        .text(row_data.accountname + " - " + row_data.accountnumber);

    // Store update-casa-accountid
    updateAccount = {
        casaaccountid: casaaccountid,
        casaaccountserviceid: row_data.tblCustomeraccountservice[0].id,
        datetimecreated: row_data.datetimecreated,
        accountnumber: row_data.accountnumber,
        customerid: row_data.customerid,
        accountstatusid: row_data.accountstatusid
    };

    // populate wizard tabs
    populateUpdate(row_data);

    // Reset wizard & show modal
    $('#accountUpdateWizard').bootstrapWizard("resetWizard");
    
    $("#accountUpdateWizard").addClass("active").show();
    $("#accountWizard").removeClass("active").hide();
    $('#wizardModal').modal('show');
}

function setDataTableEventHandlers() {
    // Customer Data Table
    debugger
    $("#customer-data-table").on("check.bs.table", function (ev, row) {
        if (row.customerid) {
            $("#frmCustomer input[name=customerid]").val(row.customerid);
            var fullname = row.surname
                + (row.othernames ? " " + row.othernames : "")
                + (row.firstname ? " " + row.firstname : "");
            $("#frmAccount input[name=nameoncard]")
                .val(fullname);
            $("#frmAccount input[name=accountname]")
                .val(fullname);
            $("#cusAccType").text(row.customeraccounttype.name);
            $("#frmCustomer input[name=customercode]").val(row.customercode);
        }
    });
    $("#customer-data-table").on("uncheck.bs.table", function (ev, row) {
        $("#frmCustomer input[name=customerid]").val(null);
        $("#frmCustomer input[name=customercode]").val(null);
    });

    // Product Data Table
    $("#product-data-table").on("check.bs.table", function (ev, row) {
        if (row.id) {
            debugger
            $("#frmProduct input[name=productid]").val(row.id);
            $("#frmProduct input[name=productcode]").val(row.productCode);
            $("#prodType").text(row.productName);

            // Detect current account
            if (row.productType.pdType.toLowerCase()
                .indexOf("current account") >= 0) {
                iscurrentaccount = true;
            }
        }
    });
    $("#product-data-table").on("uncheck.bs.table", function (ev, row) {
        $("#frmProduct input[name=productid]").val(null);
        $("#frmProduct input[name=productcode]").val(null);
        $("#prodType").text("-");
        iscurrentaccount = false;
    });
}

function initDatePicker() {
    if ($(".datepicker").length != 0) {
        $(".datepicker").datetimepicker({
            format: "YYYY-MM-DD",
            icons: {
                time: "now-ui-icons tech_watch-time",
                date: "now-ui-icons ui-1_calendar-60",
                up: "fa fa-chevron-up",
                down: "fa fa-chevron-down",
                previous: "now-ui-icons arrows-1_minimal-left",
                next: "now-ui-icons arrows-1_minimal-right",
                today: "fa fa-screenshot",
                clear: "fa fa-trash",
                close: "fa fa-remove"
            }
        });
    }
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

    $("#frmCustomer").validate({
        messages: {
            customerid: {
                required: "You must select a customer to proceed",
            }
        }, ignore: false
    });

    if (!window.location.href == "http://localhost:1659/Account")
    { 
    $("#frmProduct").validate({
        messages: {
            productid: {
                required: "You must select a product to proceed",
            }
        },
        ignore: false
    });
    }

    $("#frmAccount, #frmAccountUpdate").each(function () {
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
    
    $("#referee-form, #referee-update-form").each(function () {
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

function initWizard() {
    $("#accountWizard").bootstrapWizard({
        'tabClass': 'nav nav-pills',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-previous',
        'finishSelector': '.btn-finish',

        onNext: function (tab, navigation, index) {
            var form = getTabForm(tab);
            if (!form.valid()) {
                return false;
            }
        },

        onInit: function (tab, navigation, index) {
            var $wizard = navigation.closest('.card-wizard');
            refreshAnimation($wizard, index);
        },

        onFinish: function (tab, navigation, index) {
            swal({
                title: "Are you sure?",
                text: "Account data will be submitted",
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
            }).then(function (isConfirm) {
                if (isConfirm) {
                    // freeze finish button
                    debugger
                    $("#accountWizard .btn-finish").attr("disabled", "true");

                    var formsArray = [];
                    var tabsArray = $(navigation)
                        .find("li:not(.d-none)")
                        .map(function () {
                            return getTabForm(this);
                        });
                    tabsArray = tabsArray.toArray();
                    // remove referee & mandate form
                    tabsArray.pop();
                    tabsArray.pop();
                    //debugger
                    $.each(tabsArray, function (index, value) {
                        formsArray.push(value.serializeArray());
                    });

                    // merge form arrays into one
                    formsArray = $.map(formsArray, function (arr) {
                        return arr;
                    });

                    // Add detected product type (current/savings)
                    formsArray.push(
                        {
                            name: "iscurrentaccount",
                            value: iscurrentaccount
                        }
                    );

                    // compile/extract form data into appropriate objects
                    var casa = {}, accountservice = {}, bankingservices = [], data = {},
                        alertmediums = [], statementmediums = [], model = null;
                    $.each(formsArray, function (index, item) {
                        // skip data-table redundant fields
                        if (item.name == "btSelectItem") {
                            return;
                        }

                        // extract account-services data if not empty
                        if (item.name == "cardtypeid") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        //debugger
                        if (item.name == "nameoncard") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        if (item.name == "statementfrequencyid") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        if (item.name == "minbalance") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }

                        // extract banking-services data (if not empty)
                        if (item.name == "bankingserviceid") {
                            model = utilities.objectAppendHelper(item, null, false);
                            if (model) {
                                bankingservices.push(model);
                            }
                            return;
                        }

                        // extract alert-medium data (if not empty)
                        if (item.name == "alertmediumid") {
                            model = utilities.objectAppendHelper(item, null, false);
                            if (model) {
                                alertmediums.push(model);
                            }
                            return;
                        }

                        // extract statement-medium data (if not empty)
                        if (item.name == "statementmediumid") {
                            model = utilities.objectAppendHelper(item, null, false);
                            if (model) {
                                statementmediums.push(model);
                            }
                            return;
                        }

                        // item is added to casa object if it's not
                        // empty and passes all previous checks
                        utilities.objectAppendHelper(item, casa);
                    });

                    debugger
                    casa["productid"] = $("#frmProduct input[name=productid]").val();
                    casa["productcode"] = $("#frmProduct input[name=productcode]").val();
                    // append models to post data
                    data.account = casa;
                    data.accountservice = accountservice;
                    data.bankingservices = bankingservices;
                    data.alertmediums = alertmediums;
                    data.statementmediums = statementmediums;

                    saveAccount(data);
                }
            }, function (isRejected) {
                return;
            });
        },

        onTabClick: function (tab, navigation, index) {
            return false;
        },

        onTabShow: function (tab, navigation, index) {
            var navLength = $(navigation).find("li:not(.d-none)").length;

            var wizard = navigation.closest('.card-wizard');
            wizard.find(".btn-next").removeClass("disabled");

            if ((index + 1) === navLength) {
                $(wizard).find('.btn-next').hide();
                $(wizard).find('.btn-finish').show();
            } else {
                $(wizard).find('.btn-next').show();
                $(wizard).find('.btn-finish').hide();
            }

            refreshAnimation(wizard, index);
        }
    });

    $("#accountUpdateWizard").bootstrapWizard({
        'tabClass': 'nav nav-pills',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-previous',
        'finishSelector': '.btn-finish',

        onNext: function (tab, navigation, index) {
            var form = getTabForm(tab);
            if (!form.valid()) {
                return false;
            }
        },

        onInit: function (tab, navigation, index) {
            var $wizard = navigation.closest('.card-wizard');
            refreshAnimation($wizard, index);
        },

        onFinish: function (tab, navigation, index) {
            swal({
                title: "Are you sure?",
                text: "Account data will be submitted",
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
            }).then(function (isConfirm) {
                if (isConfirm) {
                    // freeze finish button
                    $("#accountUpdateWizard .btn-finish")
                        .attr("disabled", "true");

                    var formsArray = [];
                    var tabsArray = $(navigation)
                        .find("li:not(.d-none)")
                        .map(function () {
                            return getTabForm(this);
                        });
                    tabsArray = tabsArray.toArray();
                    // remove referee & mandate form
                    tabsArray.pop();
                    tabsArray.pop();
                    $.each(tabsArray, function (index, value) {
                        formsArray.push(value.serializeArray());
                    });

                    // merge form arrays into one
                    formsArray = $.map(formsArray, function (arr) {
                        return arr;
                    });

                    // compile/extract form data into appropriate objects
                    var casa = {}, accountservice = {}, bankingservices = [],
                        alertmediums = [], statementmediums = [], model = null;
                    $.each(formsArray, function (index, item) {
                        // skip data-table redundant fields
                        if (item.name == "btSelectItem") {
                            return;
                        }

                        // extract account-services data if not empty
                        if (item.name == "cardtypeid") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        if (item.name == "nameoncard") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        if (item.name == "statementfrequencyid") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }
                        if (item.name == "minbalance") {
                            utilities.objectAppendHelper(item, accountservice);
                            return;
                        }

                        // extract banking-services data (if not empty)
                        if (item.name == "bankingserviceid") {
                            bankingservices.push(item.value);
                            return;
                        }

                        // extract alert-medium data (if not empty)
                        if (item.name == "alertmediumid") {
                            alertmediums.push(item.value);
                            return;
                        }

                        // extract statement-medium data (if not empty)
                        if (item.name == "statementmediumid") {
                            statementmediums.push(item.value);
                            return;
                        }

                        // item is added to casa object if it's not
                        // empty and passes all previous checks
                        utilities.objectAppendHelper(item, casa);
                    });

                    // append update object ids
                    casa.casaaccountid = updateAccount.casaaccountid;
                    casa.customerid = updateAccount.customerid;
                    casa.datetimecreated = updateAccount.datetimecreated;
                    casa.accountnumber = updateAccount.accountnumber;
                    casa.accountstatusid = updateAccount.accountstatusid;

                    accountservice.id = updateAccount.casaaccountserviceid;
                    accountservice.casaaccountid = updateAccount.casaaccountid;

                    // append models to post data
                    var data = {};
                    data.account = casa;
                    data.accountservice = accountservice;
                    data.bankingserviceids = bankingservices;
                    data.alertmediumids = alertmediums;
                    data.statementmediumids = statementmediums;

                    editAccount(data);
                }
            }, function (isRejected) {
                return;
            });
        },

        onTabClick: function (tab, navigation, index) {
            return true;
        },

        onTabShow: function (tab, navigation, index) {
            var navLength = $(navigation).find("li:not(.d-none)").length;

            var wizard = navigation.closest('.card-wizard');
            wizard.find(".btn-next").removeClass("disabled");

            if ((index + 1) === navLength) {
                $(wizard).find('.btn-next').hide();
                $(wizard).find('.btn-finish').show();
            } else {
                $(wizard).find('.btn-next').show();
                $(wizard).find('.btn-finish').hide();
            }

            refreshAnimation(wizard, index);
        }
    });

    function getTabForm(tab) {
        var nav_id = $(tab).find("a.nav-link").attr("href");
        var wizard = $("#" + $(tab).closest('.card-wizard').attr("id"));
        var tabpane = wizard.find("div" + nav_id + ".tab-pane");
        return (tabpane.find("form"));
    }

    $(window).resize(function () {
        $('.card-wizard').each(function () {
            $wizard = $(this);

            index = $wizard.bootstrapWizard('currentIndex');
            refreshAnimation($wizard, index);
        });
    });

    function refreshAnimation($wizard, index) {
        $total = $wizard.find('.nav li').length;
        $li_width = 100 / $total;

        total_steps = $wizard.find('.nav li').length;
        move_distance = $wizard.width() / total_steps;
        index_temp = index;
        vertical_level = 0;

        mobile_device = $(document).width() < 600 && $total > 3;

        if (mobile_device) {
            move_distance = $wizard.width() / 2;
            index_temp = index % 2;
            $li_width = 50;
        }

        $wizard.find('.nav li').css('width', $li_width + '%');

        step_width = move_distance;
        move_distance = move_distance * index_temp;

        $current = index + 1;

        if (mobile_device) {
            vertical_level = parseInt(index / 2);
            vertical_level = vertical_level * 38;
        }
    }
}

function initSelectTwoConfig() {
    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);

    $("#ddlClass, #ddlUClass").select2({
        placeholder: "Select class",
    });
    $.ajax(url_path + "/LoadAccountPostStatuses")
        .then(function (response) {
            $("#ddlpostnostatusid").select2({
                placeholder: "Select account post status",
                data: response
            });
        });
    $.ajax(url_path + "/LoadAccountCardTypes")
        .then(function (response) {
            $("#ddlCardType, #UddlCardType").select2({
                placeholder: "Select card type",
                data: response
            });
        });
    $.ajax(url_path + "/LoadDepartments")
        .then(function (response) {
            departments = response;
            $("#ddlAcctOfficerDept,#UddlAcctOfficerDept,#ddlRelationshipOffcrDept,#UddlRelationshipOffcrDept").select2({
                placeholder: "Select Dept./Unit",
                data: response
            });
        });
    $.ajax(url_path + "/LoadStaffs")
        .then(function (response) {
            $("#acctofficer,#relationshipoffcr,#relationshipmngr,#Uacctofficer,#Urelationshipoffcr,#Urelationshipmngr").select2({
                placeholder: "Select User",
                data: response
            });
        });
    $.ajax(url_path + "/LoadBankingServices")
        .then(function (response) {
            $("#ddlBankingSrvces, #UddlBankingSrvces").select2({
                placeholder: "Select service(s)",
                data: response,
                allowClear: false
            });
        });
    $.ajax(url_path + "/LoadAlertMedia")
        .then(function (response) {
            $("#ddlAlerts, #UddlAlerts").select2({
                placeholder: "Select alert media",
                data: response,
                allowClear: false
            });
        });
    $.ajax(url_path + "/LoadStatementMedia")
        .then(function (response) {
            $("#ddlStmntMedia, #UddlStmntMedia").select2({
                placeholder: "Select statement media",
                data: response,
                allowClear: false
            });
        });
    $.ajax(url_path + "/LoadStatementFrequencies")
        .then(function (response) {
            $("#ddlStmntFreq, #UddlStmntFreq").select2({
                placeholder: "Select statement frequency",
                data: response
            });
        });
    $.ajax(url_path + "/../Profile/LoadTitles")
        .then(function (response) {
            $("#ddlTitle, #ddlUTitle").select2({
                placeholder: "Select title",
                data: response
            });
        });
    $.ajax(url_path + "/../Profile/LoadModeOfIDs")
        .then(function (response) {
            $("#ddlModeOfID, #ddlUModeOfID").select2({
                placeholder: "Select mode of identification",
                data: response
            });
        });
    $.ajax(url_path + "/../Profile/LoadBanks")
        .then(function (response) {
            $("#ddlBank, #ddlUBank").select2({
                placeholder: "Select bank",
                data: response
            });
        });
    $.ajax(url_path + "/ListCurrencies")
        .then(function (response) {
            $("#ddlCurrency").select2({
                placeholder: "Select currency",
                data: response
            });
        });

    // General select 2 event listeners
    $(document).on("select2:open", function () {
        $('.select2-results__options').perfectScrollbar();
    });
    
}

var utilities = {
    animDuration: 400,
    deleteMandateBtnFormatter: function (val, row, index) {
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
    },
    editAccountFormatter: function (value, row) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='initUpdate(" + row.casaaccountid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    clearWizard: function () {
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
            .css('background-image', 'url('+ blob +')');
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
    productNameTableFormatter: function (index, row, detail) {
            detail.html("Loading...");
        
        var productid = row.productid;
               //productData
            debugger
            var top_row = $("<div class='row'></div>");
            var bottom_row = $("<div class='row'></div>");
            //var bvn_col = $("<div class='col-sm-12 col-md-6'></div>");
            //var phone_col = $("<div class='col-sm-12 col-md-6'></div>");
            //var email_col = $("<div class='col-sm-12 col-md-6'></div>");
            var address_col = $("<div class='col'></div>");

            address_col.append("<h6 class='detail-primary d-inline-block mb-3'>Product Name</h6>");
            if(productData.length == 0) {
                address_col.append("<p>No procuct name attached.</p>");
            } else {
               // $.each(addresses, function (index, value) {
                    var html = [];
                html.push("<p><b>" + productData[productid] + "</b></p>");
                   // html.push(value.address + ", " + value.city + ", " + value.state.statename);
                  //  html.push(", " + value.country.name + ".</p>");
                    address_col.append(html.join(""));
               // });
            }
            

            top_row.append(address_col);
         // bottom_row.append(address_col);
            detail.empty();
            detail.append(top_row, bottom_row);
        
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
    },
};