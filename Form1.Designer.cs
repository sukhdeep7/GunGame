namespace GunGame
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.PlayAgainBtn = new System.Windows.Forms.Button();
            this.FireAwayBtn = new System.Windows.Forms.Button();
            this.FireBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Lime;
            this.LoadBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.Blue;
            this.LoadBtn.Location = new System.Drawing.Point(670, 26);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(98, 50);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // PlayAgainBtn
            // 
            this.PlayAgainBtn.BackColor = System.Drawing.Color.Blue;
            this.PlayAgainBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainBtn.ForeColor = System.Drawing.Color.Lime;
            this.PlayAgainBtn.Location = new System.Drawing.Point(670, 312);
            this.PlayAgainBtn.Name = "PlayAgainBtn";
            this.PlayAgainBtn.Size = new System.Drawing.Size(98, 95);
            this.PlayAgainBtn.TabIndex = 1;
            this.PlayAgainBtn.Text = "PLAY AGAIN";
            this.PlayAgainBtn.UseVisualStyleBackColor = false;
            this.PlayAgainBtn.Click += new System.EventHandler(this.PlayAgainBtn_Click);
            // 
            // FireAwayBtn
            // 
            this.FireAwayBtn.BackColor = System.Drawing.Color.Lime;
            this.FireAwayBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireAwayBtn.ForeColor = System.Drawing.Color.Blue;
            this.FireAwayBtn.Location = new System.Drawing.Point(670, 227);
            this.FireAwayBtn.Name = "FireAwayBtn";
            this.FireAwayBtn.Size = new System.Drawing.Size(98, 62);
            this.FireAwayBtn.TabIndex = 2;
            this.FireAwayBtn.Text = "FIRE AWAY";
            this.FireAwayBtn.UseVisualStyleBackColor = false;
            this.FireAwayBtn.Click += new System.EventHandler(this.FireAwayBtn_Click);
            // 
            // FireBtn
            // 
            this.FireBtn.BackColor = System.Drawing.Color.Lime;
            this.FireBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireBtn.ForeColor = System.Drawing.Color.Blue;
            this.FireBtn.Location = new System.Drawing.Point(670, 157);
            this.FireBtn.Name = "FireBtn";
            this.FireBtn.Size = new System.Drawing.Size(98, 51);
            this.FireBtn.TabIndex = 3;
            this.FireBtn.Text = "FIRE";
            this.FireBtn.UseVisualStyleBackColor = false;
            this.FireBtn.Click += new System.EventHandler(this.FireBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.Color.Lime;
            this.SpinBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.ForeColor = System.Drawing.Color.Blue;
            this.SpinBtn.Location = new System.Drawing.Point(670, 92);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(98, 48);
            this.SpinBtn.TabIndex = 4;
            this.SpinBtn.Text = "SPIN";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 426);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.FireBtn);
            this.Controls.Add(this.FireAwayBtn);
            this.Controls.Add(this.PlayAgainBtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button PlayAgainBtn;
        private System.Windows.Forms.Button FireAwayBtn;
        private System.Windows.Forms.Button FireBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

