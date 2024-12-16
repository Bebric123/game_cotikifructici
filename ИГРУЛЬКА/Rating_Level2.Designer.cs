namespace ИГРУЛЬКА
{
    partial class Rating_Level2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating_Level2));
            this.ratingTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ratingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingTable
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.ratingTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ratingTable.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.ratingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingTable.Location = new System.Drawing.Point(204, 12);
            this.ratingTable.Name = "ratingTable";
            this.ratingTable.ReadOnly = true;
            this.ratingTable.Size = new System.Drawing.Size(381, 426);
            this.ratingTable.TabIndex = 0;
            this.ratingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ratingTable_CellContentClick);
            // 
            // Rating_Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИГРУЛЬКА.Properties.Resources._03988c77_4bba_4288_a332_ea036f90506b4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rating_Level2";
            this.Text = "Rating_Level2";
            this.Load += new System.EventHandler(this.Rating_Level2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ratingTable;
    }
}