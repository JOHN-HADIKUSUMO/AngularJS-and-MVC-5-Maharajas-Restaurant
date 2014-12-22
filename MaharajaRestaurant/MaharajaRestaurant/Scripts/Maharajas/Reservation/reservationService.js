maharajasApp.factory('reservationService', function () {
    return {
        create : function(d)
        {
            $.ajax({
                type: 'POST',
                url: '/REST/RESERVATION/CREATE',
                cache: false,
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(d),
                success: function (d) {
                    bootbox.dialog({
                        message: "Your booking has been submitted. Our staff will call you shortly to confirm.",
                        title: "Informaton",
                        buttons: {
                            close: {
                                label: "Close",
                                className: "btn btn-black",
                                callback: function () {

                                }
                            }
                        }
                    });
                },
                error: function (request) {
                    bootbox.dialog({
                        message: "Fail to submit your booking.",
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