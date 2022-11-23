
namespace POOUrielAlejandroVergara.Windows
{
    partial class frmNuevaElipse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErroresErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SemiEjeMayorTextBox = new System.Windows.Forms.TextBox();
            this.SemiEjeMenorTextBox = new System.Windows.Forms.TextBox();
            this.TipoDeTrazoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semi EJe Mayor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semi Eje Menor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Trazo";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(56, 180);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(196, 179);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErroresErrorProvider
            // 
            this.ErroresErrorProvider.ContainerControl = this;
            // 
            // SemiEjeMayorTextBox
            // 
            this.SemiEjeMayorTextBox.Location = new System.Drawing.Point(141, 25);
            this.SemiEjeMayorTextBox.Name = "SemiEjeMayorTextBox";
            this.SemiEjeMayorTextBox.Size = new System.Drawing.Size(100, 20);
            this.SemiEjeMayorTextBox.TabIndex = 5;
            // 
            // SemiEjeMenorTextBox
            // 
            this.SemiEjeMenorTextBox.Location = new System.Drawing.Point(141, 55);
            this.SemiEjeMenorTextBox.Name = "SemiEjeMenorTextBox";
            this.SemiEjeMenorTextBox.Size = new System.Drawing.Size(100, 20);
            this.SemiEjeMenorTextBox.TabIndex = 6;
            this.SemiEjeMenorTextBox.TextChanged += new System.EventHandler(this.SemiEjeMneorTextBox_TextChanged);
            // 
            // TipoDeTrazoComboBox
            // 
            this.TipoDeTrazoComboBox.FormattingEnabled = true;
            this.TipoDeTrazoComboBox.Location = new System.Drawing.Point(141, 103);
            this.TipoDeTrazoComboBox.Name = "TipoDeTrazoComboBox";
            this.TipoDeTrazoComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoDeTrazoComboBox.TabIndex = 7;
            // 
            // frmNuevaElipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 237);
            this.ControlBox = false;
            this.Controls.Add(this.TipoDeTrazoComboBox);
            this.Controls.Add(this.SemiEjeMenorTextBox);
            this.Controls.Add(this.SemiEjeMayorTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNuevaElipse";
            this.Text = "frmNuevaElipse";
            this.Load += new System.EventHandler(this.frmNuevaElipse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider ErroresErrorProvider;
        private System.Windows.Forms.ComboBox TipoDeTrazoComboBox;
        private System.Windows.Forms.TextBox SemiEjeMenorTextBox;
        private System.Windows.Forms.TextBox SemiEjeMayorTextBox;
    }
}