function NewsCtrl($scope, NewsService) {
    $scope.CategoriesWithSummaries = [];
    $scope.SelectedNews = {};

    NewsService.GetNews().success(function (result) {
        $scope.CategoriesWithSummaries = result;
    });

    $scope.DisplayNews = function (cid, nid) {
        NewsService.GetNewsContent(cid, nid).success(function(result) {
            $("#categoriesSection").hide();
            $scope.SelectedNews = result;
            $("#contentSection").show();
        });
    };

    $scope.GoBack = function() {
        $("#categoriesSection").show();
        $("#contentSection").hide();
    };
}