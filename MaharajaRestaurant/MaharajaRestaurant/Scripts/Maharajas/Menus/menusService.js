maharajasApp.factory('menusService', function ($http) {
    var doFactory = {};

    doFactory.getall = function (cat) {
        return $http.get("/REST/MENUS/GETALL/" + cat);
    };

    return doFactory;
});