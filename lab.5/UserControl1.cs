using lab._5.FolderforModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab._5
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //Метод для заполнения control user
        public void Fill(Table_Motorbike motorbike)//
        {
            labellDData.Text = motorbike.ID.ToString();
            labelModelData.Text = motorbike.Model;
            labelBrandData.Text = motorbike.Brand;
            labelPriceData.Text = motorbike.Price.ToString();
            labelHorsepowerData.Text = motorbike.Horsepower.ToString();
            labelMileageData.Text = motorbike.Milieage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{motorbike.Picture}");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
