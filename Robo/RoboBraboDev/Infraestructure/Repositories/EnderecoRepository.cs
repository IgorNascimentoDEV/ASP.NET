using Domain.Entidades;
using Domain.Interfaces.Repository;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infraestructure.Repositories
{
    internal class EnderecoRepository : IEnderecoRepository
    {
        private readonly BraboDbContext _context;

        public EnderecoRepository(BraboDbContext context)
        {
            _context = context;
        }

        public async Task Add(List<Endereco> enderecos)
        {
            await _context.BulkInsertAsync(enderecos);
        }

        public async Task AtualizarDados(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            await _context.AddRangeAsync();
        }

        public async Task<Endereco?> Get(int id)
        {
            return _context.Enderecos.Where(x => x.Id == id).FirstOrDefault();
        }
         
        public async Task<List<Endereco>> List()
        {
            return _context.Enderecos.ToList();
        }

        public async Task<Endereco?> ObterCepParaTratamento(string robo)
        {
            var cep = _context.Enderecos.Where(x =>

                (x.Status == Domain.Enums.EnumStatus.EmAndamento && x.Robo == robo)
                ||
                (x.Status == Domain.Enums.EnumStatus.Aberto && string.IsNullOrEmpty(x.Robo))
            ).FirstOrDefault();

            return cep;
        }
    }
}
