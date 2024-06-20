namespace store_toys
{
    partial class ResultUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultUser));
            this.buttonDeleteStatus = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.toysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toysDBDataSet = new store_toys.toysDBDataSet();
            this.toysTableAdapter = new store_toys.toysDBDataSetTableAdapters.toysTableAdapter();
            this.textBoxToys = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteStatus
            // 
            this.buttonDeleteStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStatus.Location = new System.Drawing.Point(653, 297);
            this.buttonDeleteStatus.Name = "buttonDeleteStatus";
            this.buttonDeleteStatus.Size = new System.Drawing.Size(155, 49);
            this.buttonDeleteStatus.TabIndex = 45;
            this.buttonDeleteStatus.Text = "Удалить заявку";
            this.buttonDeleteStatus.UseVisualStyleBackColor = true;
            this.buttonDeleteStatus.Click += new System.EventHandler(this.buttonDeleteStatus_Click);
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeStatus.Location = new System.Drawing.Point(479, 297);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(155, 49);
            this.buttonChangeStatus.TabIndex = 44;
            this.buttonChangeStatus.Text = "Создать заявку";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(477, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Статус готовности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(553, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Игрушка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(605, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "id:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatus.Location = new System.Drawing.Point(636, 256);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(157, 23);
            this.textBoxStatus.TabIndex = 40;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(636, 168);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(157, 24);
            this.textBoxId.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 341);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(530, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Количество:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(636, 227);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(157, 23);
            this.textBoxCount.TabIndex = 46;
            // 
            // toysBindingSource
            // 
            this.toysBindingSource.DataMember = "toys";
            this.toysBindingSource.DataSource = this.toysDBDataSet;
            // 
            // toysDBDataSet
            // 
            this.toysDBDataSet.DataSetName = "toysDBDataSet";
            this.toysDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toysTableAdapter
            // 
            this.toysTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxToys
            // 
            this.textBoxToys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToys.Location = new System.Drawing.Point(636, 198);
            this.textBoxToys.Multiline = true;
            this.textBoxToys.Name = "textBoxToys";
            this.textBoxToys.Size = new System.Drawing.Size(157, 23);
            this.textBoxToys.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(564, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 49;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxToys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonDeleteStatus);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResultUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultUser";
            this.Load += new System.EventHandler(this.ResultUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteStatus;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCount;
        private toysDBDataSet toysDBDataSet;
        private System.Windows.Forms.BindingSource toysBindingSource;
        private toysDBDataSetTableAdapters.toysTableAdapter toysTableAdapter;
        private System.Windows.Forms.TextBox textBoxToys;
        private System.Windows.Forms.Button button1;
    }
}