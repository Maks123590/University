(function() {
    "use strict";

    let resultBlock = document.querySelector(".resultBlock");
    let resultSpan = document.querySelector(".result");


    let a = prompt("input a");
    let b = prompt("input b");
    let c = prompt("input c");

    let result = ((b + Math.sqrt(b*b + 4*a*c))/(2*a)) - Math.pow(a,3) * c + Math.pow(b, -1);

    resultBlock.style.display = "block";
    resultSpan.innerHTML = result;

}());