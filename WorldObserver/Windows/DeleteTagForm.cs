using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldObserver.Windows
{
    public partial class DeleteTagForm : Form
    {

        public string Result
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public DeleteTagForm()
        {
            InitializeComponent();
        }
    }
}
