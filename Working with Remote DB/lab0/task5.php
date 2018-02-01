<?php
    $val1 = sin($x);

    $result = 0;

    for($i = 99; $i > 1; $i-=3)
    {
        $result = sqrt($i + $result);
    }

    echo 'val1 = '.$result;
?>