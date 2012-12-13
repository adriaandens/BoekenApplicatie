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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.boekBoekenlijstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titel,
            this.categorieID,
            this.isbn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.BoekenBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(20, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(343, 207);
            this.dataGridView1.TabIndex = 0;
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
            this.Zoeken.Location = new System.Drawing.Point(16, 23);
            this.Zoeken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zoeken.Name = "Zoeken";
            this.Zoeken.Size = new System.Drawing.Size(31, 14);
            this.Zoeken.TabIndex = 2;
            this.Zoeken.Text = "titel";
            // 
            // titelzoeken
            // 
            this.titelzoeken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.titelzoeken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titelzoeken.Location = new System.Drawing.Point(20, 42);
            this.titelzoeken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.titelzoeken.Name = "titelzoeken";
            this.titelzoeken.Size = new System.Drawing.Size(133, 22);
            this.titelzoeken.TabIndex = 3;
            this.titelzoeken.TextChanged += new System.EventHandler(this.titelzoeken_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "isbn";
            // 
            // isbnzoeken
            // 
            this.isbnzoeken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.isbnzoeken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbnzoeken.Location = new System.Drawing.Point(20, 94);
            this.isbnzoeken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnzoeken.Name = "isbnzoeken";
            this.isbnzoeken.Size = new System.Drawing.Size(133, 22);
            this.isbnzoeken.TabIndex = 5;
            this.isbnzoeken.TextChanged += new System.EventHandler(this.isbnzoeken_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "categorie";
            // 
            // Cat_Search
            // 
            this.Cat_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cat_Search.DataSource = this.categorieBindingSource;
            this.Cat_Search.DisplayMember = "naam";
            this.Cat_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cat_Search.FormattingEnabled = true;
            this.Cat_Search.Location = new System.Drawing.Point(315, 42);
            this.Cat_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cat_Search.Name = "Cat_Search";
            this.Cat_Search.Size = new System.Drawing.Size(160, 22);
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
            this.all.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all.Location = new System.Drawing.Point(184, 40);
            this.all.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(100, 25);
            this.all.TabIndex = 8;
            this.all.Text = "Show All";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // Uit_Search
            // 
            this.Uit_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Uit_Search.DataSource = this.uitgeverBindingSource;
            this.Uit_Search.DisplayMember = "naam";
            this.Uit_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uit_Search.FormattingEnabled = true;
            this.Uit_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Uit_Search.Location = new System.Drawing.Point(315, 94);
            this.Uit_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Uit_Search.Name = "Uit_Search";
            this.Uit_Search.Size = new System.Drawing.Size(160, 22);
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
            this.label1.Location = new System.Drawing.Point(315, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "uitgever";
            // 
            // boekBoekenlijstBindingSource
            // 
            this.boekBoekenlijstBindingSource.DataMember = "BoekBoekenlijst";
            this.boekBoekenlijstBindingSource.DataSource = this.boekenDataSet;
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
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "isbn";
            this.isbn.Name = "isbn";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 352);
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
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).EndInit();
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
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.ComboBox Uit_Search;
        private System.Windows.Forms.BindingSource uitgeverBindingSource;
        private BoekenDataSetTableAdapters.UitgeverTableAdapter uitgeverTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.BindingSource boekBoekenlijstBindingSource;

    }
}

