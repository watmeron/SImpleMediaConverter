namespace SimpleMediaConverter
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
            this.settingsBotton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.ListBox();
            this.expandedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishedBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsBotton
            // 
            this.settingsBotton.Location = new System.Drawing.Point(241, 264);
            this.settingsBotton.Name = "settingsBotton";
            this.settingsBotton.Size = new System.Drawing.Size(75, 23);
            this.settingsBotton.TabIndex = 0;
            this.settingsBotton.Text = "Settings";
            this.settingsBotton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.AllowDrop = true;
            this.inputBox.FormattingEnabled = true;
            this.inputBox.ItemHeight = 12;
            this.inputBox.Location = new System.Drawing.Point(14, 32);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(304, 76);
            this.inputBox.TabIndex = 2;
            this.inputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputBox_DragDrop);
            this.inputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputBox_DragEnter);
            // 
            // expandedList
            // 
            this.expandedList.FormattingEnabled = true;
            this.expandedList.ItemHeight = 12;
            this.expandedList.Location = new System.Drawing.Point(14, 152);
            this.expandedList.Name = "expandedList";
            this.expandedList.Size = new System.Drawing.Size(304, 76);
            this.expandedList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "↓";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Processing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "↓";
            // 
            // FinishedBox
            // 
            this.FinishedBox.FormattingEnabled = true;
            this.FinishedBox.ItemHeight = 12;
            this.FinishedBox.Location = new System.Drawing.Point(12, 335);
            this.FinishedBox.Name = "FinishedBox";
            this.FinishedBox.Size = new System.Drawing.Size(304, 76);
            this.FinishedBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "List of Files";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FinishedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expandedList);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.settingsBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsBotton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox inputBox;
        private System.Windows.Forms.ListBox expandedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox FinishedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

