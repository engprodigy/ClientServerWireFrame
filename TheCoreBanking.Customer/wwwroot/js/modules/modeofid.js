var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

$(document).ready(function ($) {
    initModeOfIDValidation();
});

function initModeOfIDValidation() {
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
    $("#frmModeOfID").validate({
        messages: {
            idmode: {
                required: "Mode of Identity is required"
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

window.modeEvents = {
    'click .edit': function (e, value, row, index) {
        var form = $("#frmModeOfID");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=id]").val(row.id);
            form.find("[name=idmode]").val(row.idmode);
            form.find("[name=createdby]").val(row.createdby);
            form.find("[name=createddate]").val(row.createddate);
            form.find("[name=active]").prop("checked", row.active);            
            $("#modeOfIDTitle").text("Update");
            $('#btnAddMode').hide();
            $("#btnModeUpdate").show();
            $('#AddNewMode').modal('show');
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
                    url: url_path + '/DeleteModeOfID',
                    method: "POST",
                    contentType: "application/json",
                    data: JSON.stringify({ Id: row.id }),
                    success: function (data) {
                        swal("Deleted succesfully");
                        $('#modeTable').bootstrapTable('refresh');
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

function updateModeofID() {
    swal({
        title: "Are you sure?",
        text: "Mode of ID will be updated!",
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
            var form = $("#frmModeOfID");
            var data = {
                id: form.find("#id").val(),
                createdby: form.find("#createdby").val(),
                createddate: form.find("#createddate").val(),
                companycode: form.find("#companycode").val(),
                idmode: form.find('#idmode').val(),
                active: form.find('#active').prop("checked"),
            };
            form.find("#btnModeUpdate").attr("disabled", "true");
            $.ajax({
                url: url_path + '/UpdateModeOfID',
                method: "POST",
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (result) {
                    swal({
                        title: 'Mode Of Identity',
                        text: 'Identity mode updated successfully!',
                        type: 'success'
                    }).then(function () {
                        $('#modeTable').
                            bootstrapTable('refresh');
                        $("#btnModeUpdate").removeAttr("disabled");
                        $('#AddNewMode').modal('hide');
                    });
                },
                error: function (e) {
                    swal({
                        title: 'Mode Of Identity',
                        text: 'Identity mode encountered an error during update',
                        type: 'error'
                    }).then(function () {
                        $("#btnModeUpdate").removeAttr("disabled");
                    });
                }
            });
        }
    }, function (isRejected) {
        return;
    });
}

function openModeOfIDModal() {
    var form = $("#frmModeOfID");
    form.trigger("reset");
    $("#modeOfIDTitle").text("Add");
    form.find('#btnAddMode').show();
    form.find("#btnModeUpdate").hide();
    $('#AddNewMode').modal('show');
}

function AddModeofID() {
    swal({
        title: "Are you sure?",
        text: "Mode of ID will be saved!",
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
                var form = $("#frmModeOfID");
                form.find("#btnAddMode").attr("disabled", "true");
                var data = {
                    Idmode: form.find('#idmode').val(),
                    Active: form.find('#active').prop("checked"),
                }
                $.ajax({
                    url: url_path + "/AddModeOfID",
                    method: "POST",
                    data: JSON.stringify(data),
                    contentType: "application/json",
                    success: function (result) {
                        swal({
                            title: 'Mode Of Identity',
                            text: 'Identity mode saved successfully!',
                            type: 'success'
                        }).then(function () {
                            $('#modeTable').
                                bootstrapTable('refresh');
                            $("#btnAddMode").removeAttr("disabled");
                            $('#AddNewMode').modal('hide');
                        });   
                    },
                    error: function (e) {
                        swal({
                            title: 'Mode Of Identity',
                            text: 'The entered Mode of Identity already exist',
                            type: 'error'
                        }).then(function () {
                            $("#btnAddMode").removeAttr("disabled");
                        });
                    }
                });
            }
        }, function(isRejected) {
            return;
        });
}