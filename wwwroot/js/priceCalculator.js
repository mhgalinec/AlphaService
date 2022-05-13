function priceCalculator() {

    var brakePrice = parseFloat($('#brake-fluid-change-price').text().replace("$", ""));
    var oilPrice = parseFloat($('#oil-filter-change-price').text().replace("$", ""));
    var airPrice = parseFloat($('#air-filter-change-price').text().replace("$", ""));
    var chainPrice = parseFloat($('#chain-change-price').text().replace("$", ""));
    var totalPrice;
    var fullPrice;
    var discount;

    if (!isNaN(chainPrice) && !isNaN(brakePrice) && isNaN(airPrice) && isNaN(oilPrice)) {

        fullPrice = chainPrice + brakePrice;
        discount = "15%";
        totalPrice = ((chainPrice + brakePrice) * 0.85).toFixed(2);
        append(fullPrice, totalPrice, discount);
    }
    else if (!isNaN(oilPrice) && !isNaN(airPrice) && isNaN(brakePrice) && isNaN(chainPrice)) {

        totalPrice = ((oilPrice + airPrice) - 20).toFixed(2);
        fullPrice = oilPrice + airPrice;
        discount = "20$";
        append(fullPrice, totalPrice, discount);
    }
    else if (!isNaN(chainPrice) && !isNaN(oilPrice) && !isNaN(airPrice) && isNaN(brakePrice)) {

        totalPrice = ((chainPrice + oilPrice + airPrice) * 0.80).toFixed(2);
        fullPrice = chainPrice + oilPrice + airPrice;
        discount = "20%";
        append(fullPrice, totalPrice, discount);
    }
    else if (!isNaN(brakePrice) && !isNaN(oilPrice) && !isNaN(airPrice) && !isNaN(chainPrice)) {

        totalPrice = ((brakePrice + oilPrice + airPrice + chainPrice) - 40).toFixed(2);
        fullPrice = brakePrice + oilPrice + airPrice + chainPrice;
        discount = "40$";
        append(fullPrice, totalPrice, discount);
    }
    else {
        var total = 0;
        $('input[type=checkbox]:checked').each(function () {
            total = total + parseFloat($(this).data("price"));
            console.log(total);
        });
        $('#discount').empty();
        $('#totalPrice').empty().append(total + "$");
        $('#fullPrice').empty().append(total + "$");
    }

}