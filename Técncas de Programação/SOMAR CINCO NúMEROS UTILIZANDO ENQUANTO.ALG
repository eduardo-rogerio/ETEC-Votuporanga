algoritmo "Somar cinco n�meros utilizando ENQUANTO"

var
    cont, soma, num:inteiro
inicio

      cont <- 1

      enquanto cont <= 5 faca
         escreva("N�mero: ")
         leia(num)
         soma <- soma + num// variavel soma tem que receber soma + num
         cont <- cont + 1// "<" sinal de atribui��o errado, cont tem que receber cont + 1
      fimenquanto

      escreva("A soma � ",soma)

fimalgoritmo