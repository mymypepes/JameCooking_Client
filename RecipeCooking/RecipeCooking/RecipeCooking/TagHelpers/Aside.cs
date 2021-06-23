using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JameCooking.TagHelpers
{
    [HtmlTargetElement("aboutus", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class Aside : TagHelper
    {
        [ViewContext]
        public ViewContext viewContext { get; set; }

        private IHtmlHelper HtmlHelper;

        public Aside(IHtmlHelper htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (HtmlHelper as IViewContextAware).Contextualize(viewContext);

            output.TagName = "";
            output.Content.SetHtmlContent(await HtmlHelper.PartialAsync("TagHelpers/AboutUs"));
        }
    }
}
