(function() {

    "use strict";

    let countInput = document.querySelector(".count");
    let div = document.querySelector(".arr");

    let button = document.querySelector(".btn");

    button.onclick = () => {

        let different = 1;
        let doubleCount = 0;

        let count = countInput.value;

        let arr = [];

        arr[0] = prompt("input a[" + 0 + "]");

        div.innerHTML += " " + arr[0];

        for(let i = 1; i < count; i++) {
            arr[i] = prompt("input a[" + i + "]");
    
            if (arr[i] === arr[i-1]) {
                doubleCount++;
            } else {
                different++;
            }

            div.innerHTML += " " + arr[i];
        }
    
        div.innerHTML += "<br/>" + "double count: " + doubleCount + " different count: " + different;

    }

}());