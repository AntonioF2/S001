REM Relatório 01 Basic

REM Questao 1
CLS
INPUT "Entre com a: ", a
INPUT "Entre com b: ", b
INPUT "Entre com c: ", c

delta = b * b - 4 * a * c

IF delta < 0 THEN
    PRINT "Nao temos raizes reais."
ELSEIF delta = 0 THEN
    x1 = -b / (2 * a)
    PRINT "Temos uma raiz real: "; x1
ELSE
    x1 = (-b + SQR(delta)) / (2 * a)
    x2 = (-b - SQR(delta)) / (2 * a)
    PRINT "Raizes: "; x1; " e "; x2
END IF










