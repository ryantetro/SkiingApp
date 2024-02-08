$(document).ready(function () {
    $('#calculate').click(function () {
        var hours = parseFloat($('#hours').val());
        var rate = parseFloat($('#rate').val());
        if (hours > 0) {
            var total = hours * rate;
            $('#total').val(total.toFixed(2));
        } else {
            alert('Please enter a positive number for hours.');
        }
    });
});
