namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent( )
        {
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.Lbl_AClick_Count = new System.Windows.Forms.Label();
            this.Lbl_BClick_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnA
            // 
            this.BtnA.Font = new System.Drawing.Font("BIZ UDゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnA.Location = new System.Drawing.Point(141, 234);
            this.BtnA.Margin = new System.Windows.Forms.Padding(5);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(266, 93);
            this.BtnA.TabIndex = 0;
            this.BtnA.Text = "Aボタン";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Font = new System.Drawing.Font("BIZ UDゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnB.Location = new System.Drawing.Point(551, 234);
            this.BtnB.Margin = new System.Windows.Forms.Padding(5);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(266, 93);
            this.BtnB.TabIndex = 1;
            this.BtnB.Text = "Bボタン";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // Lbl_AClick_Count
            // 
            this.Lbl_AClick_Count.AutoSize = true;
            this.Lbl_AClick_Count.Font = new System.Drawing.Font("BIZ UDゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_AClick_Count.Location = new System.Drawing.Point(257, 115);
            this.Lbl_AClick_Count.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_AClick_Count.Name = "Lbl_AClick_Count";
            this.Lbl_AClick_Count.Size = new System.Drawing.Size(36, 37);
            this.Lbl_AClick_Count.TabIndex = 2;
            this.Lbl_AClick_Count.Text = "0";
            this.Lbl_AClick_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_BClick_Count
            // 
            this.Lbl_BClick_Count.AutoSize = true;
            this.Lbl_BClick_Count.Font = new System.Drawing.Font("BIZ UDゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_BClick_Count.Location = new System.Drawing.Point(666, 115);
            this.Lbl_BClick_Count.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_BClick_Count.Name = "Lbl_BClick_Count";
            this.Lbl_BClick_Count.Size = new System.Drawing.Size(36, 37);
            this.Lbl_BClick_Count.TabIndex = 3;
            this.Lbl_BClick_Count.Text = "0";
            this.Lbl_BClick_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 409);
            this.Controls.Add(this.Lbl_BClick_Count);
            this.Controls.Add(this.Lbl_AClick_Count);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Label Lbl_AClick_Count;
        private System.Windows.Forms.Label Lbl_BClick_Count;
    }
}

