using fNbt;
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
    public partial class RenameForm : Form
    {

        private NbtTag _nbtTag { get; set; }

        public NbtTag NBTTag
        {
            get
            {
                return _nbtTag;
            }
            set
            {
                _nbtTag = value;
                textBox1.Text = _nbtTag.Name;
                labelType.Text = _nbtTag.TagType.ToString();
                if (_nbtTag is NbtByteArray || _nbtTag is NbtIntArray)//TODO custom editor
                {
                    textBox1.Multiline = true;
                }
            }
        }

        public RenameForm()
        {
            InitializeComponent();
        }

        public RenameForm(NbtTag tag)
        {
            InitializeComponent();
            NBTTag = tag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.ControlText;//TODO default color
            button1.Enabled = true;
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            if (!ValidateInput(text))
            {
                textBox1.ForeColor = Color.Tomato;//TODO find a better color
                button1.Enabled = false;
            }
            else
            {
                NBTTag.Name = text;
            }
        }

        private bool ValidateInput(string text)
        {
            foreach (char c in text.ToCharArray())
            {
                if (!char.IsLetter(c)) return false;
            }
            return true;
        }

        private void RenameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                e.Cancel = !ValidateInput(textBox1.Text);
                if (e.Cancel)
                    (new AlertForm("The input is invalid!")
                    {
                        Icon = SystemIcons.Error,
                        Text = "Invalid input!"
                    }).ShowDialog();
            }
        }
    }
}
