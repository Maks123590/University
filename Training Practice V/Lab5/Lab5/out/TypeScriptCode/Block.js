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
    var Block = (function (_super) {
        __extends(Block, _super);
        function Block(width, height, layoutType, color) {
            if (width === void 0) { width = null; }
            if (height === void 0) { height = null; }
            var _this = _super.call(this) || this;
            _this.layoutType = layoutType;
            if (width != null) {
                _this.width = width;
            }
            if (height != null) {
                _this.height = height;
            }
            _this.color = color;
            return _this;
        }
        Object.defineProperty(Block.prototype, "width", {
            get: function () {
                return this._width;
            },
            set: function (theWidth) {
                this._width = theWidth;
                this.element.style.width = this._width + this._ltypePrefix;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Block.prototype, "height", {
            get: function () {
                return this._height;
            },
            set: function (theHeight) {
                this._height = theHeight;
                this.element.style.height = this._height + this._ltypePrefix;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Block.prototype, "color", {
            get: function () {
                return this._color;
            },
            set: function (newColor) {
                this._color = newColor;
                this.element.style.backgroundColor = this._color;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Block.prototype, "layoutType", {
            get: function () {
                return this._layoutType;
            },
            set: function (newLayoutType) {
                this._layoutType = newLayoutType;
                if (this._layoutType === App.LayoutType.Fixed) {
                    this._ltypePrefix = "px";
                }
                else {
                    this._ltypePrefix = "%";
                }
                this.element.style.width = this._width + this._ltypePrefix;
                this.element.style.height = this._height + this._ltypePrefix;
            },
            enumerable: true,
            configurable: true
        });
        return Block;
    }(App.InnerElem));
    App.Block = Block;
})(App || (App = {}));
//# sourceMappingURL=Block.js.map