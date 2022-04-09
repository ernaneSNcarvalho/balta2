using Balta.ContentContext;
using Balta.ContentContext.Enums;

var articles = new List<Article>();
articles.Add(new Article("Artigo", "artigo"));
articles.Add(new Article("tesge", "aTeste"));
articles.Add(new Article("xpto", "xpto"));

foreach(var article in articles){
    System.Console.WriteLine(article.Id);
    System.Console.WriteLine(article.Title);
    System.Console.WriteLine(article.Url);
}
