﻿using MethodReturnChecker.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodReturnChecker.FormUI
{
    public partial class Form2 : Form
    {
        private readonly List<ResultModel> _resultModels;

        public Form2(List<ResultModel> resultModels)
        {
            InitializeComponent();
            _resultModels = resultModels;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void displayMatchInformation(List<ResultModel> resultModels)
        {
            dataGridView1.DataSource = _resultModels;
            label2.Text = _resultModels.Count.ToString();
            if (_resultModels.Count > 0)
            {
                splitContainer1.Panel2.BackColor = Color.IndianRed;
            }
            else
            {
                splitContainer1.Panel2.BackColor = Color.PaleGreen;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayMatchInformation(_resultModels);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
