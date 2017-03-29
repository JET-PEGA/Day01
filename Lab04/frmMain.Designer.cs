namespace Lab04
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
            this.btnDynamicExtension = new System.Windows.Forms.Button();
            this.btnDynamicFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDynamicExtension
            // 
            this.btnDynamicExtension.Location = new System.Drawing.Point(12, 98);
            this.btnDynamicExtension.Name = "btnDynamicExtension";
            this.btnDynamicExtension.Size = new System.Drawing.Size(268, 80);
            this.btnDynamicExtension.TabIndex = 14;
            this.btnDynamicExtension.Text = "dynamic (Extension)";
            this.btnDynamicExtension.UseVisualStyleBackColor = true;
            this.btnDynamicExtension.Click += new System.EventHandler(this.btnDynamicExtension_Click);
            // 
            // btnDynamicFunction
            // 
            this.btnDynamicFunction.Location = new System.Drawing.Point(12, 12);
            this.btnDynamicFunction.Name = "btnDynamicFunction";
            this.btnDynamicFunction.Size = new System.Drawing.Size(268, 80);
            this.btnDynamicFunction.TabIndex = 13;
            this.btnDynamicFunction.Text = "dynamic(function)";
            this.btnDynamicFunction.UseVisualStyleBackColor = true;
            this.btnDynamicFunction.Click += new System.EventHandler(this.btnDynamicFunction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 374);
            this.Controls.Add(this.btnDynamicExtension);
            this.Controls.Add(this.btnDynamicFunction);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDynamicExtension;
        private System.Windows.Forms.Button btnDynamicFunction;
    }
}

