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




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Kazan : Form
    {
        public Kazan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chekInDate = dateTimePicker1.Value;
            DateTime chekOutDate = dateTimePicker2.Value;

            TimeSpan duraction = chekOutDate - chekInDate;
            int numDays = duraction.Days;

            MessageBox.Show($"Количество дней: {numDays}");

            if ( numDays == 0 || numDays < 0)
            {
                MessageBox.Show("Приезд возможен не менее чем на один день", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int size = 4000; // Стоимость билета
                int totalAmount = numDays * size;

                string checkText = $"Отель: {label1.Text}" + Environment.NewLine +
                    $"Даты пребывания: {chekInDate.ToString("dd MMMM")} - {chekOutDate.ToString("dd MMMM")}" + Environment.NewLine +
                $"Количество дней: {numDays}" + Environment.NewLine +
                    $"Стоимость билета: {size} руб" + Environment.NewLine +
                $"Итоговая сумма: {totalAmount} руб." + Environment.NewLine;

                if (MessageBox.Show(checkText, "Сохранение чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt) |*txt";
                    saveFileDialog.FileName = "Чек.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.None)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show("Чек успешно сохранен!", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show(DialogResult.ToString());
                        MessageBox.Show("Сохранение чека отменено.", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }   
            }  
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Krasnoyarsk : Form
    {
        public Krasnoyarsk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chekInDate = dateTimePicker1.Value;
            DateTime chekOutDate = dateTimePicker2.Value;

            TimeSpan duraction = chekOutDate - chekInDate;
            int numDays = duraction.Days;

            MessageBox.Show($"Количество дней: {numDays}");

            if (numDays == 0 || numDays < 0)
            {
                MessageBox.Show("Приезд возможен не менее чем на один день", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int size = 4000; // Стоимость билета
                int totalAmount = numDays * size;

                string checkText = $"Отель: {label1.Text}" + Environment.NewLine +
                    $"Даты пребывания: {chekInDate.ToString("dd MMMM")} - {chekOutDate.ToString("dd MMMM")}" + Environment.NewLine +
                $"Количество дней: {numDays}" + Environment.NewLine +
                    $"Стоимость билета: {size} руб" + Environment.NewLine +
                $"Итоговая сумма: {totalAmount} руб." + Environment.NewLine;

                if (MessageBox.Show(checkText, "Сохранение чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt) |*txt";
                    saveFileDialog.FileName = "Чек.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.None)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show("Чек успешно сохранен!", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show(DialogResult.ToString());
                        MessageBox.Show("Сохранение чека отменено.", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Moscow : Form
    {
        public Moscow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chekInDate = dateTimePicker1.Value;
            DateTime chekOutDate = dateTimePicker2.Value;

            TimeSpan duraction = chekOutDate - chekInDate;
            int numDays = duraction.Days;

            MessageBox.Show($"Количество дней: {numDays}");

            if (numDays == 0 || numDays < 0)
            {
                MessageBox.Show("Приезд возможен не менее чем на один день", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int size = 4000; // Стоимость билета
                int totalAmount = numDays * size;

                string checkText = $"Отель: {label1.Text}" + Environment.NewLine +
                    $"Даты пребывания: {chekInDate.ToString("dd MMMM")} - {chekOutDate.ToString("dd MMMM")}" + Environment.NewLine +
                $"Количество дней: {numDays}" + Environment.NewLine +
                    $"Стоимость билета: {size} руб" + Environment.NewLine +
                $"Итоговая сумма: {totalAmount} руб." + Environment.NewLine;

                if (MessageBox.Show(checkText, "Сохранение чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt) |*txt";
                    saveFileDialog.FileName = "Чек.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.None)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show("Чек успешно сохранен!", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show(DialogResult.ToString());
                        MessageBox.Show("Сохранение чека отменено.", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Novosibirsk : Form
    {
        public Novosibirsk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chekInDate = dateTimePicker1.Value;
            DateTime chekOutDate = dateTimePicker2.Value;

            TimeSpan duraction = chekOutDate - chekInDate;
            int numDays = duraction.Days;

            MessageBox.Show($"Количество дней: {numDays}");

            if (numDays == 0 || numDays < 0)
            {
                MessageBox.Show("Приезд возможен не менее чем на один день", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int size = 4000; // Стоимость билета
                int totalAmount = numDays * size;

                string checkText = $"Отель: {label1.Text}" + Environment.NewLine +
                    $"Даты пребывания: {chekInDate.ToString("dd MMMM")} - {chekOutDate.ToString("dd MMMM")}" + Environment.NewLine +
                $"Количество дней: {numDays}" + Environment.NewLine +
                    $"Стоимость билета: {size} руб" + Environment.NewLine +
                $"Итоговая сумма: {totalAmount} руб." + Environment.NewLine;

                if (MessageBox.Show(checkText, "Сохранение чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt) |*txt";
                    saveFileDialog.FileName = "Чек.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.None)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show("Чек успешно сохранен!", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show(DialogResult.ToString());
                        MessageBox.Show("Сохранение чека отменено.", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bileti
{
    public partial class Piter : Form
    {
        public Piter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime chekInDate = dateTimePicker1.Value;
            DateTime chekOutDate = dateTimePicker2.Value;

            TimeSpan duraction = chekOutDate - chekInDate;
            int numDays = duraction.Days;

            MessageBox.Show($"Количество дней: {numDays}");

            if (numDays == 0 || numDays < 0)
            {
                MessageBox.Show("Приезд возможен не менее чем на один день", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int size = 4000; // Стоимость билета
                int totalAmount = numDays * size;

                string checkText = $"Отель: {label1.Text}" + Environment.NewLine +
                    $"Даты пребывания: {chekInDate.ToString("dd MMMM")} - {chekOutDate.ToString("dd MMMM")}" + Environment.NewLine +
                $"Количество дней: {numDays}" + Environment.NewLine +
                    $"Стоимость билета: {size} руб" + Environment.NewLine +
                $"Итоговая сумма: {totalAmount} руб." + Environment.NewLine;

                if (MessageBox.Show(checkText, "Сохранение чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt) |*txt";
                    saveFileDialog.FileName = "Чек.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.None)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show("Чек успешно сохранен!", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(checkText);
                        }

                        MessageBox.Show(DialogResult.ToString());
                        MessageBox.Show("Сохранение чека отменено.", "Сохранение чека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}



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
    public partial class ViborBileta : Form
    {
        public ViborBileta()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Moscow moscow = new Moscow();
            moscow.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Piter piter = new Piter();
            piter.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Kazan kazan = new Kazan();
            kazan.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Novosibirsk novosibirsk = new Novosibirsk();
            novosibirsk.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Krasnoyarsk krasnoyarsk = new Krasnoyarsk();
            krasnoyarsk.Show();
        }
    }
}
