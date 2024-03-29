﻿using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
							(c as KComboBox).SelectedValue = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null);
						}
						else if (c is ComboBox)
						{
							(c as ComboBox).SelectedValue = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null);
						}
						else if (c is KToggleButton)
						{
							(c as KToggleButton).Checked = Convert.ToBoolean(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null));
						}
						else if (c is CheckBox)
						{
							(c as CheckBox).Checked = Convert.ToBoolean(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null));
						}
						else
						{
							c.Text = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null).ToString();
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
							Type underlyingType = Nullable.GetUnderlyingType(dto.GetType().GetProperty(c.Tag.ToString()).PropertyType);

							object textValue;
							if (underlyingType != null)
							{
								string text = (c as KTextBox).Texts;
								int number;
								bool success = int.TryParse(text, out number);
								textValue = string.IsNullOrEmpty(text) || !success ? null : (object)number;
							}
							else
							{
								if (dto.GetType().GetProperty(c.Tag.ToString()).PropertyType == typeof(int))
								{
									textValue = Convert.ToInt32((c as KTextBox).Texts);
								}
								else
								{
									textValue = (c as KTextBox).Texts;
								}
							}

							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, textValue);
						}
						else if (c is TextBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, c.Text);
						}
						else if (c is KComboBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as KComboBox).SelectedValue);
						}
						else if (c is ComboBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as ComboBox).SelectedValue);
						}
						else if (c is KToggleButton)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as KToggleButton).Checked);
						}
						else if (c is CheckBox)
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as CheckBox).Checked);
						}
						else
						{
							dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, c.Text);
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

		public static ICollection<ValidationResult> Validate<T> (T dto) where T : class 
		{
			var context = new ValidationContext(dto, null, null);
			var results = new List<ValidationResult>();

			bool isValid = Validator.TryValidateObject(dto, context, results, true);

			if (!isValid)
			{
				foreach (var validationResult in results)
				{
					KMessageBox.Show(validationResult.ErrorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return results;
		}


	}
}
