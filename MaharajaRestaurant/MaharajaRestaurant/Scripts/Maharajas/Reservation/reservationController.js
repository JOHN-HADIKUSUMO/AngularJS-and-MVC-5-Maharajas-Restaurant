maharajasApp.controller('reservationController', function reservationController($scope, reservationService) {

    $scope.yourevent = {name:undefined,day:1,month:'January',year:2014,numberofpeople:2, environtment: 0,paymentmethod: 0 };
    $scope.submitclick = function () {
        alert(JSON.stringify($scope.yourevent));
    };
});