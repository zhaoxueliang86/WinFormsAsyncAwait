namespace WinFormsAsyncAwait
{
    partial class FormWait
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeadlock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnWaitAll = new System.Windows.Forms.Button();
            this.BtnWait = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnDeadlock);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnWaitAll);
            this.groupBox1.Controls.Add(this.BtnWait);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BtnDeadlock
            // 
            this.BtnDeadlock.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeadlock.Location = new System.Drawing.Point(648, 29);
            this.BtnDeadlock.Name = "BtnDeadlock";
            this.BtnDeadlock.Size = new System.Drawing.Size(184, 65);
            this.BtnDeadlock.TabIndex = 8;
            this.BtnDeadlock.Text = "Deadlock";
            this.BtnDeadlock.UseVisualStyleBackColor = true;
            this.BtnDeadlock.Click += new System.EventHandler(this.BtnDeadlock_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(440, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "WaitAny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnWaitAny_Click);
            // 
            // BtnWaitAll
            // 
            this.BtnWaitAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWaitAll.Location = new System.Drawing.Point(232, 29);
            this.BtnWaitAll.Name = "BtnWaitAll";
            this.BtnWaitAll.Size = new System.Drawing.Size(184, 65);
            this.BtnWaitAll.TabIndex = 6;
            this.BtnWaitAll.Text = "WaitAll";
            this.BtnWaitAll.UseVisualStyleBackColor = true;
            this.BtnWaitAll.Click += new System.EventHandler(this.BtnWaitAll_Click);
            // 
            // BtnWait
            // 
            this.BtnWait.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWait.Location = new System.Drawing.Point(24, 29);
            this.BtnWait.Name = "BtnWait";
            this.BtnWait.Size = new System.Drawing.Size(184, 65);
            this.BtnWait.TabIndex = 5;
            this.BtnWait.Text = "Wait";
            this.BtnWait.UseVisualStyleBackColor = true;
            this.BtnWait.Click += new System.EventHandler(this.BtnWait_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(12, 148);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(1024, 911);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Text = "";
            // 
            // FormWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 1071);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "FormWait";
            this.Text = "FormWait";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnWait;
        private RichTextBox resultTextBox;
        private Button button2;
        private Button BtnWaitAll;
        private Button BtnDeadlock;
    }
}