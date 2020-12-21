namespace ArticlesOntologySorter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.originLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.algoritmhLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.combosLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nCombo = new System.Windows.Forms.ComboBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.betaLabel = new System.Windows.Forms.Label();
            this.betaCombo = new System.Windows.Forms.ComboBox();
            this.mainInterfaceTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadOntologyBtn = new System.Windows.Forms.Button();
            this.loadArticlesBtn = new System.Windows.Forms.Button();
            this.arrangeArticlesBtn = new System.Windows.Forms.Button();
            this.connOntologiesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connOntosCombo = new System.Windows.Forms.ComboBox();
            this.connOntologiesLabel = new System.Windows.Forms.Label();
            this.articlesDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleInformationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.connSentencesLabel = new System.Windows.Forms.Label();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.annotationLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.keyWordsLabel = new System.Windows.Forms.Label();
            this.authorsRTB = new System.Windows.Forms.RichTextBox();
            this.titleRTB = new System.Windows.Forms.RichTextBox();
            this.annotationRTB = new System.Windows.Forms.RichTextBox();
            this.sourceRTB = new System.Windows.Forms.RichTextBox();
            this.yearRTB = new System.Windows.Forms.RichTextBox();
            this.keyWordsRTB = new System.Windows.Forms.RichTextBox();
            this.connSentencesRTB = new System.Windows.Forms.RichTextBox();
            this.openArticle = new System.Windows.Forms.OpenFileDialog();
            this.openOntology = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            this.originLayoutPanel.SuspendLayout();
            this.dgvLayoutPanel.SuspendLayout();
            this.buttonsLayoutPanel.SuspendLayout();
            this.algoritmhLayoutPanel.SuspendLayout();
            this.combosLayoutPanel.SuspendLayout();
            this.mainInterfaceTableLayout.SuspendLayout();
            this.buttonsTableLayout.SuspendLayout();
            this.connOntologiesTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDGV)).BeginInit();
            this.articleInformationLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.originLayoutPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(946, 567);
            this.mainPanel.TabIndex = 0;
            // 
            // originLayoutPanel
            // 
            this.originLayoutPanel.ColumnCount = 3;
            this.originLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.originLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.originLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.originLayoutPanel.Controls.Add(this.dgvLayoutPanel, 0, 0);
            this.originLayoutPanel.Controls.Add(this.articleInformationLayoutPanel, 2, 0);
            this.originLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.originLayoutPanel.Name = "originLayoutPanel";
            this.originLayoutPanel.RowCount = 1;
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.originLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.originLayoutPanel.Size = new System.Drawing.Size(946, 567);
            this.originLayoutPanel.TabIndex = 0;
            // 
            // dgvLayoutPanel
            // 
            this.dgvLayoutPanel.ColumnCount = 1;
            this.dgvLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dgvLayoutPanel.Controls.Add(this.buttonsLayoutPanel, 0, 1);
            this.dgvLayoutPanel.Controls.Add(this.articlesDGV, 0, 3);
            this.dgvLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.dgvLayoutPanel.Name = "dgvLayoutPanel";
            this.dgvLayoutPanel.RowCount = 5;
            this.dgvLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.dgvLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dgvLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.dgvLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.dgvLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.dgvLayoutPanel.Size = new System.Drawing.Size(555, 561);
            this.dgvLayoutPanel.TabIndex = 0;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.ColumnCount = 3;
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsLayoutPanel.Controls.Add(this.algoritmhLayoutPanel, 2, 0);
            this.buttonsLayoutPanel.Controls.Add(this.mainInterfaceTableLayout, 0, 0);
            this.buttonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(3, 13);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.RowCount = 1;
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(549, 126);
            this.buttonsLayoutPanel.TabIndex = 0;
            // 
            // algoritmhLayoutPanel
            // 
            this.algoritmhLayoutPanel.ColumnCount = 1;
            this.algoritmhLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.algoritmhLayoutPanel.Controls.Add(this.algorithmLabel, 0, 0);
            this.algoritmhLayoutPanel.Controls.Add(this.combosLayoutPanel, 0, 2);
            this.algoritmhLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algoritmhLayoutPanel.Location = new System.Drawing.Point(417, 3);
            this.algoritmhLayoutPanel.Name = "algoritmhLayoutPanel";
            this.algoritmhLayoutPanel.RowCount = 3;
            this.algoritmhLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.algoritmhLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.algoritmhLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.algoritmhLayoutPanel.Size = new System.Drawing.Size(129, 120);
            this.algoritmhLayoutPanel.TabIndex = 3;
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algorithmLabel.Location = new System.Drawing.Point(3, 3);
            this.algorithmLabel.Margin = new System.Windows.Forms.Padding(3);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(123, 51);
            this.algorithmLabel.TabIndex = 0;
            this.algorithmLabel.Text = "Алгоритм ранжирования Efreq-Rnum";
            this.algorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combosLayoutPanel
            // 
            this.combosLayoutPanel.ColumnCount = 2;
            this.combosLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.combosLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.combosLayoutPanel.Controls.Add(this.nCombo, 1, 1);
            this.combosLayoutPanel.Controls.Add(this.nLabel, 0, 1);
            this.combosLayoutPanel.Controls.Add(this.betaLabel, 0, 0);
            this.combosLayoutPanel.Controls.Add(this.betaCombo, 1, 0);
            this.combosLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combosLayoutPanel.Location = new System.Drawing.Point(3, 65);
            this.combosLayoutPanel.Name = "combosLayoutPanel";
            this.combosLayoutPanel.RowCount = 2;
            this.combosLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.combosLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.combosLayoutPanel.Size = new System.Drawing.Size(123, 52);
            this.combosLayoutPanel.TabIndex = 1;
            // 
            // nCombo
            // 
            this.nCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCombo.FormattingEnabled = true;
            this.nCombo.Location = new System.Drawing.Point(39, 29);
            this.nCombo.Name = "nCombo";
            this.nCombo.Size = new System.Drawing.Size(81, 21);
            this.nCombo.TabIndex = 4;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nLabel.Location = new System.Drawing.Point(3, 29);
            this.nLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(30, 20);
            this.nLabel.TabIndex = 3;
            this.nLabel.Text = "n:";
            this.nLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betaLabel
            // 
            this.betaLabel.AutoSize = true;
            this.betaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betaLabel.Location = new System.Drawing.Point(3, 3);
            this.betaLabel.Margin = new System.Windows.Forms.Padding(3);
            this.betaLabel.Name = "betaLabel";
            this.betaLabel.Size = new System.Drawing.Size(30, 20);
            this.betaLabel.TabIndex = 2;
            this.betaLabel.Text = "β:";
            this.betaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betaCombo
            // 
            this.betaCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.betaCombo.FormattingEnabled = true;
            this.betaCombo.Location = new System.Drawing.Point(39, 3);
            this.betaCombo.Name = "betaCombo";
            this.betaCombo.Size = new System.Drawing.Size(81, 21);
            this.betaCombo.TabIndex = 1;
            // 
            // mainInterfaceTableLayout
            // 
            this.mainInterfaceTableLayout.ColumnCount = 1;
            this.mainInterfaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainInterfaceTableLayout.Controls.Add(this.buttonsTableLayout, 0, 0);
            this.mainInterfaceTableLayout.Controls.Add(this.connOntologiesTableLayout, 0, 1);
            this.mainInterfaceTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainInterfaceTableLayout.Location = new System.Drawing.Point(3, 3);
            this.mainInterfaceTableLayout.Name = "mainInterfaceTableLayout";
            this.mainInterfaceTableLayout.RowCount = 2;
            this.mainInterfaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainInterfaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainInterfaceTableLayout.Size = new System.Drawing.Size(398, 120);
            this.mainInterfaceTableLayout.TabIndex = 4;
            // 
            // buttonsTableLayout
            // 
            this.buttonsTableLayout.ColumnCount = 5;
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.Controls.Add(this.loadOntologyBtn, 2, 0);
            this.buttonsTableLayout.Controls.Add(this.loadArticlesBtn, 0, 0);
            this.buttonsTableLayout.Controls.Add(this.arrangeArticlesBtn, 4, 0);
            this.buttonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.buttonsTableLayout.Name = "buttonsTableLayout";
            this.buttonsTableLayout.RowCount = 1;
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayout.Size = new System.Drawing.Size(392, 78);
            this.buttonsTableLayout.TabIndex = 0;
            // 
            // loadOntologyBtn
            // 
            this.loadOntologyBtn.BackColor = System.Drawing.Color.Cyan;
            this.loadOntologyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadOntologyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadOntologyBtn.Location = new System.Drawing.Point(135, 3);
            this.loadOntologyBtn.Name = "loadOntologyBtn";
            this.loadOntologyBtn.Size = new System.Drawing.Size(121, 72);
            this.loadOntologyBtn.TabIndex = 1;
            this.loadOntologyBtn.Text = "Загрузить онтологию";
            this.loadOntologyBtn.UseVisualStyleBackColor = false;
            this.loadOntologyBtn.Click += new System.EventHandler(this.loadOntologyBtn_Click);
            // 
            // loadArticlesBtn
            // 
            this.loadArticlesBtn.BackColor = System.Drawing.Color.Cyan;
            this.loadArticlesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadArticlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadArticlesBtn.Location = new System.Drawing.Point(3, 3);
            this.loadArticlesBtn.Name = "loadArticlesBtn";
            this.loadArticlesBtn.Size = new System.Drawing.Size(121, 72);
            this.loadArticlesBtn.TabIndex = 0;
            this.loadArticlesBtn.Text = "Загрузить статьи";
            this.loadArticlesBtn.UseVisualStyleBackColor = false;
            this.loadArticlesBtn.Click += new System.EventHandler(this.loadArticlesBtn_Click);
            // 
            // arrangeArticlesBtn
            // 
            this.arrangeArticlesBtn.BackColor = System.Drawing.Color.Cyan;
            this.arrangeArticlesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrangeArticlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrangeArticlesBtn.Location = new System.Drawing.Point(267, 3);
            this.arrangeArticlesBtn.Name = "arrangeArticlesBtn";
            this.arrangeArticlesBtn.Size = new System.Drawing.Size(122, 72);
            this.arrangeArticlesBtn.TabIndex = 2;
            this.arrangeArticlesBtn.Text = "Отранжировать статьи";
            this.arrangeArticlesBtn.UseVisualStyleBackColor = false;
            this.arrangeArticlesBtn.Click += new System.EventHandler(this.arrangeArticlesBtn_Click);
            // 
            // connOntologiesTableLayout
            // 
            this.connOntologiesTableLayout.ColumnCount = 2;
            this.connOntologiesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.connOntologiesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.connOntologiesTableLayout.Controls.Add(this.connOntosCombo, 1, 0);
            this.connOntologiesTableLayout.Controls.Add(this.connOntologiesLabel, 0, 0);
            this.connOntologiesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connOntologiesTableLayout.Location = new System.Drawing.Point(3, 87);
            this.connOntologiesTableLayout.Name = "connOntologiesTableLayout";
            this.connOntologiesTableLayout.RowCount = 1;
            this.connOntologiesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connOntologiesTableLayout.Size = new System.Drawing.Size(392, 30);
            this.connOntologiesTableLayout.TabIndex = 1;
            // 
            // connOntosCombo
            // 
            this.connOntosCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connOntosCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connOntosCombo.FormattingEnabled = true;
            this.connOntosCombo.Location = new System.Drawing.Point(297, 3);
            this.connOntosCombo.Name = "connOntosCombo";
            this.connOntosCombo.Size = new System.Drawing.Size(92, 21);
            this.connOntosCombo.TabIndex = 2;
            // 
            // connOntologiesLabel
            // 
            this.connOntologiesLabel.AutoSize = true;
            this.connOntologiesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connOntologiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connOntologiesLabel.Location = new System.Drawing.Point(3, 3);
            this.connOntologiesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.connOntologiesLabel.Name = "connOntologiesLabel";
            this.connOntologiesLabel.Size = new System.Drawing.Size(288, 24);
            this.connOntologiesLabel.TabIndex = 1;
            this.connOntologiesLabel.Text = "Число создаваемых \"привязавшихся\" онтологий, m:";
            this.connOntologiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articlesDGV
            // 
            this.articlesDGV.AllowUserToAddRows = false;
            this.articlesDGV.AllowUserToDeleteRows = false;
            this.articlesDGV.AllowUserToResizeColumns = false;
            this.articlesDGV.AllowUserToResizeRows = false;
            this.articlesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.articlesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Authors});
            this.articlesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlesDGV.GridColor = System.Drawing.SystemColors.Control;
            this.articlesDGV.Location = new System.Drawing.Point(3, 155);
            this.articlesDGV.Name = "articlesDGV";
            this.articlesDGV.ReadOnly = true;
            this.articlesDGV.RowHeadersVisible = false;
            this.articlesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articlesDGV.Size = new System.Drawing.Size(549, 392);
            this.articlesDGV.TabIndex = 1;
            this.articlesDGV.SelectionChanged += new System.EventHandler(this.articlesDGV_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 46;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Authors
            // 
            this.Authors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Authors.HeaderText = "Авторы";
            this.Authors.Name = "Authors";
            this.Authors.ReadOnly = true;
            this.Authors.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // articleInformationLayoutPanel
            // 
            this.articleInformationLayoutPanel.ColumnCount = 3;
            this.articleInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.articleInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.articleInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.articleInformationLayoutPanel.Controls.Add(this.connSentencesLabel, 0, 12);
            this.articleInformationLayoutPanel.Controls.Add(this.authorsLabel, 0, 0);
            this.articleInformationLayoutPanel.Controls.Add(this.titleLabel, 0, 2);
            this.articleInformationLayoutPanel.Controls.Add(this.annotationLabel, 0, 4);
            this.articleInformationLayoutPanel.Controls.Add(this.sourceLabel, 0, 6);
            this.articleInformationLayoutPanel.Controls.Add(this.yearLabel, 0, 8);
            this.articleInformationLayoutPanel.Controls.Add(this.keyWordsLabel, 0, 10);
            this.articleInformationLayoutPanel.Controls.Add(this.authorsRTB, 2, 0);
            this.articleInformationLayoutPanel.Controls.Add(this.titleRTB, 2, 2);
            this.articleInformationLayoutPanel.Controls.Add(this.annotationRTB, 2, 4);
            this.articleInformationLayoutPanel.Controls.Add(this.sourceRTB, 2, 6);
            this.articleInformationLayoutPanel.Controls.Add(this.yearRTB, 2, 8);
            this.articleInformationLayoutPanel.Controls.Add(this.keyWordsRTB, 2, 10);
            this.articleInformationLayoutPanel.Controls.Add(this.connSentencesRTB, 2, 12);
            this.articleInformationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleInformationLayoutPanel.Location = new System.Drawing.Point(574, 3);
            this.articleInformationLayoutPanel.Name = "articleInformationLayoutPanel";
            this.articleInformationLayoutPanel.RowCount = 13;
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.articleInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.articleInformationLayoutPanel.Size = new System.Drawing.Size(369, 561);
            this.articleInformationLayoutPanel.TabIndex = 1;
            // 
            // connSentencesLabel
            // 
            this.connSentencesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connSentencesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connSentencesLabel.Location = new System.Drawing.Point(3, 385);
            this.connSentencesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.connSentencesLabel.Name = "connSentencesLabel";
            this.connSentencesLabel.Size = new System.Drawing.Size(101, 173);
            this.connSentencesLabel.TabIndex = 12;
            this.connSentencesLabel.Text = "Связанные предложения";
            this.connSentencesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorsLabel
            // 
            this.authorsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsLabel.Location = new System.Drawing.Point(3, 3);
            this.authorsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(101, 29);
            this.authorsLabel.TabIndex = 0;
            this.authorsLabel.Text = "Авторы";
            this.authorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(3, 43);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(101, 47);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Название";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // annotationLabel
            // 
            this.annotationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.annotationLabel.Location = new System.Drawing.Point(3, 101);
            this.annotationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.annotationLabel.Name = "annotationLabel";
            this.annotationLabel.Size = new System.Drawing.Size(101, 82);
            this.annotationLabel.TabIndex = 2;
            this.annotationLabel.Text = "Аннотация";
            this.annotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceLabel
            // 
            this.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceLabel.Location = new System.Drawing.Point(3, 194);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(101, 47);
            this.sourceLabel.TabIndex = 3;
            this.sourceLabel.Text = "Источник";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(3, 252);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(3);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(101, 29);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Год";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyWordsLabel
            // 
            this.keyWordsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyWordsLabel.Location = new System.Drawing.Point(3, 292);
            this.keyWordsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.keyWordsLabel.Name = "keyWordsLabel";
            this.keyWordsLabel.Size = new System.Drawing.Size(101, 82);
            this.keyWordsLabel.TabIndex = 5;
            this.keyWordsLabel.Text = "Ключевые слова";
            this.keyWordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorsRTB
            // 
            this.authorsRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsRTB.Location = new System.Drawing.Point(120, 3);
            this.authorsRTB.Name = "authorsRTB";
            this.authorsRTB.Size = new System.Drawing.Size(246, 29);
            this.authorsRTB.TabIndex = 6;
            this.authorsRTB.Text = "";
            // 
            // titleRTB
            // 
            this.titleRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleRTB.Location = new System.Drawing.Point(120, 43);
            this.titleRTB.Name = "titleRTB";
            this.titleRTB.Size = new System.Drawing.Size(246, 47);
            this.titleRTB.TabIndex = 7;
            this.titleRTB.Text = "";
            // 
            // annotationRTB
            // 
            this.annotationRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annotationRTB.Location = new System.Drawing.Point(120, 101);
            this.annotationRTB.Name = "annotationRTB";
            this.annotationRTB.Size = new System.Drawing.Size(246, 82);
            this.annotationRTB.TabIndex = 8;
            this.annotationRTB.Text = "";
            // 
            // sourceRTB
            // 
            this.sourceRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceRTB.Location = new System.Drawing.Point(120, 194);
            this.sourceRTB.Name = "sourceRTB";
            this.sourceRTB.Size = new System.Drawing.Size(246, 47);
            this.sourceRTB.TabIndex = 9;
            this.sourceRTB.Text = "";
            // 
            // yearRTB
            // 
            this.yearRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearRTB.Location = new System.Drawing.Point(120, 252);
            this.yearRTB.Name = "yearRTB";
            this.yearRTB.Size = new System.Drawing.Size(246, 29);
            this.yearRTB.TabIndex = 10;
            this.yearRTB.Text = "";
            // 
            // keyWordsRTB
            // 
            this.keyWordsRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyWordsRTB.Location = new System.Drawing.Point(120, 292);
            this.keyWordsRTB.Name = "keyWordsRTB";
            this.keyWordsRTB.Size = new System.Drawing.Size(246, 82);
            this.keyWordsRTB.TabIndex = 11;
            this.keyWordsRTB.Text = "";
            // 
            // connSentencesRTB
            // 
            this.connSentencesRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connSentencesRTB.Location = new System.Drawing.Point(120, 385);
            this.connSentencesRTB.Name = "connSentencesRTB";
            this.connSentencesRTB.Size = new System.Drawing.Size(246, 173);
            this.connSentencesRTB.TabIndex = 13;
            this.connSentencesRTB.Text = "";
            // 
            // openArticle
            // 
            this.openArticle.Multiselect = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 567);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ArticlesOntologySorter";
            this.mainPanel.ResumeLayout(false);
            this.originLayoutPanel.ResumeLayout(false);
            this.dgvLayoutPanel.ResumeLayout(false);
            this.buttonsLayoutPanel.ResumeLayout(false);
            this.algoritmhLayoutPanel.ResumeLayout(false);
            this.algoritmhLayoutPanel.PerformLayout();
            this.combosLayoutPanel.ResumeLayout(false);
            this.combosLayoutPanel.PerformLayout();
            this.mainInterfaceTableLayout.ResumeLayout(false);
            this.buttonsTableLayout.ResumeLayout(false);
            this.connOntologiesTableLayout.ResumeLayout(false);
            this.connOntologiesTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDGV)).EndInit();
            this.articleInformationLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel originLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel dgvLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.Button loadArticlesBtn;
        private System.Windows.Forms.Button loadOntologyBtn;
        private System.Windows.Forms.Button arrangeArticlesBtn;
        private System.Windows.Forms.DataGridView articlesDGV;
        private System.Windows.Forms.TableLayoutPanel articleInformationLayoutPanel;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label annotationLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label keyWordsLabel;
        private System.Windows.Forms.RichTextBox authorsRTB;
        private System.Windows.Forms.RichTextBox titleRTB;
        private System.Windows.Forms.RichTextBox annotationRTB;
        private System.Windows.Forms.RichTextBox sourceRTB;
        private System.Windows.Forms.RichTextBox yearRTB;
        private System.Windows.Forms.RichTextBox keyWordsRTB;
        private System.Windows.Forms.OpenFileDialog openArticle;
        private System.Windows.Forms.OpenFileDialog openOntology;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.TableLayoutPanel algoritmhLayoutPanel;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.ComboBox betaCombo;
        private System.Windows.Forms.TableLayoutPanel combosLayoutPanel;
        private System.Windows.Forms.Label connSentencesLabel;
        private System.Windows.Forms.RichTextBox connSentencesRTB;
        private System.Windows.Forms.ComboBox nCombo;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label betaLabel;
        private System.Windows.Forms.TableLayoutPanel mainInterfaceTableLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayout;
        private System.Windows.Forms.TableLayoutPanel connOntologiesTableLayout;
        private System.Windows.Forms.ComboBox connOntosCombo;
        private System.Windows.Forms.Label connOntologiesLabel;
    }
}

