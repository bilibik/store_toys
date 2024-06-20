namespace store_toys
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonToys = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(834, 581);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // buttonUser
            // 
            this.buttonUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUser.Location = new System.Drawing.Point(92, 233);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(153, 48);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "Пользователи";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonToys
            // 
            this.buttonToys.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToys.Location = new System.Drawing.Point(348, 233);
            this.buttonToys.Name = "buttonToys";
            this.buttonToys.Size = new System.Drawing.Size(153, 48);
            this.buttonToys.TabIndex = 4;
            this.buttonToys.Text = "Игрушки";
            this.buttonToys.UseVisualStyleBackColor = true;
            this.buttonToys.Click += new System.EventHandler(this.buttonToys_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(588, 233);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(153, 48);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "Заявки";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Личный кабинет администатора";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonToys);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonToys;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label1;
    }
}