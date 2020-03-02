namespace Uputstvo_App_Sample_by_DanijelXDA
{
    partial class glavniProzor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavniProzor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.potvrdiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pretraga = new System.Windows.Forms.WebBrowser();
            this.oglas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oglas);
            this.groupBox1.Controls.Add(this.izlazBtn);
            this.groupBox1.Controls.Add(this.potvrdiBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основни подаци о огласу";
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(218, 185);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(139, 34);
            this.izlazBtn.TabIndex = 8;
            this.izlazBtn.Text = "Излаз";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // potvrdiBtn
            // 
            this.potvrdiBtn.Location = new System.Drawing.Point(46, 185);
            this.potvrdiBtn.Name = "potvrdiBtn";
            this.potvrdiBtn.Size = new System.Drawing.Size(140, 34);
            this.potvrdiBtn.TabIndex = 7;
            this.potvrdiBtn.Text = "Потврди";
            this.potvrdiBtn.UseVisualStyleBackColor = true;
            this.potvrdiBtn.Click += new System.EventHandler(this.potvrdiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шта тражите?";
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(452, 45);
            this.pretraga.MinimumSize = new System.Drawing.Size(20, 20);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(884, 508);
            this.pretraga.TabIndex = 3;
            this.pretraga.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // oglas
            // 
            this.oglas.Location = new System.Drawing.Point(31, 110);
            this.oglas.Name = "oglas";
            this.oglas.Size = new System.Drawing.Size(335, 38);
            this.oglas.TabIndex = 9;
            // 
            // glavniProzor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 593);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "glavniProzor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Претраживач огласа | Израдио: Данијел Јовановић";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button potvrdiBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazBtn;
        private System.Windows.Forms.WebBrowser pretraga;
        private System.Windows.Forms.TextBox oglas;
    }
}

