use std::io;

fn main() {
    loop {
        let mut input1 = String::new();
        let mut input2 = String::new();
        let mut operation = String::new();

        println!("Digite o primeiro numero (ou 'sair' para fechar):");
        io::stdin().read_line(&mut input1).expect("Falha ao ler entrada");
        if input1.trim() == "sair" {
            break;
        }

        println!("Digite o segundo numero:");
        io::stdin().read_line(&mut input2).expect("Falha ao ler entrada");

        let num1: f64 = match input1.trim().parse() {
            Ok(num) => num,
            Err(_) => {
                println!("Erro, digite um numero valido!");
                continue;
            }
        };

        let num2: f64 = match input2.trim().parse() {
            Ok(num) => num,
            Err(_) => {
                println!("Erro, digite um número valido!");
                continue;
            }
        };

        println!("Escolha a operação: 'multiplicar' ou 'somar'");
        io::stdin().read_line(&mut operation).expect("Falha ao ler entrada");

        let resultado = match operation.trim() {
            "multiplicar" => num1 * num2,
            "somar" => num1 + num2,
            _ => {
                println!("Operacao invalida. Tente novamente.");
                continue;
            }
        };

        println!("Resultado: {}", resultado);
    }
}

