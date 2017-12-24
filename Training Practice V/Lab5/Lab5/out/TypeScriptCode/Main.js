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
    var Main = (function (_super) {
        __extends(Main, _super);
        function Main(width, height, layoutType, color, footerHeight) {
            if (footerHeight === void 0) { footerHeight = 0; }
            var _this = _super.call(this, null, height, layoutType, color) || this;
            _this._leftSidebar = null;
            _this._rightSidebar = null;
            _this._contentBlock = null;
            _this._contentBlock = new App.Block(width, height, layoutType, color);
            _this.addBlock(_this._contentBlock);
            _this.footerHeight = footerHeight;
            _this.color = color;
            _this.element.style.marginTop = "-" + _this.footerHeight;
            _this.element.style.display = "flex";
            _this.element.style.overflow = "hidden";
            return _this;
        }
        Object.defineProperty(Main.prototype, "leftSidebar", {
            get: function () {
                return this._leftSidebar;
            },
            set: function (newSidebar) {
                if (newSidebar !== null) {
                    this._leftSidebar = newSidebar;
                    this.addBlock(this._leftSidebar, this._contentBlock);
                    this._contentBlock.width -= this.leftSidebar.width;
                }
                else {
                    if (this.leftSidebar !== null && this.leftSidebar !== undefined) {
                        this._contentBlock.width += this.leftSidebar.width;
                        this.removeBlock(this._leftSidebar);
                        this._leftSidebar = null;
                    }
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Main.prototype, "rightSidebar", {
            get: function () {
                return this._rightSidebar;
            },
            set: function (newSidebar) {
                if (newSidebar !== null) {
                    this._rightSidebar = newSidebar;
                    this.addBlock(this._rightSidebar);
                    this._contentBlock.width -= this.rightSidebar.width;
                }
                else {
                    this._contentBlock.width += this.rightSidebar.width;
                    this.removeBlock(this._rightSidebar);
                }
            },
            enumerable: true,
            configurable: true
        });
        return Main;
    }(App.Block));
    App.Main = Main;
})(App || (App = {}));
//# sourceMappingURL=Main.js.map