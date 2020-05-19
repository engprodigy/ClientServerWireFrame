var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

$(document).ready(function () {
    initaccounttypeValidation();
});

function initaccounttypeValidation() {
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
    $("#frmtype").validate({
        messages: {
            name: {
                required: "Customer Account Type is required"
            }
        }
    });
}

function editFormatter(value, row, index) {
    return [
        '<button type="button" class="edit btn btn-sm btn-info" title="Edit">',
        '<i class="fas fa-edit"></i>',
        '</button>'
    ].join('');
}

function deleteFormatter(value, row, index) {
    return [
        '<button type="button" class="remove btn btn-sm btn-danger" title="Delete">',
        '<i class="fas fa-trash"></i> ',
        '</button>'
    ].join('');
}

window.typeEvents = {
    'click .edit': function (e, value, row, index) {
        var form = $("#frmtype");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=id]").val(row.id);
            form.find("[name=name]").val(row.name);            
            $("#accountTypeTitle").text("Update");
            $('#btnAddType').hide();
            $("#btnTypeUpdate").show();
            $('#AddNewType').modal('show');
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
                    url: url_path + "/DeleteAccountType",
                    method: 'POST',
                    data: JSON.stringify({ Id: row.id }),
                    contentType: "application/json",
                    success: function (data) {
                        swal("Deleted succesfully");
                        $('#typeTable').bootstrapTable('refresh');
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

function updateAccountType() {
    swal({
        title: "Are you sure?",
        text: "Account Type will be updated!",
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
        if (isConfirm) {
            var form = $("#frmtype");
            var data = {
                id: form.find("#id").val(),
                name: form.find("#name").val(),               
            };
            form.find("#btnTypeUpdate").attr("disabled", "true");
            $.ajax({
                url: url_path + '/UpdateCustAccount',
                method: 'POST',
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (result) {
                    swal({
                        title: 'Customer Account Type',
                        text: 'Account Type updated successfully!',
                        type: 'success'
                    }).then(function () {
                        $('#typeTable').
                            bootstrapTable('refresh');
                        $("#btnTypeUpdate").removeAttr("disabled");
                        $('#AddNewType').modal('hide');
                    });
                },
                error: function (e) {
                    swal({
                        title: 'Customer Account Type',
                        text: 'Account Type encountered an error during update',
                        type: 'error'
                    }).then(function () {
                        $("#btnTypeUpdate").removeAttr("disabled");
                    });
                }
            });
        }
    }, function (isRejected) {
        return;
    });
}

function openAccountTypeModal() {
    var form = $("#frmtype");
    form.trigger("reset");
    $("#accountTypeTitle").text("Add");
    form.find('#btnAddType').show();
    form.find("#btnTypeUpdate").hide();
    $('#AddNewType').modal('show');
}

function AddAccountType() {
    swal({
        title: "Are you sure?",
        text: "Account Type will be saved!",
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
                var form = $("#frmtype");                
                //alert(url_path);
                form.find("#btnAddType").attr("disabled", "true");
                var data = {
                    name: form.find('#name').val(),                 
                }
                $.ajax({
                    url: url_path + '/AddAccountType',             
                    method: "POST",
                    data: JSON.stringify(data),
                    contentType: "application/json",
                    success: function (result) {
                        swal({
                            title: 'Account Type',
                            text: 'Account Type saved successfully!',
                            type: 'success'
                        }).then(function () {
                            $('#typeTable').
                                bootstrapTable('refresh');
                            $("#btnAddType").removeAttr("disabled");
                            $('#AddNewType').modal('hide');
                        });
                    },
                    error: function (e) {
                        swal({
                            title: 'Customer Account Type',
                            text: 'The entered Account Type already exist',
                            type: 'error'
                        }).then(function () {
                            $("#btnAddType").removeAttr("disabled");
                        });
                    }
                });
            }
        }, function (isRejected) {
            return;
        });
}