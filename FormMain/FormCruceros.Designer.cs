
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataCamarotesPremiums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Cruceros);
            this.panel1.Location = new System.Drawing.Point(25, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 447);
            this.panel1.TabIndex = 3;
            // 
            // dgv_Cruceros
            // 
            this.dgv_Cruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cruceros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Cruceros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Cruceros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Cruceros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_Cruceros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cruceros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataCamarotesPremiums,
            this.dataCamarotesTurista,
            this.dataViaje,
            this.dataEstado});
            this.dgv_Cruceros.Cursor = System.Windows.Forms.Cursors.VSplit;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cruceros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Cruceros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cruceros.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Cruceros.Location = new System.Drawing.Point(0, 0);
            this.dgv_Cruceros.Name = "dgv_Cruceros";
            this.dgv_Cruceros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cruceros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Cruceros.RowTemplate.Height = 25;
            this.dgv_Cruceros.Size = new System.Drawing.Size(1048, 447);
            this.dgv_Cruceros.TabIndex = 5;
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
            // dataCamarotesPremiums
            // 
            this.dataCamarotesPremiums.HeaderText = "Camarotes Premiums";
            this.dataCamarotesPremiums.Name = "dataCamarotesPremiums";
            this.dataCamarotesPremiums.ReadOnly = true;
            // 
            // dataCamarotesTurista
            // 
            this.dataCamarotesTurista.HeaderText = "Camarotes Turista";
            this.dataCamarotesTurista.Name = "dataCamarotesTurista";
            this.dataCamarotesTurista.ReadOnly = true;
            // 
            // dataViaje
            // 
            this.dataViaje.HeaderText = "Proximo Viaje";
            this.dataViaje.Name = "dataViaje";
            this.dataViaje.ReadOnly = true;
            // 
            // dataEstado
            // 
            this.dataEstado.HeaderText = "Estado";
            this.dataEstado.Name = "dataEstado";
            this.dataEstado.ReadOnly = true;
            // 
            // FormCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCruceros";
            this.Text = "FormCruceros";
            this.Load += new System.EventHandler(this.FormCruceros_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCamarotesPremiums;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataViaje;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEstado;
    }
}