namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listUndo = new System.Windows.Forms.ListBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnopen.Location = new System.Drawing.Point(504, 59);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(255, 40);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "開啟檔案";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsave.Location = new System.Drawing.Point(504, 105);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(255, 40);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "儲存答案";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(29, 78);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(454, 347);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listUndo
            // 
            this.listUndo.FormattingEnabled = true;
            this.listUndo.ItemHeight = 15;
            this.listUndo.Location = new System.Drawing.Point(504, 243);
            this.listUndo.Name = "listUndo";
            this.listUndo.Size = new System.Drawing.Size(255, 184);
            this.listUndo.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUndo.Location = new System.Drawing.Point(504, 151);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(255, 40);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "還原";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRedo.Location = new System.Drawing.Point(504, 197);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(255, 40);
            this.btnRedo.TabIndex = 0;
            this.btnRedo.Text = "重做下一步";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(29, 39);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(197, 33);
            this.comboBoxFont.TabIndex = 3;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(232, 39);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(100, 33);
            this.comboBoxSize.TabIndex = 3;
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(338, 39);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(145, 33);
            this.comboBoxStyle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.listUndo);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "記事本";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listUndo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxStyle;
    }
}

