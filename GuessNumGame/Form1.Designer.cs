
namespace GuessNumGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed6 = new System.Windows.Forms.Label();
            this.lblRed5 = new System.Windows.Forms.Label();
            this.lblRed4 = new System.Windows.Forms.Label();
            this.lblRed3 = new System.Windows.Forms.Label();
            this.lblRed2 = new System.Windows.Forms.Label();
            this.lblRed1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblBlue);
            this.panel1.Controls.Add(this.lblRed6);
            this.panel1.Controls.Add(this.lblRed5);
            this.panel1.Controls.Add(this.lblRed4);
            this.panel1.Controls.Add(this.lblRed3);
            this.panel1.Controls.Add(this.lblRed2);
            this.panel1.Controls.Add(this.lblRed1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 451);
            this.panel1.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Lavender;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(569, 259);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 53);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lavender;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(103, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(633, 145);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(52, 44);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "00";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed6
            // 
            this.lblRed6.ForeColor = System.Drawing.Color.Red;
            this.lblRed6.Location = new System.Drawing.Point(477, 145);
            this.lblRed6.Name = "lblRed6";
            this.lblRed6.Size = new System.Drawing.Size(52, 44);
            this.lblRed6.TabIndex = 0;
            this.lblRed6.Text = "00";
            this.lblRed6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed5
            // 
            this.lblRed5.ForeColor = System.Drawing.Color.Red;
            this.lblRed5.Location = new System.Drawing.Point(401, 145);
            this.lblRed5.Name = "lblRed5";
            this.lblRed5.Size = new System.Drawing.Size(52, 44);
            this.lblRed5.TabIndex = 0;
            this.lblRed5.Text = "00";
            this.lblRed5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed4
            // 
            this.lblRed4.ForeColor = System.Drawing.Color.Red;
            this.lblRed4.Location = new System.Drawing.Point(325, 145);
            this.lblRed4.Name = "lblRed4";
            this.lblRed4.Size = new System.Drawing.Size(52, 44);
            this.lblRed4.TabIndex = 0;
            this.lblRed4.Text = "00";
            this.lblRed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed3
            // 
            this.lblRed3.ForeColor = System.Drawing.Color.Red;
            this.lblRed3.Location = new System.Drawing.Point(249, 145);
            this.lblRed3.Name = "lblRed3";
            this.lblRed3.Size = new System.Drawing.Size(52, 44);
            this.lblRed3.TabIndex = 0;
            this.lblRed3.Text = "00";
            this.lblRed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed2
            // 
            this.lblRed2.ForeColor = System.Drawing.Color.Red;
            this.lblRed2.Location = new System.Drawing.Point(173, 145);
            this.lblRed2.Name = "lblRed2";
            this.lblRed2.Size = new System.Drawing.Size(52, 44);
            this.lblRed2.TabIndex = 0;
            this.lblRed2.Text = "00";
            this.lblRed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed1
            // 
            this.lblRed1.ForeColor = System.Drawing.Color.Red;
            this.lblRed1.Location = new System.Drawing.Point(97, 145);
            this.lblRed1.Name = "lblRed1";
            this.lblRed1.Size = new System.Drawing.Size(52, 44);
            this.lblRed1.TabIndex = 0;
            this.lblRed1.Text = "00";
            this.lblRed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(818, 451);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "猜数字";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed5;
        private System.Windows.Forms.Label lblRed4;
        private System.Windows.Forms.Label lblRed3;
        private System.Windows.Forms.Label lblRed2;
        private System.Windows.Forms.Label lblRed1;
        private System.Windows.Forms.Label lblRed6;
    }
}

