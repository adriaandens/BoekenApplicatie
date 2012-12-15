﻿namespace BoekenApplicatie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.boekenlijst = new System.Windows.Forms.DataGridView();
            this.titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aankoopprijsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uitgeverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.klaslijst = new System.Windows.Forms.DataGridView();
            this.titelboek = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.huurprijsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolprijsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordtverhuurdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boekBoekenlijstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addtolist = new System.Windows.Forms.Button();
            this.removefromlist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.klas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.klaslabel = new System.Windows.Forms.Label();
            this.klassenlijst = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maak_klas_combobox = new System.Windows.Forms.ComboBox();
            this.maakNieuweLijst = new System.Windows.Forms.Button();
            this.boekenlijstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boekenlijst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klaslijst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenlijstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // boekenlijst
            // 
            this.boekenlijst.AllowUserToAddRows = false;
            this.boekenlijst.AllowUserToDeleteRows = false;
            this.boekenlijst.AutoGenerateColumns = false;
            this.boekenlijst.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.boekenlijst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.boekenlijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boekenlijst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titel,
            this.categorieID,
            this.isbn,
            this.idDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.aankoopprijsDataGridViewTextBoxColumn,
            this.categorieIDDataGridViewTextBoxColumn,
            this.uitgeverIDDataGridViewTextBoxColumn});
            this.boekenlijst.Cursor = System.Windows.Forms.Cursors.Default;
            this.boekenlijst.DataSource = this.BoekenBindingSource;
            this.boekenlijst.EnableHeadersVisualStyles = false;
            this.boekenlijst.GridColor = System.Drawing.SystemColors.Highlight;
            this.boekenlijst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boekenlijst.Location = new System.Drawing.Point(20, 132);
            this.boekenlijst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boekenlijst.MultiSelect = false;
            this.boekenlijst.Name = "boekenlijst";
            this.boekenlijst.ReadOnly = true;
            this.boekenlijst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.boekenlijst.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.boekenlijst.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.boekenlijst.Size = new System.Drawing.Size(412, 394);
            this.boekenlijst.TabIndex = 0;
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
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "isbn";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            this.titelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aankoopprijsDataGridViewTextBoxColumn
            // 
            this.aankoopprijsDataGridViewTextBoxColumn.DataPropertyName = "aankoopprijs";
            this.aankoopprijsDataGridViewTextBoxColumn.HeaderText = "aankoopprijs";
            this.aankoopprijsDataGridViewTextBoxColumn.Name = "aankoopprijsDataGridViewTextBoxColumn";
            this.aankoopprijsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieIDDataGridViewTextBoxColumn
            // 
            this.categorieIDDataGridViewTextBoxColumn.DataPropertyName = "categorieID";
            this.categorieIDDataGridViewTextBoxColumn.HeaderText = "categorieID";
            this.categorieIDDataGridViewTextBoxColumn.Name = "categorieIDDataGridViewTextBoxColumn";
            this.categorieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uitgeverIDDataGridViewTextBoxColumn
            // 
            this.uitgeverIDDataGridViewTextBoxColumn.DataPropertyName = "uitgeverID";
            this.uitgeverIDDataGridViewTextBoxColumn.HeaderText = "uitgeverID";
            this.uitgeverIDDataGridViewTextBoxColumn.Name = "uitgeverIDDataGridViewTextBoxColumn";
            this.uitgeverIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Zoeken.Location = new System.Drawing.Point(16, 23);
            this.Zoeken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zoeken.Name = "Zoeken";
            this.Zoeken.Size = new System.Drawing.Size(31, 14);
            this.Zoeken.TabIndex = 2;
            this.Zoeken.Text = "titel";
            // 
            // titelzoeken
            // 
            this.titelzoeken.BackColor = System.Drawing.Color.Gainsboro;
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
            this.isbnzoeken.BackColor = System.Drawing.Color.Gainsboro;
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
            this.label3.Location = new System.Drawing.Point(271, 24);
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
            this.Cat_Search.Location = new System.Drawing.Point(272, 41);
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
            this.all.Location = new System.Drawing.Point(161, 64);
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
            this.Uit_Search.Location = new System.Drawing.Point(272, 94);
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
            this.uitgeverBindingSource.DataSource = this.boekenDataSet;
            // 
            // uitgeverTableAdapter
            // 
            this.uitgeverTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 76);
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
            // klaslijst
            // 
            this.klaslijst.AllowUserToAddRows = false;
            this.klaslijst.AutoGenerateColumns = false;
            this.klaslijst.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.klaslijst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.klaslijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klaslijst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titelboek,
            this.Cat,
            this.huurprijsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.schoolprijsDataGridViewTextBoxColumn,
            this.wordtverhuurdDataGridViewTextBoxColumn});
            this.klaslijst.DataSource = this.boekBoekenlijstBindingSource1;
            this.klaslijst.EnableHeadersVisualStyles = false;
            this.klaslijst.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.klaslijst.Location = new System.Drawing.Point(549, 132);
            this.klaslijst.Name = "klaslijst";
            this.klaslijst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.klaslijst.RowHeadersVisible = false;
            this.klaslijst.Size = new System.Drawing.Size(543, 394);
            this.klaslijst.TabIndex = 11;
            // 
            // titelboek
            // 
            this.titelboek.DataPropertyName = "id_boek";
            this.titelboek.DataSource = this.BoekenBindingSource;
            this.titelboek.DisplayMember = "titel";
            this.titelboek.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.titelboek.HeaderText = "titel";
            this.titelboek.Name = "titelboek";
            this.titelboek.ValueMember = "id";
            // 
            // Cat
            // 
            this.Cat.DataPropertyName = "categorieID";
            this.Cat.DataSource = this.categorieBindingSource;
            this.Cat.DisplayMember = "naam";
            this.Cat.HeaderText = "categorie";
            this.Cat.Name = "Cat";
            this.Cat.ValueMember = "categorieID";
            // 
            // huurprijsDataGridViewTextBoxColumn
            // 
            this.huurprijsDataGridViewTextBoxColumn.DataPropertyName = "huurprijs";
            this.huurprijsDataGridViewTextBoxColumn.HeaderText = "huurprijs";
            this.huurprijsDataGridViewTextBoxColumn.Name = "huurprijsDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "klas";
            this.dataGridViewTextBoxColumn1.HeaderText = "klas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // schoolprijsDataGridViewTextBoxColumn
            // 
            this.schoolprijsDataGridViewTextBoxColumn.DataPropertyName = "schoolprijs";
            this.schoolprijsDataGridViewTextBoxColumn.HeaderText = "schoolprijs";
            this.schoolprijsDataGridViewTextBoxColumn.Name = "schoolprijsDataGridViewTextBoxColumn";
            // 
            // wordtverhuurdDataGridViewTextBoxColumn
            // 
            this.wordtverhuurdDataGridViewTextBoxColumn.DataPropertyName = "wordtverhuurd";
            this.wordtverhuurdDataGridViewTextBoxColumn.FalseValue = "0";
            this.wordtverhuurdDataGridViewTextBoxColumn.HeaderText = "verhuurd";
            this.wordtverhuurdDataGridViewTextBoxColumn.Name = "wordtverhuurdDataGridViewTextBoxColumn";
            this.wordtverhuurdDataGridViewTextBoxColumn.ReadOnly = true;
            this.wordtverhuurdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wordtverhuurdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wordtverhuurdDataGridViewTextBoxColumn.TrueValue = "1";
            this.wordtverhuurdDataGridViewTextBoxColumn.Width = 75;
            // 
            // boekBoekenlijstBindingSource1
            // 
            this.boekBoekenlijstBindingSource1.DataMember = "BoekBoekenlijst";
            this.boekBoekenlijstBindingSource1.DataSource = this.boekenDataSet;
            // 
            // addtolist
            // 
            this.addtolist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtolist.Location = new System.Drawing.Point(453, 309);
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
            this.removefromlist.Location = new System.Drawing.Point(453, 383);
            this.removefromlist.Name = "removefromlist";
            this.removefromlist.Size = new System.Drawing.Size(75, 23);
            this.removefromlist.TabIndex = 13;
            this.removefromlist.Text = "<<";
            this.removefromlist.UseVisualStyleBackColor = false;
            this.removefromlist.Click += new System.EventHandler(this.removefromlist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Maak nieuwe klas met naam:";
            // 
            // klas
            // 
            this.klas.BackColor = System.Drawing.Color.Gainsboro;
            this.klas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klas.Location = new System.Drawing.Point(734, 74);
            this.klas.MaxLength = 2;
            this.klas.Name = "klas";
            this.klas.Size = new System.Drawing.Size(56, 22);
            this.klas.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Klaslijst:";
            // 
            // klaslabel
            // 
            this.klaslabel.AutoSize = true;
            this.klaslabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaslabel.Location = new System.Drawing.Point(763, 108);
            this.klaslabel.Name = "klaslabel";
            this.klaslabel.Size = new System.Drawing.Size(0, 14);
            this.klaslabel.TabIndex = 17;
            // 
            // klassenlijst
            // 
            this.klassenlijst.DataSource = this.boekenlijstBindingSource;
            this.klassenlijst.DisplayMember = "klas";
            this.klassenlijst.FormattingEnabled = true;
            this.klassenlijst.Location = new System.Drawing.Point(603, 104);
            this.klassenlijst.Name = "klassenlijst";
            this.klassenlijst.Size = new System.Drawing.Size(121, 22);
            this.klassenlijst.TabIndex = 18;
            this.klassenlijst.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(796, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "en gebaseerd op:";
            // 
            // maak_klas_combobox
            // 
            this.maak_klas_combobox.DataSource = this.boekenlijstBindingSource;
            this.maak_klas_combobox.DisplayMember = "klas";
            this.maak_klas_combobox.FormattingEnabled = true;
            this.maak_klas_combobox.Location = new System.Drawing.Point(922, 73);
            this.maak_klas_combobox.Name = "maak_klas_combobox";
            this.maak_klas_combobox.Size = new System.Drawing.Size(63, 22);
            this.maak_klas_combobox.TabIndex = 20;
            // 
            // maakNieuweLijst
            // 
            this.maakNieuweLijst.Location = new System.Drawing.Point(991, 73);
            this.maakNieuweLijst.Name = "maakNieuweLijst";
            this.maakNieuweLijst.Size = new System.Drawing.Size(75, 23);
            this.maakNieuweLijst.TabIndex = 21;
            this.maakNieuweLijst.Text = "Maak!";
            this.maakNieuweLijst.UseVisualStyleBackColor = true;
            this.maakNieuweLijst.Click += new System.EventHandler(this.maakNieuweLijst_Click);
            // 
            // boekenlijstBindingSource
            // 
            this.boekenlijstBindingSource.DataMember = "Boekenlijst";
            this.boekenlijstBindingSource.DataSource = this.boekenDataSet;
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1096, 538);
            this.Controls.Add(this.maakNieuweLijst);
            this.Controls.Add(this.maak_klas_combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.klassenlijst);
            this.Controls.Add(this.klaslabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.klas);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.boekenlijst);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boekenlijst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoekenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitgeverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klaslijst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekBoekenlijstBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boekenlijstBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView boekenlijst;
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
        private System.Windows.Forms.BindingSource boekBoekenlijstBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridView klaslijst;
        private System.Windows.Forms.BindingSource boekBoekenlijstBindingSource1;
        private System.Windows.Forms.Button addtolist;
        private System.Windows.Forms.Button removefromlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox klas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label klaslabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn titelboek;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn huurprijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolprijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wordtverhuurdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aankoopprijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uitgeverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox klassenlijst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox maak_klas_combobox;
        private System.Windows.Forms.Button maakNieuweLijst;
        private System.Windows.Forms.BindingSource boekenlijstBindingSource;

    }
}

