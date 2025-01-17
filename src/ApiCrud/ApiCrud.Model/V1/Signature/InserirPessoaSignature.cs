﻿using ApiCrud.Common.Interfaces.Signature;
using System;

namespace ApiCrud.Model.V1.Signature
{
    public class InserirPessoaSignature : IInserirPessoaSignature
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
    }
}