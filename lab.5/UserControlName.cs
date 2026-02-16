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
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }

        //Метод для заполнения control user
        public void Fill( Table_Motorbike motorbike)//Впараметры на входе в метод экземпляр класса Table_Motorbike
        {
            labellDData.Text = motorbike.ID.ToString();
            labelModelData.Text = motorbike.Model;
            labelBrandData.Text = motorbike.Brand;
            labelPriceData.Text = motorbike.Price.ToString();
            labelHorsepowerData.Text = motorbike.Horsepower.ToString();
            labelMileageData.Text = motorbike.Milieage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{motorbike.Picture}");
        }
    }
}
