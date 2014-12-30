maharajasApp.factory('reservationService', function () {
    return {
        create : function(data)
        {
            $.ajax({
                type: 'POST',
                url: '/REST/RESERVATION/CREATE',
                cache: false,
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(data),
                success: function (d) {
                    bootbox.dialog({
                        message: "Your booking has been submitted. Our staff will call you shortly to confirm.",
                        title: "Informaton",
                        buttons: {
                            close: {
                                label: "Close",
                                className: "btn btn-black",
                                callback: function () {
                                    $('#btnReset').trigger('click');
                                }
                            }
                        }
                    });
                },
                error: function (d) {
                    bootbox.dialog({
                        message: d.responseJSON.Message,
                        title: "Alert",
                        buttons: {
                            close: {
                                label: "Close",
                                className: "btn btn-black",
                                callback: function () {

                                }
                            }
                        }
                    });
                }
            });
        }
    }
});