'use strict';

angular.module('myApp.createView', ['ngRoute', 'ngResource'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/create', {
    templateUrl: 'createView/create.html',
    controller: 'CreateCtrl'
  });
}])

.controller('CreateCtrl', ['$scope', 'Albums', '$location', function($scope, Albums, $location) {

	$scope.save = function(){
		Albums.save($scope.album, function(){
			$location.path('/main');
		});
	};
}]);