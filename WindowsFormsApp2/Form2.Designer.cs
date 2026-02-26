namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Vrsta = new System.Windows.Forms.TextBox();
            this.Pasmina = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDolazak = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCijep = new System.Windows.Forms.CheckBox();
            this.cbKast = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasmina";
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(77, 24);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 3;
            // 
            // Vrsta
            // 
            this.Vrsta.Location = new System.Drawing.Point(77, 72);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(100, 20);
            this.Vrsta.TabIndex = 4;
            // 
            // Pasmina
            // 
            this.Pasmina.Location = new System.Drawing.Point(92, 121);
            this.Pasmina.Name = "Pasmina";
            this.Pasmina.Size = new System.Drawing.Size(100, 20);
            this.Pasmina.TabIndex = 5;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(30, 174);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(57, 17);
            this.rbM.TabIndex = 6;
            this.rbM.TabStop = true;
            this.rbM.Text = "Muško";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(116, 174);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(61, 17);
            this.rbZ.TabIndex = 7;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Žensko";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // nudDob
            // 
            this.nudDob.Location = new System.Drawing.Point(77, 225);
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(120, 20);
            this.nudDob.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dob:";
            // 
            // dtpDolazak
            // 
            this.dtpDolazak.Location = new System.Drawing.Point(29, 292);
            this.dtpDolazak.Name = "dtpDolazak";
            this.dtpDolazak.Size = new System.Drawing.Size(200, 20);
            this.dtpDolazak.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum dolaska:";
            // 
            // cbCijep
            // 
            this.cbCijep.AutoSize = true;
            this.cbCijep.Location = new System.Drawing.Point(291, 37);
            this.cbCijep.Name = "cbCijep";
            this.cbCijep.Size = new System.Drawing.Size(65, 17);
            this.cbCijep.TabIndex = 12;
            this.cbCijep.Text = "Cijepljen";
            this.cbCijep.UseVisualStyleBackColor = true;
            // 
            // cbKast
            // 
            this.cbKast.AutoSize = true;
            this.cbKast.Location = new System.Drawing.Point(289, 75);
            this.cbKast.Name = "cbKast";
            this.cbKast.Size = new System.Drawing.Size(67, 17);
            this.cbKast.TabIndex = 13;
            this.cbKast.Text = "Kastriran";
            this.cbKast.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(364, 142);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(100, 20);
            this.txtNapomena.TabIndex = 15;
            this.txtNapomena.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(587, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 167);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Odaberi sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 62);
            this.button2.TabIndex = 18;
            this.button2.Text = "Spremi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKast);
            this.Controls.Add(this.cbCijep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDolazak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.rbZ);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.Pasmina);
            this.Controls.Add(this.Vrsta);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Unos životinja";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Vrsta;
        private System.Windows.Forms.TextBox Pasmina;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDolazak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCijep;
        private System.Windows.Forms.CheckBox cbKast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}