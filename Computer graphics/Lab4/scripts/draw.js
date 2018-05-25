function II(x,x1,x2,I1,I2){ return I1 + (I2-I1)*(x-x1)/(x2-x1); }

function JJ(y,y1,y2,J1,J2){ return J1 + (J2-J1)*(y-y1)/(y2-y1); }

function drawAxes(context) {
    context.beginPath();
    context.lineWidth = 2;
    context.strokeStyle = "#000";
    context.moveTo(II(x1,x1,x2,I1,I2), JJ(0,y1,y2,J1,J2));
    context.lineTo(II(x2,x1,x2,I1,I2), JJ(0,y1,y2,J1,J2));
    context.moveTo(II(0,x1,x2,I1,I2), JJ(y1,y1,y2,J1,J2));
    context.lineTo(II(0,x1,x2,I1,I2), JJ(y2,y1,y2,J1,J2));

    context.closePath();
    context.stroke();
}

function coordLines(context) {
    context.strokeStyle = "#000";

    for (let x = -rr; x < rr+1; x += rr/10) {
        //context.strokeStyle = "red";
        context.moveTo(II(x1,x1,x2,I1,I2), JJ(x,y1,y2,J1,J2));
        context.lineTo(II(x2,x1,x2,I1,I2), JJ(x,y1,y2,J1,J2));
    }

    for (let y = -rr; y < rr+1; y += rr/10) {
        //context.strokeStyle = "red";
        context.moveTo(II(y,x1,x2,I1,I2), JJ(y1,y1,y2,J1,J2));
        context.lineTo(II(y,x1,x2,I1,I2), JJ(y2,y1,y2,J1,J2));
    }

    context.stroke();
}

function Draw(){

    context.beginPath(); 
    context.fillStyle='#F0F8FF';
    
    context.clearRect(0,0,canvas.width, canvas.height);
    context.fillRect(0,0,canvas.width,canvas.height);
    
    context.strokeStyle = "navy";
    context.strokeRect(0,0,canvas.width, canvas.height);
    
    context.closePath(); 
    context.stroke();

    context.lineWidth = 0.55;

    //координатная сетка:
    coordLines(context)

    //оси координат:
    drawAxes(context);
}

function Delete(){
    context.clearRect(0, 0, 700, 700);
    n=0;
    Draw();
    P=[];
    Q=[];
    u=0;
}

function drawCircle(x, y, radius,color){
    context.beginPath();  
    context.arc(x, y, radius, 0, Math.PI*2, false);  
    context.strokeStyle = color;
    context.closePath();  
    context.fillStyle = color;
context.fill(); 
    context.stroke();
}



    function drawLine(x1, y1, x2, y2) {
context.strokeStyle = "green";
    context.beginPath();   
    context.moveTo( x1, y1 );
    context.lineTo( x2, y2);
    context.lineWidth = 1;				
    context.stroke();
}

