using (SPSite site = new SPSite("htp://SharePointStorm"))
{    
    using (SPWeb web = site.OpenWeb())
    {
        var list = web.Lists.TryGetList("Lista");

        if (list != null)
        {
            SPQuery query = new SPQuery();
                        
            query.ViewFields = "<FieldRef Name='Campo1'/>" +
                "<FieldRef Name='Campo2'/>";
            
            query.Query = "<Where><Geq><FieldRef Name='Campo2'/>" +
                "<Value Type='Number'>100</Value></Geq></Where>";

            SPListItemCollection collListItems = list.GetItems(query);
        }
    }
}
