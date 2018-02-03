(function() {

    let images = document.querySelectorAll(".img");

    for(let i = 0; i < images.length; i++) {
        images[i].addEventListener("click", () => {
            alert("src = " + images[i].getAttribute("src"));
        })
    }

}());