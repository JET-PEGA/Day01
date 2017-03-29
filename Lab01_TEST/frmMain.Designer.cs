namespace Lab01_TEST
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDev1 = new System.Windows.Forms.Button();
            this.btnDev2 = new System.Windows.Forms.Button();
            this.btnNewAbstract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDev1
            // 
            this.btnDev1.Location = new System.Drawing.Point(85, 35);
            this.btnDev1.Name = "btnDev1";
            this.btnDev1.Size = new System.Drawing.Size(217, 79);
            this.btnDev1.TabIndex = 0;
            this.btnDev1.Text = "Result(DEV1)";
            this.btnDev1.UseVisualStyleBackColor = true;
            this.btnDev1.Click += new System.EventHandler(this.btnDev1_Click);
            // 
            // btnDev2
            // 
            this.btnDev2.Location = new System.Drawing.Point(85, 143);
            this.btnDev2.Name = "btnDev2";
            this.btnDev2.Size = new System.Drawing.Size(217, 79);
            this.btnDev2.TabIndex = 1;
            this.btnDev2.Text = "Result(DEV2)";
            this.btnDev2.UseVisualStyleBackColor = true;
            this.btnDev2.Click += new System.EventHandler(this.btnDev2_Click);
            // 
            // btnNewAbstract
            // 
            this.btnNewAbstract.Location = new System.Drawing.Point(362, 35);
            this.btnNewAbstract.Name = "btnNewAbstract";
            this.btnNewAbstract.Size = new System.Drawing.Size(217, 79);
            this.btnNewAbstract.TabIndex = 2;
            this.btnNewAbstract.Text = "new abstract";
            this.btnNewAbstract.UseVisualStyleBackColor = true;
            this.btnNewAbstract.Click += new System.EventHandler(this.btnNewAbstract_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 502);
            this.Controls.Add(this.btnNewAbstract);
            this.Controls.Add(this.btnDev2);
            this.Controls.Add(this.btnDev1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDev1;
        private System.Windows.Forms.Button btnDev2;
        private System.Windows.Forms.Button btnNewAbstract;
    }
}

