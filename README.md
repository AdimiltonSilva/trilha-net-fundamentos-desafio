# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução proposta
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Solução
Na inclusão de placas (veículo), adicionei uma estrutura de repetição (while) para que o usuário possa informar várias placas e só depois voltar ao Menu Principal, também foi feita uma validação na lista de veículos para que o usuário não cadastre uma mesma placa e seja informado que a placa já foi cadastrada, caso contrário, o usuário recebe uma mensagem que o cadastro foi efetuado com sucesso.

No método **RemoverVeiculo**, foi adicionado um método para efetuar o calculo de permanência e retornar o valor usando um "*if ternário*". O valor sofreu uma mudança referente a proposta inicial, agora a forma de calculo retornado é:

valorTotal = precoInicial + ((precoPorHora - 1) * horas)

Ou seja, o precoInicial dá direito ao veículo ficar estacionado na primeira hora inicial pagando apenas o valor "*precoInicial*", e depois será acrescido o valorPorHora para cada hora adicional.

No método **ListarVeiculos**, foi usado uma estrutura de repetição "*foreach*" para percorrer todos os itens da lista e também foi usada uma variável para contar e informar quantos veículos tem estacionados.
