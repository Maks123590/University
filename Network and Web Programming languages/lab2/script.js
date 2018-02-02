(function() {
    
    let matr = [[1.0, 0.42, 0.54, 0.66],[0.42, 1.0, 0.32, 0.44],[0.54, 0.32, 1.0, 0.22],[0.66, 0.44, 0.22, 1.0]];

    let detmatr = getMatrDet(matr);

    if (detmatr === 1 || detmatr === -1) {
        alert('Является ортогональной');
    } 
    else 
    {
        alert('Не является ортогональной');
    }


    function getMatrDet(matrix) 
    {
        let n = matrix.length;
        let m = matrix[0].length;
        let detMatr = 0;

        if (n === 1 && m === 1)
        {
            return matrix[0][0];
        }

        if (MatrDimIs2(matrix)) 
        {
            return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        } 
        

        let subMatr = [];

        for(let i = 0; i < n; i++) {

            subMatr = getSubmatrix(matrix, 0, i);

            let sign = (i%2==0) ? 1 : -1;
            detMatr += sign * matrix[0][i] * getMatrDet(subMatr);

        }

        return detMatr;
    }

    function MatrDimIs2(matrix) {
        if (matrix.length !== 2) 
        {
            return false; 
        } 
        else 
        {
            if (matrix[0].length !== 2) 
            {
                return false;
            } 
            else 
            {
                return true;
            }
        }
    }

    function getSubmatrix(matrix, elemRowPosition, elemColumnPosition) 
    {
        let subMatr = [];

        let tempRow = [];

        for(let i = 0; i < matrix.length; i++)
        {
            if (i !== elemRowPosition)
            {
                for(j = 0; j < matrix[0].length; j++)
                {
                    if (j !== elemColumnPosition) {
                        tempRow.push(matrix[i][j]);
                    }
                }
    
                subMatr.push(tempRow);
                
                tempRow = [];
            }
        }

        return subMatr;
    }
}());