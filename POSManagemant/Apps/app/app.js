﻿var app = angular.module('POSManagement', []);

app.run(function ($rootScope, $templateCache) {
    $rootScope.$on('$routeChangeStart', function (event, next, current) {
        if (typeof (current) !== 'undefined') {
            $templateCache.remove(current.templateUrl);
        }
    });
});
app.factory('Data', function () {
    return { obj: '' };
});