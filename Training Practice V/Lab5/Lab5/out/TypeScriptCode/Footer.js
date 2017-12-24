var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var App;
(function (App) {
    var Footer = (function (_super) {
        __extends(Footer, _super);
        function Footer(height, layoutType, color) {
            var _this = _super.call(this, null, height, layoutType, color) || this;
            _this.element.style.marginTop = "-" + _this.height;
            return _this;
        }
        return Footer;
    }(App.Block));
    App.Footer = Footer;
})(App || (App = {}));
//# sourceMappingURL=Footer.js.map