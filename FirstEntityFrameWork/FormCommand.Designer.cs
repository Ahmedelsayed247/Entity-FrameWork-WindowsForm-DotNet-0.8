namespace FirstEntityFrameWork
{
    partial class FormCommand
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
            btnExecute = new Button();
            label1 = new Label();
            cmbProductIDs = new ComboBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(694, 409);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(94, 29);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "product ids : ";
            // 
            // cmbProductIDs
            // 
            cmbProductIDs.FormattingEnabled = true;
            cmbProductIDs.Location = new Point(228, 69);
            cmbProductIDs.Name = "cmbProductIDs";
            cmbProductIDs.Size = new Size(151, 28);
            cmbProductIDs.TabIndex = 2;
            // 
            // FormCommand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbProductIDs);
            Controls.Add(label1);
            Controls.Add(btnExecute);
            Name = "FormCommand";
            Text = "FormCommand";
            Load += FormCommand_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private Label label1;
        private ComboBox cmbProductIDs;
    }
}