
namespace POOUrielAlejandroVergara.Windows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.RestaurarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ElipsesDataGridView = new System.Windows.Forms.DataGridView();
            this.colSemiEjeMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemiEjeMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElipsesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.EditarToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripButton1,
            this.FiltrarToolStripButton,
            this.RestaurarToolStripButton,
            this.GuardarToolStripButton,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(543, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripButton.Image")));
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.FiltrarToolStripButton.Text = "Filtro";
            // 
            // RestaurarToolStripButton
            // 
            this.RestaurarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarToolStripButton.Image")));
            this.RestaurarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurarToolStripButton.Name = "RestaurarToolStripButton";
            this.RestaurarToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.RestaurarToolStripButton.Text = "Restaurar";
            this.RestaurarToolStripButton.Click += new System.EventHandler(this.RestaurarToolStripButton_Click);
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton.Image")));
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.GuardarToolStripButton.Text = "Guardar";
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.SalirToolStripButton.Text = "SALIR";
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // ElipsesDataGridView
            // 
            this.ElipsesDataGridView.AllowUserToAddRows = false;
            this.ElipsesDataGridView.AllowUserToDeleteRows = false;
            this.ElipsesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElipsesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSemiEjeMayor,
            this.colSemiEjeMenor,
            this.colArea,
            this.colPerimetro,
            this.colTrazo});
            this.ElipsesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElipsesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ElipsesDataGridView.MultiSelect = false;
            this.ElipsesDataGridView.Name = "ElipsesDataGridView";
            this.ElipsesDataGridView.ReadOnly = true;
            this.ElipsesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElipsesDataGridView.Size = new System.Drawing.Size(543, 197);
            this.ElipsesDataGridView.TabIndex = 2;
            // 
            // colSemiEjeMayor
            // 
            this.colSemiEjeMayor.HeaderText = "Semi EJe Mayor";
            this.colSemiEjeMayor.Name = "colSemiEjeMayor";
            this.colSemiEjeMayor.ReadOnly = true;
            // 
            // colSemiEjeMenor
            // 
            this.colSemiEjeMenor.HeaderText = "Semi Eje Menor";
            this.colSemiEjeMenor.Name = "colSemiEjeMenor";
            this.colSemiEjeMenor.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colTrazo
            // 
            this.colTrazo.HeaderText = "Trazo";
            this.colTrazo.Name = "colTrazo";
            this.colTrazo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 222);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElipsesDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElipsesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripButton RestaurarToolStripButton;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView ElipsesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemiEjeMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemiEjeMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrazo;
        private System.Windows.Forms.Label label1;
    }
}

