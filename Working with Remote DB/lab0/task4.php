<?php
if(isset($_GET['t4n']) && isset($_GET['t4x']))
{
    $n = $_GET['t4n'];
    $x = $_GET['t4x'];

    $val1 = sin($x);

    for($i = 0; $i < $n; $i++)
    {
        $result += $val1;

        $val1 = sin($val1);
    }

    echo 'val1 = '.$result;

}
else {
    echo "error!";
}

?>