(function() {

    "use strict";

    let div = document.querySelector(".arr");


    //button.onclick = () => {

        let different = 0;
        let doubleCount = 0;

        let arr = [];

        let lastTemp = "";

        let temp = "";
        
        while(lastTemp != 1000)
         {
            let temp = prompt("enter number");
    
            if (lastTemp === temp) {
                doubleCount++;
            } else {
                different++;
            }

            lastTemp = temp;

            div.innerHTML += " " + temp;
        } 

/*
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
    */

        div.innerHTML += "<br/>" + "double count: " + doubleCount + " different count: " + different;

    //}

}());