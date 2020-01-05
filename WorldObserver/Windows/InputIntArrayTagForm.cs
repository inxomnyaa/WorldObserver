using fNbt;
using JetBrains.Annotations;
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
    public partial class InputIntArrayTagForm : Form
    {
        private NbtIntArray _nbtTag { get; set; }

        public NbtIntArray NBTTag
        {
            get
            {
                return _nbtTag;
            }
            set
            {
                _nbtTag = value;
                textBox1.Lines = MainClass.IntArrayToStringArray(_nbtTag.IntArrayValue.ToArray());
                labelName.Text = _nbtTag.Name;
                labelType.Text = _nbtTag.TagType.ToString();
            }
        }

        

        public InputIntArrayTagForm()
        {
            InitializeComponent();
        }

        public InputIntArrayTagForm(NbtIntArray tag)
        {
            InitializeComponent();
            NBTTag = tag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.ControlText;//TODO default color
            button1.Enabled = true;
            TextBox textBox = sender as TextBox;
            string[] text = textBox.Lines;
            if (!ValidateInput(text))
            {
                textBox1.ForeColor = Color.Tomato;//TODO find a better color
                button1.Enabled = false;
            }
        }

        private bool ValidateInput(string[] text)
        {
            try
            {
                foreach (string line in text)
                {
                    int.Parse(line);//throws exception if wrong, so no if needed
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                string[] text = this.textBox1.Lines;
                if (!ValidateInput(text))
                {
                    textBox1.ForeColor = Color.Tomato;//TODO find a better color
                    button1.Enabled = false;
                    e.Cancel = true;
                    (new AlertForm("The input is invalid!")
                    {
                        Icon = SystemIcons.Error,
                        Text = "Invalid input!"
                    }).ShowDialog();
                }
                else
                {
                    NBTTag = new NbtIntArray(NBTTag.Name, MainClass.StringToIntArray(text));
                }
                return;
            }
        }
    }
}
