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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private RepositorioDeElipses repo = new RepositorioDeElipses();
        private int cantidad;
        private List<Elipses> lista;

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmNuevaElipse frm = new frmNuevaElipse();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            var NuevaElip = frm.GetElipses();
            repo.Agregar(NuevaElip);
            var r = ConstruirFila();
            SetearFila(r, NuevaElip);
            AgregarFila(r);
            MessageBox.Show("Elipse Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cantidad = repo.GetCantidad();
            MostrarTotal();
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeElipses();
            lista = repo.getLista();
            cantidad = repo.GetCantidad();
            if (cantidad > 0)
            {
                MostrarLista();
            }
            else
            {
                MessageBox.Show("El repositorio esta vació ");
            }
            MostrarTotal();
        }

        private void MostrarTotal()
        {
            label1.Text = cantidad.ToString();
        }

        private void MostrarLista()
        {
            ElipsesDataGridView.Rows.Clear();
            foreach (var elipses in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, elipses);
                AgregarFila(r);
            }
        }

        private void AgregarFila(object r)
        {
            ElipsesDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Elipses elipses)
        {
            r.Cells[colSemiEjeMayor.Index].Value = elipses.SemiEjeMayor.ToString();
            r.Cells[colSemiEjeMenor.Index].Value = elipses.SemiEjeMenor.ToString();
            r.Cells[colArea.Index].Value = elipses.GetArea().ToString();
            r.Cells[colPerimetro.Index].Value = elipses.GetPerimetro().ToString();
            r.Cells[colTrazo.Index].Value = elipses.Trazo.ToString();

            r.Tag = elipses;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(ElipsesDataGridView);
            return r;
        }

        private void RestaurarToolStripButton_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            MostrarLista();
            cantidad = repo.GetCantidad();
            MostrarTotal();
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (ElipsesDataGridView.Rows.Count == 0)
            {
                return;
            }
            var r = ElipsesDataGridView.SelectedRows[0];
            Elipses elip = r.Tag as Elipses;
            DialogResult dr = MessageBox.Show($"¿Desea Borra la Elipse?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("El usuario se canceló");
                return;
            }

            if (repo.Borrar(elip))
            {
                repo.Borrar(elip);
                lista.Remove(elip);
                ElipsesDataGridView.Rows.Remove(r);
                cantidad = repo.GetCantidad();
                MostrarTotal();
                repo.Guardar();
                MessageBox.Show("Elipse eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo dar de baja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (ElipsesDataGridView.Rows.Count == 0)
            {
                return;
            }
            var r = ElipsesDataGridView.SelectedRows[0];
            Elipses elip = r.Tag as Elipses;
            frmNuevaElipse frm = new frmNuevaElipse() { Text = "Datos a editar" };
            frm.SetElipse(elip);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            elip = frm.GetElipses();
            SetearFila(r, elip);
            MessageBox.Show("Coordenada modificada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            repo.Guardar();
        }
    }
}
