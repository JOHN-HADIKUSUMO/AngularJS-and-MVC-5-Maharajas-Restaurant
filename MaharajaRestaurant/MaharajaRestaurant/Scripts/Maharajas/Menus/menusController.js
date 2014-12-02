maharajasApp.controller('menusController', function menusController($scope, menusService) {
    $scope.menuslist = menusService.menuslist;
    $scope.add = function (x) {
        alert(x);
    };
    $scope.read = function (x) {
        alert(x);
    };
});