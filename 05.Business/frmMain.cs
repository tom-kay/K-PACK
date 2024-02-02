using _01.K_DESIGN_WIN;
using _02.K_CONTROL_WIN;
using _05.Business._03.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Business
{
    public partial class frmMain : frmMdiContainer
    {
        public frmMain()
        {
            InitializeComponent();

            frmLogin login = new frmLogin();
            login.ShowDialog();

            frmPopup popup = new frmPopup();
            popup.ShowDialog();

            base.btnMaximum_Click(null, null);

          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            drm0.IsMainMenu = true;
            drm0.PrimaryColor = Color.FromArgb(170, 199, 255);
            drm0.MenuItemTextColor = Color.White;
            drm0.Font = new Font("Verdana", 15f);

            btnMenu0.MouseEnter += OpenSubMenu;
            btnMenu0.Click += OpenSubMenu;

        }

        private void OpenSubMenu(object sender, EventArgs e)
        {
            Open_DropdownMenu(drm0, sender);
        }

        private void Open_DropdownMenu(KDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);

        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            KDropdownMenu dropdownMenu = (KDropdownMenu)sender;
            if (!DesignMode)
            {
                ctrl.BackColor = Color.FromArgb(51, 60, 77);
            }
        }

        private void 그래프ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            base.OpenChildForm(new frmCodeMasterMng(), null);
        }
    }
}
