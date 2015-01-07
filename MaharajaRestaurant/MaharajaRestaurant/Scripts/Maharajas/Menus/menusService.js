maharajasApp.factory('menusService', function ($http) {
    var doFactory = {};

    doFactory.get = function (id) {
        return $http.get("/REST/MENUS/GET/" + id);
    };

    doFactory.getall = function (cat) {
        return $http.get("/REST/MENUS/GETALL/" + cat);
    };

    return doFactory;
});