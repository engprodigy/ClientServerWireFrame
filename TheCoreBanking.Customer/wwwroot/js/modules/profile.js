var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}
var CustomerType;
var UpdateCustomer;
var AddressTypes;
var LGAs = [];
var Industries = [];
var tracker = 0;
var data1 = [];
var selectedTab = [];


$(document).ready(function () {

    
    function initializeSelect2(selectElementObj) {
       /* selectElementObj.select2({
            width: "80%",
            tags: true
        });*/
        /*$.fn.select2.defaults.set("theme", "bootstrap4");
        $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
        $.fn.select2.defaults.set("width", "100%");
        $.fn.select2.defaults.set("allowClear", true);

        selectElementObj.select2({
            placeholder: "Select Options",
            allowClear: true,
            //   data: data
        }); */
    }
    
    
   

           /* $("#othersPrimary").append(customInputSelect);
            $("#othersPrimary").append(customInputCheckBox);
            $("#othersPrimary").append(customInputText);*/

    $.ajax({
        
        url: "../Setup/ListCustomFields",
        type: "GET",
        success: function (response) {

            debugger

            if (response != "") {

                var count = 0;

                $.each(response, function (index, value) {

                    count++;

                    console.log(value);
                    if (value.inputTypeId == 1) {
                        var customInputText = '<div class="row mb-2">' +
                            '<label class="col-md-2 col-form-label">' + value.inputLabel + '</label>' +
                            '<div class="col-md-10">' +
                            '<div class="form-group">' +
                            '<input name="customInputText' + count + '" id="customInputText' + count + '"' +
                            'type="text" class="form-control" />' +
                            ' </div>' +
                            '</div>' +
                            '</div>';

                       // $("#othersPrimary").append(customInputText);
                        $("#frmOthers").append(customInputText);

                    } else if (value.inputTypeId == 2) {
                        

                        $.get('../Setup/LoadCustomFieldOptions', { id: value.id }, function (result) {

                            var customInputCheckBox = '<div class="row mb-2">' +
                                '<label class="col-md-2 col-form-label">' + value.inputLabel + '</label>';

                            $.each(result, function (index, value) {

                                
                                customInputCheckBox += '<div class="col-md-3 mb-3">';
                                customInputCheckBox += '<div class="form-check pl-0">';
                                customInputCheckBox += '<label class="form-check-label">';
                                customInputCheckBox += '<input name="customInputCheckBox' + count + value.id + '" id="customInputCheckBox' + count + value.id + '"';
                                customInputCheckBox += 'class="form-check-input" type="checkbox">';
                                customInputCheckBox += '<span class="form-check-sign"></span> ' + value.optionName + '';
                                customInputCheckBox += '</label>';
                                customInputCheckBox += '</div>';
                                customInputCheckBox += '</div>';
                                console.log(value);

                            });

                            customInputCheckBox += '</div>';

                            $("#frmOthers").append(customInputCheckBox);

                        });

                        for (var i = 0; i < 3; i++) {

                           
                        }
                        
                          
                       

                    } else if (value.inputTypeId == 3) {
                        
                        var customInputDate = '<div class="row mb-2 ">' +
                            '<label class="col-md-2 col-form-label">' + value.inputLabel + '</label>' +
                            '<div class="col-md-10 ">' +
                            '<div class="form-group">' +
                            '<input name="DateType' + count + '" id="DateType' + count + '"' +
                            ' type="text" class="form-control datepickercustom" />' +
                            '</div>' +
                            '</div>' +
                            '</div>';
                        $("#frmOthers").append(customInputDate);

                        //initDatePicker(".datepickercustom");

                        if ($(".datepickercustom").length != 0) {
                            $(".datepickercustom").datetimepicker({
                                format: "Do MMM YYYY",
                                //format: "YYYY-MM-DD",
                                icons: {
                                    time: "now-ui-icons tech_watch-time",
                                    date: "now-ui-icons ui-1_calendar-60",
                                    up: "fa fa-chevron-up",
                                    down: "fa fa-chevron-down",
                                    previous: "now-ui-icons arrows-1_minimal-left",
                                    next: "now-ui-icons arrows-1_minimal-right",
                                    today: "fa fa-screenshot",
                                    clear: "fa fa-trash",
                                    close: "fa fa-remove"
                                }
                            });
                        }



                    } else if (value.inputTypeId == 4) {


                    } else if (value.inputTypeId == 5) {



                        
                        $.ajax({
                            type: "GET",
                            url: "../Setup/LoadCustomFieldOptions",
                            data: { id: value.id },
                            dataType: "json",
                            statusCode: {
                                404: function () {
                                    alert('page not found');
                                }
                            },
                            success: handleData
                            //function (result) {
                            //  data1.push(result);
                            //myFunction()
                            // }
                        });
                        function handleData(data) {

                            var customInputRadio = '<div class="row mb-4" id="ShowCashCheque" >';
                            customInputRadio += '<div class="col-xs-12 col-md-3 mt-1">';
                            customInputRadio += '<label>' + value.inputLabel + '</label>';
                            customInputRadio += '</div>';
                            customInputRadio += '<div class="col-xs-12 col-md-6 d-flex flex-row justify-content-between">';
                           
                            var optionName = value.inputName;

                            $.each(data, function (index, value) {

                               /* customInputRadio += '<div class="radio-item">';

                            customInputRadio += '<input type="radio" name="cash"';
                            customInputRadio += ' id="cheque"  value="cheque" required>';
                            customInputRadio += ' <label for="cheque">';
                            customInputRadio += '  <span class="form-check-sign"></span> Cheque</label>';
                                                                                    
                            customInputRadio += '  </div>';*/
                               

                                customInputRadio += '<div class="radio-item">';

                                customInputRadio += '<input type="radio" name="' + optionName + '"';
                                customInputRadio += 'id="' + value.optionName + '" value="' + value.optionName + '" >';
                                customInputRadio += '   <label for="' + value.optionName + '">';
                                customInputRadio += ' <span class="form-check-sign"></span> ' + value.optionName + '';
                                customInputRadio += '  </label>';
                                customInputRadio += ' </div>';


                            });

                            
                           /* customInputRadio += '<div class="radio-item">';

                            customInputRadio += '<input type="radio" name="cash"';
                            customInputRadio += ' id="cheque"  value="cheque" required>';
                            customInputRadio += ' <label for="cheque">';
                            customInputRadio += '  <span class="form-check-sign"></span> Cheque</label>';
                                                                                    
                            customInputRadio += '  </div>';*/
                            customInputRadio += ' </div>';
                            customInputRadio += ' </div>';

                            $("#frmOthers").append(customInputRadio);
                           
                           
                        }
                        

                    } else if (value.inputTypeId == 6) {

                       

                      

                          
                           

                      //  data1 = value.inputLabel;

                       // console.log(data1);

                       
                        //  customInputSelect += '<option value="' + count + value.id + '">' + value.optionName + '</option>'
                        $.ajax({
                            type: "GET",
                            url: "../Setup/LoadCustomFieldOptions",
                            data: { id: value.id },
                            dataType: "json",
                            statusCode: {
                                404: function () {
                                    alert('page not found');
                                }
                            },
                            success: handleData
                                //function (result) {
                              //  data1.push(result);
                                //myFunction()
                           // }
                        });
                        
                        function handleData(data) {


                            var customInputSelect = '<div class="row mb-2">' +
                                '<label class="col-md-2 col-form-label">' + value.inputLabel + '</label>' +
                                '<div class="col-md-10">' +
                                '<div class="form-group">' +
                                '<select id="customType' + count + value.id + '">';

                           // customInputSelect += '<option value="default"> Select' + value.inputLabel + '</option>'

                            $.each(data, function (index, value) {

                                customInputSelect += '<option value="' + count + value.id + '">' + value.optionName + '</option>'


                            }); 

                           
                            data1.push(data)
                            console.log(data1);
                            //do some stuff
                            customInputSelect += '</select>';
                            customInputSelect += '</div>';
                            customInputSelect += '</div>';
                            customInputSelect += '</div>';

                            $("#frmOthers").append(customInputSelect);


                            $.fn.select2.defaults.set("theme", "bootstrap4");
                            $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
                            $.fn.select2.defaults.set("width", "100%");
                            $.fn.select2.defaults.set("allowClear", true);


                            $("#customType" + count + value.id).select2({
                                placeholder: "Select Options",
                                allowClear: true,
                            });
                        }
                                               
                    }
                 
                
                })
            
          }
        }
    })
      
   // console.log(data1);
        // inputTypeId: 2, inputName: "Employment Month", inputLabel: "Employment Month"
   

    initDataTable();
    initSelectTwoConfig();
    initDatePicker(".datepicker");
    initFormValidations();
    initWizards();
   // $(".modal").perfectScrollbar();
    $(".card").perfectScrollbar();
    prepareKYCTables();

    $("#UpdateUploadFile").fileinput({
        theme: "fa",
        //hideThumbnailContent: true, // hide image, pdf, text or other content in the thumbnail preview
        allowedFileExtensions: ["jpg", "png", "gif"],
        msgSizeTooLarge: 'File  "{name}"  (<b> { size } KB</b >) exceeds maximum allowed upload size of < b > { maxSize } KB</b >.Please retry your upload!',
        msgInvalidFileExtension: 'Invalid extension for file. Only { extensions } files are supported.',
        msgFilePreviewAborted: 'File preview aborted for "{name}"',
    });


    

});

$('.modal').modal('handleUpdate');

function initDataTable() {
    
    $("#data-table").bootstrapTable('showLoading');
    
        
    $("#data-table").bootstrapTable({
        search: true,
        searchAlign: "right",
        detailView: true,
        detailFormatter: utilities.profileTableFormatter,
        url: url_path + "/Profile/LoadCustomers",
        showPaginationSwitch: true,
        pagination: true,
        mobileResponsive: true,
        checkOnInit: true,
        minWidth: 626,
        toolbar: "#custom-toolbar",
        showRefresh: true,
        showToggle: true,
        uniqueId: "customerid",
        buttonsClass: "danger",
        columns: [
            {
                field: "surname",
                title: "Surname",
                sortable: true
            },
            {
                field: "firstname",
                title: "Firstname",
                sortable: true
            }, {
                field: "customercode",
                title: "Customer Code",
                sortable: true,
                align: "right",
            }, {
                field: "customeraccounttype.name",
                title: "Account Type",
                sortable: true,
            },
            {
                field: null,
                align: "center",
                width: "5%",
                formatter: function (val, row, index) {
                    return[
                        "<div class='dropdown'>",
                        "<button class='btn btn-warning btn-icon' ",
                        "data-toggle='dropdown' type='button'>",
                        "<i class='now-ui-icons ui-2_settings-90'></i>",
                        "</button>",
                        "<div class='dropdown-menu dropdown-menu-right'>",
                        "<h6 class='dropdown-header'>Edit</h6>",
                        "<a class='dropdown-item'",
                        " onclick='initUpdate(" + row.customerid + ")'>",
                        "Profile",
                        "</a>",
                        "<a class='dropdown-item' id='" + row.customerid + "' ",
                        " onclick='handleAddressUpdate(this)'>",
                        "Address",
                        "</a>",
                        "<a class='dropdown-item' id='" + row.customerid + "' ",
                        " onclick='handleEmailUpdate(this)'>",
                        "Email",
                        "</a>",
                        "<a class='dropdown-item' id='" + row.customerid + "' ",
                        " onclick='handlePhoneUpdate(this)'>",
                        "Phone",
                        "</a>",
                        "</div>",
                        "</div>"
                    ].join("");
                }
            },
            
        ],
    });
   // $("#data-table").bootstrapTable("hideLoading");
}

function handleAddressUpdate(self) {
    UpdateCustomer = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self.id);

    utilities.updateWizardHeader("#addressUpdateModal");

    $.ajax(url_path + "/Profile/LoadCustomerAddresses/" + self.id)
        .then(function (response) {
            $("#addressUpdateTable").bootstrapTable("load", response);
            $("#addressUpdateTable").bootstrapTable("hideLoading");

            // show/hide form/table
            $("#frmAddressUpdate").closest("div.row").hide();
            $("#addressUpdateTable").closest("div.row").show();

            // swap title text
            $("#addressUpdateModal #title").text("Customer Address(es)");

            // Show modal
            $("#addressUpdateModal").modal("show");
        });
    
}

function handleEmailUpdate(self) {
    UpdateCustomer = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self.id);

    utilities.updateWizardHeader("#emailUpdateModal");

    $.ajax(url_path + "/Profile/LoadCustomerEmails/" + self.id)
        .then(function (response) {
            $("#emailUpdateTable").bootstrapTable("load", response);
            $("#emailUpdateTable").bootstrapTable("hideLoading");

            // show/hide form/table
            $("#frmEmailUpdate").closest("div.row").hide();
            $("#emailUpdateTable").closest("div.row").show();

            // swap title text
            $("#emailUpdateModal #title").text("Customer E-mail(s)");

            // Show modal
            $("#emailUpdateModal").modal("show");
        });
}

function handlePhoneUpdate(self) {
    UpdateCustomer = $("#data-table")
        .bootstrapTable('getRowByUniqueId', self.id);

    utilities.updateWizardHeader("#phoneUpdateModal");

    $.ajax(url_path + "/Profile/LoadCustomerPhones/" + self.id)
        .then(function (response) {
            $("#phoneUpdateTable").bootstrapTable("load", response);
            $("#phoneUpdateTable").bootstrapTable("hideLoading");

            // show/hide form/table
            $("#frmPhoneUpdate").closest("div.row").hide();
            $("#phoneUpdateTable").closest("div.row").show();

            // swap title text
            $("#phoneUpdateModal #title").text("Customer Phone(s)");

            // Show modal
            $("#phoneUpdateModal").modal("show");
        });
}

function initFormValidations() {
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

    $("#wizardComponent #frmGeneral, #updateWizard #frmGeneral")
        .each(function () {
            $(this).validate({
                rules: {
                    Staffnumber: {
                        maxlength: 50
                    }
                },
                messages: {
                    Staffnumber: {
                        required: "Staff number required if customer category is internal",
                        maxlength: jQuery.validator.format("Staff number cannot exceed {0} characters")
                    },
                    Customersensitivitylevelid: {
                        required: "Customer Sensitivity Level is required"
                    },
                    Institutiontypeid: {
                        required: "Customer institution type is required"
                    }
                }
            });
        });
    $("#wizardComponent #frmPersonalPrimary, #updateWizard #frmPersonalPrimary")
        .each(function () {
            $(this).validate({
                rules: {
                    Surname: {
                        maxlength: 200
                    },
                    Firstname: {
                        maxlength: 200
                    },
                    Othernames: {
                        maxlength: 200
                    },
                    Taxidnumber: {
                        maxlength: 50
                    },
                    Placeofbirth: {
                        maxlength: 200
                    },
                    Nationality: {
                        maxlength: 50
                    },
                    Hometown: {
                        maxlength: 100
                    },
                    Spousenamework: {
                        maxlength: 200
                    },
                    Foreignrpno: {
                        maxlength: 50
                    },
                    Spousephone: {
                        digits: true,
                        maxlength: 20
                    },
                    Spousemail: {
                        email: true,
                        maxlength: 100
                    },
                    Educationlevel: {
                        maxlength: 100
                    },
                    Firstchildname: {
                        maxlength: 200
                    },
                    Mothersmaidenname: {
                        maxlength: 100
                    },
                    phone1: {
                        digits: true,
                        maxlength: 50
                    },
                    phone2: {
                        digits: true,
                        maxlength: 50
                    },
                    email1: {
                        email: true,
                        maxlength: 200
                    },
                    email2: {
                        email: true,
                        maxlength: 200
                    },
                    address1: {
                        maxlength: 200
                    },
                    address2: {
                        maxlength: 200
                    },
                    City: {
                        maxlength: 50
                    },
                    Fax: {
                        digits: true,
                        maxlength: 20
                    },
                    Pobox: {
                        maxlength: 20
                    },
                    Idissueauthority: {
                        maxlength: 100
                    },
                    Idplaceofissue: {
                        maxlength: 100
                    },
                    Noksurname: {
                        maxlength: 200
                    },
                    Nokothernames: {
                        maxlength: 200
                    },
                    Nokemail: {
                        email: true,
                        maxlength: 100
                    },
                    Nokaddress: {
                        maxlength: 200
                    },
                    Nokphone: {
                        digits: true,
                        maxlength: 50
                    },
                    Bvn: {
                        digits: true,
                        maxlength: 11,
                        minlength:11
                    },
                    Nokrelationship: {
                        maxlength: 50
                    }
                },
                messages: {
                    Surname: {
                        required: "Surname is required",
                        maxlength: jQuery.validator.format("Surname cannot exceed {0} characters")
                    },
                    Firstname: {
                        required: "First name is required",
                        maxlength: jQuery.validator.format("First name cannot exceed {0} characters")
                    },
                    Othernames: {
                        maxlength: jQuery.validator.format("Other names cannot exceed {0} characters")
                    },
                    Taxidnumber: {
                        maxlength: jQuery.validator.format("TIN cannot exceed {0} characters")
                    },
                    Dateofbirth: "Date of birth is required",
                    Placeofbirth: {
                        maxlength: jQuery.validator.format("Place of Birth cannot exceed {0} characters")
                    },
                    Genderid: "Gender is required",
                    Nationality: {
                        required: "Nationality is required",
                        maxlength: jQuery.validator.format("Nationality cannot exceed {0} characters")
                    },
                    Hometown: {
                        maxlength: jQuery.validator.format("Home town cannot exceed {0} characters")
                    },
                    Spousenamework: {
                        maxlength: jQuery.validator.format("Spouse name/work cannot exceed {0} characters")
                    },
                    Foreignrpno: {
                        maxlength: jQuery.validator.format("Foreign residential permit no. cannot exceed {0} characters")
                    },
                    Spousephone: {
                        maxlength: jQuery.validator.format("Spouse's phone number cannot exceed {0} characters"),
                        digits: "Spouse's phone number can contain only digits"
                    },
                    Spousemail: {
                        email: "Spouse's email format is invalid",
                        maxlength: jQuery.validator.format("Spouse's email cannot exceed {0} characters")
                    },
                    Educationlevel: {
                        maxlength: jQuery.validator.format("Education level cannot exceed {0} characters")
                    },
                    Firstchildname: {
                        maxlength: jQuery.validator.format("Name of first child cannot exceed {0} characters")
                    },
                    Mothersmaidenname: {
                        maxlength: jQuery.validator.format("Mother's maiden name cannot exceed {0} characters")
                    },
                    phone1: {
                        required: "Mobile phone number is required",
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Mobile phone number cannot exceed {0} characters")
                    },
                    phone2: {
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Home phone number cannot exceed {0} characters")
                    },
                    email1: {
                        email: "E-mail 1 format not valid",
                        maxlength: jQuery.validator.format("Email 1 cannot exceed {0} characters")
                    },
                    email2: {
                        email: "E-mail 2 format not valid",
                        maxlength: jQuery.validator.format("Email 2 cannot exceed {0} characters")
                    },
                    address1: {
                        required: "Residential address is required",
                        maxlength: jQuery.validator.format("Residential address cannot exceed {0} characters")
                    },
                    address2: {
                        maxlength: jQuery.validator.format("Mailing address cannot exceed {0} characters")
                    },
                    City: {
                        required: "City is required",
                        maxlength: jQuery.validator.format("City cannot exceed {0} characters")
                    },
                    Fax: {
                        digits: "Fax can contain only digits",
                        maxlength: jQuery.validator.format("Fax cannot exceed {0} characters")
                    },
                    State: "State is required",
                    Country: "Country is required",
                    Modeofidentificationid: "Mode of identity is required",
                    Pobox: {
                        maxlength: jQuery.validator.format("P.O. Box cannot exceed {0} characters")
                    },
                    Idissueauthority: {
                        maxlength: jQuery.validator.format("ID issue authority cannot exceed {0} characters")
                    },
                    Idplaceofissue: {
                        maxlength: jQuery.validator.format("ID place of issue cannot exceed {0} characters")
                    },
                    Noksurname: {
                        maxlength: jQuery.validator.format("Next of Kin's surname cannot exceed {0} characters")
                    },
                    Nokothernames: {
                        maxlength: jQuery.validator.format("Next of Kin's other name cannot exceed {0} characters")
                    },
                    Nokemail: {
                        email: "Next of Kin's email format is invalid",
                        maxlength: jQuery.validator.format("Next of Kin's email cannot exceed {0} characters")
                    },
                    Nokaddress: {
                        maxlength: jQuery.validator.format("Next of Kin's address cannot exceed {0} characters")
                    },
                    Nokphone: {
                        digits: "Next of Kin's mobile phone can contain only digits",
                        maxlength: jQuery.validator.format("Next of Kin's mobile phone cannot exceed {0} characters")
                    },
                    Bvn: {
                        required: "BVN is required",
                        digits: "BVN can contain only digits",
                        maxlength: jQuery.validator.format("BVN cannot exceed {0} characters")
                    },
                    Nokrelationship: {
                        maxlength: jQuery.validator.format("Next of Kin's relationship cannot exceed {0} characters")
                    }
                },
                ignore: false
            });
        });
    $("#wizardComponent #frmPersonalSecondary, #updateWizard #frmPersonalSecondary")
        .each(function () {
            $(this).validate({
                rules: {
                    Surname: {
                        maxlength: 200
                    },
                    Firstname: {
                        maxlength: 200
                    },
                    Othernames: {
                        maxlength: 200
                    },
                    Taxidnumber: {
                        maxlength: 50
                    },
                    Placeofbirth: {
                        maxlength: 200
                    },
                    Nationality: {
                        maxlength: 50
                    },
                    Hometown: {
                        maxlength: 100
                    },
                    Spousenamework: {
                        maxlength: 200
                    },
                    Foreignrpno: {
                        maxlength: 50
                    },
                    Spousephone: {
                        digits: true,
                        maxlength: 20
                    },
                    Spousemail: {
                        email: true,
                        maxlength: 100
                    },
                    Educationlevel: {
                        maxlength: 100
                    },
                    Firstchildname: {
                        maxlength: 200
                    },
                    Mothersmaidenname: {
                        maxlength: 100
                    },
                    phone1: {
                        digits: true,
                        maxlength: 50
                    },
                    phone2: {
                        digits: true,
                        maxlength: 50
                    },
                    email1: {
                        email: true,
                        maxlength: 200
                    },
                    email2: {
                        email: true,
                        maxlength: 200
                    },
                    address1: {
                        maxlength: 200
                    },
                    address2: {
                        maxlength: 200
                    },
                    City: {
                        maxlength: 50
                    },
                    Fax: {
                        digits: true,
                        maxlength: 20
                    },
                    Pobox: {
                        maxlength: 20
                    },
                    Idissueauthority: {
                        maxlength: 100
                    },
                    Idplaceofissue: {
                        maxlength: 100
                    },
                    Noksurname: {
                        maxlength: 200
                    },
                    Nokothernames: {
                        maxlength: 200
                    },
                    Nokemail: {
                        email: true,
                        maxlength: 100
                    },
                    Nokaddress: {
                        maxlength: 200
                    },
                    Nokphone: {
                        digits: true,
                        maxlength: 50
                    },
                    Bvn: {
                        digits: true,
                        maxlength: 11,
                        minlength: 11
                    },
                    Nokrelationship: {
                        maxlength: 50
                    }
                },
                messages: {
                    Surname: {
                        required: "Joint name is required",
                        maxlength: jQuery.validator.format("Joint name cannot exceed {0} characters")
                    },
                    Firstname: {
                        required: "First name is required",
                        maxlength: jQuery.validator.format("First name cannot exceed {0} characters")
                    },
                    Othernames: {
                        maxlength: jQuery.validator.format("Other names cannot exceed {0} characters")
                    },
                    Taxidnumber: {
                        maxlength: jQuery.validator.format("TIN cannot exceed {0} characters")
                    },
                    Dateofbirth: "Date of birth is required",
                    Placeofbirth: {
                        maxlength: jQuery.validator.format("Place of Birth cannot exceed {0} characters")
                    },
                    Genderid: "Gender is required",
                    Nationality: {
                        required: "Nationality is required",
                        maxlength: jQuery.validator.format("Nationality cannot exceed {0} characters")
                    },
                    Hometown: {
                        maxlength: jQuery.validator.format("Home town cannot exceed {0} characters")
                    },
                    Spousenamework: {
                        maxlength: jQuery.validator.format("Spouse name/work cannot exceed {0} characters")
                    },
                    Foreignrpno: {
                        maxlength: jQuery.validator.format("Foreign residential permit no. cannot exceed {0} characters")
                    },
                    Spousephone: {
                        maxlength: jQuery.validator.format("Spouse's phone number cannot exceed {0} characters"),
                        digits: "Spouse's phone number can contain only digits"
                    },
                    Spousemail: {
                        email: "Spouse's email format is invalid",
                        maxlength: jQuery.validator.format("Spouse's email cannot exceed {0} characters")
                    },
                    Educationlevel: {
                        maxlength: jQuery.validator.format("Education level cannot exceed {0} characters")
                    },
                    Firstchildname: {
                        maxlength: jQuery.validator.format("Name of first child cannot exceed {0} characters")
                    },
                    Mothersmaidenname: {
                        maxlength: jQuery.validator.format("Mother's maiden name cannot exceed {0} characters")
                    },
                    phone1: {
                        required: "Mobile phone number is required",
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Mobile phone number cannot exceed {0} characters")
                    },
                    phone2: {
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Home phone number cannot exceed {0} characters")
                    },
                    email1: {
                        email: "E-mail 1 format not valid",
                        maxlength: jQuery.validator.format("Email 1 cannot exceed {0} characters")
                    },
                    email2: {
                        email: "E-mail 2 format not valid",
                        maxlength: jQuery.validator.format("Email 2 cannot exceed {0} characters")
                    },
                    address1: {
                        required: "Residential address is required",
                        maxlength: jQuery.validator.format("Residential address cannot exceed {0} characters")
                    },
                    address2: {
                        maxlength: jQuery.validator.format("Mailing address cannot exceed {0} characters")
                    },
                    City: {
                        required: "City is required",
                        maxlength: jQuery.validator.format("City cannot exceed {0} characters")
                    },
                    Fax: {
                        digits: "Fax can contain only digits",
                        maxlength: jQuery.validator.format("Fax cannot exceed {0} characters")
                    },
                    State: "State is required",
                    Country: "Country is required",
                    Modeofidentificationid: "Mode of identity is required",
                    Pobox: {
                        maxlength: jQuery.validator.format("P.O. Box cannot exceed {0} characters")
                    },
                    Idissueauthority: {
                        maxlength: jQuery.validator.format("ID issue authority cannot exceed {0} characters")
                    },
                    Idplaceofissue: {
                        maxlength: jQuery.validator.format("ID place of issue cannot exceed {0} characters")
                    },
                    Noksurname: {
                        maxlength: jQuery.validator.format("Next of Kin's surname cannot exceed {0} characters")
                    },
                    Nokothernames: {
                        maxlength: jQuery.validator.format("Next of Kin's other name cannot exceed {0} characters")
                    },
                    Nokemail: {
                        email: "Next of Kin's email format is invalid",
                        maxlength: jQuery.validator.format("Next of Kin's email cannot exceed {0} characters")
                    },
                    Nokaddress: {
                        maxlength: jQuery.validator.format("Next of Kin's address cannot exceed {0} characters")
                    },
                    Nokphone: {
                        digits: "Next of Kin's mobile phone can contain only digits",
                        maxlength: jQuery.validator.format("Next of Kin's mobile phone cannot exceed {0} characters")
                    },
                    Bvn: {
                        digits: "BVN can contain only digits",
                        maxlength: jQuery.validator.format("BVN cannot exceed {0} characters")
                    },
                    
                    Nokrelationship: {
                        maxlength: jQuery.validator.format("Next of Kin's relationship cannot exceed {0} characters")
                    }, Bvn: {
                        required: "BVN is required",
                        digits: "BVN can contain only digits",
                        maxlength: jQuery.validator.format("BVN cannot exceed {0} characters")
                    }
                },
                ignore: false
            });
        });
    $("#wizardComponent #frmOfficialPrimary, #updateWizard #frmOfficialPrimary")
        .each(function () {
            $(this).validate({
                rules: {
                    Occupation: {
                        maxlength: 100
                    },
                    Currentemployer: {
                        maxlength: 50
                    },
                    Workaddress: {
                        maxlength: 200
                    },
                    Workphone: {
                        maxlength: 50,
                        digits: true
                    },
                    Previousemployer: {
                        maxlength: 100
                    }
                },
                messages: {
                    Occupation: {
                        maxlength: jQuery.validator.format("Occupation cannot exceed {0} characters")
                    },
                    Currentemployer: {
                        maxlength: jQuery.validator.format("Current employer cannot exceed {0} characters")
                    },
                    Workaddress: {
                        maxlength: jQuery.validator.format("Work address cannot exceed {0} characters")
                    },
                    Workphone: {
                        digits: "Telephone can only contain digits",
                        maxlength: jQuery.validator.format("Telephone cannot exceed {0} characters")
                    },
                    Previousemployer: {
                        maxlength: jQuery.validator.format("Previous employer cannot exceed {0} characters")
                    }
                }
            });
        });
    $("#wizardComponent #frmOfficialSecondary, #updateWizard #frmOfficialSecondary")
        .each(function () {
            $(this).validate({
                rules: {
                    Surname: {
                        maxlength: 200
                    },
                    Rcnumber: {
                        maxlength: 50
                    },
                    Taxidnumber: {
                        maxlength: 50
                    },
                    Natureofbusiness: {
                        maxlength: 200
                    },
                    address1: {
                        maxlength: 200
                    },
                    City: {
                        maxlength: 50
                    },
                    address2: {
                        maxlength: 200
                    },
                    address3: {
                        maxlength: 200
                    },
                    Scumlnumber: {
                        maxlength: 50
                    },
                    Fax: {
                        maxlength: 20,
                        digits: true
                    },
                    phone1: {
                        maxlength: 50,
                        digits: true
                    },
                    phone2: {
                        maxlength: 50,
                        digits: true
                    },
                    email1: {
                        maxlength: 200,
                        email: true
                    },
                    email2: {
                        maxlength: 200,
                        email: true
                    },
                    Businesswebsite: {
                        url: true,
                        maxlength: 100
                    },
                    Pobox: {
                        maxlength: 20
                    },
                    Namercrelatedcoys: {
                        maxlength: 200
                    },
                    Namercparentbody: {
                        maxlength: 200
                    }
                },
                messages: {
                    Surname: {
                        required: "Company name is required",
                        maxlength: jQuery.validator.format("Company name cannot exceed {0} characters")
                    },
                    Rcnumber: {
                        required: "RC Number is required",
                        maxlength: jQuery.validator.format("RC number cannot exceed {0} characters")
                    },
                    Businessstartdate: "Incorporation date is required",
                    Taxidnumber: {
                        required: "Tax identification number is required",
                        maxlength: jQuery.validator.format("Tax identification no. cannot exceed {0} characters")
                    },
                    Natureofbusiness: {
                        required: "Nature of business is required",
                        maxlength: jQuery.validator.format("Nature of business cannot exceed {0} characters")
                    },
                    address1: {
                        required: "Registered address is required",
                        maxlength: jQuery.validator.format("Registered address cannot exceed {0} characters")
                    },
                    City: {
                        required: "City is required",
                        maxlength: jQuery.validator.format("City cannot exceed {0} characters")
                    },
                    address2: {
                        maxlength: jQuery.validator.format("Business address 2 cannot exceed {0} characters")
                    },
                    address3: {
                        maxlength: jQuery.validator.format("Mailing address cannot exceed {0} characters")
                    },
                    Scumlnumber: {
                        maxlength: jQuery.validator.format("SCUML number cannot exceed {0} characters")
                    },
                    Fax: {
                        digits: "Fax can contain only digits",
                        maxlength: jQuery.validator.format("Fax cannot exceed {0} characters")
                    },
                    Country: "Country is required",
                    State: "State is required",
                    phone1: {
                        required: "Transaction account phone number is required",
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Transact. acct. phone number cannot exceed {0} characters")
                    },
                    phone2: {
                        digits: "Phone number(s) can only contain digits",
                        maxlength: jQuery.validator.format("Phone 2 cannot exceed {0} characters")
                    },
                    email1: {
                        email: "E-mail format not valid",
                        maxlength: jQuery.validator.format("Transact. acct. email cannot exceed {0} characters")
                    },
                    email2: {
                        email: "E-mail format not valid",
                        maxlength: jQuery.validator.format("Email 2 cannot exceed {0} characters")
                    },
                    Businesswebsite: {
                        url: "Website format is invalid",
                        maxlength: jQuery.validator.format("Business website cannot exceed {0} characters")
                    },
                    Pobox: {
                        maxlength: jQuery.validator.format("P.O. box cannot exceed {0} characters")
                    },
                    Namercrelatedcoys: {
                        maxlength: jQuery.validator.format("Name/RC No. of related coys cannot exceed {0} characters")
                    },
                    Namercparentbody: {
                        maxlength: jQuery.validator.format("Name/RC No. of parent body cannot exceed {0} characters")
                    }
                }
            });
        });
    $("#wizardComponent #frmBank, #updateWizard #frmBank")
        .each(function () {
            $(this).validate({
                rules: {
                    Bankaddress: {
                        maxlength: 200
                    },
                    Bankaccountnumber: {
                        maxlength: 10,
                        minlength:10,
                        digits: true
                    },
                    Bvn: {
                        maxlength: 11,
                        minlength: 11,
                        digits: true
                    }
                },
                messages: {
                    Bankaddress: {
                        maxlength: jQuery.validator.format("Bank address cannot exceed {0} characters")
                    },
                    Bankaccountnumber: {
                        required: "Bank Account Number is required",
                        digits: "Account number can only contain digits",
                        maxlength: jQuery.validator.format("Account no. cannot exceed {0} characters")
                    },
                    Bvn: {
                        required: "BVN is required",
                        digits: "BVN can only contain digits",
                        maxlength: jQuery.validator.format("BVN cannot exceed {0} characters")
                    }
                }
            });
        });
    $("#wizardComponent #frmKyc").validate();
    $("#frmAddressUpdate").validate({
        rules: {
            address: {
                maxlength: 200
            },
            city: {
                maxlength: 50
            }
        },
        messages: {
            address: {
                required: "Address is required",
                maxlength: jQuery.validator.format("Address cannot exceed {0} characters")
            },
            addresstypeid: {
                required: "Address type is required"
            },
            city: {
                required: "City is required",
                maxlength: jQuery.validator.format("City cannot exceed {0} characters")
            },
            stateid: { required: "State is required" },
            countryid: { required: "Country is required" }
        }
    });
    $("#frmPhoneUpdate").validate({
        rules: {
            phone: {
                maxlength: 50,
                digits: true
            }
        },
        messages: {
            phone: {
                required: "Phone number is required",
                maxlength: jQuery.validator.format("Phone number cannot exceed {0} characters"),
                digits: "Phone number can only contain digits",
            }
        }
    });
    $("#frmEmailUpdate").validate({
        rules: {
            email: {
                maxlength: 200,
                email: true
            }
        },
        messages: {
            required: "E-mail is required",
            email: "E-mail format is invalid",
            maxlength: jQuery.validator.format("E-mail cannot exceed {0} characters")
        }
    });
}

function showKYCUpload(uploadid) {
    // set placeholder image
    $("#kyc-preview-modal").find("img")
        .attr("src", url_path + "/css/img/loading-sm.gif");
    // set real image
    $("#kyc-preview-modal").find("img")
        .attr("src", url_path + "/Profile/LoadKYCDocument/" + uploadid);
    // set title
    $("#kyc-preview-modal")
        .find(".modal-title").text(
        $("#kycupload-update-data-table")
            .bootstrapTable("getRowByUniqueId", uploadid)
            .title
    );
    // show modal
    $("#kyc-preview-modal").modal("show");
}

function openModal(e) {
    $('#wizardComponent').bootstrapWizard("resetWizard");
    CustomerType = e;
    switch (e.text.toLowerCase()) {
        case "individual":
        case "minor":
            $("#wizardComponent").bootstrapWizard("hide", 1);
            $("#wizardComponent").bootstrapWizard("hide", 5);
            $("#wizardComponent").bootstrapWizard("display", 0);
            $("#wizardComponent").bootstrapWizard("display", 4);

            // hide and disable institution type
            $("#wizardComponent #Institutiontypeid").attr("disabled", "true");
            $("#wizardComponent .institution-hide").hide();
            // handle minor and individual dob logic
            var datefield =
                $("#wizardComponent #frmPersonalPrimary input[name=Dateofbirth]");
            
            if (e.text.toLowerCase() == "minor") {
                datefield.data("DateTimePicker").maxDate(
                    moment()
                );
                datefield.data("DateTimePicker").minDate(
                    moment().subtract(18, "years")
                        .add(1, "days")
                );
            } else {
                datefield.data("DateTimePicker").minDate(
                    false
                );
                datefield.data("DateTimePicker").maxDate(
                    moment().subtract(18, "years")
                );
            }
            debugger
            console.log(selectedTab);
            selectedTab = [];
            selectedTab.push("li.nav-item.personalPrimary");
            selectedTab.push("li.nav-item.general");
            selectedTab.push("li.nav-item.kyc");
            selectedTab.push("li.nav-item.officialPrimary");
            selectedTab.push("li.nav-item.bank");


            break;
        case "estate":
        case "joint":
            $('#wizardComponent').bootstrapWizard("show", 1);

            $("#wizardComponent").bootstrapWizard("hide", 0);
            $("#wizardComponent").bootstrapWizard("hide", 4);
            $("#wizardComponent").bootstrapWizard("hide", 5);
            $("#wizardComponent").bootstrapWizard("display", 1);

            $("#wizardComponent #Institutiontypeid").removeAttr("disabled");
            $("#wizardComponent .institution-hide").show();
            selectedTab = [];
            selectedTab.push("li.nav-item.personalSecondary");
            selectedTab.push("li.nav-item.general");
            selectedTab.push("li.nav-item.kyc");
            selectedTab.push("li.nav-item.bank");
            
            break;
        case "unincorporated":
        case "corporate":
            $('#wizardComponent').bootstrapWizard("show", 2);

            $("#wizardComponent").bootstrapWizard("hide", 0);
            $("#wizardComponent").bootstrapWizard("hide", 1);
            $("#wizardComponent").bootstrapWizard("hide", 4);
            $("#wizardComponent").bootstrapWizard("display", 5);

            $("#wizardComponent #Institutiontypeid").removeAttr("disabled");
            $("#wizardComponent .institution-hide").show();
            selectedTab = [];
            selectedTab.push("li.nav-item.general");
            selectedTab.push("li.nav-item.kyc");
            selectedTab.push("li.nav-item.officialSecondary");
            selectedTab.push("li.nav-item.bank");
            break;
    };

    // hide/disable or show/enable KYC tables/fields
    $("#kyc #frmKyc table").addClass("d-none");
    var table_name = "#KYC" + e.text.substr(0, 1).toUpperCase() + e.text.substr(1);
    if (!$(table_name).hasClass("empty")) {
        $(table_name).removeClass("d-none");
    }

    // add customer type to wizard header
    $("#wizardComponent #createCustType")
        .text(e.text);

    // set active wizard & show modal
    $('#wizardModal').modal('show');
    $("#updateWizard").removeClass("active").hide();
    $("#wizardComponent").addClass("active").show();
}

function initUpdate(customerid) {
    // Clear form fields & Reset wizard
    clear();
    $('#updateWizard').bootstrapWizard("resetWizard");
    var row = $("#data-table")
        .bootstrapTable('getRowByUniqueId', customerid);
    
    UpdateCustomer = row;

    utilities.updateWizardHeader("#updateWizard");

    // hide/disable or show/enable KYC tables/fields
    $("#kycU #frmKyc table").addClass("d-none");
    var table_name = "#kycU #KYC" + UpdateCustomer.customeraccounttype.name;
    if (!$(table_name).hasClass("empty")) {
        $(table_name).removeClass("d-none");
    }

    // request KYC Uploads
    $.ajax(url_path + "/Profile/ListKYCUploads/" + customerid)
        .then(function (response) {
            $("#kycupload-update-data-table").bootstrapTable("load", response);
        });
    
    utilities.populateGeneral(UpdateCustomer);
    utilities.populateBank(UpdateCustomer);
    utilities.populateKYC(UpdateCustomer.tblCustomeraccountkycitem, table_name);

    switch (UpdateCustomer.customeraccounttype.name.toLowerCase()) {
        case "individual":
        case "minor":
            $("#updateWizard").bootstrapWizard("hide", 1);
            $("#updateWizard").bootstrapWizard("hide", 5);
            $("#updateWizard").bootstrapWizard("display", 0);
            $("#updateWizard").bootstrapWizard("display", 4);

            // hide and disable institution type
            $("#updateWizard #Institutiontypeid").attr("disabled", "true");
            $("#updateWizard .institution-hide").hide();
            // populate fields
            utilities.populatePersonal(row);
            utilities.populateOfficialPrimary(row);
            break;
        case "estate":
        case "joint":
            $('#updateWizard').bootstrapWizard("show", 1);

            $("#updateWizard").bootstrapWizard("hide", 0);
            $("#updateWizard").bootstrapWizard("hide", 4);
            $("#updateWizard").bootstrapWizard("hide", 5);
            $("#updateWizard").bootstrapWizard("display", 1);

            $("#updateWizard #Institutiontypeid").removeAttr("disabled");
            $("#updateWizard .institution-hide").show();
            // populate fields
            utilities.populatePersonal(row, false);
            break;
        case "unincorporated":
        case "corporate":
            $('#updateWizard').bootstrapWizard("show", 2);

            $("#updateWizard").bootstrapWizard("hide", 0);
            $("#updateWizard").bootstrapWizard("hide", 1);
            $("#updateWizard").bootstrapWizard("hide", 4);
            $("#updateWizard").bootstrapWizard("display", 5);

            $("#updateWizard #Institutiontypeid").removeAttr("disabled");
            $("#updateWizard .institution-hide").show();
            // populate fields
            utilities.populateOfficialSecondary(row);
            break;
    };

    // Show modal
    $('#wizardModal').modal('show');
    $("#wizardComponent").removeClass("active").hide();
    $("#updateWizard").addClass("active").show();
}

function prepareKYCTables() {
    var configs = {};
    var KYCItemActions = {};
    $.when(
        $.ajax(url_path + "/Profile/LoadKYCItems/individual")
            .then(function(response) {
                configs.individual = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItems/minor")
            .then(function(response) {
                configs.minor = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItems/corporate")
            .then(function (response) {
                configs.corporate = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItems/joint")
            .then(function (response) {
                configs.joint = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItems/estate")
            .then(function (response) {
                configs.estate = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItems/unincorporated")
            .then(function (response) {
                configs.unincorporated = response;
            }),
        $.ajax(url_path + "/Profile/LoadKYCItemActions")
            .then(function (response) {
                KYCItemActions = response;
            })
    ).then(
        function () {
            $.each(configs, function (name, value) {
                var create_table = "#kyc #KYC" + name.substr(0, 1).toUpperCase() + name.substr(1);
                var update_table = "#kycU #KYC" + name.substr(0, 1).toUpperCase() + name.substr(1);
                var table_name = create_table + ", " + update_table;
                if (value.length == 0) {
                    $(table_name).addClass("empty");
                    return;
                }
                var table_body = $(create_table + " > tbody, " + update_table + " > tbody");
                $.each(value, function (index, val) {
                    var input = "<div class='form-group mb-0'>" +
                        "<input name='dt_" + val.id + "' type='text' style='visibility:hidden'" +
                        " id='dt_" + val.id + "' disabled" +
                        " data-msg-required='Date required if item is deferred'" +
                        " class='form-control KYCdatepicker' required />" +
                        "</div>";
                    var select = "<select " + (val.mandatory ? "required" : "") +
                        " data-msg-required='Item " + val.displayOrder +
                        " requires a mandatory action' name='slt_" + val.id + "'>" +
                        "<option></option></select>";
                    var table_row = $("<tr></tr>");
                    table_row.append("<td>"+ val.displayOrder +"</td>");
                    table_row.append("<td>" + val.item + "</td>");
                    table_row.append(
                        "<td class='text-center'>" + ((val.mandatory) ? 'Yes' : 'No') + "</td>"
                    );
                    table_row.append("<td>" + select + "</td>");
                    table_row.append("<td>" + input + "</td>");
                    table_body.append(table_row);
                })
            });
            // initialize datepicker config for KYC item dates
            initDatePickerKYCFormat("#frmKyc .KYCdatepicker");

            // initialize select2 config for KYC item selects
            $("#frmKyc select").select2({
                placeholder: "Select an action",
                data: KYCItemActions,
                allowClear: true
            })
            // attach event handlers to KYC select2 items
            .each(function (i, el) {
                $(el).on("select2:select", function (opt) {
                    var date = $(this).closest("tr").find("input.KYCdatepicker");
                    if (opt.params.data.text.toLowerCase() === "deferred") {
                        $(date).removeAttr("disabled");
                        $(date).css("visibility", "visible");
                    } else {
                        $(date).val("");
                        $(date).attr("disabled", "true");
                        $(date).css("visibility", "hidden");
                    }
                }).on("select2:unselect", function (opt) {
                    var date = $(this).closest("tr").find("input.KYCdatepicker");
                    $(date).val("");
                    $(date).attr("disabled", "true");
                    $(date).css("visibility", "hidden");
                });
            });
        },
        function () {
            throw new DOMException("Cannot resolve KYC items request!");
        }
    );
}

function initDatePicker(selector) {
    if ($(selector).length != 0) {
        $(selector).datetimepicker({
            format: "Do MMM YYYY",
            //format: "YYYY-MM-DD",
            icons: {
                time: "now-ui-icons tech_watch-time",
                date: "now-ui-icons ui-1_calendar-60",
                up: "fa fa-chevron-up",
                down: "fa fa-chevron-down",
                previous: "now-ui-icons arrows-1_minimal-left",
                next: "now-ui-icons arrows-1_minimal-right",
                today: "fa fa-screenshot",
                clear: "fa fa-trash",
                close: "fa fa-remove"
            }
        });
    }
}


function initDatePickerKYCFormat(selector) {
    if ($(selector).length != 0) {
        $(selector).datetimepicker({
            //format: "Do MMM YYYY",
            format: "YYYY-MM-DD",
            icons: {
                time: "now-ui-icons tech_watch-time",
                date: "now-ui-icons ui-1_calendar-60",
                up: "fa fa-chevron-up",
                down: "fa fa-chevron-down",
                previous: "now-ui-icons arrows-1_minimal-left",
                next: "now-ui-icons arrows-1_minimal-right",
                today: "fa fa-screenshot",
                clear: "fa fa-trash",
                close: "fa fa-remove"
            }
        });
    }
}

function save(form) {

    //row_data.dateofbirth.format('MMM Do YY');


   // 
   // if (row_data.dateofbirth) {
    
       //     .val(formattedDateOfBirth.format('Do MMM YYYY'));
  //  }

    // flatten form arrays
    
    form = $.map(form, function (arr) {
        return arr;
    });
    //remove empty stringed entries
    form = $.map(form, function (n) {
        if ($.trim(n.value).length !== 0)
            return n;
        return null;
    });
    // Flattening further...
    var form_data = {};
    $.each(form, function (index, item) {
        form_data[item.name] = item.value;
    });



    // Manually include arbitrary fields
    //form_data.Customercode = "";
    form_data.Customeraccounttypeid = CustomerType.id;

    var customer = {},
        emails = [],
        phones = [],
        addresses = [],
        kyc_items = [];
    // include phone numbers (optional/required)
    phones.push(utilities.makePhone(form_data.phone1));
    delete form_data.phone1;
    if (form_data.phone2) {
        phones.push(utilities.makePhone(form_data.phone2));
        delete form_data.phone2;
    }

    // include emails if available
    if (form_data.email1) {
        emails.push(utilities.makeEmail(form_data.email1));
        delete form_data.email1;
    }
    if (form_data.email2) {
        emails.push(utilities.makeEmail(form_data.email2));
        delete form_data.email2;
    }

    // include addresses (optional/required)
    var addressSource =
        (CustomerType.text.toLowerCase() !== "unincorporated") &&
        (CustomerType.text.toLowerCase() !== "corporate");
    if (addressSource) {
        // for Personal Primary/Secondary
        addresses.push(
            utilities.makeAddress(form_data, "Residential", form_data.address1)
        );
        if (form_data.address2) {
            addresses.push(utilities.makeAddress(form_data, "Mailing", form_data.address2));
        }
    } else {
        // for Offical Secondary
        addresses.push(
            utilities.makeAddress(form_data, "Corporate", form_data.address1)
        );
        if (form_data.address2) {
            addresses.push(utilities.makeAddress(form_data, "Corporate",form_data.address2));
        }
        if (form_data.address3) {
            addresses.push(utilities.makeAddress(form_data, "Mailing",form_data.address3));
        }
    }
    delete form_data.address1;
    delete form_data.address2;
    delete form_data.address3;

    // convert checkbox field to boolean
    if (form_data.Ispoliticallyexposed) {
        form_data.Ispoliticallyexposed = true;
    }

    // filter KYC select items
    $.each(form_data, function (name, val) {
        if (name.indexOf("slt_") >= 0) {
            var item_id = name.substr(4);
            var date_option = "dt_" + item_id;
            var item = {
                Kycitemid: item_id,
                Actionid: val
            };
            if (date_option in form_data) {
                item["Actiondate"] = form_data[date_option];
                delete form_data[date_option];
            } else {
                item["Actiondate"] = null;
            }
            kyc_items.push(item);
            delete form_data[name];
        }
    });

    var data = {
        customer: form_data,
    };
    
    if (emails.length !== 0) {
        data.Emails = emails;
    }
    if (phones.length !== 0) {
        data.Phones = phones;
    }
    if (addresses.length !== 0) {
        data.Addresses = addresses;
    }
    if (kyc_items.length !== 0) {
        data.kyc = kyc_items;
    }

    var kyc_uploads = $("#kycupload-data-table")
        .bootstrapTable("getData");
    if (kyc_uploads.length !== 0) {
        kyc_uploads = $.map(kyc_uploads, function (item) {
            item.document.append("title", item.title);
            return item.document
        });
    }
    
    $.ajax(url_path + "/Profile/AddCustomer", {
        data: JSON.stringify(data),
        method: "POST",
        contentType: "application/json"
    }).then(function (response) {
        function profileSuccess() {
            swal({
                title: "Save Customer",
                text: "Customer saved successfully!",
                type: 'success',
                allowOutsideClick: false,
                allowEscapeKey: false
            }).then(function () {
                clear();
                $('#data-table').bootstrapTable('refresh', {
                    silent: true
                });
                $('#wizardModal').modal('hide');
                $("#wizardComponent .btn-finish").removeAttr("disabled");
            });
        }
        if (kyc_uploads.length !== 0) {
            var kyc_requests = $.map(kyc_uploads,
                function (item) {
                    return $.ajax(
                        url_path + "/Profile/AddKYCUpload/" + response,
                        {
                            method: "POST",
                            contentType: false,
                            processData: false,
                            data: item
                        }
                    );
                });
            // observe ajax requests
            $.when.apply($, kyc_requests)
                .then(function (response) {
                    profileSuccess();
                }, function (error) {
                    swal({
                        title: "Save Customer",
                        text:
                            "Customer saved successfully but one" +
                            " or more kyc documents weren't submitted." +
                            " View the customer's kyc status page for more details.",
                        type: 'warning',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        clear();
                        $('#data-table').bootstrapTable('refresh', {
                            silent: true
                        });
                        $('#wizardModal').modal('hide');
                        $("#wizardComponent .btn-finish").removeAttr("disabled");
                    });
                });
        } else {
            profileSuccess();
        }
    }, function (error) {
        swal({
            title: 'Save Customer',
            text: 'Customer submission encountered an error',
            type: 'error',
            allowOutsideClick: false,
            allowEscapeKey: false
        }).then(function () {
            $("#wizardComponent .btn-finish").removeAttr("disabled");
        });
    });
}

function update(form) {
    debugger
    // get kyc items separately
    
    var kycUpdateFrm = $("#kycU #frmKyc");
    var kycTable = kycUpdateFrm.find("table:not(.d-none)");
    var kycItems = kycTable.find("input, select").serializeArray();
    // turn empty strings into null
    kycItems = $.map(kycItems, function (i) {
        if ($.trim(i.value).length == 0) {
            i.value = null;
        }
        return i;
    });
    // flatten form arrays
    form = $.map(form, function (arr) {
        return arr;
    });
    //remove empty stringed entries
    form = $.map(form, function (n) {
        if ($.trim(n.value).length !== 0)
            return n;
        return null;
    });
    // Flattening further...
    var form_data = {};
    $.each(form, function (index, item) {
        form_data[item.name] = item.value;
    });
    // include kyc items
    $.each(kycItems, function (index, item) {
        form_data[item.name] = item.value;
    });

    // include customer id, type & code
    form_data.Customerid = UpdateCustomer.customerid;
    form_data.Customercode = UpdateCustomer.customercode;
    form_data.Customeraccounttypeid = UpdateCustomer.customeraccounttypeid;

    // convert checkbox field to boolean
    if (form_data.Ispoliticallyexposed) {
        form_data.Ispoliticallyexposed = true;
    } else {
        form_data.Ispoliticallyexposed = false;
    }

    var data = {
        
        kyc: []
        
    };
    

    // filter KYC select items
    $.each(form_data, function (name, val) {
        if (name.indexOf("slt_") >= 0) {
            var item_id = name.substr(4);
            var date_option = "dt_" + item_id;
            var item = {
                Kycitemid: item_id,
                Actionid: val,
                Customerid: UpdateCustomer.customerid
            };
            if (date_option in form_data) {
                item["Actiondate"] = form_data[date_option];
                delete form_data[date_option];
            } else {
                item["Actiondate"] = null;
            }
            data.kyc.push(item);
            delete form_data[name];
        }
    });
   
    data.customer = form_data;
   
    
    $.ajax(url_path + "/Profile/UpdateCustomer", {
        data: JSON.stringify(data),
        method: "POST",
        contentType: "application/json"
    }).then(function (response) {
        swal({
            title: "Update Customer",
            text: "Customer updated successfully!",
            type: 'success',
            allowOutsideClick: false,
            allowEscapeKey: false
        }).then(function () {
            clear();
            $('#data-table').bootstrapTable('refresh', {
                silent: true
            });
            $('#wizardModal').modal('hide');
            $("#updateWizard .btn-finish").removeAttr("disabled");
        });
    }, function (error) {
        swal({
            title: 'Update Customer',
            text: 'Customer update encountered an error',
            type: 'error',
            allowOutsideClick: false,
            allowEscapeKey: false
        }).then(function () {
            $(".btn-finish").removeAttr("disabled");
        });
    });
}

function deleteKYCUpload(id) {
    debugger
    swal({
        title: "Are you sure?",
        text: "KYC document will be deleted",
        type: "warning",
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
                }, 10000);
            });
        }
    }).then(
        function (isConfirm) {
            $.ajax(url_path + "/Profile/DeleteKYCUpload/" + id, {
                method: "POST",
                contentType: "application/json"
            }).then(
                function (response) {
                    swal({
                        title: "Delete KYC Document",
                        text: "Document deleted successfully!",
                        type: 'success',
                    });
                    $("#kycupload-update-data-table")
                        .bootstrapTable("load", response);
                },
                function (error) {
                    swal({
                        title: "Delete KYC Document",
                        text: "KYC document deletion encountered an error!",
                        type: "error"
                    });
                }
            );
        },
        function (isRejected) { return; }
    );
}

function addKYCUpdateUpload() {
    var valid = true;
    debugger
    var title = $.trim($("#UpdateUploadTitle").val());
    var input = $("#UpdateUploadFile").get(0);

    if (!title) {
        valid = false;
        $.notify({
            icon: "now-ui-icons travel_info",
            message: "Please insert document title"
        }, {
                type: "danger",
                placement: {
                    from: "top",
                    align: "right"
                }
            });
    }
    if (!input.files.length) {
        valid = false;
        $.notify({
            icon: "now-ui-icons travel_info",
            message: "Please choose a document"
        }, {
                type: "danger",
                placement: {
                    from: "top",
                    align: "right"
                }
            }
        );
    }

    if (!valid) return;

    swal({
        title: "Are you sure?",
        text: "KYC document will be saved",
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
            var formdata = new FormData();
            formdata.append("document", input.files[0]);
            formdata.append("title", title);

            $.ajax(url_path + "/Profile/AddKYCUpload/"
                + UpdateCustomer.customerid + "/?sendall=true", {
                    method: "POST",
                    contentType: false,
                    processData: false,
                    data: formdata
                }).then(
                    function (response) {
                        $("#UpdateUploadTitle").val(null);
                        $("#UpdateUploadFile").fileinput("clear");
                        swal({
                            title: "Add KYC Document",
                            text: "KYC document added successfully!",
                            type: 'success',
                        });
                        $("#kycupload-update-data-table")
                            .bootstrapTable("load", response);
                    },
                    function (error) {
                        swal({
                            title: "Add KYC Document",
                            text: "An error occured when adding KYC document!",
                            type: "error"
                        });
                    }
                );
        },
        function (isRejected) { return; }
    );
}

function clear() {
    $(".wizard-container form select").val(null)
        .trigger("select2:unselect")
        .trigger("change");
    $(".wizard-container form").trigger("reset");
}

function initWizards() {
    // Add Wizard Initialization
    debugger
    $('#wizardComponent').bootstrapWizard({
        'tabClass': 'nav nav-pills',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-previous',
        'finishSelector' : '.btn-finish',

        onNext: function (tab, navigation, index) {

           
            var form = getTabForm(tab);
            if (!form.valid()) {
                return false;
            }
            //return true;
        },

        onInit: function (tab, navigation, index) {
            var $wizard = navigation.closest('.card-wizard');
            refreshAnimation($wizard, index);
        },

        onFinish: function (tab, navigation, index) {
            // Get and validate last form
            var form = getTabForm(tab);

            /*if (!form.valid()) {
                return false;
            }*/

            debugger
            console.log(selectedTab);
            var toReturn = false;
            $.each(selectedTab, function (index, value) {

                console.log(value);
                var form = getTabForm(value);
                if (!form.valid()) {
                    toReturn = true;
                    return false;
                }
            })

            if (toReturn) {
                return false;
            }
            /*var form2 = getTabForm("li.nav-item.personalPrimary");
            var form3 = getTabForm("li.nav-item.general")

            if (!form2.valid()) {
                return false;
            }

            if (!form3.valid()) {
                return false;
            }*/



           // selectedTab = [];

            var tabs = $("#wizardComponent " + "#frmPersonalPrimary");

           var dateofBirth = tabs.find("[name=Dateofbirth]").val();
           const formattedDateOfBirth = moment(dateofBirth, 'Do MMM YYYY')
            if (dateofBirth != "") {
                tabs.find("[name=Dateofbirth]")
                    .val(formattedDateOfBirth.format('YYYY-MM-DD'));
            }

            var weddingdate = tabs.find("[name=Weddingdate]").val();
            const formattedweddingDate = moment(weddingdate, 'Do MMM YYYY')
            if (weddingdate != "") {
                tabs.find("[name=Weddingdate]")
                    .val(formattedweddingDate.format('YYYY-MM-DD'));
                var dateofWeddingDate = tabs.find("[name=Weddingdate]").val();
                console.log(dateofWeddingDate);
            }

            var Firstchilddob = tabs.find("[name=Firstchilddob]").val();
            const formattedFirstchilddob = moment(Firstchilddob, 'Do MMM YYYY')
            if (Firstchilddob != "") {
                tabs.find("[name=Firstchilddob]")
                    .val(formattedFirstchilddob.format('YYYY-MM-DD'));
            }

            var Marriagecertificationdate = tabs.find("[name=Marriagecertificationdate]").val();
            const formattedMarriagecertificationdate = moment(Marriagecertificationdate, 'Do MMM YYYY')
            if (Marriagecertificationdate != "") {
                tabs.find("[name=Marriagecertificationdate]")
                    .val(formattedMarriagecertificationdate.format('YYYY-MM-DD'));
            }

            var Idexpiry = tabs.find("[name=Idexpiry]").val();
            const formattedIdexpiry = moment(Idexpiry, 'Do MMM YYYY')
            if (Idexpiry != "") {
                tabs.find("[name=Idexpiry]")
                    .val(formattedIdexpiry.format('YYYY-MM-DD'));
            }

            var Idissueauthority = tabs.find("[name=Idissueauthority]").val();
            const formattedIdissueauthority = moment(Idissueauthority, 'Do MMM YYYY')
            if (Idissueauthority != "") {
                tabs.find("[name=Idissueauthority]")
                    .val(formattedIdissueauthority.format('YYYY-MM-DD'));
            }

            var Nokdob = tabs.find("[name=Nokdob]").val();
            const formattedNokdob = moment(Nokdob, 'Do MMM YYYY')
            if (Nokdob != "") {
                tabs.find("[name=Nokdob]")
                    .val(formattedNokdob.format('YYYY-MM-DD'));
            }

            var tabsPersonalSecondary = $("#wizardComponent " + "#frmPersonalSecondary");

            var Idexpiry2 = tabsPersonalSecondary.find("[name=Idexpiry]").val();
            const formattedIdexpiry2 = moment(Idexpiry2, 'Do MMM YYYY')
            if (Idexpiry2 != "") {
                tabsPersonalSecondary.find("[name=Idexpiry]")
                    .val(formattedIdexpiry2.format('YYYY-MM-DD'));
            }

            var Nokdob2 = tabsPersonalSecondary.find("[name=Nokdob]").val();
            const formattedNokdob2 = moment(Nokdob2, 'Do MMM YYYY')
            if (Nokdob2 != "") {
                tabsPersonalSecondary.find("[name=Nokdob]")
                    .val(formattedNokdob2.format('YYYY-MM-DD'));
            }

            
           
            var tabsOfficialPrimary = $("#wizardComponent " + "#frmOfficialPrimary");

            var Employeddate = tabsOfficialPrimary.find("[name=Employeddate]").val();
            const formattedEmployeddate = moment(Employeddate, 'Do MMM YYYY')
            if (Employeddate != "") {
                tabsOfficialPrimary.find("[name=Employeddate]")
                    .val(formattedEmployeddate.format('YYYY-MM-DD'));
            }

            var tabsOfficialSecondary = $("#wizardComponent " + "#frmOfficialSecondary");

            var Businessstartdate = tabsOfficialSecondary.find("[name=Businessstartdate]").val();
            const formattedBusinessstartdate = moment(Businessstartdate, 'Do MMM YYYY')
            if (Businessstartdate != "") {
                tabsOfficialSecondary.find("[name=Businessstartdate]")
                    .val(formattedBusinessstartdate.format('YYYY-MM-DD'));
            }

            var tabsBank = $("#wizardComponent " + "#frmBank");

            var Bankaccountopeneddate = tabsBank.find("[name=Bankaccountopeneddate]").val();
            const formattedBankaccountopeneddate = moment(Bankaccountopeneddate, 'Do MMM YYYY')
            if (Bankaccountopeneddate != "") {
                tabsBank.find("[name=Bankaccountopeneddate]")
                    .val(formattedBankaccountopeneddate.format('YYYY-MM-DD'));
            }


            swal({
                title: "Are you sure?",
                text: "Customer will be submitted",
                type: "warning",
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
            }).then(function (isConfirm) {
                if (isConfirm) {
                    // freeze finish button
                    $("#wizardComponent .btn-finish").attr("disabled", "true");
                    var form_data = [];
                    var tabsArray = $(navigation)
                        .find("li:not(.d-none)")
                        .map(function () {
                            return getTabForm(this);
                        });
                    tabsArray.each(function () {
                        form_data.push(this.serializeArray());
                    });
                    save(form_data);
                }
            }, function (isRejected) {
                return;
            });
        },

        onTabClick: function (tab, navigation, index) {
           // return false;// false;

            //selectedTab.push(tab);

            debugger
            var form = getTabForm(tab);
            if (!form.valid()) {
                return false;
            }
        },

        onTabShow: function (tab, navigation, index) {
            var navLength = $(navigation).find("li:visible").length;

            var wizard = navigation.closest('.card-wizard');
            wizard.find(".btn-next").removeClass("disabled");

            if ((index+1) == navLength && index !== -1) {
                $(wizard).find('.btn-next').hide();
                $(wizard).find('.btn-finish').show();
            } else {
                $(wizard).find('.btn-next').show();
                $(wizard).find('.btn-finish').hide();
            }

            refreshAnimation(wizard, index);
        }
    });

    // Update Wizard Initialization
    $('#updateWizard').bootstrapWizard({
        'tabClass': 'nav nav-pills',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-previous',
        'finishSelector': '.btn-finish',

        onNext: function (tab, navigation, index) {
            var form = getTabForm(tab);
            if (!form.valid()) {
                return false;
            }
            return true;
        },

        onInit: function (tab, navigation, index) {
            var $wizard = navigation.closest('.card-wizard');
            refreshAnimation($wizard, index);
        },

        onFinish: function (tab, navigation, index) {
            // Get and validate last form
            debugger
            var form = getTabForm(tab);

            /*var tabs = $("#updateWizard " + "#frmPersonalPrimary");
            debugger
            var dateofBirth = tabs.find("[name=Dateofbirth]").val();
            console.log(dateofBirth);
            const formattedDateOfBirth = moment(dateofBirth, 'Do MMM YYYY')
            if (dateofBirth) {
                tabs.find("[name=Dateofbirth]")
                    .val(formattedDateOfBirth.format('YYYY-MM-DD'));
            }
            var dateofBirthFormatted = tabs.find("[name=Dateofbirth]").val();
            console.log(dateofBirthFormatted);*/

            var tabs = $("#updateWizard " + "#frmPersonalPrimary");

            var dateofBirth = tabs.find("[name=Dateofbirth]").val();
            const formattedDateOfBirth = moment(dateofBirth, 'Do MMM YYYY')
            if (dateofBirth != "") {
                tabs.find("[name=Dateofbirth]")
                    .val(formattedDateOfBirth.format('YYYY-MM-DD'));
            }

            var weddingdate = tabs.find("[name=Weddingdate]").val();
            const formattedweddingDate = moment(weddingdate, 'Do MMM YYYY')
            if (weddingdate != "") {
                tabs.find("[name=Weddingdate]")
                    .val(formattedweddingDate.format('YYYY-MM-DD'));
                
            }

            var Firstchilddob = tabs.find("[name=Firstchilddob]").val();
            const formattedFirstchilddob = moment(Firstchilddob, 'Do MMM YYYY')
            if (Firstchilddob != "") {
                tabs.find("[name=Firstchilddob]")
                    .val(formattedFirstchilddob.format('YYYY-MM-DD'));
                
            }

            var Marriagecertificationdate = tabs.find("[name=Marriagecertificationdate]").val();
            const formattedMarriagecertificationdate = moment(Marriagecertificationdate, 'Do MMM YYYY')
            if (Marriagecertificationdate != "") {
                tabs.find("[name=Marriagecertificationdate]")
                    .val(formattedMarriagecertificationdate.format('YYYY-MM-DD'));
            }

            var Idexpiry = tabs.find("[name=Idexpiry]").val();
            const formattedIdexpiry = moment(Idexpiry, 'Do MMM YYYY')
            if (Idexpiry != "") {
                tabs.find("[name=Idexpiry]")
                    .val(formattedIdexpiry.format('YYYY-MM-DD'));
            }

            var Idissueauthority = tabs.find("[name=Idissueauthority]").val();
            const formattedIdissueauthority = moment(Idissueauthority, 'Do MMM YYYY')
            if (Idissueauthority != "") {
                tabs.find("[name=Idissueauthority]")
                    .val(formattedIdissueauthority.format('YYYY-MM-DD'));
            }

            var Nokdob = tabs.find("[name=Nokdob]").val();
            const formattedNokdob = moment(Nokdob, 'Do MMM YYYY')
            if (Nokdob != "") {
                tabs.find("[name=Nokdob]")
                    .val(formattedNokdob.format('YYYY-MM-DD'));
                var dateofNokdob = tabs.find("[name=Nokdob]").val();
                console.log(dateofNokdob);
            }
            

            var tabsPersonalSecondary = $("#updateWizard " + "#frmPersonalSecondary");

            var Idexpiry2 = tabsPersonalSecondary.find("[name=Idexpiry]").val();
            const formattedIdexpiry2 = moment(Idexpiry2, 'Do MMM YYYY')
            if (Idexpiry2 != "") {
                tabsPersonalSecondary.find("[name=Idexpiry]")
                    .val(formattedIdexpiry2.format('YYYY-MM-DD'));
            }

            var Nokdob2 = tabsPersonalSecondary.find("[name=Nokdob]").val();
            const formattedNokdob2 = moment(Nokdob2, 'Do MMM YYYY')
            if (Nokdob2 != "") {
                tabsPersonalSecondary.find("[name=Nokdob]")
                    .val(formattedNokdob2.format('YYYY-MM-DD'));
            }



            var tabsOfficialPrimary = $("#updateWizard " + "#frmOfficialPrimary");

            var Employeddate = tabsOfficialPrimary.find("[name=Employeddate]").val();
            const formattedEmployeddate = moment(Employeddate, 'Do MMM YYYY')
            if (Employeddate != "") {
                tabsOfficialPrimary.find("[name=Employeddate]")
                    .val(formattedEmployeddate.format('YYYY-MM-DD'));
            }

            var tabsOfficialSecondary = $("#updateWizard " + "#frmOfficialSecondary");

            var Businessstartdate = tabsOfficialSecondary.find("[name=Businessstartdate]").val();
            const formattedBusinessstartdate = moment(Businessstartdate, 'Do MMM YYYY')
            if (Businessstartdate != "") {
                tabsOfficialSecondary.find("[name=Businessstartdate]")
                    .val(formattedBusinessstartdate.format('YYYY-MM-DD'));
            }

            var tabsBank = $("#updateWizard " + "#frmBank");

            var Bankaccountopeneddate = tabsBank.find("[name=Bankaccountopeneddate]").val();
            const formattedBankaccountopeneddate = moment(Bankaccountopeneddate, 'Do MMM YYYY')
            if (Bankaccountopeneddate != "") {
                tabsBank.find("[name=Bankaccountopeneddate]")
                    .val(formattedBankaccountopeneddate.format('YYYY-MM-DD'));
            }

            if (!form.valid()) {
                return false;
            }

            swal({
                title: "Are you sure?",
                text: "Customer will be updated",
                type: "warning",
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
            }).then(function (isConfirm) {
                if (isConfirm) {
                    // freeze finish button
                    $("#updateWizard .btn-finish").attr("disabled", "true");
                    var form_data = [];
                    var tabsArray = $(navigation)
                        .find("li:not(.d-none)")
                        .map(function () {
                            if ($(this).hasClass("kyc")) {
                                return null;
                            }
                            return getTabForm(this);
                        });
                    tabsArray.each(function () {
                        form_data.push(this.serializeArray());
                    });
                    update(form_data);
                }
            }, function (isRejected) {
                return;
            });
        },

        onTabClick: function (tab, navigation, index) {
            //var form = getTabForm(tab);
            //if (!form.valid()) {
            //    return false;
            //}
            return true;
        },

        onTabShow: function (tab, navigation, index) {
            var navLength = $(navigation).find("li:visible").length;

            var wizard = navigation.closest('.card-wizard');
            wizard.find(".btn-next").removeClass("disabled");

            if ((index + 1) == navLength && index !== -1) {
                $(wizard).find('.btn-next').hide();
                $(wizard).find('.btn-finish').show();
            } else {
                $(wizard).find('.btn-next').show();
                $(wizard).find('.btn-finish').hide();
            }

            refreshAnimation(wizard, index);
        }
    });

    function getTabForm(tab) {
        var nav_id = $(tab).find("a.nav-link").attr("href");
        var wizard = $("#" + $(tab).closest('.card-wizard').attr("id"));
        var tabpane = wizard.find("div" + nav_id + ".tab-pane");
        return (tabpane.find("form"));
    }

    $(window).resize(function () {
        $('.card-wizard').each(function () {
            $wizard = $(this);

            index = $wizard.bootstrapWizard('currentIndex');
            refreshAnimation($wizard, index);
        });
    });

    function refreshAnimation($wizard, index) {
        $total = $wizard.find('.nav li').length;
        $li_width = 100 / $total;

        total_steps = $wizard.find('.nav li').length;
        move_distance = $wizard.width() / total_steps;
        index_temp = index;
        vertical_level = 0;

        mobile_device = $(document).width() < 600 && $total > 3;

        if (mobile_device) {
            move_distance = $wizard.width() / 2;
            index_temp = index % 2;
            $li_width = 50;
        }

        $wizard.find('.nav li').css('width', $li_width + '%');

        step_width = move_distance;
        move_distance = move_distance * index_temp;

        $current = index + 1;

        if (mobile_device) {
            vertical_level = parseInt(index / 2);
            vertical_level = vertical_level * 38;
        }
    }
}

function initSelectTwoConfig() {
    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $(".modal").first());
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);

    $("#customType").select2({
        placeholder: "Select custom option"
    });


    $("#ddlCategoryType, #UddlCategoryType").select2({
        placeholder: "Select customer category"
    });

    var stateLGA = [];
    var sectorIndustries = [];
    $.ajax(url_path + "/Profile/LoadAddressTypes")
        .then(function (response) {
            
            AddressTypes = response;
            $("#ddlAddType").select2({
                placeholder: "Select address type",
                dropdownParent: $("#addressUpdateModal.modal"),
                data: response
            });
           
        });
    $.ajax(url_path + "/Profile/LoadRegions")
        .then(function(response) {
            $("#Regionid, #URegionid").select2({
                placeholder: "Select region",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadSectors")
        .then(function (response) {
            $("#Sectorid, #USectorid").select2({
                placeholder: "Select sector",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadTitles")
        .then(function (response) {
            $("#Titleid, #UTitleid").select2({
                placeholder: "Select title",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadSensitivityLevels")
        .then(function (response) {
            $("#ddlSensitivityLevel, #UddlSensitivityLevel").select2({
                placeholder: "Select sensitivity level",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadMaritalStatuses")
        .then(function (response) {
            $("#Maritalstatusid, #UMaritalstatusid").select2({
                placeholder: "Select status",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadGenders")
        .then(function (response) {
            $("#Genderid, #UGenderid, #Nokgenderid, #UNokgenderid, #sNOKGender, #UsNOKGender").select2({
                placeholder: "Select gender",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadStates")
        .then(function (response) {
            $("#ddlState, #UddlState, #Stateoforiginid, #UStateoforiginid, #sDdlState, #UsDdlState, #ssDdlState, #UssDdlState, #Workstate, #UWorkstate")
                .select2({
                placeholder: "Select state",
                data: response
            });
            $("#ddlAddState").select2({
                placeholder: "Select state",
                dropdownParent: $("#addressUpdateModal.modal"),
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadModeOfIDs")
        .then(function (response) {
            $("#Modeofidentification, #UModeofidentification, #sDdlModeOfID, #UsDdlModeOfID").select2({
                placeholder: "Select ID type",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadCountries")
        .then(function (response) {
            $("#ddlCountry, #NationalityCr, #NationalityU, #UddlCountry, #sDdlCountry, #UsDdlCountry, #Workcountry, #UWorkcountry, #ssDdlCountry, #UssDdlCountry")
                .select2({
                    placeholder: "Select country",
                    data: response
                });
            $("#ddlAddCountry").select2({
                placeholder: "Select country",
                dropdownParent: $("#addressUpdateModal.modal"),
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadAnnualIncomes/individual")
        .then(function (response) {
            $("#Annualincome, #UAnnualincome").select2({
                placeholder: "Select income type",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadAnnualIncomes/business")
        .then(function (response) {
            $("#ssDdlAnnTurnover, #UssDdlAnnTurnover").select2({
                placeholder: "Select turnover amount",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadBusinessCategories")
        .then(function (response) {
            $("#Businesscategoryid, #UBusinesscategoryid").select2({
                placeholder: "Select business category",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadFundSources")
        .then(function (response) {
            $("#Sourceoffundid, #USourceoffundid, #sDdlFundSource, #UsDdlFundSource").select2({
                placeholder: "Select funds source",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadBanks")
        .then(function (response) {
            $("#Bankid, #UBankid").select2({
                placeholder: "Select bank",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadBankAccountTypes")
        .then(function (response) {
            $("#Bankaccountypeid, #UBankaccountypeid").select2({
                placeholder: "Select account type",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadEmploymentTypes")
        .then(function (response) {
            $("#Employmentstatus, #UEmploymentstatus").select2({
                placeholder: "Select employment status",
                data: response
            });
        });
    $.ajax(url_path + "/Profile/LoadLGAs")
        .then(function (response) {
            LGAs = response;
            $("#Stateoriginlgaid, #UStateoriginlgaid").select2({
                placeholder: "Select LGA"
            });
        });
    $.ajax(url_path + "/Profile/LoadIndustries")
        .then(function (response) {
            Industries = response;
            $("#Industryid, #UIndustryid").select2({
                placeholder: "Select industry"
            });
        });
    $.ajax(url_path + "/Profile/LoadInstitutionTypes")
        .then(function (response) {
            $("#Institutiontypeid, #UInstitutiontypeid").select2({
                placeholder: "Select institution type",
                data: response,
                width: "100%"
            });
        });

    // Event Listeners
    $(document).on("select2:open", function () {
        $('.select2-results__options').perfectScrollbar();
    });
    $("#Stateoforiginid").on("select2:select", function (e) {
        $("#Stateoriginlgaid").removeAttr("disabled");

        debugger
        console.log(e.params.data.text);

        stateLGA = LGAs.filter(function (elem) {
            return elem.state == e.params.data.text;
        });
        stateLGA = stateLGA.map(function (elem) {
            return {
                id: elem.id,
                text: elem.lga
            };
        });
        stateLGA.unshift({ id: '', text: '' });
        $("#Stateoriginlgaid").select2('destroy').empty().select2({
            placeholder: "Select LGA",
            width: "100%",
            data: stateLGA
        });
        
    });
    $("#Stateoforiginid").on("select2:unselect", function (e) {
        $("#Stateoriginlgaid").val(null).trigger("change");
        $("#Stateoriginlgaid").attr("disabled", "true");
    });

    $("#Sectorid").on("select2:select", function (e) {
        $("#Industryid").removeAttr("disabled");
        sectorIndustries = Industries.filter(function (elem) {
            return elem.sectorid == e.params.data.id;
        });
        sectorIndustries = sectorIndustries.map(function (elem) {
            return {
                id: elem.industryid,
                text: elem.name
            };
        });
        sectorIndustries.unshift({id: '', text: ''});
        $("#Industryid").select2('destroy').empty().select2({
            placeholder: "Select industry",
            width: "100%",
            data: sectorIndustries
        });

    });
    $("#Sectorid").on("select2:unselect", function (e) {
        $("#Industryid").val(null).trigger("change");
        $("#Industryid").attr("disabled", "true");
    });

    $("#ddlCategoryType").on("select2:select", function (e) {
        if (e.params.data.id == "internal") {
            $("#Staffnumber").removeAttr("disabled");
        } else {
            $("#Staffnumber").val("");
            $("#Staffnumber").attr("disabled", "true");
            $("#Staffnumber").siblings("label").remove();
            $("#Staffnumber").closest(".has-danger").removeClass("has-danger");
            $("#Staffnumber").closest(".has-success").removeClass("has-success");
        }
    });
    $("#ddlCategoryType").on("select2:unselect", function (e) {
        $("#Staffnumber").val("")
        $("#Staffnumber").attr("disabled", "true");
    });

    // Update Event Listeners
    $("#UStateoforiginid").on("select2:select", function (e) {
        $("#UStateoriginlgaid").removeAttr("disabled");

        console.log(e.params.data.text);

        stateLGA = LGAs.filter(function (elem) {
            return elem.state == e.params.data.text;
        });
        stateLGA = stateLGA.map(function (elem) {
            return {
                id: elem.id,
                text: elem.lga
            };
        });
        stateLGA.unshift({ id: '', text: '' });
        $("#UStateoriginlgaid").select2('destroy').empty().select2({
            placeholder: "Select LGA",
            width: "100%",
            data: stateLGA
        });

    });
    $("#UStateoforiginid").on("select2:unselect", function (e) {
        $("#UStateoriginlgaid").val(null).trigger("change");
        $("#UStateoriginlgaid").attr("disabled", "true");
    });

    $("#USectorid").on("select2:select", function (e) {
        $("#UIndustryid").removeAttr("disabled");
        sectorIndustries = Industries.filter(function (elem) {
            return elem.sectorid == e.params.data.id;
        });
        sectorIndustries = sectorIndustries.map(function (elem) {
            return {
                id: elem.industryid,
                text: elem.name
            };
        });
        sectorIndustries.unshift({ id: '', text: '' });
        $("#UIndustryid").select2('destroy').empty().select2({
            placeholder: "Select industry",
            width: "100%",
            data: sectorIndustries
        });

    });
    $("#USectorid").on("select2:unselect", function (e) {
        $("#UIndustryid").val(null).trigger("change");
        $("#UIndustryid").attr("disabled", "true");
    });

    $("#updateWizard #UddlCategoryType").on("select2:select", function (e) {
        if (e.params.data.id == "internal") {
            $("#updateWizard #UStaffnumber").removeAttr("disabled");
        } else {
            $("#updateWizard #UStaffnumber").val("");
            $("#updateWizard #UStaffnumber").attr("disabled", "true");
            $("#updateWizard #UStaffnumber").siblings("label").remove();
            $("#updateWizard #UStaffnumber").closest(".has-danger").removeClass("has-danger");
            $("#updateWizard #UStaffnumber").closest(".has-success").removeClass("has-success");
        }
    });
    $("#updateWizard #UddlCategoryType").on("select2:unselect", function (e) {
        $("#updateWizard #UStaffnumber").val("")
        $("#updateWizard #UStaffnumber").attr("disabled", "true");
    });

}

var utilities = {
    animDuration: 400,
    profileTableFormatter: function (index, row, detail) {
        detail.html("Loading...");
        var addresses = [], bvn, phones = [], emails = [];
        
        bvn = row.bvn;
        $.when(
            $.ajax(url_path + "/Profile/LoadCustomerAddresses/" + row.customerid)
                .then(function (response) {
                    addresses = response;
                }),
            $.ajax(url_path + "/Profile/LoadCustomerEmails/" + row.customerid)
                .then(function (response) {
                    emails = response;
                }),
            $.ajax(url_path + "/Profile/LoadCustomerPhones/" + row.customerid)
                .then(function (response) {
                    phones = response;
                })
        ).then(function () {
            var top_row = $("<div class='row'></div>");
            var bottom_row = $("<div class='row'></div>");
            var bvn_col = $("<div class='col-sm-12 col-md-6'></div>");
            var phone_col = $("<div class='col-sm-12 col-md-6'></div>");
            var email_col = $("<div class='col-sm-12 col-md-6'></div>");
            var address_col = $("<div class='col'></div>");

            address_col.append("<h6 class='detail-primary d-inline-block mb-3'>Address(es)</h6>");
            if (addresses.length == 0) {
                address_col.append("<p>No address record.</p>");
            } else {
                $.each(addresses, function (index, value) {
                    var html = [];
                    html.push("<p><b>" + value.addresstype.addressTypeName + " Address: </b>");
                    html.push(value.address + ", " + value.city + ", " + value.state.statename);
                    html.push(", " + value.country.name + ".</p>");
                    address_col.append(html.join(""));
                });
            }
            phone_col.append("<h6 class='detail-primary d-inline-block mb-3'>PHONE</h6>");
            if (phones.length == 0) {
                phone_col.append("<p>No phone record.</p>");
            } else {
                $.each(phones, function (index, value) {
                    phone_col.append("<p><b>Phone</b>: " + value.phone + "</p>");
                });
            }
            
            email_col.append("<h6 class='detail-primary d-inline-block mb-3'>E-mail(s)</h6>");
            if (emails.length == 0) {
                email_col.append("<p>No e-mail record.</p>");
            } else {
                $.each(emails, function (index, value) {
                    email_col.append("<p><b>E-mail</b>: " + value.email + "</p>");
                });
            }

            bvn_col.append("<h6 class='detail-primary d-inline-block mb-3'>BVN</h6>");
            if (bvn == null) {
                bvn_col.append("<p>No BVN record.</p>");
            } else {
                
                bvn_col.append("<p><b>BVN</b>: " + bvn + "</p>");
               
            }

            top_row.append(bvn_col, phone_col, email_col);
            bottom_row.append(address_col);
            detail.empty();
            detail.append(top_row, bottom_row);
        });
    },
    updateWizardHeader: function (container) {
        $(container + " .headerCustDetails")
            .text(UpdateCustomer.surname + " "
                + (UpdateCustomer.firstname ? UpdateCustomer.firstname : '') + " - "
                + UpdateCustomer.customercode);
    },
    addKYCUpload: function () {
        var valid = true;
        var title = $.trim($("#uploadTitle").val());
        var input = $("#uploadFile").get(0);

        if (!title) {
            valid = false;
            $.notify({
                icon: "now-ui-icons travel_info",
                message: "Please insert document title"
            }, {
                    type: "danger",
                    placement: {
                        from: "top",
                        align: "right"
                    }
                });
        }
        if (!input.files.length) {
            valid = false;
            $.notify({
                icon: "now-ui-icons travel_info",
                message: "Please choose a document"
            }, {
                    type: "danger",
                    placement: {
                        from: "top",
                        align: "right"
                    }
                });
        }

        if (!valid) return;

        var formdata = new FormData();
        formdata.append("document", input.files[0]);

        $("#kycupload-data-table").bootstrapTable(
            "append", {
                tracker: ++tracker,
                title: title,
                document: formdata
            }
        );        

        // reset upload data
        $("#uploadTitle").val(null);
        $("#uploadFile").fileinput("clear");
    },
    removeKYCUpload: function (tracker) {
        $("#kycupload-data-table").bootstrapTable(
            "remove", {
                field: "tracker",
                values: [tracker]
            }
        );
    },
    makeAddress: function (form_data, address_type, address) {
        return {
            City: form_data.City,
            Stateid: form_data.State,
            Countryid: form_data.Country,
            Addresstypeid: ($.grep(AddressTypes, function (el) {
                return el.text == address_type;
            }))[0].id,
            Address: address,
            Active: true
        };
    },
    makePhone: function (phone) {
        return {
            Phone: phone,
            Active: true
        };
    },
    makeEmail: function (email) {
        return {
            Email: email,
            Active: true
        };
    },
    populateGeneral: function (row_data) {
        var tab = $("#updateWizard #frmGeneral");
        tab.find("[name=Creditrating]").val(row_data.creditrating);
        if (row_data.sectorid) {
            tab.find("[name=Sectorid]")
                .val(row_data.sectorid).change();
            tab.find("[name=Industryid]").removeAttr("disabled");
            var sectorIndustries = Industries.filter(function (elem) {
                return elem.sectorid == row_data.sectorid;
            });
            sectorIndustries = sectorIndustries.map(function (elem) {
                return {
                    id: elem.industryid,
                    text: elem.name
                };
            });
            sectorIndustries.unshift({ id: '', text: '' });
            tab.find("[name=Industryid]").select2('destroy')
                .empty().select2({
                    placeholder: "Select industry",
                    width: "100%",
                    data: sectorIndustries
                });
        }
        if (row_data.industryid) {
            tab.find("[name=Industryid]").val(row_data.industryid)
                .change();
        }
        tab.find("[name=Regionid]").val(row_data.regionid).change();
        tab.find("[name=Ispoliticallyexposed]")
            .prop("checked", row_data.ispoliticallyexposed);
        if (row_data.staffnumber) {
            tab.find("[name=Staffnumber]")
                .removeAttr("disabled")
                .val(row_data.staffnumber);
            tab.find("#UddlCategoryType").val("internal").change();
        } else {
            tab.find("[name=Staffnumber]")
                .attr("disabled", "true")
                .val(null);
            tab.find("#UddlCategoryType").val("external").change();
        }
        if (row_data.institutiontypeid) {
            tab.find("[name=Institutiontypeid]")
                .val(row_data.institutiontypeid).change();
        }
        if (row_data.customersensitivitylevelid) {
            tab.find("[name=Customersensitivitylevelid]")
                .val(row_data.customersensitivitylevelid).change();
        }
    },
    populatePersonal: function (row_data, primary = true) {
        var form = primary ? "#frmPersonalPrimary" : "#frmPersonalSecondary";
        var tab = $("#updateWizard " + form);
        // Bio section
        if (primary) {
            tab.find("[name=Titleid]").val(row_data.titleid).change();
            tab.find("[name=Surname]").val(row_data.surname);
            tab.find("[name=Firstname]").val(row_data.firstname);
            tab.find("[name=Othernames]").val(row_data.othernames);
            tab.find("[name=Taxidnumber ]").val(row_data.taxidnumber);
            tab.find("[name=Bvn ]").val(row_data.bvn);
            debugger
            var m = moment('2013-03-01', 'YYYY-MM-DD')
            const formattedDateOfBirth = moment(row_data.dateofbirth, 'YYYY-MM-DD')
                //row_data.dateofbirth.format('MMM Do YY');
            /*if (row_data.dateofbirth) {
                tab.find("[name=Dateofbirth]")
                    .val(row_data.dateofbirth.substr(0,10));
            }*/
           if (row_data.dateofbirth) {
                tab.find("[name=Dateofbirth]")
                    .val(formattedDateOfBirth.format('Do MMM YYYY'));
                   // .val(row_data.dateofbirth.format('Do MMM YYYY'));
            }
            tab.find("[name=Placeofbirth]").val(row_data.placeofbirth);
            tab.find("[name=Maritalstatusid]")
                .val(row_data.maritalstatusid).change();
            tab.find("[name=Genderid]").val(row_data.genderid).change();
            tab.find("[name=Nationality]").val(row_data.nationality);
            if (row_data.stateoforiginid) {
                tab.find("[name=Stateoforiginid]")
                    .val(row_data.stateoforiginid).change();

                tab.find("[name=Stateoriginlgaid]").removeAttr("disabled");
                var stateLGA = LGAs.filter(function (elem) {
                    return elem.state == tab
                        .find("[name=Stateoforiginid] option:selected").text();
                });
                stateLGA = stateLGA.map(function (elem) {
                    return {
                        id: elem.id,
                        text: elem.lga
                    };
                });
                stateLGA.unshift({ id: '', text: '' });
                tab.find("[name=Stateoriginlgaid]").select2('destroy')
                    .empty().select2({
                    placeholder: "Select LGA",
                    width: "100%",
                    data: stateLGA
                });
            }
            if (row_data.weddingdate) {
                
                const formattedWeddingDate = moment(row_data.weddingdate, 'YYYY-MM-DD');  
                
                //tab.find("[name=Weddingdate]").val(row_data.weddingdate.substr(0, 10));
                
                tab.find("[name=Weddingdate]").val(formattedWeddingDate.format('Do MMM YYYY'));
            }
            if (row_data.stateoriginlgaid) {
                tab.find("[name=Stateoriginlgaid]").val(row_data.stateoriginlgaid)
                    .change();
            }
            tab.find("[name=Hometown]").val(row_data.hometown);
            tab.find("[name=Spousenamework]").val(row_data.spousenamework);
            tab.find("[name=Foreignrpno]").val(row_data.foreignrpno);
            tab.find("[name=Spousephone]").val(row_data.spousephone);
            tab.find("[name=Spousemail]").val(row_data.spousemail);
            tab.find("[name=Educationlevel]").val(row_data.educationlevel);
            tab.find("[name=Firstchildname]").val(row_data.firstchildname);
            tab.find("[name=Mothersmaidenname]").val(row_data.mothersmaidenname);
            if (row_data.firstchilddob) {
                const formattedFirstChildDOB = moment(row_data.firstchilddob, 'YYYY-MM-DD');  
                //tab.find("[name=Firstchilddob]").val(row_data.firstchilddob.substr(0, 10));
                tab.find("[name=Firstchilddob]")
                    .val(formattedFirstChildDOB.format('Do MMM YYYY'));
            }
            if (row_data.marriagecertificationdate) {
                const formattedMarriageCertificateDate = moment(row_data.marriagecertificationdate, 'YYYY-MM-DD'); 
                tab.find("[name=Marriagecertificationdate]")
                    .val(formattedMarriageCertificateDate.format('Do MMM YYYY'));
          
                //tab.find("[name=Marriagecertificationdate]").val(row_data.marriagecertificationdate.substr(0,10));
            }
        } else {
            tab.find("[name=Surname]").val(row_data.surname);
        }
        // Contact info
        tab.find("[name=Fax]").val(row_data.fax);
        tab.find("[name=Pobox]").val(row_data.pobox);
        tab.find("[name=Firstchildname]").val(row_data.firstchildname);
        tab.find("[name=Modeofidentificationid]")
            .val(row_data.modeofidentificationid).change();
        if (row_data.idexpiry) {
            const formattedidexpiry = moment(row_data.idexpiry, 'YYYY-MM-DD')

            tab.find("[name=Idexpiry]")
                .val(formattedidexpiry.format('Do MMM YYYY'));
            //tab.find("[name=Idexpiry]").val(row_data.idexpiry.substr(0,10));
        }
        tab.find("[name=Idissueauthority]").val(row_data.idissueauthority);
        tab.find("[name=Idplaceofissue]").val(row_data.idplaceofissue);
        tab.find("[name=Sourceoffundid]").val(row_data.sourceoffundid).change();
        // NOK details
        tab.find("[name=Noksurname]").val(row_data.noksurname);
        tab.find("[name=Nokothernames]").val(row_data.nokothernames);
        if (row_data.nokdob) {
            const formattedNok = moment(row_data.nokdob, 'YYYY-MM-DD')
            
            tab.find("[name=Nokdob]")
                .val(formattedNok.format('Do MMM YYYY'));
            
           //tab.find("[name=Nokdob]").val(row_data.nokdob.substr(0,10));
        }
        tab.find("[name=Nokemail]").val(row_data.nokemail);
        tab.find("[name=Nokaddress]").val(row_data.nokaddress);
        tab.find("[name=Nokphone]").val(row_data.nokphone);
        tab.find("[name=Nokrelationship]").val(row_data.nokrelationship);
        tab.find("[name=Nokgenderid]").val(row_data.nokgenderid).change();
    },
    populateOfficialPrimary: function (row_data) {
        var tab = $("#updateWizard #frmOfficialPrimary");
        tab.find("[name=Employmentstatus]")
            .val(row_data.employmentstatus).change();
        tab.find("[name=Occupation]").val(row_data.occupation);
        tab.find("[name=Currentemployer]").val(row_data.currentemployer);
        tab.find("[name=Workaddress]").val(row_data.workaddress);
        tab.find("[name=Workphone]").val(row_data.workphone);
        tab.find("[name=Workstate]").val(row_data.workstate).change();
        tab.find("[name=Workcountry]").val(row_data.workcountry).change();
        if (row_data.employeddate) {
            const formattedemployeddate = moment(row_data.employeddate, 'YYYY-MM-DD')

            tab.find("[name=Employeddate]")
              .val(formattedemployeddate.format('Do MMM YYYY'));
           // tab.find("[name=Employeddate]").val(row_data.employeddate.substr(0,10));
        }
        tab.find("[name=Previousemployer]").val(row_data.previousemployer);
        tab.find("[name=Annualincomeid]").val(row_data.annualincomeid).change();
    },
    populateOfficialSecondary: function (row_data) {
        var tab = $("#updateWizard #frmOfficialSecondary");
        tab.find("[name=Surname]").val(row_data.surname);
        tab.find("[name=Rcnumber]").val(row_data.rcnumber);
        tab.find("[name=Businesscategoryid]")
            .val(row_data.businesscategoryid).change();
        if (row_data.businessstartdate) {
            const formattedbusinessstartdate = moment(row_data.businessstartdate, 'YYYY-MM-DD')
            tab.find("[name=Businessstartdate]")
                .val(formattedbusinessstartdate.format('Do MMM YYYY'));
            //tab.find("[name=Businessstartdate]").val(row_data.businessstartdate.substr(0,10));
        }
        tab.find("[name=Taxidnumber]").val(row_data.taxidnumber);
        tab.find("[name=Natureofbusiness]").val(row_data.natureofbusiness);
        tab.find("[name=Scumlnumber]").val(row_data.scumlnumber);
        tab.find("[name=Fax]").val(row_data.fax);
        tab.find("[name=Businesswebsite]").val(row_data.businesswebsite);
        tab.find("[name=Pobox]").val(row_data.pobox);
        tab.find("[name=Annualincomeid]").val(row_data.annualincomeid).change();
        tab.find("[name=Namercrelatedcoys]").val(row_data.namercrelatedcoys);
        tab.find("[name=Namercparentbody]").val(row_data.namercparentbody);
    },
    populateBank: function (row_data) {
        var tab = $("#updateWizard #frmBank");
        tab.find("[name=Bankid]").val(row_data.bankid).change();
        tab.find("[name=Bankaddress]").val(row_data.bankaddress);
        tab.find("[name=Bankaccountypeid]").val(row_data.bankaccountypeid).change();
        tab.find("[name=Bankaccountnumber]").val(row_data.bankaccountnumber);
        if (row_data.bankaccountopeneddate) {
            const formattedbankaccountopeneddate = moment(row_data.bankaccountopeneddate, 'YYYY-MM-DD')
            tab.find("[name=Bankaccountopeneddate]")
                .val(formattedbankaccountopeneddate.format('Do MMM YYYY'));
            //tab.find("[name=Bankaccountopeneddate]").val(row_data.bankaccountopeneddate.substr(0,10));
        }
    },
    populateKYC: function (items, table_name) {
        if (items.length == 0) {
            return;
        }
        var table = $(table_name);
        $.each(items, function (index, item) {
            table.find("select[name=slt_" + item.kycitemid + "]")
                .val(item.actionid).change();
            if (item.actiondate) {
                table.find("input[name=dt_" + item.kycitemid + "]")
                    .val(item.actiondate.substr(0, 10))
                    .removeAttr("disabled")
                    .css("visibility", "visible");
            }
        });
    },
    editAddressBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populateAddressFrm(" + row.addressid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    editPhoneBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populatePhoneFrm(" + row.phonecontactid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    editEmailBtnFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-warning btn-icon' ",
            "onclick='utilities.populateEmailFrm(" + row.emailcontactid + ")'>",
            "<i class='now-ui-icons ui-2_settings-90'>",
            "</i></button>"
        ].join("");
    },
    deleteKYCFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='utilities.removeKYCUpload(" + row.tracker + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    deleteKYCUpdateFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-danger btn-icon' ",
            "onclick='deleteKYCUpload(" + row.id + ")'>",
            "<i class='now-ui-icons ui-1_simple-remove'>",
            "</i></button>"
        ].join("");
    },
    viewUploadFormatter: function (val, row, index) {
        return [
            "<button class='btn btn-info btn-icon' ",
            "onclick='showKYCUpload(" + row.id + ")'>",
            "<i class='now-ui-icons gestures_tap-01'>",
            "</i></button>"
        ].join("");
    },
    populateAddressFrm: function (addressid) {
        var row = $("#addressUpdateTable")
            .bootstrapTable("getRowByUniqueId", addressid);

        // Populate individual form fields
        var addressForm = $("#frmAddressUpdate");
        addressForm.find("[name=addressid]").val(row.addressid);
        addressForm.find("[name=customerid]").val(row.customerid);
        addressForm.find("[name=address]").val(row.address);
        addressForm.find("[name=addresstypeid]")
            .val(row.addresstypeid).change();
        addressForm.find("[name=city]").val(row.city);
        addressForm.find("[name=stateid]")
            .val(row.stateid).change();
        addressForm.find("[name=countryid]")
            .val(row.countryid).change();

        // swap out title text + hide/show buttons
        $("#addressUpdateModal #title").text("Edit Address");
        $("#frmAddressUpdate #saveBtn").hide();
        $("#frmAddressUpdate #updateBtn").show();

        // form-enter/table-leave animation goes here
        $("#addressUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmAddressUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    populatePhoneFrm: function (phoneid) {
        var row = $("#phoneUpdateTable")
            .bootstrapTable("getRowByUniqueId", phoneid);

        // Populate individual form fields
        var phoneForm = $("#frmPhoneUpdate");
        phoneForm.find("[name=phonecontactid]").val(row.phonecontactid);
        phoneForm.find("[name=customerid]").val(row.customerid);
        phoneForm.find("[name=phone]").val(row.phone);

        // swap out title text + hide/show buttons
        $("#phoneUpdateModal #title").text("Edit Phone");
        $("#frmPhoneUpdate #saveBtn").hide();
        $("#frmPhoneUpdate #updateBtn").show();

        // form-enter/table-leave animation goes here
        $("#phoneUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmPhoneUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    populateEmailFrm: function (emailid) {
        var row = $("#emailUpdateTable")
            .bootstrapTable("getRowByUniqueId", emailid);

        // Populate individual form fields
        var emailForm = $("#frmEmailUpdate");
        emailForm.find("[name=emailcontactid]").val(row.emailcontactid);
        emailForm.find("[name=customerid]").val(row.customerid);
        emailForm.find("[name=email]").val(row.email);

        // swap out title text + hide/show buttons
        $("#emailUpdateModal #title").text("Edit E-mail");
        $("#frmEmailUpdate #saveBtn").hide();
        $("#frmEmailUpdate #updateBtn").show();

        // form-enter/table-leave animation goes here
        $("#emailUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmEmailUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    showAddressTable: function () {
        // animations + changes
        $("#addressUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmAddressUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#addressUpdateModal #title").text("Customer Phone(s)");

        // clear form values
        $("#frmAddressUpdate").trigger("reset");

    },
    showPhoneTable: function () {
        // animations + changes
        $("#phoneUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmPhoneUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#phoneUpdateModal #title").text("Customer Phone(s)");

        // clear form value
        $("#frmPhoneUpdate").trigger("reset");
    },
    showEmailTable: function () {
        // animations + changes
        $("#emailUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmEmailUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#emailUpdateModal #title").text("Customer E-mail(s)");

        // clear form value
        $("#frmEmailUpdate").trigger("reset");
    },
    updateAddress: function () {
        var form = $("#frmAddressUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "Customer address will be updated",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze update button
                $("#frmAddressUpdate #updateBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value; 
                });
                testDataObject = {
                           active: true,
                           address: "41 AYODELE STREET, MAFOLUKU, OSHODI, LAGOS STATE 14 TIWALADE STREET, SHOGUNLE, OSHODI, LAGOS STATE",
                           addressid: "1014",
                           addresstypeid: "2",
                           city: "LAGOS",
                           countryid: "1",
                           //customerid: "1020",
                           stateid: "25"
                }
                // Mark as active
                data["active"] = true;
               debugger
                $.ajax(url_path + "/Profile/UpdateCustomerAddress", {
                    data: JSON.stringify(data),
                   // data: JSON.stringify(testDataObject),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Save Customer Address",
                        text: "Customer address saved successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $('#addressUpdateTable').bootstrapTable("load", response);
                        // clear form and load data-table with updated entries
                        utilities.showAddressTable();
                        $("#frmAddressUpdate #updateBtn").removeAttr("disabled");
                    });
                    
                }, function (error) {
                    swal({
                        title: 'Update Customer Address',
                        text: 'Customer address update encountered an error!',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmAddressUpdate #updateBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    updatePhone: function () {
        var form = $("#frmPhoneUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "Customer phone will be updated",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze update button
                $("#frmPhoneUpdate #updateBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value;
                });

                // Mark as active
                data["active"] = true;

                $.ajax(url_path + "/Profile/UpdateCustomerPhone", {
                    data: JSON.stringify(data),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Save Customer Phone",
                        text: "Customer phone saved successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $('#phoneUpdateTable').bootstrapTable("load", response);
                        utilities.showPhoneTable();
                        $("#frmPhoneUpdate #updateBtn").removeAttr("disabled");
                    });

                }, function (error) {
                    swal({
                        title: 'Update Customer Phone',
                        text: 'Customer phone update encountered an error!',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmPhoneUpdate #updateBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    updateEmail: function () {
        var form = $("#frmEmailUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "Customer email will be updated",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze update button
                $("#frmEmailUpdate #updateBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value;
                });

                // Mark as active
                data["active"] = true;

                $.ajax(url_path + "/Profile/UpdateCustomerEmail", {
                    data: JSON.stringify(data),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Update Customer Email",
                        text: "Customer email updated successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $("#emailUpdateTable").bootstrapTable("load", response);
                        utilities.showEmailTable();
                        $("#frmEmailUpdate #updateBtn").removeAttr("disabled");
                    });
                }, function (error) {
                    swal({
                        title: 'Update Customer Email',
                        text: 'Customer email update encountered an error!',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmEmailUpdate #updateBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    addAddress: function () {
        var form = $("#frmAddressUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "New address will be added",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze save button
                $("#frmAddressUpdate #saveBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value;
                });

                // Mark as active / remove id fields
                data["active"] = true;
                data.customerid = UpdateCustomer.customerid;
                delete data.addressid;

                $.ajax(url_path + "/Profile/AddCustomerAddress", {
                    data: JSON.stringify(data),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Create New Address",
                        text: "Customer address created successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $('#addressUpdateTable').bootstrapTable("load", response);
                        // clear form and load data-table with new entries
                        utilities.showAddressTable();
                        $("#frmAddressUpdate #saveBtn").removeAttr("disabled");
                    });

                }, function (error) {
                    swal({
                        title: 'Create New Address',
                        text: 'An error occured while processing your request',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmAddressUpdate #saveBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    addPhone: function () {
        var form = $("#frmPhoneUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "New phone will be added",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze save button
                $("#frmPhoneUpdate #saveBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value;
                });

                // Mark as active / remove id fields
                data["active"] = true;
                data.customerid = UpdateCustomer.customerid;
                delete data.phonecontactid;

                $.ajax(url_path + "/Profile/AddCustomerPhone", {
                    data: JSON.stringify(data),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Create New Phone",
                        text: "Customer phone number created successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $('#phoneUpdateTable').bootstrapTable("load", response);
                        utilities.showPhoneTable();
                        $("#frmPhoneUpdate #saveBtn").removeAttr("disabled");
                    });
                }, function (error) {
                    swal({
                        title: 'Create New Phone',
                        text: 'An error occured while processing your request',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmPhoneUpdate #saveBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    addEmail: function () {
        var form = $("#frmEmailUpdate");

        if (!form.valid()) {
            return false;
        }

        swal({
            title: "Are you sure?",
            text: "New email will be added",
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
        }).then(function (isConfirm) {
            if (isConfirm) {
                // freeze save button
                $("#frmEmailUpdate #saveBtn")
                    .attr("disabled", "true");
                var form_data, data = {};
                form_data = form.serializeArray()
                $.each(form_data, function (index, item) {
                    data[item.name] = item.value;
                });

                // Mark as active / remove id fields
                data["active"] = true;
                data.customerid = UpdateCustomer.customerid;
                delete data.emailcontactid;

                $.ajax(url_path + "/Profile/AddCustomerEmail", {
                    data: JSON.stringify(data),
                    method: "POST",
                    contentType: "application/json"
                }).then(function (response) {
                    swal({
                        title: "Create New Email",
                        text: "Customer email created successfully!",
                        type: 'success',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        // reload data-table with response data
                        $('#emailUpdateTable').bootstrapTable("load", response);
                        utilities.showEmailTable();
                        $("#frmEmailUpdate #saveBtn").removeAttr("disabled");
                    });
                }, function (error) {
                    swal({
                        title: 'Create New Email',
                        text: 'An error occured while processing your request',
                        type: 'error',
                        allowOutsideClick: false,
                        allowEscapeKey: false
                    }).then(function () {
                        $("#frmEmailUpdate #saveBtn").removeAttr("disabled");
                    });
                });
            }
        }, function (isRejected) {
            return;
        });
    },
    showNewAddFrm: function () {
        // clear form
        $("#frmAddressUpdate").trigger("reset");
        $("#frmAddressUpdate select").val(null)
            .change();
        
        // swap out title text + hide/show buttons
        $("#addressUpdateModal #title").text("Add New Address");
        $("#frmAddressUpdate #saveBtn").show();
        $("#frmAddressUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#addressUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmAddressUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    showNewPhoneFrm: function () {
        // clear form
        $("#frmPhoneUpdate").trigger("reset");

        // swap out title text + hide/show buttons
        $("#phoneUpdateModal #title").text("Add New Phone");
        $("#frmPhoneUpdate #saveBtn").show();
        $("#frmPhoneUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#phoneUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmPhoneUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
    showNewEmailFrm: function () {
        // clear form
        $("#frmEmailUpdate").trigger("reset");

        // swap out title text + hide/show buttons
        $("#emailUpdateModal #title").text("Add New E-mail");
        $("#frmEmailUpdate #saveBtn").show();
        $("#frmEmailUpdate #updateBtn").hide();

        // form-enter/table-leave animation
        $("#emailUpdateTable").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
        $("#frmEmailUpdate").closest("div.row")
            .slideToggle({
                duration: utilities.animDuration,
                queue: false
            });
    },
};