var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

var freezeStatus;

$(document).ready(function () {
    //initDataTable();
    //setDataTableEventHandlers();
    //initDatePicker();
    initSelectTwoConfig();
    initFormValidations();
    $(".modal").perfectScrollbar();
});

function openModal() {
    // TODO clear form
    // show modal
    $('#freeze-account-modal').modal('show');
}

function clear() {
    // TODO Clear file upload field
    $("#freeze-account-form select").val(null)
        .trigger("select2:unselect");
    $("#freeze-account-form").trigger("reset");
}

function initDataTable() {
    $.ajax(url_path + "/LoadProducts")
        .then(function (response) {
            $.each(response, function (index, value) {
                productData[value.id] = value.productName;
            });
            // Let data table load its data / refresh with url
            $("#account-data-table")
                .bootstrapTable("refresh", {
                    url: url_path + "/LoadAccounts"
                });
            $('#product-data-table')
                .bootstrapTable('load', response);
        });
}

function save() {
   // return; // TODO remove this

    debugger

    if (freezeStatus) {

    $.notify({
        icon: "now-ui-icons travel_info",
        message: "Account Has Already Been Frozen"
    }, {
        type: "danger",
        placement: {
            from: "top",
            align: "right"
        }
    }
        );

        return;
    }


   
    var form = $("#freeze-account-form");

    /*if (!form.valid()) {
        return false;
    }*/

    var valid = true;

    var input = $("#freeze-file").get(0);
    var customerAccNo = $("#productaccountno").val();

    var Freezereasontype = $("#freezereason").val();

    if (Freezereasontype == 7) {

        var freezeReasonOthersText = $("#freezeReasonOthersText").val();

    } else {

        var freezeReasonOthersText = "";
    }

    var Freezetype = $("#freezetype").val();

    var freezedate = $("#freezedatetype").val();

    if (freezedate == 2) {
        var startDate = $("#freezestartDate").val();
        var endDate = "9999-99-99";
    } else {
        var startDate = $("#freezestartDate").val();
        var endDate = $("#freezeendDate").val();
    }

    var Amount = $("#freezeamount").val();


   
    if (!input.files.length) {
        /* valid = false;
        */
        swal({
            title: "Are you sure?",
            text: "Freeze Details will be saved",
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

        $.ajax(url_path + "/../FreezeAccount", {
            data: {
                AccountNumber: customerAccNo, StartDate: startDate, EndDate: endDate, AccountName: "", DateTypeId: freezedate, TransactionToPreventId:
                    "", AttachedDocumntId: "", Balance: "", FreezeReason2: freezeReasonOthersText, FreezeTypeId: Freezetype, FreezeAmount: Amount,
                FreezeReason: Freezereasontype
            },
            method: "POST",
            dataType: "json",
        }).then(
            function (response) {
              //  function accountSuccess() {
                    swal({
                        title: "Freeze Account",
                        text: "Freeze Transaction Successfull!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(clear());
             //   }

               // clear();
                // utilities.clearWizard
                //$('#freeze-account-form')[0].reset();
                $("#freeze-account-data-table").bootstrapTable("refresh", {
                    url: "../Account/LoadFrozenAccountsForCustomerModule"
                });
                $('#productaccountno').val(null).trigger("change");
                $('#freezetype').val(null).trigger("change");
                $('#freezereason').val(null).trigger("change");
                $('#freezeReasonOthers').val(null).trigger("change");
                $('#freezedatetype').val(null).trigger("change");
                $("#freezedatediv").modal("hide");
                $("#freeze-account-modal").modal("hide");
                $('.datetimepicker').val('');
            },
            function (error) {
                swal({
                    title: 'Freeze Account',
                    text: 'Freeze Account submission encountered an error',
                    type: 'error',
                    allowOutsideClick: false,
                    allowEscapeKey: false
                }).then(function () {
                    // Unfreeze finish button
                    $("#accountWizard .btn-finish").removeAttr("disabled");
                });
            }
                );

                 


        debugger


            },

    function (isRejected) { return; }
        );


    }
    else {

        swal({
            title: "Are you sure?",
            text: "Freeze Details will be saved",
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
                var formdata = new FormData();

                formdata.append("document", input.files[0]);
                formdata.append("title", customerAccNo);

                $.ajax(url_path + "/../AddDocumentUpload/"
                    + customerAccNo + "/?sendall=true", {
                    method: "POST",
                    contentType: false,
                    processData: false,
                    data: formdata
                }).then(
                    function (response) {


                        $("#freeze-file").fileinput("clear");
                        /*swal({
                            title: "Add Cheque Accompany Document",
                            text: "Cheque Accompany document added successfully!",
                            type: 'success',
                        });*/


                        $.ajax(url_path + "/../FreezeAccount", {
                            data: {
                                AccountNumber: customerAccNo, StartDate: startDate, EndDate: endDate, AccountName: "", DateTypeId: freezedate, TransactionToPreventId:
                                    "", AttachedDocumntId: "", Balance: "", FreezeReason2: freezeReasonOthersText, FreezeTypeId: Freezetype, FreezeAmount: Amount,
                                FreezeReason: Freezereasontype
                            },
                            method: "POST",
                            dataType: "json",
                        }).then(
                            function (response) {
                               // function accountSuccess() {
                                    swal({
                                        title: "Freeze Account",
                                        text: "Freeze Transaction Successfull!",
                                        type: 'success',
                                        allowOutsideClick: false,
                                        allowEscapeKey: false
                                    }).then(clear());
                               // }

                              //  clear();

                                $("#freeze-account-data-table").bootstrapTable("refresh", {
                                    url:"../Account/LoadFrozenAccounts"});
                                // utilities.clearWizard
                                //$('#freeze-account-form')[0].reset();
                                $('#productaccountno').val(null).trigger("change");
                                $('#freezetype').val(null).trigger("change");
                                $('#freezereason').val(null).trigger("change");
                                $('#freezeReasonOthers').val(null).trigger("change");
                                $('#freezedatetype').val(null).trigger("change");
                                $("#freezedatediv").modal("hide");
                                $("#freeze-account-modal").modal("hide");
                                $('.datetimepicker').val('');
                                //$('.freezestartDate').val('');
                                //$('.select').val([]).trigger('change');
                                //$('.select2-container').select2('val', '');
                                

                            },
                            function (error) {
                                swal({
                                    title: 'Freeze Account',
                                    text: 'Freeze Account submission encountered an error',
                                    type: 'error',
                                    allowOutsideClick: false,
                                    allowEscapeKey: false
                                }).then(function () {
                                    // Unfreeze finish button
                                    $("#accountWizard .btn-finish").removeAttr("disabled");
                                });
                            }
                        );



                    },
                    function (error) {
                        swal({
                            title: "Add Freeze Accompany Document",
                            text: "An error occured when adding Freeze Accompany Document!",
                            type: "error"
                        });

                        return;
                    }
                );


                debugger


            },
            function (isRejected) { return; }
        );



    }

    if (!valid) return;

    

   
    
}


$('.datetimepicker').datetimepicker({
    format: 'DD MMMM, YYYY',
    icons: {
        time: "fa fa-clock-o",
        date: "fa fa-calendar",
        up: "fa fa-chevron-up",
        down: "fa fa-chevron-down",
        previous: 'fa fa-chevron-left',
        next: 'fa fa-chevron-right',
        today: 'fa fa-screenshot',
        clear: 'fa fa-trash',
        close: 'fa fa-remove',
        inline: true

    }
});



$("#freezestartDate").on("dp.change", function (e) {
    //console.log(e.date);
    var freezedate = $("#freezedatetype").val();
    if (freezedate == 3) {
        var startDate = $("#freezestartDate").val();
        var dateString = startDate;
        var myDate = new Date(dateString);

        //add a day to the date
        myDate.setDate(myDate.getDate() + 1);
        $("#freezeendDate").val(myDate.toDateString().slice(4, myDate.length));



    }
});

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

    $("#freeze-account-form").validate({
        rules: {
            productaccountno: {
                digits: true,
                maxlength: 50
            },
            freezeamount: {
                digits: true,
                maxlength: 50
            }
        },
        messages: {
            productaccountno: {
                required: "You must select an account to proceed",
            },
            freezeamount: {
                // add rules & messages for money validations (with formatting)
                required: "Please input amount to freeze"
            }
        },

        ignore: false
    });
}

function initSelectTwoConfig() {
    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $("#freeze-account-modal"));
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);

    $.ajax(url_path + "/../LoadFreezeType")
        .then(function (response) {
            $("#freezetype").select2({
                placeholder: "Select freeze type",
                data: response
            });
        });
    
    // General select2 event listeners
    $(document).on("select2:open", function () {
        $('.select2-results__options').perfectScrollbar();
    });

    // Specific select2 event listeners
    $("#freezetype").on("select2:select", function () {
       
        if ($("#freezetype").val() == 1) {


            $("#freezeamountdiv").hide();

            $('#freezedatetype').prop('disabled', false);

        } else if ($("#freezetype").val() == 3) {

            $("#freezeamountdiv").show();

            $('#freezedatetype').prop('disabled', true);

            $("#freezedatediv").hide();
        }


        else {
            $('#freezedatetype').prop('disabled', false);
            $("#freezeamountdiv").show();
        }

    });

    $("#freezetype").on("select2:unselect", function () {
        utilities.populateCasaDetails(null);
    });

    $.ajax(url_path + "/../ListAccountNoMapDetails")
        .then(function (response) {
            $("#productaccountno").select2({
                placeholder: "Select Customer Account",
                data: response
            });
        });

    $.ajax(url_path + "/../LoadFreezeReason")
        .then(function (response) {
            $("#freezereason").select2({
                placeholder: "Select Freeze Reason",
                data: response
            });
        });

    $.ajax(url_path + "/../LoadFreezeDateType")
        .then(function (response) {
            $("#freezedatetype").select2({
                placeholder: "Select Freeze Date Type",
                data: response
            });
        });

    // Specific select2 event listeners
    $("#freezedatetype").on("select2:select", function () {

       //debugger

        var freezedate = $("#freezedatetype").val();

        if (freezedate == 3) {

            $("#freezedatediv").show();
            

        } else if (freezedate == 1) {

            $("#freezedatediv").show();

        } else if (freezedate == 2) {

            $("#freezedatediv").hide();

        }

       
    });

    $("#freezereason").on("select2:select", function () {

        debugger

        var reasontype = $("#freezereason").val();

        if (reasontype == 7) {

            $("#freezeReasonOthers").show()

        } else {

            $("#freezeReasonOthers").hide()
        }


    });

    $("#productaccountno").on("select2:select", function () {

        debugger

        var casaAccNo = $("#productaccountno").val();

        $.ajax(
            url_path + "/../ConfirmFreezeStatus/" +
            casaAccNo ,
            {
                method: "GET",
                dataType: "json",

            }).then(function (response) {

                if (response) {

                    freezeStatus = true;

                } else {

                    freezeStatus = false;

                }

            })


    });
    
}

var utilities = {
    populateCasaDetails: function (data) {
        if (data == null) {
            // TODO Populate fields with '-', whipe data-tables (if any)
            return;
        }
        // TODO Populate fields/tables with values in data
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
    freezeApprovalStatusFormatter: function (value) {
        
        if (value) {

            return "Approved";

        } else {

            return "Pending";

        }
        
    },
    editFreezeFormatter: function (value, row) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.initFreezeReversal(" + row.accountNumber + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    freezeTypeFormatter: function (value) {
        var statusString;
        switch (value) {
            case 1:
                statusString = "Total Freeze";
                break;
            case 2:
                statusString = "Partial Freeze";
                break;
            case 3:
                statusString = "Indefinite Freeze";
                break;
            case 4:
                statusString = "Credit Freeze";
                break;
            case 13:
                statusString = "Debit Freeze";
                break;
            default:
                statusString = "";
                break;
        }
        return statusString;
    },

    initFreezeReversal: function (casaAccNo) {
        debugger

       

        $.ajax(
            url_path + "/../ConfirmFreezeReversalStatus/" +
            casaAccNo,
            {
                method: "GET",
                dataType: "json",

            }).then(function (response) {

                if (response) {

                    freezeStatus = true;


                } else {

                    freezeStatus = false;

                }

            })

        if (freezeStatus) {

            $.notify({
                icon: "now-ui-icons travel_info",
                message: "Transaction has already been reversed and waiting for approval"
            }, {
                type: "danger",
                placement: {
                    from: "top",
                    align: "right"
                }
            });

            return;

        }
       


        swal({
            title: "Are you sure?",
            text: "Freeze will be Reversed",
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

                $.ajax(url_path + "/../FreezeAccountReversal/" +
                    casaAccNo, {
                    
                    method: "GET",
                    dataType: "json",
                }).then(
                    function (response) {
                        //  function accountSuccess() {
                        console.log(response);
                        if (response) {
                            swal({
                                title: "Freeze Account",
                                text: "Freeze Reversal Successfull!",
                                type: 'success',
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(clear());
                        } else {
                            swal({
                                title: "Freeze Account",
                                text: "Transaction has not been previously approved, cannot perform reversal on unapproved transactions",
                                type: 'error',
                                allowOutsideClick: false,
                                allowEscapeKey: false
                            }).then(clear());

                        }

                        // clear();
                        // utilities.clearWizard
                        //$('#freeze-account-form')[0].reset();
                        $("#freeze-account-data-table").bootstrapTable("refresh", {
                            url: "../Account/LoadFrozenAccountsForCustomerModule"
                        });
                        /*$('#productaccountno').val(null).trigger("change");
                        $('#freezetype').val(null).trigger("change");
                        $('#freezereason').val(null).trigger("change");
                        $('#freezeReasonOthers').val(null).trigger("change");
                        $('#freezedatetype').val(null).trigger("change");
                        $("#freezedatediv").modal("hide");
                        $("#freeze-account-modal").modal("hide");
                        $('.datetimepicker').val('');*/
                    },
                    function (error) {
                        swal({
                            title: 'Freeze Account',
                            text: 'Freeze Reversal encountered an error',
                            type: 'error',
                            allowOutsideClick: false,
                            allowEscapeKey: false
                        }).then(function () {
                            // Unfreeze finish button
                            $("#accountWizard .btn-finish").removeAttr("disabled");
                        });
                    }
                );




                debugger


            },

            function (isRejected) { return; }
        );


    },

    freezeTableFormatter: function (index, row, el) {
        var container = $("<div class='row mx-0'></div>");
        container.append($("<div class='col-xs-12 col-md-6'><b>Freeze Start Date:</b> &nbsp;&nbsp; "
            + (moment(row.startDate).format("MMMM DD, YYYY") == 'Invalid date' ? "-" : moment(row.startDate).format("MMMM DD, YYYY")) + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6'><b>Freeze End Date:</b> &nbsp;&nbsp; "
            + (moment(row.endDate).format("MMMM DD, YYYY") == 'Invalid date' ? "-" : moment(row.endDate).format("MMMM DD, YYYY")) + "</div> <br> <br> <br>"));
        container.append($("<div class='col-xs-12 col-md-6'><b>Freeze Amount:</b> &nbsp;&nbsp; N"
            + row.freezeAmount + "</div>"));
        el.append(container);
    }
};