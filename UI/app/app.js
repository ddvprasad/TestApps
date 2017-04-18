'use strict';

//
// Here is how to define your module
// has dependent on mobile-angular-ui
//
var app = angular.module('MMMmdle', [
  'ngRoute',
  'mobile-angular-ui',  
  'mobile-angular-ui.gestures'
]);

app.run(function($transform) {
    window.$transform = $transform;
});


app.config(function($routeProvider) {
    $routeProvider.when('/', { templateUrl: 'templates/WorkOrders.html', reloadOnSearch: false });
    $routeProvider.when('/scroll', {templateUrl: 'scroll.html', reloadOnSearch: false});
    $routeProvider.when('/toggle', {templateUrl: 'toggle.html', reloadOnSearch: false});
    $routeProvider.when('/tabs', {templateUrl: 'tabs.html', reloadOnSearch: false});
    $routeProvider.when('/accordion', {templateUrl: 'accordion.html', reloadOnSearch: false});
    $routeProvider.when('/overlay', {templateUrl: 'overlay.html', reloadOnSearch: false});
    $routeProvider.when('/forms', {templateUrl: 'forms.html', reloadOnSearch: false});
    $routeProvider.when('/dropdown', {templateUrl: 'dropdown.html', reloadOnSearch: false});
    $routeProvider.when('/touch', {templateUrl: 'touch.html', reloadOnSearch: false});
    $routeProvider.when('/swipe', {templateUrl: 'swipe.html', reloadOnSearch: false});
    $routeProvider.when('/drag', {templateUrl: 'drag.html', reloadOnSearch: false});
    $routeProvider.when('/drag2', {templateUrl: 'drag2.html', reloadOnSearch: false});
    $routeProvider.when('/carousel', {templateUrl: 'carousel.html', reloadOnSearch: false});
});

app.controller('MMMCtrl', function($rootScope, $scope) {

});