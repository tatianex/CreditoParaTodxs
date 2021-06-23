# CreditoParaTodxs

O problema:

A empresa CréditoParaTodxs é uma empresa multinacional que ajuda milhões de pessoas a conseguirem crédito pessoal.

Um dos grandes desafios desta empresa, é se comunicar de forma efetiva com seus respectivos clientes. Por exemplo, uma das necessidades é apresentar, de acordo com sua saúde financeira, propostas de empréstimo pessoal.

Considere os seguintes critérios fictícios:

Listar as ofertas de crédito de acordo com o descritivo técnico;
Detalhar a oferta do usuário ao momento de escolha;
Apresentar a revisão das informações;
E permitir realizar a contratação;

# Definição de Classes e estrutura do sistema da empresa Crédito para Todxs

Inicialmente foi desenhado um diagrama de classes, dividindo uma classe para Clientes (Customers.cs), uma classe para Ofertas (Quotation.cs) e outra para Contrato (Contract.cs).

Foram criadas as devidas propriedades com anotações sobre suas utilidades e iniciado a implementação dos métodos.

Por ter sido especificado que o problema deveria ser simples e objetivo não foram criadas classes de serviço e nem o banco de dados.

Numa implementação futura o código poderia ser refatorado, criando uma camada de serviços, com uma classe de pessoas, por exemplo, onde clientes e fornecedores herdariam características da classe Pessoa assim como a implementação de uma classe endereço, para reaproveitar melhor o código e ajudar na manutenção de endereços.
