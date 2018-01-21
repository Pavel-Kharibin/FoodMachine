namespace FoodMachine.App.Controls
{
    partial class IngredientControl
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.chkIngredient = new System.Windows.Forms.CheckBox();
            this.lblPrice = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(this.numCount);
            flowLayoutPanel1.Controls.Add(this.chkIngredient);
            flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(123, 26);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(3, 3);
            this.numCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(35, 20);
            this.numCount.TabIndex = 0;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkIngredient
            // 
            this.chkIngredient.AutoSize = true;
            this.chkIngredient.Location = new System.Drawing.Point(44, 5);
            this.chkIngredient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkIngredient.Name = "chkIngredient";
            this.chkIngredient.Size = new System.Drawing.Size(76, 17);
            this.chkIngredient.TabIndex = 1;
            this.chkIngredient.Text = "Название";
            this.chkIngredient.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(174, 7);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IngredientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(flowLayoutPanel1);
            this.Name = "IngredientControl";
            this.Size = new System.Drawing.Size(210, 28);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.CheckBox chkIngredient;
    }
}
