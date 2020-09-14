<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="_css/estilo.css"/>
        <title>Média do Aluno</title>
    </head>
    <body>
        <div>
        <?php
            function media($n1,$n2,$n3,$n4){
                $media = ($n1+$n2+$n3+$n4)/4;
                return $media;
            }
            echo "Sua média é ".media(5,7,7,10);
        ?>
        </div>
    </body>
</html>
