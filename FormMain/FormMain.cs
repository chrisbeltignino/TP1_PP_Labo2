﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (panelSubMenuViajes.Visible == true)
            {
                panelSubMenuViajes.Visible = false;
            }
            if (panelSubMenuCruceros.Visible == true)
            {
                panelSubMenuCruceros.Visible = false;
            }
            if (panelSubMenuEstadistica.Visible == true)
            {
                panelSubMenuEstadistica.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
                subMenu.Visible = true;
        }

        private void btn_Viajes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuViajes);
        }

        private void btn_Cruceros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCruceros);
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEstadistica);
        }

        /*
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(childForm);
                panelFormulario.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        */

        private void btn_VerViajes_Click(object sender, EventArgs e)
        {
            FormViaje formViaje = new FormViaje();

            //openChildForm(new FormViaje());
            
            formViaje.TopLevel = false;
            formViaje.FormBorderStyle = FormBorderStyle.None;
            formViaje.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formViaje);
            panelFormulario.Tag = formViaje;
            formViaje.BringToFront();
            formViaje.Show();
            
            hideSubMenu();
        }

        private void btn_InfoCruceros_Click(object sender, EventArgs e)
        {
            FormCruceros formCrucero = new FormCruceros();

            //openChildForm(new FormCruceros());

            formCrucero.TopLevel = false;
            formCrucero.FormBorderStyle = FormBorderStyle.None;
            formCrucero.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formCrucero);
            panelFormulario.Tag = formCrucero;
            formCrucero.BringToFront();
            formCrucero.Show();

            hideSubMenu();
        }
    }
}
