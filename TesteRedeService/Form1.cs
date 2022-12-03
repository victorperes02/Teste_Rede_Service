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
using Correios.NET;
using Correios.NET.Models;
//using consultaCEP;


namespace TesteRedeService
{
    public partial class Form1 : Form
    {
        List<int> numeros = new List<int>();
        public Form1()
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
            string CaminhoNome = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"//numeros_ordenar.txt";
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
            string CaminhoNome = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"//numeros_ordenar.txt";
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
    }
}
