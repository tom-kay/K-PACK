using _02.K_CONTROL_WIN;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kButton1_Click(object sender, EventArgs e)
        {
            //kDropdownMenu1.Show(kButton1, kDropdownMenu1.Width, 0);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kDropdownMenu1.IsMainMenu = true;
            kDropdownMenu1.PrimaryColor = Color.FromArgb(170, 199, 255);
            kDropdownMenu1.MenuItemTextColor = Color.White;
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
            if(!DesignMode)
            {
                ctrl.BackColor = Color.FromArgb(51, 60, 77);
            }
        }

        private void kButton1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void kButton1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void kButton1_MouseEnter(object sender, EventArgs e)
        {
            Open_DropdownMenu(kDropdownMenu1, sender);
        }
    }
}
