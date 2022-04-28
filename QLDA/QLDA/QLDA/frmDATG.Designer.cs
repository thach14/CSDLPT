namespace QLDA
{
    partial class frmDATG
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
            this.dgvDATG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDATG
            // 
            this.dgvDATG.AllowUserToAddRows = false;
            this.dgvDATG.AllowUserToDeleteRows = false;
            this.dgvDATG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDATG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDATG.Location = new System.Drawing.Point(0, 0);
            this.dgvDATG.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDATG.MultiSelect = false;
            this.dgvDATG.Name = "dgvDATG";
            this.dgvDATG.ReadOnly = true;
            this.dgvDATG.RowHeadersWidth = 51;
            this.dgvDATG.RowTemplate.Height = 24;
            this.dgvDATG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDATG.Size = new System.Drawing.Size(654, 261);
            this.dgvDATG.TabIndex = 0;
            // 
            // frmDATG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 261);
            this.Controls.Add(this.dgvDATG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "frmDATG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dự án tham gia";
            this.Load += new System.EventHandler(this.frmDATG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDATG;
    }
}