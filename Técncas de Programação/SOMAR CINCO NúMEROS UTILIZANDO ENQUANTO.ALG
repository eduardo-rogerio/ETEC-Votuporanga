algoritmo "Somar cinco números utilizando ENQUANTO"

var
    cont, soma, num:inteiro
inicio

      cont <- 1

      enquanto cont <= 5 faca
         escreva("Número: ")
         leia(num)
         soma <- soma + num// variavel soma tem que receber soma + num
         cont <- cont + 1// "<" sinal de atribuição errado, cont tem que receber cont + 1
      fimenquanto

      escreva("A soma é ",soma)

fimalgoritmo