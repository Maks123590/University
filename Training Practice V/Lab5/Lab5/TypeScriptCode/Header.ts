module App {

    export class Header extends Block {

        private _h1: HTMLHeadingElement = null;

        set h1(newH1: HTMLHeadingElement) {

            if (this._h1 !== null) {
                this.element.removeChild(this._h1);
            }

            this._h1 = newH1;

            this.setStyle(this._h1);

            if (this._h1 !== null) {
                this.element.appendChild(this._h1);
            }
        }

        set h1Text(text: string) {
            if (this._h1 !== null) {
                this._h1.innerText = text;
            }
        }

        set h1FontSize(size: number) {
            if (this._h1 !== null) {
                this._h1.style.fontSize = size.toString() + "px";
            }
        }

        constructor(height: number, layoutType: LayoutType, color : string) {

            super(null, height, layoutType, color);
        }

        private setStyle(h1: HTMLElement) {
            h1.style.margin = "0";
            h1.style.padding = "0";
            h1.style.textAlign = "center";
        }
    }
}