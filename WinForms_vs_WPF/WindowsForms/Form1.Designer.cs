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
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonA_Count = new System.Windows.Forms.Label();
            this.ButtonB_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonA
            // 
            this.ButtonA.Font = new System.Drawing.Font("BIZ UDゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonA.Location = new System.Drawing.Point(87, 146);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(164, 58);
            this.ButtonA.TabIndex = 0;
            this.ButtonA.Text = "Aボタン";
            this.ButtonA.UseVisualStyleBackColor = true;
            this.ButtonA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // ButtonB
            // 
            this.ButtonB.Font = new System.Drawing.Font("BIZ UDゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonB.Location = new System.Drawing.Point(339, 146);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(164, 58);
            this.ButtonB.TabIndex = 1;
            this.ButtonB.Text = "Bボタン";
            this.ButtonB.UseVisualStyleBackColor = true;
            this.ButtonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // ButtonA_Count
            // 
            this.ButtonA_Count.AutoSize = true;
            this.ButtonA_Count.Font = new System.Drawing.Font("BIZ UDゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonA_Count.Location = new System.Drawing.Point(158, 72);
            this.ButtonA_Count.Name = "ButtonA_Count";
            this.ButtonA_Count.Size = new System.Drawing.Size(22, 23);
            this.ButtonA_Count.TabIndex = 2;
            this.ButtonA_Count.Text = "0";
            this.ButtonA_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonB_Count
            // 
            this.ButtonB_Count.AutoSize = true;
            this.ButtonB_Count.Font = new System.Drawing.Font("BIZ UDゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonB_Count.Location = new System.Drawing.Point(410, 72);
            this.ButtonB_Count.Name = "ButtonB_Count";
            this.ButtonB_Count.Size = new System.Drawing.Size(22, 23);
            this.ButtonB_Count.TabIndex = 3;
            this.ButtonB_Count.Text = "0";
            this.ButtonB_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.ButtonB_Count);
            this.Controls.Add(this.ButtonA_Count);
            this.Controls.Add(this.ButtonB);
            this.Controls.Add(this.ButtonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Label ButtonA_Count;
        private System.Windows.Forms.Label ButtonB_Count;
    }
}

