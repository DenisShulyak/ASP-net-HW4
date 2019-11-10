using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationHW4.DataAccess
{
    public class NewsInitializer : CreateDatabaseIfNotExists<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            context.Articles.Add(
                new Article
                {
                    PathImg = "",
                    Description = "It's my first record) I'm first!!!"
                });

            }
    }
}