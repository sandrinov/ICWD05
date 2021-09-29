using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            Fax fax = new Fax(mm);
            Printer prn = new Printer(mm);

            mm.SimulateEventHandler("Topolino", "Minni", "Cena", "Esci con me?");
            mm.SimulateEventHandler("Minni", "Topolino", "Cena", "No esco con Pippo");
        }
    }
}
