using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructure.Persistence.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> GetCliente(Guid clienteId)
        {
            Cliente obj =
                await _context.Clientes.Where(o => o.Id == clienteId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);

            /*foreach (var item in cliente.Items)
            {
                await _context.ItemEntregas.AddAsync(item);
            }*/
        }
    }
}
