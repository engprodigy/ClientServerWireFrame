var customer;
var url_path = window.location.pathname;

$(document).ready(function () {
    $(".modal").perfectScrollbar();
});

function viewKYCModal(customerid) {
    customer = $("#kyc-data-table")
        .bootstrapTable('getRowByUniqueId', customerid);

    // Reset table body
    var table_body = $("#KYCtable > tbody");
    table_body.empty();

    // Set customer name and code in modal header
    var header = customer.surname
        + (customer.firstname? " "+customer.firstname : "")
        + " - " + customer.customercode;
    $("#KYCmodal .modal-header h5").text(header);
    
    // Load KYC items
    $.ajax(url_path + "/../LoadKYCItems/" + customer.customeraccounttype.name)
        .then(function (response) {
            $.each(response, function (index, val) {
                var table_row = $("<tr></tr>");
                table_row.attr("id", val.id);
                table_row.append("<td>" + val.displayOrder + "</td>");
                table_row.append("<td>" + val.item + "</td>");
                table_row.append(
                    "<td class='text-center'>" + ((val.mandatory) ? 'Yes' : 'No') + "</td>"
                );
                table_row.append("<td class='text-center'>-</td>");
                table_row.append("<td class='text-center'>-</td>");
                table_body.append(table_row);
            });
            if (customer.tblCustomeraccountkycitem.length !== 0) {
                $.each(customer.tblCustomeraccountkycitem, function (i, item) {
                    var row = table_body.children("[id=" + item.kycitemid + "]").first();
                    if (item.action) {
                        $(row.children()[3]).text(item.action.action);
                        if (item.actiondate) {
                            $(row.children()[4])
                                .text(item.actiondate.substr(0,10));
                        }
                    }
                });
            }
            // Show modal
            $("#KYCmodal").modal("show");
        });
}

var utilities = {
    viewKYCBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-info btn-icon' ",
            "onclick='viewKYCModal("+row.customerid+")'>",
            "<i class='now-ui-icons gestures_tap-01'>",
            "</i></button>"
        ].join("");
    },
};