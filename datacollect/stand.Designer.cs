namespace WindowsFormsApp1
{
    partial class stand
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
            this.no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.instandno = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.standardtext = new System.Windows.Forms.RichTextBox();
            this.standardmemo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.head1 = new System.Windows.Forms.Button();
            this.bperv = new System.Windows.Forms.Button();
            this.bnext = new System.Windows.Forms.Button();
            this.bend = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.standardname = new System.Windows.Forms.TextBox();
            this.standardno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "标准/技术文件号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "标准名称";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.ForeColor = System.Drawing.Color.Red;
            this.no.Location = new System.Drawing.Point(661, 61);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(61, 15);
            this.no.TabIndex = 2;
            this.no.Text = "序号0/0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "快速查询标准技术号";
            // 
            // instandno
            // 
            this.instandno.Location = new System.Drawing.Point(307, 3);
            this.instandno.Name = "instandno";
            this.instandno.Size = new System.Drawing.Size(144, 25);
            this.instandno.TabIndex = 4;
            this.instandno.TextChanged += new System.EventHandler(this.instandno_TextChanged);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(472, 4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(23, 23);
            this.prev.TabIndex = 5;
            this.prev.Text = "↑";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(501, 5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 23);
            this.next.TabIndex = 6;
            this.next.Text = "↓";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // standardtext
            // 
            this.standardtext.Location = new System.Drawing.Point(94, 109);
            this.standardtext.Name = "standardtext";
            this.standardtext.Size = new System.Drawing.Size(755, 342);
            this.standardtext.TabIndex = 7;
            this.standardtext.Text = "";
            // 
            // standardmemo
            // 
            this.standardmemo.Location = new System.Drawing.Point(94, 498);
            this.standardmemo.Name = "standardmemo";
            this.standardmemo.Size = new System.Drawing.Size(755, 121);
            this.standardmemo.TabIndex = 8;
            this.standardmemo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "标准全文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "备注";
            // 
            // head1
            // 
            this.head1.Location = new System.Drawing.Point(879, 108);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(75, 23);
            this.head1.TabIndex = 11;
            this.head1.Text = "首页";
            this.head1.UseVisualStyleBackColor = true;
            this.head1.Click += new System.EventHandler(this.head1_Click);
            // 
            // bperv
            // 
            this.bperv.Location = new System.Drawing.Point(879, 157);
            this.bperv.Name = "bperv";
            this.bperv.Size = new System.Drawing.Size(75, 23);
            this.bperv.TabIndex = 12;
            this.bperv.Text = "上页";
            this.bperv.UseVisualStyleBackColor = true;
            this.bperv.Click += new System.EventHandler(this.bperv_Click);
            // 
            // bnext
            // 
            this.bnext.Location = new System.Drawing.Point(879, 198);
            this.bnext.Name = "bnext";
            this.bnext.Size = new System.Drawing.Size(75, 23);
            this.bnext.TabIndex = 13;
            this.bnext.Text = "下页";
            this.bnext.UseVisualStyleBackColor = true;
            this.bnext.Click += new System.EventHandler(this.bnext_Click);
            // 
            // bend
            // 
            this.bend.Location = new System.Drawing.Point(879, 244);
            this.bend.Name = "bend";
            this.bend.Size = new System.Drawing.Size(75, 23);
            this.bend.TabIndex = 14;
            this.bend.Text = "末页";
            this.bend.UseVisualStyleBackColor = true;
            this.bend.Click += new System.EventHandler(this.bend_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(879, 312);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 15;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(879, 366);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 16;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(879, 409);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 17;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // standardname
            // 
            this.standardname.Location = new System.Drawing.Point(435, 56);
            this.standardname.Name = "standardname";
            this.standardname.Size = new System.Drawing.Size(220, 25);
            this.standardname.TabIndex = 18;
            // 
            // standardno
            // 
            this.standardno.Location = new System.Drawing.Point(139, 56);
            this.standardno.Name = "standardno";
            this.standardno.Size = new System.Drawing.Size(217, 25);
            this.standardno.TabIndex = 19;
            // 
            // stand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 648);
            this.Controls.Add(this.standardno);
            this.Controls.Add(this.standardname);
            this.Controls.Add(this.save);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bend);
            this.Controls.Add(this.bnext);
            this.Controls.Add(this.bperv);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.standardmemo);
            this.Controls.Add(this.standardtext);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.instandno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "stand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "技术标准信息";
            this.Load += new System.EventHandler(this.stand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox instandno;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RichTextBox standardtext;
        private System.Windows.Forms.RichTextBox standardmemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button head1;
        private System.Windows.Forms.Button bperv;
        private System.Windows.Forms.Button bnext;
        private System.Windows.Forms.Button bend;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox standardname;
        private System.Windows.Forms.TextBox standardno;
    }
}