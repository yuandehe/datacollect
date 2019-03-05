namespace WindowsFormsApp1
{
    partial class mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.主菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表2材料性能数据采集表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表3单位信息采集表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术标准信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.牌号基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.性能条目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料体系ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据上报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改账户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主菜单ToolStripMenuItem,
            this.导入数据ToolStripMenuItem,
            this.数据删除ToolStripMenuItem,
            this.数据审核ToolStripMenuItem,
            this.取消审核ToolStripMenuItem,
            this.数据上报ToolStripMenuItem,
            this.数据导出ToolStripMenuItem,
            this.系统维护ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1320, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 主菜单ToolStripMenuItem
            // 
            this.主菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.表2材料性能数据采集表ToolStripMenuItem,
            this.表3单位信息采集表ToolStripMenuItem,
            this.技术标准信息ToolStripMenuItem,
            this.人员信息ToolStripMenuItem});
            this.主菜单ToolStripMenuItem.Name = "主菜单ToolStripMenuItem";
            this.主菜单ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.主菜单ToolStripMenuItem.Text = "数据采集";
            this.主菜单ToolStripMenuItem.Click += new System.EventHandler(this.主菜单ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.退出ToolStripMenuItem.Text = "表1 材料基本数据采集表";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 表2材料性能数据采集表ToolStripMenuItem
            // 
            this.表2材料性能数据采集表ToolStripMenuItem.Name = "表2材料性能数据采集表ToolStripMenuItem";
            this.表2材料性能数据采集表ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.表2材料性能数据采集表ToolStripMenuItem.Text = "表2 材料性能数据采集表";
            this.表2材料性能数据采集表ToolStripMenuItem.Click += new System.EventHandler(this.表2材料性能数据采集表ToolStripMenuItem_Click);
            // 
            // 表3单位信息采集表ToolStripMenuItem
            // 
            this.表3单位信息采集表ToolStripMenuItem.Name = "表3单位信息采集表ToolStripMenuItem";
            this.表3单位信息采集表ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.表3单位信息采集表ToolStripMenuItem.Text = "表3 单位信息采集表";
            this.表3单位信息采集表ToolStripMenuItem.Click += new System.EventHandler(this.表3单位信息采集表ToolStripMenuItem_Click);
            // 
            // 技术标准信息ToolStripMenuItem
            // 
            this.技术标准信息ToolStripMenuItem.Name = "技术标准信息ToolStripMenuItem";
            this.技术标准信息ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.技术标准信息ToolStripMenuItem.Text = "技术标准信息";
            this.技术标准信息ToolStripMenuItem.Click += new System.EventHandler(this.技术标准信息ToolStripMenuItem_Click);
            // 
            // 人员信息ToolStripMenuItem
            // 
            this.人员信息ToolStripMenuItem.Name = "人员信息ToolStripMenuItem";
            this.人员信息ToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.人员信息ToolStripMenuItem.Text = "人员信息";
            this.人员信息ToolStripMenuItem.Click += new System.EventHandler(this.人员信息ToolStripMenuItem_Click);
            // 
            // 导入数据ToolStripMenuItem
            // 
            this.导入数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.牌号基础信息ToolStripMenuItem,
            this.性能条目ToolStripMenuItem,
            this.材料体系ToolStripMenuItem,
            this.数据维护ToolStripMenuItem});
            this.导入数据ToolStripMenuItem.Name = "导入数据ToolStripMenuItem";
            this.导入数据ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.导入数据ToolStripMenuItem.Text = "基础数据管理";
            this.导入数据ToolStripMenuItem.Click += new System.EventHandler(this.导入数据ToolStripMenuItem_Click);
            // 
            // 牌号基础信息ToolStripMenuItem
            // 
            this.牌号基础信息ToolStripMenuItem.Name = "牌号基础信息ToolStripMenuItem";
            this.牌号基础信息ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.牌号基础信息ToolStripMenuItem.Text = "导入牌号基础信息";
            this.牌号基础信息ToolStripMenuItem.Click += new System.EventHandler(this.牌号基础信息ToolStripMenuItem_Click);
            // 
            // 性能条目ToolStripMenuItem
            // 
            this.性能条目ToolStripMenuItem.Name = "性能条目ToolStripMenuItem";
            this.性能条目ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.性能条目ToolStripMenuItem.Text = "导入性能条目";
            this.性能条目ToolStripMenuItem.Click += new System.EventHandler(this.性能条目ToolStripMenuItem_Click);
            // 
            // 材料体系ToolStripMenuItem
            // 
            this.材料体系ToolStripMenuItem.Name = "材料体系ToolStripMenuItem";
            this.材料体系ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.材料体系ToolStripMenuItem.Text = "导入材料体系";
            this.材料体系ToolStripMenuItem.Click += new System.EventHandler(this.材料体系ToolStripMenuItem_Click);
            // 
            // 数据维护ToolStripMenuItem
            // 
            this.数据维护ToolStripMenuItem.Name = "数据维护ToolStripMenuItem";
            this.数据维护ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.数据维护ToolStripMenuItem.Text = "数据维护";
            this.数据维护ToolStripMenuItem.Click += new System.EventHandler(this.数据维护ToolStripMenuItem_Click);
            // 
            // 数据删除ToolStripMenuItem
            // 
            this.数据删除ToolStripMenuItem.Name = "数据删除ToolStripMenuItem";
            this.数据删除ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据删除ToolStripMenuItem.Text = "数据删除";
            this.数据删除ToolStripMenuItem.Click += new System.EventHandler(this.数据删除ToolStripMenuItem_Click);
            // 
            // 数据审核ToolStripMenuItem
            // 
            this.数据审核ToolStripMenuItem.Name = "数据审核ToolStripMenuItem";
            this.数据审核ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据审核ToolStripMenuItem.Text = "数据审核";
            this.数据审核ToolStripMenuItem.Click += new System.EventHandler(this.数据审核ToolStripMenuItem_Click);
            // 
            // 取消审核ToolStripMenuItem
            // 
            this.取消审核ToolStripMenuItem.Name = "取消审核ToolStripMenuItem";
            this.取消审核ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.取消审核ToolStripMenuItem.Text = "取消审核";
            this.取消审核ToolStripMenuItem.Click += new System.EventHandler(this.取消审核ToolStripMenuItem_Click);
            // 
            // 数据上报ToolStripMenuItem
            // 
            this.数据上报ToolStripMenuItem.Name = "数据上报ToolStripMenuItem";
            this.数据上报ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据上报ToolStripMenuItem.Text = "数据上报";
            this.数据上报ToolStripMenuItem.Click += new System.EventHandler(this.数据上报ToolStripMenuItem_Click);
            // 
            // 数据导出ToolStripMenuItem
            // 
            this.数据导出ToolStripMenuItem.Name = "数据导出ToolStripMenuItem";
            this.数据导出ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据导出ToolStripMenuItem.Text = "数据导出";
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据备份ToolStripMenuItem,
            this.数据恢复ToolStripMenuItem,
            this.修改账户信息ToolStripMenuItem,
            this.修改口令ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 数据备份ToolStripMenuItem
            // 
            this.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem";
            this.数据备份ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.数据备份ToolStripMenuItem.Text = "数据备份";
            // 
            // 数据恢复ToolStripMenuItem
            // 
            this.数据恢复ToolStripMenuItem.Name = "数据恢复ToolStripMenuItem";
            this.数据恢复ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.数据恢复ToolStripMenuItem.Text = "数据恢复";
            // 
            // 修改账户信息ToolStripMenuItem
            // 
            this.修改账户信息ToolStripMenuItem.Name = "修改账户信息ToolStripMenuItem";
            this.修改账户信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.修改账户信息ToolStripMenuItem.Text = "修改账户信息";
            // 
            // 修改口令ToolStripMenuItem
            // 
            this.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem";
            this.修改口令ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.修改口令ToolStripMenuItem.Text = "修改口令";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1320, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(189, 20);
            this.status.Text = " 信息提示                             ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 78);
            this.panel1.TabIndex = 5;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainform";
            this.Text = "武器装备基本材料体系数据库采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 牌号基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 性能条目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料体系ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表2材料性能数据采集表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表3单位信息采集表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术标准信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据上报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改账户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据删除ToolStripMenuItem;
    }
}

