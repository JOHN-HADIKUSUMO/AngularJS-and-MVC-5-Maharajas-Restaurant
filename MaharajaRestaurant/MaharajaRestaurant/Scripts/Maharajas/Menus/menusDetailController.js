maharajasApp.controller('menusDetailController', function menusDetailController($scope, menusService) {
    var promiseget = menusService.get($scope.id);
    promiseget.then(function (response) {
        $scope.menuitem = response.data;
    }, function (response) {

    });
    $scope.back = function () {
        window.location = $scope.url;
    };
});