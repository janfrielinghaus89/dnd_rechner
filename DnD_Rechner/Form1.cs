using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;


namespace DnD_Rechner

{
    public partial class Form1 : Form
    {
        // Initialisiere Inventar
        private Inventory inventory;

        // Umrechnungskurse DnD zu Euro
        private double platinToEuro = 1000;
        private double goldToEuro = 100;
        private double electrumToEuro = 50;
        private double silverToEuro = 10;
        private double copperToEuro = 1;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
            inventory.Items = new List<Item>();
            inventory.Lifestyles = new List<Item>();

            // JSON mit Preisen laden und deserialisieren
            string jsonFilePath = "prices.json";
            string priceData = File.ReadAllText(jsonFilePath);
            var inventoryData = JsonSerializer.Deserialize<Inventory>(priceData);
            inventory.Items = inventoryData.Items;
            inventory.Lifestyles = inventoryData.Lifestyles;

            // Fülle das Dropdown-Menü für Items
            foreach (Item item in inventoryData.Items)
            {
                dropdownPriceItem.Items.Add(item.Name);
            }

            // Fülle das Dropdown-Menü für Lifestyles
            foreach (Item lifestyle in inventoryData.Lifestyles)
            {
                dropdownPriceLifestyle.Items.Add(lifestyle.Name);
            }

            // Ereignishandler für das Dropdown-Menü dropdownPriceLifestyle hinzufügen
            dropdownPriceLifestyle.SelectedIndexChanged += priceLifestyle_Selected;
            dropdownPriceItem.SelectedIndexChanged += priceItems_Selected;
        }

        // Verabeitung der Auswahl im Dropdown Menü für Items
        private void priceItems_Selected(object sender, EventArgs e)
        {
            // Überprüfe, ob ein Item ausgewählt wurde
            if (dropdownPriceItem.SelectedIndex != -1)
            {
                // Rufe den ausgewählten Lifestyle ab
                string selectedItemName = dropdownPriceItem.SelectedItem.ToString();

                // Suche den ausgewählten Lifestyle in der Liste der Lifestyles
                Item selectedItem = inventory.Items.Find(l => l.Name == selectedItemName);

                // Überprüfe, ob der ausgewählte Lifestyle gefunden wurde
                if (selectedItem != null)
                {
                    // Berechnung des Europreises
                    double euroPreis = 0;

                    switch (selectedItem.Currency)
                    {
                        case "pp":
                            euroPreis = selectedItem.Value * platinToEuro;
                            break;
                        case "gp":
                            euroPreis = selectedItem.Value * goldToEuro;
                            break;
                        case "ep":
                            euroPreis = selectedItem.Value * electrumToEuro;
                            break;
                        case "sp":
                            euroPreis = selectedItem.Value * silverToEuro;
                            break;
                        case "cp":
                            euroPreis = selectedItem.Value * copperToEuro;
                            break;
                        default:
                            break;
                    }

                    // Aktualisiere das Label priceLifestyle mit dem Wert und der Währung des ausgewählten Lifestyles
                    priceItem.Text = $"{selectedItem.Value} {selectedItem.Currency} = {euroPreis} €";
                    priceItem.Visible = true;
                }
                else
                {
                    // Fehlerbehandlung: Lifestyle nicht gefunden
                    MessageBox.Show("Der ausgewählte Lifestyle wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Verabeitung der Auswahl im Dropdown Menü für Lifestyles
        private void priceLifestyle_Selected(object sender, EventArgs e)
        {
            // Überprüfe, ob ein Lifestyle ausgewählt wurde
            if (dropdownPriceLifestyle.SelectedIndex != -1)
            {
                // Rufe den ausgewählten Lifestyle ab
                string selectedLifestyleName = dropdownPriceLifestyle.SelectedItem.ToString();

                // Suche den ausgewählten Lifestyle in der Liste der Lifestyles
                Item selectedLifestyle = inventory.Lifestyles.Find(l => l.Name == selectedLifestyleName);

                // Überprüfe, ob der ausgewählte Lifestyle gefunden wurde
                if (selectedLifestyle != null)
                {
                    // Berechnung des Europreises
                    double euroPreis = 0;

                    switch (selectedLifestyle.Currency)
                    {
                        case "pp":
                            euroPreis = selectedLifestyle.Value * platinToEuro;
                            break;
                        case "gp":
                            euroPreis = selectedLifestyle.Value * goldToEuro;
                            break;
                        case "ep":
                            euroPreis = selectedLifestyle.Value * electrumToEuro;
                            break;
                        case "sp":
                            euroPreis = selectedLifestyle.Value * silverToEuro;
                            break;
                        case "cp":
                            euroPreis = selectedLifestyle.Value * copperToEuro;
                            break;
                        default:
                            break;
                    }

                    // Aktualisiere das Label priceLifestyle mit dem Wert und der Währung des ausgewählten Lifestyles
                    priceLifestyle.Text = $"{selectedLifestyle.Value} {selectedLifestyle.Currency} = {euroPreis} € pro Tag";
                    priceLifestyle.Visible = true;
                }
                else
                {
                    // Fehlerbehandlung: Lifestyle nicht gefunden
                    MessageBox.Show("Der ausgewählte Lifestyle wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Prüfen, ob Enter gedrückt wird und berechnet werden kann
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

    // Vorbereitung für die Dropdown Listen
    public class Item
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public int Value { get; set; }
    }

    public class Inventory
    {
        public List<Item> Items { get; set; }
        public List<Item> Lifestyles { get; set; }
    }
}
