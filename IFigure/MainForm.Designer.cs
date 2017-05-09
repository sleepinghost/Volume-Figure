namespace Figure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonRemove_Figure = new System.Windows.Forms.Button();
            this.buttonAdd_Figure = new System.Windows.Forms.Button();
            this.dataGridViewFigures = new System.Windows.Forms.DataGridView();
            this.ColumnfigureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnstartX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnstartY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnstartZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumncountVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFigures)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonRemove_Figure);
            this.groupBox1.Controls.Add(this.buttonAdd_Figure);
            this.groupBox1.Controls.Add(this.dataGridViewFigures);
            this.groupBox1.Location = new System.Drawing.Point(24, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(957, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FiguresForm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.Location = new System.Drawing.Point(379, 505);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModify.Location = new System.Drawing.Point(245, 505);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(128, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonRemove_Figure
            // 
            this.buttonRemove_Figure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove_Figure.Location = new System.Drawing.Point(128, 505);
            this.buttonRemove_Figure.Name = "buttonRemove_Figure";
            this.buttonRemove_Figure.Size = new System.Drawing.Size(111, 23);
            this.buttonRemove_Figure.TabIndex = 2;
            this.buttonRemove_Figure.Text = "Remove Figure";
            this.buttonRemove_Figure.UseVisualStyleBackColor = true;
            this.buttonRemove_Figure.Click += new System.EventHandler(this.buttonRemove_Figure_Click);
            // 
            // buttonAdd_Figure
            // 
            this.buttonAdd_Figure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd_Figure.Location = new System.Drawing.Point(6, 502);
            this.buttonAdd_Figure.Name = "buttonAdd_Figure";
            this.buttonAdd_Figure.Size = new System.Drawing.Size(116, 26);
            this.buttonAdd_Figure.TabIndex = 1;
            this.buttonAdd_Figure.Text = "Add Figure";
            this.buttonAdd_Figure.UseVisualStyleBackColor = true;
            this.buttonAdd_Figure.Click += new System.EventHandler(this.buttonAdd_Figure_Click);
            // 
            // dataGridViewFigures
            // 
            this.dataGridViewFigures.AllowUserToAddRows = false;
            this.dataGridViewFigures.AllowUserToDeleteRows = false;
            this.dataGridViewFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFigures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnfigureName,
            this.ColumnstartX,
            this.ColumnstartY,
            this.ColumnstartZ,
            this.ColumncountVolume});
            this.dataGridViewFigures.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFigures.Name = "dataGridViewFigures";
            this.dataGridViewFigures.ReadOnly = true;
            this.dataGridViewFigures.Size = new System.Drawing.Size(945, 477);
            this.dataGridViewFigures.TabIndex = 0;
            // 
            // ColumnfigureName
            // 
            this.ColumnfigureName.HeaderText = "Figure name";
            this.ColumnfigureName.Name = "ColumnfigureName";
            this.ColumnfigureName.ReadOnly = true;
            // 
            // ColumnstartX
            // 
            this.ColumnstartX.HeaderText = "start X";
            this.ColumnstartX.Name = "ColumnstartX";
            this.ColumnstartX.ReadOnly = true;
            // 
            // ColumnstartY
            // 
            this.ColumnstartY.HeaderText = "start Y";
            this.ColumnstartY.Name = "ColumnstartY";
            this.ColumnstartY.ReadOnly = true;
            // 
            // ColumnstartZ
            // 
            this.ColumnstartZ.HeaderText = "start Z";
            this.ColumnstartZ.Name = "ColumnstartZ";
            this.ColumnstartZ.ReadOnly = true;
            // 
            // ColumncountVolume
            // 
            this.ColumncountVolume.HeaderText = "Volume";
            this.ColumncountVolume.Name = "ColumncountVolume";
            this.ColumncountVolume.ReadOnly = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(993, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "Файл";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripFile.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(993, 624);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(607, 250);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFigures)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd_Figure;
        private System.Windows.Forms.Button buttonRemove_Figure;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnfigureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnstartX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnstartY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnstartZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumncountVolume;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.DataGridView dataGridViewFigures;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

