#pragma checksum "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bc7280c3c1f4b06ce60d36d13965331df47ca8"
// <auto-generated/>
#pragma warning disable 1591
namespace Cotoso_Craft_Like_Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
using Cotoso_Craft_Like_Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
using Cotoso_Craft_Like_Web.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
 foreach (var product in productService.GetProducts())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-group");
            __builder.AddAttribute(3, "style", "background-image:url(" + (
#nullable restore
#line 9 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
                                                         product.Image

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "h2");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
             product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-footer");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "small");
            __builder.AddAttribute(13, "class", " text-muted");
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
                              (e=>SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "data-toggle", "model");
            __builder.AddAttribute(18, "data-target", "#productModel");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddMarkupContent(20, "\r\n                More Info\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 22 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\31727\source\repos\Cotoso Craft Like Web\Cotoso Craft Like Web\Components\ProductList.razor"
       
    string selectedProductId;
    Product selectedProduct = new Product();
    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = productService.GetProducts().First(x => x.Id == productId);
         
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices productService { get; set; }
    }
}
#pragma warning restore 1591