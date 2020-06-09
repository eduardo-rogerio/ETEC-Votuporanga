Algoritmo "Programa_Soma"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 26/05/2020
Var
// Seção de Declarações das variáveis 
opcao,n1,n2:inteiro
resultado:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("---------------------------------")
escreval("-----PROGRAMA CALCULADORA--------")
escreval("---------------------------------")
escreval("")
escreval("Digite um número para calcular: ")
leia(n1)
escreval("")
escreval("Digite um número de opção")
escreval("(1)SOMA , opção(2)Dividir,")
escreval("(3)MULTIPLICA,(4)SUBTRAIR")
leia(opcao)
escreval("")
escreval("Digite outro número")
leia(n2)
escolha opcao
       caso 1
            resultado:= n1+n2
            escreva(n1," +",n2," =",resultado)
       caso 2
            resultado:= n1/n2
            escreva(n1," /",n2," =",resultado)
       caso 3
            resultado:= n1*n2
            escreva(n1," *",n2," =",resultado)
       caso 4
            resultado:= n1-n2
            escreva(n1," -",n2," =",resultado)
       outrocaso
            escreva("opção invalida")
fimescolha

Fimalgoritmo