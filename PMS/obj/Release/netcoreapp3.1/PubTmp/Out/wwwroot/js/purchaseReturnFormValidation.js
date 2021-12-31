$(document).on("input", ".calc", function () {
    var sum = 0;
    var rent = 0;
    var tax = 0;
    var discount = 0;

    rent = +$("#rent").val();
    tax = +$("#tax").val();
    discount = +$("#totalDiscount").val();


    $(".total").each(function () {
        sum += +$(this).val();
    });

    var id = $(this).attr("id");

    if (id == "rent" || id == "tax" || id == "totalPercentDiscount" || id == "due" || id == "paid") {
        sum += rent;
        sum += tax;
        sum -= discount;
        $("#grandtotal").val(sum);
        $("#due").val(sum);
    } else {
        $("#subTotal").val(sum);
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
    var rent = 0;
    var tax = 0;
    var discount = 0;
    var paid = 0;

    $("input[name='totalReturnPrice']").each(function () {
        subtotal += +$(this).val();
    });
    $("#subTotal").val(subtotal);

    rent = +$("#rent").val();
    tax = +$("#tax").val();
    discount = +$("#totalDiscount").val();

    subtotal += rent;
    subtotal += tax;
    subtotal -= discount;


    $("#grandtotal").val(subtotal);

    paid = +$("#paid").val();
    subtotal -= paid;

    $("#due").val(subtotal);
}

//function clearAll() {
//    $("select[name='ProductId']").each(function () {
//        $(this).prop("selectedIndex", 0);
//    });

//    $("input[name='Qty']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='PurchasePrice']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='SellPrice']").each(function () {
//        $(this).val(0);
//    });

//    $("input[name='TotalPurchasePrice']").each(function () {
//        $(this).val(0);
//    });

//    $("#total").val(0);
//    $("#rent").val(0);
//    $("#tax").val(0);
//    $("#discount").val(0);
//    $("#discAmount").text(0);
//    $("#totalPercentDiscount").val(0);
//    $("#grandtotal").val(0);
//    $("#paid").val(0);
//    $("#due").val(0);
//}