module App {

    export class Main extends Block {

        footerHeight: number;

        _leftSidebar: Block = null;
        _rightSidebar: Block = null;
        _contentBlock: Block = null;

        get leftSidebar(): Block {

            return this._leftSidebar;
        }
        set leftSidebar(newSidebar: Block) {

            if (newSidebar !== null) {
                this._leftSidebar = newSidebar;
                this.addBlock(this._leftSidebar, this._contentBlock);
                this._contentBlock.width -= this.leftSidebar.width;
            } else {

                if (this.leftSidebar !== null && this.leftSidebar !== undefined) {
                    this._contentBlock.width += this.leftSidebar.width;
                    this.removeBlock(this._leftSidebar);
                    this._leftSidebar = null; 
                }
                
                
            }
        }

        get rightSidebar(): Block {

            return this._rightSidebar;
        }
        set rightSidebar(newSidebar: Block) {

            if (newSidebar !== null) {
                this._rightSidebar = newSidebar;
                this.addBlock(this._rightSidebar);
                this._contentBlock.width -= this.rightSidebar.width;
            } else {
                this._contentBlock.width += this.rightSidebar.width;
                this.removeBlock(this._rightSidebar);
            }
        }

        constructor(width : number, height: number, layoutType: LayoutType, color: string, footerHeight: number = 0) {

            super(null, height, layoutType, color);

            this._contentBlock = new Block(width, height, layoutType, color);

            this.addBlock(this._contentBlock);

            this.footerHeight = footerHeight;

            this.color = color;

            this.element.style.marginTop = `-${this.footerHeight}`;

            this.element.style.display = "flex";
            this.element.style.overflow = "hidden";
        }

    }
}