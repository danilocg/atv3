using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.ThreeState)
            {
                
                MessageBox.Show("Checkbox: Marcado\nTexto: " + textBox1.Text);
                
            }
            else
            {
                MessageBox.Show("Checkbox: Desmarcado\nTexto: " + textBox1.Text);
            }
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Change the ThreeState and CheckAlign properties on every other click.
            if (!checkBox1.ThreeState)
            {
                checkBox1.ThreeState = true;
                
            }
            else
            {
                checkBox1.ThreeState = false;
                
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }

