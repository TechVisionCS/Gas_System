$(document).on("input", ".calc", function () {
    var sum = 0;
    var rent = 0;
    var tax = 0;
    var totalDiscount = 0;


    rent = +$("#rent").val();
    tax = +$("#tax").val();
    totalDiscount = +$("#totalDiscount").val();


    $(".total").each(function () {
        sum += +$(this).val();
    });

    var id = $(this).attr("id");

    if (id == "rent" || id == "tax" || id == "totalPercentDiscount" || id == "due" || id == "paid") {
        sum += rent;
        sum += tax;
        sum -= totalDiscount;
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

function calculate2() {
    var subtotal = 0;
    var rent = 0;
    var tax = 0;
    var discount = 0;
    var paid = 0;

    $("input[name='TotalPrice']").each(function () {
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

