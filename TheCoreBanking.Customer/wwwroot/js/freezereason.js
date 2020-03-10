function freezeReasonOperationFormatter(value, row, index) {
    return [
        '<a class="edit btn btn-sm btn-warning d-none d-sm-inline mr-2"  title="Edit Freeze Reason">',
        '<i class="now-ui-icons ui-2_settings-90"></i> ',
        '</a>',
        '<a class="remove btn btn-sm btn-danger"  title="Delete Freeze Reason">',
        '<i class="now-ui-icons ui-1_simple-remove"></i> ',
        '</a>'
    ].join('');
}
window.freezeReasonOperationEvents = {
    'click .edit': function (e, value, row, index) {
        debugger
        if (row.state = true) {
            var data = JSON.stringify(row);
            $("#rowId").val(row.id)
            $('#FreezeReason2').val(row.reason);
            $('#FreezeReasonModal2').modal('show');
            $('#btnFreezeReasonUpdate').html('<i class="now-ui-icons ui-1_check"></i> Update Record');
            $('#btnSaveFreezeReason').hide();
            $('#btnFreezeReasonUpdate').show();
            $('#titleBSR1').hide();
            $('#titleBSR2').show();
        }
    },
    'click .remove': function (e, value, row, index) {
        debugger
        info = JSON.stringify(row);
        console.log(info);
        debugger;
        $.ajax({
            url: '../FreezeSetup/RemoveFreezeReason',
            Reason: 'POST',
            data: { Id: row.id },
            success: function (data) {
                swal({
                    title: "Are you sure?",
                    text: "You are about to delete this record!",
                    Reason: "warning",
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
                        $('#listfreezeReasonTable').
                            bootstrapTable(
                                'refresh', { url: '../FreezeSetup/listfreezereasontype' });

                        //return false;
                    }
                    else {
                        swal("Freeze Reason", "You cancelled delete freeze Reason.", "error");
                    }
                    $('#listfreezeTable').
                        bootstrapTable(
                            'refresh', { url: '../FreezeSetup/listfreezereasontype' });
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
    $('#btnSaveFreezeReason').hide();
    $('#btnFreezeReasonUpdate').show();
    $('#titleBSR1').hide();
    $('#titleBSR2').show();
    $('#btnFreezeReasonUpdate').on('click', function () {
        debugger
        var active = false;
        var freezeReason = $('#FreezeReason').val();
        var Id = $('#rowId').val();
      
        // $("button[Reason=submit]").attr("disabled", "disabled");

        $.ajax({
            url: '../FreezeSetup/UpdateFreezeOperation',
            Reason: 'POST',
            data: { FreezeReason: freezeReason,rowId: Id },
            dataReason: "json",
            //headers: {
            //    'VerificationToken': forgeryId
            //},
            success: function (result) {
                alert(result);
                if (result.toString !== '' && result !== null) {
                    swal({ title: 'Freeze Reason', text: 'Freeze Reason updated successfully!', Reason: 'success' }).then(function () { clear(); });

                    $('#listfreezeTable').
                        bootstrapTable(
                            'refresh', { url: 'FreezeSetup/listfreezeReason' });

                    $("#btnFreezeReasonUpdate").removeAttr("disabled");
                }
                else {
                    swal({ title: 'Freeze Reason', text: 'Something went wrong: </br>' + result.toString(), Reason: 'error' }).then(function () { clear(); });
                    $("#btnFreezeReasonUpdate").removeAttr("disabled");
                }
            },
            error: function (e) {
                swal({ title: 'Freeze Reason', text: 'Freeze Reason encountered an error', Reason: 'error' }).then(function () { clear(); });
                $("#btnFreezeReasonUpdate").removeAttr("disabled");
            }
        });
    });

});
$(document).ready(function () {
    $('#btnSaveFreezeReason').show();
    $('#btnFreezeReasonUpdate').hide();
    $('#titleBSR1').show();
    $('#titleBSR2').hide();
    $("#btnSaveFreezeReason").click(function () {
        debugger
        var freezeReason = $('#FreezeReason2').val();
        
        // $("button[Reason=submit]").attr("disabled", "disabled");

        $.ajax({
            url: '../FreezeSetup/CreateFreezeReasonOperation',
            Reason: 'POST',
            data: { FreezeReason2: freezeReason },
            dataType: "json",
            //headers: {
            //    'VerificationToken': forgeryId
            //},
            success: function (result) {
                alert(result);
                if (result.toString !== '' && result !== null) {
                    swal({ title: 'Freeze Reason', text: 'Freeze Reason added successfully!', Reason: 'success' }).then(function () { clear(); });

                    $('#listfreezeReasonTable').
                        bootstrapTable(
                            'refresh', { url: 'FreezeSetup/listfreezereasontype' });

                    $("#btnSaveFreezeReason").removeAttr("disabled");
                }
                else {
                    swal({ title: 'Freeze Reason', text: 'Something went wrong: </br>' + result.toString(), Reason: 'error' }).then(function () { clear(); });
                    $("#btnSaveFreezeReason").removeAttr("disabled");
                }
            },
            error: function (e) {
                swal({ title: 'Freeze Reason', text: 'Freeze Reason encountered an error', Reason: 'error' }).then(function () { clear(); });
                $("#btnSaveFreezeReason").removeAttr("disabled");
            }
        });


    })
});

$(document).ready(function ($) {
    $('#btnSaveFreezeReason').hide();
    $('#btnFreezeReasonUpdate').show();
    $('#btnFreezeReasonUpdate').on('click', function () {
        debugger
        var active = false;
        var freezeReason = $('#FreezeReason2').val();
        var Id = $('#rowId').val();
       
        // $("button[type=submit]").attr("disabled", "disabled");

        $.ajax({
            url: '../FreezeSetup/UpdateFreezeReasonOperation',
            type: 'POST',
            data: { FreezeReason2: freezeReason, rowId: Id },
            dataType: "json",
            //headers: {
            //    'VerificationToken': forgeryId
            //},
            success: function (result) {
                alert(result);
                if (result.toString !== '' && result !== null) {
                    swal({ title: 'Freeze Reason', text: 'Freeze Reason updated successfully!', type: 'success' }).then(function () { clear(); });

                    $('#listfreezeReasonTable').
                        bootstrapTable(
                            'refresh', { url: 'FreezeSetup/listfreezereasontype' });

                    $("#btnFreezeReasonUpdate").removeAttr("disabled");
                }
                else {
                    swal({ title: 'Freeze Reason', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () { clear(); });
                    $("#btnFreezeReasonUpdate").removeAttr("disabled");
                }
            },
            error: function (e) {
                swal({ title: 'Freeze Reason', text: 'Freeze Reason encountered an error', type: 'error' }).then(function () { clear(); });
                $("#btnFreezeReasonUpdate").removeAttr("disabled");
            }
        });
    });

});

