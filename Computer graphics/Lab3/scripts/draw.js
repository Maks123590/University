function clip(x, y, p)
{
    if(x<xwmin)
        p[3] = 1;
        
    if(x>xwmax)
        p[2] = 1;
        
    if(y<ywmin)
        p[1] = 1;
        
    if(y>ywmax)
        p[0] = 1;
}


let Canvas = document.getElementById('canvasId');  
	let context = null;

	let Width = Canvas.width;
	let Height = Canvas.height;

	function MaxX() {
		return zoom;
	}

	function MinX() {
		return -zoom;
	}

	function MaxY() {
		return MaxX() * Height / Width;
	}

	function MinY() {
		return MinX() * Height / Width;
	}

	function DecartToScreenX(x) {
		return (x - MinX()) / (MaxX() - MinX()) * Width - w1;
	}

	function DecartToScreenY(y) {
		return Height - (y - MinY()) / (MaxY() - MinY()) * Height - w2;
	}


	function Draw() {
		if (Canvas.getContext) {
			context = Canvas.getContext('2d');
			
			context.fillStyle = "#F0F8FF";

			context.fillRect(0,0,Width,Height);

			context.fillStyle = "#000";

			context.font="10px Helvetica";
			
			DrawAxes();
			DrawLine();
		}
    }
    
    function XTickDelta() {
		return 1;
	}

	function YTickDelta() {
		return 1;
	}
	
	function DrawAxes(color) 
	{
		context.strokeStyle="#000";
		context.save();
		context.lineWidth = 0.15;
		context.beginPath();
		context.moveTo(DecartToScreenX(0),DecartToScreenY(0));
		context.lineTo(DecartToScreenX(0),DecartToScreenY(MaxY())+w2);
		context.stroke();
		
		let del = Math.floor(zoom / 10);

		context.beginPath();
		context.moveTo(DecartToScreenX(0),DecartToScreenY(0));
		context.lineTo(DecartToScreenX(0),DecartToScreenY(MinY())+w2);
		context.stroke();
		let delta = YTickDelta();
		let tt3 = Math.floor(-w2 / 10);
		tt3 = (tt3 > 0) ? tt3 : 1;
		for (let i = 1; (i * delta) < MaxY()+ tt3; ++i) {
			context.beginPath();
			if(del < 2){
				context.moveTo(DecartToScreenX(0) - Width/2 + w1,DecartToScreenY(i * delta));
				context.lineTo(DecartToScreenX(0) + Width/2 + w1,DecartToScreenY(i * delta));
				context.fillText(i, DecartToScreenX(0)+2,DecartToScreenY(i * delta)-3);
			}else if(del > 1 && i % del == 0){
				context.moveTo(DecartToScreenX(0) - Width/2 + w1,DecartToScreenY(i * delta));
				context.lineTo(DecartToScreenX(0) + Width/2 + w1,DecartToScreenY(i * delta));
				context.fillText(i, DecartToScreenX(0)+2,DecartToScreenY(i * delta)-3);
			}
			context.stroke();  
		}

		delta = YTickDelta();
		let tt4 = Math.floor(-w2 / 10);
		tt4 = (tt4 < 0) ? tt4 : -1;
		for (let i = 1; (i * delta) > MinY()+ tt4; --i) {
			context.beginPath();
			if(i == 0) context.lineWidth = 0.7; else context.lineWidth = 0.15;
			if(del < 2){
				context.moveTo(DecartToScreenX(0) - Width/2 + w1,DecartToScreenY(i * delta));
				context.lineTo(DecartToScreenX(0) + Width/2 + w1,DecartToScreenY(i * delta));
				context.fillText(i, DecartToScreenX(0)+2,DecartToScreenY(i * delta)-3);
			}else if(del > 1 && i % del == 0){
				context.moveTo(DecartToScreenX(0) - Width/2 + w1,DecartToScreenY(i * delta));
				context.lineTo(DecartToScreenX(0) + Width/2 + w1,DecartToScreenY(i * delta));
				context.fillText(i, DecartToScreenX(0)+2,DecartToScreenY(i * delta)-3);
			}
			context.stroke();  
		}  
		
		context.beginPath();
		context.moveTo(DecartToScreenX(0),DecartToScreenY(0));
		context.lineTo(DecartToScreenX(MaxX())+w1,DecartToScreenY(0));
		context.stroke();
		
		context.beginPath();
		context.moveTo(DecartToScreenX(0),DecartToScreenY(0));
		context.lineTo(DecartToScreenX(MinX())+w1,DecartToScreenY(0));
		context.stroke();
		
		delta = XTickDelta();
		let tt1 = Math.floor(w1 / 10);
		tt1 = (tt1 > 0) ? tt1 : 1;
		for (let i = 1; (i * delta) < MaxX() + tt1; ++i) {
			context.beginPath();
			if(del < 2){
				context.moveTo(DecartToScreenX(i * delta),DecartToScreenY(0)-Height/2 + w2);
				context.lineTo(DecartToScreenX(i * delta),DecartToScreenY(0)+Height/2 + w2);
				context.fillText(i, DecartToScreenX(i * delta)+2,DecartToScreenY(0)-3);
			}else if(del > 1 && i % del == 0){
				context.moveTo(DecartToScreenX(i * delta),DecartToScreenY(0)-Height/2 + w2);
				context.lineTo(DecartToScreenX(i * delta),DecartToScreenY(0)+Height/2 + w2);
				context.fillText(i, DecartToScreenX(i * delta)+2,DecartToScreenY(0)-3);
			}
			context.stroke();  
		}

		delta = XTickDelta();
		let tt2 = Math.floor(w1 / 10);
		tt2 = (tt2 < 0) ? tt2 : -1;
		for (let i = 1; (i * delta) > MinX()+ tt2; --i) {
			context.beginPath();
			if(i == 0) context.lineWidth = 0.7; else context.lineWidth = 0.15;
			if(del < 2){
				context.moveTo(DecartToScreenX(i * delta),DecartToScreenY(0)-Height/2 + w2);
				context.lineTo(DecartToScreenX(i * delta),DecartToScreenY(0)+Height/2 + w2);
				context.fillText(i, DecartToScreenX(i * delta)+2,DecartToScreenY(0)-3);
			}else if(del > 1 && i % del == 0){
				context.moveTo(DecartToScreenX(i * delta),DecartToScreenY(0)-Height/2 + w2);
				context.lineTo(DecartToScreenX(i * delta),DecartToScreenY(0)+Height/2 + w2);
				context.fillText(i, DecartToScreenX(i * delta)+2,DecartToScreenY(0)-3);
			}
			context.stroke();  
		}
		context.restore();
		exx = 1;
	}
    
    function DrawLine(){

        let bbox1 = document.getElementById("bbox1").value;
        let bbox2 = document.getElementById("bbox2").value;
        let bbox3 = document.getElementById("bbox3").value;
        let bbox4 = document.getElementById("bbox4").value;
        
        let line1 = document.getElementById("line1").value;
        let line2 = document.getElementById("line2").value;
        let line3 = document.getElementById("line3").value;
        let line4 = document.getElementById("line4").value;

		let algoritmSelect = document.getElementById("algoritm").value;

		
		context.beginPath();

		context.moveTo(DecartToScreenX(bbox1),DecartToScreenY(bbox3));
		context.lineTo(DecartToScreenX(bbox2),DecartToScreenY(bbox3));

		context.moveTo(DecartToScreenX(bbox1),DecartToScreenY(bbox4));
		context.lineTo(DecartToScreenX(bbox2),DecartToScreenY(bbox4));
		
		context.moveTo(DecartToScreenX(bbox1),DecartToScreenY(bbox3));
		context.lineTo(DecartToScreenX(bbox1),DecartToScreenY(bbox4));

		context.moveTo(DecartToScreenX(bbox2),DecartToScreenY(bbox3));
		context.lineTo(DecartToScreenX(bbox2),DecartToScreenY(bbox4));
		
        xwmax=bbox2, xwmin=bbox1, ywmax=bbox4, ywmin=bbox3;
		
		point1 = [0,0,0,0];
		point2 = [0,0,0,0];
		
		clip(+line1, +line2, point1);
		clip(+line3, +line4, point2);

		let solution;

		if (algoritmSelect === "SC") {
			solution = SutherlandCohenAlgorithm(+line1, +line2, +line3, +line4, xwmin, xwmax, ywmin, ywmax);
		} else {
			solution = LiangBarskiAlgorithm(+line1, +line2, +line3, +line4, xwmin, xwmax, ywmin, ywmax);
		}


		context.stroke(); 
		context.beginPath();
		context.moveTo(DecartToScreenX(solution[0][0]),DecartToScreenY(solution[0][1]));
		context.lineTo(DecartToScreenX(solution[1][0]),DecartToScreenY(solution[1][1]));
		
		context.stroke(); 
		
	}
