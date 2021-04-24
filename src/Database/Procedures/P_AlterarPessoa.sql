USE UsandoCrud;

IF OBJECT_ID(N'dbo.P_AlterarPessoa', 'P') IS NULL
	EXEC('create proc dbo.P_AlterarPessoa as select 1')
GO

ALTER PROCEDURE dbo.P_AlterarPessoa
(
	@CodPessoa int,
	@Nome varchar(300),
	@Rg varchar(10),
	@DataNascimento date,
	@Cep varchar(10),
	@Endereco varchar(500),
	@Numero varchar(10),
	@Complemento varchar(30)
)
AS
	UPDATE dbo.Pessoa
	SET
		Nome = @Nome,
		Rg = @Rg, 
		DataNascimento = @DataNascimento, 
		Endereco = @Endereco, 
		Numero = @Numero, 
		Complemento = @Complemento, 
		Cep = @Cep		
	WHERE
		CodPessoa = @CodPessoa
	