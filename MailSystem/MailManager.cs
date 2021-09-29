using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    public class MailEventArgs:EventArgs
    {
        public string From { get; set; }
        public string To { get; set; }
        public string MailObject { get; set; }
        public string Text { get; set; }
    }

    public delegate void MailArrivedEventHandler(object sender, MailEventArgs args);
    public class MailManager
    {
        public event MailArrivedEventHandler MailArrived;

        public void SimulateEventHandler(string from, string to, string mailObj, string text)
        {
            MailEventArgs args = new MailEventArgs() { From = from, MailObject = mailObj, Text = text, To = to };

            //if(MailArrived != null)
            //{
            //    MailArrived(this, args);
            //}
            if (MailArrived != null)
            {
                Delegate[] arrayOfDelegates = MailArrived.GetInvocationList();
                foreach (Delegate d in arrayOfDelegates)
                {
                    MailArrivedEventHandler eh = (MailArrivedEventHandler)d;
                    eh(this, args);
                }
            }
        }

    }
}
