var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

$(document).ready(function ($) {
    initCustTitleValidation();
});

function initCustTitleValidation() {
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
    $("#frmTitle").validate({
        messages: {
            title: {
                required: "Customer Title is required"
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

window.titleEvents = {
    'click .edit': function (e, value, row, index) {
        var form = $("#frmTitle");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=id]").val(row.id);
            form.find("[name=title]").val(row.title);            
            $("#custTitleTitle").text("Update");
            $('#btnAddTitle').hide();
            $("#btnTitleUpdate").show();
            $('#AddNewTitle').modal('show');
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
                    url: url_path + '/DeleteCustomerTitle',
                    method: "POST",
                    data: JSON.stringify({ Id: row.id }),
                    contentType: "application/json",
                    success: function (data) {
                        swal("Deleted succesfully");
                        $('#titleTable').bootstrapTable('refresh');
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

function updateCustTitle() {
    swal({
        title: "Are you sure?",
        text: "Customer Title will be updated!",
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
            var form = $("#frmTitle");
            var data = {
                id: form.find("#id").val(),               
                title: form.find('#title').val(),               
            };
            form.find("#btnTitleUpdate").attr("disabled", "true");
            $.ajax({
                url: url_path + '/updateCustTitle',
                method: "POST",
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (result) {
                    swal({
                        title: 'Customer Title',
                        text: 'Customer Title updated successfully!',
                        type: 'success'
                    }).then(function () {
                        $('#titleTable').
                            bootstrapTable('refresh');
                        $("#btnTitleUpdate").removeAttr("disabled");
                        $('#AddNewTitle').modal('hide');
                    });
                },
                error: function (e) {
                    swal({
                        title: 'Customer Title',
                        text: 'Customer Title encountered an error during update',
                        type: 'error'
                    }).then(function () {
                        $("#btnTitleUpdate").removeAttr("disabled");
                    });
                }
            });
        }
    }, function (isRejected) {
        return;
    });
}

function openTitleModal() {
    var form = $("#frmTitle");
    form.trigger("reset");
    $("#custTitleTitle").text("Add");
    form.find('#btnAddTitle').show();
    form.find("#btnTitleUpdate").hide();
    $('#AddNewTitle').modal('show');
}

function AddCustTitle() {
    swal({
        title: "Are you sure?",
        text: "Customer Title will be saved!",
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
                var form = $("#frmTitle");
                form.find("#btnAddTitle").attr("disabled", "true");
                var data = {
                    title: form.find('#title').val(),                    
                }
                $.ajax({
                    url: url_path + '/AddCustTitle',
                    method: "POST",
                    data: JSON.stringify(data),
                    contentType: "application/json",
                    success: function (result) {
                        swal({
                            title: 'Customer Title',
                            text: 'Customer Title saved successfully!',
                            type: 'success'
                        }).then(function () {
                            $('#titleTable').
                                bootstrapTable('refresh');
                            $("#btnAddTitle").removeAttr("disabled");
                            $('#AddNewTitle').modal('hide');
                        });
                    },
                    error: function (e) {
                        swal({
                            title: 'Customer Title',
                            text: 'The entered customer Title already exist',
                            type: 'error'
                        }).then(function () {
                            $("#btnAddTitle").removeAttr("disabled");
                        });
                    }
                });
            }
        }, function (isRejected) {
            return;
        });
}