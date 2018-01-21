namespace FoodMachine.App.Controls
{
    partial class DishControl
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
            this.rdoDish = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoDish
            // 
            this.rdoDish.AutoSize = true;
            this.rdoDish.Location = new System.Drawing.Point(4, 6);
            this.rdoDish.Name = "rdoDish";
            this.rdoDish.Size = new System.Drawing.Size(75, 17);
            this.rdoDish.TabIndex = 0;
            this.rdoDish.Text = "Название";
            this.rdoDish.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(172, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DishControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.rdoDish);
            this.Name = "DishControl";
            this.Size = new System.Drawing.Size(210, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDish;
        private System.Windows.Forms.Label lblPrice;
    }
}
