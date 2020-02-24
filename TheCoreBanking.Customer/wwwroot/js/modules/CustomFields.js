
var url_path = window.location.pathname;
if (url_path.charAt(url_path.length - 1) == '/') {
    url_path = url_path.slice(0, url_path.length - 1);
}

var allCustomFields;

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



})
    

           