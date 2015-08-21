SPSite SiteCollection = new SPSite("http:/SharepointStorm");

SPWeb Site = SiteCollection.OpenWeb();

foreach(SPList List in Site.Lists)
{
	Console.WriteLine("List:" + List.Title);
}


