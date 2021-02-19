﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW3_1
{
    public partial class Form1 : Form
    {
        /*1. Разработайте программу, которая позволяет пользователю
осуществлять поиск файлов по заданному критерию.
Приложение состоит из двух форм — главное окно
и окно поиска. Пользователь может открыть сколько
угодно окон поиска. Окно поиска запускается немодально.
В окне поиска пользователь выбирает папку, в которой
будет идти поиск и вводит маску поиска, например «*.doc».
Найденные файлы отображаются в списке.*/

        public Form1()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnClose.Click += BtnClose_Click;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
