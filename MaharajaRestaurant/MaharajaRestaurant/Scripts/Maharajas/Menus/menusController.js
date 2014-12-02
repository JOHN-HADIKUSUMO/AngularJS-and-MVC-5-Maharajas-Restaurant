maharajasApp.controller('menusController', function menusController($scope, menusService) {
    $scope.menuslist = menusService.menuslist;
});