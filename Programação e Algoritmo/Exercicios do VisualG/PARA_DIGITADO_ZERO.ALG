Algoritmo "para_digitado_zero"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Eduardo rogério
// Data atual  : 16/06/2020
Var
// Seção de Declarações das variáveis 
x,n :inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("Digite um número:")
leia(n)
se n > 0 entao
   para x:= n ate 0 passo -1 faca
        escreva(X)
   fimpara
senao
     para x:= n ate 0 passo 1 faca
        escreva(X)
     fimpara
fimse

Fimalgoritmo