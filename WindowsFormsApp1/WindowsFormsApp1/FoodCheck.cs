using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class FoodCheck : Main
    {
        public FoodCheck()
        {
            InitializeComponent();
        }


        private void FoodCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void FoodCheck_Load(object sender, EventArgs e)
        {
            checkLoad();
        }

        public Product product;
        private void checkLoad()
        {
            textBox1.Text = product.Name;
            textBox3.Text = product.Manufacturer;
            if ((product.Allergy&Allergic.Egg)!=0)
                listBox1.Items.Add("난류");
            if ((product.Allergy&Allergic.Milk)!=0)
                listBox1.Items.Add("우유");
            if ((product.Allergy&Allergic.Flour)!=0)
                listBox1.Items.Add("곡류");
            if ((product.Allergy&Allergic.Crab)!=0)
                listBox1.Items.Add("갑각류");
            if ((product.Allergy&Allergic.Almond)!=0)
                listBox1.Items.Add("견과류");
            if ((product.Allergy&Allergic.Fish)!=0)
                listBox1.Items.Add("생선류");
            if ((product.Allergy&Allergic.Molluscs)!=0)
                listBox1.Items.Add("연체류");
            if ((product.Allergy&Allergic.Beef)!=0)
                listBox1.Items.Add("육류");
            if ((product.Allergy&Allergic.Soybean)!=0)
                listBox1.Items.Add("대두");
            if(product.Allergy==Allergic.None)
                listBox1.Items.Add("없음");
        }
    }
}
