
function departmentFormatter(value, row, index) {
    return [
        '<a class="edit btn btn-sm"  title="Edit Department">',
        '<i class="now-ui-icons ui-2_settings-90"></i> ',
        '</a>',
         '<a class="edit btn btn-sm" onclick="delete"  title="Delete Department">',
        '<i class="now-ui-icons ui-2_settings-90"></i> ',
        '</a>'
    ].join('');
}

window.departmentEvents = {
    'click .edit': function (e, value, row, index) {
        if (row.state = true) {

            var data = JSON.stringify(row);
            $('#Id').val(row.Id);
            $('#CoyId').val(row.coyId);
            $('#BranchId').val(row.branchId);
            $('#Department').val(row.department);
            $('#DeptCode').val(row.deptCode);
            $('#UnitCode').val(row.unitCode);
            $('#UnitName').val(row.unitName);
            $('#AddNewDepartment').modal('show');
            $('#btnDepartment').html('  <i class="now-ui-icons ui-1_check"></i> Update Record');
        }
    }
};

$(document).ready(function ($) {

    $('#btnDepartment').on('click', function () {
        updateDepartment();
    });

});

function reloadpage() {
    location.reload();
}

function clear() {
    $('#Id').val('');
    $('#CoyId').val('');
    $('#BranchId').val('');
    $('#Department').val('');
    $('#DeptCode').val('');
    $('#UnitCode').val('');
    $('#UnitName').val('');
}

function updateDepartment() {
    debugger
    //var forgeryId = $("#forgeryToken").val();
    var json_data = {};
    json_data.Id = $('#Id').val();
    json_data.coyId = $('#CoyId').val();
    json_data.branchId = $('#BranchId').val();
    json_data.department = $('#Department').val();
    json_data.deptCode = $('#DeptCode').val();
    json_data.unitCode = $('#UnitCode').val();
    json_data.unitName = $('#UnitName').val();

    $("input[type=submit]").attr("disabled", "disabled");

    $('#frmDepartment').validate({

        messages: {
            CoyId: { required: "Company Code is required" },
            UnitName: { required: "Unit Name is required" },
            BranchId: { required: "Branch Code is required" },
            Department: { required: "Department is required" },
            DeptCode: { required: "Department Code is required" },
            UnitCode: { required: "Unit Code is required" }

        },
        errorPlacement: function (error, element) {
            $.notify({
                icon: "now-ui-icons travel_info",
                message: error.text(),
            }, {
                    type: 'danger',
                    placement: {
                        from: 'top',
                        align: 'right'
                    }
                });
        },
        submitHandler: function (form) {
            swal({
                title: "Are you sure?",
                text: "Department will be Added!",
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
                        }, 4000);
                    });
                }
            }).then(function (isConfirm) {
                if (isConfirm) {
                    $("#btnDepartment").attr("disabled", "disabled");
                    debugger

                    $.ajax({
                        url: 'CompanySetup/AddDepartment',
                        type: 'POST',
                        data: json_data,
                        dataType: "json",
                        //headers: {
                        //    'VerificationToken': forgeryId
                        //},
                        success: function (result) {
                            alert(result);
                            if (result.toString != '' && result != null) {
                                swal({ title: 'Create Department', text: 'Department added successfully!', type: 'success' }).then(function () { clear(); });

                                $('#departmentTable').
                                    bootstrapTable(
                                        'refresh', { url: 'CompanySetup/listdepartment' });

                                $("#btnDepartment").removeAttr("disabled");
                            }
                            else {
                                swal({ title: 'Create Department', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () { clear(); });
                                $("#btnDepartment").removeAttr("disabled");
                            }
                        },
                        error: function (e) {
                            swal({ title: 'Create Department', text: 'Create Department encountered an error', type: 'error' }).then(function () { clear(); });
                            $("#btnDepartment").removeAttr("disabled");
                        }
                    });
                }
            });
        }

    },
        function (dismiss) {
            swal('Create Department', 'You cancelled Department creation.', 'error');
            $("#btnDepartment").removeAttr("disabled");
        });

}