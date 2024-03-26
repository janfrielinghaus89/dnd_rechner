using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DnD_Rechner

{

    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
            inventory.Items = new List<Item>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textEuro1.Text))
            {
                buttonEuroDnd_Click(sender, e);
                e.Handled = true; // Verhindert weiteres Behandeln des Tastendrucks
            }

            if (e.KeyCode == Keys.Enter && AtLeastOneFieldFilled())
            {
                buttonDndEuro_Click(sender, e);
                e.Handled = true; // Verhindert weiteres Behandeln des Tastendrucks
            }
        }

        // Prüfen, ob mindestens ein Feld auf der rechten Seite gefüllt wurde
        private bool AtLeastOneFieldFilled()
        {
            TextBox[] textFields = { textPlatin1, textGold1, textElectrum1, textSilver1, textCopper1 };

            foreach (TextBox textField in textFields)
            {
                if (!string.IsNullOrWhiteSpace(textField.Text))
                {
                    return true;
                }
            }

            return false;
        }


        // Umrechnungskurse DnD zu Euro
        private double platinToEuro = 1000;
        private double goldToEuro = 100;
        private double electrumToEuro = 50;
        private double silverToEuro = 10;
        private double copperToEuro = 1;

        // Umrechungskurs DnD zu Gold

        private void buttonEuroDnd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textEuro1.Text, out double euroAmount))
            {
                // Berechnung der Werte
                double platinumAmount = Math.Round((euroAmount / platinToEuro), 2);
                double goldAmount = Math.Round((euroAmount / goldToEuro), 2);
                double electrumAmount = Math.Round((euroAmount / electrumToEuro), 2);
                double silverAmount = Math.Round((euroAmount / silverToEuro), 2);
                double copperAmount = Math.Round((euroAmount / copperToEuro), 2);

                // Anpassen der Label
                resultPlatinum.Text = $"{platinumAmount} pp";
                resultGold.Text = $"{goldAmount} gp";
                resultElectrum.Text = $"{electrumAmount} ep";
                resultSilver.Text = $"{silverAmount} sp";
                resultCopper.Text = $"{copperAmount} cp";

                // Sichtbarkeit aktivieren
                resultPlatinum.Visible = true;
                resultGold.Visible = true;
                resultElectrum.Visible = true;
                resultSilver.Visible = true;
                resultCopper.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl für Euro ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDndEuro_Click(object sender, EventArgs e)
        {
            // Zu füllende Werte der einzelnen Währungen
            double platinToChange = 0;
            double goldToChange = 0;
            double electrumToChange = 0;
            double silverToChange = 0;
            double copperToChange = 0;

            // Array zur Speicherung der einzelnen Textfelder
            TextBox[] textFields = { textPlatin1, textGold1, textElectrum1, textSilver1, textCopper1 };

            // Überprüfe, ob mindestens ein Textfeld gefüllt ist
            if (textPlatin1.Text != "" || textGold1.Text != "" || textElectrum1.Text != "" || textSilver1.Text != "" || textCopper1.Text != "")
            {
                // Schleife um die Werte zuzuordnen
                for (int i = 0; i < textFields.Length; i++)
                {
                    string textValue = textFields[i].Text;

                    // Wenn das Textfeld nicht leer ist, setze den Wert der entsprechenden Variable
                    if (!string.IsNullOrWhiteSpace(textValue))
                    {
                        switch (i)
                        {
                            case 0:
                                platinToChange = double.Parse(textValue);
                                break;
                            case 1:
                                goldToChange = double.Parse(textValue);
                                break;
                            case 2:
                                electrumToChange = double.Parse(textValue);
                                break;
                            case 3:
                                silverToChange = double.Parse(textValue);
                                break;
                            case 4:
                                copperToChange = double.Parse(textValue);
                                break;
                            default:
                                break;
                        }
                    }
                }

                // Verarbeitung der Daten
                double euroValue = 0;

                euroValue = platinToChange * platinToEuro + goldToChange * goldToEuro + electrumToChange * electrumToEuro + silverToChange * silverToEuro + copperToChange * copperToEuro;

                // Anpassen des Labels
                resultEuro1.Text = $"{euroValue:0.##} €";

                // Sichtbarkeit aktivieren
                resultEuro1.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte füllen sie mindestens eines der Felder mit einer gültigen Zahl aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            // Leeren der Textbox
            textEuro1.Text = "";

            // Anpassen der Label
            resultPlatinum.Text = "";
            resultGold.Text = "";
            resultElectrum.Text = "";
            resultSilver.Text = "";
            resultCopper.Text = "";

            // Sichtbarkeit deaktivieren
            resultPlatinum.Visible = false;
            resultGold.Visible = false;
            resultElectrum.Visible = false;
            resultSilver.Visible = false;
            resultCopper.Visible = false;
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            // Leeren der Textboxen
            textPlatin1.Text = "";
            textGold1.Text = "";
            textElectrum1.Text = "";
            textSilver1.Text = "";
            textCopper1.Text = "";

            // Label anpassen und Sichtbarkeit deaktivieren
            resultEuro1.Text = "";
            resultEuro1.Visible = false;
        }

    }
    public class Item
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public int Value { get; set; }
    }

    public class Inventory
    {
        public List<Item> Items { get; set; }
    }
}
