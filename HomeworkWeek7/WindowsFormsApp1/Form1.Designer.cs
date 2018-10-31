namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nextCilentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextorderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nextGoodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextGoodNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextGoodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextorderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nextCilentNameDataGridViewTextBoxColumn,
            this.nextOrderIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(342, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nextCilentNameDataGridViewTextBoxColumn
            // 
            this.nextCilentNameDataGridViewTextBoxColumn.DataPropertyName = "NextCilentName";
            this.nextCilentNameDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.nextCilentNameDataGridViewTextBoxColumn.Name = "nextCilentNameDataGridViewTextBoxColumn";
            this.nextCilentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextOrderIDDataGridViewTextBoxColumn
            // 
            this.nextOrderIDDataGridViewTextBoxColumn.DataPropertyName = "NextOrderID";
            this.nextOrderIDDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.nextOrderIDDataGridViewTextBoxColumn.Name = "nextOrderIDDataGridViewTextBoxColumn";
            this.nextOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(GreatOrder.Order);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "客户名查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // nextorderDetailsBindingSource
            // 
            this.nextorderDetailsBindingSource.DataMember = "NextorderDetails";
            this.nextorderDetailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nextGoodNameDataGridViewTextBoxColumn,
            this.nextGoodNumberDataGridViewTextBoxColumn,
            this.nextGoodpriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nextorderDetailsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(395, 318);
            this.dataGridView2.TabIndex = 3;
            // 
            // nextGoodNameDataGridViewTextBoxColumn
            // 
            this.nextGoodNameDataGridViewTextBoxColumn.DataPropertyName = "NextGoodName";
            this.nextGoodNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nextGoodNameDataGridViewTextBoxColumn.Name = "nextGoodNameDataGridViewTextBoxColumn";
            this.nextGoodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextGoodNumberDataGridViewTextBoxColumn
            // 
            this.nextGoodNumberDataGridViewTextBoxColumn.DataPropertyName = "NextGoodNumber";
            this.nextGoodNumberDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.nextGoodNumberDataGridViewTextBoxColumn.Name = "nextGoodNumberDataGridViewTextBoxColumn";
            this.nextGoodNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextGoodpriceDataGridViewTextBoxColumn
            // 
            this.nextGoodpriceDataGridViewTextBoxColumn.DataPropertyName = "NextGoodprice";
            this.nextGoodpriceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.nextGoodpriceDataGridViewTextBoxColumn.Name = "nextGoodpriceDataGridViewTextBoxColumn";
            this.nextGoodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(221, 187);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(8, 8);
            this.dataGridView3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextorderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource nextorderDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextCilentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

