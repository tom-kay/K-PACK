using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public class DataHandles
	{
		/// <summary>
		/// DTO 값을 Control에 바인딩한다.
		/// </summary>
		/// <typeparam name="T">DTO Class</typeparam>
		/// <param name="control">대상 Control</param>
		/// <param name="dto">대상 DTO</param>
		public static void DtoToControls<T>(Control control, T dto) where T : class
		{
			foreach (Control c in control.Controls)
			{
				if (c is KRadioButton || c is RadioButton)
				{
					if (c.Tag != null)
					{
						if (c is KRadioButton)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null && dto.GetType().GetProperty(tuple.Item1) != null)
							{
								(c as KRadioButton).Checked = Convert.ToString(dto.GetType().GetProperty(tuple.Item1).GetValue(dto, null)) == tuple.Item2;
							}
						}
						else if (c is RadioButton)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null && dto.GetType().GetProperty(tuple.Item1) != null)
							{
								(c as RadioButton).Checked = Convert.ToString(dto.GetType().GetProperty(tuple.Item1).GetValue(dto, null)) == tuple.Item2;
							}
						}
					}
				}
				else
				{
					if (c.Tag != null && dto.GetType().GetProperty(c.Tag.ToString()) != null && dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null) != null)
					{
						if (c is KTextBox)
						{
							(c as KTextBox).Texts = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null).ToString();
						}
						else if (c is TextBox)
						{
							c.Text = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null).ToString();
						}
						else if (c is KComboBox)
						{
							(c as KComboBox).SelectedItem = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null);
						}
						else if (c is ComboBox)
						{
							(c as ComboBox).SelectedItem = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null);
						}
						else if (c is CheckBox)
						{
							(c as CheckBox).Checked = (bool)dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null);
						}

					}
				}

				if (c.HasChildren)
				{
					DtoToControls(c, dto);
				}
			}
		}

		/// <summary>
		/// Control값을 DTO에 바인딩한다.
		/// </summary>
		/// <typeparam name="T">DTO Class</typeparam>
		/// <param name="control">대상 Control</param>
		/// <param name="dto">대상 DTO</param>
		/// <returns></returns>
		public static T ControlsToDto<T>(Control control, T dto) where T : class
		{
			foreach (Control c in control.Controls)
			{
				if (c is KRadioButton || c is RadioButton)
				{
					if (c.Tag != null)
					{
						if (c is KRadioButton && (c as KRadioButton).Checked)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null)
							{
								dto.GetType().GetProperty(tuple.Item1).SetValue(dto, tuple.Item2);
							}
						}
						else if (c is RadioButton && (c as RadioButton).Checked)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null)
							{
								dto.GetType().GetProperty(tuple.Item1).SetValue(dto, tuple.Item2);
							}
						}
					}
				}
				else
				{
					if (c.Tag != null && dto.GetType().GetProperty(c.Tag.ToString()) != null)
					{
						if (c is KTextBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as KTextBox).Texts);
						}
						else if (c is TextBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, c.Text);
						}
						else if (c is KComboBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as KComboBox).SelectedItem);
						}
						else if (c is ComboBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as ComboBox).SelectedItem);
						}
						else if (c is CheckBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as CheckBox).Checked);
						}

					}
				}

				if (c.HasChildren)
				{
					ControlsToDto(c, dto);
				}
			}
			return dto;
		}
	}
}
