using POOUrielAlejandroVergara.Datos;
using POOUrielAlejandroVergara.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOUrielAlejandroVergara.Windows
{
    public partial class frmNuevaElipse : Form
    {
        public frmNuevaElipse()
        {
            InitializeComponent();
        }
        private Elipses elipses;
        private RepositorioDeElipses repo = new RepositorioDeElipses();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosenComboBox();
            if (elipses != null)
            {
                SemiEjeMayorTextBox.Text = elipses.SemiEjeMayor.ToString();
                SemiEjeMenorTextBox.Text = elipses.SemiEjeMenor.ToString();
            }
        }

        private void CargarDatosenComboBox()
        {
            TipoDeTrazoComboBox.DataSource = Enum.GetValues(typeof(Trazo));
            TipoDeTrazoComboBox.SelectedItem = 0;
        }

        internal Elipses GetElipses()
        {
            return elipses;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (elipses == null)
                {
                    elipses = new Elipses();
                }
                elipses.SemiEjeMayor = int.Parse(SemiEjeMayorTextBox.Text);
                elipses.SemiEjeMenor = int.Parse(SemiEjeMenorTextBox.Text);
                if (repo.ExisteElipse(elipses))
                {
                    ErroresErrorProvider.SetError(SemiEjeMayorTextBox, "Elipse Existente!!!");
                }
                else
                {
                    DialogResult = DialogResult.OK;

                }
            }
        }

        private bool ValidarDatos()
        {
            bool Valido = true;
            ErroresErrorProvider.Clear();
            if (!int.TryParse(SemiEjeMayorTextBox.Text, out int SemiEjeMayor))
            {
                Valido = false;
                ErroresErrorProvider.SetError(SemiEjeMayorTextBox, "Los datos estan mal ingresados");
            }
            else if (SemiEjeMayor < 0)
            {
                Valido = false;
                ErroresErrorProvider.SetError(SemiEjeMayorTextBox, "El dato debe ser mayor a 0");
            }
            if (!int.TryParse(SemiEjeMenorTextBox.Text, out int SemiEjeMenor))
            {
                Valido = false;
                ErroresErrorProvider.SetError(SemiEjeMenorTextBox, "Los datos estan mal ingresados");
            }
            else if (SemiEjeMenor < 0)
            {
                Valido = false;
                ErroresErrorProvider.SetError(SemiEjeMenorTextBox, "El dato debe ser mayor a 0");
            }
            return Valido;
        }

        private void SemiEjeMneorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNuevaElipse_Load(object sender, EventArgs e)
        {

        }

        internal void SetElipse(Elipses elip)
        {
            elipses = elip;
        }
    }
}
