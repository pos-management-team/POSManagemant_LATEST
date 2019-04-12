app.controller("LoginController", ["$scope", "LoginService", "$location",
    function ($scope, LoginService, $location) { //$location,
        $scope.obj = {};
       
        function login(l, p) {
            var loginData = LoginService.CheckLogin(l, p);
            loginData.then(function (data) {
                var newDataJSON = JSON.parse(data);
                if (newDataJSON.length === 0) {
                    var msg =  "Invalid Id or Password";
                    alert(msg);                    

                } else {
                    var a = $location.absUrl().split('/')[2].split('?')[0];
                    window.location.href = "http://" + a + "/Menu/Menu";
                }

            });
        }

        
        $scope.login = function (l, p) {
            login(l, p);
        }


    }]);