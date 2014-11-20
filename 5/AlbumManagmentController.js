myApp.controller("AlbumManagmentController", function($scope, Albums){

	Albums.query(function(data){
		$scope.albums = data;
	});

	$scope.getAlbum = function(id){
		Albums.get({id: id}, function(data){
			$scope.currentAlbum = data;
		});
	};
});