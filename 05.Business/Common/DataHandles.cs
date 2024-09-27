using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
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
				else if (c is KCodeNameBox)
				{
                    if (c.Tag != null)
                    {
						string[] tags = c.Tag.ToString().Split('|');

                        (c as KCodeNameBox).CodeValue = Convert.ToString(dto.GetType().GetProperty(tags[0]).GetValue(dto, null));
                        if (tags.Length > 1 && dto.GetType().GetProperty(tags[1]) != null && dto.GetType().GetProperty(tags[1]).GetValue(dto, null) != null)
						{	
							(c as KCodeNameBox).NameValue = dto.GetType().GetProperty(tags[1]).GetValue(dto, null).ToString();
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
                        else if (c is KDateBox)
                        {
                            (c as KDateBox).DateValue = dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null).ToString();
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
                else if (c is KCodeNameBox)
                {
					string[] tags = c.Tag.ToString().Split('|');
					if (c.Tag != null && dto.GetType().GetProperty(tags[0]) != null)
					{
						dto.GetType().GetProperty(tags[0]).SetValue(dto, (c as KCodeNameBox).CodeValue);
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
                        else if (c is KDateBox)
                        {
                            dto.GetType().GetProperty(c.Tag.ToString()).SetValue(dto, (c as KDateBox).DateValue);
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

		public static DataTable ConvertToDataTable<T>(IList<T> data)
		{
			if (data == null) return null;

			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			DataTable dt = new DataTable();
			foreach (PropertyDescriptor prop in properties)
				dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			foreach (T item in data)
			{
				DataRow row = dt.NewRow();
				foreach (PropertyDescriptor prop in properties)
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				dt.Rows.Add(row);
			}
			return dt;
		}

        public static DataRow ConvertToDataRow<T>(T data, DataTable dt)
        {
            if (data == null || dt == null) return null;

            // 새로운 DataRow 객체를 생성합니다.
            DataRow row = dt.NewRow();

            // T 객체의 프로퍼티 값을 DataRow에 설정합니다.
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(data) ?? DBNull.Value;

            // 생성된 DataRow를 반환합니다.
            return row;
        }


        public static DataRow ConvertToDataRow<T>(T data)
        {
            if (data == null) return null;

            // 새로운 DataTable을 생성합니다.
            DataTable dt = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in properties)
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            // 새로운 DataRow 객체를 생성합니다.
            DataRow row = dt.NewRow();

            // T 객체의 프로퍼티 값을 DataRow에 설정합니다.
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(data) ?? DBNull.Value;

            // 생성된 DataRow를 반환하기 전에 DataTable에 추가합니다.
            dt.Rows.Add(row);

            // 생성된 DataRow를 반환합니다.
            return row;
        }


        public static List<T> ConvertToList<T>(DataTable dt) where T : new()
		{
			if (dt == null) return null;

			List<T> list = new List<T>();

			foreach (DataRow row in dt.Rows)
			{
				T item = new T();
				foreach (DataColumn column in dt.Columns)
				{
					PropertyInfo property = item.GetType().GetProperty(column.ColumnName);
					if (property != null)
					{
						object value = null;
						if (row.RowState == DataRowState.Deleted)
						{
							value = row[column, DataRowVersion.Original];
						}
						else if (row[column] != DBNull.Value)
						{
							value = row[column];
						}

						if (value != null && value != DBNull.Value) // DBNull.Value를 체크합니다.
						{
							if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
							{
								property.SetValue(item, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)), null);
							}
							else
							{
								property.SetValue(item, Convert.ChangeType(value, property.PropertyType), null);
							}
						}
					}
				}

				PropertyInfo prop = item.GetType().GetProperty("DataState");
				if (prop != null)
				{
					prop.SetValue(item, row.RowState, null);
				}
				list.Add(item);
			}

			return list;
		}

        public static T ConvertToData<T>(DataTable dt) where T : new()
        {
            if (dt == null || dt.Rows.Count == 0) return default(T);

            DataRow row = dt.Rows[0];
            T item = new T();
            foreach (DataColumn column in dt.Columns)
            {
                PropertyInfo property = item.GetType().GetProperty(column.ColumnName);
                if (property != null)
                {
                    object value = null;
                    if (row.RowState == DataRowState.Deleted)
                    {
                        value = row[column, DataRowVersion.Original];
                    }
                    else if (row[column] != DBNull.Value)
                    {
                        value = row[column];
                    }

                    if (value != null && value != DBNull.Value) // DBNull.Value를 체크합니다.
                    {
                        if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            property.SetValue(item, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)), null);
                        }
                        else
                        {
                            property.SetValue(item, Convert.ChangeType(value, property.PropertyType), null);
                        }
                    }
                }
            }

            PropertyInfo prop = item.GetType().GetProperty("DataState");
            if (prop != null)
            {
                prop.SetValue(item, row.RowState, null);
            }

            return item;
        }

    }
}
