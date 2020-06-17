Algoritmo "para_quantidade"
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
se a < b entao
   para x := a ate b passo 1 faca
        se (x mod 2 = 0) entao
           conta_par := conta_par + 1
        senao
             conta_impar := conta_impar + 1
        fimse
   fimpara
senao
     para x := b ate a passo 1 faca
          se (x mod 2 = 0) entao
             conta_par := conta_par + 1
          senao
               conta_impar := conta_impar + 1
          fimse
     fimpara
fimse
escreval("quantidade de pares",conta_par)
escreva("quantidade de impares",conta_impar)
Fimalgoritmo