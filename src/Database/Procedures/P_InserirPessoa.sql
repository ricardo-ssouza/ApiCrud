USE UsandoCrud;

IF OBJECT_ID(N'dbo.P_InserirPessoa', 'P') IS NULL
	EXEC('create proc dbo.P_InserirPessoa as select 1')
GO

ALTER PROCEDURE dbo.P_InserirPessoa
(
	@CpfCnpj varchar(14),
	@Nome varchar(300),
	@Rg varchar(10),
	@DataNascimento date,
	@Cep varchar(10),
	@Endereco varchar(500),
	@Numero varchar(10),
	@Complemento varchar(30)
)
AS
	INSERT INTO DBO.Pessoa(CpfCnpj, Nome,Rg, DataNascimento, Endereco, Numero, Complemento, Cep, DataCadastro)
	VALUES(@CpfCnpj, @Nome, @Rg, @DataNascimento, @Endereco, @Numero, @Complemento, @Cep, GETDATE())