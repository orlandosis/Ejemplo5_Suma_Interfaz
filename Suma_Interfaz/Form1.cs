namespace Suma_Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumaDatos_Click(object sender, EventArgs e)
        {
            int x, N, suma = 0;

            N = Convert.ToInt32(txt_numero.Text);

            for (x=1; x<=N; x++)
            {
                suma = suma + x;

                if (checkBox1.Checked==true) 
                {
                    listBox1.Items.Add("sumando:\t" + x+ "\tSuma Parcial:\t" + suma);
                }

            }

            listBox1.Items.Add("La suma total es:\t" + suma);

        }
    }
}