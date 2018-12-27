using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;
        private readonly IOptions<ConnectionOptions> _options;

        public ArticleController(IArticleService service,IOptions<ConnectionOptions> options)
        {
            _service = service;
            _options = options;
        }
        public IActionResult Index()
        {
            var list = _service.GetList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Article article)
        {
            if (ModelState.IsValid)
            {
                _service.Add(article);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            
            return View(_service.GetById(Id));
        }
        [HttpPost]
        public IActionResult Edit(int Id,Article article)
        {
            if (ModelState.IsValid)
            {
                _service.Edit(article);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            _service.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}