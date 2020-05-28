using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.koma = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.kurang = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.bagi = new System.Windows.Forms.Button();
            this.kosong = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(424, 79);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(19, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(100, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(181, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(19, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(100, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(181, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(19, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 65);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button8.Location = new System.Drawing.Point(100, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 65);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button9.Location = new System.Drawing.Point(181, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 65);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // koma
            // 
            this.koma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.koma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.koma.Location = new System.Drawing.Point(19, 360);
            this.koma.Name = "koma";
            this.koma.Size = new System.Drawing.Size(77, 67);
            this.koma.TabIndex = 10;
            this.koma.Text = ".";
            this.koma.UseVisualStyleBackColor = false;
            this.koma.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button11.Location = new System.Drawing.Point(100, 360);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(77, 67);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.SystemColors.Control;
            this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hapus.Location = new System.Drawing.Point(181, 360);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(77, 67);
            this.hapus.TabIndex = 12;
            this.hapus.Text = "Del";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.backspace_Click);
            // 
            // ON
            // 
            this.ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ON.Location = new System.Drawing.Point(19, 97);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(75, 37);
            this.ON.TabIndex = 13;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = false;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OFF.Location = new System.Drawing.Point(100, 97);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 37);
            this.OFF.TabIndex = 14;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = false;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exit.Location = new System.Drawing.Point(361, 97);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 44);
            this.exit.TabIndex = 15;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tambah.Location = new System.Drawing.Point(269, 179);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(86, 39);
            this.tambah.TabIndex = 16;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // kurang
            // 
            this.kurang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kurang.Location = new System.Drawing.Point(269, 224);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(86, 38);
            this.kurang.TabIndex = 17;
            this.kurang.Text = "-";
            this.kurang.UseVisualStyleBackColor = false;
            this.kurang.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // kali
            // 
            this.kali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kali.Location = new System.Drawing.Point(269, 268);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(86, 40);
            this.kali.TabIndex = 18;
            this.kali.Text = "*";
            this.kali.UseVisualStyleBackColor = false;
            this.kali.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // bagi
            // 
            this.bagi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bagi.Location = new System.Drawing.Point(269, 314);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(86, 40);
            this.bagi.TabIndex = 19;
            this.bagi.Text = "/";
            this.bagi.UseVisualStyleBackColor = false;
            this.bagi.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // kosong
            // 
            this.kosong.BackColor = System.Drawing.SystemColors.Control;
            this.kosong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kosong.Location = new System.Drawing.Point(269, 360);
            this.kosong.Name = "kosong";
            this.kosong.Size = new System.Drawing.Size(86, 67);
            this.kosong.TabIndex = 20;
            this.kosong.Text = "AC";
            this.kosong.UseVisualStyleBackColor = false;
            this.kosong.Click += new System.EventHandler(this.clear_Click);
            // 
            // Hasil
            // 
            this.Hasil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Hasil.Location = new System.Drawing.Point(361, 268);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(75, 159);
            this.Hasil.TabIndex = 21;
            this.Hasil.Text = "=";
            this.Hasil.UseVisualStyleBackColor = false;
            this.Hasil.Click += new System.EventHandler(this.hasil_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.Location = new System.Drawing.Point(0, 0);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(100, 23);
            this.lblShowOp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 464);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.kosong);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.koma);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button koma;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button kurang;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Button kosong;
        private System.Windows.Forms.Button Hasil;
        private System.Windows.Forms.Label lblShowOp;
    }
}

