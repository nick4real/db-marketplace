namespace Amafun.Forms
{
    partial class FormMyAds
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
            this.dgvEnd = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnd
            // 
            this.dgvEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnd.Location = new System.Drawing.Point(12, 12);
            this.dgvEnd.Name = "dgvEnd";
            this.dgvEnd.RowTemplate.Height = 25;
            this.dgvEnd.Size = new System.Drawing.Size(636, 329);
            this.dgvEnd.TabIndex = 0;
            this.dgvEnd.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEnd_CellMouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(12, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInactive.Location = new System.Drawing.Point(242, 347);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(177, 23);
            this.btnInactive.TabIndex = 8;
            this.btnInactive.Text = "Деактивировать";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.Location = new System.Drawing.Point(471, 347);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(177, 23);
            this.btnActive.TabIndex = 9;
            this.btnActive.Text = "Активировать";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // FormMyAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 377);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvEnd);
            this.MinimumSize = new System.Drawing.Size(676, 416);
            this.Name = "FormMyAds";
            this.Text = "Мои объявления";
            this.Load += new System.EventHandler(this.FormEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.Button btnActive;
    }
}