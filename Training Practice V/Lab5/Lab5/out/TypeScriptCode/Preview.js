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
    var Preview = (function (_super) {
        __extends(Preview, _super);
        function Preview(width, height, layoutType, color) {
            var _this = _super.call(this, width, height, layoutType, color) || this;
            _this._header = null;
            _this._footer = null;
            _this._menu = null;
            _this._main = new App.Main(width, height, layoutType, color);
            _this.addBlock(_this._main);
            return _this;
        }
        Object.defineProperty(Preview.prototype, "header", {
            get: function () {
                return this._header;
            },
            set: function (newHeader) {
                if (this._header !== null) {
                    this.removeBlock(this._header);
                }
                if (newHeader !== null) {
                    this._header = newHeader;
                    if (this.menu !== null) {
                        this.addBlock(this._header, this.menu);
                    }
                    else {
                        this.addBlock(this._header, this._main);
                    }
                    this.main.height -= this._header.height;
                }
                else {
                    this.main.height += this._header.height;
                    this._header = null;
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Preview.prototype, "footer", {
            get: function () {
                return this._footer;
            },
            set: function (newFooter) {
                if (this._footer !== null) {
                    this.removeBlock(this._footer);
                }
                if (newFooter !== null) {
                    this._footer = newFooter;
                    this.addBlock(this._footer);
                    this.main.height -= this._footer.height;
                    this._main.footerHeight = this._footer.height;
                }
                else {
                    this.main.footerHeight = 0;
                    this.main.height += this._footer.height;
                    this._footer = null;
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Preview.prototype, "menu", {
            get: function () {
                return this._menu;
            },
            set: function (newMenu) {
                if (this._menu !== null) {
                    this.removeBlock(this._menu);
                }
                if (newMenu !== null) {
                    this._menu = newMenu;
                    this.addBlock(this._menu, this._main);
                    this.main.height -= this._menu.height;
                }
                else if (this._menu !== null) {
                    this.main.height += this._menu.height;
                    this._menu = null;
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Preview.prototype, "main", {
            get: function () {
                return this._main;
            },
            enumerable: true,
            configurable: true
        });
        return Preview;
    }(App.Block));
    App.Preview = Preview;
})(App || (App = {}));
//# sourceMappingURL=Preview.js.map