using CepLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiTurmaTarde
{
    public partial class Form1 : Form
    {
        private List<string> Emails = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Criar um Email
            MailMessage mail = new MailMessage();

            //Definir os Endereços
            mail.From = new MailAddress("testeentra21@gmail.com");
            mail.To.Add(txtEmail.Text);

            //Definir o Conteudo
            mail.Subject = "Teste Email no C#";
            mail.Body = "Prezado(a) cliente, use o codigo a seguir para completar o cadastro : \n 563691";

            // Enviar o Email
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("testeentra21@gmail.com", "@Senac2021");
            smtp.Send(mail);
            txtEmail.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Emails.Add(txtEmail.Text);
            txtEmail.Clear();
        }

        private void btnET_Click(object sender, EventArgs e)
        {
            //Criar um Email
            MailMessage mail = new MailMessage();

            //Definir os Endereços
            mail.From = new MailAddress("testeentra21@gmail.com");
            foreach (var item in Emails)
            {
                mail.To.Add(item);
            }
            //Definir o Conteudo
            mail.Subject = "Teste Email no C#";
            mail.Body = "Prezado(a) cliente, use o codigo a seguir para completar o cadastro : \n 563691";

            // Enviar o Email
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("testeentra21@gmail.com", "@Senac2021");
            smtp.Send(mail);
            txtEmail.Clear();
            Emails.Clear();
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            Endereco end = Cep.Scrap(txtCep.Text);
            lblCep.Text = end.Bairro;
            lblCep.Text += "\n" + end.Localidade;
            lblCep.Text += "\n" + end.Logradouro;
            lblCep.Text += "\n" + end.Uf;
            txtCep.Clear();
        }
    }
}
