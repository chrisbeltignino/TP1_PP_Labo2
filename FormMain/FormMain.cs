using System;
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
    public partial class Form2 : Form
    {
        public Form2()
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
    }
}
