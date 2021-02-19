
namespace WinForms_HW3_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.allPriceProductLabel = new System.Windows.Forms.Label();
            this.allPriceProductLabel2 = new System.Windows.Forms.Label();
            this.labelAllPriceProduct = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.productStock = new System.Windows.Forms.ComboBox();
            this.allPriceProduct = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 16;
            this.ProductList.Location = new System.Drawing.Point(12, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(361, 388);
            this.ProductList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с товарами";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // allPriceProductLabel
            // 
            this.allPriceProductLabel.AutoSize = true;
            this.allPriceProductLabel.Location = new System.Drawing.Point(398, 13);
            this.allPriceProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allPriceProductLabel.Name = "allPriceProductLabel";
            this.allPriceProductLabel.Size = new System.Drawing.Size(160, 17);
            this.allPriceProductLabel.TabIndex = 2;
            this.allPriceProductLabel.Text = "Цена товаров в списке";
            this.allPriceProductLabel.Visible = false;
            // 
            // allPriceProductLabel2
            // 
            this.allPriceProductLabel2.AutoSize = true;
            this.allPriceProductLabel2.Location = new System.Drawing.Point(398, 51);
            this.allPriceProductLabel2.Name = "allPriceProductLabel2";
            this.allPriceProductLabel2.Size = new System.Drawing.Size(145, 17);
            this.allPriceProductLabel2.TabIndex = 3;
            this.allPriceProductLabel2.Text = "Список товаров пуст";
            // 
            // labelAllPriceProduct
            // 
            this.labelAllPriceProduct.AutoSize = true;
            this.labelAllPriceProduct.Location = new System.Drawing.Point(572, 34);
            this.labelAllPriceProduct.Name = "labelAllPriceProduct";
            this.labelAllPriceProduct.Size = new System.Drawing.Size(33, 17);
            this.labelAllPriceProduct.TabIndex = 4;
            this.labelAllPriceProduct.Text = "грн.";
            this.labelAllPriceProduct.Visible = false;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.btnAddList);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Controls.Add(this.priceProduct);
            this.groupBoxProduct.Controls.Add(this.productStock);
            this.groupBoxProduct.Location = new System.Drawing.Point(401, 154);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(200, 246);
            this.groupBoxProduct.TabIndex = 5;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Товары";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(7, 180);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(187, 37);
            this.btnAddList.TabIndex = 3;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "грн.";
            // 
            // priceProduct
            // 
            this.priceProduct.Location = new System.Drawing.Point(6, 113);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(149, 22);
            this.priceProduct.TabIndex = 1;
            this.priceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productStock
            // 
            this.productStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStock.FormattingEnabled = true;
            this.productStock.Location = new System.Drawing.Point(6, 43);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(188, 24);
            this.productStock.TabIndex = 0;
            // 
            // allPriceProduct
            // 
            this.allPriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPriceProduct.Location = new System.Drawing.Point(459, 34);
            this.allPriceProduct.Name = "allPriceProduct";
            this.allPriceProduct.ReadOnly = true;
            this.allPriceProduct.Size = new System.Drawing.Size(152, 15);
            this.allPriceProduct.TabIndex = 8;
            this.allPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allPriceProduct.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 535);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.labelAllPriceProduct);
            this.Controls.Add(this.allPriceProductLabel2);
            this.Controls.Add(this.allPriceProductLabel);
            this.Controls.Add(this.allPriceProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.Text = "Учет продаж";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label allPriceProductLabel;
        private System.Windows.Forms.Label allPriceProductLabel2;
        private System.Windows.Forms.Label labelAllPriceProduct;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.ComboBox productStock;
        private System.Windows.Forms.TextBox allPriceProduct;
    }
}

