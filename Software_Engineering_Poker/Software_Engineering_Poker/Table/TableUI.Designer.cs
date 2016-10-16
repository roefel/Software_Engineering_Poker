namespace Software_Engineering_Poker.Table
{
    partial class TableUI
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
            this.tableBox = new System.Windows.Forms.GroupBox();
            this.computer1Card1 = new System.Windows.Forms.PictureBox();
            this.computer1Card2 = new System.Windows.Forms.PictureBox();
            this.tableMoneyCircle = new System.Windows.Forms.PictureBox();
            this.tableMoneyValue = new System.Windows.Forms.Label();
            this.tableBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBox
            // 
            this.tableBox.BackgroundImage = global::Software_Engineering_Poker.Properties.Resources.poker_table;
            this.tableBox.Controls.Add(this.tableMoneyValue);
            this.tableBox.Controls.Add(this.tableMoneyCircle);
            this.tableBox.Controls.Add(this.computer1Card2);
            this.tableBox.Controls.Add(this.computer1Card1);
            this.tableBox.Location = new System.Drawing.Point(15, 16);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(943, 376);
            this.tableBox.TabIndex = 0;
            this.tableBox.TabStop = false;
            // 
            // computer1Card1
            // 
            this.computer1Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.computer1Card1.Location = new System.Drawing.Point(18, 19);
            this.computer1Card1.Name = "computer1Card1";
            this.computer1Card1.Size = new System.Drawing.Size(65, 80);
            this.computer1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.computer1Card1.TabIndex = 0;
            this.computer1Card1.TabStop = false;
            // 
            // computer1Card2
            // 
            this.computer1Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.computer1Card2.ImageLocation = "Software_Engineering_Poker\\images\\cards\\hart-2.png";
            this.computer1Card2.Location = new System.Drawing.Point(89, 19);
            this.computer1Card2.Name = "computer1Card2";
            this.computer1Card2.Size = new System.Drawing.Size(65, 80);
            this.computer1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.computer1Card2.TabIndex = 3;
            this.computer1Card2.TabStop = false;
            // 
            // tableMoneyCircle
            // 
            this.tableMoneyCircle.ImageLocation = "Software_Engineering_Poker\\images\\assets\\circle.png";
            this.tableMoneyCircle.Location = new System.Drawing.Point(373, 119);
            this.tableMoneyCircle.Name = "tableMoneyCircle";
            this.tableMoneyCircle.Size = new System.Drawing.Size(209, 133);
            this.tableMoneyCircle.TabIndex = 4;
            this.tableMoneyCircle.TabStop = false;
            // 
            // tableMoneyValue
            // 
            this.tableMoneyValue.AutoSize = true;
            this.tableMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableMoneyValue.Location = new System.Drawing.Point(434, 169);
            this.tableMoneyValue.Name = "tableMoneyValue";
            this.tableMoneyValue.Size = new System.Drawing.Size(89, 31);
            this.tableMoneyValue.TabIndex = 5;
            this.tableMoneyValue.Text = "1000$";
            // 
            // TableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableBox);
            this.Name = "TableUI";
            this.Size = new System.Drawing.Size(975, 408);
            this.tableBox.ResumeLayout(false);
            this.tableBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyCircle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tableBox;
        private System.Windows.Forms.PictureBox computer1Card1;
        private System.Windows.Forms.PictureBox computer1Card2;
        private System.Windows.Forms.PictureBox tableMoneyCircle;
        private System.Windows.Forms.Label tableMoneyValue;
    }
}
