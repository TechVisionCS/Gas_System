

$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    var redirectUrl = "";
    $('a[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        redirectUrl = $(this).data('redirect');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })

    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            PlaceHolderElement.find('.modal').modal('hide');
        })
        window.location.href = redirectUrl;
    })
});