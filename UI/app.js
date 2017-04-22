var app = angular.module('myApp', ['localytics.directives']);

app.controller('MainCtrl', function ($scope, $http) {
    $scope.name = 'Multiple Angular Chosen Example using ngModel and ngOptions';
    $scope.state = [3, 2];

    $scope.selected = 2;

    //Static items
    $scope.states = [
      { id: 1, tite: 'Filler1' },
      { id: 2, title: 'Filler2' },
      { id: 3, title: 'Filler3' },
      { id: 1, tite: 'Filler4' },
      { id: 2, title: 'Filler5' },
      { id: 3, title: 'Filler6' },
      { id: 1, tite: 'Filler7' },
      { id: 2, title: 'Filler8' },
      { id: 3, title: 'Filler9' },
      { id: 1, tite: 'Filler10' },
      { id: 2, title: 'Filler11' },
      { id: 3, title: 'Filler12' },
      { id: 1, tite: 'Filler13' },
      { id: 2, title: 'Filler14' },
      { id: 3, title: 'Filler15' },
      { id: 1, tite: 'Filler16' },
      { id: 2, title: 'Filler17' },
      { id: 3, title: 'Filler18' },
      { id: 4, title: 'Filler19' }
    ];

    ////Remote items
    //$http({
    //    method: 'get',
    //    url: 'http://jsonplaceholder.typicode.com/posts'
    //}).success(function (posts) {
    //    console.log(posts);
    //    $scope.states = posts;
    //});
});