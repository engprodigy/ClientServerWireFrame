
var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

var inputTypeId;

(function ($) {
    $.fn.dynamicForm = function (options) {
        var opts = $.extend({}, $.fn.dynamicForm.defaults, options);
        return this.each(function () {
            $this = $(this);
            var o = $.meta ? $.extend({}, opts, $this.data()) : opts;
            $(this).click(function () {
                addFieldset(o, $(this));
            });
        });
    };

    function addFieldset(options, addButtonObj) {

        debugger

        if (inputTypeId == 5) {

            options.numTimes = 1;
            options.maxFields = 2;
        } else {

            options.numTimes = 1;
            options.maxFields = false;
        }

        console.log(options.maxFields);

        var testVariable = $("#fieldsetracker").prevAll()

        console.log(testVariable);

        // var fieldsetEls = getImmediateSiblings(addButtonObj, 'FIELDSET'); //get all fieldset tags above the add button
        //var fieldsetEls = testVariable;

        var siblings = new Array();

        jQuery.each($("#fieldsetracker").prevAll(), function () {
            if (this.tagName == 'FIELDSET') {
                siblings.unshift($(this));
            } else {
                return siblings;
            }
        });

       // siblings.unshift(testVariable);

        var fieldsetEls = siblings;

        var fieldsetElsLen = fieldsetEls.length; //get the length of above

        if (!options.maxFields
            || ((fieldsetElsLen + options.numTimes) <= options.maxFields)) {
            var clone = fieldsetEls[0].clone(); //clone the first fieldset
            var db = getDeleteButtonObj(options); //create its delete button
            db.click(function () { //add delete button event
                var parent = $(this).parent('fieldset');
                parent.fadeOut(options.fadeDuration, function () {
                    $(this).remove();
                });
                return false;
            });
            db.appendTo(clone); //add the delete button to the clone

            clone.find(':input').each(function () { //clear the clone's fields
                //clear the inputs
                var type = this.type;
                var tag = this.tagName.toLowerCase(); // normalize tag name case
                // it's ok to reset the value attr of text inputs, password inputs, and textareas
                if (type == 'text' || type == 'password'
                    || tag == 'textarea')
                    this.value = "";
                // checkboxes and radios need to have their checked state cleared
                // but should *not* have their 'value' changed
                else if (type == 'checkbox' || type == 'radio')
                    this.checked = false;
                // select elements need to have their 'selectedIndex' property set to -1
                // (this works for both single and multiple select elements)
                else if (tag == 'select')
                    this.selectedIndex = -1;
            });
            //renumber the existing fieldsets starting at 1
            var count = 1;
            jQuery.each(fieldsetEls, function () {
                this.find(':input').each(function () {
                    renameField(this, 'id', count); // rename the fieldset inputs' id
                    renameField(this, 'name', count); // rename the fieldset inputs' name
                });
                count++;
            });
            //renumber the clones
            for (var i = count; i < (options.numTimes + count); i++) {
                var newClone = clone.clone(true);
                newClone.find(':input').each(function () {
                    renameField(this, 'id', i); // rename the fieldset inputs' id
                    renameField(this, 'name', i); // rename the fieldset inputs' name
                });
                
                newClone.insertBefore("#fieldsetracker");
                //newClone.insertBefore(addButtonObj);
            }
        } else {
            alert(options.maxFieldsMsg);
        }
    }

    function getImmediateSiblings(source, targetNodeType) {

        //expecting the targets nodes to be in a row
        //immeditately beside the source (add button)
        var siblings = new Array();
        jQuery.each(source.prevAll(), function () {
            if (this.tagName == targetNodeType) {
                siblings.unshift($(this));
            } else {
                return siblings;
            }
        });
        return siblings;
    }

    function renameField(obj, attr, num) {

        debugger;

        var a = $(obj).attr(attr).split(/_[0-9]*$/i)[0];
        $(obj).attr(attr, a + '_' + num);
    }

    function getDeleteButtonObj(options) {
        var html = '<div class="' + options.deleteButtonDiv + '">'
            + '<input type="button"value="' + options.deleteButtonValue
           + '"' + ' class="' + options.deleteButtonClass + '" id="delete" name="delete" />'
            + '</div>';
       // var html = '<div class="' + options.deleteButtonDiv + '">'
        //    + ' < input type = "button" class="btn btn-danger btn-next btn-wd" id = "addButton1" name = "add" id="delete" name="delete"'
        //    + 'value = "Add Extra Field" /> </div >';

        return $(html);
    }

    $.fn.dynamicForm.defaults = {
        numTimes: 1,
        maxFields: false,
        maxFieldsMsg: 'You have reached the maximum number of fields allowed',
        fadeDuration: 'slow',
        deleteButtonDiv: 'form-group',
        //deleteButtonDiv: 'delete-button-div',
        //deleteButtonClass: 'delete-button',
        deleteButtonClass: 'btn btn-danger btn-next btn-wd',
        deleteButtonValue: 'Delete This Option Field'
    };
})(jQuery);


var allCustomFields;


$(document).ready(function () {


    //initDataTable();
    initSelectTwoConfig();
    //initDatePicker(".datepicker");
    //initFormValidations();
    //initWizards();
    //$(".modal").perfectScrollbar();
   // prepareKYCTables();
   // $('#addButton1').dynamicForm();
    $('#addButton1').dynamicForm({
        deleteButtonDiv: 'form-group',
        //deleteButtonDiv: 'delete-button-div',
        //deleteButtonClass: 'delete-button',
        deleteButtonClass: 'btn btn-danger btn-next btn-wd',
        deleteButtonValue: 'Delete This Option Field',
        maxFields: false,
        numTimes: 1,
        fadeDuration: 'slow'
    });
    

});

function initSelectTwoConfig() {

    $.fn.select2.defaults.set("theme", "bootstrap4");
    $.fn.select2.defaults.set("dropdownParent", $(".card-body").first());
    $.fn.select2.defaults.set("width", "100%");
    $.fn.select2.defaults.set("allowClear", true);


    $("#InputType").select2({
        placeholder: "Select input type",
        //dropdownParent: $("#refereeUpdateModal.modal"),
        data: [{ "id": "1", "text": "Text" },
        { "id": "2", "text": "Checkbox" },
        { "id": "3", "text": "date" },
        { "id": "4", "text": "file" },
        { "id": "5", "text": "radio" },
        { "id": "6", "text": "Select" }]
    });


}



$("#InputType").on("select2:select", function (e) {

    debugger
    var inputid = e.params.data.id;
    console.log(inputid);

    inputTypeId = inputid;

   // $("#extrainput").val("");
    $("#custom-input").find("[name=extrainput]").val("");

    var value = $("fieldset").nextAll("#form-group").length;

    //$("fieldset").nextAll("#form-group").css({ "border": "2px solid red" });

    $("fieldset").nextAll("#form-group").remove();

    /*if ($("fieldset").nextAll().length != 2) {

        $("fieldset").nextAll().remove();

    }*/  

    //var value2 = $("input#extrainput").nextAll();   //.remove();

    if (inputid == 2) {

        $("#selectinputconfigure").show();
        $("#selectinputconfigureaddbutton").show();
        

    } else if (inputid == 5) {

        $("#selectinputconfigure").show();
        $("#selectinputconfigureaddbutton").show();
    }
    else if (inputid == 6) {

        $("#selectinputconfigure").show();
        $("#selectinputconfigureaddbutton").show();

    }
    else {

        $("#selectinputconfigure").hide();
        $("#selectinputconfigureaddbutton").hide();

    }
   

});

$("#submit").click(function (event) {

    debugger

    event.preventDefault(); 

    var form = $("#custom-input");

    console.log(form);

    var frmInputValue = $(form).serializeArray();

    console.log(frmInputValue);

    swal({
        title: "Are you sure?",
        text: "Custom Field Will be added",
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
            $.ajax({
                url: '../Setup/AddCustomField',
                type: 'POST',
                data: JSON.stringify(frmInputValue) ,
                dataType: "json",
                contentType: 'application/json; charset=utf-8',
                //headers: {
                //    'VerificationToken': forgeryId
                //},
                success: function (result) {
                    //alert(result);
                    if (result.toString !== '' && result !== null) {
                        swal({ title: 'Customer Custom Field', text: 'Custom Field Type added successfully!', type: 'success' }).then(function () { });

                        /*$('#listfreezeTable').
                            bootstrapTable(
                                'refresh', { url: 'FreezeSetup/listfreezetype' });*/

                       // $("#btnFreezeTypeUpdate").removeAttr("disabled");
                       // $('#FreezeTypeModal').modal('hide');

                        //$('#extrainput').val("");
                        $("fieldset").nextAll("#form-group").remove();
                        $("#selectinputconfigure").hide();
                        $("#selectinputconfigureaddbutton").hide();
                        $('#custom-input')[0].reset();
                        $("#InputType").val('').trigger('change');

                    }
                    else {
                        swal({ title: 'Customer Custom Field', text: 'Something went wrong: </br>' + result.toString(), type: 'error' }).then(function () { });
                        $("#submit").removeAttr("disabled");
                    }
                },
                error: function (e) {
                    swal({ title: 'Customer Custom Field', text: 'Customer Custom Field encountered an error', type: 'error' }).then(function () { });
                    //$("#btnFreezeTypeUpdate").removeAttr("disabled");
                }
            });

        }

    }, function (isRejected) {

            swal({
                title: "Cancel Customer Custom Field",
                text: "Customer Custom Field Addition was Cancelled!",
                type: "error"
            });
        //$('#FreezeTypeModal').modal('hide');
        return;
    }); 

});








/*

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: url_path + "/CaptureCaptionList",
        success: function (response) {
            
            $("#Caption1").val(response[0].caption1);
            $("#HtmlCaption1").html(response[0].caption1);
            if (response[0].caption1 != null && response[0].caption2 != "") {   
                $("#btnUpdate1").show();
                $("#btnSubmit1").hide();
            }

            $("#Caption2").val(response[0].caption2);
            $("#HtmlCaption2").html(response[0].caption2);
            if (response[0].caption2 != null && response[0].caption2 != "") {
                $("#btnUpdate2").show();
                $("#btnSubmit2").hide();
            }

            $("#Caption3").val(response[0].caption3);
            $("#HtmlCaption3").html(response[0].caption3);
            if (response[0].caption3 != null && response[0].caption3 != "") {
                $("#btnUpdate3").show();
                $("#btnSubmit3").hide();
            }

            $("#Caption4").val(response[0].caption4);
            $("#HtmlCaption4").html(response[0].caption4);
            if (response[0].caption4 != null && response[0].caption4 != "") {
                $("#btnUpdate4").show();
                $("#btnSubmit4").hide();
            }

            $("#Caption5").val(response[0].caption5);
            $("#HtmlCaption5").html(response[0].caption5);
            if (response[0].caption5 != null && response[0].caption5 != "") {
                $("#btnUpdate5").show();
                $("#btnSubmit5").hide();
            }

            $("#Caption6").val(response[0].caption6);
            $("#HtmlCaption6").html(response[0].caption6);
            if (response[0].caption6 != null && response[0].caption6 != "") {
                $("#btnUpdate6").show();
                $("#btnSubmit6").hide();
            }

            $("#Caption7").val(response[0].caption7);
            $("#HtmlCaption7").html(response[0].caption7);
            if (response[0].caption7 != null && response[0].caption7 != "") {
                $("#btnUpdate7").show();
                $("#btnSubmit7").hide();
            }

            $("#Caption8").val(response[0].caption8);
            $("#HtmlCaption8").html(response[0].caption8);
            if (response[0].caption8 != null && response[0].caption8 != "") {
                $("#btnUpdate8").show();
                $("#btnSubmit8").hide();
            }

            $("#Caption9").val(response[0].caption9);
            $("#HtmlCaption9").html(response[0].caption9);
            if (response[0].caption9 != null && response[0].caption9 != "") {
                $("#btnUpdate9").show();
                $("#btnSubmit9").hide();
            }

            $("#Caption10").val(response[0].caption10);
            $("#HtmlCaption10").html(response[0].caption10);
            if (response[0].caption10 != null && response[0].caption10 != "") {
                $("#btnUpdate10").show();
                $("#btnSubmit10").hide();
            }

            $("#Caption11").val(response[0].caption11);
            $("#HtmlCaption11").html(response[0].caption11);
            if (response[0].caption11 != null && response[0].caption11 != "") {
                $("#btnUpdate11").show();
                $("#btnSubmit11").hide();
            }

            $("#Caption12").val(response[0].caption12);
            $("#HtmlCaption12").html(response[0].caption12);
            if (response[0].caption12 != null && response[0].caption12 != "") {
                $("#btnUpdate12").show();
                $("#btnSubmit12").hide();
            }

            $("#Caption13").val(response[0].caption13);
            $("#HtmlCaption13").html(response[0].caption13);
            if (response[0].caption13 != null && response[0].caption13 != "") {
                $("#btnUpdate13").show();
                $("#btnSubmit13").hide();
            }

            $("#Caption14").val(response[0].caption14);
            $("#HtmlCaption14").html(response[0].caption14);
            if (response[0].caption14 != null && response[0].caption14 != "") {
                $("#btnUpdate14").show();
                $("#btnSubmit14").hide();
            }

            $("#Caption15").val(response[0].caption15);
            $("#HtmlCaption15").html(response[0].caption15);
            if (response[0].caption15 != null && response[0].caption15 != "") {
                $("#btnUpdate15").show();
                $("#btnSubmit15").hide();
            }

            $("#Caption16").val(response[0].caption16);
            $("#HtmlCaption16").html(response[0].caption16);
            if (response[0].caption16 != null && response[0].caption16 != "") {
                $("#btnUpdate16").show();
                $("#btnSubmit16").hide();
            }

            $("#Caption17").val(response[0].caption17);
            $("#HtmlCaption17").html(response[0].caption17);
            if (response[0].caption17 != null && response[0].caption17 != "") {
                $("#btnUpdate17").show();
                $("#btnSubmit17").hide();
            }

            $("#Caption18").val(response[0].caption18);
            $("#HtmlCaption18").html(response[0].caption18);
            if (response[0].caption18 != null && response[0].caption18 != "") {
                $("#btnUpdate18").show();
                $("#btnSubmit18").hide();
            }

            $("#Caption19").val(response[0].caption19);
            $("#HtmlCaption19").html(response[0].caption19);
            if (response[0].caption19 != null && response[0].caption19 != "") {
                $("#btnUpdate19").show();
                $("#btnSubmit19").hide();
            }

            $("#Caption20").val(response[0].caption20);
            $("#HtmlCaption20").html(response[0].caption20);
            if (response[0].caption20 != null && response[0].caption20 != "") {
                $("#btnUpdate20").show();
                $("#btnSubmit20").hide();
            }
        }
    })


    

})
*/

/*

    $("#btnUpdate1").click(function () {
    
        var caption1 = $("#Caption1").val();
        var caption2 = $("#Caption2").val();
        var caption3 = $("#Caption3").val();
        var caption4 = $("#Caption4").val();
        var caption5 = $("#Caption5").val();
        var caption6 = $("#Caption6").val();
        var caption7 = $("#Caption7").val();
        var caption8 = $("#Caption8").val();
        var caption9 = $("#Caption9").val();
        var caption10 = $("#Caption10").val();
        var caption11 = $("#Caption11").val();
        var caption12 = $("#Caption12").val();
        var caption13 = $("#Caption13").val();
        var caption14 = $("#Caption14").val();
        var caption15 = $("#Caption15").val();
        var caption16 = $("#Caption16").val();
        var caption17 = $("#Caption17").val();
        var caption18 = $("#Caption18").val();
        var caption19 = $("#Caption19").val();
        var caption20 = $("#Caption20").val();
        $.ajax({
            url: url_path + "/CaptureCaption",
            type: "POST",
            data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
            success: function (response) {          
            }
        })

        $("#Caption1").val(caption1);
        $("#HtmlCaption1").html(caption1);
      
             if (caption1 != "" ) {
                    $("#btnUpdate1").show();
                    $("#btnSubmit1").hide();
                } else {
                    $("#btnUpdate1").hide();
                    $("#btnSubmit1").show();
                }
    
    })

    $("#btnSubmit1").click(function () {
       
        

        var caption1 = $("#Caption1").val();
        var caption2 = $("#Caption2").val();
        var caption3 = $("#Caption3").val();
        var caption4 = $("#Caption4").val();
        var caption5 = $("#Caption5").val();
        var caption6 = $("#Caption6").val();
        var caption7 = $("#Caption7").val();
        var caption8 = $("#Caption8").val();
        var caption9 = $("#Caption9").val();
        var caption10 = $("#Caption10").val();
        var caption11 = $("#Caption11").val();
        var caption12 = $("#Caption12").val();
        var caption13 = $("#Caption13").val();
        var caption14 = $("#Caption14").val();
        var caption15 = $("#Caption15").val();
        var caption16 = $("#Caption16").val();
        var caption17 = $("#Caption17").val();
        var caption18 = $("#Caption18").val();
        var caption19 = $("#Caption19").val();
        var caption20 = $("#Caption20").val();
        $.ajax({
            url: url_path + "/CaptureCaption",
            type: "POST",
            data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
            success: function (response) {

               
            }
        })
        
            
        $("#Caption1").val(caption1);
        $("#HtmlCaption1").html(caption1);
                if ( caption1 != "") {

                       $("#btnUpdate1").show();
                       $("#btnSubmit1").hide();
                 }
                 else
                 {
                     $("#btnUpdate1").hide();
                     $("#btnSubmit1").show();

                 }
            
       
       
    })



   
    //Second Submit Button and update button


$("#btnUpdate2").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption2").val(caption2);
    $("#HtmlCaption2").html(caption2);

    if (caption2 != "") {
        $("#btnUpdate2").show();
        $("#btnSubmit2").hide();
    } else {
        $("#btnUpdate2").hide();
        $("#btnSubmit2").show();
    }

})

$("#btnSubmit2").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption2").val(caption2);
    $("#HtmlCaption2").html(caption2);
    if (caption2 != "") {

        $("#btnUpdate2").show();
        $("#btnSubmit2").hide();
    }
    else {
        $("#btnUpdate2").hide();
        $("#btnSubmit2").show();

    }



})
   
    //Third Submit Button and update button

$("#btnUpdate3").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption3").val(caption3);
    $("#HtmlCaption3").html(caption3);

    if (caption3 != "") {
        $("#btnUpdate3").show();
        $("#btnSubmit3").hide();
    } else {
        $("#btnUpdate3").hide();
        $("#btnSubmit3").show();
    }

})

$("#btnSubmit3").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption3").val(caption3);
    $("#HtmlCaption3").html(caption3);
    if (caption3 != "") {

        $("#btnUpdate3").show();
        $("#btnSubmit3").hide();
    }
    else {
        $("#btnUpdate3").hide();
        $("#btnSubmit3").show();

    }



})
   
    //Fourth Submit Button and update button

$("#btnUpdate4").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption4").val(caption4);
    $("#HtmlCaption4").html(caption4);

    if (caption4 != "") {
        $("#btnUpdate4").show();
        $("#btnSubmit4").hide();
    } else {
        $("#btnUpdate4").hide();
        $("#btnSubmit4").show();
    }

})

$("#btnSubmit4").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption4").val(caption4);
    $("#HtmlCaption4").html(caption4);
    if (caption4 != "") {

        $("#btnUpdate4").show();
        $("#btnSubmit4").hide();
    }
    else {
        $("#btnUpdate4").hide();
        $("#btnSubmit4").show();

    }



})
    
    //Fifth Submit Button and update button

$("#btnUpdate5").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption5").val(caption5);
    $("#HtmlCaption5").html(caption5);

    if (caption5 != "") {
        $("#btnUpdate5").show();
        $("#btnSubmit5").hide();
    } else {
        $("#btnUpdate5").hide();
        $("#btnSubmit5").show();
    }

})

$("#btnSubmit5").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption5").val(caption5);
    $("#HtmlCaption5").html(caption5);
    if (caption5 != "") {

        $("#btnUpdate5").show();
        $("#btnSubmit5").hide();
    }
    else {
        $("#btnUpdate5").hide();
        $("#btnSubmit5").show();

    }



})
    
    //Sixth Submit Button and update button

$("#btnUpdate6").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption6").val(caption6);
    $("#HtmlCaption6").html(caption6);

    if (caption6 != "") {
        $("#btnUpdate6").show();
        $("#btnSubmit6").hide();
    } else {
        $("#btnUpdate6").hide();
        $("#btnSubmit6").show();
    }

})

$("#btnSubmit6").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption6").val(caption6);
    $("#HtmlCaption6").html(caption6);
    if (caption6 != "") {

        $("#btnUpdate6").show();
        $("#btnSubmit6").hide();
    }
    else {
        $("#btnUpdate6").hide();
        $("#btnSubmit6").show();

    }



})
    
    //Sevnth Submit Button and update button

$("#btnUpdate7").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption7").val(caption7);
    $("#HtmlCaption7").html(caption7);

    if (caption7 != "") {
        $("#btnUpdate7").show();
        $("#btnSubmit7").hide();
    } else {
        $("#btnUpdate7").hide();
        $("#btnSubmit7").show();
    }

})

$("#btnSubmit7").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption7").val(caption7);
    $("#HtmlCaption7").html(caption7);
    if (caption7 != "") {

        $("#btnUpdate7").show();
        $("#btnSubmit7").hide();
    }
    else {
        $("#btnUpdate7").hide();
        $("#btnSubmit7").show();

    }



})

    
    //Eighth Submit Button and update button

$("#btnUpdate8").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption8").val(caption8);
    $("#HtmlCaption8").html(caption8);

    if (caption8 != "") {
        $("#btnUpdate8").show();
        $("#btnSubmit8").hide();
    } else {
        $("#btnUpdate8").hide();
        $("#btnSubmit8").show();
    }

})

$("#btnSubmit8").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption8").val(caption8);
    $("#HtmlCaption8").html(caption8);
    if (caption8 != "") {

        $("#btnUpdate8").show();
        $("#btnSubmit8").hide();
    }
    else {
        $("#btnUpdate8").hide();
        $("#btnSubmit8").show();

    }



})
    
    //Ninth Submit Button and update button

$("#btnUpdate9").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption9").val(caption9);
    $("#HtmlCaption9").html(caption9);

    if (caption9 != "") {
        $("#btnUpdate9").show();
        $("#btnSubmit9").hide();
    } else {
        $("#btnUpdate9").hide();
        $("#btnSubmit9").show();
    }

})

$("#btnSubmit9").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption9").val(caption9);
    $("#HtmlCaption9").html(caption9);
    if (caption9 != "") {

        $("#btnUpdate9").show();
        $("#btnSubmit9").hide();
    }
    else {
        $("#btnUpdate9").hide();
        $("#btnSubmit9").show();

    }



})
    
    //Tenth Submit Button and update button

$("#btnUpdate10").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption10").val(caption10);
    $("#HtmlCaption10").html(caption10);

    if (caption10 != "") {
        $("#btnUpdate10").show();
        $("#btnSubmit10").hide();
    } else {
        $("#btnUpdate10").hide();
        $("#btnSubmit10").show();
    }

})

$("#btnSubmit10").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption10").val(caption10);
    $("#HtmlCaption10").html(caption10);
    if (caption10 != "") {

        $("#btnUpdate10").show();
        $("#btnSubmit10").hide();
    }
    else {
        $("#btnUpdate10").hide();
        $("#btnSubmit10").show();

    }



})
   
    //Eleventh Submit Button and update button

$("#btnUpdate11").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption11").val(caption11);
    $("#HtmlCaption11").html(caption11);

    if (caption11 != "") {
        $("#btnUpdate11").show();
        $("#btnSubmit11").hide();
    } else {
        $("#btnUpdate11").hide();
        $("#btnSubmit11").show();
    }

})

$("#btnSubmit11").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption11").val(caption11);
    $("#HtmlCaption11").html(caption11);
    if (caption11 != "") {

        $("#btnUpdate11").show();
        $("#btnSubmit11").hide();
    }
    else {
        $("#btnUpdate11").hide();
        $("#btnSubmit11").show();

    }



})

    
    //Twelveth Submit Button and update button

$("#btnUpdate12").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption12").val(caption12);
    $("#HtmlCaption12").html(caption12);

    if (caption12 != "") {
        $("#btnUpdate12").show();
        $("#btnSubmit12").hide();
    } else {
        $("#btnUpdate12").hide();
        $("#btnSubmit12").show();
    }

})

$("#btnSubmit12").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption12").val(caption12);
    $("#HtmlCaption12").html(caption12);
    if (caption12 != "") {

        $("#btnUpdate12").show();
        $("#btnSubmit12").hide();
    }
    else {
        $("#btnUpdate12").hide();
        $("#btnSubmit12").show();

    }



})
    
    //Thirteenth Submit Button and update button

$("#btnUpdate13").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption13").val(caption13);
    $("#HtmlCaption13").html(caption13);

    if (caption13 != "") {
        $("#btnUpdate13").show();
        $("#btnSubmit13").hide();
    } else {
        $("#btnUpdate13").hide();
        $("#btnSubmit13").show();
    }

})

$("#btnSubmit13").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption13").val(caption13);
    $("#HtmlCaption13").html(caption13);
    if (caption13 != "") {

        $("#btnUpdate13").show();
        $("#btnSubmit13").hide();
    }
    else {
        $("#btnUpdate13").hide();
        $("#btnSubmit13").show();

    }



})
    
    //Fourteenth Submit Button and update button

$("#btnUpdate14").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption14").val(caption14);
    $("#HtmlCaption14").html(caption14);

    if (caption14 != "") {
        $("#btnUpdate14").show();
        $("#btnSubmit14").hide();
    } else {
        $("#btnUpdate14").hide();
        $("#btnSubmit14").show();
    }

})

$("#btnSubmit14").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption14").val(caption14);
    $("#HtmlCaption14").html(caption14);
    if (caption14 != "") {

        $("#btnUpdate14").show();
        $("#btnSubmit14").hide();
    }
    else {
        $("#btnUpdate14").hide();
        $("#btnSubmit14").show();

    }



})
   
    //Fifteenth Submit Button and update button

$("#btnUpdate15").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption15").val(caption15);
    $("#HtmlCaption15").html(caption15);

    if (caption15 != "") {
        $("#btnUpdate15").show();
        $("#btnSubmit15").hide();
    } else {
        $("#btnUpdate15").hide();
        $("#btnSubmit15").show();
    }

})

$("#btnSubmit15").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption15").val(caption15);
    $("#HtmlCaption15").html(caption15);
    if (caption15 != "") {

        $("#btnUpdate15").show();
        $("#btnSubmit15").hide();
    }
    else {
        $("#btnUpdate15").hide();
        $("#btnSubmit15").show();

    }



})

    
    //Sixteenth Submit Button and update button

$("#btnUpdate16").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption16").val(caption16);
    $("#HtmlCaption16").html(caption16);

    if (caption16 != "") {
        $("#btnUpdate16").show();
        $("#btnSubmit16").hide();
    } else {
        $("#btnUpdate16").hide();
        $("#btnSubmit16").show();
    }

})

$("#btnSubmit16").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption16").val(caption16);
    $("#HtmlCaption16").html(caption16);
    if (caption16 != "") {

        $("#btnUpdate16").show();
        $("#btnSubmit16").hide();
    }
    else {
        $("#btnUpdate16").hide();
        $("#btnSubmit16").show();

    }



})

    
    //Sevententh Submit Button and update button

$("#btnUpdate17").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption17").val(caption17);
    $("#HtmlCaption17").html(caption17);

    if (caption17 != "") {
        $("#btnUpdate17").show();
        $("#btnSubmit17").hide();
    } else {
        $("#btnUpdate17").hide();
        $("#btnSubmit17").show();
    }

})

$("#btnSubmit17").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption17").val(caption17);
    $("#HtmlCaption17").html(caption17);
    if (caption17 != "") {

        $("#btnUpdate17").show();
        $("#btnSubmit17").hide();
    }
    else {
        $("#btnUpdate17").hide();
        $("#btnSubmit17").show();

    }



})
    
    //Eighteenth Submit Button and update button

$("#btnUpdate18").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption18").val(caption18);
    $("#HtmlCaption18").html(caption18);

    if (caption18 != "") {
        $("#btnUpdate18").show();
        $("#btnSubmit18").hide();
    } else {
        $("#btnUpdate18").hide();
        $("#btnSubmit18").show();
    }

})

$("#btnSubmit19").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption19").val(caption19);
    $("#HtmlCaption19").html(caption19);
    if (caption19 != "") {

        $("#btnUpdate19").show();
        $("#btnSubmit19").hide();
    }
    else {
        $("#btnUpdate19").hide();
        $("#btnSubmit19").show();

    }



})
    
    //Nineteenth Submit Button and update button

$("#btnUpdate1").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption19").val(caption19);
    $("#HtmlCaption19").html(caption19);

    if (caption19 != "") {
        $("#btnUpdate19").show();
        $("#btnSubmit19").hide();
    } else {
        $("#btnUpdate19").hide();
        $("#btnSubmit19").show();
    }

})

$("#btnSubmit19").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption19").val(caption19);
    $("#HtmlCaption19").html(caption19);
    if (caption19 != "") {

        $("#btnUpdate19").show();
        $("#btnSubmit19").hide();
    }
    else {
        $("#btnUpdate19").hide();
        $("#btnSubmit19").show();

    }



})
    
    //Twentieth Submit Button and update button

$("#btnUpdate20").click(function () {

    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {
        }
    })

    $("#Caption20").val(caption20);
    $("#HtmlCaption20").html(caption20);

    if (caption20 != "") {
        $("#btnUpdate20").show();
        $("#btnSubmit20").hide();
    } else {
        $("#btnUpdate20").hide();
        $("#btnSubmit20").show();
    }

})

$("#btnSubmit20").click(function () {



    var caption1 = $("#Caption1").val();
    var caption2 = $("#Caption2").val();
    var caption3 = $("#Caption3").val();
    var caption4 = $("#Caption4").val();
    var caption5 = $("#Caption5").val();
    var caption6 = $("#Caption6").val();
    var caption7 = $("#Caption7").val();
    var caption8 = $("#Caption8").val();
    var caption9 = $("#Caption9").val();
    var caption10 = $("#Caption10").val();
    var caption11 = $("#Caption11").val();
    var caption12 = $("#Caption12").val();
    var caption13 = $("#Caption13").val();
    var caption14 = $("#Caption14").val();
    var caption15 = $("#Caption15").val();
    var caption16 = $("#Caption16").val();
    var caption17 = $("#Caption17").val();
    var caption18 = $("#Caption18").val();
    var caption19 = $("#Caption19").val();
    var caption20 = $("#Caption20").val();
    $.ajax({
        url: url_path + "/CaptureCaption",
        type: "POST",
        data: { Caption1: caption1, Caption2: caption2, Caption3: caption3, Caption4: caption4, Caption5: caption5, Caption6: caption6, Caption7: caption7, Caption8: caption8, Caption9: caption9, Caption10: caption10, Caption11: caption11, Caption12: caption12, Caption13: caption13, Caption14: caption14, Caption15: caption15, Caption16: caption16, Caption17: caption17, Caption18: caption18, Caption19: caption19, Caption20: caption20 },
        success: function (response) {


        }
    })


    $("#Caption20").val(caption20);
    $("#HtmlCaption20").html(caption20);
    if (caption20 != "") {

        $("#btnUpdate20").show();
        $("#btnSubmit20").hide();
    }
    else {
        $("#btnUpdate20").hide();
        $("#btnSubmit20").show();

    }



})*/
    
