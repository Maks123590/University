function SutherlandCohenAlgorithm(ax, ay, bx, by, xwmin, xwmax, ywmin, ywmax) {
    var m = (by-ay) / (bx-ax);
    
    if (point1[0] == 1)
        y = ywmax;
    if (point1[1] == 1)
        y = ywmin;
    if (point1[0] == 1|| point1[1] == 1)
    {
        ax = ax + (y - ay) / m;
        ay = y;
    }
    
    if (point2[0] == 1)
        y = ywmax;
    if (point2[1] == 1)
        y = ywmin;
    if (point2[0] == 1|| point2[1] == 1)
    {
        bx = bx + (y - by) / m;
        by = y;
    }
    
    if (point1[2] == 1)
        x=xwmax;
    if (point1[3] == 1)
        x=xwmin;
    if (point1[2] == 1|| point1[3] == 1)
    {
        ay = +ay + m * (x - ax);
        ax = x;
    }
    
    if (point2[2] == 1)
        x = xwmax;
    if (point2[3] == 1)
        x = xwmin;
    if (point2[2] == 1||point2[3] == 1)
    {
        by = by + m * (x - bx);
        bx = x;
    }
    
    return [
      [+ax , +ay],
      [+bx , +by]
    ];
    
}


function LiangBarskiAlgorithm(x0, y0, x1, y1, xmin, xmax, ymin, ymax) {
    var t0 = 0, t1 = 1;
    var dx = x1 - x0, dy = y1 - y0;
    var p, q, r;
    
    for(var i = 0; i < 4; i++) {
        if (i  ==  0){
            p = -dx;
            q = -(xmin - x0);
        }
        if (i  ==  1){
            p = dx;
            q = (xmax - x0);
        }
        if (i  ==  2){
            p = -dy;
            q = -(ymin - y0);
        }
        if (i  ==  3){
            p = dy;
            q = (ymax - y0);
        }
        
        r = q / p;
        
        if (p  ==  0 && q < 0) return null;
        
        if (p < 0) {
          if (r > t1) return null;
          else if (r > t0) t0 = r;
        } else if (p > 0) {
          if (r < t0) return null;
          else if (r < t1) t1 = r; 
        }
    }
    
    return [
      [x0 + t0 * dx, y0 + t0 * dy],
      [x0 + t1 * dx, y0 + t1 * dy]
    ];
    
}