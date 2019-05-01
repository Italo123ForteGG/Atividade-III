CREATE DATABASE dbOficina12
GO
USE dbOficina12
GO
-- DROP DATABASE dbOficina125

CREATE TABLE Cliente (
	codCliente					INT IDENTITY(100,1) PRIMARY KEY ,
	nome						VARCHAR(80),
	cpf							VARCHAR(30),
	cep							VARCHAR(30),
	endereco					VARCHAR(30),
	bairro						VARCHAR(30),
	cidade						VARCHAR(30),
	celular						VARCHAR(30)
	);

CREATE TABLE Usuario(
	codLogin INT IDENTITY(1, 1) PRIMARY KEY,
	ATLogin VARCHAR(30),
	email VARCHAR(80),
	senha VARCHAR(30)
);


CREATE TABLE Veiculo (
	codVeiculo						CHAR(9) PRIMARY KEY,
	Cliente_codCliente				INT,
	Modelo							VARCHAR(20),
	Ano								INT,
	Cor								VARCHAR(20),
	Marca							VARCHAR(20),
	kmAtual							INT,
	Combustivel						VARCHAR(20),
	Observação						VARCHAR(80),			
	FOREIGN KEY(Cliente_codCliente) REFERENCES Cliente (codCliente)
	);


CREATE TABLE Funcionario (
	codFunc							INT PRIMARY KEY,
	Nome							VARCHAR(80),
	Especialidade					VARCHAR(50)
	);

CREATE TABLE OrdemServico (
	codOrdem			INT IDENTITY (1000,1) PRIMARY KEY,
	Veiculo_codVeiculo  CHAR(9),
	nomeCliente			CHAR(30),
	Hora				VARCHAR(5),
	DataEntrada			VARCHAR(10),
	DataSaida			VARCHAR(10),
	TipoServico			VARCHAR(80),
	Funcionario_codFunc	INT,
	ValorServico		FLOAT,
	FOREIGN KEY (Funcionario_codFunc) REFERENCES Funcionario (codFunc),
	FOREIGN KEY(Veiculo_codVeiculo) REFERENCES Veiculo (codVeiculo)
	);
	




INSERT INTO Cliente VALUES ('Ítalo César Silva Olveira','09968595608', '31110340', 'Rua Itabira' ,'Lagoinha', 'Belo Horizonte', 31975706224),
						   ('Arthur José Ricardo Carvalho','08214725874', '39560000','Rua Mendo Correa', 'Centro', 'Salinas', 3891762923  )

INSERT INTO Usuario VALUES ('admin', 'estudantecabhsitalo@gmail.com' ,'123')

INSERT INTO Veiculo VALUES ('GZY-4039',100,'Gol','2018','Prata','Wolksvagwn',600,'Flex',NULL),
						 ('GQB-1168',100,'Uno','2017','Vermelho','Fiat',2000,'Gasolina',NULL),
						 ('GCX-8502',101,'Palio','2005','Preto','Fiat',4680,'Gasolina',NUll)

						 
INSERT INTO Funcionario VALUES  (991,'Rogerio Carvalho','Motor'),
								(992,'Augusto Ferreira','Eletricista'),
								(993,'Paulo Costa','Freio e Suspenção')

INSERT INTO OrdemServico VALUES ('GZY-4039','Paulo Augusto','08:35','2018/08/21','2018/04/08','Baixa Potência',991,350.90),
								('GQB-1168','Priscila Almeida','10:16','2018/08/23','2018/05/03','Ruídos e batidas nas rodas',991,245.10),
								('GCX-8502','Ana Clara','19:40','2018/08/18','2018/02/15','O Veiculo ou pedal vibrar ao pisar no pedal de freio',992,110.50)

SELECT*FROM Cliente 
SELECT*FROM Veiculo
SELECT*FROM OrdemServico
SELECT*FROM Funcionario
SELECT*FROM Usuario