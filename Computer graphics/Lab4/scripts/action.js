let spos;

let n=0;
let z=0;

let P=[];
let Q=[];

let step=0.01;


let rr = 50;
let test = document.getElementById('form');
let canvas = document.getElementById("canvas");
let context = canvas.getContext('2d');


let I1 = 3; let J1 = 3;
let I2 = canvas.width-3;
let J2 = canvas.height-3;


let x0 = 0;
let y0 = 0;

x1=x0-rr-1;
y1=y0+rr+1;

x2=x0+rr+1;
y2=y0-rr-1;


Draw();
