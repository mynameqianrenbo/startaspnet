using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.ViewComponents111
{
    public class ArticleCountViewComponent:ViewComponent
    {
        private readonly IArticleService _service;

        public ArticleCountViewComponent(IArticleService service)
        {
            _service = service;
        }
        public IViewComponentResult Invoke(int init=0)
        {
            int count = _service.GetList().Count();
            return View(count+init);
        }
    }
}
