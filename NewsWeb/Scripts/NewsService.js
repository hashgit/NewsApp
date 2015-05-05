var myApp = angular.module('app', ['ngSanitize']);

myApp.factory('NewsService', [
    '$http', function ($http) {
        return {
            GetNews: function () {
                return $http.get("http://localhost:8091/api/category/");
            },
            GetNewsContent: function(cid, nid) {
                return $http.get("http://localhost:8091/api/category/" + cid + "/news/" + nid);
            }
        }
    }
]);