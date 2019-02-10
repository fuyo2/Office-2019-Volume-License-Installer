using System;
using System.Windows.Forms;

namespace OfficeEasyInstaller
{
    public partial class Form1 : Form
    {

        string officeClientEdition = "32";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            string productKey = maskedTextBoxKey.Text;
            PIDKEY.WriteXML(productKey);
            PIDKEY.WriteXMLOfficeClientEdition(officeClientEdition);
            RunCMD.SetUp();
            System.Windows.Forms.Application.Exit();
        }

        private void maskedTextBoxKey_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            officeClientEdition = "64";
        }
    }
}
