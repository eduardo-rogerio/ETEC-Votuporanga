Algoritmo "vetor-capitais"

Var
vet : vetor [1..3] de caractere
capital: vetor [1..3] de caractere
i: inteiro
Inicio
para i := 1 ate 3 faca
     escreva("digite o nome de um pais")
     leia(vet[i])
     escreva("digite o nome da capital:")
     leia(capital[i])
     escreval("---------------------------------------")
fimpara
escreva("O nome dos jogadores digitados foram: ",vet[1]," do time",capital[1],", ",vet[2]," do time",capital[2],", ",vet[3]," do time",capital[3])
Fimalgoritmo