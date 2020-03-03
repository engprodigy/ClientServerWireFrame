var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}


function refresh() {

    setTimeout(function () {
        location.reload()
    }, 100);
}

 
 
 
 

var utilities = {

    tillMapTypeTableFormatter: function (index, row, el) {
        var container = $("<div class='row mx-0'></div>");
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>Ledger :</b> "
            + row.creditaccount.type + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>Ledger Number :</b> "
            + row.accountnumber + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6 mb-2'><b>Date Created :</b> "
            + moment(row.datecreated).format("MMMM DD, YYYY") + "</div>"));
        container.append($("<div class='col-xs-12 col-md-6 mb-3 mt-2'><b>CreatedBy :</b> "
            + row.createdby + "</div>"));
        el.append(container);
    }

};