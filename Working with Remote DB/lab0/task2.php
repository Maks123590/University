<?php
if(isset($_GET['number2']))
{
    $x = $_GET['number2'];
    
    $sqarX = $x * $x;

    $denom = $sqarX;

    for($i = 256; $i > 1; $i /= 2) 
    {
        $denom = $sqarX + $i/$denom;
    }
        
    echo $x / $denom;
}
else {
    echo "error!";
}

?>