using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab._5.FolderforModel;

namespace lab._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();//глобальная статическая переменная которая необходима для работы с классом ModelDB
        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();//Список класса Table_Motorbike содержащий данные из одноименной таблицы SQL
        int AccNumber = 0;//Переменная нужная для того, чобы программа понимала на каком элементе из списка Motorbikes мы сейчас находимся

        private void Loading() 
        {
            userControl11.Fill(Motorbikes[AccNumber+1]);
            userControlName1.Fill(Motorbikes[AccNumber]);
        }

        private void Loading(bool Incr) //Перегрузка метода Loading, что бы на вход были другие параметры
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)//Провекра при нажатии "Листать вправо"
                AccNumber++;
            else if (Incr == false && Motorbikes.Count > AccNumber - 1)//Провекра при нажатии "Листать влево"
                AccNumber--;
            else
                return;//Если проверка не пройдена выход из метода
            Loading();
        }

        private void Form1_Load(object sender, EventArgs e)//Событие загрузки данной формы
        {
            Loading();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }
    }
}
