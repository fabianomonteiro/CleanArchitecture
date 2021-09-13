# CleanArchitecture

Neste repositório estou utilizando C# para construir uma arquitetura de projeto que utilize alguns dos conceitos que Robert Cecil Martin aborda em seu livro intitulado Clean Architecture ou Arquitetura Limpa.

Estou aplicando desde conceitos mais conhecidos como Inversão de Controle utilizando Injeção de Dependência.

Como também fazendo a Inversão de Controle utilizando o conceito de AOP (Aspect Oriented Programming) ou (Programação Orientada a Aspectos).

Nesta abordagem de AOP, desenvolvemos uma classe que representa o Interactor descrito no livro, e ele é responsável por atuar como um Proxy Transparente que encapsula todas as execuções da aplicação.

Esta abordagem é muito interessante, pois com ela nós conseguimos adiar ao máximo possível decisões de quais tecnologias, banco de dados, e frameworks vamos utilizar no projeto, pois conforme o livro aborda, estes itens devem ser tratados como secundários dentro do desenvolvimento de uma sistema.

E com a utilização de técnicas de AOP, nós fomos capazes de criar um mecanismo de inversão de controle, que disponibiliza Aspectos (Plugins) de Log, Cache, Mappers entre outros, que podem facilmente ser implementados posteriormente no sistema.

Assim sendo, podemos focar no que realmente é importante no início de todo projeto, principalmente para os nossos Clientes/Stakeholders, que é, a Regra de Negócio!

Isto é muito aderente a realidade do nosso mercado, ainda mais quando amadurecemos como desenvolvedores/arquitetos de software, pois no final das contas, nosso foco deve ser o desenvolvimento de software que Entrega Valor para os nossos Clientes/Stakeholders e não para nós mesmos, não é verdade?

Com certeza desta forma é muito mais fácil entregarmos valor, pois podemos trabalhar mais focados em entregas evolutivas das nossas POCs/MVPs, deixando decisões mais técnicas para o futuro, de acordo com a viabilidade do projeto.

No livro Robert Martin descreve alguns exemplos onde ele utilizou a abordagem de plugins criando uma aplicação inteira sem banco de dados, persistindo os dados diretamente em disco, no final do projeto ele viu que a abordagem de não utilizar um banco de dados era até melhor, e decidiu lançar o produto sem uma ferramenta de banco de dados.

Adiar este tipo de decisão faz muito sentido, muitas vezes perdermos muito tempo decidindo quais tecnologias vamos utilizar, quais ferramentas, frameworks, banco de dados e etc, e na maioria das vezes decidimos isso de forma totalmente precoce. Quantas vezes somente quando avançamos no desenvolvimento do projeto percebemos que este tipo de decisão acabou não sendo a melhor, e precisamos reavaliar outras opções que se enquadrem melhor com o sistema já mais maduro.

A abordagem de AOP gera duas coisas muito boas, a primeira é essa que já explicamos, de podermos adiar a decisão até o momento que tenhamos mais segurança para decidi-la, e a outra é que no final das contas, a nossa aplicação fica totalmente desacoplada e plugável, pois muitas vezes quando decidimos por utilizar um determinado framework logo no início, acabamos amarrando a aplicação a ele, e quando precisamos mudar de ideia acabamos tendo que refatorar muita coisa.

Eu achei interessante o livro, pois Robert Martin fala muito mais sobre conceitos e principios, ele não nos da uma receita de bolo de como podemos aplicar de forma prática a arquitetura limpa em nossos projetos, isto é interessante, pois podemos utilizar os vários padrões arquiteturais, design patterns, e mescla-los em nossas soluções de acordo com a necessidade de cada projeto.

Neste projeto pretendo explorar conceitos de CQRS, Agregadores do DDD entre outras abordagens.

O projeto ainda está em construção e pretendo ir amadurecendo ele aos poucos, conto com a colaboração de quem estiver afim de me apoiar nesta empreitada!

Lembrem-se, não existe bala de prata no desenvolvimento de software, esta solução que estou criando é uma mescla de vários conhecimentos que adiquiri durante os meus quase 20 anos na área de desenvolvimento de software, e minha intenção aqui não é de convencer ninguém de que existe uma arquitetura perfeita que deve ser seguida para todos os projetos.

Quero mostrar que existem conceitos e principios, que independem da forma como você irá construir a sua aplicação, e até de qual linguagem e plataforma você irá desenvolve-la, se você seguir estes conceitos e principios, tenho certeza que sua aplicação chegará muito mais longe do que uma aplicação que não os seguem.

Já vi muito código construido sem nenhuma boa práticas, arquitetura, e sem nenhum principio, eles funcionam, sim, eu já vi sistemas assim que já mantem empresas por 20 anos, mas seja no custo de manutenção, ou no custo que você tem para evolui-lo, esse preço está sendo pago por alguém, você pode ter certeza.

Construir softwares realmente verdadeiramente duráveis é para poucos, seja um destes!
