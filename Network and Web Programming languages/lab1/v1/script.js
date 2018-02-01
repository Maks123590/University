(function() {
    "use strict";

    let aTextArea = document.querySelector("#a");
    let bTextArea = document.querySelector("#b");
    let cTextArea = document.querySelector("#c");
    let resultBlock = document.querySelector(".resultBlock");
    let resultSpan = document.querySelector(".result");
    let okButton = document.querySelector("#ok");


    okButton.onclick = () => {

        let a = aTextArea.value;
        let b = bTextArea.value;
        let c = cTextArea.value;

        let result = ((b + Math.sqrt(b*b + 4*a*c))/(2*a)) - Math.pow(a,3) * c + Math.pow(b, -1);
    
        resultBlock.style.display = "block";
        resultSpan.innerHTML = result;
    };

}());