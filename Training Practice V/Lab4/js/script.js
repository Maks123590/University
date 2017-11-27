(function() {
    let list = document.querySelector('.list');
    let items = document.querySelectorAll('.item');

    function itemClick(e) {

        if (e.shiftKey) {
            let targerItem = findItemIndex(e.target);
            let closestSelectedItem = findClosestSelected(targerItem);

            clearSelect();

            if (targerItem < closestSelectedItem) {
                selectInterval(targerItem, closestSelectedItem);
            } else {
                selectInterval(closestSelectedItem, targerItem);
            }
            
        } else if (e.ctrlKey) {
            e.target.classList.toggle("selected");
        } else {
            clearSelect();
            e.target.classList.toggle("selected");
        }
    }

    function clearSelect() {
        for (let i = 0; i < items.length; i++) {
            items[i].classList.remove("selected");
        }
    }

    function findClosestSelected(markedIndex) {
        
        let closestLeft = null;
        let closestRight = null;

        for (let i = markedIndex; i < items.length; i++) {
            if (items[i].className === "item selected") {
                closestRight = i;
            }
        }

        for (let i = markedIndex; i >= 0; i--) {
            if (items[i].className === "item selected") {
                closestLeft = i;
            }
        }

        if (closestLeft === null) {
            if (closestRight === null)
            {
                return 0;
            }

            return closestRight;
        }

        if (closestRight === null) {
            return closestLeft;
        }


        if ((markedIndex - closestLeft) > (closestRight - markedIndex)) {
            return closestRight;
        } else {
            return closestLeft;
        }
    }


    function findItemIndex(item) {
        for (let i = 0; i < items.length; i++) {
            if (item === items[i]) {
                return i;
            }
        }
    }

    function selectInterval(begin, end) {
        for (let i = begin; i <= end; i++) {
            items[i].classList.add("selected");
        }
    }

    for (let i = 0; i < items.length; i++) {
        items[i].addEventListener("click", itemClick);
    }
}());