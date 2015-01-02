maharajasApp.factory('menusService', function ($http) {
    var doFactory = {};

    doFactory.getall = function () {
        return $http.get("/REST/MENUS/GETALL");
    };

    return doFactory;
});