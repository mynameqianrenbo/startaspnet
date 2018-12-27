using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ArticleService:IArticleService
    {
        private readonly List<Article> _list;
         public ArticleService()
        {
           _list=new List<Article>()
           {
               new Article(){ ID=1, Title = "AAAAA", Summary = "AAAAAA"},
               new Article(){ ID=2, Title = "BBBB", Summary = "BBBB"},
               new Article(){ ID=3, Title = "CCCCC", Summary = "CCCCC"},
               new Article(){ ID=4, Title = "CDDDDDD", Summary = "CDDDDDD"},
           };
        }
        public List<Article> GetList()
        {
            return _list;
        }

        public Article GetById(int Id)
        {
            return _list.Find(m => m.ID == Id);
        }

        public void Add(Article article)
        {
            int maxId = _list.Max(m => m.ID);
            article.ID = maxId;
            _list.Add(article);
        }

        public void Edit(Article article)
        {
           var oldArc=_list.Find(m => m.ID == article.ID);
           oldArc.Summary = article.Summary;
           oldArc.Title = article.Title;
        }

        public void Delete(int id)
        {
            _list.RemoveAll(m => m.ID == id);
        }
    }
}
