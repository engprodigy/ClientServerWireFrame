var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

$(document).ready(function ($) {
    initKycValidation();
    initKYCItemSelectTwoConfig();
});

function initKycValidation() {
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
    $("#frmkyc").validate({
        messages: {
            item: {
                required: "KYC Item is required"
            }
        }
    });
}

function kycdateFormatter(value, row, $element) {
    var html = "-";
    if (value) {
        html = moment(value).format("DD MMMM, YYYY");
    }
    return html;
}

function lastdateupdateFormatter(value, row, $element) {
    var format = moment(value).format("DD MMMM, YYYY");
    var html = '<div>' + format + '</div>';
    return html;
}

function mandatoryFormatter(value, row, index) {        
    return (value ? "Yes" : "No");
}

function editFormatter(value, row, index) {
    return [
        '<button type="button" class="edit btn btn-sm btn-info" title="Edit">',
        '<i class="fas fa-edit"></i>',
        '</button>'
    ].join('');
}

function initKYCItemSelectTwoConfig() {
    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);

    $.ajax(url_path + "./../Profile/LoadCustomerAccountTypes")
        .then(function (response) {            
            $("#accounttype").select2({
                placeholder: "Select customer account type",
                data: response,
                dropdownParent: $("#AddNewKycPage.modal"),
            });
        });

}

function deleteFormatter(value, row, index) {
    return [
        '<button type="button" class="remove btn btn-sm btn-danger" title="Delete">',
        '<i class="fas fa-trash"></i> ',
        '</button>'
    ].join('');
}

window.kycEvents = {
    'click .edit': function (e, value, row, index) {   
        var form = $("#frmkyc");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=kycitemid]").val(row.kycitemid);
            form.find("[name=accounttypeid]").val(row.accounttypeid);
            form.find("[name=displayorder]").val(row.displayorder);
            form.find("[name=lastupdatedby]").val(row.lastupdatedby);
            form.find("[name=createdby]").val(row.createdby);
            form.find("[name=datetimecreated]").val(row.datetimecreated);
            form.find("[name=datetimeupdated]").val(row.datetimeupdated);
            form.find("[name=item]").val(row.item);            
            form.find("[name=ismandatory]").prop("checked", row.ismandatory);
            $("#kycItemTitle").text("Update");
            $('#btnAddKyc').hide();
            $("#btnKycUpdate").show();
            $('#AddNewKycPage').modal('show');
        }
    },
    'click .remove': function (e, value, row, index) {
        swal({
            title: "Are you sure?",
            text: "You are about to delete this record!",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#ff9800",
            confirmButtonText: "Yes, proceed",
            cancelButtonText: "No, cancel!",
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
                $.ajax({
                    url: url_path + '/DeleteKycItem',
                    method: 'POST',
                    data: JSON.stringify({ kycitemid: row.kycitemid }),
                    contentType: "application/json",
                    success: function (data) {
                        swal("Deleted succesfully");
                        $('#kycTable').bootstrapTable('refresh');
                    },
                    error: function (e) {
                        swal("An exception occured!");
                    }
                });
            }
        }, function (isRejected) {
            return;
        });
    }
};

function updateKycItem() {
    swal({
        title: "Are you sure?",
        text: "KYC will be updated!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#ff9800",
        confirmButtonText: "Yes, continue",
        cancelButtonText: "No, stop!",
        showLoaderOnConfirm: true,
        preConfirm: function () {
            return new Promise(function (resolve) {
                setTimeout(function () {
                    resolve();
                }, 1000);
            });
        }
    }).then(function (isConfirm) {
        debugger
        if (isConfirm) {
            var form = $("#frmkyc");
            var data = {
                kycitemid: form.find("#kycitemid").val(),
                accounttypeid: form.find("#accounttypeid").val(),
                displayorder: form.find("#displayorder").val(),
                item: form.find("#item").val(),
                lastupdatedby: form.find("#lastupdatedby").val(),
                datetimecreated: form.find("#datetimecreated").val(),
                createdby: form.find('#createdby').val(),
                ismandatory: form.find('#ismandatory').prop("checked"),
            };
            form.find("#btnKycUpdate").attr("disabled", "true");
            $.ajax({
                url: url_path + '/updateKycItem',
                method: "POST",
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (result) {
                    swal({
                        title: 'Know Your Customer(KYC)',
                        text: 'KYC updated successfully!',
                        type: 'success'
                    }).then(function () {
                        $('#kycTable').
                            bootstrapTable('refresh');
                        $("#btnKycUpdate").removeAttr("disabled");
                        $('#AddNewKycPage').modal('hide');
                    });
                },
                error: function (e) {
                    swal({
                        title: 'Know Your Customer(KYC)',
                        text: 'KYC encountered an error during update',
                        type: 'error'
                    }).then(function () {
                        $("#btnKycUpdate").removeAttr("disabled");
                    });
                }
            });
        }
    }, function (isRejected) {
        return;
    });
}

function openKycModal() {
    var form = $("#frmkyc");
    form.trigger("reset");
    $("#kycItemTitle").text("Add");
    form.find('#btnAddKyc').show();
    form.find("#btnKycUpdate").hide();
    $('#AddNewKycPage').modal('show');
}

function AddKycItem() {
    swal({
        title: "Are you sure?",
        text: "KYC will be saved!",
        type: "question",
        showCancelButton: true,
        confirmButtonColor: "#ff9800",
        confirmButtonText: "Yes, continue",
        cancelButtonText: "No, stop!",
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
                var form = $("#frmkyc");
                form.find("#btnAddKyc").attr("disabled", "true");
               
                var data = {
                    item: form.find('#item').val(),
                    accounttypeid: form.find('#accounttype').val(),
                    displayorder: form.find('#displayorder').val(),
                    ismandatory: form.find('#ismandatory').prop("checked"),
                    /*item: "TESTING",
                    accounttypeid: 2,
                    displayorder: 2,
                    ismandatory: 1*/

                };
                debugger
                $.ajax({
                    url: url_path + '/AddKycItem',
                    method: "POST",
                    data: JSON.stringify(data),
                    contentType: "application/json",
                    
                    success: function (result) {
                        debugger
                        swal({
                            title: 'Know Your Customer(KYC)',
                            text: 'KYC saved successfully!',
                            type: 'success'
                        }).then(function () {
                            $('#kycTable').
                                bootstrapTable('refresh');
                            $("#btnAddKyc").removeAttr("disabled");
                            $('#AddNewKycPage').modal('hide');
                        });
                    },
                    error: function (e) {
                        swal({
                            title: 'Know Your Customer(KYC)',
                            text: 'KYC encountered an error',
                            type: 'error'
                        }).then(function () {
                            $("#btnAddKyc").removeAttr("disabled");
                        });
                    }
                });
            }
        }, function (isRejected) {
            return;
        });
}