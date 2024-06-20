namespace store_toys
{
    partial class ResultAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.toysDBDataSet = new store_toys.toysDBDataSet();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTableAdapter = new store_toys.toysDBDataSetTableAdapters.resultTableAdapter();
            this.toysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toysTableAdapter = new store_toys.toysDBDataSetTableAdapters.toysTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(105)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.comboBoxToys);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Location = new System.Drawing.Point(157, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 369);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "Создание заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(85, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Игрушка:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(191, 209);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(222, 23);
            this.textBoxCount.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNew.Location = new System.Drawing.Point(197, 293);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(115, 53);
            this.buttonNew.TabIndex = 25;
            this.buttonNew.Text = "Создать";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DataSource = this.toysBindingSource;
            this.comboBoxToys.DisplayMember = "name";
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(191, 182);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(222, 21);
            this.comboBoxToys.TabIndex = 49;
            this.comboBoxToys.ValueMember = "name";
            // 
            // toysDBDataSet
            // 
            this.toysDBDataSet.DataSetName = "toysDBDataSet";
            this.toysDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "result";
            this.resultBindingSource.DataSource = this.toysDBDataSet;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // toysBindingSource
            // 
            this.toysBindingSource.DataMember = "toys";
            this.toysBindingSource.DataSource = this.toysDBDataSet;
            // 
            // toysTableAdapter
            // 
            this.toysTableAdapter.ClearBeforeFill = true;
            // 
            // ResultAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResultAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultAdd";
            this.Load += new System.EventHandler(this.ResultAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        private toysDBDataSet toysDBDataSet;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private toysDBDataSetTableAdapters.resultTableAdapter resultTableAdapter;
        private System.Windows.Forms.BindingSource toysBindingSource;
        private toysDBDataSetTableAdapters.toysTableAdapter toysTableAdapter;
    }
}