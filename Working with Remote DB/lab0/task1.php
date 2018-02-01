<?php
if(isset($_GET['number']))
{
    $summ = 0;

    $n = $_GET['number'];
    
    //$n = 10;
    
    for($i = 1; $i < $n; $i++)
    {
        $temp = 1;
    
        for($j = $i; $j <= $i*2; $j++)
        {
            $temp *= $j;
        }
    
        $summ += $temp;
    }
        
    echo $summ;
}
else {
    echo "error!";
}


?>