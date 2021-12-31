$(document).on("input", ".calc", function () {
    var sum = 0;
    var excharges = 0;
    var income = 0;


    excharges = +$("#excharges").val();
    income = +$("#income").val();


    $(".total").each(function () {
        sum += +$(this).val();
    });

    var id = $(this).attr("id");

    if (id == "excharges" || id == "income") {
        sum += excharges;
        sum -= income;
        $("#grandtotal").val(sum);
    } else {
        $("#total").val(sum);
        $("#grandtotal").val(sum);
    }

});



function clearAll() {
    $("select[name='ProductId']").each(function () {
        $(this).prop("selectedIndex", 0);
    });

    $("select[name='BatchId']").each(function () {
        $(this).prop("selectedIndex", 0);
    });

    $("input[name='Qty']").each(function () {
        $(this).val(0);
    });

    $("input[name='UnitPrice']").each(function () {
        $(this).val(0);
    });


    $("input[name='TotalPrice']").each(function () {
        $(this).val(0);
    });

    $("#total").val(0);
    $("#excharges").val(0);
    $("#income").val(0);
    $("#grandtotal").val(0);
}

function calculate2() {
    var subtotal = 0;
    var exch = 0;
    var income = 0;


    $("input[name='TotalPrice']").each(function () {
        subtotal += +$(this).val();
    });
    $("#total").val(subtotal);

    excharges = +$("#excharges").val();
    income = +$("#income").val();


    subtotal += excharges;
    subtotal -= income;


    $("#grandtotal").val(subtotal);

}