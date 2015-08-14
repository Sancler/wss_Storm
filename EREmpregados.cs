using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace SharePointProject1.EREmpregados
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class EREmpregados : SPItemEventReceiver
    {
       /// <summary>
       /// An item is being added.
       /// </summary>      

        public override void ItemAdding(SPItemEventProperties properties)
        {
            double Salario;
    if (properties.ListTitle == "Funcionarios")
    {
        if (properties.AfterProperties["Salario"] != null)
        {
            Salario =Convert.ToDouble(properties.AfterProperties["Salario"].ToString());

            if (Salario < 300)
                properties.Cancel = true;
        }
    }
}

       /// <summary>
       /// An item is being deleted.
       /// </summary>
       public override void ItemDeleting(SPItemEventProperties properties)
{
    DateTime DataFimContrato;

    if (properties.ListTitle == "Funcionarios")
    {
        if (properties.ListItem["Data Fim do Contrato"] != null)
        {
            DataFimContrato = Convert.ToDateTime(properties.ListItem["Data Fim do Contrato"].ToString());

            if (DateTime.Now > DataFimContrato)
                properties.Cancel = true;
        }
    }
}



    }
}
