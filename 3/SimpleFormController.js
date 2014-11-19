function FormController($scope){
	$scope.user = {
		FirstName: '',
		LastName: '',
		UserName: '',
		Birthdate: '',
		NumPicked: 1
	};

	$scope.save = function() {
		var firstName = $scope.user.FirstName;
		var lastName = $scope.user.LastName;
		var birthday = $scope.user.Birthdate;

		var message = "User " + firstName + " " + lastName + " with Birthdate " + birthday;
		window.alert(message);
	};

	$scope.oldNumber = $scope.user.NumPicked;

	$scope.numberChanged = function(newValue){
		window.alert("changed from " + $scope.oldNumber + " to " + newValue);
		$scope.oldNumber = newValue;
	}
}