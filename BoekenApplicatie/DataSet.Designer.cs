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
            this.BoekenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boekenDataSet = new BoekenApplicatie.BoekenDataSet();
            this.boekBoekenlijstTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekBoekenlijstTableAdapter();
            this.boekenlijstTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekenlijstTableAdapter();
            this.categorieTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.CategorieTableAdapter();
            this.boekTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.BoekTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Zoeken = new System.Windows.Forms.Label();
            this.titelzoeken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnzoeken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boekenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 192);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "isbn";
            // 
            // isbnzoeken
            // 
            this.isbnzoeken.Location = new System.Drawing.Point(133, 39);
            this.isbnzoeken.Name = "isbnzoeken";
            this.isbnzoeken.Size = new System.Drawing.Size(100, 20);
            this.isbnzoeken.TabIndex = 5;
            this.isbnzoeken.TextChanged += new System.EventHandler(this.isbnzoeken_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "categorie";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categorieBindingSource;
            this.comboBox1.DisplayMember = "naam";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // boekenDataSetBindingSource
            // 
            this.boekenDataSetBindingSource.DataSource = this.boekenDataSet;
            this.boekenDataSetBindingSource.Position = 0;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.boekenDataSetBindingSource;
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
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 327);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnzoeken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titelzoeken);
            this.Controls.Add(this.Zoeken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Zoeken;
        private System.Windows.Forms.TextBox titelzoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnzoeken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource boekenDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;

    }
}

