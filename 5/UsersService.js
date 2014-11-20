myApp.factory('Users', ['$resource', function($resource){
	var baseUrl = 'http://localhost:26882/api/Person/:id';
	return $resource(baseUrl);
}]);
