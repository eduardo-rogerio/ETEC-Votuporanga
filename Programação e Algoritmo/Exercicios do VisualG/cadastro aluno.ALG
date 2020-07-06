Algoritmo "Vetor_Nome_Idade"

Var
  nome: vetor [1..2] de caractere
  idade: vetor [1..2] de inteiro
  altura: vetor [1..2] de real
  i: inteiro

Inicio
  ESCREVAL ("CADASTRO SIMPLES DE NOME E IDADE DO ALUNO")
           PARA i <- 1 ATE 2 FACA
                ESCREVAL ("=========================================")
                ESCREVA ("Digite o nome do aluno: ")
                LEIA (nome[i])

                ESCREVA ("Digite a idade do aluno: ")
                LEIA (idade[i])

                ESCREVA ("Digite a altura do aluno: ")
                LEIA (altura[i])
           FIMPARA
  LIMPATELA
  ESCREVAL ("RELATORIO DO CADASTRO SIMPLES DE NOME E IDADE DO ALUNO")

           PARA i <- 1 ATE 2 FACA
                ESCREVAL ("======================================================")
                ESCREVAL ("O nome do aluno é ", nome[i],", ele tem ",altura[i]," de altura e sua idade é ",idade[i])
           FIMPARA
   ESCREVAL ("====================================================")
   ESCREVAL ("RELATORIO GERADO COM SUCESSO")
Fimalgoritmo
