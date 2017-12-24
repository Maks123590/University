module App {
	
        export class InnerElem {

        private _element: HTMLDivElement;

        get element(): HTMLDivElement {

            return this._element;
        }


        constructor() {
            this._element = document.createElement("div");
        }

        public addBlock(block: Block, before: Block = null) {

            if (before != null) {
                this._element.insertBefore(block.element, before.element);
            } else {
                this._element.appendChild(block.element);
            }

        }

        public removeBlock(block: Block) {
            this._element.removeChild(block.element);
        }
    }
}