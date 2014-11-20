'use strict';

angular.module('myApp.mainView', ['ngRoute', 'ngResource'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/main', {
    templateUrl: 'mainView/main.html',
    controller: 'MainCtrl'
  });
}])

.controller('MainCtrl', ['$scope', 'Albums', function($scope, Albums) {
	Albums.query(function(data){
		$scope.albums = data;
	});

	$scope.getAlbum = function(id){
		Albums.get({id: id}, function(data){
			$scope.currentAlbum = data;
			window.alert ('id is ' + data.Id);
		});
	};
}]);