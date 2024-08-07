namespace FirstEntityFrameWork
{
    partial class ClosedConnection
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
            lstProducts = new ListBox();
            btnExecute = new Button();
            grdViewProducts = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)grdViewProducts).BeginInit();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(910, 23);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(234, 384);
            lstProducts.TabIndex = 0;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(992, 437);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(94, 29);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // grdViewProducts
            // 
            grdViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViewProducts.Location = new Point(74, 34);
            grdViewProducts.Name = "grdViewProducts";
            grdViewProducts.RowHeadersWidth = 51;
            grdViewProducts.Size = new Size(747, 373);
            grdViewProducts.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(97, 449);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ClosedConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 509);
            Controls.Add(btnSave);
            Controls.Add(grdViewProducts);
            Controls.Add(btnExecute);
            Controls.Add(lstProducts);
            Name = "ClosedConnection";
            Text = "ClosedConnection";
            Load += ClosedConnection_Load;
            ((System.ComponentModel.ISupportInitialize)grdViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button btnExecute;
        private DataGridView grdViewProducts;
        private Button btnSave;
    }
}