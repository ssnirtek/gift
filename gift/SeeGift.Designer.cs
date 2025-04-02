namespace gift
{
    partial class SeeGift
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
            this.dataGridViewGifts = new System.Windows.Forms.DataGridView();
            this.giftDataSet = new gift.giftDataSet();
            this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giftsTableAdapter = new gift.giftDataSetTableAdapters.giftsTableAdapter();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxGift = new System.Windows.Forms.PictureBox();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGift)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGifts
            // 
            this.dataGridViewGifts.AutoGenerateColumns = false;
            this.dataGridViewGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giftNameDataGridViewTextBoxColumn,
            this.giftCategoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.giftImage,
            this.giftDescriptionDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridViewGifts.DataSource = this.giftsBindingSource;
            this.dataGridViewGifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGifts.Name = "dataGridViewGifts";
            this.dataGridViewGifts.Size = new System.Drawing.Size(642, 426);
            this.dataGridViewGifts.TabIndex = 0;
            this.dataGridViewGifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGifts_CellContentClick);
            this.dataGridViewGifts.SelectionChanged += new System.EventHandler(this.dataGridViewGifts_SelectionChanged);
            // 
            // giftDataSet
            // 
            this.giftDataSet.DataSetName = "giftDataSet";
            this.giftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(673, 62);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(229, 21);
            this.cmbCategoryFilter.TabIndex = 1;
            this.cmbCategoryFilter.Text = "Фильтрация по категориям";
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(673, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск по названию";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGift
            // 
            this.pictureBoxGift.Location = new System.Drawing.Point(673, 147);
            this.pictureBoxGift.Name = "pictureBoxGift";
            this.pictureBoxGift.Size = new System.Drawing.Size(229, 138);
            this.pictureBoxGift.TabIndex = 5;
            this.pictureBoxGift.TabStop = false;
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "giftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            // 
            // giftCategoryDataGridViewTextBoxColumn
            // 
            this.giftCategoryDataGridViewTextBoxColumn.DataPropertyName = "giftCategory";
            this.giftCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.giftCategoryDataGridViewTextBoxColumn.Name = "giftCategoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // giftImage
            // 
            this.giftImage.DataPropertyName = "giftImage";
            this.giftImage.HeaderText = "Изображение";
            this.giftImage.Name = "giftImage";
            // 
            // giftDescriptionDataGridViewTextBoxColumn
            // 
            this.giftDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.giftDescriptionDataGridViewTextBoxColumn.DataPropertyName = "giftDescription";
            this.giftDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.giftDescriptionDataGridViewTextBoxColumn.Name = "giftDescriptionDataGridViewTextBoxColumn";
            this.giftDescriptionDataGridViewTextBoxColumn.Width = 82;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // SeeGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.pictureBoxGift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.dataGridViewGifts);
            this.Name = "SeeGift";
            this.Text = "SeeGift";
            this.Load += new System.EventHandler(this.SeeGift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGifts;
        private giftDataSet giftDataSet;
        private System.Windows.Forms.BindingSource giftsBindingSource;
        private giftDataSetTableAdapters.giftsTableAdapter giftsTableAdapter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}