<?php
if(isset($_GET['number3']))
{
    $n = $_GET['number3'];
    
    $val1 = 1;
    $val2 = 2;

    $result = 1;

    for($i = 0; $i < $n; $i++)
    {
        $result *= $val1 / $val2;

        $val1 += 2;
        $val2 += 2;
    }

    echo 'val1 = '.$result;

}
else {
    echo "error!";
}

?>