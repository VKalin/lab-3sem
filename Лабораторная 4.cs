using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WindowsFormsFiles
{
public partial classForm1 :Form
    {
public Form1()
{
    Initialize Component();
}

///<summary>
///Списокслов
///</summary>
List<string> list = new List<string>();

privatevoidbuttonLoadFile_Click(object sender, EventArgs e)
{
    OpenFileDialog fd = new OpenFileDialog();
    fd.Filter = "текстовыефайлы|*.txt";

    if (fd.ShowDialog() == DialogResult.OK)
    {
        Stopwatch t = new Stopwatch();
        t.Start();

        //Чтениефайлаввидестроки
        string text = File.ReadAllText(fd.FileName);

        //Разделительные символы для чтения из файла
        char[] separators = new char[] { ' ','.',',','!','?','/','\t','\n'};

        string[] textArray = text.Split(separators);

        foreach (string strTempintextArray)
        {
            //Удаление пробелов в начале и конце строки
            string str = str Temp.Trim();
            //Добавление строки в список, если строка не содержится в списке
            if (!list.Contains(str)) list.Add(str);
        }

        t.Stop();
        this.textBoxFileReadTime.Text = t.Elapsed.ToString();
        this.textBoxFileReadCount.Text = list.Count.ToString();
    }
    else
    {
        MessageBox.Show("Может всё-таки выберете файл?");
    }
}

privatevoidbuttonExact_Click(object sender, EventArgs e) //Кнопкачёткогопоиска
{
    //Словодляпоиска
    string word = this.textBoxFind.Text.Trim();

    //Если слово для поиска не пусто
    if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
    {
        //Слово для поиска в верхнем регистре
        string wordUpper = word.ToUpper();

        //Временные результаты поиска
        List<string> tempList = new List<string>();

        Stopwatch t = new Stopwatch();
        t.Start();

        foreach (string str in list)
        {
            if (str.ToUpper().Contains(wordUpper))
            {
                tempList.Add(str);
            }
        }

        t.Stop();
        this.textBoxExactTime.Text = t.Elapsed.ToString();

        this.listBoxResult.BeginUpdate();

        //Очисткасписка
        this.listBoxResult.Items.Clear();

        //Выводрезультатовпоиска
        foreach (string str in tempList)
        {
            this.listBoxResult.Items.Add(str);
        }
        this.listBoxResult.EndUpdate();
    }
    else
    {
        MessageBox.Show("Лучше бы Вывыбрали файл и ввели слово для поиска");
    }
}

private void buttonExit_Click(object sender, EventArgs e)
{
    this.Close();
}

private void Form1_Load(object sender, EventArgs e)
{

}

private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
{

}
    }
}
