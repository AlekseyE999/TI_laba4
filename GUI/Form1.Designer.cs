namespace GUI
{
    partial class Form1
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenKey = new System.Windows.Forms.Button();
            this.cipher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.decipher = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputText.Location = new System.Drawing.Point(160, 36);
            this.inputText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(897, 168);
            this.inputText.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "input text";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(160, 232);
            this.result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(897, 150);
            this.result.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "result";
            // 
            // GenKey
            // 
            this.GenKey.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenKey.Location = new System.Drawing.Point(595, 569);
            this.GenKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenKey.Name = "GenKey";
            this.GenKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenKey.Size = new System.Drawing.Size(194, 37);
            this.GenKey.TabIndex = 47;
            this.GenKey.Text = "Generate key";
            this.GenKey.UseVisualStyleBackColor = true;
            this.GenKey.Click += new System.EventHandler(this.GenKey_Click);
            // 
            // cipher
            // 
            this.cipher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipher.Location = new System.Drawing.Point(160, 569);
            this.cipher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cipher.Name = "cipher";
            this.cipher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cipher.Size = new System.Drawing.Size(181, 37);
            this.cipher.TabIndex = 48;
            this.cipher.Text = "Cipher";
            this.cipher.UseVisualStyleBackColor = true;
            this.cipher.Click += new System.EventHandler(this.cipher_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "key";
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(160, 413);
            this.key.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(897, 134);
            this.key.TabIndex = 49;
            // 
            // decipher
            // 
            this.decipher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decipher.Location = new System.Drawing.Point(368, 569);
            this.decipher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decipher.Name = "decipher";
            this.decipher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decipher.Size = new System.Drawing.Size(180, 37);
            this.decipher.TabIndex = 51;
            this.decipher.Text = "Decipher";
            this.decipher.UseVisualStyleBackColor = true;
            this.decipher.Click += new System.EventHandler(this.decipher_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.Location = new System.Drawing.Point(834, 569);
            this.open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.open.Name = "open";
            this.open.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.open.Size = new System.Drawing.Size(185, 37);
            this.open.TabIndex = 52;
            this.open.Text = "Open file";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 652);
            this.Controls.Add(this.open);
            this.Controls.Add(this.decipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.GenKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenKey;
        private System.Windows.Forms.Button cipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button decipher;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

