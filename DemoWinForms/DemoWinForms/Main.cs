using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.Windows.Forms;

namespace DemoWinForms
{
    public partial class Main : Form
    {
        NamedPipeClientStream pipeClient;
        public Main()
        {
            InitializeComponent();
            pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.InOut);
            pipeClient.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salve");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Teste";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void memoryDump_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi o Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede que o som padrão do Enter seja tocado
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string message = txt_nome.Text; // Pegando a mensagem da caixa de texto

            try
            {
                // Enviar a mensagem
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                pipeClient.Write(buffer, 0, buffer.Length);
                pipeClient.Flush(); // Garante que os dados sejam enviados imediatamente

                // Limpar a caixa de texto após enviar
                txt_nome.Clear();

                // Receber a resposta do servidor
                byte[] responseBuffer = new byte[256];
                int bytesRead = pipeClient.Read(responseBuffer, 0, responseBuffer.Length);
                string serverResponse = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);

                // Exibir a resposta do servidor no TextBox na TabPage1
                DisplayResponse(serverResponse);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Método para exibir a resposta do servidor no TextBox da TabPage1
        private void DisplayResponse(string message)
        {
            textBoxResponse.AppendText(message + Environment.NewLine); // Exibir mensagem na TextBox
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pipeClient.Close();
            base.OnFormClosed(e);
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            //Limpa caixa de texto quando clicar
            if (txt_nome.Text == "Digite Aqui")
            {
                txt_nome.Text = "";
            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
