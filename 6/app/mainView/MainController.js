'use strict';

angular.module('myApp.mainView', ['ngRoute', 'ngResource'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/main', {
    templateUrl: 'mainView/main.html',
    controller: 'MainCtrl'
  });
}])

.controller('MainCtrl', ['$scope', 'Albums', '$location', function($scope, Albums, $location) {
	Albums.query(function(data){
		$scope.albums = data;
	});

	$scope.getAlbum = function(id){
		$location.path("/detail/" + id);			
	};
}]);