using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mb;
            mb = MessageBoxButtons.YesNoCancel;
            MessageBox.Show("vs2015的桌面编程好像很简单的样子", "这是一个简单的测试", mb, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
    }
}
