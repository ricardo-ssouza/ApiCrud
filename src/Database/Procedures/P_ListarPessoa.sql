USE UsandoCrud;

IF OBJECT_ID(N'dbo.P_ListarPessoa', 'P') IS NULL
	EXEC('create proc dbo.P_ListarPessoa as select 1')
GO

ALTER PROCEDURE dbo.P_ListarPessoa
AS
	SELECT
		CodPessoa,
		Nome,
		CpfCnpj,
		Rg,
		DataNascimento,
		Endereco,
		Numero,
		Complemento,
		Cep		
	FROM
		DBO.Pessoa