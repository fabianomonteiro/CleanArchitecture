# Clean Architecture

Neste repositório estou utilizando C# para construir uma arquitetura de projeto que faça uso de alguns dos conceitos e princípios que Robert Cecil Martin aborda em seu livro intitulado Clean Architecture, ou Arquitetura Limpa em português:

<div style="text-align:center"><img src="https://m.media-amazon.com/images/I/411csr6Nn0L.jpg" /></div>
<br />
<p>
Nesta fase inicial do projeto, estou aplicando desde conceitos mais conhecidos como Inversão de Controle utilizando Injeção de Dependência, como também fazendo a Inversão de Controle utilizando o conceito de AOP (Aspect Oriented Programming) ou (Programação Orientada a Aspectos).
</p>

Mesclando a abordagem de AOP com conceitos da Arquitetura Limpa, desenvolvi uma classe que representa o Interactor descrito no livro, e ela é responsável por atuar como um Proxy Transparente que encapsula todas as execuções da aplicação:

![alt text](https://res.cloudinary.com/practicaldev/image/fetch/s--G_FNRMwu--/c_imagga_scale,f_auto,fl_progressive,h_720,q_auto,w_1280/https://dev-to-uploads.s3.amazonaws.com/uploads/articles/00zocjrfniog06hsbwnr.jpeg)

Esta abordagem ficou interessante, pois com ela pretendo ser capaz de adiar ao máximo decisões de quais tecnologias, banco de dados, e frameworks vamos utilizar no projeto.

Estendendo a utilização das técnicas de AOP, criei um mecanismo de inversão de controle, que disponibiliza Aspectos (Plugins) de Log, Cache, Mappers entre outros, que podem facilmente ser implementados posteriormente no sistema.

Assim sendo, podemos focar no que realmente é importante no início do projeto, principalmente para os nossos Clientes/Stakeholders, que é nada mais nada menos, que a nossa querida Regra de Negócio!

![alt text](https://global-uploads.webflow.com/6046bc2da84ac5553b1fa71a/6061de485239533e653d461d_Blog-Clapping-hands.jpeg)

Isto é muito aderente a realidade do nosso mercado, ainda mais quando amadurecemos como desenvolvedores/arquitetos de software, pois no final das contas, nosso foco deve ser o desenvolvimento de softwares que Entreguem cada vez mais Valor para os nossos Clientes/Stakeholders e não para nós mesmos, não é verdade?

Desta forma é muito mais fácil entregarmos valor, pois podemos trabalhar mais focados nas entregas evolutivas dos nossos MVPs, deixando decisões mais técnicas para o futuro, quando a viabilidade do produto estiver mais clara.

![alt text](https://blog.jovensprotagonistas.com/wp-content/uploads/2021/04/mvp-minimo-produto-viavel.jpg)

Além disso, no livro Robert Martin descreve alguns exemplos onde ele utilizou a abordagem de plugins, criando uma aplicação inteira sem SGBD, persistindo as informações diretamente em disco focando na regra de negócio e em ter mais velocidade de desenvolvimento, no final do projeto ele viu que a abordagem de não utilizar um SGBD seria melhor para o contexto do seu projeto, e decidiu lançá-lo desta forma.

Adiar este tipo de decisão faz muito sentido, muitas vezes perdermos muito tempo decidindo quais tecnologias vamos utilizar, quais ferramentas, frameworks, banco de dados e etc, e perdemos o timing do produto.

Quantas vezes somente quando avançamos no desenvolvimento do projeto percebemos que acabamos caindo na armadilha de definir estas coisas no início do projeto, e depois conforme o tempo passou e tivemos mais clareza, enxergamos a necessidade de reavaliar outras opções que se enquadrassem melhor com a ideia mais amadurecida?

Esta forma de pensar e desenvolver software pode nos poupar um grande esforço inicial tentando ser precisos na escolha, em meio as tantas opções que temos disponíveis:

![alt text](https://pbs.twimg.com/media/CHEa_7SXAAAAX1U.png)

Como vimos, a abordagem de AOP nos ajuda bastante a adiar algumas decisões até o momento que tenhamos mais segurança para toma-las, e também nos ajuda no desacoplamento dos nossos sistemas, tornando-os mais plugáveis.

Muitas vezes quando decidimos utilizar um determinado framework logo no início do projeto, acabamos de forma involuntária acoplando o sistema a ele, e quando precisamos mudar de ideia acabamos tendo que refatorar muita coisa.

Eu também achei interessante o livro, pois Robert Martin fala muito mais sobre conceitos e princípios e sobre mesclarmos os diversos paradigmas, arquiteturas e padrões de projeto, criando soluções customizadas a cada contexto de projeto.

Ele não nos da uma receita de bolo de como podemos aplicar de forma prática a arquitetura limpa em nossos projetos, isto é interessante, pois podemos exercer a nossa liberdade criativa.

Desta forma, pretendo explorar outros conceitos como CQRS, Agregadores do DDD entre outras abordagens.

O projeto ainda está em construção e pretendo ir amadurecendo-o aos poucos, conto com a colaboração de quem estiver a fim de me apoiar nesta empreitada!

E lembre-se, não existe bala de prata no desenvolvimento de software, esta solução que pretendo desenvolver é uma mescla de vários conhecimentos que adquiri durante os meus anos na área de desenvolvimento de software, e minha intenção aqui não é de convencer ninguém de que existe uma arquitetura perfeita que deve ser seguida para todos os projetos.

Quero mostrar que existem conceitos e princípios que independem da forma como construímos nossos softwares, e até de quais linguagens e plataformas utilizamos, e se você segui-los, tenho certeza de que seus sistemas chegarão muito mais longe do que sistemas que não o fazem.

Já vi muito código construído sem nenhuma boa prática, arquitetura, e sem nenhum princípio, eles funcionam, sim, eu já vi sistemas assim que já duram mais de 20 anos, mas seja no custo de manutenção, ou no custo que você tem para evolui-lo, esse preço está sendo pago por alguém, tenha certeza disso.

E não são só os donos de empresas que pagam este custo, nós também o pagamos, pois muitas vezes nos tornamos escravos de sistemas mal construídos, tendo que trabalhar de forma incansável além do expediente, algumas vezes sem recebermos um real a mais por isso, para resolver bugs extremamente difíceis de encontrar, e para criar features em softwares completamente acoplados e quase impossíveis de serem mantidos.

Construir softwares com qualidade e que são verdadeiramente duráveis é uma tarefa que poucas pessoas encaram, eu pretendo fazer parte deste grupo de pessoas, e se você já faz parte deste grupo parabéns, se não, o que acha de embarcar nesta jornada de aprendizado também?
