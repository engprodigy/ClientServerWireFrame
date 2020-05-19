var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

$(document).ready(function ($) {
    initMaritalStatusValidation();
});

function initMaritalStatusValidation() {
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
    $("#frmMaritalStatus").validate({
        messages: {
            status: {
                required: "Marital Status is required"
            }
        }
    });
}

function dateFormatter(value, row, $element) {
    var format = moment(value).format("DD MMMM, YYYY");
    var html = '<div>' + format + '</div>';
    return html;
}

function activeFormatter(value, row, index) {
    return (value ? "Yes" : "No");
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

window.stateEvents = {
    'click .edit': function (e, value, row, index) {
        var form = $("#frmMaritalStatus");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=id]").val(row.id);
            form.find("[name=status]").val(row.status);           
            form.find("[name=dateCreated]").val(row.dateCreated);           
            $("#maritalStatusTitle").text("Update");
            $('#btnAddMarital').hide();
            $("#btnMaritalUpdate").show();
            $('#AddNewStatus').modal('show');
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
                    url: url_path + '/DeleteMaritalStatus',
                    method: "POST",
                    data: JSON.stringify({ Id: row.id }),
                    contentType: "application/json",
                    success: function (data) {
                        swal("Deleted succesfully");
                        $('#statusTable').bootstrapTable('refresh');
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

function UpdateMaritalStatus() {
    swal({
        title: "Are you sure?",
        text: "Marital Status will be updated!",
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
            var form = $("#frmMaritalStatus");
            var data = {
                id: form.find("#id").val(),               
                dateCreated: form.find("#dateCreated").val(),                
                status: form.find('#status').val(),                
            };
            form.find("#btnMaritalUpdate").attr("disabled", "true");
            $.ajax({
                url: url_path + '/UpdateMaritalStatus',
                type: 'POST',
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (result) {
                    swal({
                        title: 'Marital Status',
                        text: 'Marital Status updated successfully!',
                        type: 'success'
                    }).then(function () {
                        $('#statusTable').
                            bootstrapTable('refresh');
                        $("#btnMaritalUpdate").removeAttr("disabled");
                        $('#AddNewStatus').modal('hide');
                    });
                },
                error: function (e) {
                    swal({
                        title: 'Marital Status',
                        text: 'Marital Status encountered an error during update',
                        type: 'error'
                    }).then(function () {
                        $("#btnMaritalUpdate").removeAttr("disabled");
                    });
                }
            });
        }
    }, function (isRejected) {
        return;
    });
}

function openMaritalStatusModal() {
    var form = $("#frmMaritalStatus");
    form.trigger("reset");
    $("#maritalStatusTitle").text("Add");
    form.find('#btnAddMarital').show();
    form.find("#btnMaritalUpdate").hide();
    $('#AddNewStatus').modal('show');
}

function AddMaritalStatus() {
    swal({
        title: "Are you sure?",
        text: "Marital Status will be saved!",
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
                var form = $("#frmMaritalStatus");
                form.find("#btnAddMarital").attr("disabled", "true");
                var data = {
                    status: form.find('#status').val(),
                }
                $.ajax({
                    url: url_path + '/AddMaritalStatus',
                    method: "POST",
                    data: JSON.stringify(data),
                    contentType: "application/json",
                    success: function (result) {
                        swal({
                            title: 'Marital Status',
                            text: 'Marital Status saved successfully!',
                            type: 'success'
                        }).then(function () {
                            $('#statusTable').
                                bootstrapTable('refresh');
                            $("#btnAddMarital").removeAttr("disabled");
                            $('#AddNewStatus').modal('hide');
                        });
                    },
                    error: function (e) {
                        swal({
                            title: 'Marital Status',
                            text: 'The entered Marital Status already exist',
                            type: 'error'
                        }).then(function () {
                            $("#btnAddMarital").removeAttr("disabled");
                        });
                    }
                });
            }
        }, function (isRejected) {
            return;
        });
}