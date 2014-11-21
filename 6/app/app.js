'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
  'ngRoute',
  'ngResource',
  'myApp.mainView',
  'myApp.detailView',
  'myApp.createView',
  'myApp.editView',
  'myApp.version',
  'albumService'
]).
config(['$routeProvider', function($routeProvider) {
  $routeProvider.otherwise({redirectTo: '/main'});
}]);
