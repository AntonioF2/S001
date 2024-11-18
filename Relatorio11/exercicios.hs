--1
import Control.Monad (forever)

main :: IO ()
main = do
    
    let lista = [30,29..1]
    let listaMultiplicada = map (*3) lista
    let listaInvertida = reverse listaMultiplicada
  
    print $ last listaInvertida

    --2
    
fatorial :: Integer -> Integer
fatorial 0 = 1
fatorial n = n * fatorial (n - 1)

main :: IO ()
main = forever $ do
    putStrLn "Digite um número:"
    input <- getLine
    let numero = read input :: Integer
    if numero > 0
        then print $ fatorial numero
        else print $ numero * 2
