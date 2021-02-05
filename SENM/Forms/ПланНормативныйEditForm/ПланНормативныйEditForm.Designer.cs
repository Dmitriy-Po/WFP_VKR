namespace SENM.Forms.ПланНормативныйEditForm
{
    partial class ПланНормативныйEditForm
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
            this.textBoxОбъёмПроизводства = new System.Windows.Forms.TextBox();
            this.dateTimePickerДатаНачала = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerДатаЗавершения = new System.Windows.Forms.DateTimePicker();
            this.labelДатаНачала = new System.Windows.Forms.Label();
            this.labelДатаЗавершения = new System.Windows.Forms.Label();
            this.labelОбъёмПроизводства = new System.Windows.Forms.Label();
            this.labelАгрегат = new System.Windows.Forms.Label();
            this.labelОписание = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.времяЗамераПотребленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.значениеПотребленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоеПотреблениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxАгрегат = new System.Windows.Forms.ComboBox();
            this.агрегатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonДобавитьСостояниеВПлан = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеПотреблениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.агрегатBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxОбъёмПроизводства
            // 
            this.textBoxОбъёмПроизводства.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxОбъёмПроизводства.Location = new System.Drawing.Point(310, 64);
            this.textBoxОбъёмПроизводства.Name = "textBoxОбъёмПроизводства";
            this.textBoxОбъёмПроизводства.Size = new System.Drawing.Size(200, 20);
            this.textBoxОбъёмПроизводства.TabIndex = 0;
            // 
            // dateTimePickerДатаНачала
            // 
            this.dateTimePickerДатаНачала.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerДатаНачала.Location = new System.Drawing.Point(310, 12);
            this.dateTimePickerДатаНачала.Name = "dateTimePickerДатаНачала";
            this.dateTimePickerДатаНачала.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerДатаНачала.TabIndex = 1;
            // 
            // dateTimePickerДатаЗавершения
            // 
            this.dateTimePickerДатаЗавершения.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerДатаЗавершения.Location = new System.Drawing.Point(310, 38);
            this.dateTimePickerДатаЗавершения.Name = "dateTimePickerДатаЗавершения";
            this.dateTimePickerДатаЗавершения.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerДатаЗавершения.TabIndex = 2;
            // 
            // labelДатаНачала
            // 
            this.labelДатаНачала.AutoSize = true;
            this.labelДатаНачала.Location = new System.Drawing.Point(12, 12);
            this.labelДатаНачала.Name = "labelДатаНачала";
            this.labelДатаНачала.Size = new System.Drawing.Size(71, 13);
            this.labelДатаНачала.TabIndex = 3;
            this.labelДатаНачала.Text = "Дата начала";
            this.labelДатаНачала.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelДатаЗавершения
            // 
            this.labelДатаЗавершения.AutoSize = true;
            this.labelДатаЗавершения.Location = new System.Drawing.Point(12, 37);
            this.labelДатаЗавершения.Name = "labelДатаЗавершения";
            this.labelДатаЗавершения.Size = new System.Drawing.Size(98, 13);
            this.labelДатаЗавершения.TabIndex = 4;
            this.labelДатаЗавершения.Text = "Дата завершения";
            // 
            // labelОбъёмПроизводства
            // 
            this.labelОбъёмПроизводства.AutoSize = true;
            this.labelОбъёмПроизводства.Location = new System.Drawing.Point(12, 62);
            this.labelОбъёмПроизводства.Name = "labelОбъёмПроизводства";
            this.labelОбъёмПроизводства.Size = new System.Drawing.Size(116, 13);
            this.labelОбъёмПроизводства.TabIndex = 5;
            this.labelОбъёмПроизводства.Text = "Объём производства";
            // 
            // labelАгрегат
            // 
            this.labelАгрегат.AutoSize = true;
            this.labelАгрегат.ForeColor = System.Drawing.Color.Red;
            this.labelАгрегат.Location = new System.Drawing.Point(12, 87);
            this.labelАгрегат.Name = "labelАгрегат";
            this.labelАгрегат.Size = new System.Drawing.Size(203, 13);
            this.labelАгрегат.TabIndex = 6;
            this.labelАгрегат.Text = "Агрегат (выбрать состояние агрегата)";
            // 
            // labelОписание
            // 
            this.labelОписание.AutoSize = true;
            this.labelОписание.Location = new System.Drawing.Point(12, 191);
            this.labelОписание.Name = "labelОписание";
            this.labelОписание.Size = new System.Drawing.Size(57, 13);
            this.labelОписание.TabIndex = 7;
            this.labelОписание.Text = "Описание";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времяЗамераПотребленияDataGridViewTextBoxColumn,
            this.значениеПотребленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.фактическоеПотреблениеBindingSource, "Id", true));
            this.dataGridView1.DataSource = this.фактическоеПотреблениеBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 257);
            this.dataGridView1.TabIndex = 8;
            // 
            // времяЗамераПотребленияDataGridViewTextBoxColumn
            // 
            this.времяЗамераПотребленияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.времяЗамераПотребленияDataGridViewTextBoxColumn.DataPropertyName = "ВремяЗамераПотребления";
            this.времяЗамераПотребленияDataGridViewTextBoxColumn.HeaderText = "ВремяЗамераПотребления";
            this.времяЗамераПотребленияDataGridViewTextBoxColumn.Name = "времяЗамераПотребленияDataGridViewTextBoxColumn";
            this.времяЗамераПотребленияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // значениеПотребленияDataGridViewTextBoxColumn
            // 
            this.значениеПотребленияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.значениеПотребленияDataGridViewTextBoxColumn.DataPropertyName = "ЗначениеПотребления";
            this.значениеПотребленияDataGridViewTextBoxColumn.HeaderText = "ЗначениеПотребления";
            this.значениеПотребленияDataGridViewTextBoxColumn.Name = "значениеПотребленияDataGridViewTextBoxColumn";
            this.значениеПотребленияDataGridViewTextBoxColumn.Width = 147;
            // 
            // фактическоеПотреблениеBindingSource
            // 
            this.фактическоеПотреблениеBindingSource.DataSource = typeof(TestCodeFirst.ФактическоеПотребление);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(310, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 38);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // comboBoxАгрегат
            // 
            this.comboBoxАгрегат.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxАгрегат.DataSource = this.агрегатBindingSource;
            this.comboBoxАгрегат.DisplayMember = "Модель";
            this.comboBoxАгрегат.FormattingEnabled = true;
            this.comboBoxАгрегат.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxАгрегат.Location = new System.Drawing.Point(310, 90);
            this.comboBoxАгрегат.Name = "comboBoxАгрегат";
            this.comboBoxАгрегат.Size = new System.Drawing.Size(169, 21);
            this.comboBoxАгрегат.TabIndex = 10;
            this.comboBoxАгрегат.ValueMember = "Id";
            this.comboBoxАгрегат.SelectedIndexChanged += new System.EventHandler(this.comboBoxАгрегат_SelectedIndexChanged);
            // 
            // агрегатBindingSource
            // 
            this.агрегатBindingSource.DataSource = typeof(TestCodeFirst.ТехнологическаяУстановка);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonДобавитьСостояниеВПлан);
            this.panel1.Controls.Add(this.labelДатаНачала);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.labelОписание);
            this.panel1.Controls.Add(this.comboBoxАгрегат);
            this.panel1.Controls.Add(this.dateTimePickerДатаНачала);
            this.panel1.Controls.Add(this.dateTimePickerДатаЗавершения);
            this.panel1.Controls.Add(this.labelДатаЗавершения);
            this.panel1.Controls.Add(this.textBoxОбъёмПроизводства);
            this.panel1.Controls.Add(this.labelАгрегат);
            this.panel1.Controls.Add(this.labelОбъёмПроизводства);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 267);
            this.panel1.TabIndex = 11;
            // 
            // buttonДобавитьСостояниеВПлан
            // 
            this.buttonДобавитьСостояниеВПлан.Location = new System.Drawing.Point(485, 86);
            this.buttonДобавитьСостояниеВПлан.Name = "buttonДобавитьСостояниеВПлан";
            this.buttonДобавитьСостояниеВПлан.Size = new System.Drawing.Size(25, 25);
            this.buttonДобавитьСостояниеВПлан.TabIndex = 11;
            this.buttonДобавитьСостояниеВПлан.Text = "...";
            this.buttonДобавитьСостояниеВПлан.UseVisualStyleBackColor = true;
            this.buttonДобавитьСостояниеВПлан.Click += new System.EventHandler(this.buttonДобавитьСостояниеВПлан_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.buttonSaveAndClose);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 87);
            this.panel3.TabIndex = 11;
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSaveAndClose.Location = new System.Drawing.Point(88, 12);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(40, 40);
            this.buttonSaveAndClose.TabIndex = 5;
            this.buttonSaveAndClose.UseVisualStyleBackColor = false;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сохранить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сохранить \r\nи закрыть";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(15, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(40, 40);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 87);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(522, 539);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 12;
            // 
            // ПланНормативныйEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 626);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.агрегатBindingSource, "Id", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.агрегатBindingSource, "Модель", true));
            this.MinimumSize = new System.Drawing.Size(380, 420);
            this.Name = "ПланНормативныйEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "План нормативный (редактирование)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеПотреблениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.агрегатBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxОбъёмПроизводства;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаНачала;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаЗавершения;
        private System.Windows.Forms.Label labelДатаНачала;
        private System.Windows.Forms.Label labelДатаЗавершения;
        private System.Windows.Forms.Label labelОбъёмПроизводства;
        private System.Windows.Forms.Label labelАгрегат;
        private System.Windows.Forms.Label labelОписание;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxАгрегат;
        private System.Windows.Forms.BindingSource фактическоеПотреблениеBindingSource;
        private System.Windows.Forms.BindingSource агрегатBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяЗамераПотребленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn значениеПотребленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonДобавитьСостояниеВПлан;
    }
}