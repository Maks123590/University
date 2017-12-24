module App {
    export class Preview extends Block {

        private _header: Header = null;
        private _footer: Footer = null;
        private _menu: Menu = null;
        private _main: Main;


        get header(): Header {

            return this._header;
        }
        set header(newHeader: Header) {

            if (this._header !== null) {
                this.removeBlock(this._header);
            }

            if (newHeader !== null) {
                this._header = newHeader;

                if (this.menu !== null) {
                    this.addBlock(this._header, this.menu);
                } else {
                    this.addBlock(this._header, this._main);
                }

                this.main.height -= this._header.height;
            } else {
                this.main.height += this._header.height;
                this._header = null;
            }
        }

        get footer(): Footer {

            return this._footer;
        }
        set footer(newFooter: Footer) {

            if (this._footer !== null) {
                this.removeBlock(this._footer);
            }

            if (newFooter !== null) {
                this._footer = newFooter;
                this.addBlock(this._footer);
                this.main.height -= this._footer.height;
                this._main.footerHeight = this._footer.height;
            } else {
                this.main.footerHeight = 0;
                this.main.height += this._footer.height;
                this._footer = null;
            }
        }


        get menu(): Menu {

            return this._menu;
        }
        set menu(newMenu: Menu) {

            if (this._menu !== null) {
                this.removeBlock(this._menu);
            }

            if (newMenu !== null) {
                this._menu = newMenu;
                this.addBlock(this._menu, this._main);
                this.main.height -= this._menu.height;
            } else if (this._menu !== null){
                this.main.height += this._menu.height;
                this._menu = null;
            }
        }

        get main(): Main {

            return this._main;
        }

        constructor(width: number, height: number, layoutType: LayoutType, color: string) {
            super(width, height, layoutType, color);

            this._main = new Main(width, height, layoutType, color);
            this.addBlock(this._main);
        }
    }
}