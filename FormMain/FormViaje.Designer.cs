
namespace FormMain
{
    partial class FormViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViaje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dgv_Viajes = new System.Windows.Forms.DataGridView();
            this.dtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCamarotesTurtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(627, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(45, 43);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv_Viajes
            // 
            this.dgv_Viajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Viajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Viajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Viajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Viajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtEstado,
            this.dtFechaPartida,
            this.dtCrucero,
            this.dtCamarotesTurtista,
            this.dtCamarotesPremium});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Viajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Viajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Viajes.Location = new System.Drawing.Point(3, 19);
            this.dgv_Viajes.Name = "dgv_Viajes";
            this.dgv_Viajes.ReadOnly = true;
            this.dgv_Viajes.RowTemplate.Height = 25;
            this.dgv_Viajes.Size = new System.Drawing.Size(623, 408);
            this.dgv_Viajes.TabIndex = 4;
            // 
            // dtEstado
            // 
            this.dtEstado.HeaderText = "Estado";
            this.dtEstado.Name = "dtEstado";
            this.dtEstado.ReadOnly = true;
            // 
            // dtFechaPartida
            // 
            this.dtFechaPartida.HeaderText = "Fecha de Partida";
            this.dtFechaPartida.Name = "dtFechaPartida";
            this.dtFechaPartida.ReadOnly = true;
            // 
            // dtCrucero
            // 
            this.dtCrucero.HeaderText = "Crucero";
            this.dtCrucero.Name = "dtCrucero";
            this.dtCrucero.ReadOnly = true;
            // 
            // dtCamarotesTurtista
            // 
            this.dtCamarotesTurtista.HeaderText = "Cant. de Camarotes Turistas";
            this.dtCamarotesTurtista.Name = "dtCamarotesTurtista";
            this.dtCamarotesTurtista.ReadOnly = true;
            // 
            // dtCamarotesPremium
            // 
            this.dtCamarotesPremium.HeaderText = "Cant. de Camarotes Premium";
            this.dtCamarotesPremium.Name = "dtCamarotesPremium";
            this.dtCamarotesPremium.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.dgv_Viajes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 430);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viajes Actuales";
            // 
            // FormViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViaje";
            this.Text = "FormViaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_Viajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCamarotesTurtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCamarotesPremium;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}