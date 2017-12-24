module App {

    export class Footer extends Block {

        constructor(height: number, layoutType: LayoutType, color : string) {

            super(null, height, layoutType, color);

            this.element.style.marginTop = `-${this.height}`;
        }
    }
}