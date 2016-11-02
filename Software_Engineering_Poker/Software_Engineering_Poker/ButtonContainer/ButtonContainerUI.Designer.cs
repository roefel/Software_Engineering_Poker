namespace Software_Engineering_Poker
{
    partial class ButtonContainerUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.raiseBtn = new System.Windows.Forms.Button();
            this.foldBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.raiseBidTxtBox = new System.Windows.Forms.TextBox();
            this.callBtn = new System.Windows.Forms.Button();
            this.raiseBidLabel = new System.Windows.Forms.Label();
            this.unlockBtnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raiseBtn
            // 
            this.raiseBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.raiseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.raiseBtn.Location = new System.Drawing.Point(0, 0);
            this.raiseBtn.Name = "raiseBtn";
            this.raiseBtn.Size = new System.Drawing.Size(150, 59);
            this.raiseBtn.TabIndex = 0;
            this.raiseBtn.Text = "Raise";
            this.raiseBtn.UseVisualStyleBackColor = false;
            this.raiseBtn.Click += new System.EventHandler(this.raiseBtn_Click);
            // 
            // foldBtn
            // 
            this.foldBtn.BackColor = System.Drawing.Color.Red;
            this.foldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.foldBtn.Location = new System.Drawing.Point(380, 0);
            this.foldBtn.Name = "foldBtn";
            this.foldBtn.Size = new System.Drawing.Size(150, 59);
            this.foldBtn.TabIndex = 7;
            this.foldBtn.Text = "Fold";
            this.foldBtn.UseVisualStyleBackColor = false;
            this.foldBtn.Click += new System.EventHandler(this.foldBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.allBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.allBtn.Location = new System.Drawing.Point(570, 0);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(205, 117);
            this.allBtn.TabIndex = 8;
            this.allBtn.Text = "All-In";
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // raiseBidTxtBox
            // 
            this.raiseBidTxtBox.Location = new System.Drawing.Point(86, 74);
            this.raiseBidTxtBox.Name = "raiseBidTxtBox";
            this.raiseBidTxtBox.Size = new System.Drawing.Size(63, 20);
            this.raiseBidTxtBox.TabIndex = 9;
            this.raiseBidTxtBox.Text = "0";
            this.raiseBidTxtBox.TextChanged += new System.EventHandler(this.raiseBidTxtBox_TextChanged);
            // 
            // callBtn
            // 
            this.callBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.callBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.callBtn.Location = new System.Drawing.Point(190, 0);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(150, 59);
            this.callBtn.TabIndex = 10;
            this.callBtn.Text = "Call";
            this.callBtn.UseVisualStyleBackColor = false;
            this.callBtn.Click += new System.EventHandler(this.callBtn_Click);
            // 
            // raiseBidLabel
            // 
            this.raiseBidLabel.AutoSize = true;
            this.raiseBidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.raiseBidLabel.Location = new System.Drawing.Point(3, 74);
            this.raiseBidLabel.Name = "raiseBidLabel";
            this.raiseBidLabel.Size = new System.Drawing.Size(81, 20);
            this.raiseBidLabel.TabIndex = 11;
            this.raiseBidLabel.Text = "Raise Bid:";
            this.raiseBidLabel.Click += new System.EventHandler(this.raiseBidLabel_Click);
            // 
            // unlockBtnTest
            // 
            this.unlockBtnTest.Location = new System.Drawing.Point(262, 74);
            this.unlockBtnTest.Name = "unlockBtnTest";
            this.unlockBtnTest.Size = new System.Drawing.Size(135, 40);
            this.unlockBtnTest.TabIndex = 12;
            this.unlockBtnTest.Text = "Temporary unlockBtnTest";
            this.unlockBtnTest.UseVisualStyleBackColor = true;
            this.unlockBtnTest.Click += new System.EventHandler(this.unlockBtnTest_Click);
            // 
            // ButtonContainerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unlockBtnTest);
            this.Controls.Add(this.raiseBidLabel);
            this.Controls.Add(this.callBtn);
            this.Controls.Add(this.raiseBidTxtBox);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.foldBtn);
            this.Controls.Add(this.raiseBtn);
            this.Name = "ButtonContainerUI";
            this.Size = new System.Drawing.Size(776, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button raiseBtn;
        public System.Windows.Forms.Button foldBtn;
        public System.Windows.Forms.Button allBtn;
        public System.Windows.Forms.TextBox raiseBidTxtBox;
        public System.Windows.Forms.Button callBtn;
        public System.Windows.Forms.Label raiseBidLabel;
        public System.Windows.Forms.Button unlockBtnTest;
    }
}
