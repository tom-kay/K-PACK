namespace _5.Business
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kDropdownMenu1 = new _2.K_CONTROL_WIN.KDropdownMenu(components);
            SuspendLayout();
            // 
            // kDropdownMenu1
            // 
            kDropdownMenu1.IsMainMenu = false;
            kDropdownMenu1.MenuItemHeight = 25;
            kDropdownMenu1.MenuItemTextColor = Color.Empty;
            kDropdownMenu1.Name = "kDropdownMenu1";
            kDropdownMenu1.PrimaryColor = Color.Empty;
            kDropdownMenu1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private _2.K_CONTROL_WIN.KDropdownMenu kDropdownMenu1;
    }
}
