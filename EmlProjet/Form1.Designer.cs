
namespace EmlProjet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lbSubtitle2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbFrom = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbCc = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbCci = new System.Windows.Forms.Label();
            this.tbCci = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lstbAttachment = new System.Windows.Forms.ListBox();
            this.lbAttachment = new System.Windows.Forms.Label();
            this.PanelSide.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // lbSubtitle2
            // 
            this.lbSubtitle2.AutoSize = true;
            this.lbSubtitle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubtitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSubtitle2.Location = new System.Drawing.Point(224, 273);
            this.lbSubtitle2.Name = "lbSubtitle2";
            this.lbSubtitle2.Size = new System.Drawing.Size(136, 18);
            this.lbSubtitle2.TabIndex = 24;
            this.lbSubtitle2.Text = "Lecture du fichier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(224, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Source";
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSubtitle.Location = new System.Drawing.Point(224, 151);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(224, 18);
            this.lbSubtitle.TabIndex = 19;
            this.lbSubtitle.Text = "Entrez un nom du fichier à lire";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(224, 104);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(243, 32);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Lire un fichier EML";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(875, 229);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(86, 35);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Lire";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbSource
            // 
            this.tbSource.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSource.Location = new System.Drawing.Point(224, 201);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(737, 22);
            this.tbSource.TabIndex = 16;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(967, 201);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(52, 22);
            this.btnFolder.TabIndex = 22;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelSide.Controls.Add(this.panelLogo);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 75);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(173, 619);
            this.PanelSide.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(173, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.Color.LightGray;
            this.lbLogo.Location = new System.Drawing.Point(26, 29);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(121, 19);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "EML Application";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lbTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1067, 75);
            this.panelTitleBar.TabIndex = 8;
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitleBar.AutoSize = true;
            this.lbTitleBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitleBar.ForeColor = System.Drawing.Color.White;
            this.lbTitleBar.Location = new System.Drawing.Point(510, 15);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(73, 25);
            this.lbTitleBar.TabIndex = 0;
            this.lbTitleBar.Text = "HOME";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFrom.Location = new System.Drawing.Point(224, 307);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(29, 16);
            this.lbFrom.TabIndex = 26;
            this.lbFrom.Text = "De :";
            // 
            // tbFrom
            // 
            this.tbFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFrom.Location = new System.Drawing.Point(224, 326);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(371, 22);
            this.tbFrom.TabIndex = 25;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTo.Location = new System.Drawing.Point(648, 307);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(22, 16);
            this.lbTo.TabIndex = 28;
            this.lbTo.Text = "A :";
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTo.Location = new System.Drawing.Point(648, 326);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTo.Size = new System.Drawing.Size(371, 22);
            this.tbTo.TabIndex = 27;
            // 
            // lbCc
            // 
            this.lbCc.AutoSize = true;
            this.lbCc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCc.Location = new System.Drawing.Point(648, 361);
            this.lbCc.Name = "lbCc";
            this.lbCc.Size = new System.Drawing.Size(30, 16);
            this.lbCc.TabIndex = 32;
            this.lbCc.Text = "Cc :";
            // 
            // tbCc
            // 
            this.tbCc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCc.Location = new System.Drawing.Point(648, 380);
            this.tbCc.Name = "tbCc";
            this.tbCc.ReadOnly = true;
            this.tbCc.Size = new System.Drawing.Size(371, 22);
            this.tbCc.TabIndex = 31;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDate.Location = new System.Drawing.Point(224, 361);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(40, 16);
            this.lbDate.TabIndex = 30;
            this.lbDate.Text = "Date :";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDate.Location = new System.Drawing.Point(224, 380);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(371, 22);
            this.tbDate.TabIndex = 29;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSubject.Location = new System.Drawing.Point(648, 413);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(40, 16);
            this.lbSubject.TabIndex = 36;
            this.lbSubject.Text = "Sujet :";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSubject.Location = new System.Drawing.Point(648, 432);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.ReadOnly = true;
            this.tbSubject.Size = new System.Drawing.Size(371, 22);
            this.tbSubject.TabIndex = 35;
            // 
            // lbCci
            // 
            this.lbCci.AutoSize = true;
            this.lbCci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCci.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCci.Location = new System.Drawing.Point(224, 413);
            this.lbCci.Name = "lbCci";
            this.lbCci.Size = new System.Drawing.Size(33, 16);
            this.lbCci.TabIndex = 34;
            this.lbCci.Text = "Cci :";
            // 
            // tbCci
            // 
            this.tbCci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCci.Location = new System.Drawing.Point(224, 432);
            this.tbCci.Name = "tbCci";
            this.tbCci.ReadOnly = true;
            this.tbCci.Size = new System.Drawing.Size(371, 22);
            this.tbCci.TabIndex = 33;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMessage.Location = new System.Drawing.Point(224, 552);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(60, 16);
            this.lbMessage.TabIndex = 38;
            this.lbMessage.Text = "Message";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMessage.Location = new System.Drawing.Point(224, 571);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(795, 108);
            this.tbMessage.TabIndex = 37;
            // 
            // lstbAttachment
            // 
            this.lstbAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstbAttachment.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lstbAttachment.ForeColor = System.Drawing.Color.Teal;
            this.lstbAttachment.FormattingEnabled = true;
            this.lstbAttachment.ItemHeight = 16;
            this.lstbAttachment.Location = new System.Drawing.Point(224, 487);
            this.lstbAttachment.Name = "lstbAttachment";
            this.lstbAttachment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbAttachment.Size = new System.Drawing.Size(795, 36);
            this.lstbAttachment.TabIndex = 39;
            this.lstbAttachment.SelectedIndexChanged += new System.EventHandler(this.lstbAttachment_SelectedIndexChanged);
            // 
            // lbAttachment
            // 
            this.lbAttachment.AutoSize = true;
            this.lbAttachment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAttachment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAttachment.Location = new System.Drawing.Point(224, 468);
            this.lbAttachment.Name = "lbAttachment";
            this.lbAttachment.Size = new System.Drawing.Size(102, 16);
            this.lbAttachment.TabIndex = 40;
            this.lbAttachment.Text = "Pièce(s) jointes :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 694);
            this.Controls.Add(this.lbAttachment);
            this.Controls.Add(this.lstbAttachment);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbCci);
            this.Controls.Add(this.tbCci);
            this.Controls.Add(this.lbCc);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lbSubtitle2);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lbSubtitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.tbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelSide.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSubtitle2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSubtitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbCc;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbCci;
        private System.Windows.Forms.TextBox tbCci;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lstbAttachment;
        private System.Windows.Forms.Label lbAttachment;
    }
}

