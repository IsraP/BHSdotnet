using System.Collections.Generic;
using Model;

namespace Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        bool SaveChanges();

        IEnumerable<Pedido> getAllPedidos(int page);

        IEnumerable<Pedido> getPedidosWithQuery(string query, int page);

        Pedido getPedidoById(int codigo);

        bool RemovePedido(Pedido pRemove);

        bool RestorePedido(Pedido pRestore);

        int getLastCodigoPedido();
        int getLastCodigoItem();

        IEnumerable<Item> getAllItens(int page);

        IEnumerable<Item> getItensWithQuery(string query, int page);

        Item getItemById(int codigo);

    }
}