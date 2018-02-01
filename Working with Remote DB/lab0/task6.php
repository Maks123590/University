<?php
if(isset($_GET['t6n']) && isset($_GET['t6x']) && isset($_GET['t6a']))
{
    $n = $_GET['t6n'];
    $x = $_GET['t6x'];
    $a = $_GET['t6a'];

    $result = $x;

    for($i = 0; $i < $n; $i++)
    {
        $result = ($result + $a);
        $result *= $result;
    }

    $result += $a;

    echo 'val1 = '.$result;

}
else {
    echo "error!";
}

?>