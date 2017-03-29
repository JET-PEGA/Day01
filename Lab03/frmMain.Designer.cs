namespace Lab03
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
            this.btnDynamic = new System.Windows.Forms.Button();
            this.btnDynamicRunTime = new System.Windows.Forms.Button();
            this.btnDynamicDesignTime = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.btnObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(12, 184);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(268, 80);
            this.btnDynamic.TabIndex = 9;
            this.btnDynamic.Text = "dynamic";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // btnDynamicRunTime
            // 
            this.btnDynamicRunTime.Location = new System.Drawing.Point(12, 356);
            this.btnDynamicRunTime.Name = "btnDynamicRunTime";
            this.btnDynamicRunTime.Size = new System.Drawing.Size(268, 80);
            this.btnDynamicRunTime.TabIndex = 8;
            this.btnDynamicRunTime.Text = "dynamic (runtime)";
            this.btnDynamicRunTime.UseVisualStyleBackColor = true;
            this.btnDynamicRunTime.Click += new System.EventHandler(this.btnDynamicRunTime_Click);
            // 
            // btnDynamicDesignTime
            // 
            this.btnDynamicDesignTime.Location = new System.Drawing.Point(12, 270);
            this.btnDynamicDesignTime.Name = "btnDynamicDesignTime";
            this.btnDynamicDesignTime.Size = new System.Drawing.Size(268, 80);
            this.btnDynamicDesignTime.TabIndex = 7;
            this.btnDynamicDesignTime.Text = "dynamic(design time)";
            this.btnDynamicDesignTime.UseVisualStyleBackColor = true;
            this.btnDynamicDesignTime.Click += new System.EventHandler(this.btnDynamicDesignTime_Click);
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(12, 98);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(268, 80);
            this.btnVar.TabIndex = 6;
            this.btnVar.Text = "var";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(12, 12);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(268, 80);
            this.btnObject.TabIndex = 5;
            this.btnObject.Text = "object";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.btnDynamic);
            this.Controls.Add(this.btnDynamicRunTime);
            this.Controls.Add(this.btnDynamicDesignTime);
            this.Controls.Add(this.btnVar);
            this.Controls.Add(this.btnObject);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDynamic;
        private System.Windows.Forms.Button btnDynamicRunTime;
        private System.Windows.Forms.Button btnDynamicDesignTime;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.Button btnObject;
    }
}

