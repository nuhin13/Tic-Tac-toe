namespace AI
{
    partial class Form1
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
            this.Board00 = new System.Windows.Forms.Button();
            this.Board10 = new System.Windows.Forms.Button();
            this.Board20 = new System.Windows.Forms.Button();
            this.Board21 = new System.Windows.Forms.Button();
            this.Board11 = new System.Windows.Forms.Button();
            this.Board01 = new System.Windows.Forms.Button();
            this.Board22 = new System.Windows.Forms.Button();
            this.Board12 = new System.Windows.Forms.Button();
            this.Board02 = new System.Windows.Forms.Button();
            this.via_players = new System.Windows.Forms.Button();
            this.via_computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Board00
            // 
            this.Board00.Location = new System.Drawing.Point(46, 155);
            this.Board00.Name = "Board00";
            this.Board00.Size = new System.Drawing.Size(89, 44);
            this.Board00.TabIndex = 0;
            this.Board00.UseVisualStyleBackColor = true;
            this.Board00.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board10
            // 
            this.Board10.Location = new System.Drawing.Point(46, 205);
            this.Board10.Name = "Board10";
            this.Board10.Size = new System.Drawing.Size(89, 44);
            this.Board10.TabIndex = 1;
            this.Board10.UseVisualStyleBackColor = true;
            this.Board10.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board20
            // 
            this.Board20.Location = new System.Drawing.Point(46, 255);
            this.Board20.Name = "Board20";
            this.Board20.Size = new System.Drawing.Size(89, 44);
            this.Board20.TabIndex = 2;
            this.Board20.UseVisualStyleBackColor = true;
            this.Board20.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board21
            // 
            this.Board21.Location = new System.Drawing.Point(156, 255);
            this.Board21.Name = "Board21";
            this.Board21.Size = new System.Drawing.Size(89, 44);
            this.Board21.TabIndex = 5;
            this.Board21.UseVisualStyleBackColor = true;
            this.Board21.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board11
            // 
            this.Board11.Location = new System.Drawing.Point(156, 205);
            this.Board11.Name = "Board11";
            this.Board11.Size = new System.Drawing.Size(89, 44);
            this.Board11.TabIndex = 4;
            this.Board11.UseVisualStyleBackColor = true;
            this.Board11.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board01
            // 
            this.Board01.Location = new System.Drawing.Point(156, 155);
            this.Board01.Name = "Board01";
            this.Board01.Size = new System.Drawing.Size(89, 44);
            this.Board01.TabIndex = 3;
            this.Board01.UseVisualStyleBackColor = true;
            this.Board01.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board22
            // 
            this.Board22.Location = new System.Drawing.Point(265, 255);
            this.Board22.Name = "Board22";
            this.Board22.Size = new System.Drawing.Size(89, 44);
            this.Board22.TabIndex = 8;
            this.Board22.UseVisualStyleBackColor = true;
            this.Board22.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board12
            // 
            this.Board12.Location = new System.Drawing.Point(265, 205);
            this.Board12.Name = "Board12";
            this.Board12.Size = new System.Drawing.Size(89, 44);
            this.Board12.TabIndex = 7;
            this.Board12.UseVisualStyleBackColor = true;
            this.Board12.Click += new System.EventHandler(this.ClickingButton);
            // 
            // Board02
            // 
            this.Board02.Location = new System.Drawing.Point(265, 155);
            this.Board02.Name = "Board02";
            this.Board02.Size = new System.Drawing.Size(89, 44);
            this.Board02.TabIndex = 6;
            this.Board02.UseVisualStyleBackColor = true;
            this.Board02.Click += new System.EventHandler(this.ClickingButton);
            // 
            // via_players
            // 
            this.via_players.Location = new System.Drawing.Point(46, 43);
            this.via_players.Name = "via_players";
            this.via_players.Size = new System.Drawing.Size(308, 38);
            this.via_players.TabIndex = 9;
            this.via_players.Text = "2 Players";
            this.via_players.UseVisualStyleBackColor = true;
            this.via_players.Click += new System.EventHandler(this.via_players_Click);
            // 
            // via_computer
            // 
            this.via_computer.Location = new System.Drawing.Point(46, 96);
            this.via_computer.Name = "via_computer";
            this.via_computer.Size = new System.Drawing.Size(308, 36);
            this.via_computer.TabIndex = 10;
            this.via_computer.Text = "Player vs Computer";
            this.via_computer.UseVisualStyleBackColor = true;
            this.via_computer.Click += new System.EventHandler(this.via_computer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 340);
            this.Controls.Add(this.via_computer);
            this.Controls.Add(this.via_players);
            this.Controls.Add(this.Board22);
            this.Controls.Add(this.Board12);
            this.Controls.Add(this.Board02);
            this.Controls.Add(this.Board21);
            this.Controls.Add(this.Board11);
            this.Controls.Add(this.Board01);
            this.Controls.Add(this.Board20);
            this.Controls.Add(this.Board10);
            this.Controls.Add(this.Board00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Board00;
        private System.Windows.Forms.Button Board10;
        private System.Windows.Forms.Button Board20;
        private System.Windows.Forms.Button Board21;
        private System.Windows.Forms.Button Board11;
        private System.Windows.Forms.Button Board01;
        private System.Windows.Forms.Button Board22;
        private System.Windows.Forms.Button Board12;
        private System.Windows.Forms.Button Board02;
        private System.Windows.Forms.Button via_players;
        private System.Windows.Forms.Button via_computer;
    }
}

