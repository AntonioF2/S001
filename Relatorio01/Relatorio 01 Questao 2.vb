REM Programa para gerar um número aleatório e calcular o fatorial
CLS
RANDOMIZE TIMER
n = LET(RND * 10) + 1
PRINT "Número aleatório gerado: "; n

factorial = 1
FOR i = 1 TO n
    factorial = factorial * i
NEXT i

PRINT "Fatorial de "; n; " é: "; factorial