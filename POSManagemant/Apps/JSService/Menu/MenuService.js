app.service("MenuService", ["$http", function ($http) {
    var dataSvc = {
        getMenulist: getMenulist
    };
    return dataSvc;
    function getMenulist() {
        try {
            var url = '/Menus/GetMenulist';
            return $http({
                url: url,
                method: "POST",
                data: {}
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
}])