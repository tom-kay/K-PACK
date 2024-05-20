using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_K_CONTROL_WIN
{
	public class KButtonCalendar : Button
	{
		MonthCalendar calendar;
		Form parentForm;
		public DateTime SelectedDate { get; private set; }

		public KButtonCalendar()
		{
			calendar = new MonthCalendar
			{
				Visible = false,
				MaxSelectionCount = 1,
			};
			calendar.DateSelected += Calendar_DateSelected;
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			//parentForm = FindForm();
			//if (parentForm == null)
			//{
			//	parentForm = this.Parent.FindForm();
			//}


			//if (parentForm != null && !parentForm.Controls.Contains(calendar))
			//{
			//	parentForm.Controls.Add(calendar);
			//	parentForm.Controls.SetChildIndex(calendar, 0);
			//	parentForm.Resize += ParentForm_Resize;
			//}
		}

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            parentForm = FindForm();
            if (parentForm == null)
            {
                parentForm = this.Parent.FindForm();
            }


            if (parentForm != null && !parentForm.Controls.Contains(calendar))
            {
                parentForm.Controls.Add(calendar);
                parentForm.Controls.SetChildIndex(calendar, 0);
                parentForm.Resize += ParentForm_Resize;
            }
        }

        private void ParentForm_Resize(object sender, EventArgs e)
		{
			if (calendar.Visible)
			{
				calendar.Size = calendar.PreferredSize;
				Point screenPoint = PointToScreen(new Point(0, Height));
				Point clientPoint = parentForm.PointToClient(screenPoint);
				if (clientPoint.Y + calendar.Height > parentForm.ClientSize.Height)
				{
					clientPoint.Y = parentForm.ClientSize.Height - calendar.Height;
				}
				if (clientPoint.X + calendar.Width > parentForm.ClientSize.Width)
				{
					clientPoint.X = parentForm.ClientSize.Width - calendar.Width;
				}
				calendar.Location = clientPoint;
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			Point screenPoint = PointToScreen(new Point(0, Height));
			Point clientPoint = parentForm.PointToClient(screenPoint);
			if (clientPoint.Y + calendar.Height > parentForm.ClientSize.Height)
			{
				clientPoint.Y = parentForm.ClientSize.Height - (calendar.Height < 160 ? 162 : calendar.Height);
			}
			if (clientPoint.X + calendar.Width > parentForm.ClientSize.Width)
			{
				clientPoint.X = parentForm.ClientSize.Width - (calendar.Width < 200 ? 220 : calendar.Width);
			}
			calendar.Location = clientPoint;
			calendar.BringToFront();
			calendar.Visible = !calendar.Visible;
		}

		private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			calendar.Visible = false;
			if (Tag is string textBoxName)
			{
				var controls = parentForm.Controls.Find(textBoxName, true);
				if (controls.Length > 0)
				{
					var textBox = controls[0];
					if (textBox is KTextBox)
					{
						((KTextBox)textBox).Texts = e.Start.ToShortDateString();
					}
                    else if (textBox is Label) 
					{
						textBox.Text = e.Start.ToShortDateString();
					}
                    
                }
			}
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			if (!calendar.RectangleToScreen(calendar.ClientRectangle).Contains(Cursor.Position))
			{
				calendar.Visible = false;
			}
		}

	}
}
