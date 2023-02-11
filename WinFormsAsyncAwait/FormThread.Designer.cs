namespace WinFormsAsyncAwait
{
    partial class FormThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFalse = new System.Windows.Forms.Button();
            this.BtnTrue = new System.Windows.Forms.Button();
            this.BtnEvent = new System.Windows.Forms.Button();
            this.BtnAsyncCallback = new System.Windows.Forms.Button();
            this.btnConcurrency = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnPrint);
            this.groupBox1.Controls.Add(this.BtnFalse);
            this.groupBox1.Controls.Add(this.BtnTrue);
            this.groupBox1.Controls.Add(this.BtnEvent);
            this.groupBox1.Controls.Add(this.BtnAsyncCallback);
            this.groupBox1.Controls.Add(this.btnConcurrency);
            this.groupBox1.Controls.Add(this.btnAsync);
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnFalse
            // 
            this.BtnFalse.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFalse.Location = new System.Drawing.Point(297, 101);
            this.BtnFalse.Name = "BtnFalse";
            this.BtnFalse.Size = new System.Drawing.Size(223, 65);
            this.BtnFalse.TabIndex = 6;
            this.BtnFalse.Text = "False";
            this.BtnFalse.UseVisualStyleBackColor = true;
            this.BtnFalse.Click += new System.EventHandler(this.Test_ConfigureAwait);
            // 
            // BtnTrue
            // 
            this.BtnTrue.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTrue.Location = new System.Drawing.Point(30, 101);
            this.BtnTrue.Name = "BtnTrue";
            this.BtnTrue.Size = new System.Drawing.Size(223, 65);
            this.BtnTrue.TabIndex = 5;
            this.BtnTrue.Text = "True";
            this.BtnTrue.UseVisualStyleBackColor = true;
            this.BtnTrue.Click += new System.EventHandler(this.Test_ConfigureAwait);
            // 
            // BtnEvent
            // 
            this.BtnEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEvent.Location = new System.Drawing.Point(1098, 30);
            this.BtnEvent.Name = "BtnEvent";
            this.BtnEvent.Size = new System.Drawing.Size(223, 65);
            this.BtnEvent.TabIndex = 4;
            this.BtnEvent.Text = "事件";
            this.BtnEvent.UseVisualStyleBackColor = true;
            this.BtnEvent.Click += new System.EventHandler(this.BtnEvent_Click);
            // 
            // BtnAsyncCallback
            // 
            this.BtnAsyncCallback.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAsyncCallback.Location = new System.Drawing.Point(831, 29);
            this.BtnAsyncCallback.Name = "BtnAsyncCallback";
            this.BtnAsyncCallback.Size = new System.Drawing.Size(223, 65);
            this.BtnAsyncCallback.TabIndex = 3;
            this.BtnAsyncCallback.Text = "异步回调";
            this.BtnAsyncCallback.UseVisualStyleBackColor = true;
            this.BtnAsyncCallback.Click += new System.EventHandler(this.BtnAsyncCallbak_Click);
            // 
            // btnConcurrency
            // 
            this.btnConcurrency.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConcurrency.Location = new System.Drawing.Point(564, 30);
            this.btnConcurrency.Name = "btnConcurrency";
            this.btnConcurrency.Size = new System.Drawing.Size(223, 65);
            this.btnConcurrency.TabIndex = 2;
            this.btnConcurrency.Text = "并发";
            this.btnConcurrency.UseVisualStyleBackColor = true;
            this.btnConcurrency.Click += new System.EventHandler(this.BtnConcurrencyAsync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsync.Location = new System.Drawing.Point(297, 30);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(223, 65);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "异步";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSync.Location = new System.Drawing.Point(30, 30);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(223, 65);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "同步";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(13, 208);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(1357, 829);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPrint.Location = new System.Drawing.Point(564, 101);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(223, 65);
            this.BtnPrint.TabIndex = 7;
            this.BtnPrint.Text = "输出";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // FormThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1382, 1048);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检索";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConcurrency;
        private Button btnAsync;
        private Button btnSync;
        private RichTextBox resultTextBox;
        private Button BtnAsyncCallback;
        private Button BtnEvent;
        private Button BtnTrue;
        private Button BtnFalse;
        private Button BtnPrint;
    }
}