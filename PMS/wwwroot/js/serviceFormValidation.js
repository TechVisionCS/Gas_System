$(document).on("input", ".calc", function () {
    var sum = 0;
    var tax = 0;
    var totalDiscount = 0;

    tax = +$("#tax").val();
    totalDiscount = +$("#totalDiscount").val();

    $(".total").each(function () {
        sum += +$(this).val();
    });

    var id = $(this).attr("id");

    if (id == "tax" || id == "totalDiscount" || id == "totalPercentDiscount" || id == "due" || id == "paid") {
        sum += tax;
        sum -= totalDiscount;
        $("#grandtotal").val(sum);
        $("#due").val(sum);
    } else {
        $("#total").val(sum);
        $("#grandtotal").val(sum);
        $("#due").val(sum);
    }
});

$(document).on("input", "#paid", function () {
    var gtotal = 0;
    var paid = +$("#paid").val();
    gtotal = +$("#grandtotal").val();
    var res = gtotal - paid;
    $("#due").val(res);
});

function calculate() {
    var subtotal = 0;
    var tax = 0;
    var discount = 0;
    var paid = 0;

    $("input[name='TotalServicePrice']").each(function () {
        subtotal += +$(this).val();
    });

    $("#total").val(subtotal);

    tax = +$("#tax").val();
    discount = +$("#totalDiscount").val();

    subtotal += tax;
    subtotal -= discount;

    $("#grandtotal").val(subtotal);

    paid = +$("#paid").val();
    subtotal -= paid;

    $("#due").val(subtotal);
}

function clearAll() {
    $("select[name='ServiceCatergoryId']").each(function () {
        $(this).prop("selectedIndex", 0);
    });

    $("input[name='Qty']").each(function () {
        $(this).val(0);
    });

    $("input[name='Fee_Charges']").each(function () {
        $(this).val(0);
    });

    $("input[name='Discount']").each(function () {
        $(this).val(0);
    });

    $("input[name='Descriptions']").each(function () {
        $(this).val("");
    });

    $("input[name='TotalServicePrice']").each(function () {
        $(this).val(0);
    });

    $("#total").val(0);
    $("#tax").val(0);
    $("#totalDiscount").val(0);
    $("#discAmount").text(0);
    $("#totalPercentDiscount").val(0);
    $("#grandtotal").val(0);
    $("#paid").val(0);
    $("#due").val(0);
    $("#Descriptions").val("");
    document.getElementById('ServiceCatergoryId').selectedIndex = 0;
}

//$(document).on("input", ".calc", function () {
//    var sum = 0;
//    var tax = 0;
//    var discount = 0;

//    tax = +$("#tax").val();
//    discount = +$("#discount").val();


//    $(".total").each(function () {
//        sum += +$(this).val();
//    });

//    var id = $(this).attr("id");

//    if (id == "tax" || id == "discount" || id == "totalPercentDiscount" || id == "due" || id == "paid") {
//        sum += tax;
//        sum -= discount;
//        $("#grandtotal").val(sum);
//        $("#due").val(sum);
//    } else {        
//        $("#total").val(sum);
//        $("#grandtotal").val(sum);
//        $("#due").val(sum);
//    }
    
//});

//$(document).on("input", "#paid", function () {
//    var gtotal = 0;
//    var paid = +$("#paid").val();
//    gtotal = +$("#grandtotal").val();

//    var res = gtotal - paid;
//    $("#due").val(res);
//});

//function calculate() {
//    var subtotal = 0;
//    var tax = 0;
//    var discount = 0;
//    var paid = 0;

//    $("input[name='TotalServicePrice']").each(function () {
//        subtotal += +$(this).val();
//    });
//    $("#total").val(subtotal);

//    tax = +$("#tax").val();
//    discount = +$("#discount").val();

//    subtotal += tax;
//    subtotal -= discount;

    
//    $("#grandtotal").val(subtotal);

//    paid = +$("#paid").val();
//    subtotal -= paid;

//    $("#due").val(subtotal);
//}

//function clearAll() {
//    $("select[name='ServiceCatergoryId']").each(function () {
//        $(this).prop("selectedIndex", 0);
//    });

//    $("input[name='Qty']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='Fee_Charges']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='Discount']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='Descriptions']").each(function () {
//        $(this).val("");
//    });

//    $("input[name='TotalServicePrice']").each(function () {
//        $(this).val(0);
//    });

//    $("#total").val(0);
//    $("#tax").val(0);
//    $("#totalDiscount").val(0);
//    $("#discAmount").text(0);
//    $("#totalPercentDiscount").val(0);
//    $("#grandtotal").val(0);
//    $("#paid").val(0);
//    $("#due").val(0);
//}