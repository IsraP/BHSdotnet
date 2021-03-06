using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Item
    {
        public Item() { }

        public Item(int codigo, int codigopedido, string descricao, decimal valoritem)
        {
            this.Codigo = codigo;
            this.Codigopedido = codigopedido;
            this.Descricao = descricao;
            this.Valoritem = valoritem;

        }

        public int Codigo { get; set; }

        public int? Codigopedido { get; set; }

        [MaxLength(50)]
        public string Descricao { get; set; }

        public decimal Valoritem { get; set; }

        public virtual Pedido CodigopedidoNavigation { get; set; }
    }
}
