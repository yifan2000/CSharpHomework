﻿namespace WindowsFormsApp1
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
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextorderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nextGoodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextGoodNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextGoodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.nextCilentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextCilentTelephoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextorderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nextCilentNameDataGridViewTextBoxColumn,
            this.nextOrderIDDataGridViewTextBoxColumn,
            this.NextCilentTelephoneNumber});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(484, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(24, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "根据订单号删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "增添";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(393, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 25);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(451, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 25);
            this.textBox4.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(631, 15);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 25);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(681, 15);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(45, 25);
            this.textBox7.TabIndex = 12;
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
            this.dataGridView2.Location = new System.Drawing.Point(513, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(468, 318);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 7F);
            this.button4.Location = new System.Drawing.Point(306, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 33);
            this.button4.TabIndex = 14;
            this.button4.Text = "按id修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(393, 54);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 25);
            this.textBox8.TabIndex = 15;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(579, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(46, 25);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(502, 15);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(71, 25);
            this.textBox9.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 30);
            this.button5.TabIndex = 17;
            this.button5.Text = "打印订单";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // NextCilentTelephoneNumber
            // 
            this.NextCilentTelephoneNumber.DataPropertyName = "NextCilentTelephoneNumber";
            this.NextCilentTelephoneNumber.HeaderText = "联系方式";
            this.NextCilentTelephoneNumber.Name = "NextCilentTelephoneNumber";
            this.NextCilentTelephoneNumber.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextorderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource nextorderDetailsBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextGoodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextCilentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextCilentTelephoneNumber;
    }
}

