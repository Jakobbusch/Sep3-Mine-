#pragma checksum "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b74afec2d821dc36a06ad60b701cd9c2135b4bd"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
using SEP3.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createaccount")]
    public partial class CreateAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create a new Account</h3>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h6>Please fill in the following information</h6>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                        CreateAcc

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    \r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-12 row");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label class=\"col-2 font-weight-bold\">Username : </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control col-3");
                __builder2.AddAttribute(15, "placeholder", "username");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                                           user.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.username = __value, user.username))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        &nbsp;");
                __Blazor.SEP3.Pages.CreateAccount.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 21 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                        () => user.username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-12 row");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label class=\"col-2 font-weight-bold\">E-mail : </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control col-3");
                __builder2.AddAttribute(30, "placeholder", "E-mail");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                                           user.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.email = __value, user.email))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        &nbsp;");
                __Blazor.SEP3.Pages.CreateAccount.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 27 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                        () => user.email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-12 row");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label class=\"col-2 font-weight-bold\">Password : </label>\r\n        ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "type", "password");
                __builder2.AddAttribute(45, "class", "form-control col-3");
                __builder2.AddAttribute(46, "placeholder", "password");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                                                 user.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.password = __value, user.password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        &nbsp;");
                __Blazor.SEP3.Pages.CreateAccount.TypeInference.CreateValidationMessage_2(__builder2, 50, 51, 
#nullable restore
#line 33 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                        () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-12 row");
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.AddMarkupContent(57, "<label class=\"col-2 font-weight-bold\">Confirm password : </label>\r\n        ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "password");
                __builder2.AddAttribute(60, "class", "form-control col-3");
                __builder2.AddAttribute(61, "placeholder", "Confirm password");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                                                 confPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confPass = __value, confPass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        &nbsp;");
                __Blazor.SEP3.Pages.CreateAccount.TypeInference.CreateValidationMessage_3(__builder2, 65, 66, 
#nullable restore
#line 39 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
                                        () => confPass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(69, "<div class=\"col-12 row\">\r\n        <span class=\"col-2\"></span>\r\n        <input type=\"submit\" class=\"form-control col-1 btn btn-primary\" value=\"Create Account\">\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\CreateAccount.razor"
       
    public User user;
    [Required]
    string confPass;

    protected override void OnInitialized()
    {
        user = new User();

    }
    public async void CreateAcc()
    {
        if(user.password.Equals(confPass))
        {
            bool temp = await userService.CreateAccAsync(user);
            Console.WriteLine($"*************** Create User ***********" + user);
        }
        else
        {

          // Display notification..
        }
        navManager.NavigateTo("/");
        




    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.CreateAccount
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591