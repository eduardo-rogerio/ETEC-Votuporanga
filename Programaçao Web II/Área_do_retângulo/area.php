<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <link rel="stylesheet" href="_css/estilo.css"/>
    </head>
    <body>
        <div>
        <?php
         $a = isset($_GET["base"])?$_GET["base"]:0;
         $b = isset($_GET["altura"])?$_GET["altura"]:0;
         $area = $a * $b;
         echo"A área do retângulo e :".number_format($area,2,",",".")." cm";
        ?>
        </div>
    </body>
</html>
