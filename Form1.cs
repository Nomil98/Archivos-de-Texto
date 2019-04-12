using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Abarrotes_Limon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Producto Admin = new Producto();

        double Total=0, Subtotal=0;
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            txtlista.Items.Add(Admin.Productos(txtprod.Text, Convert.ToInt16(txtcant.Value), int.Parse(txtcosto.Text), int.Parse(txtimporte.Text)));
            double subtotal_Temporal = Admin.SubTotal(Convert.ToInt16(txtcant.Value), int.Parse(txtcosto.ToString()));
            txtimporte.Text = subtotal_Temporal.ToString();
            Total = Admin.Total(subtotal_Temporal, Admin.IVA(subtotal_Temporal));
            Subtotal += subtotal_Temporal;
            txtiva.Text = Admin.IVA(subtotal_Temporal).ToString();
            txttotal.Text = Admin.Total(subtotal_Temporal, Admin.IVA(subtotal_Temporal)).ToString();
            i++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            txtcambio.Text = Admin.Pago(Total, Convert.ToInt32(txtpago.Text)).ToString();
            
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string RutaTicket;
            RutaTicket = saveFileDialog1.FileName;
            FileStream fs = new FileStream(RutaTicket, FileMode.Create);
            StreamWriter escribir = new StreamWriter(fs);

            for (j = 0; j < i; j++) /* Se va a escribir el contenido de la lista con el 
                                       acomodo del método Productos de la clase Producto*/
            {                          
                
                escribir.Write(txtlista.ToString()); 
               }

            escribir.Close();
            fs.Close();
    
        }

        private void txtcant_ValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
