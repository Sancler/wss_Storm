using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace ConsoleApplication1
{
    class SPWeb_SiteStructure
    {
        static void Main(string[] args)
        {

            using (var oSite = new SPSite("http://www.sharepointstorm.com/sites/realestate"))
            {
                using (var oWeb = oSite.AllWebs["residential"])
                //using (var oWeb = oSite.OpenWeb("residential"))
                {
                    Console.WriteLine(oWeb.Title);
                }
            }
            Console.WriteLine();
            Console.WriteLine("SharePoint Storm!!!!");
            Console.ReadLine();
        }
    }
}
