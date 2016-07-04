namespace Laboratorio1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApostaAlfredoLbl = new System.Windows.Forms.Label();
            this.ApostaBetoLbl = new System.Windows.Forms.Label();
            this.ApostaJoaoLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ApostadorLbl = new System.Windows.Forms.Label();
            this.AlfredoRbd = new System.Windows.Forms.RadioButton();
            this.BetoRdb = new System.Windows.Forms.RadioButton();
            this.JoaoRdb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dogPicUm = new System.Windows.Forms.PictureBox();
            this.dogPicDois = new System.Windows.Forms.PictureBox();
            this.dogPicTres = new System.Windows.Forms.PictureBox();
            this.dogPicQuatro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicQuatro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratorio1.Properties.Resources.racetrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApostaAlfredoLbl);
            this.groupBox1.Controls.Add(this.ApostaBetoLbl);
            this.groupBox1.Controls.Add(this.ApostaJoaoLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.runBtn);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ApostadorLbl);
            this.groupBox1.Controls.Add(this.AlfredoRbd);
            this.groupBox1.Controls.Add(this.BetoRdb);
            this.groupBox1.Controls.Add(this.JoaoRdb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balcão de Apostas";
            // 
            // ApostaAlfredoLbl
            // 
            this.ApostaAlfredoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApostaAlfredoLbl.Location = new System.Drawing.Point(325, 108);
            this.ApostaAlfredoLbl.Name = "ApostaAlfredoLbl";
            this.ApostaAlfredoLbl.Size = new System.Drawing.Size(200, 15);
            this.ApostaAlfredoLbl.TabIndex = 13;
            this.ApostaAlfredoLbl.Text = "Alfredo ainda não apostou.";
            // 
            // ApostaBetoLbl
            // 
            this.ApostaBetoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApostaBetoLbl.Location = new System.Drawing.Point(325, 85);
            this.ApostaBetoLbl.Name = "ApostaBetoLbl";
            this.ApostaBetoLbl.Size = new System.Drawing.Size(200, 15);
            this.ApostaBetoLbl.TabIndex = 12;
            this.ApostaBetoLbl.Text = "Beto ainda não apostou.";
            // 
            // ApostaJoaoLbl
            // 
            this.ApostaJoaoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApostaJoaoLbl.Location = new System.Drawing.Point(325, 60);
            this.ApostaJoaoLbl.Name = "ApostaJoaoLbl";
            this.ApostaJoaoLbl.Size = new System.Drawing.Size(200, 15);
            this.ApostaJoaoLbl.TabIndex = 11;
            this.ApostaJoaoLbl.Text = "João ainda não apostou.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apostas";
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(437, 128);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(88, 33);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Corram!";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(322, 141);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "reais no cão número";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 141);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aposta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApostadorLbl
            // 
            this.ApostadorLbl.AutoSize = true;
            this.ApostadorLbl.Location = new System.Drawing.Point(7, 148);
            this.ApostadorLbl.Name = "ApostadorLbl";
            this.ApostadorLbl.Size = new System.Drawing.Size(30, 13);
            this.ApostadorLbl.TabIndex = 4;
            this.ApostadorLbl.Text = "João";
            // 
            // AlfredoRbd
            // 
            this.AlfredoRbd.AutoSize = true;
            this.AlfredoRbd.Location = new System.Drawing.Point(6, 106);
            this.AlfredoRbd.Name = "AlfredoRbd";
            this.AlfredoRbd.Size = new System.Drawing.Size(58, 17);
            this.AlfredoRbd.TabIndex = 3;
            this.AlfredoRbd.TabStop = true;
            this.AlfredoRbd.Text = "Alfredo";
            this.AlfredoRbd.UseVisualStyleBackColor = true;
            // 
            // BetoRdb
            // 
            this.BetoRdb.AutoSize = true;
            this.BetoRdb.Location = new System.Drawing.Point(6, 83);
            this.BetoRdb.Name = "BetoRdb";
            this.BetoRdb.Size = new System.Drawing.Size(47, 17);
            this.BetoRdb.TabIndex = 2;
            this.BetoRdb.TabStop = true;
            this.BetoRdb.Text = "Beto";
            this.BetoRdb.UseVisualStyleBackColor = true;
            // 
            // JoaoRdb
            // 
            this.JoaoRdb.AutoSize = true;
            this.JoaoRdb.Location = new System.Drawing.Point(6, 60);
            this.JoaoRdb.Name = "JoaoRdb";
            this.JoaoRdb.Size = new System.Drawing.Size(48, 17);
            this.JoaoRdb.TabIndex = 1;
            this.JoaoRdb.TabStop = true;
            this.JoaoRdb.Text = "João";
            this.JoaoRdb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aposta Mínima";
            // 
            // dogPicUm
            // 
            this.dogPicUm.Image = global::Laboratorio1.Properties.Resources.dog;
            this.dogPicUm.Location = new System.Drawing.Point(436, 24);
            this.dogPicUm.Name = "dogPicUm";
            this.dogPicUm.Size = new System.Drawing.Size(64, 39);
            this.dogPicUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPicUm.TabIndex = 2;
            this.dogPicUm.TabStop = false;
            // 
            // dogPicDois
            // 
            this.dogPicDois.Image = global::Laboratorio1.Properties.Resources.dog;
            this.dogPicDois.Location = new System.Drawing.Point(22, 86);
            this.dogPicDois.Name = "dogPicDois";
            this.dogPicDois.Size = new System.Drawing.Size(64, 39);
            this.dogPicDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPicDois.TabIndex = 3;
            this.dogPicDois.TabStop = false;
            // 
            // dogPicTres
            // 
            this.dogPicTres.Image = global::Laboratorio1.Properties.Resources.dog;
            this.dogPicTres.Location = new System.Drawing.Point(183, 163);
            this.dogPicTres.Name = "dogPicTres";
            this.dogPicTres.Size = new System.Drawing.Size(64, 39);
            this.dogPicTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPicTres.TabIndex = 4;
            this.dogPicTres.TabStop = false;
            // 
            // dogPicQuatro
            // 
            this.dogPicQuatro.Image = global::Laboratorio1.Properties.Resources.dog;
            this.dogPicQuatro.Location = new System.Drawing.Point(22, 234);
            this.dogPicQuatro.Name = "dogPicQuatro";
            this.dogPicQuatro.Size = new System.Drawing.Size(64, 39);
            this.dogPicQuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPicQuatro.TabIndex = 5;
            this.dogPicQuatro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 470);
            this.Controls.Add(this.dogPicQuatro);
            this.Controls.Add(this.dogPicTres);
            this.Controls.Add(this.dogPicDois);
            this.Controls.Add(this.dogPicUm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Corrida Maluca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicQuatro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ApostadorLbl;
        private System.Windows.Forms.RadioButton AlfredoRbd;
        private System.Windows.Forms.RadioButton BetoRdb;
        private System.Windows.Forms.RadioButton JoaoRdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ApostaAlfredoLbl;
        private System.Windows.Forms.Label ApostaBetoLbl;
        private System.Windows.Forms.Label ApostaJoaoLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox dogPicUm;
        private System.Windows.Forms.PictureBox dogPicDois;
        private System.Windows.Forms.PictureBox dogPicTres;
        private System.Windows.Forms.PictureBox dogPicQuatro;
    }
}

