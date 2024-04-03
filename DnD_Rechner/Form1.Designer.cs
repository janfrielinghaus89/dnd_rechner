namespace DnD_Rechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> //
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
            boxEuroInDnd = new GroupBox();
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
            boxDndInEuro = new GroupBox();
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
            boxPricesInDnd = new GroupBox();
            buttonItemEuro = new Button();
            priceItem = new Label();
            label2 = new Label();
            label1 = new Label();
            dropdownPriceItem = new ComboBox();
            boxPricesLifestyle = new GroupBox();
            buttonLifestyleEuro = new Button();
            priceLifestyle = new Label();
            label5 = new Label();
            label6 = new Label();
            dropdownPriceLifestyle = new ComboBox();
            groupBox1 = new GroupBox();
            dropdownAddCurrency = new ComboBox();
            textAddPrice = new TextBox();
            labelAddPrice = new Label();
            labelAddCurrency = new Label();
            textAddItem = new TextBox();
            labelAddCategoryChosen = new Label();
            buttonAddItem = new Button();
            labelAddCategory = new Label();
            dropdownAddCategory = new ComboBox();
            boxEuroInDnd.SuspendLayout();
            boxDndInEuro.SuspendLayout();
            boxPricesInDnd.SuspendLayout();
            boxPricesLifestyle.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // boxEuroInDnd
            // 
            boxEuroInDnd.BackColor = Color.WhiteSmoke;
            boxEuroInDnd.Controls.Add(reset1);
            boxEuroInDnd.Controls.Add(buttonEuroDnd);
            boxEuroInDnd.Controls.Add(resultCopper);
            boxEuroInDnd.Controls.Add(resultSilver);
            boxEuroInDnd.Controls.Add(resultElectrum);
            boxEuroInDnd.Controls.Add(resultGold);
            boxEuroInDnd.Controls.Add(resultPlatinum);
            boxEuroInDnd.Controls.Add(textEuro1);
            boxEuroInDnd.Controls.Add(copper1);
            boxEuroInDnd.Controls.Add(euro1);
            boxEuroInDnd.Controls.Add(silver1);
            boxEuroInDnd.Controls.Add(electrum1);
            boxEuroInDnd.Controls.Add(platin1);
            boxEuroInDnd.Controls.Add(gold1);
            boxEuroInDnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxEuroInDnd.ForeColor = Color.DarkSlateBlue;
            boxEuroInDnd.Location = new Point(12, 12);
            boxEuroInDnd.Name = "boxEuroInDnd";
            boxEuroInDnd.Size = new Size(377, 426);
            boxEuroInDnd.TabIndex = 1;
            boxEuroInDnd.TabStop = false;
            boxEuroInDnd.Text = "Euro in DnD";
            // 
            // reset1
            // 
            reset1.BackColor = Color.LightSteelBlue;
            reset1.FlatStyle = FlatStyle.Popup;
            reset1.ForeColor = Color.Black;
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
            buttonEuroDnd.ForeColor = Color.Black;
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
            resultCopper.ForeColor = Color.DarkSlateGray;
            resultCopper.Location = new Point(165, 325);
            resultCopper.Name = "resultCopper";
            resultCopper.Size = new Size(0, 25);
            resultCopper.TabIndex = 12;
            resultCopper.Visible = false;
            // 
            // resultSilver
            // 
            resultSilver.AutoSize = true;
            resultSilver.ForeColor = Color.DarkSlateGray;
            resultSilver.Location = new Point(165, 275);
            resultSilver.Name = "resultSilver";
            resultSilver.Size = new Size(0, 25);
            resultSilver.TabIndex = 11;
            resultSilver.Visible = false;
            // 
            // resultElectrum
            // 
            resultElectrum.AutoSize = true;
            resultElectrum.ForeColor = Color.DarkSlateGray;
            resultElectrum.Location = new Point(165, 225);
            resultElectrum.Name = "resultElectrum";
            resultElectrum.Size = new Size(0, 25);
            resultElectrum.TabIndex = 10;
            resultElectrum.Visible = false;
            // 
            // resultGold
            // 
            resultGold.AutoSize = true;
            resultGold.ForeColor = Color.DarkSlateGray;
            resultGold.Location = new Point(165, 175);
            resultGold.Name = "resultGold";
            resultGold.Size = new Size(0, 25);
            resultGold.TabIndex = 9;
            resultGold.Visible = false;
            // 
            // resultPlatinum
            // 
            resultPlatinum.AutoSize = true;
            resultPlatinum.ForeColor = Color.DarkSlateGray;
            resultPlatinum.Location = new Point(165, 125);
            resultPlatinum.Name = "resultPlatinum";
            resultPlatinum.Size = new Size(0, 25);
            resultPlatinum.TabIndex = 8;
            resultPlatinum.Visible = false;
            // 
            // textEuro1
            // 
            textEuro1.BackColor = Color.White;
            textEuro1.Location = new Point(165, 47);
            textEuro1.Name = "textEuro1";
            textEuro1.Size = new Size(181, 33);
            textEuro1.TabIndex = 7;
            // 
            // copper1
            // 
            copper1.AutoSize = true;
            copper1.ForeColor = Color.DarkSlateGray;
            copper1.Location = new Point(6, 325);
            copper1.Name = "copper1";
            copper1.Size = new Size(115, 25);
            copper1.TabIndex = 6;
            copper1.Text = "Copper (cp):";
            // 
            // euro1
            // 
            euro1.AutoSize = true;
            euro1.ForeColor = Color.DarkSlateGray;
            euro1.Location = new Point(6, 50);
            euro1.Name = "euro1";
            euro1.Size = new Size(55, 25);
            euro1.TabIndex = 5;
            euro1.Text = "Euro:";
            // 
            // silver1
            // 
            silver1.AutoSize = true;
            silver1.ForeColor = Color.DarkSlateGray;
            silver1.Location = new Point(6, 275);
            silver1.Name = "silver1";
            silver1.Size = new Size(100, 25);
            silver1.TabIndex = 4;
            silver1.Text = "Silber (sp):";
            // 
            // electrum1
            // 
            electrum1.AutoSize = true;
            electrum1.ForeColor = Color.DarkSlateGray;
            electrum1.Location = new Point(6, 225);
            electrum1.Name = "electrum1";
            electrum1.Size = new Size(128, 25);
            electrum1.TabIndex = 3;
            electrum1.Text = "Electrum (ep):";
            // 
            // platin1
            // 
            platin1.AutoSize = true;
            platin1.ForeColor = Color.DarkSlateGray;
            platin1.Location = new Point(6, 125);
            platin1.Name = "platin1";
            platin1.Size = new Size(130, 25);
            platin1.TabIndex = 2;
            platin1.Text = "Platinum (pp):";
            // 
            // gold1
            // 
            gold1.AutoSize = true;
            gold1.ForeColor = Color.DarkSlateGray;
            gold1.Location = new Point(6, 175);
            gold1.Name = "gold1";
            gold1.Size = new Size(95, 25);
            gold1.TabIndex = 1;
            gold1.Text = "Gold (gp):";
            // 
            // boxDndInEuro
            // 
            boxDndInEuro.BackColor = Color.WhiteSmoke;
            boxDndInEuro.Controls.Add(reset2);
            boxDndInEuro.Controls.Add(buttonDndEuro);
            boxDndInEuro.Controls.Add(resultEuro1);
            boxDndInEuro.Controls.Add(textCopper1);
            boxDndInEuro.Controls.Add(textSilver1);
            boxDndInEuro.Controls.Add(textElectrum1);
            boxDndInEuro.Controls.Add(textGold1);
            boxDndInEuro.Controls.Add(textPlatin1);
            boxDndInEuro.Controls.Add(euro2);
            boxDndInEuro.Controls.Add(copper2);
            boxDndInEuro.Controls.Add(silver2);
            boxDndInEuro.Controls.Add(electrum2);
            boxDndInEuro.Controls.Add(gold2);
            boxDndInEuro.Controls.Add(platin2);
            boxDndInEuro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxDndInEuro.ForeColor = Color.DarkSlateBlue;
            boxDndInEuro.Location = new Point(411, 12);
            boxDndInEuro.Name = "boxDndInEuro";
            boxDndInEuro.Size = new Size(377, 426);
            boxDndInEuro.TabIndex = 2;
            boxDndInEuro.TabStop = false;
            boxDndInEuro.Text = "DnD in Euro";
            // 
            // reset2
            // 
            reset2.BackColor = Color.LightSteelBlue;
            reset2.FlatStyle = FlatStyle.Popup;
            reset2.ForeColor = Color.Black;
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
            buttonDndEuro.ForeColor = Color.Black;
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
            resultEuro1.ForeColor = Color.DarkSlateGray;
            resultEuro1.Location = new Point(165, 325);
            resultEuro1.Name = "resultEuro1";
            resultEuro1.Size = new Size(0, 25);
            resultEuro1.TabIndex = 11;
            resultEuro1.Visible = false;
            // 
            // textCopper1
            // 
            textCopper1.BackColor = Color.White;
            textCopper1.Location = new Point(165, 250);
            textCopper1.Name = "textCopper1";
            textCopper1.Size = new Size(181, 33);
            textCopper1.TabIndex = 10;
            // 
            // textSilver1
            // 
            textSilver1.BackColor = Color.White;
            textSilver1.Location = new Point(165, 200);
            textSilver1.Name = "textSilver1";
            textSilver1.Size = new Size(181, 33);
            textSilver1.TabIndex = 9;
            // 
            // textElectrum1
            // 
            textElectrum1.BackColor = Color.White;
            textElectrum1.Location = new Point(165, 150);
            textElectrum1.Name = "textElectrum1";
            textElectrum1.Size = new Size(181, 33);
            textElectrum1.TabIndex = 8;
            // 
            // textGold1
            // 
            textGold1.BackColor = Color.White;
            textGold1.Location = new Point(165, 100);
            textGold1.Name = "textGold1";
            textGold1.Size = new Size(181, 33);
            textGold1.TabIndex = 7;
            // 
            // textPlatin1
            // 
            textPlatin1.BackColor = Color.White;
            textPlatin1.Location = new Point(165, 50);
            textPlatin1.Name = "textPlatin1";
            textPlatin1.Size = new Size(181, 33);
            textPlatin1.TabIndex = 6;
            // 
            // euro2
            // 
            euro2.AutoSize = true;
            euro2.ForeColor = Color.DarkSlateGray;
            euro2.Location = new Point(6, 325);
            euro2.Name = "euro2";
            euro2.Size = new Size(55, 25);
            euro2.TabIndex = 5;
            euro2.Text = "Euro:";
            // 
            // copper2
            // 
            copper2.AutoSize = true;
            copper2.ForeColor = Color.DarkSlateGray;
            copper2.Location = new Point(6, 250);
            copper2.Name = "copper2";
            copper2.Size = new Size(115, 25);
            copper2.TabIndex = 4;
            copper2.Text = "Copper (cp):";
            // 
            // silver2
            // 
            silver2.AutoSize = true;
            silver2.ForeColor = Color.DarkSlateGray;
            silver2.Location = new Point(6, 200);
            silver2.Name = "silver2";
            silver2.Size = new Size(100, 25);
            silver2.TabIndex = 3;
            silver2.Text = "Silber (sp):";
            // 
            // electrum2
            // 
            electrum2.AutoSize = true;
            electrum2.ForeColor = Color.DarkSlateGray;
            electrum2.Location = new Point(6, 150);
            electrum2.Name = "electrum2";
            electrum2.Size = new Size(128, 25);
            electrum2.TabIndex = 2;
            electrum2.Text = "Electrum (ep):";
            // 
            // gold2
            // 
            gold2.AutoSize = true;
            gold2.ForeColor = Color.DarkSlateGray;
            gold2.Location = new Point(6, 100);
            gold2.Name = "gold2";
            gold2.Size = new Size(95, 25);
            gold2.TabIndex = 1;
            gold2.Text = "Gold (gp):";
            // 
            // platin2
            // 
            platin2.AutoSize = true;
            platin2.ForeColor = Color.DarkSlateGray;
            platin2.Location = new Point(6, 50);
            platin2.Name = "platin2";
            platin2.Size = new Size(130, 25);
            platin2.TabIndex = 0;
            platin2.Text = "Platinum (pp):";
            // 
            // boxPricesInDnd
            // 
            boxPricesInDnd.BackColor = Color.WhiteSmoke;
            boxPricesInDnd.Controls.Add(buttonItemEuro);
            boxPricesInDnd.Controls.Add(priceItem);
            boxPricesInDnd.Controls.Add(label2);
            boxPricesInDnd.Controls.Add(label1);
            boxPricesInDnd.Controls.Add(dropdownPriceItem);
            boxPricesInDnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxPricesInDnd.ForeColor = Color.DarkSlateGray;
            boxPricesInDnd.Location = new Point(12, 449);
            boxPricesInDnd.Name = "boxPricesInDnd";
            boxPricesInDnd.Size = new Size(566, 213);
            boxPricesInDnd.TabIndex = 3;
            boxPricesInDnd.TabStop = false;
            boxPricesInDnd.Text = "Item Preise";
            // 
            // buttonItemEuro
            // 
            buttonItemEuro.BackColor = Color.LightSteelBlue;
            buttonItemEuro.FlatStyle = FlatStyle.Popup;
            buttonItemEuro.ForeColor = Color.Black;
            buttonItemEuro.Location = new Point(223, 164);
            buttonItemEuro.Name = "buttonItemEuro";
            buttonItemEuro.Size = new Size(120, 37);
            buttonItemEuro.TabIndex = 15;
            buttonItemEuro.Text = "Umrechnen";
            buttonItemEuro.UseVisualStyleBackColor = false;
            // 
            // priceItem
            // 
            priceItem.AutoSize = true;
            priceItem.ForeColor = Color.DarkSlateGray;
            priceItem.Location = new Point(165, 122);
            priceItem.Name = "priceItem";
            priceItem.Size = new Size(91, 25);
            priceItem.TabIndex = 15;
            priceItem.Text = "priceItem";
            priceItem.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 16;
            label2.Text = "Preis:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 15;
            label1.Text = "Item:";
            // 
            // dropdownPriceItem
            // 
            dropdownPriceItem.BackColor = Color.White;
            dropdownPriceItem.FormattingEnabled = true;
            dropdownPriceItem.Location = new Point(165, 66);
            dropdownPriceItem.Name = "dropdownPriceItem";
            dropdownPriceItem.Size = new Size(295, 33);
            dropdownPriceItem.TabIndex = 0;
            // 
            // boxPricesLifestyle
            // 
            boxPricesLifestyle.BackColor = Color.WhiteSmoke;
            boxPricesLifestyle.Controls.Add(buttonLifestyleEuro);
            boxPricesLifestyle.Controls.Add(priceLifestyle);
            boxPricesLifestyle.Controls.Add(label5);
            boxPricesLifestyle.Controls.Add(label6);
            boxPricesLifestyle.Controls.Add(dropdownPriceLifestyle);
            boxPricesLifestyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxPricesLifestyle.ForeColor = Color.DarkSlateBlue;
            boxPricesLifestyle.Location = new Point(599, 449);
            boxPricesLifestyle.Name = "boxPricesLifestyle";
            boxPricesLifestyle.Size = new Size(566, 213);
            boxPricesLifestyle.TabIndex = 17;
            boxPricesLifestyle.TabStop = false;
            boxPricesLifestyle.Text = "Lifestyle Preise";
            // 
            // buttonLifestyleEuro
            // 
            buttonLifestyleEuro.BackColor = Color.LightSteelBlue;
            buttonLifestyleEuro.FlatStyle = FlatStyle.Popup;
            buttonLifestyleEuro.ForeColor = Color.Black;
            buttonLifestyleEuro.Location = new Point(223, 164);
            buttonLifestyleEuro.Name = "buttonLifestyleEuro";
            buttonLifestyleEuro.Size = new Size(120, 37);
            buttonLifestyleEuro.TabIndex = 17;
            buttonLifestyleEuro.Text = "Umrechnen";
            buttonLifestyleEuro.UseVisualStyleBackColor = false;
            // 
            // priceLifestyle
            // 
            priceLifestyle.AutoSize = true;
            priceLifestyle.ForeColor = Color.DarkSlateGray;
            priceLifestyle.Location = new Point(165, 122);
            priceLifestyle.Name = "priceLifestyle";
            priceLifestyle.Size = new Size(122, 25);
            priceLifestyle.TabIndex = 15;
            priceLifestyle.Text = "priceLifestyle";
            priceLifestyle.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(6, 122);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 16;
            label5.Text = "Preis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 15;
            label6.Text = "Lifestyle:";
            // 
            // dropdownPriceLifestyle
            // 
            dropdownPriceLifestyle.BackColor = Color.White;
            dropdownPriceLifestyle.FormattingEnabled = true;
            dropdownPriceLifestyle.Location = new Point(165, 66);
            dropdownPriceLifestyle.Name = "dropdownPriceLifestyle";
            dropdownPriceLifestyle.Size = new Size(295, 33);
            dropdownPriceLifestyle.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(dropdownAddCurrency);
            groupBox1.Controls.Add(textAddPrice);
            groupBox1.Controls.Add(labelAddPrice);
            groupBox1.Controls.Add(labelAddCurrency);
            groupBox1.Controls.Add(textAddItem);
            groupBox1.Controls.Add(labelAddCategoryChosen);
            groupBox1.Controls.Add(buttonAddItem);
            groupBox1.Controls.Add(labelAddCategory);
            groupBox1.Controls.Add(dropdownAddCategory);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(10, 673);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1155, 213);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item oder Lifestyle hinzufügen";
            // 
            // dropdownAddCurrency
            // 
            dropdownAddCurrency.BackColor = Color.White;
            dropdownAddCurrency.FormattingEnabled = true;
            dropdownAddCurrency.Items.AddRange(new object[] { "cp", "sp", "ep", "gp", "pp" });
            dropdownAddCurrency.Location = new Point(637, 66);
            dropdownAddCurrency.Name = "dropdownAddCurrency";
            dropdownAddCurrency.Size = new Size(295, 33);
            dropdownAddCurrency.TabIndex = 22;
            dropdownAddCurrency.Visible = false;
            // 
            // textAddPrice
            // 
            textAddPrice.BackColor = Color.White;
            textAddPrice.Location = new Point(637, 137);
            textAddPrice.Name = "textAddPrice";
            textAddPrice.Size = new Size(295, 33);
            textAddPrice.TabIndex = 21;
            textAddPrice.Visible = false;
            // 
            // labelAddPrice
            // 
            labelAddPrice.AutoSize = true;
            labelAddPrice.ForeColor = Color.DarkSlateGray;
            labelAddPrice.Location = new Point(528, 140);
            labelAddPrice.Name = "labelAddPrice";
            labelAddPrice.Size = new Size(57, 25);
            labelAddPrice.TabIndex = 19;
            labelAddPrice.Text = "Preis:";
            labelAddPrice.Visible = false;
            // 
            // labelAddCurrency
            // 
            labelAddCurrency.AutoSize = true;
            labelAddCurrency.ForeColor = Color.DarkSlateGray;
            labelAddCurrency.Location = new Point(528, 69);
            labelAddCurrency.Name = "labelAddCurrency";
            labelAddCurrency.Size = new Size(94, 25);
            labelAddCurrency.TabIndex = 18;
            labelAddCurrency.Text = "Währung:";
            labelAddCurrency.Visible = false;
            // 
            // textAddItem
            // 
            textAddItem.BackColor = Color.White;
            textAddItem.Location = new Point(165, 137);
            textAddItem.Name = "textAddItem";
            textAddItem.Size = new Size(295, 33);
            textAddItem.TabIndex = 15;
            textAddItem.Visible = false;
            // 
            // labelAddCategoryChosen
            // 
            labelAddCategoryChosen.AutoSize = true;
            labelAddCategoryChosen.ForeColor = Color.DarkSlateGray;
            labelAddCategoryChosen.Location = new Point(8, 140);
            labelAddCategoryChosen.Name = "labelAddCategoryChosen";
            labelAddCategoryChosen.Size = new Size(53, 25);
            labelAddCategoryChosen.TabIndex = 17;
            labelAddCategoryChosen.Text = "Item:";
            labelAddCategoryChosen.Visible = false;
            // 
            // buttonAddItem
            // 
            buttonAddItem.BackColor = Color.LightSteelBlue;
            buttonAddItem.FlatStyle = FlatStyle.Popup;
            buttonAddItem.ForeColor = Color.Black;
            buttonAddItem.Location = new Point(991, 96);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(120, 37);
            buttonAddItem.TabIndex = 15;
            buttonAddItem.Text = "Hinzufügen";
            buttonAddItem.UseVisualStyleBackColor = false;
            buttonAddItem.Visible = false;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // labelAddCategory
            // 
            labelAddCategory.AutoSize = true;
            labelAddCategory.ForeColor = Color.DarkSlateGray;
            labelAddCategory.Location = new Point(8, 74);
            labelAddCategory.Name = "labelAddCategory";
            labelAddCategory.Size = new Size(97, 25);
            labelAddCategory.TabIndex = 15;
            labelAddCategory.Text = "Kategorie:";
            // 
            // dropdownAddCategory
            // 
            dropdownAddCategory.BackColor = Color.White;
            dropdownAddCategory.FormattingEnabled = true;
            dropdownAddCategory.Items.AddRange(new object[] { "Item", "Lifestyle" });
            dropdownAddCategory.Location = new Point(165, 66);
            dropdownAddCategory.Name = "dropdownAddCategory";
            dropdownAddCategory.Size = new Size(295, 33);
            dropdownAddCategory.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1177, 895);
            Controls.Add(groupBox1);
            Controls.Add(boxPricesLifestyle);
            Controls.Add(boxPricesInDnd);
            Controls.Add(boxDndInEuro);
            Controls.Add(boxEuroInDnd);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            boxEuroInDnd.ResumeLayout(false);
            boxEuroInDnd.PerformLayout();
            boxDndInEuro.ResumeLayout(false);
            boxDndInEuro.PerformLayout();
            boxPricesInDnd.ResumeLayout(false);
            boxPricesInDnd.PerformLayout();
            boxPricesLifestyle.ResumeLayout(false);
            boxPricesLifestyle.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox boxEuroInDnd;
        private GroupBox boxDndInEuro;
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
        private GroupBox boxPricesInDnd;
        private Label label2;
        private Label label1;
        private ComboBox dropdownPriceItem;
        private Label priceItem;
        private GroupBox boxPricesLifestyle;
        private Label priceLifestyle;
        private Label label5;
        private Label label6;
        private ComboBox dropdownPriceLifestyle;
        private Button buttonItemEuro;
        private Button buttonLifestyleEuro;
        private GroupBox groupBox1;
        private Button buttonAddItem;
        private Label labelAddCategory;
        private ComboBox dropdownAddCategory;
        private TextBox textAddPrice;
        private Label labelAddPrice;
        private Label labelAddCurrency;
        private TextBox textAddItem;
        private Label labelAddCategoryChosen;
        private ComboBox dropdownAddCurrency;
    }
}
