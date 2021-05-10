using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get Method Names and fill the Comboboxes
            MethodInfo[] methodInfos = Type.GetType("CurrencyConverter.Currency")
                           .GetMethods(BindingFlags.Public | BindingFlags.Static);
            foreach (var item in methodInfos)
            {
                string currentItem = item.Name.Substring(4);
                //comboBox1.Items.Add(currentItem); //To limit base currency to EUR only for free subscription
                comboBox2.Items.Add(currentItem);
            }
            

            richTextBox1.Clear();
            foreach (Rate item in Money.GetRates(Currency.EUR))
            {
                richTextBox1.AppendText(item.CurrencyName + " = " + item.Value + "\n");
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            toolStripStatusLabel1.Text = Money.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                Currency FromCurrency = new Currency(comboBox1.SelectedItem.ToString());
                Currency ToCurrency = new Currency(comboBox2.SelectedItem.ToString());

                double result = Money.FromTo(double.Parse(textBox1.Text), FromCurrency, ToCurrency);

                textBox2.Text = result.ToString();
            }
        }
    }
}
