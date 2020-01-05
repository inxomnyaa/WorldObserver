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
    public partial class InputTagForm : Form
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
                textBox1.Text = _nbtTag.StringValue;
                labelName.Text = _nbtTag.Name;
                labelType.Text = _nbtTag.TagType.ToString();
                if (_nbtTag is NbtByteArray || _nbtTag is NbtIntArray)//TODO custom editor
                {
                    textBox1.Multiline = true;
                }
            }
        }

        public InputTagForm()
        {
            InitializeComponent();
        }

        public InputTagForm(NbtTag tag)
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
        }

        private bool ValidateInput(string text)
        {
            text = text.Replace(".", ",");//TODO , or . by language
            try
            {
                switch (NBTTag.TagType)
                {
                    case NbtTagType.Byte:
                        {
                            NBTTag.ByteValue.GetType().Equals(byte.Parse(text));//throws exception if wrong, so no if needed
                            break;
                        }
                    case NbtTagType.Short:
                        {
                            NBTTag.ShortValue.GetType().Equals(short.Parse(text));
                            break;
                        }
                    case NbtTagType.Int:
                        {
                            NBTTag.IntValue.GetType().Equals(int.Parse(text));
                            break;
                        }
                    case NbtTagType.Long:
                        {
                            NBTTag.LongValue.GetType().Equals(long.Parse(text));
                            break;
                        }
                    case NbtTagType.Float:
                        {
                            NBTTag.FloatValue.GetType().Equals(float.Parse(text));
                            break;
                        }
                    case NbtTagType.Double:
                        {
                            NBTTag.DoubleValue.GetType().Equals(double.Parse(text));
                            break;
                        }
                    case NbtTagType.String:
                        {
                            NBTTag.StringValue.GetType().Equals(text);
                            break;
                        }
                    case NbtTagType.List:
                        {
                            //TODO edit name?
                            break;
                        }
                    case NbtTagType.Compound:
                        {
                            //TODO edit name?
                            break;
                        }
                    case NbtTagType.IntArray:
                        {
                            //TODO check all subs, editor
                            break;
                        }
                    case NbtTagType.ByteArray:
                        {
                            //TODO check all subs, editor
                            break;
                        }
                    default:
                        {
                            break;
                        }
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
                string text = this.textBox1.Text.Replace(".", ",");//TODO , or . by language
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
                    switch (NBTTag.TagType)
                    {
                        case NbtTagType.Byte:
                            {
                                NBTTag = new NbtByte(NBTTag.Name, byte.Parse(text));
                                break;
                            }
                        case NbtTagType.Short:
                            {
                                NBTTag = new NbtShort(NBTTag.Name, short.Parse(text));
                                break;
                            }
                        case NbtTagType.Int:
                            {
                                NBTTag = new NbtInt(NBTTag.Name, int.Parse(text));
                                break;
                            }
                        case NbtTagType.Long:
                            {
                                NBTTag = new NbtLong(NBTTag.Name, long.Parse(text));
                                break;
                            }
                        case NbtTagType.Float:
                            {
                                NBTTag = new NbtFloat(NBTTag.Name, float.Parse(text));
                                break;
                            }
                        case NbtTagType.Double:
                            {
                                NBTTag = new NbtDouble(NBTTag.Name, double.Parse(text));
                                break;
                            }
                        case NbtTagType.String:
                            {
                                NBTTag = new NbtString(NBTTag.Name, text);
                                break;
                            }
                        case NbtTagType.List:
                            {
                                //TODO
                                break;
                            }
                        case NbtTagType.Compound:
                            {
                                //TODO
                                break;
                            }
                        case NbtTagType.IntArray:
                            {
                                //TODO
                                break;
                            }
                        case NbtTagType.ByteArray:
                            {
                                //TODO
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                return;
            }
        }
    }
}
