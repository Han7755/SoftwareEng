using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FoodSearch : Main
    {
        public FoodSearch()
        {
            InitializeComponent();
        }

        private void FoodSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)//식품 정보 상세보기
        {

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();
            listBox1.Items.Clear();
            string name = textBox1.Text;
            list = FoodDB.getter(name);
            UserDB userDB = new UserDB();
            userDB.getter();
            int userAllergy = (int)userDB.allergy;
            if (checkBox1.Checked==true)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (((int)list[i].Allergy&userAllergy)!=0)
                        continue;
                    listBox1.Items.Add(list[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    listBox1.Items.Add(list[i].Name);
                }
            }


        }
        public static List<Product> products = new List<Product>();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            products.Clear();
            string a = listBox1.SelectedItem.ToString();
            products = FoodDB.getter(a, 1);
            
            this.Visible=false;         // 추가

            FoodCheck showForm5 = new FoodCheck();
            showForm5.product=products[0];
            showForm5.ShowDialog();
        }
    }
}
