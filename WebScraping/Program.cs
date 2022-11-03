using EasyAutomationFramework;
using EasyAutomationFramework.Model;
using WebScraping.Driver;

var web = new WebScraper();
var computeres = web.GetData("https://www.webscraper.io/test-sites/e-commerce/allinone/computers");
var laptops = web.GetData("https://www.webscraper.io/test-sites/e-commerce/allinone/computers/laptops");
var tablets = web.GetData("https://www.webscraper.io/test-sites/e-commerce/allinone/computers/tablets");


var paramss = new ParamsDataTable("Dados", @"C:\temp\excel", new List<DataTables>()
{
    new DataTables("computeres", computeres),
    new DataTables("laptops", laptops),
    new DataTables("tablets", tablets),
});

Base.GenerateExcel(paramss);
