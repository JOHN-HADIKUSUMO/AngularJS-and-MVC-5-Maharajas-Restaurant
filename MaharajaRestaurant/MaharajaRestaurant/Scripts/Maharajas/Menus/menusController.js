maharajasApp.controller('menusController', function menusController($scope, menusService) {
    var promisegetall = menusService.getall($scope.category);
    promisegetall.then(function (response) {
        $scope.menuslist = response.data;
    }, function (response) {
        bootbox.dialog({
            message: response.data.Message,
            title: "Error",
            buttons: {
                close: {
                    label: "Close",
                    className: "btn btn-black",
                    callback: function () {
                        
                    }
                }
            }
        });
    });
    $scope.add = function (d) {
        alert(d);
    };
    $scope.hasrecord = true;
    $scope.$watch('menuslist', function () {
        $scope.hasrecord = $scope.menuslist.length > 0;
    });
});