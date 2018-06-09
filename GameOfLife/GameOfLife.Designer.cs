namespace GameOfLife
{
    partial class GameOfLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLife));
            this.btn_start = new System.Windows.Forms.Button();
            this.pbx_stat = new System.Windows.Forms.PictureBox();
            this.txt_tm = new System.Windows.Forms.TextBox();
            this.lbl_refresh = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_stat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_start.Location = new System.Drawing.Point(767, 188);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 33);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pbx_stat
            // 
            this.pbx_stat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbx_stat.Location = new System.Drawing.Point(12, 31);
            this.pbx_stat.Name = "pbx_stat";
            this.pbx_stat.Size = new System.Drawing.Size(550, 550);
            this.pbx_stat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_stat.TabIndex = 2;
            this.pbx_stat.TabStop = false;
            this.pbx_stat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_stat_MouseClick);
            // 
            // txt_tm
            // 
            this.txt_tm.Location = new System.Drawing.Point(767, 343);
            this.txt_tm.Name = "txt_tm";
            this.txt_tm.Size = new System.Drawing.Size(68, 21);
            this.txt_tm.TabIndex = 3;
            this.txt_tm.Text = "1";
            this.txt_tm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tm_KeyDown);
            // 
            // lbl_refresh
            // 
            this.lbl_refresh.AutoSize = true;
            this.lbl_refresh.Location = new System.Drawing.Point(752, 328);
            this.lbl_refresh.Name = "lbl_refresh";
            this.lbl_refresh.Size = new System.Drawing.Size(101, 12);
            this.lbl_refresh.TabIndex = 4;
            this.lbl_refresh.Text = "Refresh Time(ms)";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_reset.Location = new System.Drawing.Point(767, 258);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 33);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(767, 411);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(68, 21);
            this.txt_num.TabIndex = 6;
            this.txt_num.Text = "10";
            this.txt_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_num_KeyDown);
            // 
            // lbl_num
            // 
            this.lbl_num.Location = new System.Drawing.Point(734, 396);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(147, 12);
            this.lbl_num.TabIndex = 4;
            this.lbl_num.Text = "Number of Rows(Columns)";
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(951, 611);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_refresh);
            this.Controls.Add(this.txt_tm);
            this.Controls.Add(this.pbx_stat);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOfLife";
            this.Text = "GameOfLife";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOfLife_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_stat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pbx_stat;
        private System.Windows.Forms.TextBox txt_tm;
        private System.Windows.Forms.Label lbl_refresh;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
    }
}

