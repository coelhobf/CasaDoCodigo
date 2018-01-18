using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo
{
    public interface IDataService
    {
        void InicializaDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}