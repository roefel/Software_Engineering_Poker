namespace Software_Engineering_Poker
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

        #region Windows Form Designer generated code and component initialisations

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Name = "PC Poker";
            this.Text = "PC Poker";
            this.ResumeLayout(false);

            //create new instance of ButtonContainers
            ButtonContainerController buttonContainer = new ButtonContainerController();

            //Add ButtonContainer view to form
            this.Controls.Add(buttonContainer.view);

            //Create new instance of table

            TableContainerController tableContainer = new TableContainerController();

            //Create new instance of MoneyUI
            MoneyController money = new MoneyController();

            //Add table view to form
            this.Controls.Add(tableContainer.view);
            this.Controls.Add(money.view);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            money.view.Left = 30;
            money.view.Top = 30;
            buttonContainer.view.Top = tableContainer.view.Height + 30;
            buttonContainer.view.Left = money.view.Width + 32;
            tableContainer.view.Left = money.view.Width + 20;
            tableContainer.view.Top = money.view.Top;
        }

        #endregion
    }
}

