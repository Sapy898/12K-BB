namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem menu1 = new MenuItem("csirke", "Főétel", 2500);
            MenuItem menu2 = new MenuItem("rízs", "köret", 1000);
            ConsoleView cw = new ConsoleView();

            MenuItem menu3 = new MenuItem("krumpli", "köret", 1500);
            MenuItem menu4 = new MenuItem("kacsa", "köret", 2300);
            MenuItem menu5 = new MenuItem("steak", "Főétel", 7000);
            List<MenuItem> items = new List<MenuItem>();
            items.Add(menu1);
            items.Add(menu2);
            items.Add(menu3);
            items.Add(menu4);
            items.Add(menu5);

            cw.ShowItems(items);
            cw.ShowMessage(MenuItem.Count.ToString());

            Menu m = new Menu("kajálda");
            m.AddItem(menu1);
            m.AddItem(menu2);
            m.AddItem(menu3);
            m.AddItem(menu4);
            m.AddItem(menu5);
            //cw.ShowItem(m.FindByName("csirke"));
            //cw.ShowItem(m.FindByName("csirk"));
            if (m.FindByName("csirke") != null)
            {
                cw.ShowItem(m.FindByName("csirke"));
            }
            else
            {
                cw.ShowMessage("Nincs Ilyen elem!");
            }
            cw.ShowMessage("___________________________");
            menu1.SellOut();
            cw.ShowItems(m.AvailabeItems());
            menu1.ReStock();
            cw.ShowMessage("___________________________");
            cw.ShowItems(m.ItemsByCategory("köret"));
            cw.ShowMessage("___________________________");
            cw.ShowMessage(m.AveragePrice("köret"));
            cw.ShowMessage("___________________________");
            Order o = new Order();
            cw.ShowMessage("Rendelésem:");
            menu3.SellOut();
            o.Add(menu1);
            o.Add(menu5);
            o.Add(menu3);//elfogyott 
            cw.ShowMessage(o.GetSummary());


        }
    }
}
