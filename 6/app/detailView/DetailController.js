'use strict';

angular.module('myApp.detailView', ['ngRoute', 'ngResource'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/detail/:id', {
    templateUrl: 'detailView/detail.html',
    controller: 'DetailCtrl'
  });
}])

.controller('DetailCtrl', ['$scope', '$routeParams', 'Albums', function($scope, $routeParams, Albums) {
	Albums.get({id: $routeParams.id}, function(data){
			$scope.currentAlbum = data;
		});
}]);