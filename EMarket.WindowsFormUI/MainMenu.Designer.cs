
namespace EMarket.WindowsFormUI
{
    partial class MainMenu
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
            this.dgwBuyProducts = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.labael = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.cbxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.nudProductCount = new System.Windows.Forms.NumericUpDown();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBuyProducts
            // 
            this.dgwBuyProducts.AllowUserToAddRows = false;
            this.dgwBuyProducts.AllowUserToDeleteRows = false;
            this.dgwBuyProducts.AllowUserToResizeColumns = false;
            this.dgwBuyProducts.AllowUserToResizeRows = false;
            this.dgwBuyProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBuyProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBuyProducts.Location = new System.Drawing.Point(12, 60);
            this.dgwBuyProducts.Name = "dgwBuyProducts";
            this.dgwBuyProducts.Size = new System.Drawing.Size(760, 150);
            this.dgwBuyProducts.TabIndex = 0;
            this.dgwBuyProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBuyProducts_CellClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(653, 216);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 40);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgwCart
            // 
            this.dgwCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(12, 262);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.Size = new System.Drawing.Size(760, 150);
            this.dgwCart.TabIndex = 2;
            this.dgwCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCart_CellClick);
            // 
            // labael
            // 
            this.labael.AutoSize = true;
            this.labael.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labael.Location = new System.Drawing.Point(12, 415);
            this.labael.Name = "labael";
            this.labael.Size = new System.Drawing.Size(147, 26);
            this.labael.TabIndex = 3;
            this.labael.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(165, 415);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(54, 26);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "0.00";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(497, 7);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(114, 17);
            this.lblSearchByName.TabIndex = 5;
            this.lblSearchByName.Text = "Search By Name";
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByCategory.Location = new System.Drawing.Point(497, 40);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(134, 17);
            this.lblSearchByCategory.TabIndex = 6;
            this.lblSearchByCategory.Text = "Search By Category";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(651, 6);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(119, 20);
            this.tbxSearchByName.TabIndex = 7;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSearchByCategory
            // 
            this.cbxSearchByCategory.FormattingEnabled = true;
            this.cbxSearchByCategory.Location = new System.Drawing.Point(651, 39);
            this.cbxSearchByCategory.Name = "cbxSearchByCategory";
            this.cbxSearchByCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchByCategory.TabIndex = 8;
            this.cbxSearchByCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByCategory_SelectedIndexChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(777, 262);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(111, 34);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOne.Location = new System.Drawing.Point(777, 302);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(110, 28);
            this.btnDeleteOne.TabIndex = 10;
            this.btnDeleteOne.Text = "Delete One";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // nudProductCount
            // 
            this.nudProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProductCount.Location = new System.Drawing.Point(584, 229);
            this.nudProductCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductCount.Name = "nudProductCount";
            this.nudProductCount.ReadOnly = true;
            this.nudProductCount.Size = new System.Drawing.Size(37, 26);
            this.nudProductCount.TabIndex = 11;
            this.nudProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(778, 367);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(109, 26);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(779, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 25);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProducts.Location = new System.Drawing.Point(780, 93);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(108, 54);
            this.btnUpdateProducts.TabIndex = 14;
            this.btnUpdateProducts.Text = "Update Products";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnUpdateProducts);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.nudProductCount);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.cbxSearchByCategory);
            this.Controls.Add(this.tbxSearchByName);
            this.Controls.Add(this.lblSearchByCategory);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.labael);
            this.Controls.Add(this.dgwCart);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.dgwBuyProducts);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBuyProducts;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgwCart;
        private System.Windows.Forms.Label labael;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchByCategory;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.ComboBox cbxSearchByCategory;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.NumericUpDown nudProductCount;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateProducts;
    }
}

