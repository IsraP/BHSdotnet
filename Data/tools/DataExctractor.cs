using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Model;

namespace Data.tools
{
    public class DataExtractor
    {
        private List<Pedido> PedidosExtract { get; set; }
        private List<Item> ItensExtract { get; set; }

        public DataExtractor()
        {
            PedidosExtract = new List<Pedido>();
            ItensExtract = new List<Item>();
        }

        public void extractFile(string filename)
        {
            StreamReader fs = new StreamReader(@filename);
            StreamWriter fsItens = new StreamWriter(@"ExtracaoItens.txt");
            StreamWriter fsPedidos = new StreamWriter(@"ExtracaoPedidos.txt");

            string line;

            while (fs.Peek() >= 0)
            {
                line = fs.ReadLine();
                if (line[0] == '1')
                    fsPedidos.WriteLine(line);
                else
                    fsItens.WriteLine(line);
            }

            fs.Close();
            fsItens.Close();
            fsPedidos.Close();
        }


        public List<Item> getItens(string filename)
        {
            FileStream fs = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                br.ReadChar();
                ItensExtract.Add(readItem(br));
                br.ReadChar();
            }

            fs.Close();
            br.Close();

            return ItensExtract;
        }

        public Item readItem(BinaryReader br)
        {
            char[] aux;
            Item it = new Item();

            aux = br.ReadChars(5);
            it.Codigo = int.Parse(aux);

            aux = br.ReadChars(5);
            it.Codigopedido = int.Parse(aux);

            aux = br.ReadChars(50);
            it.Descricao = new string(aux).Trim();

            aux = br.ReadChars(10);
            it.Valoritem = decimal.Parse(new string(aux).Replace(",", "."));

            return it;
        }

        public List<Pedido> getPedidos(string filename)
        {
            FileStream fs = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                br.ReadChar();
                PedidosExtract.Add(readPedido(br));
                br.ReadChar();
            }

            fs.Close();
            br.Close();

            return PedidosExtract;
        }

        public Pedido readPedido(BinaryReader br)
        {
            Pedido pd = new Pedido();
            char[] aux;

            aux = br.ReadChars(5);
            pd.Codigo = int.Parse(aux);

            aux = br.ReadChars(44);
            pd.Descricao = new string(aux).Trim().Substring(0, 40);

            if (br.PeekChar() == ' ')
                br.BaseStream.Position += 1;

            aux = br.ReadChars(14);
            pd.Datapedido = DateTime.ParseExact(new string(aux), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

            aux = br.ReadChars(10);
            pd.Valorpedido = decimal.Parse(new string(aux).Replace(",", "."));

            aux = br.ReadChars(1);
            pd.Status = new string(aux);

            return pd;
        }
    }
}