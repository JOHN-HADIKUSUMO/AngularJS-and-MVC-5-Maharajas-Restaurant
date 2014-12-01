maharajasApp.controller('slidersController', function slidersController($scope, slidersService) {
    $scope.sliderslist = slidersService.sliderslist;
});