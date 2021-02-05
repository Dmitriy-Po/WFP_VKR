namespace SENM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddNewPlan = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowАгрегат = new System.Windows.Forms.Button();
            this.buttonУдалитьПлан = new System.Windows.Forms.Button();
            this.buttonРедактироватьПлан = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColumnCheckRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonCalculatePlan = new System.Windows.Forms.Button();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЧасовРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.агрегатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.планНормативныйТехнологическийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.планНормативныйТехнологическийBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.планНормативныйТехнологическийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.планНормативныйТехнологическийBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewPlan
            // 
            this.buttonAddNewPlan.Location = new System.Drawing.Point(6, 19);
            this.buttonAddNewPlan.Name = "buttonAddNewPlan";
            this.buttonAddNewPlan.Size = new System.Drawing.Size(120, 23);
            this.buttonAddNewPlan.TabIndex = 0;
            this.buttonAddNewPlan.Text = "Добавить новый";
            this.buttonAddNewPlan.UseVisualStyleBackColor = true;
            this.buttonAddNewPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonCalculatePlan);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowАгрегат);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(585, 271);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheckRow,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаЗавершенияDataGridViewTextBoxColumn,
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.количествоЧасовРаботыDataGridViewTextBoxColumn,
            this.агрегатDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.планНормативныйТехнологическийBindingSource, "Id", true));
            this.dataGridView1.DataSource = this.планНормативныйТехнологическийBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(585, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonShowАгрегат
            // 
            this.buttonShowАгрегат.Location = new System.Drawing.Point(355, 12);
            this.buttonShowАгрегат.Name = "buttonShowАгрегат";
            this.buttonShowАгрегат.Size = new System.Drawing.Size(218, 23);
            this.buttonShowАгрегат.TabIndex = 1;
            this.buttonShowАгрегат.Text = "Добавить новый агрегат";
            this.buttonShowАгрегат.UseVisualStyleBackColor = true;
            this.buttonShowАгрегат.Click += new System.EventHandler(this.buttonShowАгрегат_Click);
            // 
            // buttonУдалитьПлан
            // 
            this.buttonУдалитьПлан.Location = new System.Drawing.Point(6, 77);
            this.buttonУдалитьПлан.Name = "buttonУдалитьПлан";
            this.buttonУдалитьПлан.Size = new System.Drawing.Size(120, 23);
            this.buttonУдалитьПлан.TabIndex = 2;
            this.buttonУдалитьПлан.Text = "Удалить";
            this.buttonУдалитьПлан.UseVisualStyleBackColor = true;
            // 
            // buttonРедактироватьПлан
            // 
            this.buttonРедактироватьПлан.Location = new System.Drawing.Point(6, 48);
            this.buttonРедактироватьПлан.Name = "buttonРедактироватьПлан";
            this.buttonРедактироватьПлан.Size = new System.Drawing.Size(120, 23);
            this.buttonРедактироватьПлан.TabIndex = 3;
            this.buttonРедактироватьПлан.Text = "Редактировать";
            this.buttonРедактироватьПлан.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonУдалитьПлан);
            this.groupBox1.Controls.Add(this.buttonРедактироватьПлан);
            this.groupBox1.Controls.Add(this.buttonAddNewPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции с планом";
            // 
            // ColumnCheckRow
            // 
            this.ColumnCheckRow.HeaderText = "";
            this.ColumnCheckRow.Name = "ColumnCheckRow";
            this.ColumnCheckRow.ReadOnly = true;
            this.ColumnCheckRow.Width = 25;
            // 
            // buttonCalculatePlan
            // 
            this.buttonCalculatePlan.Location = new System.Drawing.Point(355, 41);
            this.buttonCalculatePlan.Name = "buttonCalculatePlan";
            this.buttonCalculatePlan.Size = new System.Drawing.Size(218, 23);
            this.buttonCalculatePlan.TabIndex = 5;
            this.buttonCalculatePlan.Text = "Рассчитать технологический план";
            this.buttonCalculatePlan.UseVisualStyleBackColor = true;
            this.buttonCalculatePlan.Click += new System.EventHandler(this.buttonCalculatePlan_Click);
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "ДатаНачала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "ДатаНачала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаНачалаDataGridViewTextBoxColumn.Width = 95;
            // 
            // датаЗавершенияDataGridViewTextBoxColumn
            // 
            this.датаЗавершенияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.датаЗавершенияDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗавершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.HeaderText = "ДатаЗавершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.Name = "датаЗавершенияDataGridViewTextBoxColumn";
            this.датаЗавершенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗавершенияDataGridViewTextBoxColumn.Width = 121;
            // 
            // целевойОбъёмПроизводстваDataGridViewTextBoxColumn
            // 
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.DataPropertyName = "ЦелевойОбъёмПроизводства";
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.HeaderText = "ЦелевойОбъёмПроизводства";
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.Name = "целевойОбъёмПроизводстваDataGridViewTextBoxColumn";
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.ReadOnly = true;
            this.целевойОбъёмПроизводстваDataGridViewTextBoxColumn.Width = 184;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоЧасовРаботыDataGridViewTextBoxColumn
            // 
            this.количествоЧасовРаботыDataGridViewTextBoxColumn.DataPropertyName = "КоличествоЧасовРаботы";
            this.количествоЧасовРаботыDataGridViewTextBoxColumn.HeaderText = "КоличествоЧасовРаботы";
            this.количествоЧасовРаботыDataGridViewTextBoxColumn.Name = "количествоЧасовРаботыDataGridViewTextBoxColumn";
            this.количествоЧасовРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоЧасовРаботыDataGridViewTextBoxColumn.Visible = false;
            // 
            // агрегатDataGridViewTextBoxColumn
            // 
            this.агрегатDataGridViewTextBoxColumn.DataPropertyName = "Агрегат";
            this.агрегатDataGridViewTextBoxColumn.HeaderText = "Агрегат";
            this.агрегатDataGridViewTextBoxColumn.Name = "агрегатDataGridViewTextBoxColumn";
            this.агрегатDataGridViewTextBoxColumn.ReadOnly = true;
            this.агрегатDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // планНормативныйТехнологическийBindingSource
            // 
            this.планНормативныйТехнологическийBindingSource.DataSource = typeof(TestCodeFirst.ПланНормативныйТехнологический);
            // 
            // планНормативныйТехнологическийBindingSource1
            // 
            this.планНормативныйТехнологическийBindingSource1.DataSource = typeof(TestCodeFirst.ПланНормативныйТехнологический);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 271);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(601, 309);
            this.Name = "Form1";
            this.Text = "Список планов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.планНормативныйТехнологическийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.планНормативныйТехнологическийBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewPlan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource планНормативныйТехнологическийBindingSource;
        private System.Windows.Forms.BindingSource планНормативныйТехнологическийBindingSource1;
        private System.Windows.Forms.Button buttonShowАгрегат;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonУдалитьПлан;
        private System.Windows.Forms.Button buttonРедактироватьПлан;
        private System.Windows.Forms.Button buttonCalculatePlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheckRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn целевойОбъёмПроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЧасовРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn агрегатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

