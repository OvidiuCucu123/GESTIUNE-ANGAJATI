﻿
namespace GESTIUNEANGAJATI
{
    partial class Angajat
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
            this.Utilizator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AfisDate = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DepartamentCb = new System.Windows.Forms.ComboBox();
            this.DataAngajareCb = new System.Windows.Forms.DateTimePicker();
            this.FunctiaCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdresaTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AngajatIdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfisDate)).BeginInit();
            this.SuspendLayout();
            // 
            // Utilizator
            // 
            this.Utilizator.AutoSize = true;
            this.Utilizator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Utilizator.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Utilizator.ForeColor = System.Drawing.Color.White;
            this.Utilizator.Location = new System.Drawing.Point(0, 0);
            this.Utilizator.Name = "Utilizator";
            this.Utilizator.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.Utilizator.Size = new System.Drawing.Size(323, 61);
            this.Utilizator.TabIndex = 4;
            this.Utilizator.Text = "Gestionare angajati";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AfisDate);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DepartamentCb);
            this.panel1.Controls.Add(this.DataAngajareCb);
            this.panel1.Controls.Add(this.FunctiaCb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TelefonTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AdresaTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NumeTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AngajatIdTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 663);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(319, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 46);
            this.button5.TabIndex = 20;
            this.button5.Text = "Cauta";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(402, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 19;
            this.button4.Text = "Resetare";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AfisDate
            // 
            this.AfisDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AfisDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.AfisDate.Location = new System.Drawing.Point(843, 0);
            this.AfisDate.Name = "AfisDate";
            this.AfisDate.RowHeadersWidth = 51;
            this.AfisDate.RowTemplate.Height = 29;
            this.AfisDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AfisDate.Size = new System.Drawing.Size(857, 663);
            this.AfisDate.TabIndex = 18;
            this.AfisDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AfisDate_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(277, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sterge";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Editeaza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartamentCb
            // 
            this.DepartamentCb.FormattingEnabled = true;
            this.DepartamentCb.Items.AddRange(new object[] {
            "Conducere",
            "Administratie",
            "Resurse Umane",
            "Tehnic",
            "Calitate",
            "Logistica",
            "IT"});
            this.DepartamentCb.Location = new System.Drawing.Point(192, 313);
            this.DepartamentCb.Name = "DepartamentCb";
            this.DepartamentCb.Size = new System.Drawing.Size(177, 28);
            this.DepartamentCb.TabIndex = 14;
            // 
            // DataAngajareCb
            // 
            this.DataAngajareCb.Location = new System.Drawing.Point(192, 224);
            this.DataAngajareCb.Name = "DataAngajareCb";
            this.DataAngajareCb.Size = new System.Drawing.Size(179, 27);
            this.DataAngajareCb.TabIndex = 13;
            // 
            // FunctiaCb
            // 
            this.FunctiaCb.FormattingEnabled = true;
            this.FunctiaCb.Items.AddRange(new object[] {
            "Operator",
            "Inginer",
            "Tehnician",
            "Sef Proiect",
            "Director"});
            this.FunctiaCb.Location = new System.Drawing.Point(194, 264);
            this.FunctiaCb.Name = "FunctiaCb";
            this.FunctiaCb.Size = new System.Drawing.Size(177, 28);
            this.FunctiaCb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Departament";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Functie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data angajare";
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(192, 181);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(94, 27);
            this.TelefonTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // AdresaTb
            // 
            this.AdresaTb.Location = new System.Drawing.Point(192, 133);
            this.AdresaTb.Name = "AdresaTb";
            this.AdresaTb.Size = new System.Drawing.Size(94, 27);
            this.AdresaTb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NumeTb
            // 
            this.NumeTb.Location = new System.Drawing.Point(192, 83);
            this.NumeTb.Name = "NumeTb";
            this.NumeTb.Size = new System.Drawing.Size(94, 27);
            this.NumeTb.TabIndex = 3;
            this.NumeTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AngajatIdTb
            // 
            this.AngajatIdTb.Location = new System.Drawing.Point(192, 33);
            this.AngajatIdTb.Name = "AngajatIdTb";
            this.AngajatIdTb.Size = new System.Drawing.Size(94, 27);
            this.AngajatIdTb.TabIndex = 1;
            this.AngajatIdTb.TextChanged += new System.EventHandler(this.AngajatIdTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AngajatId";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 694);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.panel2.Size = new System.Drawing.Size(1700, 30);
            this.panel2.TabIndex = 6;
            // 
            // Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1700, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Utilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Angajat";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Angajat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfisDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Utilizator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AngajatID;
        private System.Windows.Forms.TextBox TelefonTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdresaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DepartamentCb;
        private System.Windows.Forms.DateTimePicker DataAngajareCb;
        private System.Windows.Forms.ComboBox FunctiaCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView AfisDate;
        private System.Windows.Forms.TextBox AngajatIdTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}