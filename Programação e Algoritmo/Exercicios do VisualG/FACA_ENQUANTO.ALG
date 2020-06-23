Algoritmo "faca_enquanto"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Eduardo Rogério
// Data atual  : 22/06/2020
Var
resp: caractere
A, B: real
Inicio
 repita
    escreval ("Digite dois números: ")
    leia(A)
    leia(B)
    escreval ("Soma = ",(A + B))
    escreva ("Deseja continuar (S/N): ")
    leia (resp)
    escreva("-------------------------")
 ate ((resp = "n") ou (resp = "N" ))

Fimalgoritmo