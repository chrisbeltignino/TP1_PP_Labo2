
namespace FormMain
{
    partial class FormCruceros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Cruceros = new System.Windows.Forms.DataGridView();
            this.dataNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCamarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRestaurants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPiscinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSalonesBaile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPasajeros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrarPasajeros = new System.Windows.Forms.Button();
            this.lblMatriculaCrucero = new System.Windows.Forms.Label();
            this.txtMatriculaCrucero = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cruceros)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_Cruceros);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 269);
            this.panel1.TabIndex = 3;
            // 
            // dgv_Cruceros
            // 
            this.dgv_Cruceros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Cruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cruceros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Cruceros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Cruceros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Cruceros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_Cruceros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cruceros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Cruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataNombre,
            this.dataMatricula,
            this.dataCamarotes,
            this.dataBodega,
            this.dataRestaurants,
            this.dataCasinos,
            this.dataPiscinas,
            this.dataSalonesBaile,
            this.dataPasajeros,
            this.dataEstado});
            this.dgv_Cruceros.Cursor = System.Windows.Forms.Cursors.VSplit;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cruceros.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Cruceros.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Cruceros.Location = new System.Drawing.Point(3, 16);
            this.dgv_Cruceros.Name = "dgv_Cruceros";
            this.dgv_Cruceros.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cruceros.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Cruceros.RowTemplate.Height = 25;
            this.dgv_Cruceros.Size = new System.Drawing.Size(1101, 251);
            this.dgv_Cruceros.TabIndex = 1;
            // 
            // dataNombre
            // 
            this.dataNombre.HeaderText = "Nombre";
            this.dataNombre.Name = "dataNombre";
            this.dataNombre.ReadOnly = true;
            // 
            // dataMatricula
            // 
            this.dataMatricula.HeaderText = "Matricula";
            this.dataMatricula.Name = "dataMatricula";
            this.dataMatricula.ReadOnly = true;
            // 
            // dataCamarotes
            // 
            this.dataCamarotes.HeaderText = "Camarotes";
            this.dataCamarotes.Name = "dataCamarotes";
            this.dataCamarotes.ReadOnly = true;
            // 
            // dataBodega
            // 
            this.dataBodega.HeaderText = "Bodega";
            this.dataBodega.Name = "dataBodega";
            this.dataBodega.ReadOnly = true;
            // 
            // dataRestaurants
            // 
            this.dataRestaurants.HeaderText = "Restaurants";
            this.dataRestaurants.Name = "dataRestaurants";
            this.dataRestaurants.ReadOnly = true;
            // 
            // dataCasinos
            // 
            this.dataCasinos.HeaderText = "Casinos";
            this.dataCasinos.Name = "dataCasinos";
            this.dataCasinos.ReadOnly = true;
            // 
            // dataPiscinas
            // 
            this.dataPiscinas.HeaderText = "Piscinas";
            this.dataPiscinas.Name = "dataPiscinas";
            this.dataPiscinas.ReadOnly = true;
            // 
            // dataSalonesBaile
            // 
            this.dataSalonesBaile.HeaderText = "Salones de Baile";
            this.dataSalonesBaile.Name = "dataSalonesBaile";
            this.dataSalonesBaile.ReadOnly = true;
            // 
            // dataPasajeros
            // 
            this.dataPasajeros.HeaderText = "Pasajeros";
            this.dataPasajeros.Name = "dataPasajeros";
            this.dataPasajeros.ReadOnly = true;
            // 
            // dataEstado
            // 
            this.dataEstado.HeaderText = "Estado";
            this.dataEstado.Name = "dataEstado";
            this.dataEstado.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridPasajeros);
            this.panel2.Controls.Add(this.btnFiltrarPasajeros);
            this.panel2.Controls.Add(this.lblMatriculaCrucero);
            this.panel2.Controls.Add(this.txtMatriculaCrucero);
            this.panel2.Location = new System.Drawing.Point(7, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 262);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informacion Pasajeros";
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.AllowUserToOrderColumns = true;
            this.dataGridPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridPasajeros.Location = new System.Drawing.Point(172, 3);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.ReadOnly = true;
            this.dataGridPasajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridPasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridPasajeros.RowTemplate.Height = 25;
            this.dataGridPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPasajeros.Size = new System.Drawing.Size(907, 256);
            this.dataGridPasajeros.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sexo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pasaporte";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nacionalidad";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "LLeva Bolso";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Peso Valijas";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Es Premium";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // btnFiltrarPasajeros
            // 
            this.btnFiltrarPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrarPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.btnFiltrarPasajeros.FlatAppearance.BorderSize = 0;
            this.btnFiltrarPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPasajeros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPasajeros.Location = new System.Drawing.Point(37, 182);
            this.btnFiltrarPasajeros.Name = "btnFiltrarPasajeros";
            this.btnFiltrarPasajeros.Size = new System.Drawing.Size(100, 46);
            this.btnFiltrarPasajeros.TabIndex = 3;
            this.btnFiltrarPasajeros.Text = "Filtrar Pasajeros";
            this.btnFiltrarPasajeros.UseVisualStyleBackColor = false;
            this.btnFiltrarPasajeros.Click += new System.EventHandler(this.btnFiltrarPasajeros_Click);
            // 
            // lblMatriculaCrucero
            // 
            this.lblMatriculaCrucero.AutoSize = true;
            this.lblMatriculaCrucero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatriculaCrucero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMatriculaCrucero.Location = new System.Drawing.Point(15, 85);
            this.lblMatriculaCrucero.Name = "lblMatriculaCrucero";
            this.lblMatriculaCrucero.Size = new System.Drawing.Size(140, 17);
            this.lblMatriculaCrucero.TabIndex = 2;
            this.lblMatriculaCrucero.Text = "Matricula del Crucero";
            // 
            // txtMatriculaCrucero
            // 
            this.txtMatriculaCrucero.Location = new System.Drawing.Point(37, 105);
            this.txtMatriculaCrucero.Name = "txtMatriculaCrucero";
            this.txtMatriculaCrucero.Size = new System.Drawing.Size(100, 23);
            this.txtMatriculaCrucero.TabIndex = 0;
            // 
            // FormCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCruceros";
            this.Text = "FormCruceros";
            this.Load += new System.EventHandler(this.FormCruceros_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cruceros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Cruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCamarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRestaurants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCasinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPiscinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSalonesBaile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCamarotesPremiums;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMatriculaCrucero;
        private System.Windows.Forms.Button btnFiltrarPasajeros;
        private System.Windows.Forms.Label lblMatriculaCrucero;
        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label1;
    }
}