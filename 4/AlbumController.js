function ServicesController($scope, $http){
	$scope.album = {
		Name: '',
		Artist: '',
		Year: ''
	};

	$scope.albumToGet = 0;

	var baseUrl = 'http://localhost:26882/api/Album';

	$scope.retrieve = function(id){
		$http.get(baseUrl + "/" + id)
			.success(function(data){
				$scope.album = data;
			})
			.error(function(data, status, headers, config){
				window.alert("didn't work " + status);
			});
	}

	$scope.save = function(){
		$http.post(baseUrl, $scope.album, { params: {} })
			.success(saveSuccess)
			.error(function (data, status){
				window.alert("didn't work! " + status);
			});
	};

	function saveSuccess(data, status) {
		window.alert('worked! ' + status);
	}
}