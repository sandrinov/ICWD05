using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Framework
{
    public class MyClass
    {
        private Button myButton;
        public MyClass(Button btn)
        {
            myButton = btn;
            myButton.Click += new EventHandler(this.myButtonbClick);
        }

        private void myButtonbClick(object sender, EventArgs e)
        {
            MessageBox.Show("Click handled by MyClass");
        }
    }
}
