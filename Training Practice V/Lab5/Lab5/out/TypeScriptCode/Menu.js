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
    var Menu = (function (_super) {
        __extends(Menu, _super);
        function Menu(width, height, layoutType, menuType, itemsCount, color) {
            var _this = _super.call(this, width, height, layoutType, color) || this;
            _this._itemCount = 0;
            _this._menuList = document.createElement("ul");
            _this.clearStyle(_this._menuList);
            _this._menuList.style.display = "flex";
            _this._menuList.style.justifyContent = "space-around";
            _this._menuList.style.alignItems = "center";
            _this._menuList.style.width = "100%"; // it's a feature :D
            _this.element.appendChild(_this._menuList);
            _this.itemsCount = itemsCount;
            _this.menuType = menuType;
            return _this;
        }
        Object.defineProperty(Menu.prototype, "menuType", {
            get: function () {
                return this._menuType;
            },
            set: function (newType) {
                this._menuType = newType;
                if (this.menuType === App.MenuType.Horizontal) {
                    this._menuList.style.flexDirection = "row";
                }
                else {
                    this._menuList.style.flexDirection = "column";
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Menu.prototype, "itemsCount", {
            get: function () {
                return this._itemCount;
            },
            set: function (newCount) {
                this.addMenuItems(newCount - this.itemsCount);
                this._itemCount = newCount;
            },
            enumerable: true,
            configurable: true
        });
        Menu.prototype.addMenuItems = function (count) {
            if (count > 0) {
                for (var i_1 = 0; i_1 < count; i_1++) {
                    var li = document.createElement("li");
                    this.addRef(li, "item" + Number(this._menuList.childNodes.length + 1));
                    this._menuList.appendChild(li);
                }
            }
            else if (count < 0) {
                for (var i = 0; i < -count; i++) {
                    this._menuList.lastElementChild.remove();
                }
            }
        };
        Menu.prototype.clearStyle = function (li) {
            li.style.margin = "0";
            li.style.padding = "0";
        };
        Menu.prototype.addRef = function (elem, text) {
            var a = document.createElement("a");
            a.setAttribute("href", "#");
            a.innerText = text;
            elem.appendChild(a);
        };
        return Menu;
    }(App.Block));
    App.Menu = Menu;
})(App || (App = {}));
//# sourceMappingURL=Menu.js.map