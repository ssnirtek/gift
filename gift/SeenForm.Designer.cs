namespace gift
{
    partial class SeenForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.giftDataSet = new gift.giftDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new gift.giftDataSetTableAdapters.usersTableAdapter();
            this.dgvGifts = new System.Windows.Forms.DataGridView();
            this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giftsTableAdapter = new gift.giftDataSetTableAdapters.giftsTableAdapter();
            this.giftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(944, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите ID подарка, \r\nчтобы посмотреть изображение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(939, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск по названию";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(769, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(769, 63);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 21);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.Text = "Фильтрация по категориям";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // giftDataSet
            // 
            this.giftDataSet.DataSetName = "giftDataSet";
            this.giftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.giftDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvGifts
            // 
            this.dgvGifts.AutoGenerateColumns = false;
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giftIDDataGridViewTextBoxColumn,
            this.giftNameDataGridViewTextBoxColumn,
            this.giftCategoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.giftImageDataGridViewTextBoxColumn,
            this.giftDescriptionDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dgvGifts.DataSource = this.giftsBindingSource;
            this.dgvGifts.Location = new System.Drawing.Point(12, 12);
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.Size = new System.Drawing.Size(735, 316);
            this.dgvGifts.TabIndex = 16;
            // 
            // giftsBindingSource
            // 
            this.giftsBindingSource.DataMember = "gifts";
            this.giftsBindingSource.DataSource = this.giftDataSet;
            // 
            // giftsTableAdapter
            // 
            this.giftsTableAdapter.ClearBeforeFill = true;
            // 
            // giftIDDataGridViewTextBoxColumn
            // 
            this.giftIDDataGridViewTextBoxColumn.DataPropertyName = "giftID";
            this.giftIDDataGridViewTextBoxColumn.HeaderText = "giftID";
            this.giftIDDataGridViewTextBoxColumn.Name = "giftIDDataGridViewTextBoxColumn";
            this.giftIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "giftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "giftName";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            // 
            // giftCategoryDataGridViewTextBoxColumn
            // 
            this.giftCategoryDataGridViewTextBoxColumn.DataPropertyName = "giftCategory";
            this.giftCategoryDataGridViewTextBoxColumn.HeaderText = "giftCategory";
            this.giftCategoryDataGridViewTextBoxColumn.Name = "giftCategoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // giftImageDataGridViewTextBoxColumn
            // 
            this.giftImageDataGridViewTextBoxColumn.DataPropertyName = "giftImage";
            this.giftImageDataGridViewTextBoxColumn.HeaderText = "giftImage";
            this.giftImageDataGridViewTextBoxColumn.Name = "giftImageDataGridViewTextBoxColumn";
            // 
            // giftDescriptionDataGridViewTextBoxColumn
            // 
            this.giftDescriptionDataGridViewTextBoxColumn.DataPropertyName = "giftDescription";
            this.giftDescriptionDataGridViewTextBoxColumn.HeaderText = "giftDescription";
            this.giftDescriptionDataGridViewTextBoxColumn.Name = "giftDescriptionDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 357);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(732, 54);
            this.textBox2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(769, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 197);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SeenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGifts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbCategory);
            this.Name = "SeenForm";
            this.Text = "SeenForm";
            this.Load += new System.EventHandler(this.SeenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private giftDataSet giftDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private giftDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dgvGifts;
        private System.Windows.Forms.BindingSource giftsBindingSource;
        private giftDataSetTableAdapters.giftsTableAdapter giftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}