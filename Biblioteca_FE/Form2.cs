using Biblioteca_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca_FE
{
    public partial class Form2 : Form
    {
        Libro myLibro = new Libro();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            decimal Verificacion;
            if (!Decimal.TryParse(txtPeriodo.Text, out Verificacion))

            {
                errorPeriodo.SetError(txtPeriodo, "Igrese un dato numerico en días");
                return;
            }



            else
            {
                errorPeriodo.SetError(txtPeriodo, "");
                myLibro.Nombrelibro = txtNombrelibro.Text;
                myLibro.Autor = txtAutor.Text;
                myLibro.Editorial = txtEditorial.Text;
                myLibro.Periodo = txtPeriodo.Text;

                MessageBox.Show("Libro Cargado");

                lblMostrar1.Text = myLibro.Nombrelibro;
                lblMostrar2.Text = myLibro.Autor;
                lblMostrar3.Text = myLibro.Editorial;
                lblMostrar4.Text = myLibro.Periodo;

            }
        }
    }
}

