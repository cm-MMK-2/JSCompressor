namespace JSCompressor
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
            this.selbutton1 = new System.Windows.Forms.Button();
            this.selbutton2 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUglify = new System.Windows.Forms.RadioButton();
            this.rbGoogle = new System.Windows.Forms.RadioButton();
            this.rbYUI = new System.Windows.Forms.RadioButton();
            this.checkCompressInSource = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selbutton1
            // 
            this.selbutton1.Location = new System.Drawing.Point(409, 36);
            this.selbutton1.Name = "selbutton1";
            this.selbutton1.Size = new System.Drawing.Size(56, 23);
            this.selbutton1.TabIndex = 0;
            this.selbutton1.Text = "select";
            this.selbutton1.UseVisualStyleBackColor = true;
            this.selbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selbutton2
            // 
            this.selbutton2.Enabled = false;
            this.selbutton2.Location = new System.Drawing.Point(409, 63);
            this.selbutton2.Name = "selbutton2";
            this.selbutton2.Size = new System.Drawing.Size(56, 23);
            this.selbutton2.TabIndex = 1;
            this.selbutton2.Text = "select";
            this.selbutton2.UseVisualStyleBackColor = true;
            this.selbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(390, 95);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 19);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(88, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 19);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "source path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "target path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // rbUglify
            // 
            this.rbUglify.AutoSize = true;
            this.rbUglify.Checked = true;
            this.rbUglify.Location = new System.Drawing.Point(19, 16);
            this.rbUglify.Name = "rbUglify";
            this.rbUglify.Size = new System.Drawing.Size(51, 16);
            this.rbUglify.TabIndex = 8;
            this.rbUglify.TabStop = true;
            this.rbUglify.Text = "uglify";
            this.rbUglify.UseVisualStyleBackColor = true;
            // 
            // rbGoogle
            // 
            this.rbGoogle.AutoSize = true;
            this.rbGoogle.Location = new System.Drawing.Point(113, 16);
            this.rbGoogle.Name = "rbGoogle";
            this.rbGoogle.Size = new System.Drawing.Size(97, 16);
            this.rbGoogle.TabIndex = 9;
            this.rbGoogle.Text = "GoogleClosure";
            this.rbGoogle.UseVisualStyleBackColor = true;
            // 
            // rbYUI
            // 
            this.rbYUI.AutoSize = true;
            this.rbYUI.Enabled = false;
            this.rbYUI.Location = new System.Drawing.Point(233, 16);
            this.rbYUI.Name = "rbYUI";
            this.rbYUI.Size = new System.Drawing.Size(102, 16);
            this.rbYUI.TabIndex = 10;
            this.rbYUI.Text = "YUICompressor";
            this.rbYUI.UseVisualStyleBackColor = true;
            // 
            // checkCompressInSource
            // 
            this.checkCompressInSource.AutoSize = true;
            this.checkCompressInSource.Checked = true;
            this.checkCompressInSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCompressInSource.Location = new System.Drawing.Point(21, 102);
            this.checkCompressInSource.Name = "checkCompressInSource";
            this.checkCompressInSource.Size = new System.Drawing.Size(157, 16);
            this.checkCompressInSource.TabIndex = 11;
            this.checkCompressInSource.Text = "compress in source folder";
            this.checkCompressInSource.UseVisualStyleBackColor = true;
            this.checkCompressInSource.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 130);
            this.Controls.Add(this.checkCompressInSource);
            this.Controls.Add(this.rbYUI);
            this.Controls.Add(this.rbGoogle);
            this.Controls.Add(this.rbUglify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selbutton2);
            this.Controls.Add(this.selbutton1);
            this.Name = "Form1";
            this.Text = "JSCompressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selbutton1;
        private System.Windows.Forms.Button selbutton2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbUglify;
        private System.Windows.Forms.RadioButton rbGoogle;
        private System.Windows.Forms.RadioButton rbYUI;
        private System.Windows.Forms.CheckBox checkCompressInSource;
    }
}

