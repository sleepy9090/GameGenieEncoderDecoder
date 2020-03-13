namespace GameGenieEncoderDecoder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxNesCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNesAddress = new System.Windows.Forms.TextBox();
            this.textBoxNesValue = new System.Windows.Forms.TextBox();
            this.textBoxNesCheckByteCompare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNesEncode = new System.Windows.Forms.Button();
            this.buttonNesDecode = new System.Windows.Forms.Button();
            this.buttonGbGgDecode = new System.Windows.Forms.Button();
            this.buttonGbGgEncode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGbGgCheckByteCompare = new System.Windows.Forms.TextBox();
            this.textBoxGbGgValue = new System.Windows.Forms.TextBox();
            this.textBoxGbGgAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGbGgCode = new System.Windows.Forms.TextBox();
            this.buttonSnesDecode = new System.Windows.Forms.Button();
            this.buttonSnesEncode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSnesValue = new System.Windows.Forms.TextBox();
            this.textBoxSnesAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSnesCode = new System.Windows.Forms.TextBox();
            this.buttonGenMdDecode = new System.Windows.Forms.Button();
            this.buttonGenMdEncode = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxGenMdValue = new System.Windows.Forms.TextBox();
            this.textBoxGenMdAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxGenMdCode = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.buttonNesDecode);
            this.tabPage1.Controls.Add(this.buttonNesEncode);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxNesCheckByteCompare);
            this.tabPage1.Controls.Add(this.textBoxNesValue);
            this.tabPage1.Controls.Add(this.textBoxNesAddress);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNesCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NES";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.buttonGbGgDecode);
            this.tabPage2.Controls.Add(this.buttonGbGgEncode);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxGbGgCheckByteCompare);
            this.tabPage2.Controls.Add(this.textBoxGbGgValue);
            this.tabPage2.Controls.Add(this.textBoxGbGgAddress);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxGbGgCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GB/GG";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.buttonSnesDecode);
            this.tabPage3.Controls.Add(this.buttonSnesEncode);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBoxSnesValue);
            this.tabPage3.Controls.Add(this.textBoxSnesAddress);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBoxSnesCode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SNES";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.buttonGenMdDecode);
            this.tabPage4.Controls.Add(this.buttonGenMdEncode);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBoxGenMdValue);
            this.tabPage4.Controls.Add(this.textBoxGenMdAddress);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.textBoxGenMdCode);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "GEN/MD";
            // 
            // textBoxNesCode
            // 
            this.textBoxNesCode.Location = new System.Drawing.Point(130, 15);
            this.textBoxNesCode.Name = "textBoxNesCode";
            this.textBoxNesCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxNesCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            // 
            // textBoxNesAddress
            // 
            this.textBoxNesAddress.Location = new System.Drawing.Point(130, 41);
            this.textBoxNesAddress.Name = "textBoxNesAddress";
            this.textBoxNesAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxNesAddress.TabIndex = 2;
            // 
            // textBoxNesValue
            // 
            this.textBoxNesValue.Location = new System.Drawing.Point(130, 67);
            this.textBoxNesValue.Name = "textBoxNesValue";
            this.textBoxNesValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxNesValue.TabIndex = 3;
            // 
            // textBoxNesCheckByteCompare
            // 
            this.textBoxNesCheckByteCompare.Location = new System.Drawing.Point(130, 93);
            this.textBoxNesCheckByteCompare.Name = "textBoxNesCheckByteCompare";
            this.textBoxNesCheckByteCompare.Size = new System.Drawing.Size(100, 20);
            this.textBoxNesCheckByteCompare.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Check Byte / Compare:";
            // 
            // buttonNesEncode
            // 
            this.buttonNesEncode.Location = new System.Drawing.Point(75, 119);
            this.buttonNesEncode.Name = "buttonNesEncode";
            this.buttonNesEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonNesEncode.TabIndex = 8;
            this.buttonNesEncode.Text = "&Encode";
            this.buttonNesEncode.UseVisualStyleBackColor = true;
            this.buttonNesEncode.Click += new System.EventHandler(this.buttonNesEncode_Click);
            // 
            // buttonNesDecode
            // 
            this.buttonNesDecode.Location = new System.Drawing.Point(156, 119);
            this.buttonNesDecode.Name = "buttonNesDecode";
            this.buttonNesDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonNesDecode.TabIndex = 9;
            this.buttonNesDecode.Text = "&Decode";
            this.buttonNesDecode.UseVisualStyleBackColor = true;
            this.buttonNesDecode.Click += new System.EventHandler(this.buttonNesDecode_Click);
            // 
            // buttonGbGgDecode
            // 
            this.buttonGbGgDecode.Location = new System.Drawing.Point(155, 119);
            this.buttonGbGgDecode.Name = "buttonGbGgDecode";
            this.buttonGbGgDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonGbGgDecode.TabIndex = 19;
            this.buttonGbGgDecode.Text = "&Decode";
            this.buttonGbGgDecode.UseVisualStyleBackColor = true;
            this.buttonGbGgDecode.Click += new System.EventHandler(this.buttonGbGgDecode_Click);
            // 
            // buttonGbGgEncode
            // 
            this.buttonGbGgEncode.Location = new System.Drawing.Point(74, 119);
            this.buttonGbGgEncode.Name = "buttonGbGgEncode";
            this.buttonGbGgEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonGbGgEncode.TabIndex = 18;
            this.buttonGbGgEncode.Text = "&Encode";
            this.buttonGbGgEncode.UseVisualStyleBackColor = true;
            this.buttonGbGgEncode.Click += new System.EventHandler(this.buttonGbGgEncode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Check Byte / Compare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // textBoxGbGgCheckByteCompare
            // 
            this.textBoxGbGgCheckByteCompare.Location = new System.Drawing.Point(130, 93);
            this.textBoxGbGgCheckByteCompare.Name = "textBoxGbGgCheckByteCompare";
            this.textBoxGbGgCheckByteCompare.Size = new System.Drawing.Size(100, 20);
            this.textBoxGbGgCheckByteCompare.TabIndex = 14;
            // 
            // textBoxGbGgValue
            // 
            this.textBoxGbGgValue.Location = new System.Drawing.Point(130, 67);
            this.textBoxGbGgValue.Name = "textBoxGbGgValue";
            this.textBoxGbGgValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxGbGgValue.TabIndex = 13;
            // 
            // textBoxGbGgAddress
            // 
            this.textBoxGbGgAddress.Location = new System.Drawing.Point(130, 41);
            this.textBoxGbGgAddress.Name = "textBoxGbGgAddress";
            this.textBoxGbGgAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxGbGgAddress.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Code:";
            // 
            // textBoxGbGgCode
            // 
            this.textBoxGbGgCode.Location = new System.Drawing.Point(130, 15);
            this.textBoxGbGgCode.Name = "textBoxGbGgCode";
            this.textBoxGbGgCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxGbGgCode.TabIndex = 10;
            // 
            // buttonSnesDecode
            // 
            this.buttonSnesDecode.Location = new System.Drawing.Point(155, 93);
            this.buttonSnesDecode.Name = "buttonSnesDecode";
            this.buttonSnesDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonSnesDecode.TabIndex = 19;
            this.buttonSnesDecode.Text = "&Decode";
            this.buttonSnesDecode.UseVisualStyleBackColor = true;
            this.buttonSnesDecode.Click += new System.EventHandler(this.buttonSnesDecode_Click);
            // 
            // buttonSnesEncode
            // 
            this.buttonSnesEncode.Location = new System.Drawing.Point(74, 93);
            this.buttonSnesEncode.Name = "buttonSnesEncode";
            this.buttonSnesEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonSnesEncode.TabIndex = 18;
            this.buttonSnesEncode.Text = "&Encode";
            this.buttonSnesEncode.UseVisualStyleBackColor = true;
            this.buttonSnesEncode.Click += new System.EventHandler(this.buttonSnesEncode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Address:";
            // 
            // textBoxSnesValue
            // 
            this.textBoxSnesValue.Location = new System.Drawing.Point(130, 67);
            this.textBoxSnesValue.Name = "textBoxSnesValue";
            this.textBoxSnesValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnesValue.TabIndex = 13;
            // 
            // textBoxSnesAddress
            // 
            this.textBoxSnesAddress.Location = new System.Drawing.Point(130, 41);
            this.textBoxSnesAddress.Name = "textBoxSnesAddress";
            this.textBoxSnesAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnesAddress.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Code:";
            // 
            // textBoxSnesCode
            // 
            this.textBoxSnesCode.Location = new System.Drawing.Point(130, 15);
            this.textBoxSnesCode.Name = "textBoxSnesCode";
            this.textBoxSnesCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnesCode.TabIndex = 10;
            // 
            // buttonGenMdDecode
            // 
            this.buttonGenMdDecode.Location = new System.Drawing.Point(155, 93);
            this.buttonGenMdDecode.Name = "buttonGenMdDecode";
            this.buttonGenMdDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenMdDecode.TabIndex = 19;
            this.buttonGenMdDecode.Text = "&Decode";
            this.buttonGenMdDecode.UseVisualStyleBackColor = true;
            this.buttonGenMdDecode.Click += new System.EventHandler(this.buttonGenMdDecode_Click);
            // 
            // buttonGenMdEncode
            // 
            this.buttonGenMdEncode.Location = new System.Drawing.Point(74, 93);
            this.buttonGenMdEncode.Name = "buttonGenMdEncode";
            this.buttonGenMdEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenMdEncode.TabIndex = 18;
            this.buttonGenMdEncode.Text = "&Encode";
            this.buttonGenMdEncode.UseVisualStyleBackColor = true;
            this.buttonGenMdEncode.Click += new System.EventHandler(this.buttonGenMdEncode_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Value:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Address:";
            // 
            // textBoxGenMdValue
            // 
            this.textBoxGenMdValue.Location = new System.Drawing.Point(130, 67);
            this.textBoxGenMdValue.Name = "textBoxGenMdValue";
            this.textBoxGenMdValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenMdValue.TabIndex = 13;
            // 
            // textBoxGenMdAddress
            // 
            this.textBoxGenMdAddress.Location = new System.Drawing.Point(130, 41);
            this.textBoxGenMdAddress.Name = "textBoxGenMdAddress";
            this.textBoxGenMdAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenMdAddress.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Code:";
            // 
            // textBoxGenMdCode
            // 
            this.textBoxGenMdCode.Location = new System.Drawing.Point(130, 15);
            this.textBoxGenMdCode.Name = "textBoxGenMdCode";
            this.textBoxGenMdCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenMdCode.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Genie Encoder/Decoder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonNesDecode;
        private System.Windows.Forms.Button buttonNesEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNesCheckByteCompare;
        private System.Windows.Forms.TextBox textBoxNesValue;
        private System.Windows.Forms.TextBox textBoxNesAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNesCode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonGbGgDecode;
        private System.Windows.Forms.Button buttonGbGgEncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGbGgCheckByteCompare;
        private System.Windows.Forms.TextBox textBoxGbGgValue;
        private System.Windows.Forms.TextBox textBoxGbGgAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGbGgCode;
        private System.Windows.Forms.Button buttonSnesDecode;
        private System.Windows.Forms.Button buttonSnesEncode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSnesValue;
        private System.Windows.Forms.TextBox textBoxSnesAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSnesCode;
        private System.Windows.Forms.Button buttonGenMdDecode;
        private System.Windows.Forms.Button buttonGenMdEncode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxGenMdValue;
        private System.Windows.Forms.TextBox textBoxGenMdAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxGenMdCode;
    }
}

