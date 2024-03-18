﻿using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        Task Add(List<EnderecoModel> enderecos);
        Task AtualizarDados(EnderecoModel endereco);
        Task<EnderecoModel> ObterCepParaTratamento(string robo);
        Task<List<EnderecoModel>> List();
    }
}
