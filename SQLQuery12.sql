create database CINEPROXY

CREATE TABLE [dbo].[filme](
	[id] [int] NOT NULL,
	[titulo] [varchar](20) NULL,
	[duracao] [varchar](20) NULL,
	[lancamento] [varchar](20) NULL,
	[genero] [varchar](20) NULL,
	[classificacao] [varchar](20) NULL,
	[imagem] [varchar](1000) NULL,
	[sinopse] [varchar](1500) );


create table cliente(
id int,
nome varchar(50),
fk_sexo int,
cpf varchar(20),
datanasci date,
ativo bit,
email varchar (50),
telefone varchar (20))


