algoritmo "Maior número"

var

   a,b,c: inteiro

inicio

   escreva("Digite o primeiro valor: ")
   leia(a)
   escreva("Digite o segundo valor: ")
   leia(b)
   escreva("Digite o terceiro valor: ")
   leia(c)

   se ((a > b) e (a > c)) entao
      escreva("O maior é ",a)
   senao
      se (b > c) entao
         escreva("O maior é ",b)// estava faltando uma vírgula aqui.
      senao
         escreva("O maior é ",c)
      fimse
   fimse//estava faltando um fimse aqui.
fimalgoritmo
