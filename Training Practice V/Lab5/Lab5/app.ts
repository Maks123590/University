module App {

    window.onload = () => {

        let layoutWidth = document.querySelector("#layout-width") as HTMLInputElement;
        let layoutHeight = document.querySelector("#layout-height") as HTMLInputElement;
        let layoutType = document.querySelector("#layout-type-select") as HTMLSelectElement;
        let layoutColor = document.querySelector("#layout-color") as HTMLInputElement;

        let headerCheck = document.querySelector("#header-settings-check") as HTMLInputElement;
        let headerHeight = document.querySelector("#header-height") as HTMLInputElement;
        let headerColor = document.querySelector("#header-color") as HTMLInputElement;
        let h1Check = document.querySelector("#h1-check") as HTMLInputElement;
        let h1Size = document.querySelector("#h1-size") as HTMLInputElement;
        let h1Text = document.querySelector("#h1-text") as HTMLInputElement;

        let footerCheck = document.querySelector("#footer-settings-check") as HTMLInputElement;
        let footerHeight = document.querySelector("#footer-height") as HTMLInputElement;
        let footerColor = document.querySelector("#footer-color") as HTMLInputElement;

        let leftSidebarCheck = document.querySelector("#leftsidebar-check") as HTMLInputElement;
        let leftSidebarWidth = document.querySelector("#leftsidebar-width") as HTMLInputElement;
        let leftSidebarColor = document.querySelector("#leftsidebar-color") as HTMLInputElement;

        let rightSidebarCheck = document.querySelector("#rightsidebar-check") as HTMLInputElement;
        let rightSidebarWidth = document.querySelector("#rightsidebar-width") as HTMLInputElement;
        let rightSidebarColor = document.querySelector("#rightsidebar-color") as HTMLInputElement;

        let menuCheck = document.querySelector("#menu-settings-check") as HTMLInputElement;
        let menuHeight = document.querySelector("#menu-height") as HTMLInputElement;
        let menuType = document.querySelector("#menu-type") as HTMLSelectElement;
        let menuItemsCount = document.querySelector("#menu-items-count") as HTMLInputElement;
        let menuColor = document.querySelector("#menu-color") as HTMLInputElement;

        let clearButton = document.querySelector(".clear-button") as HTMLInputElement;
        let saveButton = document.querySelector(".save-button") as HTMLAnchorElement;

        const el = document.querySelector(".preview-window");

        let layType = layoutType.options.selectedIndex === 0 ? LayoutType.Flexible : LayoutType.Fixed;

        let menType = menuType.options.selectedIndex === 0 ? MenuType.Horizontal : MenuType.Vertical;

        let preview = new Preview(+layoutWidth.value, +layoutHeight.value, layType, layoutColor.value);

        el.appendChild(preview.element);

        layoutWidth.addEventListener("input", () => {
            preview.width = +layoutWidth.value;
        });
        layoutHeight.addEventListener("input", () => {
            let changeCount = +layoutHeight.value - preview.height; 

            preview.height += changeCount;
            preview.main.height += changeCount;
        });
        layoutType.addEventListener("change", () => {
            let type = layoutType.options.selectedIndex === 0 ? LayoutType.Flexible : LayoutType.Fixed;

            preview.layoutType = type;

            if (preview.header != null)
                preview.header.layoutType = type;
            if (preview.footer != null)
                preview.footer.layoutType = type;

            preview.main.layoutType = type;
            preview.main._contentBlock.layoutType = type;

            if (preview.main.leftSidebar != null)
                preview.main.leftSidebar.layoutType = type;
            if (preview.main.rightSidebar != null)
                preview.main.rightSidebar.layoutType = type;

            layType = type;
        });

        headerCheck.addEventListener("change", () => {
                if (headerCheck.checked) {
                    preview.header = new Header(+headerHeight.value, layType, headerColor.value);
                } else {
                    preview.header = null;
                }
            });
        headerHeight.addEventListener("input", () => {
            if (headerCheck.checked) {
                let changeCount = Number(headerHeight.value) - preview.header.height;

                preview.header.height += changeCount;
                preview.main.height -= changeCount;
            }
        });

        h1Check.addEventListener("change", () => {
            if (preview.header !== null) {

                if (h1Check.checked) {
                    preview.header.h1 = document.createElement("h1");
                    preview.header.h1Text = h1Text.value;
                    preview.header.h1FontSize = Number(h1Size.value);
                } else {
                    preview.header.h1 = null;
                }
            }
        });
        h1Size.addEventListener("input", () => {
            if (preview.header !== null) {
                preview.header.h1FontSize = Number(h1Size.value);
            }
        });
        h1Text.addEventListener("input", () => {
            if (preview.header !== null) {
                preview.header.h1Text = h1Text.value;
            }
        });

        footerCheck.addEventListener("change", () => {
                if (footerCheck.checked) {
                    preview.footer = new Footer(+footerHeight.value, layType, footerColor.value);
                } else {
                    preview.footer = null;
                }
            });
        footerHeight.addEventListener("input", () => {
            if (footerCheck.checked) {
                let changeCount = Number(footerHeight.value) - preview.footer.height;

                preview.footer.height += changeCount;
                preview.main.height -= changeCount;
            }
        });

        leftSidebarCheck.addEventListener("change", () => {
            if (leftSidebarCheck.checked) {
                preview.main.leftSidebar = new Block(+leftSidebarWidth.value, null, layType, leftSidebarColor.value);
            } else {
                preview.main.leftSidebar = null;
            }
        });
        leftSidebarWidth.addEventListener("input", () => {
            if (leftSidebarCheck.checked) {
                let changeCount = Number(leftSidebarWidth.value) - preview.main.leftSidebar.width;

                preview.main.leftSidebar.width += changeCount;
                preview.main._contentBlock.width -= changeCount;
            }
        });

        rightSidebarCheck.addEventListener("change", () => {
            if (rightSidebarCheck.checked) {
                preview.main.rightSidebar = new Block(+rightSidebarWidth.value, null, layType, rightSidebarColor.value);
            } else {
                preview.main.rightSidebar = null;
            }
        });
        rightSidebarWidth.addEventListener("input", () => {
            if (rightSidebarCheck.checked) {
                let changeCount = Number(rightSidebarWidth.value) - preview.main.rightSidebar.width;

                preview.main.rightSidebar.width += changeCount;
                preview.main._contentBlock.width -= changeCount;
            }
        });

        menuCheck.addEventListener("change", () => {
            toogleMenu();
        });
        menuHeight.addEventListener("input", () => {
            if (menuCheck.checked) {
                let changeCount = Number(menuHeight.value) - preview.menu.width;

                preview.menu.width += changeCount;
                preview.main.height -= changeCount;
            }
        });
        menuType.addEventListener("change", () => {
            menType = menuType.options.selectedIndex === 0 ? MenuType.Horizontal : MenuType.Vertical;

            //toogleMenu();
        });

        saveButton.addEventListener("click", () => {

            let inner = encodeURIComponent(preview.element.outerHTML);

            let text = `<!DOCTYPE html>\r\n<html lang="en">\r\n<head>\r\n    <meta charset="UTF-8">\r\n    <meta name="viewport" content="width=device-width, initial-scale=1.0">\r\n    <meta http-equiv="X-UA-Compatible" content="ie=edge">\r\n    <title>Document</title>\r\n    <style>\r\n       html, body { margin: 0; padding: 0; width: 100%; height: 100%; }\r\n    </style>\r\n</head>\r\n<body>\r\n  ${inner}  \r\n</body>\r\n</html>`;

            let data = `data:text/plain;charset=utf-8,%EF%BB%BF${text}`;

            saveButton.href = data;
            saveButton.target = "_blank";
            saveButton.download = "Index.html";
        });


        clearButton.addEventListener("click", () => {
            layoutType.selectedIndex = 0;
            layoutWidth.value = "100";
            layoutHeight.value = "100";
            layoutColor.value = "#eeeeee";

            headerCheck.checked = false;
            headerHeight.value = "10";
            headerColor.value = "#06799F";

            footerCheck.checked = false;
            footerHeight.value = "10";
            footerColor.value = "#C50080";

            leftSidebarCheck.checked = false;
            leftSidebarWidth.value = "20";
            leftSidebarColor.value = "#C0F400";

            rightSidebarCheck.checked = false;
            rightSidebarWidth.value = "20";
            rightSidebarColor.value = "#C0F400";

            menuCheck.checked = false;
            menuHeight.value = "5";
            menuType.selectedIndex = 0;
            menuItemsCount.value = "5";
            menuColor.value = "#cceedd";

            el.innerHTML = "";

            preview = new Preview(+layoutWidth.value, +layoutHeight.value, layType, layoutColor.value);

            el.appendChild(preview.element);
        });


        function toogleMenu() {
            if (menuCheck.checked) {
                if (menType === MenuType.Horizontal) {
                    preview.menu = new Menu(+layoutWidth.value, +menuHeight.value, layType, menType, +menuItemsCount.value, menuColor.value);
                } else {
                    preview.main.leftSidebar = null;
                    preview.main.leftSidebar = new Menu(+menuHeight.value, +layoutHeight.value, layType, menType, +menuItemsCount.value, menuColor.value);
                }

            } else {

                preview.main.leftSidebar = null;
                preview.menu = null;

                if (leftSidebarCheck.checked) {
                    preview.main.leftSidebar = new Block(+leftSidebarWidth.value, null, layType, leftSidebarColor.value);
                }
            }
        }

    };
}
