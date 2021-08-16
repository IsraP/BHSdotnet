# BHSdotnet

Um repositório feito pra guardar toda a solução desenvolvida para o desafio proposto pelo processo de estágio da BHS.

## Funcionalidades

### 1. Ler os dados pré feitos e incluí-los no banco
* Para facilitar a leitura, o arquivo foi separado em dois, cada um contendo os diferentes tipos de linha
    * A separação foi feita a partir de uma função da mesma classe que lê os arquivos
* O arquivo é lido a partir da classe "DataExtractor", presente no caminho Data/tools/DataExtractor.cs
* Abrange os requisitos de 1 a 4

### 2. Mostrar todos os pedidos cadastrados
* Filtro feito a partir de sua descrição
* Os itens podem ser vistos a partir do botão "ver mais"
* O cadastro pode ser feito a partir da tela de pedidos ou pelo Carrinho
* Abrange o requisito 5

### 3. Mostrar todos os itens cadastrados
* Filtro feito a partir de sua descrição
* O cadastro pode ser feito a partir da tela de itens
* Devido a um erro de leitura meu, a implementação de itens em pedidos não foi feita
  * Como placeholder, todos os novos itens são salvos no pedido de Código 1
* Abrange parcialmente o requisito 6

### 4. Bonus! Front-end
* A aplicação foi feita visando um front-end responsivo e bonito, sem necessáriamente necessitar de um tempo exclusivo para o desenvolvimento do mesmo
* Os cards e barras de pesquisa usados são templates modificados para se encaixarem na abordagem do projeto (do site free frontend)
* Foi usado o bootstrap para a criação de todos os outros componentes utilizados
* O site é completamente responsivo
  
### 5. Bonus! Paginação
* Foi feito um sistema simples de paginação para evitar páginas de 30 metros de altura
  
### 6. Bonus! Restauração de pedidos
* Foi feito um sistema de restauração de pedidos
* Era simples, então eu acabei fazendo

## Comentários

* Colocar esse código de pedido como non-nullable foi sacanagem, eim kk
  * Me pegou completamente de surpresa, todo o planejamento que eu tinha feito do sistema acabou se tornando inviável (tanto que eu nem implementei a adição de itens nos pedidos)
* A abordagem database-first não havia sido passada em nenhum dos cursos, então eu demorei um pouco pra pegar a manha
* Gostei bastante da experiência, não sei como as coisas vão ser depois disso, mas gostaria de agradecer a todos os envolvidos pela oportunidade.