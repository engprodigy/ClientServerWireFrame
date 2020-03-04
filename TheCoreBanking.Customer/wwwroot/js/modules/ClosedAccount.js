 
var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}


$(document).ready(function ($) {
    initTillMapValidation();  
    //changeText();

    var AccountNumberPicked
});

function dateFormatter(value, row, $element) {
    var format = moment(value).format("DD MMMM, YYYY");
    var html = '<div>' + format + '</div>';
    return html;
}

function editCloseFormatter(value, row, index) {
    return [
        '<button type="button" class="edit btn btn-sm btn-warning" title="Edit">',
        '<i class="now-ui-icons ui-2_settings-90"></i>',
        '</button>'
    ].join('');
}

function deleteCloseFormatter(value, row, index) {
    return [
        '<button type="button" class="remove btn btn-sm btn-danger" title="Delete">',
        '<i class="now-ui-icons ui-1_simple-remove"></i> ',
        '</button>'
    ].join('');
}

//function changeText() {
//      document.getElementById("accountname").toUpperCase();
    
//}
 
 

$.ajax(url_path + "/GetChartOfAccountLocally")
    .then(function (response) {
        $("#chartofaccountid").select2({
            placeholder: "Select Ledger to credit",
            data: response,
            width: '100%',
            dropdownParent: $("#AddNewClosed.modal"),
        });
    });

 

function initTillMapValidation() {
    jQuery.validator.setDefaults({
        onfocusout: false,
        onkeyup: false,
        onclick: false,
        normalizer: function (value) {
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
    $("#frmAcctClosed").validate({
        messages: {
            name: {
                required: "Ledger Account is required"
            }
        }
    });
}



window.CloseEvents = {
    'click .edit': function (e, value, row, index) {     
 

        var form = $("#frmAcctClosed");
        form.trigger("reset");
        if (row.state = true) {
            form.find("[name=id]").val(row.id); 
            form.find("[name=accountnumber]").val(row.accountnumber);    
            form.find("[name=accountname]").val(row.accountname);   
           
               


            debugger         
            var acctNumber = document.getElementById('accountnumber').value;
            let chargesAmt;
                

            $.ajax({
                url: url_path + '/listPendingCharges',
                method: 'GET',
                data: {
                    'accountNumber': acctNumber
                    //,'Opstype': ctype
                },
                contentType: "application/json",
                success: function (result) { },
                error: function (e) {
                    swal({
                        title: 'Closed Account',
                        text: 'encountered error. unable to reach controller',
                        type: 'error'
                    })
                }
            }).then(function (result) {
                $("#interesetAccude").val(result.results[0].interestCalculation);
                $("#cotAccude").val(result.results[0].cotCalculation);
                $("#smsAccude").val(result.results[0].smsCalculation);
                $("#freezeAmount").val(result.results[0].freezePlaced);
                $("#availablebalance").val(result.results[0].endbal);
                $("#payableamount").val(result.results[0].payable);
                $("#chargesAccrue").val(result.results[0].chargesCalculation);
                chargesAmt = result.results[0].chargesCalculation;


                $('#chaneTitle').text("Update");
                form.find('#btnPostClosed').show();
                $('#AddNewClosed').modal('show');
            });
             
                        
        }



    },
  
};
  

function AddClosedAccounts() {
    // check if form is valid
    var form = $("#frmAcctClosed");
    if (!form.valid()) {
        return;
    }
    debugger
    var json_data = {};


    var payableamt = form.find("[name=payableamount]").val();
    var accountno = form.find("[name=accountnumber]").val();
    var availablebal = form.find("[name=availablebalance]").val();
    var freezeAmt = form.find("[name=freezeAmount]").val();
    var smsaccude = form.find("[name=smsAccude]").val();
    var cotaccude = form.find("[name=cotAccude]").val();
    var interesetaccude = form.find("[name=interesetAccude]").val();
    var charge = form.find("[name=charges]").val();
    //var ledgeracct = form.find("[name=ledgeraccount]").val();
    //var ledgeracct = form.find("#chartofaccountid").val();
    var ledgeracctid = form.find("#chartofaccountid").val();
    var commnt = form.find("[name=comment]").val();


    swal({
        title: "Are you sure?",
        text: "Close Account data will be submitted",
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
                debugger
                $.ajax(
                    url_path + "/AddClosedAccounts",
                    {
                        method: "POST",
                        dataType: "json",                
                         data: {
                             payableamount: payableamt, accountnumber: accountno, availablebalance: availablebal, freezeAmount: freezeAmt,
                             smsAccude: smsaccude, CotAccude: cotaccude, InteresetAccude: interesetaccude, Charges: charge, Ledgeraccountid: ledgeracctid, Comment: commnt
                           
                        },
                    }).then(
                        function (response) {
                            debugger
                            if (response == true){
                                swal({
                                    title: 'Close Account',
                                    text: 'successfully saved Close Account!',
                                    type: 'success'
                                }).then(function () {       
                                    window.location.reload();
                                 
                                });
                            }
                            else { 
                                    swal({
                                        title: "Close Account",
                                        type: "error",
                                        text: "This Account is either Closed or Pending For Closure!"
                                    }).then(function () {       
                                        window.location.reload();                                       
                                        
                                    });
                               
                            }
                           
                        },
                   
                    );
            }
        },
        function (isRejected) { return }
    );
}



var define = {

    CloseAcctTableFormatter: function (index, row, el) {
        var container = $("<div class='row mx-0'></div>");
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>Casaaccount Id :</b> " + row.casaaccountid + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>Product Id :</b> " + row.productid + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>Status:</b> " + row.accountstatusid + "</div>"));

        container.append($("<div class='col-xs-12 col-md-6 mb-2'><b>Date Created :</b> "
            + moment(row.datecreated).format("MMMM DD, YYYY") + "</div>"));
        el.append(container);      
    }
 
};
