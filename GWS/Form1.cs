using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /* Valor do ICMS ST = (Base do ICMS ST * (Alíquota do ICMS Intra / 100)) - Valor do ICMS Inter
           Valor do ICMS ST = (4.170,00 * (18,00 / 100)) - 312,00
           Valor do ICMS ST = 750,60 - 312,00
           Valor do ICMS ST = 438,60 
        */

        private void button1_Click(object sender, EventArgs e)
        {
            /*decimal convertICMSST = 0;
            convertICMSST = Convert.ToDecimal(textBox1.Text);
            ICMSST = (float)convertICMSST;

            double convertAliquota = Convert.ToDouble(textBox2.Text);
            Aliquota = (float)convertAliquota;

            double convertICMSInter = Convert.ToDouble(textBox3.Text);
            ICMSInter = (float)convertICMSInter;

            double calculo = (ICMSST * (Aliquota / 100)) - ICMSInter;
            textBox4.Text = calculo.ToString(CultureInfo.InvariantCulture);
            //textBox4.Text = calculo.ToString("C2", CultureInfo.CurrentCulture);*/


            // Conversão Aliquota Interstadual
            try
            {
                decimal convertICMSST = 0;
                convertICMSST = Convert.ToDecimal(textBox1.Text);
                decimal aliInter = convertICMSST / 100;

                // Valor do produto x Aliquota Interstadual
                decimal vdp1 = 0;
                vdp1 = Convert.ToDecimal(textBox7.Text);
                decimal vdpXai = vdp1 * aliInter;

                // Valor do produto + MVA
                decimal porMVA = 0;
                porMVA = Convert.ToDecimal(textBox2.Text);
                decimal mva = porMVA / 100;
                decimal vdpSUMmva = vdp1 + (vdp1 * mva);
                string valorParaCalc = vdpSUMmva.ToString("N2", CultureInfo.InvariantCulture);

                // Valor do produto x Aliquota Interna Estado Destino
                decimal porAIED = 0;
                porAIED = Convert.ToDecimal(textBox3.Text);
                decimal AIED = porAIED / 100;
                decimal vdpsummva2 = 0;
                vdpsummva2 = Convert.ToDecimal(valorParaCalc);
                decimal mvaXaied = vdpsummva2 * AIED;

                //Valor Final
                decimal resultado = 0;
                resultado = mvaXaied - vdpXai;
                //textBox4.Text = resultado.ToString("C2", CultureInfo.CurrentCulture);
                textBox4.Text = resultado.ToString("C2", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("este campo aceita somente numero e ponto");
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e ponto");
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e ponto");
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e ponto");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        /* 
            (B – A) / A x 100

            A = valor inicial
            B = valor final


            (B – A) / A x 100 =
            (1.385 – 1.000) / 1.000 x 100 = 385
            385 / 1.000 x 100 = 0,385
            0,385 x 100 = 38,5%
        */
        private void btnCalcularPercentual_Click(object sender, EventArgs e)
        {
            // textBox5 e textBox6
            decimal a = 0;
            decimal b = 0;
            decimal porcDiff = 0;
            a = Convert.ToDecimal(textBox5.Text);
            b = Convert.ToDecimal(textBox6.Text);
            porcDiff = (b - a) / a * 100;

            textBox8.Text = porcDiff.ToString("N2", CultureInfo.InvariantCulture) + '%';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e ponto");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
