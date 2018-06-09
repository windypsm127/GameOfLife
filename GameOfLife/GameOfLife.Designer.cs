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
            this.lbl_stat = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stat
            // 
            this.lbl_stat.AutoSize = true;
            this.lbl_stat.Location = new System.Drawing.Point(402, 63);
            this.lbl_stat.Name = "lbl_stat";
            this.lbl_stat.Size = new System.Drawing.Size(53, 12);
            this.lbl_stat.TabIndex = 0;
            this.lbl_stat.Text = "lbl_stat";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(261, 224);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_stat);
            this.Name = "GameOfLife";
            this.Text = "生命游戏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stat;
        private System.Windows.Forms.Button btn_start;
    }
}

