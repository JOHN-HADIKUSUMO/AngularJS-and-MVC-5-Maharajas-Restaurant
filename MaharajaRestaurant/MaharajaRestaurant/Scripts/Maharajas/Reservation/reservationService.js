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
                    alert('a');
                },
                error: function (request) {
                    alert('elor');
                }
            });
        }
    }
});