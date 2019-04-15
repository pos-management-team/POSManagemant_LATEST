app.service("LoginService", ["$http", function ($http) {
    var dataSvc = {
        CheckLogin: CheckLogin,
       // getMenudata: getMenudata
    };
    return dataSvc;    

    function CheckLogin(loginName, password) {
        try {
            var url = '/Login/CheckLogin';
            return $http({
                url: url,
                method: "POST",
                data: { loginName: loginName, password: password }
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
    //function getMenudata() {
    //    try {
    //        var url = '/Login/GetMenudata';
    //        return $http({
    //            url: url,
    //            method: "POST",
    //            data: {}
    //        }).then(function (results) {
    //            return results.data;
    //        }).catch(function (ex) {
    //            throw ex;
    //        });
    //    } catch (ex) {
    //        throw ex;
    //    }
    //}
}
]);
