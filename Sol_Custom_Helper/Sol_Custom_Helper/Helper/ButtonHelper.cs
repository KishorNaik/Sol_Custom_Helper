using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sol_Custom_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Sol_Custom_Helper.Models.ButtonModel;

namespace Sol_Custom_Helper.Helper
{
    public static class ButtonHelper
    {
        public async static Task<IHtmlContent> ButtonAsync(this IHtmlHelper htmlHelper, string id, string value, string cssClass, ButtonType buttonType)
        {
            try
            {
                var buttonModel = new ButtonModel()
                {
                    Id = id,
                    Value = value,
                    CssClassName = cssClass,
                    Type = buttonType
                };

                return await htmlHelper.PartialAsync("~/Views/Shared/_Button.PartialView.cshtml",buttonModel);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
