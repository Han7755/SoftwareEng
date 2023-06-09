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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 가공식품검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;              // 추가

            FoodSearch showForm1 = new FoodSearch();

            showForm1.ShowDialog();
        }

        private void 레시피검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;            // 추가

            RecipeSearch showForm2 = new RecipeSearch();

            showForm2.ShowDialog();
        }

        private void 개인정보등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;           // 추가

            UserReg showForm3 = new UserReg();

            showForm3.ShowDialog();
        }
    }
}
