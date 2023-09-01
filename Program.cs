using Exercicios_01;

//Na main, crie um objeto de cada classe,
//preenchendo as propriedades e invocando os métodos.

Empreiteira empreiteira = new Empreiteira();
empreiteira.NomeFantasia = "Luelen Serviços de Arquitetura";
empreiteira.RazaoSocial = "Luelen Cavalheiro LTDA";
empreiteira.CNPJ = "11.003.009/0001-88";
empreiteira.DataAbertura = new DateOnly();
empreiteira.TelefoneContato = "19-23525-0988";

empreiteira.ImprimirDados();
empreiteira.RealizarVenda();

Varejo varejo = new Varejo();
varejo.NomeFantasia = "Luelen Mercadão dos Bytes";
varejo.RazaoSocial = "Luelen Cavalheiro Supermercado LTDA";
varejo.CNPJ = "28.005.089/0001-77";
varejo.DataAbertura = new DateOnly();
varejo.CNPJ = "11.003.009/0001-88";
varejo.TelefoneContato = "11-7714-2128";

varejo.ImprimirDados();
varejo.RealizarVenda();



