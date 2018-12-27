﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IArticleService
    {
        List<Article> GetList();
        Article GetById(int Id);
        void Add(Article article);
        void Edit(Article article);
        void Delete(int Id);
    }
}
