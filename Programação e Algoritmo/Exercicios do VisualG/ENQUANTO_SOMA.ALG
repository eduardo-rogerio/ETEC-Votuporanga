Algoritmo "enquanto_soma"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Eduardo rog�rio
// Data atual  : 16/06/2020
Var
resp: caractere
a,b: inteiro
Inicio
resp:= "S"
enquanto ((resp = "S") ou (resp = "s")) faca
         escreva("digite um n�mero: ")
         leia(a)
         escreva("digite outro n�mero: ")
         leia(b)
         escreval("soma �:",a+b)
         escreval("------------------------")
         escreva("Deseja continuar (s/n)? ")
         leia(resp)
         escreval("------------------------")
fimenquanto

Fimalgoritmo