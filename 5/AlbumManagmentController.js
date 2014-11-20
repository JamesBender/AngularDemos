myApp.controller("UserRegistrationController", function($scope, Users){

	Users.query(function(data){
		$scope.users = data;
	});

	$scope.getUser = function(id){
		Users.get({id: id}, function(data){
			$scope.currentUser = data;
		});
	};
/*	$http.get(baseUrl).success(function(data){
		$scope.users = data;
	});

	$scope.getUser = function(id){
		$http.get(baseUrl + "/" + id)
			.success(function(data){
				$scope.currentUser = data;
			})
			.error(function(data, status, headers, config){
				window.alert("didn't work " + status);
			});
	};
	*/
});