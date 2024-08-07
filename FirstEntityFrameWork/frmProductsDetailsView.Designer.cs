namespace FirstEntityFrameWork
{
    partial class frmProductsDetailsView
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
            lblProductID = new Label();
            txtProductName = new TextBox();
            numPrice = new NumericUpDown();
            btnNext = new Button();
            btnBack = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(156, 54);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(78, 20);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "Product ID:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(156, 86);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(156, 129);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(304, 225);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(156, 225);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(156, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmProductsDetailsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(numPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductID);
            Name = "frmProductsDetailsView";
            Text = "Product Details";
            Load += frmProductsDetailsView_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductID;
        private TextBox txtProductName;
        private NumericUpDown numPrice;
        private Button btnNext;
        private Button btnBack;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
