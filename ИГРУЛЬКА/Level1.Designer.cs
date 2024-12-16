namespace ИГРУЛЬКА
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.restart_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.next_to_second_level = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(303, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 95);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(146, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 95);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "2";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(303, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 95);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "3";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Image = global::ИГРУЛЬКА.Properties.Resources._03988c77_4bba_4288_a332_ea036f90506b4;
            this.textScore.Location = new System.Drawing.Point(550, 29);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(103, 19);
            this.textScore.TabIndex = 19;
            this.textScore.Text = "Total steps:";
            // 
            // scoreOutput
            // 
            this.scoreOutput.AutoSize = true;
            this.scoreOutput.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.Image = global::ИГРУЛЬКА.Properties.Resources._03988c77_4bba_4288_a332_ea036f90506b4;
            this.scoreOutput.Location = new System.Drawing.Point(589, 58);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(26, 27);
            this.scoreOutput.TabIndex = 20;
            this.scoreOutput.Text = "0";
            // 
            // restart_button
            // 
            this.restart_button.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart_button.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_button.Location = new System.Drawing.Point(529, 117);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(154, 50);
            this.restart_button.TabIndex = 21;
            this.restart_button.Text = "Restart";
            this.restart_button.UseVisualStyleBackColor = false;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // next_to_second_level
            // 
            this.next_to_second_level.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.next_to_second_level.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_to_second_level.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_to_second_level.Location = new System.Drawing.Point(529, 173);
            this.next_to_second_level.Name = "next_to_second_level";
            this.next_to_second_level.Size = new System.Drawing.Size(154, 50);
            this.next_to_second_level.TabIndex = 22;
            this.next_to_second_level.Text = "Next to second level";
            this.next_to_second_level.UseVisualStyleBackColor = false;
            this.next_to_second_level.Click += new System.EventHandler(this.next_to_second_level_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4e08297b6d8adc63e2a27203f80dcd09.jpg");
            this.imageList1.Images.SetKeyName(1, "19be898a68691ecdad22953683b2b238.jpg");
            this.imageList1.Images.SetKeyName(2, "02049182be0f21d5f23b49ed6c4a39cb.jpg");
            this.imageList1.Images.SetKeyName(3, "ad20e2d78c71e7b18dde96a679e61960.jpg");
            this.imageList1.Images.SetKeyName(4, "d3be19302851e3434371adb9f666b457.jpg");
            this.imageList1.Images.SetKeyName(5, "d9e35f674b74e60e87218637cf94db0b.jpg");
            this.imageList1.Images.SetKeyName(6, "e4c680ceb377e824ca96601da07245e3.jpg");
            this.imageList1.Images.SetKeyName(7, "ee5d5515e2070af88b5673a9d4b9778a.jpg");
            this.imageList1.Images.SetKeyName(8, "OneGreenPanel.png");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ИГРУЛЬКА.Properties.Resources._03988c77_4bba_4288_a332_ea036f90506b4;
            this.label2.Location = new System.Drawing.Point(244, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "Level 1";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИГРУЛЬКА.Properties.Resources._03988c77_4bba_4288_a332_ea036f90506b4;
            this.ClientSize = new System.Drawing.Size(718, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next_to_second_level);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level1";
            this.Text = "Котики-фруктики";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing);
            this.Load += new System.EventHandler(this.Level1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button next_to_second_level;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
    }
}