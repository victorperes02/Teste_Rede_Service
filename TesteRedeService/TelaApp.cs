using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;
using System.Collections;
using System.Web;/*
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Newtonsoft.Json;*/
using System.Collections.Generic;
using System.Net;

namespace TesteRedeService
{
    public partial class TelaApp : Form
    {
        List<int> numeros = new List<int>();
        public TelaApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CaminhoNome = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//numeros_ordenar.txt";
            StreamWriter nm_arquivo = new StreamWriter(CaminhoNome);
            // FileInfo file = new FileInfo(CaminhoNome);
            if (!File.Exists(CaminhoNome))
            {
                File.CreateText(CaminhoNome);
            }
            for (int i = 0; i < numeros.Count(); i++)
            {
                nm_arquivo.WriteLine(numeros[i].ToString());
            }
            nm_arquivo.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int input = int.Parse(this.inputq1_2.Text);

            numeros.Add(input);
            //  string strValores = String.Empty;
            numeros.Sort();

            foreach (int item in numeros)
            {
                //strValores += "\n" + item.ToString();


                listView1.Items.Add(item.ToString());
            }

            /* for (int i = 0; i < numeros.Count; i++)
              {
                      numeros[i] = input;
                listView1.Items.AddRange(numeros.IndexOf(i));
            }*/


            //  foreach (int p in numeros.Sort() ;

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CaminhoNome = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//numeros_ordenar.txt";
            System.Diagnostics.Process.Start("notepad.exe", CaminhoNome);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.textcep.Text))
            {
                MessageBox.Show("Informe um CEP válido!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var enderecoERP = ws.consultaCEP(this.textcep.Text.Trim());

                    this.txtEstado.Text = enderecoERP.uf;
                    this.txtCidade.Text = enderecoERP.cidade;
                    this.txtBairro.Text = enderecoERP.bairro;
                    this.txtRua.Text = enderecoERP.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Question6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e1)
        {
            /*public void Page_Load(object sender, EventArgs e1)
            {*/
        }
                public class Item
        {
            public string ispb { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string fullName { get; set; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            start_get();
            void start_get()
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://brasilapi.com.br/api/banks/v1"));

                WebReq.Method = "GET";

                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                string jsonString;
                using (Stream stream = WebResp.GetResponseStream())  
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }

                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(jsonString);


                dynamic table = JsonConvert.DeserializeObject(jsonString);
                DataTable newTable = new DataTable();
                newTable.Columns.Add("ispb", typeof(string));
                newTable.Columns.Add("name", typeof(string));
                newTable.Columns.Add("code", typeof(string));
                newTable.Columns.Add("fullName", typeof(string));

                foreach (var row in table)
                {
                    newTable.Rows.Add(row.ispb, row.name, row.code, row.fullName);
                }
                this.dataGridView2.DataSource = newTable;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeArquivo = "C:\\Users\\victor.santos\\Documents\\Teste_Rede_Service\\TesteRedeService\\logo.png";
                using (WebClient cliente = new WebClient())
                {
                    cliente.DownloadFile("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png", nomeArquivo);
                }
                string CaminhoNome = "C:\\Users\\victor.santos\\Documents\\Teste_Rede_Service\\TesteRedeService\\logo.png";
                string base64 = Convert.ToBase64String(File.ReadAllBytes(CaminhoNome));
                this.Boxbase64.Text = base64;
                    }
                 catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
    }                     
        
