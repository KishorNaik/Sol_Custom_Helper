using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sol_Custom_Helper.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Custom_Helper.Helper
{
    public static class PersonChoiceHelper
    {
        public async static Task<IHtmlContent> PersonSelectionAsync(this IHtmlHelper htmlHelper,PersonModel person)
        {
            dynamic htmlContent = null;
            try
            {
                if (person != null)
                {
                    if(person.Admin!=null)
                    {
                        htmlContent = await htmlHelper.PartialAsync("~/Views/PersonCustomHelperDemo/PartialViews/_Admin.cshtml", person);
                    }
                    else
                    {
                        htmlContent = await htmlHelper.PartialAsync("~/Views/PersonCustomHelperDemo/PartialViews/_Users.cshtml", person);
                    }
                }
                else
                {
                    htmlContent = await htmlHelper.PartialAsync("~/Views/PersonCustomHelperDemo/PartialViews/_Admin.cshtml", person);
                }

                return htmlContent;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
