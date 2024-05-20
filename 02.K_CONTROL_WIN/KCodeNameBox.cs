using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P02_K_CONTROL_WIN
{
    public partial class KCodeNameBox : UserControl
    {
        private string _CODE = string.Empty;
        private string _NAME = string.Empty;
        private string _NAMESPACE = string.Empty;
        private string _FORMNAME = string.Empty;

        Type _FORMTYPE;
        Form _FORMINSTANCE;

        [Category("ValueCode"), Description("코드 값을 설정하거나 거져온다.")]
        public string ValueCode
        {
            get
            {
                return _CODE;
            }
            set
            {
                _CODE = value;
            }
        }

        [Category("ValueName"), Description("네임 값을 설정하거나 거져온다.")]
        public string ValueName
        {
            get
            {
                return _NAME;
            }
            set
            {
                _NAME = value;
            }
        }

        [Category("Namespace"), Description("Namespace 값을 설정하거나 거져온다.")]
        public string Namespace
        {
            get
            {
                return _NAMESPACE;
            }
            set
            {
                this._NAMESPACE = value;
            }
        }

        [Category("FormName"), Description("FormName 값을 설정하거나 거져온다.")]
        public string FormName
        {
            get
            {
                return _FORMNAME;
            }
            set
            {
                _FORMNAME = value;
            }
        }

        public KCodeNameBox()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode)
            {
                Assembly assembly = Assembly.LoadFile(Assembly.GetEntryAssembly().Location);

                _FORMTYPE = assembly.GetType(string.Concat(_NAMESPACE, ".", _FORMNAME));
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCode.Text.Trim())) return;

                LoadPopupForm(txtCode.Text.Trim());

            }
            catch { }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPopupForm();
            }
            catch{ }
        }

        private void LoadPopupForm(string codeValue = "")
        {
            if (_FORMTYPE == null) return;

            object[] args = { };
            Array.Resize(ref args, args.Length + 1);
            args[args.Length - 1] = "CODE MASTER";
            if (!string.IsNullOrEmpty(codeValue))
            {
                Array.Resize(ref args, args.Length + 1);
                args[args.Length - 1] = codeValue;

                _FORMINSTANCE = (Form)Activator.CreateInstance(_FORMTYPE, args);

                if (_FORMINSTANCE.DialogResult != DialogResult.OK) return;                
            }
            else
            {
                _FORMINSTANCE = (Form)Activator.CreateInstance(_FORMTYPE, args);

                if (_FORMINSTANCE.ShowDialog() != DialogResult.OK) return;
                
            }

            PropertyInfo propertyInfo;

            propertyInfo = _FORMINSTANCE.GetType().GetProperty("ResultCode");
            object codeResult = propertyInfo.GetValue(_FORMINSTANCE);

            propertyInfo = _FORMINSTANCE.GetType().GetProperty("ResultName");
            object nameResult = propertyInfo.GetValue(_FORMINSTANCE);

            txtCode.Text = codeResult.ToString();
            txtName.Text = nameResult.ToString();

        }

    }
}
