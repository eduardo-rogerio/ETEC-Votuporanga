Algoritmo "vetor_media"

Var
nome: vetor [1..4] de caractere
n1: vetor[1..4] de real
n2: vetor[1..4] de real
m: vetor[1..4] de real
i: inteiro
Inicio
para i := 1 ate 4 faca
     escreval("---------------------------")
     escreva("digite o",i,"° nome:")
     leia(nome[i])
     escreva("digite a primeira nota:")
     leia(n1[i])
     escreva("digite a segunda nota:")
     leia(n2[i])
     m[i] := (n1[i]+n2[i])/2
fimpara
limpatela
para i := 1 ate 4 faca
escreval("--------------------------------")
escreval("aluno ",nome[i]," nota ",m[i])
fimpara
Fimalgoritmo