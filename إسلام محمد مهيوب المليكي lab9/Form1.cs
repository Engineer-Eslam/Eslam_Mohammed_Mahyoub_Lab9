using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enabled();
            Height = panel1.Top + 25;
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(100);
                listBox1.Items.Add(n.ToString());
            }

        }

        //زر اضافة 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (!listBox1.Items.Contains(textBox1.Text.Trim()))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("الرقم موجود مسبقا");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("يجب ان يكون المدخل رقما");
                textBox1.Focus();
                textBox1.Clear();
            }

        }

        //زر< 
        private void button2_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedItems.Count;
            for (int i = 0; i < c; i++)
            {
                if (!listBox2.Items.Contains(listBox1.SelectedItems[0]))
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                }
                else
                    listBox1.SelectedItems.Remove(listBox1.SelectedItems[0]);
            }
        }

        //زر <<
        private void button3_Click(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count, j = 0;
            for (int i = 0; i < c; i++)
            {
                if (!listBox2.Items.Contains(listBox1.Items[j]))
                {
                    listBox2.Items.Add(listBox1.Items[j]);
                    listBox1.Items.Remove(listBox1.Items[j]);
                }
                else
                {
                    j++;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sortanylistbox(listBox1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (radioButton1.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لاتوجد عناصر زوجية");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (radioButton2.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لاتوجد عناصر فردية");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            bool flag = true;
            if (radioButton3.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int n = Convert.ToInt32(listBox1.Items[i]);
                    flag = true;
                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لايوجد عناصر اولية");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "v")
            {
                Height = button15.Top + button15.Height + 50;
                button4.Text = "^";
            }
            else
            {
                button4.Text = "v";
                Height = panel1.Top + 25;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void sortanylistbox(ListBox l /*note*/)
        {
            int t; int c = l.Items.Count;
            for (int i = 0; i < c; i++)
            {
                for (int j = i + 1; j < c; j++)
                {
                    int n1 = Convert.ToInt32(l.Items[i]),
                        n2 = Convert.ToInt32(l.Items[j]);
                    if (n1 < n2)
                    {
                        t = n1;
                        l.Items[i] = n2;
                        l.Items[j] = t;
                    }
                }
            }
        }

        //نقل المعكوسة
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            for (int i = 0; i < n; i++)
            {
                {
                    listBox2.Items.Add(listBox1.Items[listBox1.Items.Count - 1]);
                    listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox2);

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            sortanylistbox(listBox2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Add(textBox2.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Remove(textBox3.Text); 
            //listBox1.SelectedIndices.Remove(listBox1.Items.IndexOf(textBox3.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(textBox4.Text, out index))
            {
                listBox1.SelectedIndices.Remove(index);
                //if (index >= 0 && index < listBox1.Items.Count)
                //{
                //    listBox1.SelectedItems.Remove(listBox1.Items[index]);
                //}

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = listBox1.Items.Count.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox6.Text = listBox1.SelectedItems.Count.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox7.Text = (listBox1.Items.Count - listBox1.SelectedItems.Count).ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                }
            }
            else
                MessageBox.Show("not found elemnts");
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabled();
        }

        bool isnum(string element)
        {
            if (element == "")
                return false;
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] < 48 || element[i] > 57)
                    return false;
            }
            return true;
        }

        void enabled()
        {
            button2.Enabled = listBox1.SelectedIndex > -1;
        }

        void revers(ListBox l)
        {
            for (int i = l.Items.Count - 1; i >= 0; i--)
            {
                l.Items.Add(l.Items[i]);
                l.Items.Remove(l.Items[i]);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

    }
}