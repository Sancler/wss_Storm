using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace WspImportProject2.WPHelloWorld
{
    [ToolboxItemAttribute(false)]
    public class WPHelloWorld : WebPart
    {
        protected override void CreateChildControls()
        {
            Label lbl = new Label();
            lbl.ID = "label1";
            lbl.Text = "Hello World";

            Controls.Add(lbl);
        }
    }
}
