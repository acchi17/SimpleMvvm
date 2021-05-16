
namespace SimpleMvvm.SimpleCalc
{
    partial class FormView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxItem1 = new System.Windows.Forms.TextBox();
            this.txtBxItem2 = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxItem1
            // 
            this.txtBxItem1.Location = new System.Drawing.Point(12, 33);
            this.txtBxItem1.Name = "txtBxItem1";
            this.txtBxItem1.Size = new System.Drawing.Size(62, 19);
            this.txtBxItem1.TabIndex = 0;
            // 
            // txtBxItem2
            // 
            this.txtBxItem2.Location = new System.Drawing.Point(109, 33);
            this.txtBxItem2.Name = "txtBxItem2";
            this.txtBxItem2.Size = new System.Drawing.Size(62, 19);
            this.txtBxItem2.TabIndex = 1;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(89, 37);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(11, 12);
            this.lblPlus.TabIndex = 2;
            this.lblPlus.Text = "+";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(317, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(11, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "0";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(199, 33);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(68, 19);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.txtBxItem2);
            this.Controls.Add(this.txtBxItem1);
            this.Name = "FormView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxItem1;
        private System.Windows.Forms.TextBox txtBxItem2;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button buttonCalc;
    }
}

