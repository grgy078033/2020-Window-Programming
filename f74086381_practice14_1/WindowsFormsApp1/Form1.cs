﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet3.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet3.內容簡介);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet3.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter1.Fill(this.practiceDBDataSet3.書目);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet3.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter1.Fill(this.practiceDBDataSet3.出版者);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet2.內容簡介);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet2.內容簡介);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet2.內容簡介);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet1.書目);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter1.Fill(this.practiceDBDataSet2.書目);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet2.內容簡介);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter1.Fill(this.practiceDBDataSet2.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet1.出版者);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter1.Fill(this.practiceDBDataSet2.書目);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet2.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter1.Fill(this.practiceDBDataSet2.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet1.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter1.Fill(this.practiceDBDataSet1.出版者);
            // TODO: 這行程式碼會將資料載入 'practiceDBDataSet.內容簡介' 資料表。您可以視需要進行移動或移除。
            this.內容簡介TableAdapter.Fill(this.practiceDBDataSet.內容簡介);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.書目' 資料表。您可以視需要進行移動或移除。
        }
    }
}
