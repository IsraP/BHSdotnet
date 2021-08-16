using System;
using System.Collections.Generic;


namespace Model
{
    public partial class Pedido
    {
        public Pedido()
        {
            Itens = new HashSet<Item>();
        }

        public Pedido(int codigo, string descricao, DateTime datapedido, decimal valorpedido, string status)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Datapedido = datapedido;
            this.Valorpedido = valorpedido;
            this.Status = status;
        }

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public DateTime Datapedido { get; set; }

        public decimal Valorpedido { get; set; }

        public string Status { get; set; }

        public virtual ICollection<Item> Itens { get; set; }
    }
}
