using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1MatrizyVector
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[,] Matriz1 =
                {
                {1,2,3,4 },
                {4,5,2,4 }
            };
            int[,] Matriz2 =
                {
                {1,5,3,4 },
                {4,5,2,4 }
            };

            for(int co = 0; co < 4; co++)
            {
                for (int fi = 0; fi <2; fi++)
                {
                    int suma = Matriz1[fi, co] + Matriz2[fi, co];
                    dataGridView1.Rows.Add(Matriz1[fi, co], Matriz2[fi, co], suma);
                }
            }
        }
    }
}
