using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Before starting thread-";
            Console.WriteLine("-Before starting thread-");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";

            Thread threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblStatus.Text = "-End Of Thread-";
            Console.WriteLine("-End Of Thread-");
        }
    }
}
