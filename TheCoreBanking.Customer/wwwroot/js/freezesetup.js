function freezeTypeOperationFormatter(value, row, index) {
    return [
        '<a class="edit btn btn-sm btn-warning d-none d-sm-inline mr-2"  title="Edit Freeze Type">',
        '<i class="now-ui-icons ui-2_settings-90"></i> ',
        '</a>',
        '<a class="remove btn btn-sm btn-danger"  title="Delete Freeze Type">',
        '<i class="now-ui-icons ui-1_simple-remove"></i> ',
        '</a>'
    ].join('');
}
window.freezeTypeOperationEvents = {
    'click .edit': function (e, value, row, index) {
        if (row.state = true) {
            var data = JSON.stringify(row);
            $("#rowId").val(row.id)
            $('#FreezeType2').val(row.freezeType);
            if (row.active == true) {
                $('#Active2').val(row.active);
                $('#Active2').prop("checked",true);
            } else {
                $('#Active2').val(row.active);
                $('#Active2').prop("checked", false);
            }
            $('#Active2:checked').val(row.active);
            $('#FreezeTypeModal').modal('show');
            $('#btnFreezeTypeUpdate').html('<i class="now-ui-icons ui-1_check"></i> Update Record');
            $('#btnSaveFreezeType').hide();
            $('#btnFreezeTypeUpdate').show();
            $('#titleBSF1').hide();
            $('#titleBSF2').show();

        }
    },
    'click .remove': function (e, value, row, index) {
        debugger
        info = JSON.stringify(row);
        console.log(info);
        debugger;
        $.ajax({
            url: '../FreezeSetup/RemoveFreezeType',
            type: 'POST',
            data: { Id: row.id },
            success: function (data) {
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
                            }, 4000);
                        });
                    }
                }).then(function (isConfirm) {
                    if (isConfirm) {



                        swal("Deleted succesfully");
                        //alert('Deleted succesfully');
                        $('#transferTable').
                            bootstrapTable(
                                'refresh', { url: '../FreezeSetup/listfreezetype' });

                        //return false;
                    }
                    else {
                        swal("Freeze Type", "You cancelled delete freeze type.", "error");
                    }
                    $('#listfreezeTable').
                        bootstrapTable(
                            'refresh', { url: '../FreezeSetup/listfreezetype' });
                });
                return

            },

            error: function (e) {
                //alert("An exception occured!");
                swal("An exception occured!");
            }
        });
    }
};
$(document).ready(function ($) {
    $('#btnSaveFreezeType').hide();
    $('#btnFreezeTypeUpdate').show();
    $('#titleBSF1').hide();
    $('#titleBSF2').show();
    $('#btnFreezeTypeUpdate').on('click', function () {
            debugger
            var active = false;
            var freezeType = $('#FreezeType2').val();
            var Id = $('#rowId').val();
            if ($('#Active2').is(':checked'))
                active = true;
            else
                active = false;
            // $("button[type=submit]").attr("disabled", "disabled");

            $.ajax({
                url: '../FreezeSetup/UpdateFreezeOperation',
                type: 'POST',
                data: { FreezeType2: freezeType, Active2: active, rowId: Id },
                dataType: "json",
                //headers: {
                //    'VerificationToken': forgeryId
                //},
                success: function (result) {
                    alert(result);
                    if (result.toString !== '' && result !== null) {
                        swal({ title: 'Freeze Type', text: 'Freeze Type updated successfully!', type: 'success' }).then(function () { clear(); });

                        $('#listfreezeTable').
                            bootstrapTable(
                                'refresh', { url: 'FreezeSetup/listfreezetype' });

                        $("#btnFreezeTypeUpdate").removeAttr("disabled");
                    }
                    else {
                        swal({ title: 'Freeze Type', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () { clear(); });
                        $("#btnFreezeTypeUpdate").removeAttr("disabled");
                    }
                },
                error: function (e) {
                    swal({ title: 'Freeze Type', text: 'Freeze Type encountered an error', type: 'error' }).then(function () { clear(); });
                    $("#btnFreezeTypeUpdate").removeAttr("disabled");
                }
            });
    });

});
$(document).ready(function () {
    $('#btnSaveFreezeType').show();
    $('#btnFreezeTypeUpdate').hide();
    $('#titleBSF1').show();
    $('#titleBSF2').hide();
    $("#btnSaveFreezeType").click(function () {
        debugger
        var active = false;
        var freezeType = $('#FreezeType2').val();
       
        if ($('#Active2').is(':checked'))
            active = true;
        else
             active = false;
        // $("button[type=submit]").attr("disabled", "disabled");

        $.ajax({
            url: '../FreezeSetup/CreateFreezeOperation',
            type: 'POST',
            data: {FreezeType2: freezeType, Active2: active},
            dataType: "json",
            //headers: {
            //    'VerificationToken': forgeryId
            //},
            success: function (result) {
                alert(result);
                if (result.toString !== '' && result !== null) {
                    swal({ title: 'Freeze Type', text: 'Freeze Type added successfully!', type: 'success' }).then(function () { clear(); });

                    $('#listfreezeTable').
                        bootstrapTable(
                            'refresh', { url: 'FreezeSetup/listfreezetype' });

                    $("#btnSaveFreezeType").removeAttr("disabled");
                }
                else {
                    swal({ title: 'Freeze Type', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () { clear(); });
                    $("#btnSaveFreezeType").removeAttr("disabled");
                }
            },
            error: function (e) {
                swal({ title: 'Freeze Type', text: 'Freeze Type encountered an error', type: 'error' }).then(function () { clear(); });
                $("#btnSaveFreezeType").removeAttr("disabled");
            }
        });


    })
});

