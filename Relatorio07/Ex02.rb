class Carro
  def descrever
    "Este é um carro genérico."
  end
end

class CarroEsportivo < Carro
  def descrever
    "Este é um carro esportivo, com alta performance e velocidade."
  end
end


class CarroSedan < Carro
  def descrever
    "Este é um carro sedan, confortável e espaçoso."
  end
end

# Criação das instâncias (objetos)
carro_generico = Carro.new
carro_esportivo = CarroEsportivo.new
carro_sedan = CarroSedan.new

# Chamando o método descrever para cada objeto
puts carro_generico.descrever
puts carro_esportivo.descrever
puts carro_sedan.descrever
