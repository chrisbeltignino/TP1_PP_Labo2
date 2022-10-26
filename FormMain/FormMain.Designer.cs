
namespace FormMain
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSIdeMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuEstadistica = new System.Windows.Forms.Panel();
            this.btn_Destino = new System.Windows.Forms.Button();
            this.btn_CantPasajeros = new System.Windows.Forms.Button();
            this.btn_Recaudacion = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.panelSubMenuCruceros = new System.Windows.Forms.Panel();
            this.btn_InfoCruceros = new System.Windows.Forms.Button();
            this.btn_VenderCrucero = new System.Windows.Forms.Button();
            this.btn_Cruceros = new System.Windows.Forms.Button();
            this.panelSubMenuViajes = new System.Windows.Forms.Panel();
            this.btn_CrearViaje = new System.Windows.Forms.Button();
            this.btn_VerViajes = new System.Windows.Forms.Button();
            this.btn_Viajes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSIdeMenu.SuspendLayout();
            this.panelSubMenuEstadistica.SuspendLayout();
            this.panelSubMenuCruceros.SuspendLayout();
            this.panelSubMenuViajes.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSIdeMenu
            // 
            this.panelSIdeMenu.AutoScroll = true;
            this.panelSIdeMenu.BackColor = System.Drawing.Color.Black;
            this.panelSIdeMenu.Controls.Add(this.panelSubMenuEstadistica);
            this.panelSIdeMenu.Controls.Add(this.btn_Estadisticas);
            this.panelSIdeMenu.Controls.Add(this.panelSubMenuCruceros);
            this.panelSIdeMenu.Controls.Add(this.btn_Cruceros);
            this.panelSIdeMenu.Controls.Add(this.panelSubMenuViajes);
            this.panelSIdeMenu.Controls.Add(this.btn_Viajes);
            this.panelSIdeMenu.Controls.Add(this.panelLogo);
            this.panelSIdeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSIdeMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSIdeMenu.Name = "panelSIdeMenu";
            this.panelSIdeMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSIdeMenu.TabIndex = 6;
            // 
            // panelSubMenuEstadistica
            // 
            this.panelSubMenuEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSubMenuEstadistica.Controls.Add(this.btn_Destino);
            this.panelSubMenuEstadistica.Controls.Add(this.btn_CantPasajeros);
            this.panelSubMenuEstadistica.Controls.Add(this.btn_Recaudacion);
            this.panelSubMenuEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEstadistica.Location = new System.Drawing.Point(0, 339);
            this.panelSubMenuEstadistica.Name = "panelSubMenuEstadistica";
            this.panelSubMenuEstadistica.Size = new System.Drawing.Size(200, 102);
            this.panelSubMenuEstadistica.TabIndex = 6;
            this.panelSubMenuEstadistica.Visible = false;
            // 
            // btn_Destino
            // 
            this.btn_Destino.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Destino.FlatAppearance.BorderSize = 0;
            this.btn_Destino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Destino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Destino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Destino.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Destino.Location = new System.Drawing.Point(0, 69);
            this.btn_Destino.Name = "btn_Destino";
            this.btn_Destino.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Destino.Size = new System.Drawing.Size(200, 30);
            this.btn_Destino.TabIndex = 4;
            this.btn_Destino.Text = "Destino mas elegido";
            this.btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Destino.UseVisualStyleBackColor = true;
            // 
            // btn_CantPasajeros
            // 
            this.btn_CantPasajeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CantPasajeros.FlatAppearance.BorderSize = 0;
            this.btn_CantPasajeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_CantPasajeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CantPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CantPasajeros.ForeColor = System.Drawing.Color.LightGray;
            this.btn_CantPasajeros.Location = new System.Drawing.Point(0, 30);
            this.btn_CantPasajeros.Name = "btn_CantPasajeros";
            this.btn_CantPasajeros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_CantPasajeros.Size = new System.Drawing.Size(200, 39);
            this.btn_CantPasajeros.TabIndex = 3;
            this.btn_CantPasajeros.Text = "Cant. de pasajeros por crucero";
            this.btn_CantPasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CantPasajeros.UseVisualStyleBackColor = true;
            // 
            // btn_Recaudacion
            // 
            this.btn_Recaudacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Recaudacion.FlatAppearance.BorderSize = 0;
            this.btn_Recaudacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Recaudacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Recaudacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recaudacion.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Recaudacion.Location = new System.Drawing.Point(0, 0);
            this.btn_Recaudacion.Name = "btn_Recaudacion";
            this.btn_Recaudacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Recaudacion.Size = new System.Drawing.Size(200, 30);
            this.btn_Recaudacion.TabIndex = 2;
            this.btn_Recaudacion.Text = "Recaudación";
            this.btn_Recaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Recaudacion.UseVisualStyleBackColor = true;
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_Estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Estadisticas.Location = new System.Drawing.Point(0, 299);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Estadisticas.Size = new System.Drawing.Size(200, 40);
            this.btn_Estadisticas.TabIndex = 5;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // panelSubMenuCruceros
            // 
            this.panelSubMenuCruceros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSubMenuCruceros.Controls.Add(this.btn_InfoCruceros);
            this.panelSubMenuCruceros.Controls.Add(this.btn_VenderCrucero);
            this.panelSubMenuCruceros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCruceros.Location = new System.Drawing.Point(0, 234);
            this.panelSubMenuCruceros.Name = "panelSubMenuCruceros";
            this.panelSubMenuCruceros.Size = new System.Drawing.Size(200, 65);
            this.panelSubMenuCruceros.TabIndex = 4;
            this.panelSubMenuCruceros.Visible = false;
            // 
            // btn_InfoCruceros
            // 
            this.btn_InfoCruceros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_InfoCruceros.FlatAppearance.BorderSize = 0;
            this.btn_InfoCruceros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_InfoCruceros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_InfoCruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoCruceros.ForeColor = System.Drawing.Color.LightGray;
            this.btn_InfoCruceros.Location = new System.Drawing.Point(0, 30);
            this.btn_InfoCruceros.Name = "btn_InfoCruceros";
            this.btn_InfoCruceros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_InfoCruceros.Size = new System.Drawing.Size(200, 32);
            this.btn_InfoCruceros.TabIndex = 3;
            this.btn_InfoCruceros.Text = "Informacion de Cruceros";
            this.btn_InfoCruceros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InfoCruceros.UseVisualStyleBackColor = true;
            this.btn_InfoCruceros.Click += new System.EventHandler(this.btn_InfoCruceros_Click);
            // 
            // btn_VenderCrucero
            // 
            this.btn_VenderCrucero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VenderCrucero.FlatAppearance.BorderSize = 0;
            this.btn_VenderCrucero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_VenderCrucero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_VenderCrucero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VenderCrucero.ForeColor = System.Drawing.Color.LightGray;
            this.btn_VenderCrucero.Location = new System.Drawing.Point(0, 0);
            this.btn_VenderCrucero.Name = "btn_VenderCrucero";
            this.btn_VenderCrucero.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_VenderCrucero.Size = new System.Drawing.Size(200, 30);
            this.btn_VenderCrucero.TabIndex = 2;
            this.btn_VenderCrucero.Text = "Crear Crucero";
            this.btn_VenderCrucero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VenderCrucero.UseVisualStyleBackColor = true;
            this.btn_VenderCrucero.Click += new System.EventHandler(this.btn_VenderCrucero_Click);
            // 
            // btn_Cruceros
            // 
            this.btn_Cruceros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cruceros.FlatAppearance.BorderSize = 0;
            this.btn_Cruceros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cruceros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Cruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cruceros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cruceros.Location = new System.Drawing.Point(0, 194);
            this.btn_Cruceros.Name = "btn_Cruceros";
            this.btn_Cruceros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Cruceros.Size = new System.Drawing.Size(200, 40);
            this.btn_Cruceros.TabIndex = 3;
            this.btn_Cruceros.Text = "Cruceros";
            this.btn_Cruceros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cruceros.UseVisualStyleBackColor = true;
            this.btn_Cruceros.Click += new System.EventHandler(this.btn_Cruceros_Click);
            // 
            // panelSubMenuViajes
            // 
            this.panelSubMenuViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSubMenuViajes.Controls.Add(this.btn_CrearViaje);
            this.panelSubMenuViajes.Controls.Add(this.btn_VerViajes);
            this.panelSubMenuViajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuViajes.Location = new System.Drawing.Point(0, 131);
            this.panelSubMenuViajes.Name = "panelSubMenuViajes";
            this.panelSubMenuViajes.Size = new System.Drawing.Size(200, 63);
            this.panelSubMenuViajes.TabIndex = 2;
            this.panelSubMenuViajes.Visible = false;
            // 
            // btn_CrearViaje
            // 
            this.btn_CrearViaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CrearViaje.FlatAppearance.BorderSize = 0;
            this.btn_CrearViaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_CrearViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CrearViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearViaje.ForeColor = System.Drawing.Color.LightGray;
            this.btn_CrearViaje.Location = new System.Drawing.Point(0, 30);
            this.btn_CrearViaje.Name = "btn_CrearViaje";
            this.btn_CrearViaje.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_CrearViaje.Size = new System.Drawing.Size(200, 30);
            this.btn_CrearViaje.TabIndex = 3;
            this.btn_CrearViaje.Text = "Vender Viaje";
            this.btn_CrearViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CrearViaje.UseVisualStyleBackColor = true;
            this.btn_CrearViaje.Click += new System.EventHandler(this.btn_CrearViaje_Click);
            // 
            // btn_VerViajes
            // 
            this.btn_VerViajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VerViajes.FlatAppearance.BorderSize = 0;
            this.btn_VerViajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_VerViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_VerViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerViajes.ForeColor = System.Drawing.Color.LightGray;
            this.btn_VerViajes.Location = new System.Drawing.Point(0, 0);
            this.btn_VerViajes.Name = "btn_VerViajes";
            this.btn_VerViajes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_VerViajes.Size = new System.Drawing.Size(200, 30);
            this.btn_VerViajes.TabIndex = 2;
            this.btn_VerViajes.Text = "Ver Viajes";
            this.btn_VerViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerViajes.UseVisualStyleBackColor = true;
            this.btn_VerViajes.Click += new System.EventHandler(this.btn_VerViajes_Click);
            // 
            // btn_Viajes
            // 
            this.btn_Viajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Viajes.FlatAppearance.BorderSize = 0;
            this.btn_Viajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Viajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Viajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Viajes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Viajes.Location = new System.Drawing.Point(0, 91);
            this.btn_Viajes.Name = "btn_Viajes";
            this.btn_Viajes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Viajes.Size = new System.Drawing.Size(200, 40);
            this.btn_Viajes.TabIndex = 1;
            this.btn_Viajes.Text = "Viajes";
            this.btn_Viajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Viajes.UseVisualStyleBackColor = true;
            this.btn_Viajes.Click += new System.EventHandler(this.btn_Viajes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 91);
            this.panelLogo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelFormulario.Controls.Add(this.pictureBox1);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(200, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1101, 561);
            this.panelFormulario.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 561);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelSIdeMenu);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSIdeMenu.ResumeLayout(false);
            this.panelSubMenuEstadistica.ResumeLayout(false);
            this.panelSubMenuCruceros.ResumeLayout(false);
            this.panelSubMenuViajes.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSIdeMenu;
        private System.Windows.Forms.Panel panelSubMenuViajes;
        private System.Windows.Forms.Button btn_CrearViaje;
        private System.Windows.Forms.Button btn_VerViajes;
        private System.Windows.Forms.Button btn_Viajes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuEstadistica;
        private System.Windows.Forms.Button btn_Destino;
        private System.Windows.Forms.Button btn_CantPasajeros;
        private System.Windows.Forms.Button btn_Recaudacion;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Panel panelSubMenuCruceros;
        private System.Windows.Forms.Button btn_InfoCruceros;
        private System.Windows.Forms.Button btn_VenderCrucero;
        private System.Windows.Forms.Button btn_Cruceros;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}