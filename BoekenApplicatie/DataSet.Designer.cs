namespace BoekenApplicatie
{
    partial class DataSet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoekenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boekenDataSet = new BoekenApplicatie.BoekenDataSet();
            this.boekBoekenlijstTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekBoekenlijstTableAdapter();
            this.boekenlijstTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekenlijstTableAdapter();
            this.categorieTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.CategorieTableAdapter();
            this.boekTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekTableAdapter();
            this.Zoeken = new System.Windows.Forms.Label();
            this.titelzoeken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnzoeken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cat_Search = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boekenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all = new System.Windows.Forms.Button();
            this.Uit_Search = new System.Windows.Forms.ComboBox();
            this.uitgeverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uitgeverTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.UitgeverTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titel,
            this.categorieID,
            this.isbnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BoekenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // titel
            // 
            this.titel.DataPropertyName = "titel";
            this.titel.HeaderText = "titel";
            this.titel.Name = "titel";
            // 
            // categorieID
            // 
            this.categorieID.DataPropertyName = "categorieID";
            this.categorieID.HeaderText = "categorieID";
            this.categorieID.Name = "categorieID";
            this.categorieID.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // BoekenBindingSource
            // 
            this.BoekenBindingSource.AllowNew = true;
            this.BoekenBindingSource.DataMember = "Boek";
            this.BoekenBindingSource.DataSource = this.boekenDataSet;
            this.BoekenBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // boekenDataSet
            // 
            this.boekenDataSet.DataSetName = "BoekenDataSet";
            this.boekenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boekBoekenlijstTableAdapter
            // 
            this.boekBoekenlijstTableAdapter.ClearBeforeFill = true;
            // 
            // boekenlijstTableAdapter
            // 
            this.boekenlijstTableAdapter.ClearBeforeFill = true;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // boekTableAdapter
            // 
            this.boekTableAdapter.ClearBeforeFill = true;
            // 
            // Zoeken
            // 
            this.Zoeken.AutoSize = true;
            this.Zoeken.Location = new System.Drawing.Point(12, 21);
            this.Zoeken.Name = "Zoeken";
            this.Zoeken.Size = new System.Drawing.Size(23, 13);
            this.Zoeken.TabIndex = 2;
            this.Zoeken.Text = "titel";
            // 
            // titelzoeken
            // 
            this.titelzoeken.Location = new System.Drawing.Point(15, 39);
            this.titelzoeken.Name = "titelzoeken";
            this.titelzoeken.Size = new System.Drawing.Size(100, 20);
            this.titelzoeken.TabIndex = 3;
            this.titelzoeken.TextChanged += new System.EventHandler(this.titelzoeken_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "isbn";
            // 
            // isbnzoeken
            // 
            this.isbnzoeken.Location = new System.Drawing.Point(15, 87);
            this.isbnzoeken.Name = "isbnzoeken";
            this.isbnzoeken.Size = new System.Drawing.Size(100, 20);
            this.isbnzoeken.TabIndex = 5;
            this.isbnzoeken.TextChanged += new System.EventHandler(this.isbnzoeken_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "categorie";
            // 
            // Cat_Search
            // 
            this.Cat_Search.DataSource = this.categorieBindingSource;
            this.Cat_Search.DisplayMember = "naam";
            this.Cat_Search.FormattingEnabled = true;
            this.Cat_Search.Location = new System.Drawing.Point(236, 39);
            this.Cat_Search.Name = "Cat_Search";
            this.Cat_Search.Size = new System.Drawing.Size(121, 21);
            this.Cat_Search.TabIndex = 7;
            this.Cat_Search.SelectedIndexChanged += new System.EventHandler(this.Cat_Search_SelectedIndexChanged);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.boekenDataSetBindingSource;
            // 
            // boekenDataSetBindingSource
            // 
            this.boekenDataSetBindingSource.DataSource = this.boekenDataSet;
            this.boekenDataSetBindingSource.Position = 0;
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(144, 36);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(75, 23);
            this.all.TabIndex = 8;
            this.all.Text = "Show All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // Uit_Search
            // 
            this.Uit_Search.DataSource = this.uitgeverBindingSource;
            this.Uit_Search.DisplayMember = "naam";
            this.Uit_Search.FormattingEnabled = true;
            this.Uit_Search.Location = new System.Drawing.Point(236, 87);
            this.Uit_Search.Name = "Uit_Search";
            this.Uit_Search.Size = new System.Drawing.Size(121, 21);
            this.Uit_Search.TabIndex = 9;
            this.Uit_Search.SelectedIndexChanged += new System.EventHandler(this.Uit_Search_SelectedIndexChanged);
            // 
            // uitgeverBindingSource
            // 
            this.uitgeverBindingSource.DataMember = "Uitgever";
            this.uitgeverBindingSource.DataSource = this.boekenDataSet;
            // 
            // uitgeverTableAdapter
            // 
            this.uitgeverTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "uitgever";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uit_Search);
            this.Controls.Add(this.all);
            this.Controls.Add(this.Cat_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnzoeken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titelzoeken);
            this.Controls.Add(this.Zoeken);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BoekenDataSet boekenDataSet;
        private System.Windows.Forms.BindingSource BoekenBindingSource;
        private BoekenDataSetTableAdapters.BoekBoekenlijstTableAdapter boekBoekenlijstTableAdapter;
        private BoekenDataSetTableAdapters.BoekenlijstTableAdapter boekenlijstTableAdapter;
        private BoekenDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private BoekenDataSetTableAdapters.BoekTableAdapter boekTableAdapter;
        private System.Windows.Forms.Label Zoeken;
        private System.Windows.Forms.TextBox titelzoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnzoeken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cat_Search;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource boekenDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.ComboBox Uit_Search;
        private System.Windows.Forms.BindingSource uitgeverBindingSource;
        private BoekenDataSetTableAdapters.UitgeverTableAdapter uitgeverTableAdapter;
        private System.Windows.Forms.Label label1;

    }
}

