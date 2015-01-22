maharajasApp.directive('onRepeatFinish', function ($timeout) {
    return {
        restrict: 'A',
        link: function (scope, elem, attrs) {
            if (scope.$last === true) {
                $timeout(function () {
                    scope.$emit('ngRepeatFinished');
                });
            }
        }
    }
});