Algoritmo "semnome"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Media! (fun��o)
// Autor(a)    : Eduardo rog�rio souza santos
// Data atual  : 18/05/2020
Var
// Se��o de Declara��es das vari�veis 
media,nota1,nota2,nota3:real
aluno:caractere

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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
escreva("Aluno ",aluno," aprovado sua m�dia �: ",media)
senao
escreval("Reprovado!! m�dia ",media)
fimse
Fimalgoritmo