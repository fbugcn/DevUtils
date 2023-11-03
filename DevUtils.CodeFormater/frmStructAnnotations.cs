using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevUtils.CodeFormater
{
    public partial class frmStructAnnotations : Form
    {
        private System.Threading.Timer m_Timer;

        public frmStructAnnotations()
        {
            InitializeComponent();
            m_Timer = new System.Threading.Timer(mTimer_Callback);
            m_Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void frmStructAnnotations_Load(object sender, EventArgs e)
        {
            cViewer.CodeFormating = goStruct_Annotations_Unwapper;
            cViewer.MessageEmerged = goStruct_MessageReceived;
        }

        private void cViewer_Load(object sender, EventArgs e)
        {
            cViewer.Delay = (int)(nuDelay.Value * 1000);
        }

        private void nuDelay_ValueChanged(object sender, EventArgs e)
        {
            cViewer.Delay = (int)(nuDelay.Value * 1000);
        }

        private void mTimer_Callback(object state)
        {
            tslOutput.Text = string.Empty;
        }

        private string[] goStruct_Annotations_Unwapper(string[] codelines)
        {
            List<string> contents = new List<string>();
            string mark = string.Empty;
            foreach (string line in codelines)
            {
                string code = line.TrimStart(' ', '\t');
                if (code.StartsWith("//"))
                {
                    mark = code;
                } 
                else
                {
                    if (mark == string.Empty)
                    {
                        contents.Add(line);
                    }
                    else
                    {
                        contents.Add(line + mark);
                        mark = string.Empty;
                    }
                }
            }

            return contents.ToArray();
        }

        private void goStruct_MessageReceived(string message)
        {
            tslOutput.Text = message;

            m_Timer.Change(5000, Timeout.Infinite);
        }


    }
}
