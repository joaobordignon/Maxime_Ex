using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Maxime.Entities
{
    public class Registradora
    {
        private double total;

        public void AddProduto(Produto produto)
        {
            Console.WriteLine($"{produto.Codigo}/{produto.Modelo}-{produto.Marca}:  Preco com impostos - {produto.Valor + produto.ImpostoFederal}");
            total = total + produto.Valor + produto.ImpostoFederal;
        }

        public double GetTotal()
        {
            return total;
        }

        public string GetNomeDoProduto(Produto produto)
        {
            return produto.Codigo+"/"+produto.Modelo+"-"+produto.Marca;
        }
    }


    
}
