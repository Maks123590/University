(function() {
    let wrapper = document.querySelector('.wrapper');
    let fastButton = document.querySelector('.high');
    let slowButton = document.querySelector('.low');
    
    let slideWidth = 830;
    let speed = 3;
    let clideCount = 7;
    
    fastButton.onclick = function() {
        speed++;
    }
    
    
    slowButton.onclick = function() {
        speed--;
    }
    
    offset = -slideWidth * clideCount;
    
    let timer = setInterval(function() {
        wrapper.style.marginLeft = offset + 'px';
        
        offset += speed;
    
        if (offset > 0) {
            offset = -slideWidth * clideCount;
        }
    
        if (offset < -slideWidth * clideCount) {
            offset = 0;
        }
    }, 4);
}());

