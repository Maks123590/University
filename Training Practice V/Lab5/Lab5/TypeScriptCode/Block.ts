module App {
    export class Block extends InnerElem {

        private _layoutType: LayoutType;
        private _ltypePrefix: string;

        private _width: number;
        private _height: number;
        private _color: string;

        get width(): number {

            return this._width;
        }
        set width(theWidth: number) {

            this._width = theWidth;
            this.element.style.width = this._width + this._ltypePrefix;
        }

        get height(): number {

            return this._height;
        }
        set height(theHeight: number) {

            this._height = theHeight;
            this.element.style.height = this._height + this._ltypePrefix;
        }

        get color(): string {

            return this._color;
        }
        set color(newColor: string) {

            this._color = newColor;
            this.element.style.backgroundColor = this._color;
        }

        get layoutType(): LayoutType {

            return this._layoutType;
        }
        set layoutType(newLayoutType: LayoutType) {
            
            this._layoutType = newLayoutType;

            if (this._layoutType === LayoutType.Fixed) {
                this._ltypePrefix = "px";
            } else {
                this._ltypePrefix = "%";
            }

            this.element.style.width = this._width + this._ltypePrefix;
            this.element.style.height = this._height + this._ltypePrefix;
        }

        constructor(width: number = null, height: number = null, layoutType: LayoutType, color : string) {

            super();

            this.layoutType = layoutType;

            if (width != null) {
                this.width = width;
            }

            if (height != null) {
                this.height = height;
            }

            this.color = color;
        }
    }
}