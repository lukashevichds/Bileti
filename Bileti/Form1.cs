using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Length < 3 || textBox2.Text.Length < 3)
            {
                MessageBox.Show("Вы ввели некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string login = textBox1.Text;
                string password = textBox2.Text;

                if(login == "danila" && password == "123")
                {
                    ViborBileta viborBileta = new ViborBileta();
                    viborBileta.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данного пользователя не сущеествует");
                }
            }
        }
    }
}
