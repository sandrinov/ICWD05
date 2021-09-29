using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int threadID = Thread.CurrentThread.ManagedThreadId;
            Task<int> t_int = AccessTheWebAsync();
            this.ResultTextBox.Text += "Returned in button click... \r\n";
            int l = await t_int;
            this.ResultTextBox.Text += "length"+l+"... \r\n";
        }
        // Three things to note about writing an Async Function:
        // - The function has an Async modifier.
        // - Its return type is Task or Task(Of T). (See "Return Types" section.)
        // - As a matter of convention, its name ends in "Async".
        public async Task<int> AccessTheWebAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Call and await separately.
                // - AccessTheWebAsync can do other things while GetStringAsync is also running.
                // - getStringTask stores the task we get from the call to GetStringAsync.
                // - Task(Of String) means it is a task which returns a String when it is done.
                Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");
                // You can do other work here that doesn't rely on the string from GetStringAsync.
                DoIndependentWork();
                // The Await operator suspends AccessTheWebAsync.
                // - AccessTheWebAsync does not continue until getStringTask is complete.
                // - Meanwhile, control returns to the caller of AccessTheWebAsync.
                // - Control resumes here when getStringTask is complete.
                // - The Await operator then retrieves the String result from getStringTask.
                string urlContents = await getStringTask;
                // The Return statement specifies an Integer result.
                // A method which awaits AccessTheWebAsync receives the Length value.
                return urlContents.Length;
            }
        }

        private void DoIndependentWork()
        {
            this.ResultTextBox.Text = "working.....\r\n";
        }
    }
}
