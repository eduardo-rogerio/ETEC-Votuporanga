Algoritmo "para_quantidade2"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Eduardo rog�rio
// Data atual  : 16/06/2020
Var
// Se��o de Declara��es das vari�veis 
x,a,b,conta_par,conta_impar:inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreva("digite um n�mero:")
leia(a)
escreva("digite outro n�mero:")
leia(b)
se a > b entao
   x := a
   a := b
   b := x
fimse
 para x := a ate b passo 1 faca
        se (x mod 2 = 0) entao
           conta_par := conta_par + 1
        senao
             conta_impar := conta_impar + 1
        fimse
   fimpara

escreval("quantidade de pares",conta_par)
escreva("quantidade de impares",conta_impar)
Fimalgoritmo