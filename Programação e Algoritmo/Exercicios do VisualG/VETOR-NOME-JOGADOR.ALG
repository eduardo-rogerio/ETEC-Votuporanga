Algoritmo "vetor-nome-jogador"

Var
vet : vetor [1..3] de caractere
time : vetor [1..3] de caractere
i: inteiro
Inicio
para i := 1 ate 3 faca
     escreva("digite o nome de um jogador da seleção:")
     leia(vet[i])
     escreva("digite o nome do time:")
     leia(time[i])
     escreval("---------------------------------------")
fimpara
escreva("O nome dos jogadores digitados foram: ",vet[1]," do time",time[1],", ",vet[2]," do time",time[2],", ",vet[3]," do time",time[3])
Fimalgoritmo