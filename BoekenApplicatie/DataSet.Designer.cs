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
            this.boekBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.all = new System.Windows.Forms.Button();
            this.Uit_Search = new System.Windows.Forms.ComboBox();
            this.uitgeverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boekenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uitgeverTableAdapter = new BoekenApplicatie.BoekenDataSetTableAdapters.UitgeverTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.klaslijst = new System.Windows.Forms.DataGridView();
            this.boekBoekenlijstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addtolist = new System.Windows.Forms.Button();
            this.removefromlist = new System.Windows.Forms.Button();
            this.klas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.klaslabel = new System.Windows.Forms.Label();
            this.welkeklas = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boektitel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klaslijst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titel,
            this.categorieID,
            this.id,
            this.isbn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.boekBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(20, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(418, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // boekBindingSource
            // 
            this.boekBindingSource.DataMember = "Boek";
            this.boekBindingSource.DataSource = this.boekenDataSet;
            // 
            // boekenDataSet
            // 
            this.boekenDataSet.DataSetName = "BoekenDataSet";
            this.boekenDataSet.Locale = new System.Globalization.CultureInfo("en-US");
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
            this.Zoeken.Location = new System.Drawing.Point(18, 25);
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
            this.label3.Location = new System.Drawing.Point(275, 25);
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
            this.Cat_Search.Location = new System.Drawing.Point(278, 42);
            this.Cat_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cat_Search.Name = "Cat_Search";
            this.Cat_Search.Size = new System.Drawing.Size(160, 22);
            this.Cat_Search.TabIndex = 7;
            this.Cat_Search.ValueMember = "categorieID";
            this.Cat_Search.SelectedIndexChanged += new System.EventHandler(this.Cat_Search_SelectedIndexChanged);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.boekenDataSet;
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all.Location = new System.Drawing.Point(167, 65);
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
            this.Uit_Search.Location = new System.Drawing.Point(278, 94);
            this.Uit_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Uit_Search.Name = "Uit_Search";
            this.Uit_Search.Size = new System.Drawing.Size(160, 22);
            this.Uit_Search.TabIndex = 9;
            this.Uit_Search.ValueMember = "uitgeverID";
            this.Uit_Search.SelectedIndexChanged += new System.EventHandler(this.Uit_Search_SelectedIndexChanged);
            // 
            // uitgeverBindingSource
            // 
            this.uitgeverBindingSource.DataMember = "Uitgever";
            this.uitgeverBindingSource.DataSource = this.boekenDataSetBindingSource;
            // 
            // boekenDataSetBindingSource
            // 
            this.boekenDataSetBindingSource.DataSource = this.boekenDataSet;
            this.boekenDataSetBindingSource.Position = 0;
            // 
            // uitgeverTableAdapter
            // 
            this.uitgeverTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "uitgever";
            // 
            // klaslijst
            // 
            this.klaslijst.AllowUserToAddRows = false;
            this.klaslijst.AutoGenerateColumns = false;
            this.klaslijst.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.klaslijst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.klaslijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klaslijst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boektitel,
            this.dataGridViewTextBoxColumn1,
            this.cat,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.klaslijst.DataSource = this.boekBoekenlijstBindingSource;
            this.klaslijst.EnableHeadersVisualStyles = false;
            this.klaslijst.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.klaslijst.Location = new System.Drawing.Point(525, 132);
            this.klaslijst.Name = "klaslijst";
            this.klaslijst.RowHeadersVisible = false;
            this.klaslijst.Size = new System.Drawing.Size(531, 353);
            this.klaslijst.TabIndex = 11;
            // 
            // boekBoekenlijstBindingSource
            // 
            this.boekBoekenlijstBindingSource.DataMember = "BoekBoekenlijst";
            this.boekBoekenlijstBindingSource.DataSource = this.boekenDataSet;
            // 
            // addtolist
            // 
            this.addtolist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtolist.Location = new System.Drawing.Point(444, 270);
            this.addtolist.Name = "addtolist";
            this.addtolist.Size = new System.Drawing.Size(75, 23);
            this.addtolist.TabIndex = 12;
            this.addtolist.Text = ">>";
            this.addtolist.UseVisualStyleBackColor = false;
            this.addtolist.Click += new System.EventHandler(this.addtolist_Click);
            // 
            // removefromlist
            // 
            this.removefromlist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.removefromlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removefromlist.Location = new System.Drawing.Point(444, 331);
            this.removefromlist.Name = "removefromlist";
            this.removefromlist.Size = new System.Drawing.Size(75, 23);
            this.removefromlist.TabIndex = 13;
            this.removefromlist.Text = "<<";
            this.removefromlist.UseVisualStyleBackColor = false;
            this.removefromlist.Click += new System.EventHandler(this.removefromlist_Click);
            // 
            // klas
            // 
            this.klas.Location = new System.Drawing.Point(525, 106);
            this.klas.Name = "klas";
            this.klas.Size = new System.Drawing.Size(100, 22);
            this.klas.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "klas";
            // 
            // klaslabel
            // 
            this.klaslabel.AutoSize = true;
            this.klaslabel.Location = new System.Drawing.Point(647, 106);
            this.klaslabel.Name = "klaslabel";
            this.klaslabel.Size = new System.Drawing.Size(95, 14);
            this.klaslabel.TabIndex = 16;
            this.klaslabel.Text = "lijst voor klas:";
            // 
            // welkeklas
            // 
            this.welkeklas.AutoSize = true;
            this.welkeklas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welkeklas.Location = new System.Drawing.Point(748, 106);
            this.welkeklas.Name = "welkeklas";
            this.welkeklas.Size = new System.Drawing.Size(0, 14);
            this.welkeklas.TabIndex = 17;
            // 
            // titel
            // 
            this.titel.DataPropertyName = "titel";
            this.titel.HeaderText = "titel";
            this.titel.Name = "titel";
            this.titel.ReadOnly = true;
            // 
            // categorieID
            // 
            this.categorieID.DataPropertyName = "categorieID";
            this.categorieID.HeaderText = "categorieID";
            this.categorieID.Name = "categorieID";
            this.categorieID.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "isbn";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // boektitel
            // 
            this.boektitel.DataPropertyName = "id_boek";
            this.boektitel.DataSource = this.boekBindingSource;
            this.boektitel.DisplayMember = "titel";
            this.boektitel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.boektitel.HeaderText = "boek titel";
            this.boektitel.Name = "boektitel";
            this.boektitel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boektitel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boektitel.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "klas";
            this.dataGridViewTextBoxColumn1.HeaderText = "klas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cat
            // 
            this.cat.DataPropertyName = "categorieID";
            this.cat.DataSource = this.categorieBindingSource;
            this.cat.DisplayMember = "naam";
            this.cat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cat.HeaderText = "cat";
            this.cat.Name = "cat";
            this.cat.ValueMember = "categorieID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "huurprijs";
            this.dataGridViewTextBoxColumn2.HeaderText = "huurprijs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "schoolprijs";
            this.dataGridViewTextBoxColumn3.HeaderText = "schoolprijs";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "wordtverhuurd";
            this.dataGridViewTextBoxColumn4.FalseValue = "0";
            this.dataGridViewTextBoxColumn4.HeaderText = "wordtverhuurd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.TrueValue = "1";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1068, 508);
            this.Controls.Add(this.welkeklas);
            this.Controls.Add(this.klaslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.klas);
            this.Controls.Add(this.removefromlist);
            this.Controls.Add(this.addtolist);
            this.Controls.Add(this.klaslijst);
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
            ((System.ComponentModel.ISupportInitialize)(this.boekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klaslijst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

 System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.TrueValue = "1";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 352);
            this.ClientSize = new System.Drawing.Size(1068, 508);
            this.Controls.Add(this.welkeklas);
            this.Controls.Add(this.klaslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.klas);
            this.Controls.Add(this.removefromlist);
            this.Controls.Add(this.addtolist);
            this.Controls.Add(this.klaslijst);
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
            ((System.ComponentModel.ISupportInitialize)(this.boekBindingSource)).EndInit();}
        
        private System.Windows.Forms.Label klaslabel;
        private System.Windows.Forms.Label welkeklas;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewComboBoxColumn boektitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;     private BoekenDataSetTableAdapters.BoekBoekenlijstTableAdapter boekBoekenlijstTableAdapter;
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
        private BoekenDataSetTableAdapters.UitgeverTableAdapter uitgeverTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.BindingSource boekBoekenlijstBindingSource;

        private System.Windows.Forms.Button addtolist;
        private System.Windows.Forms.Button removefromlist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wordtverhuurdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huurprijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolprijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView klaslijst;
        private System.Windows.Forms.BindingSource boekBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource uitgeverBindingSource;
        private System.Windows.Forms.BindingSource boekenDataSetBindingSource;
        private System.Windows.Forms.BindingSource boekBoekenlijstBindingSource;
        private System.Windows.Forms.TextBox klas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label klaslabel;
        private System.Windows.Forms.Label welkeklas;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewComboBoxColumn boektitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;


    }
}
