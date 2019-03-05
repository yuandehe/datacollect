namespace WindowsFormsApp1
{
    partial class materialmanger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.datano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(376, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增/编辑材料牌号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datano
            // 
            this.datano.Location = new System.Drawing.Point(195, 54);
            this.datano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datano.Name = "datano";
            this.datano.Size = new System.Drawing.Size(471, 25);
            this.datano.TabIndex = 1;
            this.datano.TextChanged += new System.EventHandler(this.datano_TextChanged);
            this.datano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datano_KeyPress);
            this.datano.Leave += new System.EventHandler(this.datano_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入新的材料牌号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "输入材料牌号:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(195, 106);
            this.searchtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(265, 25);
            this.searchtext.TabIndex = 5;
            this.searchtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(509, 108);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 32);
            this.next.TabIndex = 6;
            this.next.Text = "下一牌号";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(652, 108);
            this.prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(100, 32);
            this.prev.TabIndex = 7;
            this.prev.Text = "上一牌号";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(250, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "共有未审核牌号";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 319);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 529);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(9, 571);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(1020, 93);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "testtesttesttesttesttesttesttesttesttesttesttesttest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "特殊字符";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // materialmanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datano);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "materialmanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据编辑";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}