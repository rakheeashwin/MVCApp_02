using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_02.Infrastructure
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString EditButtonHelper(this HtmlHelper html, string controller,string action, string data)
        {
            TagBuilder tag = new TagBuilder("a");
            tag.MergeAttribute("href", "/" + controller + "/" + action + "/" + data);
            tag.InnerHtml = "<img src='/Images/edit.PNG' alt='image' width=30 height=30/>";
            tag.AddCssClass("btn btn-default btn-sm");
            return MvcHtmlString.Create(tag.ToString());
        }
    }
}