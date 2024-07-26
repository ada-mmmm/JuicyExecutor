using System.IO;
using System.Windows.Forms;
using System;
using ccapi;

namespace Ezsploit
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ExploitApi.Execute(richTextBox1.Text);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int result = ccapi.ExploitApi.Inject("bin\\api\\CeleryInject.exe", false, false);
            switch (result)
            {
                case 0:
                    MessageBox.Show("Please open roblen");
                    break;
                case 1:
                    label1.Text = "Injected!";
                    ExploitApi.RegisterCustomExecutor("juicy", "1.0.0");
                    break;
                case 2:
                    MessageBox.Show("Already injected");
                    break;
                case 3:
                    MessageBox.Show("Failed to inject");
                    break;
                case 4:
                    MessageBox.Show("Please open with administrator");
                    break;
                case 7:
                    MessageBox.Show("uhhhh...");
                    break;
            }
        }
    }
}