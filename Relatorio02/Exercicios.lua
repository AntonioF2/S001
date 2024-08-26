--1

function calcularTabuada(num)
    print("Tabuada do " .. num)
    for i = 1, 10 do
        print(num .. " x " .. i .. " = " .. num * i)
    end
end


print("Entre com um valor:")
local numero = tonumber(io.read())


calcularTabuada(numero)


--2

local tabela = {}
for i = 1, 100 do
    tabela[i] = math.random(1, 100)
end


local contadorPares = 0
for i = 1, #tabela do
    if tabela[i] % 2 == 0 then
        contadorPares = contadorPares + 1
    end
end


print("A tabela contem " .. contadorPares .. " numeros pares.")
