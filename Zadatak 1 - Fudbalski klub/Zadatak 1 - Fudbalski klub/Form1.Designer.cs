namespace Zadatak_1___Fudbalski_klub
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbBrDresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pozicijaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelaIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.fudbalerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fudbalerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbBrDresa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pozicijaComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelaIme, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.datumPicker, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbPrezime.Location = new System.Drawing.Point(282, 198);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(215, 28);
            this.tbPrezime.TabIndex = 11;
            // 
            // tbBrDresa
            // 
            this.tbBrDresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBrDresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbBrDresa.Location = new System.Drawing.Point(282, 28);
            this.tbBrDresa.Name = "tbBrDresa";
            this.tbBrDresa.Size = new System.Drawing.Size(215, 28);
            this.tbBrDresa.TabIndex = 10;
            this.tbBrDresa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broj dresa fudbalera:";
            // 
            // pozicijaComboBox
            // 
            this.pozicijaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pozicijaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.pozicijaComboBox.FormattingEnabled = true;
            this.pozicijaComboBox.Items.AddRange(new object[] {
            "GOLMAN",
            "ODBRANA",
            "SREDINA",
            "NAPAD"});
            this.pozicijaComboBox.Location = new System.Drawing.Point(285, 368);
            this.pozicijaComboBox.Name = "pozicijaComboBox";
            this.pozicijaComboBox.Size = new System.Drawing.Size(209, 30);
            this.pozicijaComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = " Pozicija fudbalera:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum rođenja fudbalera:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezime fudbalera:";
            // 
            // labelaIme
            // 
            this.labelaIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaIme.AutoSize = true;
            this.labelaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelaIme.Location = new System.Drawing.Point(58, 115);
            this.labelaIme.Name = "labelaIme";
            this.labelaIme.Size = new System.Drawing.Size(143, 24);
            this.labelaIme.TabIndex = 4;
            this.labelaIme.Text = "Ime fudbalera:";
            // 
            // tbIme
            // 
            this.tbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbIme.Location = new System.Drawing.Point(282, 113);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(215, 28);
            this.tbIme.TabIndex = 9;
            // 
            // datumPicker
            // 
            this.datumPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.datumPicker.Location = new System.Drawing.Point(290, 283);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(200, 28);
            this.datumPicker.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(740, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ukloni fudbalera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 428);
            this.dataGridView1.TabIndex = 3;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.Location = new System.Drawing.Point(177, 484);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(184, 54);
            this.dodajBtn.TabIndex = 4;
            this.dodajBtn.Text = "Dodaj fudbalera";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(34, 554);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 5;
            // 
            // fudbalerBindingSource
            // 
            this.fudbalerBindingSource.DataSource = typeof(Zadatak_1___Fudbalski_klub.Fudbaler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 583);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Fudbalski klub";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fudbalerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fudbalerBindingSource;
        private System.Windows.Forms.Label labelaIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pozicijaComboBox;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBrDresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label errorLabel;
    }
}

