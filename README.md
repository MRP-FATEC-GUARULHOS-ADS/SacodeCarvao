# Saco de Carvão

- Unificação de cadastro (peças acabadas e suprimentos/matéria-prima)
- Unificação do Controle de Estoque
- Entrada dos valores de previsão de demanda

## Instruções

### Como baixar o projeto

#### Git
1. Baixe e instale o [Git](https://git-scm.com/downloads) no seu computador.

2. [Configure o Git](https://git-scm.com/book/pt-br/v2/Come%C3%A7ando-Configura%C3%A7%C3%A3o-Inicial-do-Git) com o nome de usuário que quiser e o email que você usou pra se cadastrar no gitHub.

#### mySql
1. Baixe o [MySQL Workbench](https://dev.mysql.com/downloads/workbench/), instale o programa e [configure um servidor](https://www.alura.com.br/artigos/mysql-do-download-e-instalacao-ate-sua-primeira-tabela).

2. Baixe e instale o [conector MySQL/.NET](https://dev.mysql.com/downloads/connector/net/).

3. Abra uma conexão no Workbench e cole o conteúdo do [.sql com o schema do projeto](./Documentação/BancodeDados/MRP-schema.sql) dentro da janela de queries da sua conexão, então execute a query com o botão mostrado na imagem abaixo.

![executando queries mysql](/img/mysql.png)

#### Visual Studio
1. Baixe e instale o [Visual Studio Enterprise 2019](https://azureforeducation.microsoft.com/devtools) usando o seu email institucional.

2. Abra o Visual Studio, escolha a opção clonar um repositório.

![abrindo o VS](/img/vs-git1.jpg)

3. Digite o endereço do projeto na caixa de Local do repositório, escolha a pasta onde o repositório será criado e clique em Clonar.

```shell
https://github.com/MRP-FATEC-GUARULHOS-ADS/SacodeCarvao.git
```

![clonando o repositório](/img/vs-git2.png)

4. Depois de abrir a solução, veja se alguma referência do projeto não foi carregada corretamente (se tiver um símbolo amarelo do lado do nome da referência, ela teve algum problema ao ser carregada).

![erro carregando referências](/img/vs-git6.png)

5. Caso isso aconteça, tente remover a referência e readiciona-la em `Projeto > Adicionar Referência...`, se o problema for no Conector MySql tente instalar a [versão 8.0.21](https://downloads.mysql.com/archives/c-net/), ou então *dá teu jeito cara, sei lá*.

![adicionando referências](/img/vs-gitrefs.png)

Pronto, você já tem acesso ao projeto que a gente tá usando, tomara.

### Mantendo o projeto atualizado
Agora toda vez que editar alguma coisa você deve se certificar que ele esteja atualizado. Pra isso, cheque sempre no canto inferior direito do programa, uma setinha pra cima ↑ (Push) indica que tem mudanças que você fez e ainda não compartilhou, enquanto uma setinha pra baixo ↓ (Pull) indica que tem mudanças online que você ainda não baixou, tenha certeza de sempre estar atualizado (setinha pra cima do lado de um número 0) e na *branch* certa do projeto.

![Team-explorer](/img/vs-git3.jpg)

### Branch certa do projeto???
Se tudo deu certo esse repositório tem 5 *branches*, uma principal e uma pra cada módulo. *Branchs* são versões paralelas do mesmo repositório, que a gente tá usando pra evitar conflito entre contribuições. Se quiser mudar pra *branch* do seu módulo é só escolher no canto inferior direito do Visual Studio, ou só esquece o que eu disse e deixa no `main` mesmo, o importante é contribuir.

### Contribuindo com o projeto
1. Faça as alterações que quiser no projeto e depois abra a aba 'Team Explorer' em `Exibir > Team Explorer`, ou clique no lápis no canto inferior direito do programa, a tela de alterações será aberta, como na imagem abaixo.

2. Digite uma mensagem que expresse suas mudanças de forma clara

3. Clique no '+' e confirme tudo, ou escolha os arquivos ou pastas que quer adicionar e inclua-os separadamente (clicando com o direito no item e escolhendo `Preparar`).

Incluir no commit só os arquivos que você alterou diminui a chance de criar conflitos no Git e te torna uma pessoa melhor, mas tenha certeza de incluir todos os arquivos que você alterou.

![commit](/img/vs-git4.jpg)

4. Clique na seta do canto inferior direito e na aba que se abrir clique em 'Enviar por push'.

![push](/img/vs-git5.jpg)

Pronto, mudança feita, espero que tenha valido a pena.

![e la vamos nos](https://i.pinimg.com/736x/c2/ae/d7/c2aed7f1f926f508b62131115c3e260b.jpg)

## Fazer

### Documentação
- Tudo

### Banco de Dados
- usuarios
- cliente
- todo o resto...

### Desenvolvimento
- Tudo mesmo

### Testes e Padronização
- Tudo de tudo
