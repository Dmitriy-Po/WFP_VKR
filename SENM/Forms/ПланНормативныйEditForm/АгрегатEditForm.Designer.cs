namespace SENM.Forms.ПланНормативныйEditForm
{
    partial class АгрегатEditForm
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
            this.editFormControl1 = new SENM.EditFormControl();
            this.SuspendLayout();
            // 
            // editFormControl1
            // 
            this.editFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editFormControl1.Location = new System.Drawing.Point(0, 0);
            this.editFormControl1.Name = "editFormControl1";
            this.editFormControl1.Size = new System.Drawing.Size(449, 389);
            this.editFormControl1.TabIndex = 0;
            // 
            // АгрегатEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 389);
            this.Controls.Add(this.editFormControl1);
            this.Name = "АгрегатEditForm";
            this.Text = "АгрегатEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private EditFormControl editFormControl1;
    }
}