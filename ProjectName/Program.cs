using ProjectName;

var menu = new Menu();

string name = Helpers.GetName();
var date = DateTime.UtcNow;

do
{
    menu.ProcessMenu(name, date);
} while (true);
