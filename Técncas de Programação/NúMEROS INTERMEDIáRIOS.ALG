Algoritmo "N�meros intermedi�rios"

Var
cont: inteiro//mudei o tipo da variavel para inteiro.
num: real
Inicio
num <- 1// iniciei a vari�vel para que seja possivel entrar no loop.
cont <- 0
//escreva ("Digite um n�mero qualquer ou 0 para sair: ").
//leia(num) 'exclui essa entrada de dados pois ela n�o vai ser testa e nem entra na contagem'.

//enquanto (num <> 0) fa�a 'erro de sintaxi uso do (�)'.
  enquanto (num <> 0) faca
  
   escreva ("Digite um n�mero qualquer ou 0 para sair: ")
   leia(num)//adicionei uma entrada de dados aqui para que a variavel (num) seja testada dentro do loop.

//se ((num >= 100) e (num <= 200)) ent�o /erro de sintaxi uso do sinal(~).
   se ((num >= 100) e (num <= 200)) entao
      cont <- cont + 1
      //escreva ("Digite um n�mero qualquer ou 0 para sair: ")
      //leia(num) exclui essa entrada pois a variavel (num) n�o vai ser testada depois que sair da condicional.
   fimse
fimenquanto
escreva("Total", cont)

Fimalgoritmo