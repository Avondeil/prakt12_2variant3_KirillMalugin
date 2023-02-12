using Microsoft.VisualBasic.Logging;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        Library library = new Library(); string book="";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            book = library.NameVvod(textBox1.Text, textBox2.Text, textBox3.Text);
            bool prov=library.Scan(book);
            if (!listBox1.Items.Contains(book) && prov)
            {
                listBox1.Items.Add(book);
            }
            else MessageBox.Show("Найдено повторение данных или ошибки", "Сообщение", MessageBoxButtons.OK);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int n = listBox1.SelectedIndex;
            if (n != -1)
            {
                string[] str = listBox1.Items[n].ToString().Split(' ');
                textBox1.Text = str[0];
                textBox2.Text = str[1];
                textBox3.Text = str[2];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Sorted = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                MessageBox.Show("Книга не выбрана", "Сообщение", MessageBoxButtons.OK);
            }
            else listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool prov = true;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string[] razdel = listBox1.Items[i].ToString().Split(" ");
                if (razdel[1] == textBox4.Text)
                {
                    listBox1.SelectedIndex = i;
                    prov = false;
                    break;
                }
            }
            if (textBox4.Text == "") MessageBox.Show("Пустая строка поиска", "Сообщение", MessageBoxButtons.OK);
            else if (prov) MessageBox.Show("Не найдено совпадений", "Сообщение", MessageBoxButtons.OK);
           
        }
    }
}