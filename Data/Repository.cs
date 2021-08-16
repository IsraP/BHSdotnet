using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Pedido> getAllPedidos(int page)
        {
            IQueryable<Pedido> query = _context.Pedidos;

            query = query.AsNoTracking().OrderBy(ped => ped.Status).Include(ped => ped.Itens);

            if (page == 0)
                page++;

            var items = query.Skip((page - 1) * 7).Take(7);

            return items.ToArray();
        }

        public IEnumerable<Pedido> getPedidosWithQuery(string query, int page)
        {
            IQueryable<Pedido> queryP = _context.Pedidos;

            queryP = queryP.Where(ped => ped.Descricao.ToLower().Contains(query.ToLower()));

            if (page == 0)
                page++;

            Console.WriteLine("wat " + page);
            var results = queryP.OrderBy(ped => ped.Status).Skip((page - 1) * 8).Take(8);

            return results;
        }

        public int getLastCodigoPedido()
        {
            IQueryable<Pedido> query = _context.Pedidos;
            int lastCodigo = query.OrderBy(ped => ped.Codigo).Reverse().FirstOrDefault().Codigo; // Identity não foi setado na tabela

            return lastCodigo;
        }

        public Pedido getPedidoById(int codigo)
        {
            Pedido p = _context.Pedidos.Where(ped => ped.Codigo == codigo).FirstOrDefault();

            if (p == null)
            {
                p = new Pedido();
                p.Codigo = -1;
            }

            return p;
        }

        public bool RemovePedido(Pedido pRemove)
        {
            if (pRemove.Codigo != -1)
            {
                pRemove.Status = "E";

                Update(pRemove);

                return true;
            }
            else
                return false;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public IEnumerable<Item> getAllItens(int page)
        {
            IQueryable<Item> query = _context.Itens;

            query = query.AsNoTracking().OrderBy(ped => ped.Codigo);

            var items = query.Skip((page - 1) * 7).Take(7);

            return items.ToArray();
        }

        public IEnumerable<Item> getItensWithQuery(string query, int page)
        {
            IQueryable<Item> queryP = _context.Itens;

            queryP = queryP.Where(ped => ped.Descricao.ToLower().Contains(query.ToLower()));

            if (page == 0)
                page++;

            var results = queryP.OrderBy(ped => ped.Codigo).Skip((page - 1) * 8).Take(8);

            return results;
        }

        public Item getItemById(int codigo)
        {
            Item i = _context.Itens.Where(it => it.Codigo == codigo).FirstOrDefault();

            if (i == null)
            {
                i = new Item();
                i.Codigo = -1;
            }

            return i;
        }

        public int getLastCodigoItem()
        {
            IQueryable<Item> query = _context.Itens;
            int lastCodigo = query.OrderBy(ped => ped.Codigo).Reverse().FirstOrDefault().Codigo; // Identity não foi setado na tabela

            return lastCodigo;
        }
    }
}
