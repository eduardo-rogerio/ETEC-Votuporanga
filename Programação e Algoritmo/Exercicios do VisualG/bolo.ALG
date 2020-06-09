Algoritmo "semnome"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Media! (função)
// Autor(a)    : Eduardo rogério souza santos
// Data atual  : 18/05/2020
Var
// Seção de Declarações das variáveis 
media,nota1,nota2,nota3:real
aluno:caractere

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("Digite o nome do aluno: ")
leia(aluno)
escreva("Digite a primeira nota: ")
leia(nota1)
escreva("Digite a segunda nota: ")
leia(nota2)
escreva("Digite a terceira nota: ")
leia(nota3)
media:= (nota1+nota2+nota3)/3
se (media>=7) entao
escreva("Aluno ",aluno," aprovado sua média é: ",media)
senao
escreval("Reprovado!! média ",media)
fimse
Fimalgoritmo