
function H0(t){ return 2*t*t*t-3*t*t+1;}
function H1(t){ return -2*t*t*t+3*t*t;}
function H2(t){return t*t*t-2*t*t+t;}
function H3(t){return t*t*t-t*t;}


function H10(t){ return -1*t*t*t+3*t*t-3*t+1;}
function H11(t){ return 3*t*t*t-6*t*t+3*t;}
function H12(t){return -3*t*t*t+3*t*t;}
function H13(t){return t*t*t;}

function N110(t){return (-1*t*t*t+3*t*t-3*t+1)/6;}
function N111(t){return (3*t*t*t - 6*t*t + 4)/6;}
function N112(t){return (-3*t*t*t + 3*t*t + 3*t + 1)/6;}
function N113(t){return (t*t*t)/6;}






function Radio(Nom){
spos=Number(Nom);
}

let u=0;

function getCoords(event){


if(spos==1){
if (u%2==0){
P[n]=[];
P[n][0]=event.offsetX;
P[n][1]=event.offsetY;
drawCircle(P[n][0], P[n][1], 2,"green");
n++;u++;
}else{
Q[z]=[];
Q[z][0]=event.offsetX;
Q[z][1]=event.offsetY;
drawCircle(Q[z][0], Q[z][1], 2,"red");
drawLine(P[n-1][0],P[n-1][1],Q[z][0],Q[z][1]);
z++;u++;
}

}else if(spos==2){
if (u%2==0){
P[n]=[];
P[n][0]=event.offsetX;
P[n][1]=event.offsetY;
drawCircle(P[n][0], P[n][1], 2,"green");
n++;u++;
}else{
P[n]=[];
P[n][0]=event.offsetX;
P[n][1]=event.offsetY;

drawCircle(P[n][0], P[n][1], 2,"red");
drawLine(P[n-1][0],P[n-1][1],P[n][0],P[n][1]);
n++;u++;
}

}else{
P[n]=[];
P[n][0]=event.offsetX;
P[n][1]=event.offsetY;
drawCircle(P[n][0], P[n][1], 2,"green");
if (n>=1) {	drawLine(P[n-1][0],P[n-1][1],P[n][0],P[n][1]);}
n++
}
}



	


function graph() {
    if (spos == 1) {
        context.strokeStyle = "blue";
        context.beginPath(); 
        
        let x_0 = 0;
        let y_0 = 0;
        
        for(var i=0; i<n-1; i++){
            var b=i;
            var x0=P[i][0]; var y0=P[i++][1];
            var x1=P[i][0];var y1=P[i][1];
            console.log(x0+" "+y0+" "+x1+" "+y1);
            i=b;
            var U0=Q[i][0];   var V0=Q[i++][1];
            var U1=Q[i][0]; var V1=Q[i][1];
            i=b;
            var t=0;
            
                while (t<1){
                   var H_0=H0(t);var H_1=H1(t);var H_2=H2(t);var H_3=H3(t);
                    var x=x0*H_0+x1*H_1+U0*H_2+U1*H_3;
                    var y=y0*H_0+y1*H_1+V0*H_2+V1*H_3;
                     context.moveTo(Math.round(x_0),Math.round(y_0));
                    if (t>0||i>0){
                    context.lineTo(Math.round(x),Math.round(y));}
                    x_0=x; y_0=y;
                    t+=step;
                }
            }
                context.lineWidth = 2;				
                context.stroke();
    } else if(spos==2) {
    context.strokeStyle = "blue";
    context.beginPath(); 
    let x_0=P[0][0], y_0=P[0][1];

    for(let i=0; i<n-1; i++){

    let b=i;
    let x0=P[i][0]; let y0=P[i++][1];
    let x1=P[i][0];	let y1=P[i++][1];
    let U0=P[i][0]; let V0=P[i++][1];
    let U1=P[i][0]; let V1=P[i][1];
    let t=0;

        while (t<1){
        let H_10=H10(t);let H_11=H11(t);let H_12=H12(t);let H_13=H13(t);
            let x=x0*H_10+x1*H_11+U0*H_12+U1*H_13;
            let y=y0*H_10+y1*H_11+V0*H_12+V1*H_13;
            context.moveTo(Math.round(x_0),Math.round(y_0));
            if (t>0||i>0){
            context.lineTo(Math.round(x),Math.round(y));}
            x_0=x; y_0=y;
            t+=step;
        }
    }
            context.lineWidth = 2;				
            context.stroke();

    }else{
    context.strokeStyle = "blue";
    context.beginPath(); 
    let i=0;
    let x_0=P[0][0], y_0=P[0][1];
    for(let i=0; i<n-1; i++){
    let t=0;
    let b=i;
    let x0=P[i][0]; let y0=P[i++][1];
    let x1=P[i][0];	let y1=P[i++][1];
    let x2=P[i][0]; let y2=P[i++][1];
    let x3=P[i][0]; let y3=P[i][1];
    i=b;
    while (t<1) {
        let x=x0*N110(t) + x1*N111(t) +x2*N112(t) + x3*N113(t);
            let y=y0*N110(t) +y1*N111(t) +y2*N112(t) + y3*N113(t);
            context.moveTo(Math.round(x_0),Math.round(y_0));
            if (t>0||i>0){
            context.lineTo(Math.round(x),Math.round(y));}
            x_0=x; y_0=y;
            t=t+step;  
        }
    context.lineWidth = 2;				
    context.stroke();
    }
    }
}
