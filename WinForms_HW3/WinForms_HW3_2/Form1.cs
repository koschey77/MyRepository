using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW3_2
{
    public partial class Form1 : Form
    {
        /*2. Фирма продает составляющие компьютера. Первая
форма отвечает за учет продаж, вторая за добавление
и редактирование составляющих.
Первая форма:
Список, выпадающий список, текстовое поле, кнопка
вызова второй формы. В выпадающем списке появляются
наименования всех товаров, которые в наличии в магазине.
Пользователь выбирает товар, в текстовом окне, которое
нельзя редактировать, появляется цена. Пользователь
нажимает «добавить» и товар добавляется в список продаж.
Также должно быть окошко, которое выводит общую
стоимость.
Вторая форма:
Информация о комплектующих (наименование, характеристика,
описание и цена) вводится в текстовые поля;
в список добавляется текстовая строка, содержащая информацию
о товаре, кроме цены, цена в списке не видна, но
содержится; также комплектующие можно редактировать.*/
        public double AllPrise { get; set; } = 0;

        readonly List<Product> product = null;
        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            productStock.SelectedIndexChanged += ProductStock_SelectedIndexChanged;
            btnAddList.Click += BtnAddList_Click;
        }
        private void BtnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList.Items.Add(((Product)productStock.Items[productStock.SelectedIndex]).ToString());
                AllPrise += ((Product)productStock.Items[productStock.SelectedIndex]).Price;
                if (ProductList.Items.Count > 0)
                {
                    allPriceProductLabel2.Visible = false;
                    allPriceProductLabel.Visible = true;
                    allPriceProduct.Visible = true;
                    labelAllPriceProduct.Visible = true;
                }
                allPriceProduct.Text = AllPrise.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ProductStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceProduct.Text = ((Product)productStock.Items[productStock.SelectedIndex]).Price.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int tempNum = productStock.SelectedIndex;
                Product tempProduct = (Product)productStock.Items[tempNum];
                Form2 form2 = new Form2(false, tempProduct);
                form2.ShowDialog();
                productStock.Items.RemoveAt(tempNum);
                productStock.Items.Insert(tempNum, tempProduct);
                productStock.SelectedIndex = tempNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            product.Add(new Product());
            Form2 form2 = new Form2(true, product[product.Count - 1]);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                productStock.Items.Add(product[product.Count - 1]);
                groupBoxProduct.Text = $"Товары в наличии {productStock.Items.Count}";
            }
        }
    }
}