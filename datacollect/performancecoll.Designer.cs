namespace WindowsFormsApp1
{
    partial class performancecoll
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvdcapabilityhead = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvperformance = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TESTTYPE = new System.Windows.Forms.TextBox();
            this.CONDITION = new System.Windows.Forms.TextBox();
            this.METHOD = new System.Windows.Forms.TextBox();
            this.TESTNAME = new System.Windows.Forms.TextBox();
            this.PRESULT = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdcapabilityhead)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvperformance)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "表II  材料性能数据采集表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "材料牌号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 458);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvdcapabilityhead);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "特征性指标";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvdcapabilityhead
            // 
            this.dgvdcapabilityhead.AllowUserToAddRows = false;
            this.dgvdcapabilityhead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdcapabilityhead.Location = new System.Drawing.Point(9, 2);
            this.dgvdcapabilityhead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdcapabilityhead.Name = "dgvdcapabilityhead";
            this.dgvdcapabilityhead.RowTemplate.Height = 27;
            this.dgvdcapabilityhead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdcapabilityhead.Size = new System.Drawing.Size(1145, 425);
            this.dgvdcapabilityhead.TabIndex = 1;
            this.dgvdcapabilityhead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdcapabilityhead_CellContentClick);
            this.dgvdcapabilityhead.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvdcapabilityhead_CellFormatting);
            this.dgvdcapabilityhead.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvdcapabilityhead_RowPostPaint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvperformance);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "性能指标";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvperformance
            // 
            this.dgvperformance.AllowUserToAddRows = false;
            this.dgvperformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvperformance.Location = new System.Drawing.Point(3, 6);
            this.dgvperformance.Name = "dgvperformance";
            this.dgvperformance.RowTemplate.Height = 27;
            this.dgvperformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvperformance.Size = new System.Drawing.Size(1153, 417);
            this.dgvperformance.TabIndex = 0;
            this.dgvperformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvperformance_CellContentClick);
            this.dgvperformance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvperformance_CellDoubleClick);
            this.dgvperformance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvperformance_CellFormatting);
            this.dgvperformance.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvperformance_RowPostPaint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PRESULT);
            this.tabPage3.Controls.Add(this.TESTNAME);
            this.tabPage3.Controls.Add(this.METHOD);
            this.tabPage3.Controls.Add(this.CONDITION);
            this.tabPage3.Controls.Add(this.TESTTYPE);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1162, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "考核评价";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "特殊字符";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(89, 527);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(1095, 68);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "testtesttesttesttesttesttesttesttesttesttesttesttest";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(319, 617);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 16;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(418, 617);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 17;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "增强/基体";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(625, 617);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 19;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(740, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "预览打印";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(848, 617);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "考核类别名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "考核条件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "考核方法";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "考核名称";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "考核结果";
            // 
            // TESTTYPE
            // 
            this.TESTTYPE.Location = new System.Drawing.Point(145, 14);
            this.TESTTYPE.Name = "TESTTYPE";
            this.TESTTYPE.Size = new System.Drawing.Size(352, 25);
            this.TESTTYPE.TabIndex = 5;
            // 
            // CONDITION
            // 
            this.CONDITION.Location = new System.Drawing.Point(145, 146);
            this.CONDITION.Name = "CONDITION";
            this.CONDITION.Size = new System.Drawing.Size(559, 25);
            this.CONDITION.TabIndex = 7;
            // 
            // METHOD
            // 
            this.METHOD.Location = new System.Drawing.Point(145, 100);
            this.METHOD.Name = "METHOD";
            this.METHOD.Size = new System.Drawing.Size(352, 25);
            this.METHOD.TabIndex = 8;
            // 
            // TESTNAME
            // 
            this.TESTNAME.Location = new System.Drawing.Point(145, 56);
            this.TESTNAME.Name = "TESTNAME";
            this.TESTNAME.Size = new System.Drawing.Size(352, 25);
            this.TESTNAME.TabIndex = 9;
            // 
            // PRESULT
            // 
            this.PRESULT.Location = new System.Drawing.Point(145, 201);
            this.PRESULT.Name = "PRESULT";
            this.PRESULT.Size = new System.Drawing.Size(513, 126);
            this.PRESULT.TabIndex = 10;
            this.PRESULT.Text = "";
            // 
            // performancecoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 664);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "performancecoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料性能数据采集表";
            this.Load += new System.EventHandler(this.performancecoll_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdcapabilityhead)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvperformance)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvdcapabilityhead;
        private System.Windows.Forms.DataGridView dgvperformance;
        private System.Windows.Forms.RichTextBox PRESULT;
        private System.Windows.Forms.TextBox TESTNAME;
        private System.Windows.Forms.TextBox METHOD;
        private System.Windows.Forms.TextBox CONDITION;
        private System.Windows.Forms.TextBox TESTTYPE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}