namespace Software_Engineering_Poker
{
    partial class MoneyUI
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
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.computer1Money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.AutoSize = true;
            this.playerMoneyLabel.Location = new System.Drawing.Point(12, 13);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(69, 13);
            this.playerMoneyLabel.TabIndex = 0;
            this.playerMoneyLabel.Text = "player money:";
            this.playerMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.playerMoneyLabel.Click += new System.EventHandler(this.playerMoneyLabel_Click);
            // 
            // computer1Money
            // 
            this.computer1Money.AutoSize = true;
            this.computer1Money.Location = new System.Drawing.Point(12, 48);
            this.computer1Money.Name = "computer1Money";
            this.computer1Money.Size = new System.Drawing.Size(61, 13);
            this.computer1Money.TabIndex = 1;
            this.computer1Money.Text = "PC1 money";
            // 
            // MoneyUI
            // 
            this.Controls.Add(this.computer1Money);
            this.Controls.Add(this.playerMoneyLabel);
            this.Name = "MoneyUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label computer1Money;
    }
}
