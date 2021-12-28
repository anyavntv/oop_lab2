using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string _xmlPath;
        private bool _IsCreated;
        List<Laptop> currentlyDisplayed;
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StartSearchAlgorithm()
        {
            Laptop searchRequest = new Laptop
            {
                Manufacturer = ManufacturerComboBox.SelectedItem.ToString(),
                Price = PriceTextBox.Text,
                Condition = ConditionComboBox.SelectedItem.ToString(),
                OS = OSComboBox.SelectedItem.ToString()
            };
            ISearchStrategy strategy = new DomSearchStrategy();
            if (SaxRadioButton.Checked)
                strategy = new SaxSearchStrategy();
            if (LinqRadioButton.Checked)
                strategy = new LinqSearchStrategy();
            Search search = new Search(ref strategy, ref searchRequest, _xmlPath);
            DisplayDocument(search.Run());
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "|*.xml",
                Title = "Відкрийте .xml файл"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            _xmlPath = openFileDialog.FileName;
            LoadDoc(_xmlPath);
        }
        private void LoadDoc(string _xmlPath)
        {
            _IsCreated = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(_xmlPath);
            XmlElement root = doc.DocumentElement;
            XmlNodeList children = root.SelectNodes("Laptop");
            ManufacturerComboBox.Items.Clear();
            ConditionComboBox.Items.Clear();
            OSComboBox.Items.Clear();
            for (int i = 0; i < children.Count; i++)
            {
                XmlNode node = children.Item(i);
                AddSearchBoxItems(node);
            }
            List<Laptop> laptops = new List<Laptop>();
            foreach (XmlNode node in root.ChildNodes)
            {
                Laptop laptop = new Laptop();
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    if (attribute.Name.Equals("Manufacturer"))
                        laptop.Manufacturer = attribute.Value;
                    if (attribute.Name.Equals("Price"))
                        laptop.Price = attribute.Value;
                    if (attribute.Name.Equals("Condition"))
                        laptop.Condition = attribute.Value;
                    if (attribute.Name.Equals("OS"))
                        laptop.OS = attribute.Value;
                    if (attribute.Name.Equals("Model"))
                        laptop.Model = attribute.Value;
                    if (attribute.Name.Equals("SerialNumber"))
                        laptop.SerialNumber = attribute.Value;
                }
                laptops.Add(laptop);
            }
            DisplayDocument(laptops);
            ResetSearchOptions();
            AlgoGroupBox.Enabled = true;
            SearchGroupBox.Enabled = true;
            TransformGroupBox.Enabled = true;
            _IsCreated = true;
        }
        private void DisplayDocument(List<Laptop> laptops)
        {
            TextOutput.Clear();
            if (laptops.Count == 0)
                TextOutput.Text = "\n\n\n\n\n\n\n\n\n\nНемає результатів, що задовольняють умовам пошуку";
            foreach(Laptop laptop in laptops)
            {
                TextOutput.Text += "Виробник: " + laptop.Manufacturer + "\n";
                TextOutput.Text += "Модель: " + laptop.Model + "\n";
                TextOutput.Text += "Серійний номер: " + laptop.SerialNumber + "\n";
                TextOutput.Text += "Ціна: " + laptop.Price + "\n";
                TextOutput.Text += "Стан: " + laptop.Condition + "\n";
                TextOutput.Text += "Операційна система: " + laptop.OS + "\n";
                TextOutput.Text += "\n\n";
            }
            currentlyDisplayed = laptops;
            ActiveControl = TextOutput;
            TextOutput.Focus();
        }
        private void AddSearchBoxItems(XmlNode node)
        {
            if (!OSComboBox.Items.Contains(node.SelectSingleNode("@OS").Value))
            {
                OSComboBox.Items.Add(node.SelectSingleNode("@OS").Value);
                if (OSComboBox.Items.Count == 2)
                    OSComboBox.Items.Add("Будь-яка");
            }
            if (!ConditionComboBox.Items.Contains(node.SelectSingleNode("@Condition").Value))
            {
                ConditionComboBox.Items.Add(node.SelectSingleNode("@Condition").Value);
                if (ConditionComboBox.Items.Count == 2)
                    ConditionComboBox.Items.Add("Будь-який");
            }

            if (!ManufacturerComboBox.Items.Contains(node.SelectSingleNode("@Manufacturer").Value))
            {
                ManufacturerComboBox.Items.Add(node.SelectSingleNode("@Manufacturer").Value);
                if (ManufacturerComboBox.Items.Count == 2)
                    ManufacturerComboBox.Items.Add("Будь-який");
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            ResetSearchOptions();
        }
        private void ResetSearchOptions()
        {
            ManufacturerComboBox.SelectedIndex = ManufacturerComboBox.Items.Count - 1;
            PriceTextBox.Text = "0-999999";
            ConditionComboBox.SelectedIndex = ConditionComboBox.Items.Count - 1;
            OSComboBox.SelectedIndex = OSComboBox.Items.Count - 1;
            DomRadioButton.Checked = true;
        }
        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxChanged();
        }
        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBoxChanged();
            }
        }
        private void TextBoxChanged()
        {
            if (!_IsCreated)
            {
                return;
            }

            if (!PriceRange.CheckFormat(PriceTextBox.Text))
            {
                MessageBox.Show("Задайте діапазон цін, наприклад, 12000-14000\n\nПоточне значення буде замінено значенням за замовчуванням", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTextBox.Text = "0-999999";
            }
            StartSearchAlgorithm();
        }
        private void ManufacturerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            StartSearchAlgorithm();
        }
        private void ConditionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            StartSearchAlgorithm();
        }
        private void OSComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            StartSearchAlgorithm();
        }
        private void DomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            if (!DomRadioButton.Checked)
                return;
            StartSearchAlgorithm();
        }
        private void SaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            if (!SaxRadioButton.Checked)
                return;
            StartSearchAlgorithm();
        }
        private void LinqRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_IsCreated)
                return;
            if (!LinqRadioButton.Checked)
                return;
            StartSearchAlgorithm();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрити програму?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void TransformButton_Click(object sender, EventArgs e)
        {
            Transform();
        }
        private void Transform()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XSL|*.xsl",
                Title = "Відкрийте .xsl файл для трансформування"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string xslPath = openFileDialog.FileName;
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(xslPath);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "|*.html",
                Title = "Зберегти .html файл    ",
                FileName = "TransformedHTML",
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string htmlPath = saveFileDialog.FileName;
            xct.Transform(CurrDispToXml(currentlyDisplayed), htmlPath);
            MessageBox.Show("HTML-файл збережено");
        }
        private string CurrDispToXml(List<Laptop> currentlyDisplayed)
        {
            XDocument xdoc = new XDocument();
            XElement laptops = new XElement("LaptopCatalog");
            foreach(Laptop laptop in currentlyDisplayed)
            {
                XElement newlatop = new XElement("Laptop");
                newlatop.Add(new XAttribute("OS", laptop.OS));
                newlatop.Add(new XAttribute("Condition", laptop.Condition));
                newlatop.Add(new XAttribute("Price", laptop.Price));
                newlatop.Add(new XAttribute("SerialNumber", laptop.SerialNumber));
                newlatop.Add(new XAttribute("Model", laptop.Model));
                newlatop.Add(new XAttribute("Manufacturer", laptop.Manufacturer));
                laptops.Add(newlatop);
            }
            xdoc.Add(laptops);
            string path = "currentlyDisplayed.xml";
            xdoc.Save(path);
            return path;
        }
    }
}
