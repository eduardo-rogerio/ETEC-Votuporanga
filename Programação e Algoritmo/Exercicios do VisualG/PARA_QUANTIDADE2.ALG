Algoritmo "para_quantidade2"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Eduardo rogério
// Data atual  : 16/06/2020
Var
// Seção de Declarações das variáveis 
x,a,b,conta_par,conta_impar:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("digite um número:")
leia(a)
escreva("digite outro número:")
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