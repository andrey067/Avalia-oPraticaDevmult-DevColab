# Avaliação Prática para as disciplinas de Desenvolvimento Multiplataforma e Desenvolvimento Colaborativo;

 -Professor: Pedro Barcelos
 -Data de Entrega: 18/06/2021 às 23h59

Você foi selecionado para participar de um projeto na empresa que você trabalha com Analista Desenvolvedor Jr. O projeto consiste em duas fases: a primeira está relacionada a realização de rotinas de testes e a outra consiste em configurar o ambiente colaborativo do GitHub para o projeto de testes.

Você deve criar um projeto em C# ou DotNet Framework utilizando o Visual Studio 2019;

## Exercício 1 (5 pontos) - 
Crie uma classe para realizar o cálculo de Bhaskara. A fórmula de Bhaskara é um cálculo matemático para determinar as raízes de uma função de segundo grau por meio de seus coeficientes. Esse coeficiente que multiplica a variável desconhecida (x) das equações.  
A termologia da fórmula é uma homenagem ao seu criador, o professor e astrólogo indiano Bhaskara Akaria. Ele é tido como um dos principais matemáticos do século XII. 

![](https://images.educamaisbrasil.com.br/content/banco_de_imagens/guia-de-estudo/D/formula-bhaskara-matematica.jpg)

A figura dentro da raiz na fórmula de Bhaskara é nomeada de discriminante. Seu símbolo é a letra grega delta e apresenta a determinada fórmula:

![](https://www.coc.com.br/gallery/repository/uploads/blog/2018/novembro/formula-de-bhaskara/BHASKARA-1.png)
 
* Se o delta for maior que zero, a equação terá dois valores reais e distintos;
* Se o delta for igual a zero, a equação terá somente um valor real ou dois resultados iguais; 
* Se o delta for menor que zero, a equação não possuirá valores reais. 

Dentro da classe que você criará, implemente uma função para realizar o cálculo do delta de Bhaskara, perceba que o delta pode ter três tipos de resultados diferentes, você precisa tratar cada resultado:

* Para situações do delta maior que zero, retorne o maior valor das raízes;
* Para situações do delta igual a zero, retorne o valor zero;
* Para situações do delta menor que zero, retorne o valor -1.

Após a implementação do cálculo do delta de bhaskara adicione um projeto para realizar o teste da função anteriormente criada. Utilize um decorator na sua função de teste para pelo menos 4 casos. Construa a função de teste separando as partes: Arrange, Action e Assert.

## Exercício 2 (5 pontos)- 

Crie uma classe Pessoa que possua como atributos apenas o nome e a idade da pessoa. Nesta classe você implementará uma função que verificará se a idade da pessoa é um número primo ou não, atenção: a função retornará uma string como resultado e terá um objeto do tipo pessoa como parâmetro de passagem. Existem infinitas funções simples na internet que ensinam a realizar o cálculo de verificação de números primos. 
Após a criação da classe de cálculo, implemente um projeto de teste para verificar se o seu cálculo está correto. Utilize o framework Moq. Utilize um decorator na sua função de teste para pelo menos 4 casos
Ambas as soluções podem estar na mesma solution.


***

A parte a seguir será avaliada na disciplina de Desenvolvimento Colaborativo.

## Exercício 1 (5 pontos) - 
A solution acima deverá ser inserida em um repositório público no GitHub. Neste repositório você deverá:

*implementar um Action de Deploy;
*Criar um Project utilizando a template Basic Kanban;
*Implementar uma Wiki para explicar o todo o projeto, desde os cálculos implementados aos testes criados, utilize imagens;
*Crie uma issue solicitando apoio da comunidade do github para uma evolução na parte de testes que utilize DataDriven categorize como bug. Nesta issue explique como funciona suas funções de testes, o que elas recebem como parâmetro e a verificação que fazem;
*No meu Code crie um arquivo de readme.md, nele faça uma breve descrição do seu projeto.

## Exercício 2 (5 pontos) – 

Você foi selecionado para realizar a análise inicial de levantamento de requisitos para o problema de Controlar o consumo de manutenção de uma frota de veículos. Utilize o artigo “UMA METODOLOGIA PARA ENGENHARIA DE REQUISITOS PARA PEQUENAS EQUIPES DE DESENVOLVIMENTO DE SOFTWARE”, disponível em:< https://core.ac.uk/download/pdf/235579475.pdf> como parâmetro e fonte de consulta. Em um arquivo de texto (word ou outro tipo) construa um documento com o levantamento de requisitos que tenha:

* Definição do objetivo;
* Requisitos de Negócios;
* Requisitos Funcionais;
* Matriz de Dependências.

Para todas as soluções acima utilize o modelo do arquivo baseado em tabelas.
O aluno deverá enviar um e-mail para o professor (pedro@barcelosneto.com) com o link do repositório do github e o arquivo do levantamento de requisitos em anexo.
