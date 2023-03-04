namespace BMILaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0; // Haetaan pituus ja paino, sekä muunnetaan ne.
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if (bmi < 18.5) // Jos BMI on alle 18.5
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Aqua;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                VastausLB.Visible= true;
                KuvausLB.Visible= true;
            }
            else if (bmi < 25) // Jos BMI on alle 25
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40) // Jos BMI on alle 40
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else // Jos BMI on yli 40
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
        
           
    }
}