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
            this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giftDataSet = new gift.giftDataSet();
            this.giftsTableAdapter = new gift.giftDataSetTableAdapters.giftsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // giftsBindingSource
            // 
            this.giftsBindingSource.DataMember = "gifts";
            this.giftsBindingSource.DataSource = this.giftDataSet;
            // 
            // giftDataSet
            // 
            this.giftDataSet.DataSetName = "giftDataSet";
            this.giftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giftsTableAdapter
            // 
            this.giftsTableAdapter.ClearBeforeFill = true;
            // 
            // SeeGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Name = "SeeGift";
            this.Text = "SeeGift";
            this.Load += new System.EventHandler(this.SeeGift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private giftDataSet giftDataSet;
        private System.Windows.Forms.BindingSource giftsBindingSource;
        private giftDataSetTableAdapters.giftsTableAdapter giftsTableAdapter;
    }
}