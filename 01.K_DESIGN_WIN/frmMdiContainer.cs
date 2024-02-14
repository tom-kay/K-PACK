using P01_K_DESIGN_WIN.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
{
	public partial class frmMdiContainer : MetroFramework.Forms.MetroForm
	{	
		private Random random;
		private int tempIndex;
		
		private int tolerance = 15;
		private const int WM_NCHITTEST = 132;
		private const int HTBOTTOMRIGHT = 17;

		private Rectangle sizeGripRectangle;

		//Constructor
		public frmMdiContainer()
		{
			InitializeComponent();
			random = new Random();
			btnCloseChildForm.Visible = false;
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.DoubleBuffered = true;

			tabMenuForm.TabPages.Clear();   // 모든 메뉴탭 지우기
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		//Methods
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case WM_NCHITTEST:
					base.WndProc(ref m);
					var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
					if (sizeGripRectangle.Contains(hitPoint))
						m.Result = new IntPtr(HTBOTTOMRIGHT);
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

			sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

			region.Exclude(sizeGripRectangle);
			this.pnlMainContainer.Region = region;
			this.Invalidate();

			if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
			{
				btnNormal.Visible = true;
				btnMaximum.Visible = false;
			}
			else
			{
				btnNormal.Visible = false;
				btnMaximum.Visible = true;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{

			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
			e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

			base.OnPaint(e);
			ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

		}

		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}
		
		private void DisableButton()
		{
			foreach (Control previousBtn in panelTopMenuBar.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}
		protected void OpenChildForm(Form childForm)
		{	
			TabPage page = CreateMenuTab(childForm);   //메뉴탭에 메뉴 활성화
			lblTopMenuCaption.Text = childForm.Text;	//화면명 표시
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			page.Controls.Add(childForm);
			page.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();

			btnCloseChildForm.Visible = true;
		}

		private TabPage CreateMenuTab(Form childForm)
		{
			TabPage tabPage = new TabPage();
			tabPage.Text = childForm.Text;
			tabPage.Tag = childForm.Name;
			tabMenuForm.TabPages.Add(tabPage);
			tabMenuForm.TabPages.IndexOf(tabPage);
			tabMenuForm.SelectTab(tabMenuForm.TabPages.IndexOf(tabPage));

			return tabPage;
		}

		protected void OpenMenu(Form frm)
		{
			//오픈되어 있는 화면이 있으면 활성화 
			foreach (Form openForm in Application.OpenForms)
			{
				if (openForm.Name.Equals(frm.Name))
				{
					openForm.Activate();    //폼 활성화
					lblTopMenuCaption.Text = openForm.Text;	// 화면명 표시
					//탭 선택
					foreach (TabPage item in tabMenuForm.TabPages)
					{
						Form pageForm = item.Tag as Form;
						if (pageForm.Name.Equals(frm.Name))
						{
							tabMenuForm.SelectTab(tabMenuForm.TabPages.IndexOf(item));
						}
					}
					return;
				}
			}
			//없으면 새로 오픈한다.
			OpenChildForm(frm);
		}

		private void btnCloseChildForm_Click(object sender, EventArgs e)
		{
            foreach (Control ctrl in tabMenuForm.SelectedTab.Controls)
            {
                if (ctrl is Form)
                {
					Form frm = ctrl as Form;
					frm.Close();
					if (frm.IsDisposed == true)
					{
						tabMenuForm.TabPages.Remove(tabMenuForm.SelectedTab);
					}
				}
            }

			if (Application.OpenForms.Count < 2)
				Reset();
		}
		private void Reset()
		{
			//DisableButton();
			//panelSubMenuBar.BackColor = Color.FromArgb(51, 60, 77);
			//panelLogo.BackColor = Color.FromArgb(51, 60, 77);
			
			btnCloseChildForm.Visible = false;
		}
		private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Clicks == 2)
			{
				pnlTitleBar_MouseDoubleClick(sender, e);
			}
			else if (e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
		}

		private void pnlTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
			{
				btnNormal_Click(sender, e);
			}
			else
			{
				btnMaximum_Click(sender, e);
			}

		}

		protected void btnNormal_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;

			btnNormal.Visible = false;
			btnMaximum.Visible = true;
		}
		protected void btnMaximum_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;

			btnMaximum.Visible = false;
			btnNormal.Visible = true;
		}
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			if (KMessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void tmDateTime_Tick(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToLongDateString();
			lblTime.Text = DateTime.Now.ToString("HH:mm:ssss");
		}

		private void tabMenuForm_Selected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage != null && e.TabPage.Tag is Form)
			{
				lblTopMenuCaption.Text = (e.TabPage.Tag as Form).Text; 
			}
		}
	}
}
