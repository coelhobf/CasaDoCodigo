using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; private set; }
        public decimal Total
        {
            get
            {
                return Itens.Sum(i => i.SubTotal);
            }
        }

        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }
    }
}