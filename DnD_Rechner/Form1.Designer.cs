﻿namespace DnD_Rechner
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
            groupBox1 = new GroupBox();
            reset1 = new Button();
            buttonEuroDnd = new Button();
            resultCopper = new Label();
            resultSilver = new Label();
            resultElectrum = new Label();
            resultGold = new Label();
            resultPlatinum = new Label();
            textEuro1 = new TextBox();
            copper1 = new Label();
            euro1 = new Label();
            silver1 = new Label();
            electrum1 = new Label();
            platin1 = new Label();
            gold1 = new Label();
            groupBox2 = new GroupBox();
            reset2 = new Button();
            buttonDndEuro = new Button();
            resultEuro1 = new Label();
            textCopper1 = new TextBox();
            textSilver1 = new TextBox();
            textElectrum1 = new TextBox();
            textGold1 = new TextBox();
            textPlatin1 = new TextBox();
            euro2 = new Label();
            copper2 = new Label();
            silver2 = new Label();
            electrum2 = new Label();
            gold2 = new Label();
            platin2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reset1);
            groupBox1.Controls.Add(buttonEuroDnd);
            groupBox1.Controls.Add(resultCopper);
            groupBox1.Controls.Add(resultSilver);
            groupBox1.Controls.Add(resultElectrum);
            groupBox1.Controls.Add(resultGold);
            groupBox1.Controls.Add(resultPlatinum);
            groupBox1.Controls.Add(textEuro1);
            groupBox1.Controls.Add(copper1);
            groupBox1.Controls.Add(euro1);
            groupBox1.Controls.Add(silver1);
            groupBox1.Controls.Add(electrum1);
            groupBox1.Controls.Add(platin1);
            groupBox1.Controls.Add(gold1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Euro in DnD";
            // 
            // reset1
            // 
            reset1.BackColor = Color.LightCoral;
            reset1.FlatStyle = FlatStyle.Popup;
            reset1.Location = new Point(206, 376);
            reset1.Name = "reset1";
            reset1.Size = new Size(120, 37);
            reset1.TabIndex = 14;
            reset1.Text = "Reset";
            reset1.UseVisualStyleBackColor = false;
            reset1.Click += reset1_Click;
            // 
            // buttonEuroDnd
            // 
            buttonEuroDnd.BackColor = Color.LightSteelBlue;
            buttonEuroDnd.FlatStyle = FlatStyle.Popup;
            buttonEuroDnd.Location = new Point(60, 376);
            buttonEuroDnd.Name = "buttonEuroDnd";
            buttonEuroDnd.Size = new Size(120, 37);
            buttonEuroDnd.TabIndex = 13;
            buttonEuroDnd.Text = "Umrechnen";
            buttonEuroDnd.UseVisualStyleBackColor = false;
            buttonEuroDnd.Click += buttonEuroDnd_Click;
            // 
            // resultCopper
            // 
            resultCopper.AutoSize = true;
            resultCopper.Location = new Point(165, 325);
            resultCopper.Name = "resultCopper";
            resultCopper.Size = new Size(63, 25);
            resultCopper.TabIndex = 12;
            resultCopper.Text = "label6";
            resultCopper.Visible = false;
            // 
            // resultSilver
            // 
            resultSilver.AutoSize = true;
            resultSilver.Location = new Point(165, 275);
            resultSilver.Name = "resultSilver";
            resultSilver.Size = new Size(63, 25);
            resultSilver.TabIndex = 11;
            resultSilver.Text = "label5";
            resultSilver.Visible = false;
            // 
            // resultElectrum
            // 
            resultElectrum.AutoSize = true;
            resultElectrum.Location = new Point(165, 225);
            resultElectrum.Name = "resultElectrum";
            resultElectrum.Size = new Size(63, 25);
            resultElectrum.TabIndex = 10;
            resultElectrum.Text = "label4";
            resultElectrum.Visible = false;
            // 
            // resultGold
            // 
            resultGold.AutoSize = true;
            resultGold.Location = new Point(165, 175);
            resultGold.Name = "resultGold";
            resultGold.Size = new Size(63, 25);
            resultGold.TabIndex = 9;
            resultGold.Text = "label3";
            resultGold.Visible = false;
            // 
            // resultPlatinum
            // 
            resultPlatinum.AutoSize = true;
            resultPlatinum.Location = new Point(165, 125);
            resultPlatinum.Name = "resultPlatinum";
            resultPlatinum.Size = new Size(63, 25);
            resultPlatinum.TabIndex = 8;
            resultPlatinum.Text = "label2";
            resultPlatinum.Visible = false;
            // 
            // textEuro1
            // 
            textEuro1.Location = new Point(165, 50);
            textEuro1.Name = "textEuro1";
            textEuro1.Size = new Size(181, 33);
            textEuro1.TabIndex = 7;
            // 
            // copper1
            // 
            copper1.AutoSize = true;
            copper1.Location = new Point(6, 325);
            copper1.Name = "copper1";
            copper1.Size = new Size(115, 25);
            copper1.TabIndex = 6;
            copper1.Text = "Copper (cp):";
            // 
            // euro1
            // 
            euro1.AutoSize = true;
            euro1.Location = new Point(6, 50);
            euro1.Name = "euro1";
            euro1.Size = new Size(55, 25);
            euro1.TabIndex = 5;
            euro1.Text = "Euro:";
            // 
            // silver1
            // 
            silver1.AutoSize = true;
            silver1.Location = new Point(6, 275);
            silver1.Name = "silver1";
            silver1.Size = new Size(100, 25);
            silver1.TabIndex = 4;
            silver1.Text = "Silber (sp):";
            // 
            // electrum1
            // 
            electrum1.AutoSize = true;
            electrum1.Location = new Point(6, 225);
            electrum1.Name = "electrum1";
            electrum1.Size = new Size(128, 25);
            electrum1.TabIndex = 3;
            electrum1.Text = "Electrum (ep):";
            // 
            // platin1
            // 
            platin1.AutoSize = true;
            platin1.Location = new Point(6, 125);
            platin1.Name = "platin1";
            platin1.Size = new Size(130, 25);
            platin1.TabIndex = 2;
            platin1.Text = "Platinum (pp):";
            // 
            // gold1
            // 
            gold1.AutoSize = true;
            gold1.Location = new Point(6, 175);
            gold1.Name = "gold1";
            gold1.Size = new Size(95, 25);
            gold1.TabIndex = 1;
            gold1.Text = "Gold (gp):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(reset2);
            groupBox2.Controls.Add(buttonDndEuro);
            groupBox2.Controls.Add(resultEuro1);
            groupBox2.Controls.Add(textCopper1);
            groupBox2.Controls.Add(textSilver1);
            groupBox2.Controls.Add(textElectrum1);
            groupBox2.Controls.Add(textGold1);
            groupBox2.Controls.Add(textPlatin1);
            groupBox2.Controls.Add(euro2);
            groupBox2.Controls.Add(copper2);
            groupBox2.Controls.Add(silver2);
            groupBox2.Controls.Add(electrum2);
            groupBox2.Controls.Add(gold2);
            groupBox2.Controls.Add(platin2);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(411, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 426);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DnD in Euro";
            // 
            // reset2
            // 
            reset2.BackColor = Color.LightCoral;
            reset2.FlatStyle = FlatStyle.Popup;
            reset2.Location = new Point(206, 376);
            reset2.Name = "reset2";
            reset2.Size = new Size(120, 37);
            reset2.TabIndex = 13;
            reset2.Text = "Reset";
            reset2.UseVisualStyleBackColor = false;
            reset2.Click += reset2_Click;
            // 
            // buttonDndEuro
            // 
            buttonDndEuro.BackColor = Color.LightSteelBlue;
            buttonDndEuro.FlatStyle = FlatStyle.Popup;
            buttonDndEuro.Location = new Point(60, 376);
            buttonDndEuro.Name = "buttonDndEuro";
            buttonDndEuro.Size = new Size(120, 37);
            buttonDndEuro.TabIndex = 12;
            buttonDndEuro.Text = "Umrechnen";
            buttonDndEuro.UseVisualStyleBackColor = false;
            buttonDndEuro.Click += buttonDndEuro_Click;
            // 
            // resultEuro1
            // 
            resultEuro1.AutoSize = true;
            resultEuro1.Location = new Point(165, 325);
            resultEuro1.Name = "resultEuro1";
            resultEuro1.Size = new Size(63, 25);
            resultEuro1.TabIndex = 11;
            resultEuro1.Text = "label1";
            resultEuro1.Visible = false;
            // 
            // textCopper1
            // 
            textCopper1.Location = new Point(165, 250);
            textCopper1.Name = "textCopper1";
            textCopper1.Size = new Size(181, 33);
            textCopper1.TabIndex = 10;
            // 
            // textSilver1
            // 
            textSilver1.Location = new Point(165, 200);
            textSilver1.Name = "textSilver1";
            textSilver1.Size = new Size(181, 33);
            textSilver1.TabIndex = 9;
            // 
            // textElectrum1
            // 
            textElectrum1.Location = new Point(165, 150);
            textElectrum1.Name = "textElectrum1";
            textElectrum1.Size = new Size(181, 33);
            textElectrum1.TabIndex = 8;
            // 
            // textGold1
            // 
            textGold1.Location = new Point(165, 100);
            textGold1.Name = "textGold1";
            textGold1.Size = new Size(181, 33);
            textGold1.TabIndex = 7;
            // 
            // textPlatin1
            // 
            textPlatin1.Location = new Point(165, 50);
            textPlatin1.Name = "textPlatin1";
            textPlatin1.Size = new Size(181, 33);
            textPlatin1.TabIndex = 6;
            // 
            // euro2
            // 
            euro2.AutoSize = true;
            euro2.Location = new Point(6, 325);
            euro2.Name = "euro2";
            euro2.Size = new Size(55, 25);
            euro2.TabIndex = 5;
            euro2.Text = "Euro:";
            // 
            // copper2
            // 
            copper2.AutoSize = true;
            copper2.Location = new Point(6, 250);
            copper2.Name = "copper2";
            copper2.Size = new Size(115, 25);
            copper2.TabIndex = 4;
            copper2.Text = "Copper (cp):";
            // 
            // silver2
            // 
            silver2.AutoSize = true;
            silver2.Location = new Point(6, 200);
            silver2.Name = "silver2";
            silver2.Size = new Size(100, 25);
            silver2.TabIndex = 3;
            silver2.Text = "Silber (sp):";
            // 
            // electrum2
            // 
            electrum2.AutoSize = true;
            electrum2.Location = new Point(6, 150);
            electrum2.Name = "electrum2";
            electrum2.Size = new Size(128, 25);
            electrum2.TabIndex = 2;
            electrum2.Text = "Electrum (ep):";
            // 
            // gold2
            // 
            gold2.AutoSize = true;
            gold2.Location = new Point(6, 100);
            gold2.Name = "gold2";
            gold2.Size = new Size(95, 25);
            gold2.TabIndex = 1;
            gold2.Text = "Gold (gp):";
            // 
            // platin2
            // 
            platin2.AutoSize = true;
            platin2.Location = new Point(6, 50);
            platin2.Name = "platin2";
            platin2.Size = new Size(130, 25);
            platin2.TabIndex = 0;
            platin2.Text = "Platinum (pp):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label copper1;
        private Label euro1;
        private Label silver1;
        private Label electrum1;
        private Label platin1;
        private Label gold1;
        private Label euro2;
        private Label copper2;
        private Label silver2;
        private Label electrum2;
        private Label gold2;
        private Label platin2;
        private TextBox textEuro1;
        private TextBox textPlatin1;
        private TextBox textGold1;
        private TextBox textCopper1;
        private TextBox textSilver1;
        private TextBox textElectrum1;
        private Button buttonEuroDnd;
        private Label resultCopper;
        private Label resultSilver;
        private Label resultElectrum;
        private Label resultGold;
        private Label resultPlatinum;
        private Label resultEuro1;
        private Button buttonDndEuro;
        private Button reset1;
        private Button reset2;
    }
}