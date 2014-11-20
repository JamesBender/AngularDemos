myApp.factory('Albums', ['$resource', function($resource){
	var baseUrl = 'http://localhost:26882/api/Album/:id';
	return $resource(baseUrl);
}]);
