namespace FoodMachine.App
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupDrinks;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupFoodIngredients;
            System.Windows.Forms.GroupBox groupFood;
            this.drinksLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDrinks = new System.Windows.Forms.FlowLayoutPanel();
            this.groupDrinksIngrediens = new System.Windows.Forms.GroupBox();
            this.pnlDrinksIngrediens = new System.Windows.Forms.FlowLayoutPanel();
            this.foodLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFoodIngredients = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFood = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnGiveMe = new System.Windows.Forms.Button();
            this.chkComplex = new System.Windows.Forms.CheckBox();
            this.lblComplexPrice = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrice = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupDrinks = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupFoodIngredients = new System.Windows.Forms.GroupBox();
            groupFood = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.drinksLayout.SuspendLayout();
            groupDrinks.SuspendLayout();
            this.groupDrinksIngrediens.SuspendLayout();
            groupBox2.SuspendLayout();
            this.foodLayout.SuspendLayout();
            groupFoodIngredients.SuspendLayout();
            groupFood.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(this.drinksLayout);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(273, 504);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // drinksLayout
            // 
            this.drinksLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinksLayout.ColumnCount = 1;
            this.drinksLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.drinksLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.drinksLayout.Controls.Add(groupDrinks, 0, 0);
            this.drinksLayout.Controls.Add(this.groupDrinksIngrediens, 0, 1);
            this.drinksLayout.Location = new System.Drawing.Point(6, 13);
            this.drinksLayout.Name = "drinksLayout";
            this.drinksLayout.RowCount = 2;
            this.drinksLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.drinksLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.drinksLayout.Size = new System.Drawing.Size(261, 485);
            this.drinksLayout.TabIndex = 0;
            // 
            // groupDrinks
            // 
            groupDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupDrinks.AutoSize = true;
            groupDrinks.Controls.Add(this.pnlDrinks);
            groupDrinks.Location = new System.Drawing.Point(3, 3);
            groupDrinks.Name = "groupDrinks";
            groupDrinks.Size = new System.Drawing.Size(255, 236);
            groupDrinks.TabIndex = 0;
            groupDrinks.TabStop = false;
            groupDrinks.Text = "Напитки";
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrinks.AutoSize = true;
            this.pnlDrinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlDrinks.Location = new System.Drawing.Point(6, 19);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(243, 206);
            this.pnlDrinks.TabIndex = 0;
            // 
            // groupDrinksIngrediens
            // 
            this.groupDrinksIngrediens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDrinksIngrediens.AutoSize = true;
            this.groupDrinksIngrediens.Controls.Add(this.pnlDrinksIngrediens);
            this.groupDrinksIngrediens.Location = new System.Drawing.Point(3, 245);
            this.groupDrinksIngrediens.Name = "groupDrinksIngrediens";
            this.groupDrinksIngrediens.Size = new System.Drawing.Size(255, 237);
            this.groupDrinksIngrediens.TabIndex = 1;
            this.groupDrinksIngrediens.TabStop = false;
            this.groupDrinksIngrediens.Text = "Добавки к напиткам";
            // 
            // pnlDrinksIngrediens
            // 
            this.pnlDrinksIngrediens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrinksIngrediens.AutoSize = true;
            this.pnlDrinksIngrediens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlDrinksIngrediens.Location = new System.Drawing.Point(6, 13);
            this.pnlDrinksIngrediens.Name = "pnlDrinksIngrediens";
            this.pnlDrinksIngrediens.Size = new System.Drawing.Size(243, 218);
            this.pnlDrinksIngrediens.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.foodLayout);
            groupBox2.Location = new System.Drawing.Point(282, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(273, 504);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // foodLayout
            // 
            this.foodLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodLayout.ColumnCount = 1;
            this.foodLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.foodLayout.Controls.Add(groupFood, 0, 0);
            this.foodLayout.Controls.Add(groupFoodIngredients, 0, 1);
            this.foodLayout.Location = new System.Drawing.Point(7, 13);
            this.foodLayout.Name = "foodLayout";
            this.foodLayout.RowCount = 2;
            this.foodLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.foodLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foodLayout.Size = new System.Drawing.Size(260, 485);
            this.foodLayout.TabIndex = 1;
            // 
            // groupFoodIngredients
            // 
            groupFoodIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupFoodIngredients.Controls.Add(this.pnlFoodIngredients);
            groupFoodIngredients.Location = new System.Drawing.Point(3, 245);
            groupFoodIngredients.Name = "groupFoodIngredients";
            groupFoodIngredients.Size = new System.Drawing.Size(254, 237);
            groupFoodIngredients.TabIndex = 2;
            groupFoodIngredients.TabStop = false;
            groupFoodIngredients.Text = "Добавки к еде";
            // 
            // pnlFoodIngredients
            // 
            this.pnlFoodIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFoodIngredients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFoodIngredients.Location = new System.Drawing.Point(6, 13);
            this.pnlFoodIngredients.Name = "pnlFoodIngredients";
            this.pnlFoodIngredients.Size = new System.Drawing.Size(243, 218);
            this.pnlFoodIngredients.TabIndex = 1;
            // 
            // groupFood
            // 
            groupFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupFood.AutoSize = true;
            groupFood.Controls.Add(this.pnlFood);
            groupFood.Location = new System.Drawing.Point(3, 3);
            groupFood.Name = "groupFood";
            groupFood.Size = new System.Drawing.Size(254, 236);
            groupFood.TabIndex = 1;
            groupFood.TabStop = false;
            groupFood.Text = "Еда";
            // 
            // pnlFood
            // 
            this.pnlFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFood.AutoSize = true;
            this.pnlFood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFood.Location = new System.Drawing.Point(6, 19);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(243, 206);
            this.pnlFood.TabIndex = 1;
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(groupBox1, 0, 0);
            this.mainLayout.Controls.Add(groupBox2, 1, 0);
            this.mainLayout.Location = new System.Drawing.Point(8, 8);
            this.mainLayout.MinimumSize = new System.Drawing.Size(440, 440);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.Size = new System.Drawing.Size(558, 510);
            this.mainLayout.TabIndex = 0;
            // 
            // btnGiveMe
            // 
            this.btnGiveMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiveMe.Location = new System.Drawing.Point(481, 590);
            this.btnGiveMe.Name = "btnGiveMe";
            this.btnGiveMe.Size = new System.Drawing.Size(75, 23);
            this.btnGiveMe.TabIndex = 1;
            this.btnGiveMe.Text = "Выдать";
            this.btnGiveMe.UseVisualStyleBackColor = true;
            // 
            // chkComplex
            // 
            this.chkComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkComplex.AutoSize = true;
            this.chkComplex.Location = new System.Drawing.Point(8, 543);
            this.chkComplex.Name = "chkComplex";
            this.chkComplex.Size = new System.Drawing.Size(345, 17);
            this.chkComplex.TabIndex = 1;
            this.chkComplex.Text = "Комплекс (1 нариток с добавкой + 1 еда с добавкой на выбор)";
            this.chkComplex.UseVisualStyleBackColor = true;
            // 
            // lblComplexPrice
            // 
            this.lblComplexPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplexPrice.AutoSize = true;
            this.lblComplexPrice.Location = new System.Drawing.Point(541, 544);
            this.lblComplexPrice.Name = "lblComplexPrice";
            this.lblComplexPrice.Size = new System.Drawing.Size(25, 13);
            this.lblComplexPrice.TabIndex = 2;
            this.lblComplexPrice.Text = "100";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 595);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Стоимость:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 621);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblComplexPrice);
            this.Controls.Add(this.btnGiveMe);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.chkComplex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Апарат с едой";
            groupBox1.ResumeLayout(false);
            this.drinksLayout.ResumeLayout(false);
            this.drinksLayout.PerformLayout();
            groupDrinks.ResumeLayout(false);
            groupDrinks.PerformLayout();
            this.groupDrinksIngrediens.ResumeLayout(false);
            this.groupDrinksIngrediens.PerformLayout();
            groupBox2.ResumeLayout(false);
            this.foodLayout.ResumeLayout(false);
            this.foodLayout.PerformLayout();
            groupFoodIngredients.ResumeLayout(false);
            groupFood.ResumeLayout(false);
            groupFood.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel drinksLayout;
        private System.Windows.Forms.TableLayoutPanel foodLayout;
        private System.Windows.Forms.Button btnGiveMe;
        private System.Windows.Forms.CheckBox chkComplex;
        private System.Windows.Forms.Label lblComplexPrice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.FlowLayoutPanel pnlDrinks;
        private System.Windows.Forms.FlowLayoutPanel pnlDrinksIngrediens;
        private System.Windows.Forms.GroupBox groupDrinksIngrediens;
        private System.Windows.Forms.FlowLayoutPanel pnlFoodIngredients;
        private System.Windows.Forms.FlowLayoutPanel pnlFood;
        private System.Windows.Forms.Label lblPrice;
    }
}

