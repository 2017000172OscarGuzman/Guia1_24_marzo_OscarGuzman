namespace Guia1MatrizyVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] v1 = { 1, 2, 3, 4 };
            int[] v2 = { 5, 6, 7, 8 };

            for (int i = 0; i < 4; i++)
            {
                int suma = v1[i] + v2[i];
                dataGridView1.Rows.Add(v1[i], v2[i], suma);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 form = new form2();
            form.ShowDialog();
        }
    }
}
