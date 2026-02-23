-- criar banco de dados
create database alfapdv;

-- utilizar apenas a o banco de dados
use alfServ;

-- cria os usuarios
create user 'alfamaq'@'localhost' identified by '29814608';

-- garante todos os privilegios
grant all privileges on *.* to 'alfamaq'@'localhost';

-- cria tabela ConfiguraServer
-- create table ConfiguraServer()

-- cria tabela categoria
create table Categoria(
cateId int not null primary key,
cateNome varchar(15) not null,
cateSigla varchar(3) not null
);

-- cria tabela sub-categoria
create table SubCategoria(
subCateId int not null primary key,
subCateNome varchar(15) not null,
subCateSigla varchar(3) not null,
CateId int not null,
foreign key (CateId) references Categoria(cateId)
);
-- cria tabela produtos
create table PRODUTO(
prodid int not null primary key, -- PK e id do produto
proddescri varchar(40) not null, -- descricao do produto
prodredescri varchar(16) not null, -- descrição reduzida do produto
prodauxi int(8), -- codigo auxiligar do produto
produnicp int(2) not null, -- codigo do tipo de unidade de compra
prodqutunicp float(8), -- codigo da quantidade que vem em cada unidade de compra
produnivd int(2) not null, -- codigo do tipo de unidade de venda
prodqutnivd float(8) not null, -- codigo da quantidade que vem em cada unidade de venda
prodpre float(8) not null,  -- codigo do valor em R$ de preço da tabela 1
prodofer float(8),  -- codigo do valor em R$ da oferta da tabela 1
prodpre2 float(8), -- codigo do valor em R$ de preço da tabela 2
prodofer2 float(8), -- codigo do valor em R$ da oferta da tabela 2
prodforne int(4),  -- codigo de identificaçaõ do fornecedor
prodestoq int(4), -- qual estoque esta localizado
produniestoq int(5),  -- quantidade de itens em estoque
prodNcm int(8) not null,   -- ncm dele
prNcmAux int(8) not null,  -- ncm auxiliar
prodCate int not null,
prodSubCate int not null,
foreign key (prodCate) references Categoria(cateId),
foreign key (prodSubCate) references SubCategoria(subCateId)
);

-- cria tabela cliente
create table CLIENTE(
cleId int not null primary key, -- PK e id do cliente
cleNome varchar(30) not null, -- nome do cliente
cleEnde varchar(30),-- endereco do cliente
cleEndNum int(5)not null, -- numero do endereco do cliente
cleMail varchar(25), -- email do cliente
cleTele int(11)not null, -- telefone do cliente
cleCpfCNPJ int(14) not null -- CPF/CNPJ do cliente
);

-- cria tablea proprio
create table Empresa(
empId int not null primary key, -- PK e id do Proprio
empNome varchar(30) not null, -- nome no sintegra
empFan varchar(20)not null, -- fantasia no sintegra
empCpfCNPJ int(14) not null,  -- CPF ou CNPJ da empresa
empEnde varchar(30) not null, -- nome endereço rua ou avenida
empEndeNum int(5)not null, -- numero do endereço
empCep int(8) not null, -- cep da empresa
empTipo int(1) not null,-- tipo da empresa, exemplo juridico ou fisico
empTele int(11) not null -- numero do telefone da empresa
);

-- cria tabela funcionario
create table funcionario(
funId int not null primary key, -- PK e id do funcionario
funNome varchar(30) not null, -- nome do funcionario
funCpf varchar(11)not null, -- cpf do funcionario
funSenha varchar(15) default null, -- senha do funcionario
funEnd varchar(30) default null, -- endereço do funcionario
funEndNum int(5)default null, -- numero do endereço do funcionario
funTele int(11)default null, -- numero de telefone
funCargo int(3) not null, -- cargo do funcionario
funMail varchar(25)default null, -- email do funcionmario
funDataEnt int(12) not null, -- data de entrada do funcionario
funDataSai int(12)default null, -- data de saida
funAtive char(1) default null -- verifica se funcionario esta ativo 
);

-- cria tabela fornecedor
create table Fornecedor(
forneId int not null primary key,
forneNome varchar(30) not null,
forneCpfCnpj int(14) not null,
forneEnd varchar(30),
forneEndNum int(5) not null,
forneMail varchar(25),
forneDataCad int(12) not null,
forneDataSai int(12),
forneTrans char(1),
forneAtive char(1),
forneProd int not null,
foreign key (forneProd) references Produto(prodid)
);

-- cria tabela especie
create table Especie( 
espeID int not null primary key, -- PK e id da especie
espeNome varchar(10) not null, -- nome da especie
espeDescri varchar(15), -- descrição da especie
espeSig varchar(3) not null, -- sigla da especie
espeNfe int(2) not null -- numero da nfw
);

-- cria tabela finalizadora
create table Finalizadora(
finaId int not null primary key, -- PK e id da finalizado
finaNome varchar(10) not null, -- nome da finalizadora
finaDescri varchar(15), -- descrição da finalizadora
finaTipo int(3) not null, -- tipo de finalizadora
finaAgen int(3) not null, -- agente financeiro da finalizadora
finaEspe int not null, -- cria int para FK
foreign key BuscarEspecie(finaEspe) references Especie(espeId) -- fk para busca o id da especie
);

-- cria tabela pedido
create table Pedido(
idPe int not null primary key,
idClie int not null, 
idProd int not null,
idFun int not null,
peFina int not null,
peQuan float(5) not null,
peEntra varchar(10) not null,
foreign key (idClie) references Cliente(cleId),
foreign key (idProd) references Produto(prodid),
foreign key (idFun) references Funcionario(funId),
foreign key (peFina) references Finalizadora(finaId)
);

-- cria tabela HistoricoPedido
create table HistoricoPedido(
hisPeId int not null primary key,
peId int not null,
funId int not null,
finaId int not null,
cliId int not null,
foreign key (peId) references Pedido(idPe),
foreign key (funId) references Funcionario(funId) ,
foreign key (finaId) references Finalizadora(finaId),
foreign key (cliId) references Cliente(cleId)
);




