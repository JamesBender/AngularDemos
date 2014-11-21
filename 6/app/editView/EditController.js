'use strict';

angular.module('myApp.editView', ['ngRoute', 'ngResource'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/edit/:id', {
    templateUrl: 'editView/edit.html',
    controller: 'EditCtrl'
  });
}])

.controller('EditCtrl',
	['$scope', 'Albums', '$location', '$routeParams', function($scope, Albums, $location, $routeParams) {

	Albums.get({id: $routeParams.id}, function(data){
			$scope.album = data;
			$scope.albumId = data.id;
		});

	$scope.save = function(){
		Albums.update({id: $scope.albumId}, $scope.album);
		$location.path('/main');
	};
	/*$scope.save = function(){
		Albums.save($scope.album, function(){
			$location.path('/main');
		});
	};*/
}]);