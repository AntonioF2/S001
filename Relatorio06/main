class Animal {
    constructor(nome, idade, especie) {
        this.nome = nome;
        this.idade = idade;
        this.especie = especie;
    }

    printinfo() {
        console.log(`Nome: ${this.nome}`);
        console.log(`Idade: ${this.idade}`);
        console.log(`Espécie: ${this.especie}`);
    }
}


class Cachorro extends Animal {
    #raca; 

    constructor(nome, idade, raca) {
        super(nome, idade, 'Cachorro');
        this.#raca = raca;
    }

    printinfo() {
        super.printinfo();
        console.log(`Raça: ${this.#raca}`);
    }
}


class Gato extends Animal {
    constructor(nome, idade, cores) {
        super(nome, idade, 'Gato');
        this.cores = cores;
    }

    printinfo() {
        super.printinfo();
        console.log(`Cores: ${this.cores.join(', ')}`);
    }
}




const animal1 = new Animal('Balu', 5, 'Elefante');

const cachorro1 = new Cachorro('Rex', 3, 'Labrador');

const gato1 = new Gato('Mimi', 2, ['Preto', 'Branco', 'Cinza']);


function listarMetodos(obj) {
    let metodos = [];
    let proto = Object.getPrototypeOf(obj);
    while (proto) {
        metodos = metodos.concat(Object.getOwnPropertyNames(proto));
        proto = Object.getPrototypeOf(proto);
    }
    
    return metodos.filter(item => typeof obj[item] === 'function');
}


console.log('--- Informações do Animal ---');
animal1.printinfo();
console.log('\n--- Informações do Cachorro ---');
cachorro1.printinfo();
console.log('\n--- Informações do Gato ---');
gato1.printinfo();


console.log('\n--- Metodos do Animal ---');
console.log(listarMetodos(animal1));

console.log('\n--- Metodos do Cachorro ---');
console.log(listarMetodos(cachorro1));

console.log('\n--- Metodos do Gato ---');
console.log(listarMetodos(gato1));

