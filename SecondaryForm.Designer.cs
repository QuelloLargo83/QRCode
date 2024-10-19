namespace QRCode
{
    partial class SecondaryForm
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
            this.LOGGERdataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LOGlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LOGGERdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LOGGERdataGridView
            // 
            this.LOGGERdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LOGGERdataGridView.Location = new System.Drawing.Point(12, 51);
            this.LOGGERdataGridView.Name = "LOGGERdataGridView";
            this.LOGGERdataGridView.Size = new System.Drawing.Size(776, 426);
            this.LOGGERdataGridView.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 557);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // LOGlbl
            // 
            this.LOGlbl.AutoSize = true;
            this.LOGlbl.Location = new System.Drawing.Point(378, 13);
            this.LOGlbl.Name = "LOGlbl";
            this.LOGlbl.Size = new System.Drawing.Size(52, 13);
            this.LOGlbl.TabIndex = 2;
            this.LOGlbl.Text = "LOGGER";
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 661);
            this.Controls.Add(this.LOGlbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LOGGERdataGridView);
            this.Name = "SecondaryForm";
            this.Text = "Logger";
            ((System.ComponentModel.ISupportInitialize)(this.LOGGERdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LOGGERdataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LOGlbl;
    }
}