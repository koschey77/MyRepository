using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW3_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnSearch.Click += Button1_Click;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Введите маску поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string[] list = Directory.GetFiles(folder.SelectedPath, textBox.Text, SearchOption.AllDirectories);
                listBox.Items.Clear();
                if (list.Length != 0)
                {
                    foreach (var item in list)
                    {
                        listBox.Items.Add(item);
                    }
                }
                else MessageBox.Show($"Файлы не найдены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
