using MetroFramework.Controls;
using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN.Classes
{
	public class FormSettings
	{
		private const string FORM_FONT_NAME = "Microsoft New Tai Lue";
		private const float FORM_FONT_SIZE = 12f;

		private static string DISABLE_COLOR_HEX = "#F0F0F0";
		static Color TEXTBOX_DISABLE_COLOR = ColorTranslator.FromHtml(DISABLE_COLOR_HEX);

		public static void Control_Init(Control control)
		{
			foreach (Control ctrl in control.Controls)
			{
				if (ctrl is KTextBox)
				{
					((KTextBox)ctrl).Texts = string.Empty;
				}
				else if (ctrl is TextBox)
				{
					((TextBox)ctrl).Text = string.Empty;
				}
				else if (ctrl is KComboBox)
				{
					if (((KComboBox)ctrl).DataSource != null)
					{
						((KComboBox)ctrl).SelectedIndex = 0;
					}
				}
				else if (ctrl is MetroCheckBox)
				{
					((MetroCheckBox)ctrl).Checked = false;
				}
				else if (ctrl is CheckBox)
				{
					((CheckBox)ctrl).Checked = false;
				}
				else if (ctrl is KRadioButton)
				{
					((KRadioButton)ctrl).Checked = false;
				}
				else if (ctrl is RadioButton)
				{
					((RadioButton)ctrl).Checked = false;
				}

				if (ctrl.Controls.Count > 0)
				{
					Control_Init(ctrl);
				}
			}
		}

		public static void Control_SetDesign(Control control)
		{
			foreach (Control ctrl in control.Controls)
			{
				if (ctrl is Label)
				{
					if (ctrl.Parent is KComboBox) continue;

					Label lbl = (Label)ctrl;

					lbl.AutoSize = false;
					lbl.Dock = DockStyle.Fill;
					if (lbl.FindForm().GetType().BaseType.Name.Equals("frmSearchContainer"))
					{
						lbl.ForeColor = SystemColors.WindowText;
						lbl.BackColor = Color.Transparent;
					} 
					else
					{
						lbl.ForeColor = Color.White;
						lbl.BackColor = Color.CornflowerBlue;
					}
					lbl.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE, FontStyle.Bold);
				}
				else if (ctrl is KTextBox)
				{
					KTextBox txt = (KTextBox)ctrl;
					txt.ForeColor = SystemColors.WindowText;
					txt.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
					TextBox_EnabledChanged(ctrl, null);
				}
				else if (ctrl is TextBox)
				{
					TextBox txt = (TextBox)ctrl;
					txt.ForeColor = SystemColors.WindowText;
					txt.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
					TextBox_EnabledChanged(ctrl, null);
				}
				else if (ctrl is KComboBox)
				{
					KComboBox cbo = (KComboBox)ctrl;
					cbo.ForeColor = SystemColors.WindowText;
					cbo.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
				}
				else if (ctrl is ComboBox)
				{
					ComboBox cbo = (ComboBox)ctrl;
					cbo.ForeColor = SystemColors.WindowText;
					cbo.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
				}
				else if (ctrl is KRadioButton)
				{
					KRadioButton rdo = (KRadioButton)ctrl;
					rdo.ForeColor = SystemColors.WindowText;
					rdo.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
				}
				else if (ctrl is RadioButton)
				{
					RadioButton rdo = (RadioButton)ctrl;
					rdo.ForeColor = SystemColors.WindowText;
					rdo.Font = new Font(FORM_FONT_NAME, FORM_FONT_SIZE);
				}

				if (ctrl.Controls.Count > 0)
				{
					Control_SetDesign(ctrl);
				}
			}
		}

		public static void Control_SetEvents(Control control)
		{
			foreach (Control ctrl in control.Controls)
			{
				if (ctrl is KTextBox)
				{
					((KTextBox)ctrl).Enter += TextBox_Enter;
					((KTextBox)ctrl).Leave += TextBox_Leave;
					((KTextBox)ctrl).EnabledChanged += TextBox_EnabledChanged;

				}
				else if (ctrl is TextBox)
				{
					((TextBox)ctrl).Enter += TextBox_Enter;
					((TextBox)ctrl).Leave += TextBox_Leave;
					((TextBox)ctrl).EnabledChanged += TextBox_EnabledChanged;
				}


				if (ctrl.Controls.Count > 0)
				{
					Control_SetEvents(ctrl);
				}
			}
		}

		public static void TextBox_EnabledChanged(object sender, EventArgs e)
		{
			if (sender is KTextBox)
			{
				KTextBox txt = (KTextBox)sender;

				if (txt.Enabled)
				{
					if (((KTextBox)sender).Parent is Panel)
					{
						((Panel)((KTextBox)sender).Parent).BackColor = SystemColors.Window;
					}
				}
				else
				{
					if (((KTextBox)sender).Parent is Panel)
					{
						((Panel)((KTextBox)sender).Parent).BackColor = TEXTBOX_DISABLE_COLOR;
					}
				}
			}
			else if (sender is TextBox)
			{
				TextBox txt = (TextBox)sender;

				if (txt.Enabled)
				{
					if (((TextBox)sender).Parent is Panel)
					{
						((Panel)((TextBox)sender).Parent).BackColor = SystemColors.Window;
					}
				}
				else
				{
					if (((TextBox)sender).Parent is Panel)
					{
						((Panel)((TextBox)sender).Parent).BackColor = TEXTBOX_DISABLE_COLOR;
					}
				}
			}
		}



		/// <summary>
		/// 텍스트 박스가 활성화 되었을 때
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public static void TextBox_Enter(object sender, EventArgs e)
		{
			if (sender is KTextBox)
			{
				((KTextBox)sender).BackColor = Color.Beige;
				if (((KTextBox)sender).Parent is Panel)
				{
					((Panel)((KTextBox)sender).Parent).BackColor = Color.Beige;
				}
			}
			else if (sender is TextBox)
			{
				((TextBox)sender).BackColor = Color.Beige;
				if (((TextBox)sender).Parent is Panel)
				{
					((Panel)((TextBox)sender).Parent).BackColor = Color.Beige;
				}
			}
		}

		/// <summary>
		/// 텍스트 박스가 비활성화 되었을 때
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		public static void TextBox_Leave(object sender, EventArgs e)
		{
			if (sender is KTextBox)
			{
				((KTextBox)sender).BackColor = SystemColors.Window;
				if (((KTextBox)sender).Parent is Panel)
				{
					((Panel)((KTextBox)sender).Parent).BackColor = SystemColors.Window;
				}
			}
			else if (sender is TextBox)
			{
				((TextBox)sender).BackColor = SystemColors.Window;
				if (((TextBox)sender).Parent is Panel)
				{
					((Panel)((TextBox)sender).Parent).BackColor = SystemColors.Window;
				}
			}

		}



	}
}
