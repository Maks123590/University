(function() {

    "use ctrict";

    let n = prompt("input n");

    let count = 0;

    for(let number = 1000; number < 10000; number++) {
        
        let temp = 0;

        tempNumber = number.toString();

        for(let j = 0; j < tempNumber.length; j++) {
            temp += parseInt(tempNumber[j]);
        }

        if (temp < n) {
            count++;
        }
    }

    if (count > 0) {
        alert(count);
    } else {
        alert("нет!");
    }

}());