
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Viajes = new System.Windows.Forms.DataGridView();
            this.dtDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtMatriculaCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCamTuristas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCamPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Viajes);
            this.panel1.Location = new System.Drawing.Point(27, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 447);
            this.panel1.TabIndex = 4;
            // 
            // dgv_Viajes
            // 
            this.dgv_Viajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Viajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Viajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtDisponibilidad,
            this.dtFechaPartida,
            this.dtMatriculaCrucero,
            this.dtCamTuristas,
            this.dtCamPremium,
            this.dtDestino});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Viajes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Viajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Viajes.Enabled = false;
            this.dgv_Viajes.Location = new System.Drawing.Point(0, 0);
            this.dgv_Viajes.Name = "dgv_Viajes";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_Viajes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Viajes.RowTemplate.Height = 25;
            this.dgv_Viajes.Size = new System.Drawing.Size(1048, 447);
            this.dgv_Viajes.TabIndex = 0;            // 
            // dtDisponibilidad
            // 
            this.dtDisponibilidad.HeaderText = "Disponible";
            this.dtDisponibilidad.Name = "dtDisponibilidad";
            // 
            // dtFechaPartida
            // 
            this.dtFechaPartida.HeaderText = "Fecha de Partida";
            this.dtFechaPartida.Name = "dtFechaPartida";
            // 
            // dtMatriculaCrucero
            // 
            this.dtMatriculaCrucero.HeaderText = "Crucero";
            this.dtMatriculaCrucero.Name = "dtMatriculaCrucero";
            // 
            // dtCamTuristas
            // 
            this.dtCamTuristas.HeaderText = "Camarotes Turistas";
            this.dtCamTuristas.Name = "dtCamTuristas";
            // 
            // dtCamPremium
            // 
            this.dtCamPremium.HeaderText = "Camarotes Premium";
            this.dtCamPremium.Name = "dtCamPremium";
            // 
            // dtDestino
            // 
            this.dtDestino.HeaderText = "Destino";
            this.dtDestino.Name = "dtDestino";
            // 
            // FormViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViaje";
            this.Text = "FormViaje";
            this.Load += new System.EventHandler(this.FormViaje_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Viajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtMatriculaCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCamTuristas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCamPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDestino;
    }
}