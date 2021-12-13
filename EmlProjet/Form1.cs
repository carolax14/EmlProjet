using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace EmlProjet
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

        private void btnFolder_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.eml)|*.eml|(*.txt)|*.txt|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbChemin.Text = dialog.FileName;
                richtbMessage.Text = File.ReadAllText(dialog.FileName);
            }
        }
    }
}
