Algoritmo "Números intermediários"

Var
cont: inteiro//mudei o tipo da variavel para inteiro.
num: real
Inicio
num <- 1// iniciei a variável para que seja possivel entrar no loop.
cont <- 0
//escreva ("Digite um número qualquer ou 0 para sair: ").
//leia(num) 'exclui essa entrada de dados pois ela não vai ser testa e nem entra na contagem'.

//enquanto (num <> 0) faça 'erro de sintaxi uso do (ç)'.
  enquanto (num <> 0) faca
  
   escreva ("Digite um número qualquer ou 0 para sair: ")
   leia(num)//adicionei uma entrada de dados aqui para que a variavel (num) seja testada dentro do loop.

//se ((num >= 100) e (num <= 200)) então /erro de sintaxi uso do sinal(~).
   se ((num >= 100) e (num <= 200)) entao
      cont <- cont + 1
      //escreva ("Digite um número qualquer ou 0 para sair: ")
      //leia(num) exclui essa entrada pois a variavel (num) não vai ser testada depois que sair da condicional.
   fimse
fimenquanto
escreva("Total", cont)

Fimalgoritmo