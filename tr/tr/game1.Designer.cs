namespace vas9dayn
{
    partial class game1
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
            this.target1 = new System.Windows.Forms.PictureBox();
            this.target3 = new System.Windows.Forms.PictureBox();
            this.target2 = new System.Windows.Forms.PictureBox();
            this.target4 = new System.Windows.Forms.PictureBox();
            this.target5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target5)).BeginInit();
            this.SuspendLayout();
            // 
            // target1
            // 
            this.target1.BackColor = System.Drawing.Color.Red;
            this.target1.Location = new System.Drawing.Point(32, 131);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(30, 30);
            this.target1.TabIndex = 0;
            this.target1.TabStop = false;
            this.target1.Click += new System.EventHandler(this.target1_Click);
            // 
            // target3
            // 
            this.target3.BackColor = System.Drawing.Color.Red;
            this.target3.Location = new System.Drawing.Point(206, 131);
            this.target3.Name = "target3";
            this.target3.Size = new System.Drawing.Size(30, 30);
            this.target3.TabIndex = 1;
            this.target3.TabStop = false;
            this.target3.Click += new System.EventHandler(this.target3_Click);
            // 
            // target2
            // 
            this.target2.BackColor = System.Drawing.Color.Red;
            this.target2.Location = new System.Drawing.Point(102, 131);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(30, 30);
            this.target2.TabIndex = 2;
            this.target2.TabStop = false;
            this.target2.Click += new System.EventHandler(this.target2_Click);
            // 
            // target4
            // 
            this.target4.BackColor = System.Drawing.Color.Red;
            this.target4.Location = new System.Drawing.Point(309, 131);
            this.target4.Name = "target4";
            this.target4.Size = new System.Drawing.Size(30, 30);
            this.target4.TabIndex = 3;
            this.target4.TabStop = false;
            this.target4.Click += new System.EventHandler(this.target4_Click);
            // 
            // target5
            // 
            this.target5.BackColor = System.Drawing.Color.Red;
            this.target5.Location = new System.Drawing.Point(389, 131);
            this.target5.Name = "target5";
            this.target5.Size = new System.Drawing.Size(30, 30);
            this.target5.TabIndex = 4;
            this.target5.TabStop = false;
            this.target5.Click += new System.EventHandler(this.target5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(228, 240);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(75, 23);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "button1";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Visible = false;
            this.mainMenu.Click += new System.EventHandler(this.menu_Click);
            // 
            // game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.target5);
            this.Controls.Add(this.target4);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.target3);
            this.Controls.Add(this.target1);
            this.Name = "game1";
            this.Text = "game1";
            ((System.ComponentModel.ISupportInitialize)(this.target1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox target1;
        private System.Windows.Forms.PictureBox target3;
        private System.Windows.Forms.PictureBox target2;
        private System.Windows.Forms.PictureBox target4;
        private System.Windows.Forms.PictureBox target5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mainMenu;
    }
}