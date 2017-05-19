using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace GeekStore.UI.Extensions
{
    public static class ProductViewComponent
    {
        public static ProductViewExtension<TModel> ProductExtension<TModel>(this HtmlHelper<TModel> helper, TModel product)
        {
            return new ProductViewExtension<TModel>(helper, product);
        }
    }

    public class ProductViewExtension<TModel>
    {
        private readonly HtmlHelper<TModel> _helper;
        private readonly object _product;
        //private object p;

        public ProductViewExtension(HtmlHelper<TModel> helper, TModel product)
        {
            _helper = helper;
            _product = product;
        }

        public MvcHtmlString Build()
        {
            IList<PropertyInfo> properties = _product.GetType().GetProperties();
            var listOfProperties = new TagBuilder("dl");
            foreach(var property in properties)
            {
                var propertyDescription = new TagBuilder("dt") { InnerHtml = _helper.DisplayName(property.Name).ToString() };
                var propertyValue = new TagBuilder("dd") { InnerHtml = _helper.Display(property.GetValue(_product).ToString()).ToString() };
                listOfProperties.InnerHtml += propertyDescription;
                listOfProperties.InnerHtml += propertyValue;
            }
            return new MvcHtmlString(listOfProperties.ToString());
        }
    }
}