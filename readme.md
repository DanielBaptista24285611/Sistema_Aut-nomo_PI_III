# King Me!
![Image](https://github.com/user-attachments/assets/19667848-d171-4a9e-b2e0-1cba845a8c3c)
 Jogo de tabuleiro desenvolvido no pi da faculdade..

## 💻Sobre o Projeto
King Me! é  um jogo que mescla elementos de estratégia, blefe e movimento tático, imergindo os jogadores em um cenário fictício onde devem conduzir personagens por um castelo até a posição mais elevada, o trono. Durante o jogo, os jogadores precisam não só manipular peças de maneira inteligente, mas também enganar seus adversários através de votos e escolhas estratégicas, criando uma experiência dinâmica e imprevisível.
 

## 📝 Funcionamento do Jogo
O jogo pode ser jogado por  2 a 6 jogadores, onde cada um deve movimentar personagens dentro de um castelo, tentando promover seus aliados à posição mais alta (o trono) enquanto manipula votos e toma decisões com base nas ações dos outros jogadores. O jogo ocorre ao longo de três rodadas, sendo cada uma composta de diferentes fases e mecânicas, sendo composto pelo nivel 0, 1, 2, 3, 4, 5 e 10.

### Inicio do Jogo
No começo de cada rodada, cada jogador recebe uma carta. Essa carta lista 6 dos 13 personagens disponíveis no jogo e define o objetivo do jogador: levar esses personagens para a posição mais alta possível no castelo, sem eliminá-los. Após isso os jogadores começam a colocar seus personagens no castelo. Cada jogador coloca de 2 a 4 personagens (dependendo do número de participantes) em níveis específicos do castelo  do nível 1 ao nível 4, podendo ser 3 personagens por nível, sendo que o nível 0 serve para o ultimo personagem colocado.

### Promoção de Personagem
A cada turno, um jogador move um personagem para cima um nível, lembrando que cada nível só pode conter 3 personagens.

### Votação
Se um personagem for promovido do nível 5 (nível dos Nobres) para o nível 10 (a sala do trono), uma votação para rei será iniciada. Cada jogador terá 1 voto "Sim"  e dois votos "Não". 

Cada jogador escolhe uma de suas cartas de voto e a joga. Quando todas as cartas forem jogadas, todas são reveladas. Se houver pelo menos um voto "Não", o candidato a rei é removido do tabuleiro. Após uma votação sem sucesso, os jogadores recebem de volta seus votos "Sim", mas não seus votos "Não". Se todos os votos forem Sim, o personagem se torna monarca e a rodada atual do jogo termina.

### Fim da Rodada
Para cada personagem que tiver alcançado uma posição no castelo, o jogador recebe pontos correspondentes ao nível do castelo em que o personagem está localizado. O personagem no nível 10 (o rei) vale 10 pontos, no nível 5 vale 5 pontos, no 4 vale 4 pontos e assim por diante.

Se ainda houver rodadas adicionais a serem jogadas, cada jogador recebe de volta todas as suas cartas de voto Não e escolhe aleatoriamente uma nova carta de objetivo secreto.

### Fim do Jogo
Após três rodadas, o jogo termina. O jogador com o maior número de pontos acumulados é declarado vencedor. Contudo, existe uma regra especial na terceira rodada: se todos os personagens de um jogador forem eliminados, esse jogador recebe 33 pontos extras.

# 📋 Comandos para dar o fork do Projeto
1) Faça um Fork deste Repositório
Acesse a página principal do repositório e clique no botão "Fork" no canto superior direito da página.

2) Clone localmente
Abra o seu Git Bash e digite o comando git clone seguido da URL do seu fork para clonar o seu repositório localmente. Pressione enter, e uma cópia do seu fork no GitHub será criada localmente.

3) use o comando git remote add upstream `https://github.com/IsaiasdeOliveira/Teste.git` para ligar a atualizaçoes do repositorio principal e digite a seguir git remote -v para ver os repositorios.

4) de  `git pull` upstream main para atualizar cada atualização.

5) crie uma branch local com o comando  `git checkout -b nomedabranch`

6) de `git add`. na pasta do arquivo que quer adicionar

7) faça `git commit -m "nomedocommit"`

8) e por ultimo de `git push origin nomedabranchlocal`

9) no github crie um pull request para mandar a atualizaçao do codigo 

# 📌 Links úteis

 [Comandos Git](https://github.com/digitalinnovationone/dio-lab-open-source/blob/main/utils/git/COMANDOSGIT.md)

[Linguagem de marcação](https://github.com/digitalinnovationone/dio-lab-open-source/blob/main/utils/markdown/sintaxes_marcacao.md)

[Site para fazer readme](https://readme.so/pt)
