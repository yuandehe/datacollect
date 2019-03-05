namespace WindowsFormsApp1
{
    partial class commpanymanger
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
            this.save = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.bend = new System.Windows.Forms.Button();
            this.bnext = new System.Windows.Forms.Button();
            this.bperv = new System.Windows.Forms.Button();
            this.head1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.instandno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intro = new System.Windows.Forms.RichTextBox();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.postcode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.homepage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pname1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.pcode = new System.Windows.Forms.TextBox();
            this.serachname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1121, 651);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 37;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(1121, 608);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 36;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(1121, 554);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 35;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bend
            // 
            this.bend.Location = new System.Drawing.Point(1121, 486);
            this.bend.Name = "bend";
            this.bend.Size = new System.Drawing.Size(75, 23);
            this.bend.TabIndex = 34;
            this.bend.Text = "末页";
            this.bend.UseVisualStyleBackColor = true;
            this.bend.Click += new System.EventHandler(this.bend_Click);
            // 
            // bnext
            // 
            this.bnext.Location = new System.Drawing.Point(1121, 440);
            this.bnext.Name = "bnext";
            this.bnext.Size = new System.Drawing.Size(75, 23);
            this.bnext.TabIndex = 33;
            this.bnext.Text = "下页";
            this.bnext.UseVisualStyleBackColor = true;
            this.bnext.Click += new System.EventHandler(this.bnext_Click);
            // 
            // bperv
            // 
            this.bperv.Location = new System.Drawing.Point(1121, 399);
            this.bperv.Name = "bperv";
            this.bperv.Size = new System.Drawing.Size(75, 23);
            this.bperv.TabIndex = 32;
            this.bperv.Text = "上页";
            this.bperv.UseVisualStyleBackColor = true;
            this.bperv.Click += new System.EventHandler(this.bperv_Click);
            // 
            // head1
            // 
            this.head1.Location = new System.Drawing.Point(1121, 350);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(75, 23);
            this.head1.TabIndex = 31;
            this.head1.Text = "首页";
            this.head1.UseVisualStyleBackColor = true;
            this.head1.Click += new System.EventHandler(this.head1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "单位代码";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(509, -47);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 23);
            this.next.TabIndex = 26;
            this.next.Text = "↓";
            this.next.UseVisualStyleBackColor = true;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(480, -48);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(23, 23);
            this.prev.TabIndex = 25;
            this.prev.Text = "↑";
            this.prev.UseVisualStyleBackColor = true;
            // 
            // instandno
            // 
            this.instandno.Location = new System.Drawing.Point(315, -49);
            this.instandno.Name = "instandno";
            this.instandno.Size = new System.Drawing.Size(144, 25);
            this.instandno.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, -39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "快速查询标准技术号";
            // 
            // listno
            // 
            this.listno.AutoSize = true;
            this.listno.ForeColor = System.Drawing.Color.Red;
            this.listno.Location = new System.Drawing.Point(712, 20);
            this.listno.Name = "listno";
            this.listno.Size = new System.Drawing.Size(61, 15);
            this.listno.TabIndex = 22;
            this.listno.Text = "序号0/0";
            this.listno.Click += new System.EventHandler(this.listno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "单位名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "快速查询单位信息";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.intro);
            this.panel1.Controls.Add(this.memo);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.postcode);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.homepage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.fax);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.pname1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pname);
            this.panel1.Controls.Add(this.pcode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listno);
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 688);
            this.panel1.TabIndex = 38;
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(129, 411);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(770, 96);
            this.intro.TabIndex = 55;
            this.intro.Text = "";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(129, 528);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(770, 96);
            this.memo.TabIndex = 54;
            this.memo.Text = "";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(141, 138);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(756, 25);
            this.address.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(46, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 52;
            this.label17.Text = "通讯地址";
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(141, 185);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(756, 25);
            this.postcode.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 50;
            this.label16.Text = "联系电话";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(141, 235);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(756, 25);
            this.tel.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "邮政编码:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // homepage
            // 
            this.homepage.Location = new System.Drawing.Point(134, 279);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(756, 25);
            this.homepage.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "网站地址";
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(134, 380);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(756, 25);
            this.fax.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(76, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 42;
            this.label18.Text = "传真";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(134, 328);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(756, 25);
            this.email.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "E-mail地址";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "备注";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-28, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "专业专长及 主要产品";
            // 
            // pname1
            // 
            this.pname1.Location = new System.Drawing.Point(141, 98);
            this.pname1.Name = "pname1";
            this.pname1.Size = new System.Drawing.Size(756, 25);
            this.pname1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "第二厂（所）名";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(141, 53);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(756, 25);
            this.pname.TabIndex = 31;
            // 
            // pcode
            // 
            this.pcode.Location = new System.Drawing.Point(141, 14);
            this.pcode.Name = "pcode";
            this.pcode.Size = new System.Drawing.Size(302, 25);
            this.pcode.TabIndex = 30;
            // 
            // serachname
            // 
            this.serachname.Location = new System.Drawing.Point(167, 11);
            this.serachname.Name = "serachname";
            this.serachname.Size = new System.Drawing.Size(281, 25);
            this.serachname.TabIndex = 39;
            this.serachname.TextChanged += new System.EventHandler(this.serachname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // commpanymanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 759);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serachname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bend);
            this.Controls.Add(this.bnext);
            this.Controls.Add(this.bperv);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.instandno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "commpanymanger";
            this.Text = "单位信息";
            this.Load += new System.EventHandler(this.commpanymanger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button bend;
        private System.Windows.Forms.Button bnext;
        private System.Windows.Forms.Button bperv;
        private System.Windows.Forms.Button head1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.TextBox instandno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label listno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox serachname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox intro;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox homepage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pname1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox pcode;
    }
}