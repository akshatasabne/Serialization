using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.InteropServices.ComTypes;
using System.Text.Json;

namespace Binary_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter=new SoapFormatter();
                Product product = new Product();
                product.Id = Convert.ToInt32(textid.Text);
                product.Name = textname.Text;
                product.Price = Convert.ToDouble(textprice.Text);
                soapFormatter.Serialize(fileStream, product);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Product product = new Product();
                product.Id = Convert.ToInt32(textid.Text);
                product.Name = textname.Text;
                product.Price = Convert.ToDouble(textprice.Text);
                formatter.Serialize(fileStream, product);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Product product = new Product();
              // we done explicit type casting from Object --> Product
                product= (Product)formatter.Deserialize(fileStream);
               textid.Text = product.Id.ToString();
                textname.Text = product.Name;
                textprice.Text = product.Price.ToString();
                
                fileStream.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void xwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product product = new Product();
                product.Id = Convert.ToInt32(textid.Text);
                product.Name = textname.Text;
                product.Price = Convert.ToDouble(textprice.Text);
                xmlSerializer.Serialize(fileStream, product);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void xread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product product = new Product();
                product = (Product)xmlSerializer.Deserialize(fileStream);
                textid.Text = product.Id.ToString();
                textname.Text = product.Name;
                textprice.Text = product.Price.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void sread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product product = new Product();
                // we done explicit type casting from Object --> Product
                product = (Product)soapFormatter.Deserialize(fileStream);
                textid.Text = product.Id.ToString();
                textname.Text = product.Name;
                textprice.Text = product.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void jwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Product product = new Product();
                product.Id = Convert.ToInt32(textid.Text);
                product.Name = textname.Text;
                product.Price = Convert.ToDouble(textprice.Text);
                JsonSerializer.Serialize<Product>(fileStream, product);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void jread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Product product = new Product();
                // we done explicit type casting from Object --> Product
                product = (Product)JsonSerializer.Deserialize<Product>(fileStream);
                textid.Text = product.Id.ToString();
                textname.Text = product.Name;
                textprice.Text = product.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
