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
    var Header = (function (_super) {
        __extends(Header, _super);
        function Header(height, layoutType, color) {
            var _this = _super.call(this, null, height, layoutType, color) || this;
            _this._h1 = null;
            return _this;
        }
        Object.defineProperty(Header.prototype, "h1", {
            set: function (newH1) {
                if (this._h1 !== null) {
                    this.element.removeChild(this._h1);
                }
                this._h1 = newH1;
                this.setStyle(this._h1);
                if (this._h1 !== null) {
                    this.element.appendChild(this._h1);
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Header.prototype, "h1Text", {
            set: function (text) {
                if (this._h1 !== null) {
                    this._h1.innerText = text;
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Header.prototype, "h1FontSize", {
            set: function (size) {
                if (this._h1 !== null) {
                    this._h1.style.fontSize = size.toString() + "px";
                }
            },
            enumerable: true,
            configurable: true
        });
        Header.prototype.setStyle = function (h1) {
            h1.style.margin = "0";
            h1.style.padding = "0";
            h1.style.textAlign = "center";
        };
        return Header;
    }(App.Block));
    App.Header = Header;
})(App || (App = {}));
//# sourceMappingURL=Header.js.map