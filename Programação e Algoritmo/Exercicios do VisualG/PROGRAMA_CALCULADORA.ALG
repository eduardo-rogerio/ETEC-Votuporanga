Algoritmo "Programa_Soma"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 26/05/2020
Var
// Se��o de Declara��es das vari�veis 
opcao,n1,n2:inteiro
resultado:real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreval("---------------------------------")
escreval("-----PROGRAMA CALCULADORA--------")
escreval("---------------------------------")
escreval("")
escreval("Digite um n�mero para calcular: ")
leia(n1)
escreval("")
escreval("Digite um n�mero de op��o")
escreval("(1)SOMA , op��o(2)Dividir,")
escreval("(3)MULTIPLICA,(4)SUBTRAIR")
leia(opcao)
escreval("")
escreval("Digite outro n�mero")
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
            escreva("op��o invalida")
fimescolha

Fimalgoritmo