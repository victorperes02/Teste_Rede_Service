
namespace TesteRedeService
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
        public void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Question1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.inputq1_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question3_4_5 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Question6 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textcep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Question7 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Question8 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Question1.SuspendLayout();
            this.Question3_4_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Question6.SuspendLayout();
            this.Question7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Question8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Question1);
            this.tabControl1.Controls.Add(this.Question3_4_5);
            this.tabControl1.Controls.Add(this.Question6);
            this.tabControl1.Controls.Add(this.Question7);
            this.tabControl1.Controls.Add(this.Question8);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // Question1
            // 
            this.Question1.Controls.Add(this.button3);
            this.Question1.Controls.Add(this.button2);
            this.Question1.Controls.Add(this.listView1);
            this.Question1.Controls.Add(this.button1);
            this.Question1.Controls.Add(this.inputq1_2);
            this.Question1.Controls.Add(this.label2);
            this.Question1.Controls.Add(this.label1);
            this.Question1.Location = new System.Drawing.Point(4, 24);
            this.Question1.Name = "Question1";
            this.Question1.Padding = new System.Windows.Forms.Padding(3);
            this.Question1.Size = new System.Drawing.Size(796, 436);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "Q1 e Q2";
            this.Question1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Abrir Arquivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gravar Lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(16, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(336, 137);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputq1_2
            // 
            this.inputq1_2.Location = new System.Drawing.Point(31, 84);
            this.inputq1_2.Name = "inputq1_2";
            this.inputq1_2.Size = new System.Drawing.Size(100, 23);
            this.inputq1_2.TabIndex = 3;
            this.inputq1_2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(723, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Agora grave os números visualizados cada 1 em uma linha em um arquivo de texto" +
    " na pasta raiz da aplicação de numeros_ordenar.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Faça a aplicação permitir a digitação de números e mostre esses números em tel" +
    "a de forma ordenada";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Question3_4_5
            // 
            this.Question3_4_5.Controls.Add(this.label13);
            this.Question3_4_5.Controls.Add(this.label12);
            this.Question3_4_5.Controls.Add(this.button8);
            this.Question3_4_5.Controls.Add(this.button5);
            this.Question3_4_5.Controls.Add(this.label5);
            this.Question3_4_5.Controls.Add(this.dataGridView1);
            this.Question3_4_5.Location = new System.Drawing.Point(4, 24);
            this.Question3_4_5.Name = "Question3_4_5";
            this.Question3_4_5.Padding = new System.Windows.Forms.Padding(3);
            this.Question3_4_5.Size = new System.Drawing.Size(796, 436);
            this.Question3_4_5.TabIndex = 1;
            this.Question3_4_5.Text = "Q3,Q4 e Q5";
            this.Question3_4_5.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(483, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "5. Crie um Grid, leia o arquivo data.json que foi gravado, e mostre os dados no G" +
    "rid criado.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(463, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "4. Grave a lista do item 3, em um arquivo de nome data.json na pasta raiz da apli" +
    "cação.";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(213, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Carregar Grid";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Criar arquivo data.json";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(517, 60);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(704, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // Question6
            // 
            this.Question6.Controls.Add(this.label17);
            this.Question6.Controls.Add(this.label16);
            this.Question6.Controls.Add(this.label15);
            this.Question6.Controls.Add(this.label14);
            this.Question6.Controls.Add(this.txtBairro);
            this.Question6.Controls.Add(this.txtCidade);
            this.Question6.Controls.Add(this.txtRua);
            this.Question6.Controls.Add(this.txtEstado);
            this.Question6.Controls.Add(this.button6);
            this.Question6.Controls.Add(this.textcep);
            this.Question6.Controls.Add(this.label7);
            this.Question6.Controls.Add(this.label6);
            this.Question6.Location = new System.Drawing.Point(4, 24);
            this.Question6.Name = "Question6";
            this.Question6.Padding = new System.Windows.Forms.Padding(3);
            this.Question6.Size = new System.Drawing.Size(796, 436);
            this.Question6.TabIndex = 2;
            this.Question6.Text = "Q6";
            this.Question6.UseVisualStyleBackColor = true;
            this.Question6.Click += new System.EventHandler(this.Question6_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Bairro:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Rua:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Estado:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(24, 333);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(350, 23);
            this.txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(24, 271);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(350, 23);
            this.txtCidade.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(24, 390);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(350, 23);
            this.txtRua.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(24, 203);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(350, 23);
            this.txtEstado.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(217, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Consultar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textcep
            // 
            this.textcep.Location = new System.Drawing.Point(95, 130);
            this.textcep.Name = "textcep";
            this.textcep.Size = new System.Drawing.Size(100, 23);
            this.textcep.TabIndex = 2;
            this.textcep.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informe o CEP";
            // 
            // Question7
            // 
            this.Question7.Controls.Add(this.dataGridView2);
            this.Question7.Controls.Add(this.button7);
            this.Question7.Controls.Add(this.label11);
            this.Question7.Controls.Add(this.label10);
            this.Question7.Controls.Add(this.label9);
            this.Question7.Controls.Add(this.label8);
            this.Question7.Location = new System.Drawing.Point(4, 24);
            this.Question7.Name = "Question7";
            this.Question7.Padding = new System.Windows.Forms.Padding(3);
            this.Question7.Size = new System.Drawing.Size(796, 436);
            this.Question7.TabIndex = 3;
            this.Question7.Text = "Q7";
            this.Question7.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(388, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(66, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // Question8
            // 
            this.Question8.Controls.Add(this.button4);
            this.Question8.Controls.Add(this.label4);
            this.Question8.Controls.Add(this.label3);
            this.Question8.Location = new System.Drawing.Point(4, 24);
            this.Question8.Name = "Question8";
            this.Question8.Padding = new System.Windows.Forms.Padding(3);
            this.Question8.Size = new System.Drawing.Size(796, 436);
            this.Question8.TabIndex = 4;
            this.Question8.Text = "Q8";
            this.Question8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Baixar Imagem e Gravar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(724, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "8. Pela aplicação faça o download da imagem https://redeservice.com.br/wpcontent/" +
    "uploads/2020/07/redeservice-logo.png, colocar na";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "pasta do sistema, e criar alguma função para ler essa imagem e mostrar em tela no" +
    " formato base64.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Avaliação Progamador .NET";
            this.tabControl1.ResumeLayout(false);
            this.Question1.ResumeLayout(false);
            this.Question1.PerformLayout();
            this.Question3_4_5.ResumeLayout(false);
            this.Question3_4_5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Question6.ResumeLayout(false);
            this.Question6.PerformLayout();
            this.Question7.ResumeLayout(false);
            this.Question7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Question8.ResumeLayout(false);
            this.Question8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Question1;
        private System.Windows.Forms.TabPage Question3_4_5;
        private System.Windows.Forms.TabPage Question6;
        private System.Windows.Forms.TabPage Question7;
        private System.Windows.Forms.TabPage Question8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputq1_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public  System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textcep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtEstado;
    }
}

