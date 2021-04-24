USE UsandoCrud;

IF OBJECT_ID(N'dbo.P_ExcluirPessoa', 'P') IS NULL
	EXEC('create proc dbo.P_ExcluirPessoa as select 1')
GO

ALTER PROCEDURE dbo.P_ExcluirPessoa
(
	@CodPessoa int	
)
AS
	DELETE FROM 
		dbo.Pessoa	
	WHERE
		CodPessoa = @CodPessoa