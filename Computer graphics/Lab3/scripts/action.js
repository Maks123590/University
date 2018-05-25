let zoom = 15;
let w1 = 0; 
let w2 = 0;
let exx = 0;

Draw();

Canvas.addEventListener("wheel", onWheel);
function onWheel(e) {
    e = e || window.event;
    
    let delta = e.deltaY || e.detail || e.wheelDelta;
    
    zoom += (-delta > 0 && zoom > 1) ? -1 : 1;
    
    Draw();
}

let touch = false;

function activate() {
    touch =! touch;
}

Canvas.addEventListener("mousemove", function(e){
    if(touch) {
        w1 -= e.movementX;
        w2 -= e.movementY;
        Draw();
    }
});