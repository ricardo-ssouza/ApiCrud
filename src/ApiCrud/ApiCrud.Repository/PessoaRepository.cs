using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ApiCrud.Repository
{
    public class PessoaRepository: IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("defaultConnection");
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            using SqlConnection sql = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.P_InserirPessoa", sql);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CpfCnpj", SqlDbType.VarChar) { Value = signature.CpfCnpj });
            command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar) { Value = signature.Nome });
            command.Parameters.Add(new SqlParameter("@Rg", SqlDbType.VarChar) { Value = signature.Rg });
            command.Parameters.Add(new SqlParameter("@DataNascimento", SqlDbType.Date) { Value = signature.DataNascimento.Date });
            command.Parameters.Add(new SqlParameter("@Cep", SqlDbType.VarChar) { Value = signature.Cep });
            command.Parameters.Add(new SqlParameter("@Endereco", SqlDbType.VarChar) { Value = signature.Endereco });
            command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.VarChar) { Value = signature.Numero });
            command.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.VarChar) { Value = signature.Complemento });

            await sql.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }
    }
}
