using Gildo.lojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Gildo.lojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao pagincao, Func<int, string> paginaUrl )
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1 ; i <= pagincao.TotalPagina ; i ++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == pagincao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                tag.AddCssClass("btn-default");
                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());            
        }
    }
}