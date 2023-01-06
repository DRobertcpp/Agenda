namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label8 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.telefon = new System.Windows.Forms.TextBox();
            this.butonSalveaza = new System.Windows.Forms.ToolStripButton();
            this.mail = new System.Windows.Forms.TextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.butonExport = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.sexul = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.butonRenunta = new System.Windows.Forms.ToolStripButton();
            this.adresa = new System.Windows.Forms.TextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.data_n = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.butonSterge = new System.Windows.Forms.ToolStripButton();
            this.nume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butonModifica = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.butonAdauga = new System.Windows.Forms.ToolStripButton();
            this.butonImport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "( zi / luna / an )";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(16, 71);
            this.lista.Margin = new System.Windows.Forms.Padding(4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(324, 340);
            this.lista.TabIndex = 13;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            this.toolStripSeparator3.Visible = false;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.Color.White;
            this.telefon.Location = new System.Drawing.Point(100, 309);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            this.telefon.Size = new System.Drawing.Size(227, 22);
            this.telefon.TabIndex = 20;
            // 
            // butonSalveaza
            // 
            this.butonSalveaza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butonSalveaza.Image = ((System.Drawing.Image)(resources.GetObject("butonSalveaza.Image")));
            this.butonSalveaza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonSalveaza.Name = "butonSalveaza";
            this.butonSalveaza.Size = new System.Drawing.Size(71, 52);
            this.butonSalveaza.Text = "Salveaza";
            this.butonSalveaza.Visible = false;
            this.butonSalveaza.Click += new System.EventHandler(this.butonSalveaza_Click);
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.White;
            this.mail.Location = new System.Drawing.Point(100, 266);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(227, 22);
            this.mail.TabIndex = 19;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            this.toolStripSeparator4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-mail";
            // 
            // butonExport
            // 
            this.butonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butonExport.Image = ((System.Drawing.Image)(resources.GetObject("butonExport.Image")));
            this.butonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonExport.Name = "butonExport";
            this.butonExport.Size = new System.Drawing.Size(52, 52);
            this.butonExport.Text = "Export";
            this.butonExport.ToolTipText = "export vCard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefon*";
            // 
            // sexul
            // 
            this.sexul.FormattingEnabled = true;
            this.sexul.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexul.Location = new System.Drawing.Point(275, 95);
            this.sexul.Margin = new System.Windows.Forms.Padding(4);
            this.sexul.Name = "sexul";
            this.sexul.Size = new System.Drawing.Size(52, 24);
            this.sexul.TabIndex = 16;
            this.sexul.Text = "M";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sexul";
            // 
            // butonRenunta
            // 
            this.butonRenunta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butonRenunta.Image = ((System.Drawing.Image)(resources.GetObject("butonRenunta.Image")));
            this.butonRenunta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonRenunta.Name = "butonRenunta";
            this.butonRenunta.Size = new System.Drawing.Size(67, 52);
            this.butonRenunta.Text = "Renunta";
            this.butonRenunta.Visible = false;
            this.butonRenunta.Click += new System.EventHandler(this.butonRenunta_Click);
            // 
            // adresa
            // 
            this.adresa.BackColor = System.Drawing.Color.White;
            this.adresa.Location = new System.Drawing.Point(100, 156);
            this.adresa.Margin = new System.Windows.Forms.Padding(4);
            this.adresa.Multiline = true;
            this.adresa.Name = "adresa";
            this.adresa.ReadOnly = true;
            this.adresa.Size = new System.Drawing.Size(227, 90);
            this.adresa.TabIndex = 14;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            this.toolStripSeparator5.Visible = false;
            // 
            // data_n
            // 
            this.data_n.BackColor = System.Drawing.Color.White;
            this.data_n.Location = new System.Drawing.Point(100, 96);
            this.data_n.Margin = new System.Windows.Forms.Padding(4);
            this.data_n.Name = "data_n";
            this.data_n.ReadOnly = true;
            this.data_n.Size = new System.Drawing.Size(109, 22);
            this.data_n.TabIndex = 13;
            // 
            // prenume
            // 
            this.prenume.BackColor = System.Drawing.Color.White;
            this.prenume.Location = new System.Drawing.Point(100, 54);
            this.prenume.Margin = new System.Windows.Forms.Padding(4);
            this.prenume.Name = "prenume";
            this.prenume.ReadOnly = true;
            this.prenume.Size = new System.Drawing.Size(231, 22);
            this.prenume.TabIndex = 12;
            // 
            // butonSterge
            // 
            this.butonSterge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butonSterge.Image = ((System.Drawing.Image)(resources.GetObject("butonSterge.Image")));
            this.butonSterge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonSterge.Name = "butonSterge";
            this.butonSterge.Size = new System.Drawing.Size(52, 52);
            this.butonSterge.Text = "toolStripButton4";
            this.butonSterge.ToolTipText = "Sterge";
            this.butonSterge.Click += new System.EventHandler(this.butonSterge_Click);
            // 
            // nume
            // 
            this.nume.BackColor = System.Drawing.Color.White;
            this.nume.Location = new System.Drawing.Point(100, 16);
            this.nume.Margin = new System.Windows.Forms.Padding(4);
            this.nume.Name = "nume";
            this.nume.ReadOnly = true;
            this.nume.Size = new System.Drawing.Size(231, 22);
            this.nume.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data nasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "* camp oblogatoriu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume*";
            // 
            // butonModifica
            // 
            this.butonModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butonModifica.Image = ((System.Drawing.Image)(resources.GetObject("butonModifica.Image")));
            this.butonModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(52, 52);
            this.butonModifica.Text = "toolStripButton3";
            this.butonModifica.ToolTipText = "Modifica";
            this.butonModifica.Click += new System.EventHandler(this.butonModifica_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.butonAdauga,
            this.butonModifica,
            this.butonSterge,
            this.toolStripSeparator2,
            this.butonImport,
            this.butonExport,
            this.toolStripSeparator3,
            this.butonSalveaza,
            this.toolStripSeparator4,
            this.butonRenunta,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 55);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Iesire";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // butonAdauga
            // 
            this.butonAdauga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butonAdauga.Image = ((System.Drawing.Image)(resources.GetObject("butonAdauga.Image")));
            this.butonAdauga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonAdauga.Name = "butonAdauga";
            this.butonAdauga.Size = new System.Drawing.Size(52, 52);
            this.butonAdauga.Text = "toolStripButton2";
            this.butonAdauga.ToolTipText = "Adauga";
            this.butonAdauga.Click += new System.EventHandler(this.butonAdauga_Click);
            // 
            // butonImport
            // 
            this.butonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butonImport.Image = ((System.Drawing.Image)(resources.GetObject("butonImport.Image")));
            this.butonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butonImport.Name = "butonImport";
            this.butonImport.Size = new System.Drawing.Size(52, 52);
            this.butonImport.Text = "toolStripButton2";
            this.butonImport.ToolTipText = "import vCard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sexul);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.adresa);
            this.groupBox1.Controls.Add(this.data_n);
            this.groupBox1.Controls.Add(this.prenume);
            this.groupBox1.Controls.Add(this.nume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(369, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 348);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.ToolStripButton butonSalveaza;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton butonExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sexul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton butonRenunta;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox data_n;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.ToolStripButton butonSterge;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton butonModifica;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton butonAdauga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton butonImport;
    }
}

