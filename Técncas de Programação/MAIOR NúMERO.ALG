algoritmo "Maior n�mero"

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
      escreva("O maior � ",a)
   senao
      se (b > c) entao
         escreva("O maior � ",b)// estava faltando uma v�rgula aqui.
      senao
         escreva("O maior � ",c)
      fimse
   fimse//estava faltando um fimse aqui.
fimalgoritmo
