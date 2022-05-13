function compareBrandIds() {
    var modelBrandId = parseInt($('#model').find(':selected').data('brand'));
    var brandId = parseInt($('#brand').find(':selected').val());

    if (modelBrandId !== brandId) {
        $('#submitButton').prop('disabled', true);
        $('#modelErrorMessage').empty().append("This model doesn't belong to the selected brand");
        $('#modelErrorMessage').addClass("alert alert-danger");
    } else {
        $('#submitButton').prop('disabled', false);
        $('#modelErrorMessage').removeClass("alert alert-danger");
        $('#modelErrorMessage').empty();
    }
}