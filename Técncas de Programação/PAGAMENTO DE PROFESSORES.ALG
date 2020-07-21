Algoritmo "Pagamento de professores"

Var
nivel, horas: inteiro

Inicio

escreva("DIGITE O NÍVEL DO PROFESSOR (1/2/3): ")
leia(nivel)
escreva("DIGITE O NÚMERO DE HORAS TRABALHADAS: ")//fechei as aspas aqui
leia(horas)

se nivel = 1 entao
   escreval("O PROFESSOR GANHA",horas*12)
senao
     se nivel = 2 entao // adicionei o comando entao nessa linha e mudei a variavel testada para nivel.
        escreval("O PROFESSOR GANHA",horas*17)// mudei o sinal + por *
     senao
          se nivel = 3 entao// adicionei mais um teste pois números negativos estavam gerando pagamentos com valor da hora 25
            escreva("O PROFESSOR GANHA",horas*25)
          senao
               escreva ("número invalido. digite o número 1, 2 ou 3.")
          fimse
     fimse
fimse
Fimalgoritmo