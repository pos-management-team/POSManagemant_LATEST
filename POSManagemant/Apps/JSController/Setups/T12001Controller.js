

app.controller("T12001Controller", ["$scope", "$http", "$window", "T12001Service", "Data",
    function (scope, $http, $window, T12001Service, Data) {
        //for instance   $filter,
        scope.obj = {};
        scope.obj = Data;
        scope.comType = {};
        //scope.Save_Click = function (obj) {
        //    var save = CompanyService.saveData(obj);
        //    save.then(function () {
        //        alert('Save successfully')

        //        var getdata = CompanyService.getGridData();
        //        getdata.then(function (data) {
        //            scope.CompanyList = data;
        //        })

        //    });
        //}
        //var dropdown = CompanyService.getDropdownData()
        //dropdown.then(function (data) {
        //    scope.DropdownList = data;
        //});
        //var getdata = CompanyService.getGridData();
        //getdata.then(function (data) {
        //    scope.CompanyList = data;
        //})
        //scope.setClickedRow = function (index, Z) {

        //    scope.selectedRow = index;
        //    scope.comType.Comp_Type_ID = Z.Comp_Type_ID;
        //    scope.comType.Comp_Type_Name = Z.Comp_Type_Name;
        //    scope.comType.Comp_Type_Code = Z.Comp_Type_Code;
        //}
        //scope.$watch('selectedRow', function () {
        //    console.log('Do Some processing'); //runs the block whenever selectedRow is changed. 
        //});


    }]);
//app.filter('propsFilter', function () {
//    return function (items, props) {
//        var out = [];

//        if (angular.isArray(items)) {
//            var keys = Object.keys(props);

//            items.forEach(function (item) {
//                var itemMatches = false;

//                for (var i = 0; i < keys.length; i++) {
//                    var prop = keys[i];
//                    var text = props[prop].toLowerCase();
//                    if (item[prop].toString().toLowerCase().indexOf(text) !== -1) {
//                        itemMatches = true;
//                        break;
//                    }
//                }

//                if (itemMatches) {
//                    out.push(item);
//                }
//            });
//        } else {
//            // Let the output be the input untouched
//            out = items;
//        }

//        return out;
//    };
//});
//app.directive('arrowSelector', ['$document', function ($document) {
//    return {
//        restrict: 'A',
//        link: function (scope, elem, attrs, ctrl) {
//            var elemFocus = false;
//            elem.on('mouseenter', function () {
//                elemFocus = true;
//            });
//            elem.on('mouseleave', function () {
//                elemFocus = false;
//            });
//            $document.bind('keydown', function (e) {
//                if (elemFocus) {
//                    if (e.keyCode == 38) {
//                        console.log(scope.selectedRow);
//                        if (scope.selectedRow == 0) {
//                            return;
//                        }
//                        scope.selectedRow--;
//                        scope.$apply();
//                        e.preventDefault();
//                    }
//                    if (e.keyCode == 40) {
//                        if (scope.selectedRow == scope.foodItems.length - 1) {
//                            return;
//                        }
//                        scope.selectedRow++;
//                        scope.$apply();
//                        e.preventDefault();
//                    }
//                }
//            });
//        }
//    };
//}]);