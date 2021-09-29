using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    public class Fax
    {
        private MailManager _mm;

        public Fax(MailManager mm)
        {
            _mm = mm;
            _mm.MailArrived += _mm_MailArrived;
        }

        private void _mm_MailArrived(object sender, MailEventArgs args)
        {
            Console.WriteLine("FAX");
            Console.WriteLine("Mail arrived from " + args.From);
            Console.WriteLine($"Object: {args.MailObject}  Text: {args.Text}");
        }
    }
}
