DROP DATABASE IF EXISTS SacodeCarvao;

CREATE DATABASE SacodeCarvao;
USE SacodeCarvao;

CREATE TABLE PRODUTO (
 idProduto int primary key AUTO_INCREMENT,
 modeloProduto varchar(100) not null,
 descrProduto varchar(1000),
 valorProduto decimal(10,2),
 qtdeMinEstoque int,
 qtdeMaxEstoque int,
 qtdeAtualEstoque int,
 estado char(1) not null
);

CREATE TABLE PEDIDO (
 idPedido int primary key AUTO_INCREMENT,
 idProduto int,
 nomeProduto varchar(100) not null,
 quantidade int,
 valor int,
 FOREIGN KEY idProdut (idProduto) References PRODUTO (idProduto) 
 );

CREATE TABLE COMPONENTE (
 idComponente int primary key AUTO_INCREMENT,
 tipoComponente varchar(100) not null,
 marcaComponente varchar(1000) not null,
 modeloComponente varchar(1000) not null,
 especificacoes varchar(8000),
 qtdeMinEstoque int,
 qtdeMaxEstoque int,
 qtdeAtualEstoque int,
 estado char(1) not null
);

CREATE TABLE PRODUTO_COMPONENTE (
  idProduto int not null,
  idComponente int not null,
  qtdeComponente int not null,
  primary key (idProduto, idComponente)
);

ALTER TABLE PRODUTO_COMPONENTE 
ADD CONSTRAINT FK_PRODCOMP_PRODUTO
FOREIGN KEY (idProduto) REFERENCES PRODUTO(idProduto);

ALTER TABLE PRODUTO_COMPONENTE 
ADD CONSTRAINT FK_PRODCOMP_COMPONENTE
FOREIGN KEY (idComponente) REFERENCES COMPONENTE(idComponente);

CREATE TABLE FORNECEDOR (
 idFornecedor int primary key AUTO_INCREMENT,
 nome varchar(100) not null,
 logradouro varchar(150),
 numero varchar(30),
 complemento varchar(50),
 cep char(8) not null,
 telefone varchar(20) not null,
 celular varchar(20),
 email varchar(30),
 urlSite varchar(100)
);

CREATE TABLE FORNECEDOR_COMPONENTE (
  idFornecedor int not null,
  idComponente int not null,
  leadTime int,
  custo decimal(10,2),
  primary key (idFornecedor, idComponente)
);

ALTER TABLE FORNECEDOR_COMPONENTE 
ADD CONSTRAINT FK_FORNCOMP_FORNECEDOR
FOREIGN KEY (idFornecedor) REFERENCES FORNECEDOR(idFornecedor);

ALTER TABLE FORNECEDOR_COMPONENTE 
ADD CONSTRAINT FK_FORNCOMP_COMPONENTE
FOREIGN KEY (idComponente) REFERENCES COMPONENTE(idComponente);

CREATE TABLE MOVIMENTACAO_PRODUTO (
  idMovProduto int primary key AUTO_INCREMENT,
  dataMov date not null,
  tipoMov char(1) not null,
  qtdeMov int not null,
  idProduto int not null
);

ALTER TABLE MOVIMENTACAO_PRODUTO 
ADD CONSTRAINT FK_MOVPROD_PRODUTO
FOREIGN KEY (idProduto) REFERENCES Produto(idProduto);

CREATE TABLE MOVIMENTACAO_COMPONENTE (
  idMovComponente int primary key AUTO_INCREMENT,
  dataMov date not null,
  tipoMov char(1) not null,
  qtdeMov int not null,
  idComponente int not null
);

ALTER TABLE MOVIMENTACAO_COMPONENTE
ADD CONSTRAINT FK_MOVCOMP_COMPONENTE
FOREIGN KEY (idComponente) REFERENCES COMPONENTE(idComponente);

CREATE TABLE BOM(
idBom int PRIMARY KEY AUTO_INCREMENT,
noProduto int,
noPai int NULL,
codigoLista int,
nome varchar(20),
nivel int,
quantidadeLista int
);

CREATE TABLE MRP (
 idMRP int PRIMARY KEY AUTO_INCREMENT,
 idPedido int,
 idProduto int,
 nome varchar(50),
 quantidadePedido int,
 quantidadeEstoque int,
 quantidadeFinal int,
 FOREIGN KEY idPed (idPedido) REFERENCES PEDIDO (idPedido)
);

CREATE TABLE REQUISICAOCOMPRA (
 idReqCompra int PRIMARY KEY AUTO_INCREMENT,
 idProduto int,
 nomeProduto varchar(100),
 quantidade int,
 FOREIGN KEY idProduto (idProduto) REFERENCES PRODUTO(idProduto)
 );
 
CREATE TABLE USUARIO (
  idUsuario int primary key AUTO_INCREMENT,
  nomeUsuario varchar(100) not null,
  senhaUsuario varchar(30) not null,
  acessoUsuario varchar(30) not null
);

-- INSERTS
INSERT INTO PRODUTO (
  modeloProduto, descrProduto, valorProduto,
  qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado
) VALUES
  ('Notebook A3', 'Notebook A3 A315-33-C58D Intel Celeron N3060 15,6" 4GB HD 500 GB Linux', 2899, 50, 500, 100, 'P'),
  ('Notebook S145', 'Notebook S145 81WT0006BR Intel Celeron N4020 15,6" 4GB SSD 128 GB Windows', 1899.00, 20, 50, null, 'P'),
  ('Notebook P', 'Notebook P Motion Plus Q464B Intel Atom 14" 4GB eMMC', 4500, 20, 100, null, 'D'),
  ('Notebook S', 'Notebook S Book E20 NP550XCJ-KO2BR Intel Celeron 5205U 15,6" 4GB HD 500 GB', 2420.50, 200, 500, 120, 'P');

INSERT INTO COMPONENTE (
  tipoComponente, marcaComponente, modeloComponente, especificacoes,
  qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado
) VALUES 
  ('Processador','Intel', 'Celeron N3060', null, 100, 1000, 200, 'P'),
  ('Processador','Intel', 'Celeron N4020', null, 100, 800, 300, 'P'),
  ('Processador','Intel', 'Core i5 1035G1', null, 100, 1100, 110, 'D'),
  ('Processador','Intel', 'Core i3 10110U', null, 80, 720, 100, 'P'),
  ('Processador','Intel', 'Core i5 9300H', null, 100, 1000, 200, 'P'),
  ('HD', 'Seagate', '500 GB', null, 10, 500, 80, 'P'),
  ('HD', 'ASUS', '1 TB', null, 100, 1000, 200, 'P'),
  ('SSD', 'Crucial', '500 GB', null, 100, 1000, 200, 'P'),
  ('Memória RAM', 'Kingston', '4 GB', null, 100, 1000, 200, 'M'),
  ('Memória RAM', 'Spectrix', '8 GB', null, 100, 1000, 200, 'P');

INSERT INTO PRODUTO_COMPONENTE VALUES 
  (1,  1, 1) ,(1,  6, 1) ,(1,  9, 1),
  (2,  2, 1) ,(2,  6, 1) ,(2,  9, 1),
  (3,  2, 1) ,(3,  9, 2) ,(3, 10, 1),
  (4,  2, 1) ,(4,  7, 1) ,(4,  9, 1);

INSERT INTO FORNECEDOR (
  nome, logradouro, numero, complemento, cep, telefone, celular, email, urlSite
) VALUES 
  ('MaxFix','Rua Lúcia Mormito Biason', '204', null, '09370835', '11 4544-1600', null, 'vendas@maxfix.ind.br', 'https://maxfix.ind.br'),
  ('Baú da Eletrônica','AV. DOUTOR RAMOS DE AZEVEDO', '159', 'SALA 908', '07012020', '11 2442-6600', null, 'vendas@baudaeletronica.com.br', 'https://www.baudaeletronica.com.br');

INSERT INTO USUARIO (
  nomeUsuario, senhaUsuario, acessoUsuario
) VALUES
  ('gatinhodoestoque18', '123456', 'Estoque'),
  ('admin', 'admin', 'Administracao');

USE SacodeCarvao;
DROP USER IF EXISTS 'SacodeCarvao'@'localhost';
CREATE USER 'SacodeCarvao'@'localhost' IDENTIFIED BY 'SacodeCarvao';
GRANT ALL ON *.* TO 'SacodeCarvao'@'localhost';
FLUSH PRIVILEGES;