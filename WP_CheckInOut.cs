using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharePointProject1.WP_CheckInOut
{
    [ToolboxItemAttribute(false)]
    public class WP_CheckInOut : WebPart
    {
        public Button button;
        public Label labelAlert;

        protected override void CreateChildControls()
        {
            button = new Button();
            button.ID = "btn1";
            button.Text = "Executar";
            button.Click +=new EventHandler(button_Click);
            Controls.Add(button);
            Controls.Add(new LiteralControl("<br>"));

            labelAlert = new Label();
            labelAlert.ID = "lblAlert";
            labelAlert.Text = "";
            labelAlert.Visible = false;
            Controls.Add(labelAlert);
            Controls.Add(new LiteralControl("<br>"));
        }

        void button_Click(object sender, EventArgs e)
        {
            try
            {
                SPWeb web = SPContext.Current.Web;

                SPSecurity.RunWithElevatedPrivileges(delegate
                {
                    foreach (SPFolder folder in web.Folders)
                    {
                        if (folder.Name == "Documentos")
                        {
                            foreach (SPFile file in folder.Files)
                            {
                                file.CheckOut();
                            }
                            break;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                labelAlert.Visible = true;
                labelAlert.Text = ex.Message;
            }
        }

    }
}
