Algoritmo "caixaEletr�nico"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/05/2020
Var
// Se��o de Declara��es das vari�veis 
saldoDisponivel,valorSacar:real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
saldoDisponivel:=
escreval("seja BEM VINDO ao seu terminal.........")
escreval("-------------------------")
escreva("Quanto voc� deseja sacar? ")
leia(valorSacar)
se valorSacar<=saldoDisponivel entao
saldoDisponivel:=saldoDisponivel-valorSacar
escreval("voce sacou R$",valorSacar)
escreva("seu saldo � R$",saldoDisponivel)
senao
escreva("saldo insuficiente!!")
fimse
Fimalgoritmo