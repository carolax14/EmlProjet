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
using MsgReader;
using System.Windows.Forms;

namespace EmlProjet
{
    public partial class Form1 : Form
    {
        MsgReader.Mime.Message eml;
        public Form1()
        {
            InitializeComponent();
            // ScrollBar
            tbMessage.Multiline = true;
            tbMessage.ScrollBars = ScrollBars.Both;
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
                tbSource.Text = dialog.FileName;
                /*richtbMessage.Text = File.ReadAllText(dialog.FileName);*/

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(tbSource.Text);
            eml = MsgReader.Mime.Message.Load(fileInfo);
            tbFrom.Text = eml.Headers.From.ToString();
            if (eml.Headers != null)
            {
                if (eml.Headers.To != null)
                {
                    tbTo.Text = string.Join(", " , eml.Headers.To.Select(x => x.Address).ToArray());

                }

            }
            tbSubject.Text = eml.Headers.Subject;
            tbCc.Text = string.Join(", ", eml.Headers.Cc.Select(x => x.Address).ToArray());
            tbCci.Text = string.Join(", ", eml.Headers.Bcc.Select(x => x.Address).ToArray());
            tbDate.Text = eml.Headers.Date;

            lstbAttachment.Items.Clear(); // Vide la liste des pièces jointes 
            foreach (MsgReader.Mime.MessagePart attach in eml.Attachments)
            {
                lstbAttachment.Items.Add(attach.FileName);
            }

          

            if (eml.TextBody != null)
            {
                tbMessage.Text = Encoding.UTF8.GetString(eml.TextBody.Body).ToString();
            }
        }

        private void lstbAttachment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
