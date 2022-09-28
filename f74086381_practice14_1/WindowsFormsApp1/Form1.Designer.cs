namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.出版者TableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.出版者TableAdapter();
            this.書目TableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.書目TableAdapter();
            this.practiceDBDataSet = new WindowsFormsApp1.practiceDBDataSet();
            this.內容簡介TableAdapter = new WindowsFormsApp1.practiceDBDataSetTableAdapters.內容簡介TableAdapter();
            this.practiceDBDataSet1 = new WindowsFormsApp1.practiceDBDataSet();
            this.出版者TableAdapter1 = new WindowsFormsApp1.practiceDBDataSetTableAdapters.出版者TableAdapter();
            this.practiceDBDataSet2 = new WindowsFormsApp1.practiceDBDataSet();
            this.書目TableAdapter1 = new WindowsFormsApp1.practiceDBDataSetTableAdapters.書目TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.practiceDBDataSet3 = new WindowsFormsApp1.practiceDBDataSet();
            this.出版者BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版商位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書目出版者BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.定價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書商編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.內容簡介書目BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書名DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.來源DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.簡介DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書目出版者BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.內容簡介書目BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 出版者TableAdapter
            // 
            this.出版者TableAdapter.ClearBeforeFill = true;
            // 
            // 書目TableAdapter
            // 
            this.書目TableAdapter.ClearBeforeFill = true;
            // 
            // practiceDBDataSet
            // 
            this.practiceDBDataSet.DataSetName = "practiceDBDataSet";
            this.practiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 內容簡介TableAdapter
            // 
            this.內容簡介TableAdapter.ClearBeforeFill = true;
            // 
            // practiceDBDataSet1
            // 
            this.practiceDBDataSet1.DataSetName = "practiceDBDataSet";
            this.practiceDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 出版者TableAdapter1
            // 
            this.出版者TableAdapter1.ClearBeforeFill = true;
            // 
            // practiceDBDataSet2
            // 
            this.practiceDBDataSet2.DataSetName = "practiceDBDataSet";
            this.practiceDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 書目TableAdapter1
            // 
            this.書目TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.出版商DataGridViewTextBoxColumn,
            this.出版商位置DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.出版者BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(140, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(602, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書號DataGridViewTextBoxColumn,
            this.書名DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.定價DataGridViewTextBoxColumn,
            this.書商編號DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.書目出版者BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(140, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(602, 149);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書名DataGridViewTextBoxColumn1,
            this.作者DataGridViewTextBoxColumn1,
            this.來源DataGridViewTextBoxColumn,
            this.簡介DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.內容簡介書目BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(140, 321);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(602, 133);
            this.dataGridView3.TabIndex = 4;
            // 
            // practiceDBDataSet3
            // 
            this.practiceDBDataSet3.DataSetName = "practiceDBDataSet";
            this.practiceDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 出版者BindingSource
            // 
            this.出版者BindingSource.DataMember = "出版者";
            this.出版者BindingSource.DataSource = this.practiceDBDataSet3;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 出版商DataGridViewTextBoxColumn
            // 
            this.出版商DataGridViewTextBoxColumn.DataPropertyName = "出版商";
            this.出版商DataGridViewTextBoxColumn.HeaderText = "出版商";
            this.出版商DataGridViewTextBoxColumn.Name = "出版商DataGridViewTextBoxColumn";
            // 
            // 出版商位置DataGridViewTextBoxColumn
            // 
            this.出版商位置DataGridViewTextBoxColumn.DataPropertyName = "出版商位置";
            this.出版商位置DataGridViewTextBoxColumn.HeaderText = "出版商位置";
            this.出版商位置DataGridViewTextBoxColumn.Name = "出版商位置DataGridViewTextBoxColumn";
            // 
            // 書目出版者BindingSource
            // 
            this.書目出版者BindingSource.DataMember = "書目_出版者";
            this.書目出版者BindingSource.DataSource = this.出版者BindingSource;
            // 
            // 書號DataGridViewTextBoxColumn
            // 
            this.書號DataGridViewTextBoxColumn.DataPropertyName = "書號";
            this.書號DataGridViewTextBoxColumn.HeaderText = "書號";
            this.書號DataGridViewTextBoxColumn.Name = "書號DataGridViewTextBoxColumn";
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            // 
            // 定價DataGridViewTextBoxColumn
            // 
            this.定價DataGridViewTextBoxColumn.DataPropertyName = "定價";
            this.定價DataGridViewTextBoxColumn.HeaderText = "定價";
            this.定價DataGridViewTextBoxColumn.Name = "定價DataGridViewTextBoxColumn";
            // 
            // 書商編號DataGridViewTextBoxColumn
            // 
            this.書商編號DataGridViewTextBoxColumn.DataPropertyName = "書商編號";
            this.書商編號DataGridViewTextBoxColumn.HeaderText = "書商編號";
            this.書商編號DataGridViewTextBoxColumn.Name = "書商編號DataGridViewTextBoxColumn";
            // 
            // 內容簡介書目BindingSource
            // 
            this.內容簡介書目BindingSource.DataMember = "內容簡介_書目";
            this.內容簡介書目BindingSource.DataSource = this.書目出版者BindingSource;
            // 
            // 書名DataGridViewTextBoxColumn1
            // 
            this.書名DataGridViewTextBoxColumn1.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn1.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn1.Name = "書名DataGridViewTextBoxColumn1";
            // 
            // 作者DataGridViewTextBoxColumn1
            // 
            this.作者DataGridViewTextBoxColumn1.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn1.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn1.Name = "作者DataGridViewTextBoxColumn1";
            // 
            // 來源DataGridViewTextBoxColumn
            // 
            this.來源DataGridViewTextBoxColumn.DataPropertyName = "來源";
            this.來源DataGridViewTextBoxColumn.HeaderText = "來源";
            this.來源DataGridViewTextBoxColumn.Name = "來源DataGridViewTextBoxColumn";
            // 
            // 簡介DataGridViewTextBoxColumn
            // 
            this.簡介DataGridViewTextBoxColumn.DataPropertyName = "簡介";
            this.簡介DataGridViewTextBoxColumn.HeaderText = "簡介";
            this.簡介DataGridViewTextBoxColumn.Name = "簡介DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書目出版者BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.內容簡介書目BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.出版者TableAdapter 出版者TableAdapter;
        private Database1DataSetTableAdapters.書目TableAdapter 書目TableAdapter;
        private practiceDBDataSet practiceDBDataSet;
        private practiceDBDataSetTableAdapters.內容簡介TableAdapter 內容簡介TableAdapter;
        private practiceDBDataSet practiceDBDataSet1;
        private practiceDBDataSetTableAdapters.出版者TableAdapter 出版者TableAdapter1;
        private practiceDBDataSet practiceDBDataSet2;
        private practiceDBDataSetTableAdapters.書目TableAdapter 書目TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private practiceDBDataSet practiceDBDataSet3;
        private System.Windows.Forms.BindingSource 出版者BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版商DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版商位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 書目出版者BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 定價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書商編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 內容簡介書目BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 來源DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 簡介DataGridViewTextBoxColumn;
    }
}

