namespace WindowsFormsApp1
{
    partial class performance
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 646);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 648);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 432);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(423, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "共有未审核牌号";
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(947, 91);
            this.prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(100, 32);
            this.prev.TabIndex = 16;
            this.prev.Text = "上一牌号";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(811, 91);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 32);
            this.next.TabIndex = 15;
            this.next.Text = "下一牌号";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(97, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "输入材料牌号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datano
            // 
            this.datano.Location = new System.Drawing.Point(315, 91);
            this.datano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datano.Name = "datano";
            this.datano.Size = new System.Drawing.Size(471, 25);
            this.datano.TabIndex = 13;
            this.datano.TextChanged += new System.EventHandler(this.datano_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(559, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "选择材料牌号";
            // 
            // performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 714);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datano);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料性能数据采集";
            this.Load += new System.EventHandler(this.performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datano;
        private System.Windows.Forms.Label label1;
    }
}