namespace WindowsFormsApp1
{
    partial class checkmaterial
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.datano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "全部取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "全部选中";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(387, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "选择要审核的材料牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "输入材料牌号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 328);
            this.dataGridView1.TabIndex = 23;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(850, 114);
            this.prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(100, 32);
            this.prev.TabIndex = 22;
            this.prev.Text = "上一牌号";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(736, 114);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 32);
            this.next.TabIndex = 21;
            this.next.Text = "下一牌号";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // datano
            // 
            this.datano.Location = new System.Drawing.Point(249, 116);
            this.datano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datano.Name = "datano";
            this.datano.Size = new System.Drawing.Size(471, 25);
            this.datano.TabIndex = 20;
            this.datano.TextChanged += new System.EventHandler(this.datano_TextChanged);
            // 
            // checkmaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 659);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.datano);
            this.Name = "checkmaterial";
            this.Text = "数据审核";
            this.Load += new System.EventHandler(this.checkmaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox datano;
    }
}