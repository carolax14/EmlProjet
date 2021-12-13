
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lbSubtitle2 = new System.Windows.Forms.Label();
            this.richtbMessage = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbChemin = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelDesktop.SuspendLayout();
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
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.Controls.Add(this.lbSubtitle2);
            this.panelDesktop.Controls.Add(this.richtbMessage);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.lbSubtitle);
            this.panelDesktop.Controls.Add(this.lbTitle);
            this.panelDesktop.Controls.Add(this.btnRead);
            this.panelDesktop.Controls.Add(this.tbChemin);
            this.panelDesktop.Controls.Add(this.btnFolder);
            this.panelDesktop.Location = new System.Drawing.Point(172, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(836, 422);
            this.panelDesktop.TabIndex = 9;
            // 
            // lbSubtitle2
            // 
            this.lbSubtitle2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSubtitle2.AutoSize = true;
            this.lbSubtitle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubtitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSubtitle2.Location = new System.Drawing.Point(448, 63);
            this.lbSubtitle2.Name = "lbSubtitle2";
            this.lbSubtitle2.Size = new System.Drawing.Size(224, 18);
            this.lbSubtitle2.TabIndex = 24;
            this.lbSubtitle2.Text = "Entrez un nom du fichier à lire";
            // 
            // richtbMessage
            // 
            this.richtbMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtbMessage.Location = new System.Drawing.Point(448, 128);
            this.richtbMessage.Name = "richtbMessage";
            this.richtbMessage.Size = new System.Drawing.Size(373, 282);
            this.richtbMessage.TabIndex = 23;
            this.richtbMessage.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chemin";
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSubtitle.Location = new System.Drawing.Point(25, 63);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(224, 18);
            this.lbSubtitle.TabIndex = 19;
            this.lbSubtitle.Text = "Entrez un nom du fichier à lire";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(25, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(243, 32);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Lire un fichier EML";
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(241, 166);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(86, 35);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Lire";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // tbChemin
            // 
            this.tbChemin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbChemin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChemin.Location = new System.Drawing.Point(25, 128);
            this.tbChemin.Name = "tbChemin";
            this.tbChemin.Size = new System.Drawing.Size(302, 22);
            this.tbChemin.TabIndex = 16;
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFolder.Location = new System.Drawing.Point(333, 128);
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
            this.PanelSide.Size = new System.Drawing.Size(173, 422);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 75);
            this.panelTitleBar.TabIndex = 8;
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitleBar.AutoSize = true;
            this.lbTitleBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitleBar.ForeColor = System.Drawing.Color.White;
            this.lbTitleBar.Location = new System.Drawing.Point(485, 15);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(73, 25);
            this.lbTitleBar.TabIndex = 0;
            this.lbTitleBar.Text = "HOME";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 497);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
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
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lbSubtitle2;
        private System.Windows.Forms.RichTextBox richtbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSubtitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbChemin;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

