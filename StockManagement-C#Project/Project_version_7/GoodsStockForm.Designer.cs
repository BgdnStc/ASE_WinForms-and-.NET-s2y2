namespace Project_version_7
{
    partial class GoodsStockForm
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
            this.lvGoods = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudSupplierId = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStockofGoods = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSupplierId)).BeginInit();
            this.SuspendLayout();
            // 
            // lvGoods
            // 
            this.lvGoods.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvGoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvGoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderQuantity,
            this.columnHeaderSupplier});
            this.lvGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGoods.FullRowSelect = true;
            this.lvGoods.GridLines = true;
            this.lvGoods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGoods.HideSelection = false;
            this.lvGoods.LabelEdit = true;
            this.lvGoods.Location = new System.Drawing.Point(13, 44);
            this.lvGoods.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvGoods.Name = "lvGoods";
            this.lvGoods.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvGoods.Size = new System.Drawing.Size(695, 383);
            this.lvGoods.TabIndex = 0;
            this.lvGoods.UseCompatibleStateImageBehavior = false;
            this.lvGoods.View = System.Windows.Forms.View.Details;
            this.lvGoods.SelectedIndexChanged += new System.EventHandler(this.lvGoods_SelectedIndexChanged);
            this.lvGoods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvGoods_MouseDoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 26;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Good";
            this.columnHeaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderName.Width = 180;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQuantity.Width = 107;
            // 
            // columnHeaderSupplier
            // 
            this.columnHeaderSupplier.Text = "Supplier";
            this.columnHeaderSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSupplier.Width = 237;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(765, 448);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(716, 64);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(134, 24);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Name";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(716, 158);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(135, 24);
            this.nudQuantity.TabIndex = 5;
            // 
            // nudSupplierId
            // 
            this.nudSupplierId.Location = new System.Drawing.Point(716, 263);
            this.nudSupplierId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudSupplierId.Name = "nudSupplierId";
            this.nudSupplierId.Size = new System.Drawing.Size(135, 24);
            this.nudSupplierId.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 448);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStockofGoods
            // 
            this.lblStockofGoods.AutoSize = true;
            this.lblStockofGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockofGoods.Location = new System.Drawing.Point(14, 10);
            this.lblStockofGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockofGoods.Name = "lblStockofGoods";
            this.lblStockofGoods.Size = new System.Drawing.Size(215, 32);
            this.lblStockofGoods.TabIndex = 8;
            this.lblStockofGoods.Text = "Stock of Goods:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Data:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(622, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GoodsStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockofGoods);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nudSupplierId);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvGoods);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "GoodsStockForm";
            this.RightToLeftLayout = true;
            this.Text = "GoodsStockForm";
            this.Load += new System.EventHandler(this.GoodsStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSupplierId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudSupplierId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStockofGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderSupplier;
        private System.Windows.Forms.Button btnUpdate;
    }
}