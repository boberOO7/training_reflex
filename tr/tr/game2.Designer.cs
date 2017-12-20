namespace vas9dayn
{
    partial class game2
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
            this.target = new System.Windows.Forms.Button();
            this.copyTarget = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(209, 269);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(182, 119);
            this.target.TabIndex = 0;
            this.target.Text = "button1";
            this.target.UseVisualStyleBackColor = true;
            this.target.Click += new System.EventHandler(this.target_Click);
            // 
            // copyTarget
            // 
            this.copyTarget.Location = new System.Drawing.Point(209, 269);
            this.copyTarget.Name = "copyTarget";
            this.copyTarget.Size = new System.Drawing.Size(184, 119);
            this.copyTarget.TabIndex = 1;
            this.copyTarget.Text = "button2";
            this.copyTarget.UseVisualStyleBackColor = true;
            this.copyTarget.Visible = false;
            this.copyTarget.Click += new System.EventHandler(this.copyTarget_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 2;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(260, 453);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(75, 23);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.copyTarget);
            this.Controls.Add(this.target);
            this.Name = "game2";
            this.Text = "game2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button target;
        private System.Windows.Forms.Button copyTarget;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mainMenu;
    }
}