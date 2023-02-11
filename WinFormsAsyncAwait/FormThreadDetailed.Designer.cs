namespace WinFormsAsyncAwait
{
    partial class FormThreadDetailed
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
            this.BtnTrue = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.cbAwait = new System.Windows.Forms.CheckBox();
            this.cbConfigureAwait = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbConfigureAwait);
            this.groupBox1.Controls.Add(this.cbAwait);
            this.groupBox1.Controls.Add(this.BtnTrue);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnTrue
            // 
            this.BtnTrue.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTrue.Location = new System.Drawing.Point(475, 60);
            this.BtnTrue.Name = "BtnTrue";
            this.BtnTrue.Size = new System.Drawing.Size(223, 65);
            this.BtnTrue.TabIndex = 5;
            this.BtnTrue.Text = "执行";
            this.BtnTrue.UseVisualStyleBackColor = true;
            this.BtnTrue.Click += new System.EventHandler(this.Test_ConfigureAwait);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(12, 196);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(754, 842);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.Text = "";
            // 
            // cbAwait
            // 
            this.cbAwait.AutoSize = true;
            this.cbAwait.Checked = true;
            this.cbAwait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAwait.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAwait.Location = new System.Drawing.Point(19, 29);
            this.cbAwait.Name = "cbAwait";
            this.cbAwait.Size = new System.Drawing.Size(131, 45);
            this.cbAwait.TabIndex = 6;
            this.cbAwait.Text = "Await";
            this.cbAwait.UseVisualStyleBackColor = true;
            // 
            // cbConfigureAwait
            // 
            this.cbConfigureAwait.AutoSize = true;
            this.cbConfigureAwait.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConfigureAwait.Location = new System.Drawing.Point(19, 80);
            this.cbConfigureAwait.Name = "cbConfigureAwait";
            this.cbConfigureAwait.Size = new System.Drawing.Size(282, 45);
            this.cbConfigureAwait.TabIndex = 7;
            this.cbConfigureAwait.Text = "ConfigureAwait";
            this.cbConfigureAwait.UseVisualStyleBackColor = true;
            // 
            // FormThreadDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 1057);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "FormThreadDetailed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task/Async/Await";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnTrue;
        private RichTextBox resultTextBox;
        private CheckBox cbConfigureAwait;
        private CheckBox cbAwait;
    }
}