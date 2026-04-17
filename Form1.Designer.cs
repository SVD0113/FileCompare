namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppName = new System.Windows.Forms.Label();
            this.txtLeftDir = new System.Windows.Forms.TextBox();
            this.btnCopyFromLeft = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwLeftDir = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLeftDir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtRightDir = new System.Windows.Forms.TextBox();
            this.btnRightDir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvwRightdir = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCopyFromRight = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAppName.ForeColor = System.Drawing.Color.Blue;
            this.lblAppName.Location = new System.Drawing.Point(9, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(278, 40);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "File Compare";
            // 
            // txtLeftDir
            // 
            this.txtLeftDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeftDir.Location = new System.Drawing.Point(13, 23);
            this.txtLeftDir.Multiline = true;
            this.txtLeftDir.Name = "txtLeftDir";
            this.txtLeftDir.Size = new System.Drawing.Size(282, 35);
            this.txtLeftDir.TabIndex = 1;
            // 
            // btnCopyFromLeft
            // 
            this.btnCopyFromLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFromLeft.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCopyFromLeft.Location = new System.Drawing.Point(317, 33);
            this.btnCopyFromLeft.Name = "btnCopyFromLeft";
            this.btnCopyFromLeft.Size = new System.Drawing.Size(75, 37);
            this.btnCopyFromLeft.TabIndex = 2;
            this.btnCopyFromLeft.Text = ">>>";
            this.btnCopyFromLeft.UseVisualStyleBackColor = true;
            this.btnCopyFromLeft.Click += new System.EventHandler(this.btnCopyToRight_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnCopyFromLeft);
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 76);
            this.panel1.TabIndex = 3;
            // 
            // lvwLeftDir
            // 
            this.lvwLeftDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLeftDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwLeftDir.HideSelection = false;
            this.lvwLeftDir.Location = new System.Drawing.Point(16, 88);
            this.lvwLeftDir.Name = "lvwLeftDir";
            this.lvwLeftDir.Size = new System.Drawing.Size(379, 316);
            this.lvwLeftDir.TabIndex = 4;
            this.lvwLeftDir.UseCompatibleStateImageBehavior = false;
            this.lvwLeftDir.View = System.Windows.Forms.View.Details;
            this.lvwLeftDir.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "크기";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수정일";
            this.columnHeader3.Width = 130;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(811, 490);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnLeftDir);
            this.panel2.Controls.Add(this.txtLeftDir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 82);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLeftDir
            // 
            this.btnLeftDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeftDir.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLeftDir.Location = new System.Drawing.Point(303, 23);
            this.btnLeftDir.Name = "btnLeftDir";
            this.btnLeftDir.Size = new System.Drawing.Size(89, 35);
            this.btnLeftDir.TabIndex = 2;
            this.btnLeftDir.Text = "폴더선택";
            this.btnLeftDir.UseVisualStyleBackColor = true;
            this.btnLeftDir.Click += new System.EventHandler(this.btnLeftDir_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.lvwLeftDir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 414);
            this.panel3.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.txtRightDir);
            this.panel6.Controls.Add(this.btnRightDir);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 82);
            this.panel6.TabIndex = 7;
            // 
            // txtRightDir
            // 
            this.txtRightDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRightDir.Location = new System.Drawing.Point(11, 24);
            this.txtRightDir.Multiline = true;
            this.txtRightDir.Name = "txtRightDir";
            this.txtRightDir.Size = new System.Drawing.Size(282, 35);
            this.txtRightDir.TabIndex = 4;
            // 
            // btnRightDir
            // 
            this.btnRightDir.AccessibleDescription = "s";
            this.btnRightDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightDir.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRightDir.Location = new System.Drawing.Point(301, 22);
            this.btnRightDir.Name = "btnRightDir";
            this.btnRightDir.Size = new System.Drawing.Size(89, 37);
            this.btnRightDir.TabIndex = 3;
            this.btnRightDir.Text = "폴더선택";
            this.btnRightDir.UseVisualStyleBackColor = true;
            this.btnRightDir.Click += new System.EventHandler(this.btnRightDir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lime;
            this.panel5.Controls.Add(this.lvwRightdir);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 414);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lvwRightdir
            // 
            this.lvwRightdir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRightdir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwRightdir.HideSelection = false;
            this.lvwRightdir.Location = new System.Drawing.Point(11, 88);
            this.lvwRightdir.Name = "lvwRightdir";
            this.lvwRightdir.Size = new System.Drawing.Size(379, 316);
            this.lvwRightdir.TabIndex = 5;
            this.lvwRightdir.UseCompatibleStateImageBehavior = false;
            this.lvwRightdir.View = System.Windows.Forms.View.Details;
            this.lvwRightdir.SelectedIndexChanged += new System.EventHandler(this.lvwRightdir_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이름";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "크기";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "수정일";
            this.columnHeader6.Width = 130;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnCopyFromRight);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 76);
            this.panel4.TabIndex = 4;
            // 
            // btnCopyFromRight
            // 
            this.btnCopyFromRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyFromRight.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCopyFromRight.Location = new System.Drawing.Point(11, 33);
            this.btnCopyFromRight.Name = "btnCopyFromRight";
            this.btnCopyFromRight.Size = new System.Drawing.Size(75, 34);
            this.btnCopyFromRight.TabIndex = 2;
            this.btnCopyFromRight.Text = "<<<";
            this.btnCopyFromRight.UseVisualStyleBackColor = true;
            this.btnCopyFromRight.Click += new System.EventHandler(this.btnCopyToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "File Compare V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TextBox txtLeftDir;
        private System.Windows.Forms.Button btnCopyFromLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwLeftDir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCopyFromRight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLeftDir;
        private System.Windows.Forms.TextBox txtRightDir;
        private System.Windows.Forms.Button btnRightDir;
        private System.Windows.Forms.ListView lvwRightdir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

