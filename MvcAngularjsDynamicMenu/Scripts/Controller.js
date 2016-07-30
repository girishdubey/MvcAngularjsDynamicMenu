app.controller('menuController', ['$scope', '$http', function ($scope, $http) {
    $scope.SiteMenu = [];

    $http.get('/home/GetSiteMenu').then(function (data) {
        $scope.SiteMenu = data.data;
        console.log($scope.SiteMenu);
    }, function (error) {
        alert(error);
    });

}]);