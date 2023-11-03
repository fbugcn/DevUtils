using DevUtils.CodeFormater.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevUtils.CodeFormater
{
    public delegate string[] CodeFormatingHandler(string[] codelines);
    public delegate void MessageEmergedHandler(string message);

    public partial class ucCodeViewer : UserControl
    {
        // 格式化方法
        public CodeFormatingHandler CodeFormating { get; set; }

        public MessageEmergedHandler MessageEmerged { get; set; }


        // 延迟(单位:毫秒)
        public int Delay { get; set; } = 1000;

        private LazyExecuter m_Executer;

        public ucCodeViewer()
        {
            InitializeComponent();
        }

        private void ucCodeViewer_Load(object sender, EventArgs e)
        {
            m_Executer = new LazyExecuter(onTime_Callback);
        }

        private void txtRaw_TextChanged(object sender, EventArgs e)
        {
            m_Executer.Invoke(this.Delay);
        }

        private void txtChanged_DoubleClick(object sender, EventArgs e)
        {
            txtChanged.SelectAll();

            if (txtChanged.SelectedText.Length > 0)
            {
                Clipboard.SetDataObject(txtChanged.SelectedText);
                onMessageEmerged("Text copied.");
            }
            else
            {
                onMessageEmerged("No text copied.");
            }
        }


        private void onTime_Callback(object state)
        {
            onCodeFormating();
        }

        protected virtual void onCodeFormating()
        {
            if (this.CodeFormating != null && txtRaw.Text.Length > 0)
            {
                txtChanged.Lines = this.CodeFormating(txtRaw.Lines);
            }
        }

        protected virtual void onMessageEmerged(string message)
        {
            if (this.MessageEmerged != null)
            {
                this.MessageEmerged(message);
            }
        }
    }
}
