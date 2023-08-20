namespace MonopolyProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            InfoPalletGroupBox = new GroupBox();
            MainInfoPalletGroupBox = new GroupBox();
            CreatePalletButton = new Button();
            DepthPalletTextBox = new TextBox();
            HeightPalletTextBox = new TextBox();
            WidthPalletTextBox = new TextBox();
            SeparatorPalletLabel2 = new Label();
            SeparatorPalletLabel1 = new Label();
            DepthPalletLabel = new Label();
            HeightPalletLabel = new Label();
            WidthPalletLabel = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            depthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            palletBindingSource = new BindingSource(components);
            Hint = new ToolTip(components);
            DepthBoxTextBox = new TextBox();
            HeightBoxTextBox = new TextBox();
            WidthBoxTextBox = new TextBox();
            InfoBoxGroupBox = new GroupBox();
            CreateBoxButton = new Button();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            palletIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            depthDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            manufactureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boxBindingSource = new BindingSource(components);
            AdditionalnfoBoxGroupBox = new GroupBox();
            ManufactureDateTimePicker = new DateTimePicker();
            ExpirationDateTimePicker = new DateTimePicker();
            ManufactureDateCheckBox = new CheckBox();
            ExpirationDateCheckBox = new CheckBox();
            NumberPalletComboBox = new ComboBox();
            label1 = new Label();
            MainInfoBoxGroupBox = new GroupBox();
            SeparatorBoxLabel2 = new Label();
            label2aSeparatorBoxLabel1 = new Label();
            DepthBoxLabel = new Label();
            HeightBoxLabel = new Label();
            WidthBoxLabel = new Label();
            InfoPalletGroupBox.SuspendLayout();
            MainInfoPalletGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletBindingSource).BeginInit();
            InfoBoxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).BeginInit();
            AdditionalnfoBoxGroupBox.SuspendLayout();
            MainInfoBoxGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InfoPalletGroupBox
            // 
            InfoPalletGroupBox.Controls.Add(dataGridView1);
            InfoPalletGroupBox.Controls.Add(MainInfoPalletGroupBox);
            InfoPalletGroupBox.Location = new Point(12, 12);
            InfoPalletGroupBox.Name = "InfoPalletGroupBox";
            InfoPalletGroupBox.Size = new Size(985, 243);
            InfoPalletGroupBox.TabIndex = 0;
            InfoPalletGroupBox.TabStop = false;
            InfoPalletGroupBox.Text = "Информация о паллете";
            // 
            // MainInfoPalletGroupBox
            // 
            MainInfoPalletGroupBox.Controls.Add(CreatePalletButton);
            MainInfoPalletGroupBox.Controls.Add(DepthPalletTextBox);
            MainInfoPalletGroupBox.Controls.Add(HeightPalletTextBox);
            MainInfoPalletGroupBox.Controls.Add(WidthPalletTextBox);
            MainInfoPalletGroupBox.Controls.Add(SeparatorPalletLabel2);
            MainInfoPalletGroupBox.Controls.Add(SeparatorPalletLabel1);
            MainInfoPalletGroupBox.Controls.Add(DepthPalletLabel);
            MainInfoPalletGroupBox.Controls.Add(HeightPalletLabel);
            MainInfoPalletGroupBox.Controls.Add(WidthPalletLabel);
            MainInfoPalletGroupBox.Location = new Point(6, 17);
            MainInfoPalletGroupBox.Name = "MainInfoPalletGroupBox";
            MainInfoPalletGroupBox.Size = new Size(317, 101);
            MainInfoPalletGroupBox.TabIndex = 0;
            MainInfoPalletGroupBox.TabStop = false;
            MainInfoPalletGroupBox.Text = "Основные параметры";
            // 
            // CreatePalletButton
            // 
            CreatePalletButton.Cursor = Cursors.Hand;
            CreatePalletButton.FlatStyle = FlatStyle.Flat;
            CreatePalletButton.Location = new Point(14, 66);
            CreatePalletButton.Name = "CreatePalletButton";
            CreatePalletButton.Size = new Size(292, 23);
            CreatePalletButton.TabIndex = 1;
            CreatePalletButton.Text = "Создать";
            CreatePalletButton.UseVisualStyleBackColor = true;
            CreatePalletButton.Click += CreatePalletButton_Click;
            // 
            // DepthPalletTextBox
            // 
            DepthPalletTextBox.Location = new Point(226, 37);
            DepthPalletTextBox.Name = "DepthPalletTextBox";
            DepthPalletTextBox.PlaceholderText = "Глубина, мм";
            DepthPalletTextBox.Size = new Size(80, 23);
            DepthPalletTextBox.TabIndex = 7;
            DepthPalletTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(DepthPalletTextBox, "Размеры в милиметрах");
            // 
            // HeightPalletTextBox
            // 
            HeightPalletTextBox.Location = new Point(120, 37);
            HeightPalletTextBox.Name = "HeightPalletTextBox";
            HeightPalletTextBox.PlaceholderText = "Высота, мм";
            HeightPalletTextBox.Size = new Size(80, 23);
            HeightPalletTextBox.TabIndex = 6;
            HeightPalletTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(HeightPalletTextBox, "Размеры в милиметрах");
            // 
            // WidthPalletTextBox
            // 
            WidthPalletTextBox.Location = new Point(14, 37);
            WidthPalletTextBox.Name = "WidthPalletTextBox";
            WidthPalletTextBox.PlaceholderText = "Ширина, мм";
            WidthPalletTextBox.Size = new Size(80, 23);
            WidthPalletTextBox.TabIndex = 1;
            WidthPalletTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(WidthPalletTextBox, "Размеры в милиметрах");
            // 
            // SeparatorPalletLabel2
            // 
            SeparatorPalletLabel2.AutoSize = true;
            SeparatorPalletLabel2.Location = new Point(206, 40);
            SeparatorPalletLabel2.Name = "SeparatorPalletLabel2";
            SeparatorPalletLabel2.Size = new Size(14, 15);
            SeparatorPalletLabel2.TabIndex = 5;
            SeparatorPalletLabel2.Text = "X";
            // 
            // SeparatorPalletLabel1
            // 
            SeparatorPalletLabel1.AutoSize = true;
            SeparatorPalletLabel1.Location = new Point(100, 40);
            SeparatorPalletLabel1.Name = "SeparatorPalletLabel1";
            SeparatorPalletLabel1.Size = new Size(14, 15);
            SeparatorPalletLabel1.TabIndex = 4;
            SeparatorPalletLabel1.Text = "X";
            // 
            // DepthPalletLabel
            // 
            DepthPalletLabel.AutoSize = true;
            DepthPalletLabel.Location = new Point(242, 19);
            DepthPalletLabel.Name = "DepthPalletLabel";
            DepthPalletLabel.Size = new Size(53, 15);
            DepthPalletLabel.TabIndex = 3;
            DepthPalletLabel.Text = "Глубина";
            // 
            // HeightPalletLabel
            // 
            HeightPalletLabel.AutoSize = true;
            HeightPalletLabel.Location = new Point(138, 19);
            HeightPalletLabel.Name = "HeightPalletLabel";
            HeightPalletLabel.Size = new Size(47, 15);
            HeightPalletLabel.TabIndex = 2;
            HeightPalletLabel.Text = "Высота";
            // 
            // WidthPalletLabel
            // 
            WidthPalletLabel.AutoSize = true;
            WidthPalletLabel.Location = new Point(31, 19);
            WidthPalletLabel.Name = "WidthPalletLabel";
            WidthPalletLabel.Size = new Size(52, 15);
            WidthPalletLabel.TabIndex = 1;
            WidthPalletLabel.Text = "Ширина";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, depthDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, volumeDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = palletBindingSource;
            dataGridView1.Location = new Point(339, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(634, 204);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Номер паллета";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 107;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Ширина";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.ReadOnly = true;
            widthDataGridViewTextBoxColumn.Width = 77;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Высота";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            heightDataGridViewTextBoxColumn.Width = 72;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            depthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            depthDataGridViewTextBoxColumn.HeaderText = "Глубина";
            depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            depthDataGridViewTextBoxColumn.ReadOnly = true;
            depthDataGridViewTextBoxColumn.Width = 78;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            weightDataGridViewTextBoxColumn.Width = 51;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            volumeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            volumeDataGridViewTextBoxColumn.HeaderText = "Объем";
            volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            volumeDataGridViewTextBoxColumn.ReadOnly = true;
            volumeDataGridViewTextBoxColumn.Width = 70;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            expirationDateDataGridViewTextBoxColumn.Width = 104;
            // 
            // palletBindingSource
            // 
            palletBindingSource.DataSource = typeof(Classes.Pallet);
            // 
            // Hint
            // 
            Hint.ToolTipIcon = ToolTipIcon.Info;
            Hint.ToolTipTitle = "Подсказка ввода";
            // 
            // DepthBoxTextBox
            // 
            DepthBoxTextBox.Location = new Point(218, 37);
            DepthBoxTextBox.Name = "DepthBoxTextBox";
            DepthBoxTextBox.PlaceholderText = "Глубина, мм";
            DepthBoxTextBox.Size = new Size(80, 23);
            DepthBoxTextBox.TabIndex = 7;
            DepthBoxTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(DepthBoxTextBox, "Размеры в милиметрах");
            // 
            // HeightBoxTextBox
            // 
            HeightBoxTextBox.Location = new Point(112, 37);
            HeightBoxTextBox.Name = "HeightBoxTextBox";
            HeightBoxTextBox.PlaceholderText = "Высота, мм";
            HeightBoxTextBox.Size = new Size(80, 23);
            HeightBoxTextBox.TabIndex = 6;
            HeightBoxTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(HeightBoxTextBox, "Размеры в милиметрах");
            // 
            // WidthBoxTextBox
            // 
            WidthBoxTextBox.Location = new Point(6, 37);
            WidthBoxTextBox.Name = "WidthBoxTextBox";
            WidthBoxTextBox.PlaceholderText = "Ширина, мм";
            WidthBoxTextBox.Size = new Size(80, 23);
            WidthBoxTextBox.TabIndex = 1;
            WidthBoxTextBox.TextAlign = HorizontalAlignment.Center;
            Hint.SetToolTip(WidthBoxTextBox, "Размеры в милиметрах");
            // 
            // InfoBoxGroupBox
            // 
            InfoBoxGroupBox.Controls.Add(CreateBoxButton);
            InfoBoxGroupBox.Controls.Add(dataGridView2);
            InfoBoxGroupBox.Controls.Add(AdditionalnfoBoxGroupBox);
            InfoBoxGroupBox.Controls.Add(MainInfoBoxGroupBox);
            InfoBoxGroupBox.Location = new Point(12, 261);
            InfoBoxGroupBox.Name = "InfoBoxGroupBox";
            InfoBoxGroupBox.Size = new Size(985, 243);
            InfoBoxGroupBox.TabIndex = 1;
            InfoBoxGroupBox.TabStop = false;
            InfoBoxGroupBox.Text = "Информация о коробке";
            // 
            // CreateBoxButton
            // 
            CreateBoxButton.Cursor = Cursors.Hand;
            CreateBoxButton.FlatStyle = FlatStyle.Flat;
            CreateBoxButton.Location = new Point(6, 203);
            CreateBoxButton.Name = "CreateBoxButton";
            CreateBoxButton.Size = new Size(317, 23);
            CreateBoxButton.TabIndex = 1;
            CreateBoxButton.Text = "Создать";
            CreateBoxButton.UseVisualStyleBackColor = true;
            CreateBoxButton.Click += CreateBoxButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, palletIdDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn1, heightDataGridViewTextBoxColumn1, depthDataGridViewTextBoxColumn1, weightDataGridViewTextBoxColumn1, volumeDataGridViewTextBoxColumn1, ExpirationDate, manufactureDateDataGridViewTextBoxColumn });
            dataGridView2.DataSource = boxBindingSource;
            dataGridView2.Location = new Point(339, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(634, 204);
            dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Номер коробки";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 110;
            // 
            // palletIdDataGridViewTextBoxColumn
            // 
            palletIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            palletIdDataGridViewTextBoxColumn.DataPropertyName = "PalletId";
            palletIdDataGridViewTextBoxColumn.HeaderText = "Паллет выбранный для коробки";
            palletIdDataGridViewTextBoxColumn.Name = "palletIdDataGridViewTextBoxColumn";
            palletIdDataGridViewTextBoxColumn.ReadOnly = true;
            palletIdDataGridViewTextBoxColumn.Width = 151;
            // 
            // widthDataGridViewTextBoxColumn1
            // 
            widthDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            widthDataGridViewTextBoxColumn1.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn1.HeaderText = "Ширина";
            widthDataGridViewTextBoxColumn1.Name = "widthDataGridViewTextBoxColumn1";
            widthDataGridViewTextBoxColumn1.ReadOnly = true;
            widthDataGridViewTextBoxColumn1.Width = 77;
            // 
            // heightDataGridViewTextBoxColumn1
            // 
            heightDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            heightDataGridViewTextBoxColumn1.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn1.HeaderText = "Высота";
            heightDataGridViewTextBoxColumn1.Name = "heightDataGridViewTextBoxColumn1";
            heightDataGridViewTextBoxColumn1.ReadOnly = true;
            heightDataGridViewTextBoxColumn1.Width = 72;
            // 
            // depthDataGridViewTextBoxColumn1
            // 
            depthDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            depthDataGridViewTextBoxColumn1.DataPropertyName = "Depth";
            depthDataGridViewTextBoxColumn1.HeaderText = "Глубина";
            depthDataGridViewTextBoxColumn1.Name = "depthDataGridViewTextBoxColumn1";
            depthDataGridViewTextBoxColumn1.ReadOnly = true;
            depthDataGridViewTextBoxColumn1.Width = 78;
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            weightDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn1.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            weightDataGridViewTextBoxColumn1.ReadOnly = true;
            weightDataGridViewTextBoxColumn1.Width = 51;
            // 
            // volumeDataGridViewTextBoxColumn1
            // 
            volumeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            volumeDataGridViewTextBoxColumn1.DataPropertyName = "Volume";
            volumeDataGridViewTextBoxColumn1.HeaderText = "Объем";
            volumeDataGridViewTextBoxColumn1.Name = "volumeDataGridViewTextBoxColumn1";
            volumeDataGridViewTextBoxColumn1.ReadOnly = true;
            volumeDataGridViewTextBoxColumn1.Width = 70;
            // 
            // ExpirationDate
            // 
            ExpirationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ExpirationDate.DataPropertyName = "ExpirationDate";
            ExpirationDate.HeaderText = "Срок годности";
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.ReadOnly = true;
            ExpirationDate.Width = 104;
            // 
            // manufactureDateDataGridViewTextBoxColumn
            // 
            manufactureDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            manufactureDateDataGridViewTextBoxColumn.DataPropertyName = "ManufactureDate";
            manufactureDateDataGridViewTextBoxColumn.HeaderText = "Дата производства";
            manufactureDateDataGridViewTextBoxColumn.Name = "manufactureDateDataGridViewTextBoxColumn";
            manufactureDateDataGridViewTextBoxColumn.ReadOnly = true;
            manufactureDateDataGridViewTextBoxColumn.Width = 124;
            // 
            // boxBindingSource
            // 
            boxBindingSource.DataSource = typeof(Classes.Box);
            // 
            // AdditionalnfoBoxGroupBox
            // 
            AdditionalnfoBoxGroupBox.Controls.Add(ManufactureDateTimePicker);
            AdditionalnfoBoxGroupBox.Controls.Add(ExpirationDateTimePicker);
            AdditionalnfoBoxGroupBox.Controls.Add(ManufactureDateCheckBox);
            AdditionalnfoBoxGroupBox.Controls.Add(ExpirationDateCheckBox);
            AdditionalnfoBoxGroupBox.Controls.Add(NumberPalletComboBox);
            AdditionalnfoBoxGroupBox.Controls.Add(label1);
            AdditionalnfoBoxGroupBox.Location = new Point(6, 96);
            AdditionalnfoBoxGroupBox.Name = "AdditionalnfoBoxGroupBox";
            AdditionalnfoBoxGroupBox.Size = new Size(317, 101);
            AdditionalnfoBoxGroupBox.TabIndex = 1;
            AdditionalnfoBoxGroupBox.TabStop = false;
            AdditionalnfoBoxGroupBox.Text = "Дополнительные параметры";
            // 
            // ManufactureDateTimePicker
            // 
            ManufactureDateTimePicker.Location = new Point(166, 64);
            ManufactureDateTimePicker.Name = "ManufactureDateTimePicker";
            ManufactureDateTimePicker.Size = new Size(139, 23);
            ManufactureDateTimePicker.TabIndex = 5;
            ManufactureDateTimePicker.Visible = false;
            // 
            // ExpirationDateTimePicker
            // 
            ExpirationDateTimePicker.Location = new Point(166, 40);
            ExpirationDateTimePicker.Name = "ExpirationDateTimePicker";
            ExpirationDateTimePicker.Size = new Size(139, 23);
            ExpirationDateTimePicker.TabIndex = 4;
            ExpirationDateTimePicker.Visible = false;
            // 
            // ManufactureDateCheckBox
            // 
            ManufactureDateCheckBox.AutoSize = true;
            ManufactureDateCheckBox.Location = new Point(10, 69);
            ManufactureDateCheckBox.Name = "ManufactureDateCheckBox";
            ManufactureDateCheckBox.Size = new Size(129, 19);
            ManufactureDateCheckBox.TabIndex = 3;
            ManufactureDateCheckBox.Text = "Дата производства";
            ManufactureDateCheckBox.UseVisualStyleBackColor = true;
            ManufactureDateCheckBox.CheckedChanged += ManufactureDateCheckBox_CheckedChanged;
            // 
            // ExpirationDateCheckBox
            // 
            ExpirationDateCheckBox.AutoSize = true;
            ExpirationDateCheckBox.Location = new Point(10, 41);
            ExpirationDateCheckBox.Name = "ExpirationDateCheckBox";
            ExpirationDateCheckBox.Size = new Size(107, 19);
            ExpirationDateCheckBox.TabIndex = 2;
            ExpirationDateCheckBox.Text = "Срок годности";
            ExpirationDateCheckBox.UseVisualStyleBackColor = true;
            ExpirationDateCheckBox.CheckedChanged += ExpirationDateCheckBox_CheckedChanged;
            // 
            // NumberPalletComboBox
            // 
            NumberPalletComboBox.DataSource = palletBindingSource;
            NumberPalletComboBox.DisplayMember = "Id";
            NumberPalletComboBox.FormattingEnabled = true;
            NumberPalletComboBox.Location = new Point(166, 16);
            NumberPalletComboBox.Name = "NumberPalletComboBox";
            NumberPalletComboBox.Size = new Size(139, 23);
            NumberPalletComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Выберите паллет";
            // 
            // MainInfoBoxGroupBox
            // 
            MainInfoBoxGroupBox.Controls.Add(DepthBoxTextBox);
            MainInfoBoxGroupBox.Controls.Add(HeightBoxTextBox);
            MainInfoBoxGroupBox.Controls.Add(WidthBoxTextBox);
            MainInfoBoxGroupBox.Controls.Add(SeparatorBoxLabel2);
            MainInfoBoxGroupBox.Controls.Add(label2aSeparatorBoxLabel1);
            MainInfoBoxGroupBox.Controls.Add(DepthBoxLabel);
            MainInfoBoxGroupBox.Controls.Add(HeightBoxLabel);
            MainInfoBoxGroupBox.Controls.Add(WidthBoxLabel);
            MainInfoBoxGroupBox.Location = new Point(6, 17);
            MainInfoBoxGroupBox.Name = "MainInfoBoxGroupBox";
            MainInfoBoxGroupBox.Size = new Size(317, 73);
            MainInfoBoxGroupBox.TabIndex = 0;
            MainInfoBoxGroupBox.TabStop = false;
            MainInfoBoxGroupBox.Text = "Основные параметры";
            // 
            // SeparatorBoxLabel2
            // 
            SeparatorBoxLabel2.AutoSize = true;
            SeparatorBoxLabel2.Location = new Point(198, 40);
            SeparatorBoxLabel2.Name = "SeparatorBoxLabel2";
            SeparatorBoxLabel2.Size = new Size(14, 15);
            SeparatorBoxLabel2.TabIndex = 5;
            SeparatorBoxLabel2.Text = "X";
            // 
            // label2aSeparatorBoxLabel1
            // 
            label2aSeparatorBoxLabel1.AutoSize = true;
            label2aSeparatorBoxLabel1.Location = new Point(92, 40);
            label2aSeparatorBoxLabel1.Name = "label2aSeparatorBoxLabel1";
            label2aSeparatorBoxLabel1.Size = new Size(14, 15);
            label2aSeparatorBoxLabel1.TabIndex = 4;
            label2aSeparatorBoxLabel1.Text = "X";
            // 
            // DepthBoxLabel
            // 
            DepthBoxLabel.AutoSize = true;
            DepthBoxLabel.Location = new Point(234, 19);
            DepthBoxLabel.Name = "DepthBoxLabel";
            DepthBoxLabel.Size = new Size(53, 15);
            DepthBoxLabel.TabIndex = 3;
            DepthBoxLabel.Text = "Глубина";
            // 
            // HeightBoxLabel
            // 
            HeightBoxLabel.AutoSize = true;
            HeightBoxLabel.Location = new Point(130, 19);
            HeightBoxLabel.Name = "HeightBoxLabel";
            HeightBoxLabel.Size = new Size(47, 15);
            HeightBoxLabel.TabIndex = 2;
            HeightBoxLabel.Text = "Высота";
            // 
            // WidthBoxLabel
            // 
            WidthBoxLabel.AutoSize = true;
            WidthBoxLabel.Location = new Point(23, 19);
            WidthBoxLabel.Name = "WidthBoxLabel";
            WidthBoxLabel.Size = new Size(52, 15);
            WidthBoxLabel.TabIndex = 1;
            WidthBoxLabel.Text = "Ширина";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1009, 521);
            Controls.Add(InfoBoxGroupBox);
            Controls.Add(InfoPalletGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            Load += MainForm_Load;
            InfoPalletGroupBox.ResumeLayout(false);
            MainInfoPalletGroupBox.ResumeLayout(false);
            MainInfoPalletGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletBindingSource).EndInit();
            InfoBoxGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).EndInit();
            AdditionalnfoBoxGroupBox.ResumeLayout(false);
            AdditionalnfoBoxGroupBox.PerformLayout();
            MainInfoBoxGroupBox.ResumeLayout(false);
            MainInfoBoxGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox InfoPalletGroupBox;
        private GroupBox MainInfoPalletGroupBox;
        private TextBox DepthPalletTextBox;
        private TextBox HeightPalletTextBox;
        private TextBox WidthPalletTextBox;
        private Label SeparatorPalletLabel2;
        private Label SeparatorPalletLabel1;
        private Label DepthPalletLabel;
        private Label HeightPalletLabel;
        private Label WidthPalletLabel;
        private Button CreatePalletButton;
        private ToolTip Hint;
        private GroupBox InfoBoxGroupBox;
        private GroupBox MainInfoBoxGroupBox;
        private Button CreateBoxButton;
        private TextBox DepthBoxTextBox;
        private TextBox HeightBoxTextBox;
        private TextBox WidthBoxTextBox;
        private Label SeparatorBoxLabel2;
        private Label label2aSeparatorBoxLabel1;
        private Label DepthBoxLabel;
        private Label HeightBoxLabel;
        private Label WidthBoxLabel;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource palletBindingSource;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn1;
        private BindingSource boxBindingSource;
        private GroupBox AdditionalnfoBoxGroupBox;
        private Label label1;
        private DateTimePicker ManufactureDateTimePicker;
        private DateTimePicker ExpirationDateTimePicker;
        private CheckBox ManufactureDateCheckBox;
        private CheckBox ExpirationDateCheckBox;
        private ComboBox NumberPalletComboBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn palletIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewTextBoxColumn manufactureDateDataGridViewTextBoxColumn;
    }
}