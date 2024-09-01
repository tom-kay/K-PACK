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
        private string _NAMESPACE = string.Empty;
        private string _FORMNAME = string.Empty;
        private string _FORMTITLE = string.Empty;
        private object _ADDPARAMS = null;

        Type _FORMTYPE;
        Form _FORMINSTANCE;

        //Events
        public event EventHandler OnCodeChanged;//Default event

        [Category("CodeValue"), Description("코드 값을 설정하거나 거져온다.")]
        public string CodeValue
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
            }
        }

        [Category("NameValue"), Description("네임 값을 설정하거나 거져온다.")]
        public string NameValue
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
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

        [Category("FormTitle"), Description("FormTitle 값을 설정하거나 거져온다.")]
        public string FormTitle
        {
            get
            {
                return _FORMTITLE;
            }
            set
            {
                _FORMTITLE = value;
            }
        }

        [Category("AddParams"), Description("AddParams 값을 설정하거나 거져온다.")]
        public object AddParams
        {
            get
            {
                return _ADDPARAMS;
            }
            set
            {
                _ADDPARAMS = value;
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

                txtCode.Tag = null;

                //이벤트 발생
                if (!string.IsNullOrEmpty(txtCode.Text))
                {
                    if (OnCodeChanged != null)
                        OnCodeChanged.Invoke(this, e); 
                }

            }
            catch { }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPopupForm();

                //이벤트 발생
                if (!string.IsNullOrEmpty(txtCode.Text))
                {
                    if (OnCodeChanged != null)
                        OnCodeChanged.Invoke(this, e);
                }
            }
            catch{ }
        }

        private void LoadPopupForm(string codeValue = "")
        {
            if (_FORMTYPE == null) return;

            object[] args = { };
            Array.Resize(ref args, args.Length + 1);
            args[args.Length - 1] = _FORMTITLE;
            Array.Resize(ref args, args.Length + 1);
            args[args.Length - 1] = _ADDPARAMS;
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
