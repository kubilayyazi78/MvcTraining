using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorSyntax.HtmlHelpers
{
    public static class ButtonHelpers 
    {
     /*   public static MvcHtmlString Submit (this HtmlHelper helper,string text)
        {
            var tagBuilder = new TagBuilder("button");
            tagBuilder.InnerHtml = text;

            tagBuilder.MergeAttribute("type", "submit");
            tagBuilder.MergeAttribute("class", "btn btn-primary pull-right");

            return MvcHtmlString.Create(tagBuilder.ToString());
        }
        */
        public static MvcHtmlString Submit(this HtmlHelper helper, string text,object htmlAttributes)
        {
            var tagBuilder = new TagBuilder("button");
            tagBuilder.InnerHtml = text;

            tagBuilder.MergeAttribute("type", "submit");
            //tagBuilder.MergeAttribute("class", "btn btn-primary pull-right");
            tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return MvcHtmlString.Create(tagBuilder.ToString());
        }
    }
}