Algoritmo "faca_enquanto"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Eduardo Rog�rio
// Data atual  : 22/06/2020
Var
resp: caractere
A, B: real
Inicio
 repita
    escreval ("Digite dois n�meros: ")
    leia(A)
    leia(B)
    escreval ("Soma = ",(A + B))
    escreva ("Deseja continuar (S/N): ")
    leia (resp)
    escreva("-------------------------")
 ate ((resp = "n") ou (resp = "N" ))

Fimalgoritmo