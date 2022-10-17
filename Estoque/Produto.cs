using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque{
    public class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
           return  Preco * Quantidade;            
        }   
        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }     

        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }
        
        public override string ToString(){
            return  Nome + " na quantidade de " 
            + Quantidade + " unidades "
            + "ao preço unitario de R$ "+ Preco.ToString("F2",CultureInfo.InvariantCulture) + " com o valor total em estoque de $" 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }
        
    }
}
