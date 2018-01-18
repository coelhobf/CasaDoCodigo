using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.ViewModels;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }
        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            
            //List<Produto> produtos = this._dataService.GetProdutos();
            var produtos = this._dataService.GetProdutos();
            var itensCarrinho = this._dataService.GetItensPedido();
            var viewModel = new CarrinhoViewModel(itensCarrinho);

            return viewModel;
        }

        public IActionResult Carrossel()
        {
            //List<Produto> produtos = _dataService.GetProdutos();
            var produtos = _dataService.GetProdutos();
            return View(produtos);
        }
        public IActionResult Carrinho()
        {
            //CarrinhoViewModel viewModel = GetCarrinhoViewModel();
            var viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }
        public IActionResult Resumo()
        {
            var viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }
    }
}