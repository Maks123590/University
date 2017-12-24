var App;
(function (App) {
    var InnerElem = (function () {
        function InnerElem() {
            this._element = document.createElement("div");
        }
        Object.defineProperty(InnerElem.prototype, "element", {
            get: function () {
                return this._element;
            },
            enumerable: true,
            configurable: true
        });
        InnerElem.prototype.addBlock = function (block, before) {
            if (before === void 0) { before = null; }
            if (before != null) {
                this._element.insertBefore(block.element, before.element);
            }
            else {
                this._element.appendChild(block.element);
            }
        };
        InnerElem.prototype.removeBlock = function (block) {
            this._element.removeChild(block.element);
        };
        return InnerElem;
    }());
    App.InnerElem = InnerElem;
})(App || (App = {}));
//# sourceMappingURL=InnerElem.js.map