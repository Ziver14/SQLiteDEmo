﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDEmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbOutput.Text = DBWork.MakeDB();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category _category = new Category(tbInputNewCategory.Text);
            string insert_query = _category.AddCategory();
            DBWork.AddData(insert_query);
            tbInputNewCategory.Text = string.Empty;
        }

        private void btnRefreshDG_Click(object sender, EventArgs e)
        {
            dgCategory.DataSource = DBWork.Refresh().Tables[0];
            dgCategory.Update();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _query = string.Empty;
            DataTable dt = (DataTable)dgCategory.DataSource;
            DBWork.Save(dt,out _query);
            tbQuery.Text = _query;
        }
    }
}
