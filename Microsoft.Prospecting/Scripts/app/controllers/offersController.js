

var app = angular.module('prospectApp', ['ngAnimate']);

app.filter('unique', function () {
    return function (items, filterOn) {

        if (filterOn === false) {
            return items;
        }

        if ((filterOn || angular.isUndefined(filterOn)) && angular.isArray(items)) {
            var hashCheck = {}, newItems = [];

            var extractValueToCompare = function (item) {
                if (angular.isObject(item) && angular.isString(filterOn)) {
                    return item[filterOn];
                } else {
                    return item;
                }
            };

            angular.forEach(items, function (item) {
                var valueToCheck, isDuplicate = false;

                for (var i = 0; i < newItems.length; i++) {
                    if (angular.equals(extractValueToCompare(newItems[i]), extractValueToCompare(item))) {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) {
                    newItems.push(item);
                }

            });
            items = newItems;
        }
        return items;
    };
});

app.factory('offersService', ['$http', '$q', function ($http, $q) {
    var endpoint = '/Microsoft.Prospecting/api/Offers/';
    var service = {};
    service.queryOffers = function (id) {
        var deferred = $q.defer();
        $http.get(endpoint + id)
        .success(function (data) {
            deferred.resolve(data);
        }).error(function () {
            deferred.reject('There was an error.');
        });
        return deferred.promise;
    }

    service.getAllOffers = function () {
        var deferred = $q.defer();
        $http.get(endpoint)
        .success(function (data) {
            deferred.resolve(data);
        }).error(function () {
            deferred.reject('There was an error.');
        });
        return deferred.promise;
    }
    return service;    
}]);

app.controller('offersController', ['$scope', '$http', 'offersService', function offersController($scope, $http, offersService) {    
    offersService.getAllOffers().then(function (data) {
        $scope.offers = data;
    });

    $scope.queryOffers = function (txtQuery) {
        offersService.queryOffers(txtQuery).then(function (data) {            
            $scope.offers = data;
        }, function (data) {
            alert(data);
        });
    }

    
}]);







