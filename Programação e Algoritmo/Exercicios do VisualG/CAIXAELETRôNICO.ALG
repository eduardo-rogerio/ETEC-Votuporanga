Algoritmo "caixaEletrônico"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/05/2020
Var
// Seção de Declarações das variáveis 
saldoDisponivel,valorSacar:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
saldoDisponivel:=
escreval("seja BEM VINDO ao seu terminal.........")
escreval("-------------------------")
escreva("Quanto você deseja sacar? ")
leia(valorSacar)
se valorSacar<=saldoDisponivel entao
saldoDisponivel:=saldoDisponivel-valorSacar
escreval("voce sacou R$",valorSacar)
escreva("seu saldo é R$",saldoDisponivel)
senao
escreva("saldo insuficiente!!")
fimse
Fimalgoritmo