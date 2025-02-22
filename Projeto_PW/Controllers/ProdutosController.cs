﻿using Microsoft.AspNetCore.Mvc;
using Projeto_PW.Models;
using System.Collections.Generic;

namespace Projeto_PW.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<ProdutoModel> lsProdutos = new List<ProdutoModel>();
        public IActionResult Index()
        {
            ProdutoModel produto = new ProdutoModel();
            produto.Descricao = "Mouse Gamer";
            produto.Codigo = 2538;
            lsProdutos.Add(produto);
            return View(lsProdutos);
        }

        public IActionResult Create()
        {
            return View(lsProdutos);
        }

        [HttpPost]
        public IActionResult Create(ProdutoModel produto)
        {
            return View();
        }
    }
}
