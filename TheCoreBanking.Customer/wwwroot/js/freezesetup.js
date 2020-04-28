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
                //$('#Active2').val(row.active);
                $('#Active2').prop("checked",true);
            } else {
                //$('#Active2').val(row.active);
                $('#Active2').prop("checked", false);
            }
            //$('#Active2:checked').val(row.active);
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
                $.ajax({
                    url: '../FreezeSetup/RemoveFreezeType',
                    type: 'POST',
                    data: { Id: row.id },
                    success: function (data) {
                        swal("Deleted succesfully");
                        //alert('Deleted succesfully');
                        $('#listfreezeTable').
                            bootstrapTable(
                                'refresh', { url: '../FreezeSetup/listfreezetype' });
                        return

                    },

                    error: function (e) {
                        //alert("An exception occured!");
                        swal("An exception occured!");
                    }
                });


              

                //return false;
            }
            else {
                swal("Freeze Type", "You cancelled delete freeze type.", "error");
            }
           
        });
       
    }
};
$(document).ready(function ($) {

    $("#FreezeTypeModal").on('hide.bs.modal', function () {
        $('#btnFreezeTypeUpdate').hide();
        $('#titleBSF2').hide();
        $('#btnSaveFreezeType').show();
        $('#titleBSF1').show();
        $('#FreezeType2').val("");
    });
   
    $('#btnFreezeTypeUpdate').on('click', function (event) {
       /* $('#btnSaveFreezeType').hide();
        $('#titleBSF1').hide();
        $('#btnFreezeTypeUpdate').show();
        $('#titleBSF2').show();*/
        debugger
        event.preventDefault(); 

            var active = false;
            var freezeType = $('#FreezeType2').val();
            var Id = $('#rowId').val();
            if ($('#Active2').is(':checked'))
                active = true;
            else
                active = false;
            // $("button[type=submit]").attr("disabled", "disabled");


        // $("button[Reason=submit]").attr("disabled", "disabled");
        swal({
            title: "Are you sure?",
            text: "You are about to update this record!",
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
                    }, 1000);
                });
                    }
                    }).then(function (isConfirm) {
                        if (isConfirm) {
                            $.ajax({
                                url: '../FreezeSetup/UpdateFreezeOperation',
                                type: 'POST',
                                data: { FreezeType2: freezeType, Active2: active, rowId: Id },
                                dataType: "json",
                                //headers: {
                                //    'VerificationToken': forgeryId
                                //},
                                success: function (result) {
                                    //alert(result);
                                    if (result.toString !== '' && result !== null) {
                                        swal({ title: 'Freeze Type', text: 'Freeze Type updated successfully!', type: 'success' }).then(function () {  });

                                        $('#listfreezeTable').
                                            bootstrapTable(
                                                'refresh', { url: 'FreezeSetup/listfreezetype' });

                                        $("#btnFreezeTypeUpdate").removeAttr("disabled");
                                        $('#FreezeTypeModal').modal('hide');
                                        
                                        $('#FreezeType2').val("");
                                    }
                                    else {
                                        swal({ title: 'Freeze Type', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () {  });
                                        $("#btnFreezeTypeUpdate").removeAttr("disabled");
                                    }
                                },
                                error: function (e) {
                                    swal({ title: 'Freeze Type', text: 'Freeze Type encountered an error', type: 'error' }).then(function () {  });
                                    $("#btnFreezeTypeUpdate").removeAttr("disabled");
                                }
                            });

                       }

                    }, function (isRejected) {

                swal("Freeze Type", "You cancelled freeze type update", "error");
                            $('#FreezeTypeModal').modal('hide');
                return;
            }); 

          /* */

        $('#btnFreezeTypeUpdate').hide();
        $('#titleBSF2').hide();
        $('#btnSaveFreezeType').show();
        $('#titleBSF1').show();
        $('#FreezeType2').val("");
    });

});
$(document).ready(function () {

    $('#btnFreezeTypeUpdate').hide();
    $('#titleBSF2').hide();

    $("#btnSaveFreezeType").click(function (event) {

        debugger

        event.preventDefault(); 

        var active = false;
        var freezeType = $('#FreezeType2').val();
       
        if ($('#Active2').is(':checked'))
            active = true;
        else
             active = false;
        // $("button[type=submit]").attr("disabled", "disabled");

        swal({
            title: "Are you sure?",
            text: "You are about to create a new freeze type!",
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
                    }, 1000);
                });
            }
        }).then(function (isConfirm) {
            if (isConfirm) {

                $.ajax({
                    url: '../FreezeSetup/CreateFreezeOperation',
                    type: 'POST',
                    data: { FreezeType2: freezeType, Active2: active },
                    dataType: "json",
                    //headers: {
                    //    'VerificationToken': forgeryId
                    //},
                    success: function (result) {
                        //alert(result);
                        if (result.toString !== '' && result !== null) {
                            swal({ title: 'Freeze Type', text: 'Freeze Type added successfully!', type: 'success' }).then(function () {  });

                            $('#listfreezeTable').
                                bootstrapTable(
                                    'refresh', { url: 'FreezeSetup/listfreezetype' });

                            $("#btnSaveFreezeType").removeAttr("disabled");
                            $('#FreezeTypeModal').modal('hide');
                            $('#FreezeType2').val("");
                        }
                        else {
                            swal({ title: 'Freeze Type', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () {  });
                            $("#btnSaveFreezeType").removeAttr("disabled");
                        }
                    },
                    error: function (e) {
                        swal({ title: 'Freeze Type', text: 'Freeze Type encountered an error', type: 'error' }).then(function () {  });
                        $("#btnSaveFreezeType").removeAttr("disabled");
                    }
                });
                }

                                }, function (isRejected) {

                swal("Freeze Reason", "You cancelled freeze type Creation", "error");
                $('#FreezeTypeModal').modal('hide');
                return;
            }); 
       /* */

        $('#FreezeType2').val("");
    })
});

