module App {

    export class Menu extends Block {

        private _menuType: MenuType;
        private _itemCount: number;

        private _menuList: HTMLUListElement;

        get menuType() {
            return this._menuType;
        }
        set menuType(newType: MenuType) {

            this._menuType = newType;

            if (this.menuType === MenuType.Horizontal) {
                this._menuList.style.flexDirection = "row";
            } else {
                this._menuList.style.flexDirection = "column";
            }
        }

        get itemsCount() {
            return this._itemCount;
        }
        set itemsCount(newCount: number) {

            this.addMenuItems(newCount - this.itemsCount);

            this._itemCount = newCount;
        }

        constructor(width: number, height: number, layoutType: LayoutType, menuType: MenuType, itemsCount: number, color: string) {

            super(width, height, layoutType, color);

            this._itemCount = 0;

            this._menuList = document.createElement("ul");

            this.clearStyle(this._menuList);

            this._menuList.style.display = "flex";
            this._menuList.style.justifyContent = "space-around";
            this._menuList.style.alignItems = "center";
            this._menuList.style.width = "100%";            // it's a feature :D

            this.element.appendChild(this._menuList);

            this.itemsCount = itemsCount;

            this.menuType = menuType;
            
        }

        private addMenuItems(count: number) {
            if (count > 0) {

                for (let i = 0; i < count; i++) {

                    let li = document.createElement("li");

                    this.addRef(li, "item" + Number(this._menuList.childNodes.length + 1));

                    this._menuList.appendChild(li);
                }                
            } else if (count < 0){

                for (var i = 0; i < -count; i++) {
                    this._menuList.lastElementChild.remove();
                }
            }
        }

        private clearStyle(li: HTMLElement) {
            li.style.margin = "0";
            li.style.padding = "0";
        }

        private addRef(elem: HTMLElement, text: string) {

            let a = document.createElement("a");

            a.setAttribute("href","#");

            a.innerText = text;

            elem.appendChild(a);
        }
    }
}