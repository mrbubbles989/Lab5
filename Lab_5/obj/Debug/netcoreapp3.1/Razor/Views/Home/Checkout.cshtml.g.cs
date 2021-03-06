#pragma checksum "C:\DC Semesters\Fall 2021\NETD\Lab 5\Lab_5\Lab_5\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392ef06c309c0ded19cb809908d460dbb18eded3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\DC Semesters\Fall 2021\NETD\Lab 5\Lab_5\Lab_5\Views\_ViewImports.cshtml"
using Lab_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DC Semesters\Fall 2021\NETD\Lab 5\Lab_5\Lab_5\Views\_ViewImports.cshtml"
using Lab_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392ef06c309c0ded19cb809908d460dbb18eded3", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84a9bcc92e45f78f75c27d81e83d4a668d44915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\DC Semesters\Fall 2021\NETD\Lab 5\Lab_5\Lab_5\Views\Home\Checkout.cshtml"
  
	ViewData["Title"] = "Checkout";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
	<p>Please note that this is not a real </p>
	<div class=""col-75"">
		<div id=""checkout"" class=""container"">
			<!--A checkout form-->
			<div class=""row"">
				<div class=""col-50"">
					<h3>Checkout</h3>
					<label for=""fname""><i class=""fa fa-user""></i> First Name</label>
					<input type=""text"" id=""fname"" name=""firstName"" placeholder=""John"" />

					<label for=""lname""><i class=""fa fa-user""></i> Last Name</label>
					<input type=""text"" id=""fname"" name=""firstName"" placeholder=""Doe"" />

					<label for=""email""><i class=""fa fa-envelope""></i> Email</label>
					<input type=""text"" id=""email"" name=""email"" placeholder=""john.doe@example.com"" />

					<label for=""adr""><i class=""fa fa-address-card""></i> Address</label>
					<input type=""text"" id=""address"" name=""address"" placeholder=""123 AnyStreet"" />

					<label for=""city""><i class=""fa fa-city""></i> City</label>
					<input type=""text"" id=""city"" name=""city"" placeholder=""Toronto"" />

					<div class=""row"">
						<div class=""col");
            WriteLiteral(@"-50"">
							<label for=""province"">Province</label>
							<input type=""text"" id=""province"" name=""province"" placeholder=""ON"" />
						</div>
						<div class=""col-50"">
							<label for=""postalCode"">Postal Code</label>
							<input type=""text"" id=""postalCode"" name=""postalCode"" placeholder=""M2K 1W9"" />
						</div>
					</div>
				</div>

				<div class=""col-50"">
					<h3>Payment</h3>
					<label for=""fname"">Accepted Cards</label>
					<div class=""icon-container"">
						<i class=""fa fa-cc-visa"" style=""color:navy;""></i>
						<i class=""fa fa-cc-amex"" style=""color:blue;""></i>
						<i class=""fa fa-cc-mastercard"" style=""color:red;""></i>
						<i class=""fa fa-cc-discover"" style=""color:orange;""></i>
					</div>
					<label for=""cname"">Name on Card</label>
					<input type=""text"" id=""cname"" name=""cardName"" placeholder=""John Home Doe"" />

					<label for=""ccnum"">Credit Card Number</label>
					<input type=""text"" id=""ccnum"" name=""cardNum"" placeholder=""1111-2222-3333-4444"" />

					<label for");
            WriteLiteral(@"=""expMonth"">Exp Month</label>
					<input type=""text"" id=""expMonth"" name=""expMonth"" placeholder=""January"" />

					<div class=""row"">
						<div class=""col-50"">
							<label for=""expYear"">Exp Year</label>
							<input type=""text"" id=""expYear"" name=""expYear"" placeholder=""2020"" />
						</div>
						<div class=""col-50"">
							<label for=""cvv"">CVV</label>
							<input type=""text"" id=""cvv"" name=""cvv"" placeholder=""123"" />
						</div>
					</div>
				</div>
			</div>
			<label>
				<input type=""checkbox"" checked=""checked"" name=""sameadr""> Shipping address same as billing
			</label>
			<input type=""submit"" value=""Continue to checkout"" class=""btn"" />
		</div>
	</div>
	<!--The cart that should show the items selected-->
	<div class=""col-25"">
		<div id=""checkout"" class=""container"">
			<h4>
				Cart
				<span class=""price"" style=""color:black"">
					<i class=""fa fa-shopping-cart""></i>
					<b></b>
				</span>
			</h4>
			<ul id=""cart-list"">

			</ul>
			<p>Total <span class=""price"" s");
            WriteLiteral("tyle=\"color:black;\"></span></p>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
