using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biblioteka
{
    internal class Library
    {
        public string NameVvod(string name, string author, string year)
        {
            string together;
                together = name + " " + author+ " " + year;
            return together;
        }


        public bool Scan(string tog)
        {
            bool prov = true;
            string[] razdel = tog.Split(" ");
            char [] scanauthor = razdel[1].ToCharArray();
            char[] scanyear = razdel[2].ToCharArray();
            if (razdel[0] == "")
            { 
                MessageBox.Show("Не может быть пустого названия!", "Книга", MessageBoxButtons.OK); 
            prov=false;
            }
            else if (razdel[1] == "") 
            {
                MessageBox.Show("Пустая строка автора!", "Автор", MessageBoxButtons.OK);
                prov = false;
            }
            else if (razdel[2] == "") {MessageBox.Show("Пустая строка года!", "Год", MessageBoxButtons.OK);
                prov = false;
            }
            for (int i = 0; i < scanauthor.Length; i++)
            {
                if (!Char.IsLetter(scanauthor[i]))
                {
                    {
                        MessageBox.Show("Не может быть цифр или знаков в строке автор", "Автор", MessageBoxButtons.OK);
                        prov = false;
                        break;
                    }
                }
            }
            for (int count=0; count<scanyear.Length;count++)
            {
                if (Char.IsLetter(scanyear[count]))
                {
                        MessageBox.Show("Не может быть букв в строке года", "Год", MessageBoxButtons.OK);
                        prov = false;
                        break;
                }
                else if (Char.IsPunctuation(scanyear[count]))
                {
                        MessageBox.Show("Не может быть знаков в строке года", "Год", MessageBoxButtons.OK);
                        prov = false;
                        break;
                }
            }
            if (scanyear.Length > 4)
            {
                MessageBox.Show("Некорректный ввод года (пример: 2000)", "Год", MessageBoxButtons.OK);
                prov = false;
            }

            return prov;
        }

    }

}

