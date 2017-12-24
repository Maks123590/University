var App;
(function (App) {
    window.onload = function () {
        var layoutWidth = document.querySelector("#layout-width");
        var layoutHeight = document.querySelector("#layout-height");
        var layoutType = document.querySelector("#layout-type-select");
        var layoutColor = document.querySelector("#layout-color");
        var headerCheck = document.querySelector("#header-settings-check");
        var headerHeight = document.querySelector("#header-height");
        var headerColor = document.querySelector("#header-color");
        var h1Check = document.querySelector("#h1-check");
        var h1Size = document.querySelector("#h1-size");
        var h1Text = document.querySelector("#h1-text");
        var footerCheck = document.querySelector("#footer-settings-check");
        var footerHeight = document.querySelector("#footer-height");
        var footerColor = document.querySelector("#footer-color");
        var leftSidebarCheck = document.querySelector("#leftsidebar-check");
        var leftSidebarWidth = document.querySelector("#leftsidebar-width");
        var leftSidebarColor = document.querySelector("#leftsidebar-color");
        var rightSidebarCheck = document.querySelector("#rightsidebar-check");
        var rightSidebarWidth = document.querySelector("#rightsidebar-width");
        var rightSidebarColor = document.querySelector("#rightsidebar-color");
        var menuCheck = document.querySelector("#menu-settings-check");
        var menuHeight = document.querySelector("#menu-height");
        var menuType = document.querySelector("#menu-type");
        var menuItemsCount = document.querySelector("#menu-items-count");
        var menuColor = document.querySelector("#menu-color");
        var clearButton = document.querySelector(".clear-button");
        var saveButton = document.querySelector(".save-button");
        var el = document.querySelector(".preview-window");
        var layType = layoutType.options.selectedIndex === 0 ? App.LayoutType.Flexible : App.LayoutType.Fixed;
        var menType = menuType.options.selectedIndex === 0 ? App.MenuType.Horizontal : App.MenuType.Vertical;
        var preview = new App.Preview(+layoutWidth.value, +layoutHeight.value, layType, layoutColor.value);
        el.appendChild(preview.element);
        layoutWidth.addEventListener("input", function () {
            preview.width = +layoutWidth.value;
        });
        layoutHeight.addEventListener("input", function () {
            var changeCount = +layoutHeight.value - preview.height;
            preview.height += changeCount;
            preview.main.height += changeCount;
        });
        layoutType.addEventListener("change", function () {
            var type = layoutType.options.selectedIndex === 0 ? App.LayoutType.Flexible : App.LayoutType.Fixed;
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
        headerCheck.addEventListener("change", function () {
            if (headerCheck.checked) {
                preview.header = new App.Header(+headerHeight.value, layType, headerColor.value);
            }
            else {
                preview.header = null;
            }
        });
        headerHeight.addEventListener("input", function () {
            if (headerCheck.checked) {
                var changeCount = Number(headerHeight.value) - preview.header.height;
                preview.header.height += changeCount;
                preview.main.height -= changeCount;
            }
        });
        h1Check.addEventListener("change", function () {
            if (preview.header !== null) {
                if (h1Check.checked) {
                    preview.header.h1 = document.createElement("h1");
                    preview.header.h1Text = h1Text.value;
                    preview.header.h1FontSize = Number(h1Size.value);
                }
                else {
                    preview.header.h1 = null;
                }
            }
        });
        h1Size.addEventListener("input", function () {
            if (preview.header !== null) {
                preview.header.h1FontSize = Number(h1Size.value);
            }
        });
        h1Text.addEventListener("input", function () {
            if (preview.header !== null) {
                preview.header.h1Text = h1Text.value;
            }
        });
        footerCheck.addEventListener("change", function () {
            if (footerCheck.checked) {
                preview.footer = new App.Footer(+footerHeight.value, layType, footerColor.value);
            }
            else {
                preview.footer = null;
            }
        });
        footerHeight.addEventListener("input", function () {
            if (footerCheck.checked) {
                var changeCount = Number(footerHeight.value) - preview.footer.height;
                preview.footer.height += changeCount;
                preview.main.height -= changeCount;
            }
        });
        leftSidebarCheck.addEventListener("change", function () {
            if (leftSidebarCheck.checked) {
                preview.main.leftSidebar = new App.Block(+leftSidebarWidth.value, null, layType, leftSidebarColor.value);
            }
            else {
                preview.main.leftSidebar = null;
            }
        });
        leftSidebarWidth.addEventListener("input", function () {
            if (leftSidebarCheck.checked) {
                var changeCount = Number(leftSidebarWidth.value) - preview.main.leftSidebar.width;
                preview.main.leftSidebar.width += changeCount;
                preview.main._contentBlock.width -= changeCount;
            }
        });
        rightSidebarCheck.addEventListener("change", function () {
            if (rightSidebarCheck.checked) {
                preview.main.rightSidebar = new App.Block(+rightSidebarWidth.value, null, layType, rightSidebarColor.value);
            }
            else {
                preview.main.rightSidebar = null;
            }
        });
        rightSidebarWidth.addEventListener("input", function () {
            if (rightSidebarCheck.checked) {
                var changeCount = Number(rightSidebarWidth.value) - preview.main.rightSidebar.width;
                preview.main.rightSidebar.width += changeCount;
                preview.main._contentBlock.width -= changeCount;
            }
        });
        menuCheck.addEventListener("change", function () {
            toogleMenu();
        });
        menuHeight.addEventListener("input", function () {
            if (menuCheck.checked) {
                var changeCount = Number(menuHeight.value) - preview.menu.width;
                preview.menu.width += changeCount;
                preview.main.height -= changeCount;
            }
        });
        menuType.addEventListener("change", function () {
            menType = menuType.options.selectedIndex === 0 ? App.MenuType.Horizontal : App.MenuType.Vertical;
            //toogleMenu();
        });
        saveButton.addEventListener("click", function () {
            var inner = encodeURIComponent(preview.element.outerHTML);
            var text = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Document</title>\r\n    <style>\r\n       html, body { margin: 0; padding: 0; width: 100%; height: 100%; }\r\n    </style>\r\n</head>\r\n<body>\r\n  " + inner + "  \r\n</body>\r\n</html>";
            var data = "data:text/plain;charset=utf-8,%EF%BB%BF" + text;
            saveButton.href = data;
            saveButton.target = "_blank";
            saveButton.download = "Index.html";
        });
        clearButton.addEventListener("click", function () {
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
            preview = new App.Preview(+layoutWidth.value, +layoutHeight.value, layType, layoutColor.value);
            el.appendChild(preview.element);
        });
        function toogleMenu() {
            if (menuCheck.checked) {
                if (menType === App.MenuType.Horizontal) {
                    preview.menu = new App.Menu(+layoutWidth.value, +menuHeight.value, layType, menType, +menuItemsCount.value, menuColor.value);
                }
                else {
                    preview.main.leftSidebar = null;
                    preview.main.leftSidebar = new App.Menu(+menuHeight.value, +layoutHeight.value, layType, menType, +menuItemsCount.value, menuColor.value);
                }
            }
            else {
                preview.main.leftSidebar = null;
                preview.menu = null;
                if (leftSidebarCheck.checked) {
                    preview.main.leftSidebar = new App.Block(+leftSidebarWidth.value, null, layType, leftSidebarColor.value);
                }
            }
        }
    };
})(App || (App = {}));
//# sourceMappingURL=app.js.map