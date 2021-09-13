# CleanArchitecture

Neste repositório estou utilizando C# para construir uma arquitetura de projeto que utilize alguns dos conceitos e princípios que Robert Cecil Martin aborda em seu livro intitulado Clean Architecture, ou Arquitetura Limpa em português:

<div style="text-align:center"><img src="https://m.media-amazon.com/images/I/411csr6Nn0L.jpg" /></div>
<br />
<p>
Nesta fase inicial do projeto, estou aplicando desde conceitos mais conhecidos como Inversão de Controle utilizando Injeção de Dependência, como também fazendo a Inversão de Controle utilizando o conceito de AOP (Aspect Oriented Programming) ou (Programação Orientada a Aspectos).
</p>

Mesclando a abordagem de AOP com conceitos da Arquitetura Limpa, desenvolvi uma classe que representa o Interactor descrito no livro, e ela é responsável por atuar como um Proxy Transparente que encapsula todas as execuções da aplicação:

![alt text](https://res.cloudinary.com/practicaldev/image/fetch/s--G_FNRMwu--/c_imagga_scale,f_auto,fl_progressive,h_720,q_auto,w_1280/https://dev-to-uploads.s3.amazonaws.com/uploads/articles/00zocjrfniog06hsbwnr.jpeg)

Esta abordagem ficou interessante, pois com ela pretendo ser capaz de adiar ao máximo decisões de quais tecnologias, banco de dados, e frameworks vamos utilizar no projeto.

Extendendo a utilização das técnicas de AOP, criei um mecanismo de inversão de controle, que disponibiliza Aspectos (Plugins) de Log, Cache, Mappers entre outros, que podem facilmente ser implementados posteriormente no sistema.

Assim sendo, podemos focar no que realmente é importante no início do projeto, principalmente para os nossos Clientes/Stakeholders, que é nada mais nada menos, que a nossa querida Regra de Negócio!

![alt text](https://lh3.googleusercontent.com/proxy/4A7Ov_CuEfy4dMdc03h4dM--nTlXnUhLHBMYhdfR4myqL8VGVQ3bORVj8a6mEaCWiP3c6I8hXK6D2nCfok3ezUAJkIowe6_jP74KVPR-apdRVp949N5g9CI)

Isto é muito aderente a realidade do nosso mercado, ainda mais quando amadurecemos como desenvolvedores/arquitetos de software, pois no final das contas, nosso foco deve ser o desenvolvimento de softwares que Entreguem cada vez mais Valor para os nossos Clientes/Stakeholders e não para nós mesmos, não é verdade?

Desta forma é muito mais fácil entregarmos valor, pois podemos trabalhar mais focados nas entregas evolutivas dos nossos MVPs, deixando decisões mais técnicas para o futuro, quando a viabilidade do produto estiver mais clara.

![alt text](https://blog.jovensprotagonistas.com/wp-content/uploads/2021/04/mvp-minimo-produto-viavel.jpg)

Além disso, no livro Robert Martin descreve alguns exemplos onde ele utilizou a abordagem de plugins, criando uma aplicação inteira sem banco de dados, persistindo as informações diretamente em disco, e no final do projeto ele viu que a abordagem de não utilizar um SGBD seria até melhor para o contexto do seu projeto, e decidiu lançar o produto desta forma.

Adiar este tipo de decisão faz muito sentido, muitas vezes perdermos muito tempo decidindo quais tecnologias vamos utilizar, quais ferramentas, frameworks, banco de dados e etc, e na maioria das vezes decidimos isso de forma totalmente precoce. Quantas vezes somente quando avançamos no desenvolvimento do projeto percebemos que este tipo de decisão acabou não sendo a melhor, e tivemos que reavaliar outras opções que se enquadrassem melhor depois do sistema já mais maduro?

Esta forma de pensar e desenvolver software pode nos poupar um grande esforço inicial tentando ser precisos na escolha, em meio as tantas opções que temos disponíveis:

![alt text](https://www.davrous.com/wp-content/uploads/2018/12/screen001_thumb.jpg)

Como vimos, a abordagem de AOP nos ajuda bastante a adiar algumas decisões até o momento que tenhamos mais segurança para toma-las, e também ajuda com que nossas aplicações fiquem desacopladas e plugáveis, pois muitas vezes quando decidimos por utilizar um determinado framework logo no início, acabamos amarrando a aplicação a ele, e quando precisamos mudar de ideia acabamos tendo que refatorar muita coisa.

Eu também achei interessante o livro, pois Robert Martin fala muito mais sobre conceitos e princípios, ele não nos da uma receita de bolo de como podemos aplicar de forma prática a arquitetura limpa em nossos projetos, isto é interessante, pois podemos utilizar os vários padrões arquiteturais, design patterns, e mescla-los em nossas soluções de acordo com a necessidade de cada projeto.

Desta forma, pretendo explorar outros conceitos como CQRS, Agregadores do DDD entre outras abordagens.

O projeto ainda está em construção e pretendo ir amadurecendo-o aos poucos, conto com a colaboração de quem estiver a fim de me apoiar nesta empreitada!

E lembre-se, não existe bala de prata no desenvolvimento de software, esta solução que pretendo desenvolver é uma mescla de vários conhecimentos que adquiri durante os meus anos na área de desenvolvimento de software, e minha intenção aqui não é de convencer ninguém de que existe uma arquitetura perfeita que deve ser seguida para todos os projetos.

Quero mostrar que existem conceitos e princípios que independem da forma como construimos nossos softwares, e até de quais linguagens e plataformas utilizamos, se você seguir estes bons conceitos e princípios, tenho certeza de que seus sistemas chegarão muito mais longe do que sistemas que não os seguem.

Já vi muito código construído sem nenhuma boa prática, arquitetura, e sem nenhum princípio, eles funcionam, sim, eu já vi sistemas assim que já duram mais de 20 anos, mas seja no custo de manutenção, ou no custo que você tem para evolui-lo, esse preço está sendo pago por alguém, tenha certeza disso.

E não são só os donos de empresas que pagam este custo, nós também o pagamos, pois muitas vezes somos quase que obrigados a trabalhar de forma incansável além do expediente, algumas vezes sem recebermos um real a mais por isso, para resolver bugs extremamente difíceis de encontrar, e para criar features em softwares completamente acoplados e quase impossíveis de serem mantidos.

Construir softwares verdadeiramente duráveis é para poucos, faça parte deste seleto grupo!
