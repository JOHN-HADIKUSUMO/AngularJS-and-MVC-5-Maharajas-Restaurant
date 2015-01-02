maharajasApp.controller('menusController', function menusController($scope, menusService) {
    $scope.firstname = 'John';
    var promisegetall = menusService.getall();
    promisegetall.then(function (response) {
        $scope.menuslist = response.data;
    }, function (response) {
        alert(response.status);
    });
});