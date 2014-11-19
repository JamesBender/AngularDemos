function ServicesController($scope, $http){
	$scope.user = {
		FirstName: '',
		LastName: '',
		UserName: ''
	};

	$scope.userToGet = 0;

	var baseUrl = 'http://localhost:26882//api/Person';

	$scope.retrieve = function(id){
		$http.get(baseUrl + "/" + id)
			.success(function(data){
				$scope.user = data;
			})
			.error(function(data, status, headers, config){
				window.alert("didn't work " + status);
			})
	}

	$scope.save = function(){
		$http.post(baseUrl, $scope.user, { params: {} })
			.success(saveSuccess)
			.error(function (data, status){
				window.alert("didn't work! " + status);
			});
	};

	function saveSuccess(data, status) {
		window.alert('worked! ' + status);
	}
}