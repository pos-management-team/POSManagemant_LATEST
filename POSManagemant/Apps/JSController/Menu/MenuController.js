app.controller("MenuController", ["$scope", "MenuService", "$location",
    function ($scope, MenuService, $location) { //$location,
        // $scope.obj = {};
        $scope.setup = false;
        var menu = MenuService.getMenulist();
        menu.then(function (data) {
            $scope.menulist = data;
        });
        $scope.Setup_Click = function () {
            $scope.setup = true;
        };

        //function login(l, p) {
        //    var loginData = LoginService.CheckLogin(l, p);
        //    loginData.then(function (data) {
        //        var newDataJSON = JSON.parse(data);
        //        if (newDataJSON.length === 0) {
        //            var msg = "Invalid Id or Password";
        //            alert(msg);

        //        } else {
        //            var a = $location.absUrl().split('/')[2].split('?')[0];
        //            window.location.href = "http://" + a + "/Menu/Index";
        //        }

        //    });
        //}


        //$scope.login = function (l, p) {
        //    login(l, p);
        //}


    }]);