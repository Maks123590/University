(function() {
    
    let button = document.querySelector(".ok");
    let textarea = document.querySelector("#textarea");

    let resultDiv = document.querySelector(".result");


    button.onclick = () => {

        let string = textarea.value;

        let words = string.split(' ');

        for(let i = 0; i < words.length; i++) {
            words[i] = words[i].split('').reverse().join('');
        }


        resultDiv.innerHTML = words.join(' ');
    }
}());