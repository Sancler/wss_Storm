using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.WebControls;

namespace SharePointProject1.wpULS
{
    [ToolboxItemAttribute(false)]
    public class wpULS : WebPart
    {
        protected override void CreateChildControls()
        {
            Label lbl = new Label();
            lbl.ID = "label1";
            Controls.Add(lbl);

            try
            {
                string n = "mm";
                int i = Convert.ToInt32(n);
            }
            catch (Exception ex)
            {
                lbl.Text = ex.Message;
                SPDiagnosticsService.Local.WriteTrace(0,newSPDiagnosticsCategory("SharepointStorm",
                TraceSeverity.Unexpected, EventSeverity.Error),
                TraceSeverity.Unexpected, ex.Message, ex.StackTrace);
            }
        }

        private SPDiagnosticsCategory newSPDiagnosticsCategory(string p, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            throw new NotImplementedException();
        }
    }
}
