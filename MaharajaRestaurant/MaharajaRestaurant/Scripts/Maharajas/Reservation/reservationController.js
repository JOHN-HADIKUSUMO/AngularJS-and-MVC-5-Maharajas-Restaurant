maharajasApp.controller('reservationController', function reservationController($scope, reservationService) {
    $scope.booking = {
        yourdetail: { title: undefined, firstname: undefined, lastname: undefined, email: undefined, mobile: undefined, firsttimecustomer: 0, password: undefined, conpassword: undefined },
        yourevent: { name: undefined, day: 1, month: 1, year: 2014, numberofpeople: '1-5', environtment: 0, paymentmethod: 0 }
    }
    $scope.titleoptions = ['Mr', 'Mrs', 'Ms', 'Sir', 'Madam'];
    $scope.dayoptions = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31];
    $scope.monthoptions = [
        {
            key: 'January',
            value: '1'
        },
        {
            key: 'February',
            value: '2'
        },
        {
            key: 'March',
            value: '3'
        },
        {
            key: 'April',
            value: '4'
        },
        {
            key: 'May',
            value: '5'
        },
        {
            key: 'June',
            value: '6'
        },
        {
            key: 'July',
            value: '7'
        },
        {
            key: 'August',
            value: '8'
        },
        {
            key: 'September',
            value: '9'
        },
        {
            key: 'October',
            value: '10'
        },
        {
            key: 'November',
            value: '11'
        },
        {
            key: 'December',
            value: '12'
        }
    ];
    $scope.yearoptions = [2014, 2015];
    $scope.numberofpeopleoptions = ['1-5','5-10','10-20','20-40'];
    $scope.submitclick = function () {
        alert(JSON.stringify($scope.booking));
        //$scope.removeallerror();

        //if ($.trim($scope.yourdetail.firstname) == '')
        //{
        //    var fn = $('#firstname');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('Firstname must be provided.');
        //}
        //else if ($.trim($scope.yourdetail.lastname) == '') {
        //    var fn = $('#lastname');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('Lastname must be provided.');
        //}
        //else if ($.trim($scope.yourdetail.email) == '') {
        //    var fn = $('#email');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('email must be provided.');
        //}
        //else if ($.trim($scope.yourdetail.firsttimecustomer) == '1' && $.trim($('#password').val()) == '') {
        //    var fn = $('#password');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('password must be provided.');
        //}
        //else if ($.trim($scope.yourdetail.firsttimecustomer) == '1' && $.trim($('#conpassword').val()) == '') {
        //    var fn = $('#conpassword');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('confirming password must be provided.');
        //}
        //else if ($.trim($scope.yourdetail.firsttimecustomer) == '1' && ($.trim($('#password').val()) != $.trim($('#conpassword').val()))) {
        //    var fn = $('#conpassword');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('password and confirming password must be the same.');
        //}
        //else if ($.trim($scope.yourevent.name) == '') {
        //    var fn = $('#eventname');
        //    fn.parent().addClass('has-error')
        //    fn.next().removeClass('sr-only');
        //    fn.next().html('event name must be provided.');
        //}
        //else
        //{
        //    alert('submit');
        //}


    };
    $scope.removeallerror = function () {
        var str = 'firstname,lastname,email,password,conpassword,eventname';
        var item = str.split(',');
        for (var i = 0; i < item.length; i++) {
            $scope.removeerror(item[i]);
        };
    };
    $scope.removeerror = function (str) {
        var fn = $('#' + str);
        fn.parent().removeClass('has-error')
        fn.next().addClass('sr-only');
        fn.next().html('');
    };
});