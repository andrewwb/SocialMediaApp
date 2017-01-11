var SocialMediaApp;
(function (SocialMediaApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('api/guidebox').then(function (res) {
                    _this.movies = res.data;
                    console.log(_this.movies);
                });
            }
            return HomeController;
        }());
        Controllers.HomeController = HomeController;
    })(Controllers = SocialMediaApp.Controllers || (SocialMediaApp.Controllers = {}));
})(SocialMediaApp || (SocialMediaApp = {}));
//# sourceMappingURL=homeController.js.map