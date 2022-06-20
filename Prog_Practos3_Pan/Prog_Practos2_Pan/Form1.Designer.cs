
namespace Prog_Practos2_Pan
{
    partial class Practos2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbColl = new System.Windows.Forms.ComboBox();
            this.cmbRows = new System.Windows.Forms.ComboBox();
            this.ArrayView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете количество строк и столбцов в таблице";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Столбцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Строки";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(164, 64);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 29);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbColl
            // 
            this.cmbColl.FormattingEnabled = true;
            this.cmbColl.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbColl.Location = new System.Drawing.Point(12, 65);
            this.cmbColl.Name = "cmbColl";
            this.cmbColl.Size = new System.Drawing.Size(70, 28);
            this.cmbColl.TabIndex = 4;
            this.cmbColl.Text = "2";
            // 
            // cmbRows
            // 
            this.cmbRows.FormattingEnabled = true;
            this.cmbRows.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbRows.Location = new System.Drawing.Point(88, 64);
            this.cmbRows.Name = "cmbRows";
            this.cmbRows.Size = new System.Drawing.Size(70, 28);
            this.cmbRows.TabIndex = 5;
            this.cmbRows.Text = "2";
            // 
            // ArrayView
            // 
            this.ArrayView.AllowUserToAddRows = false;
            this.ArrayView.AllowUserToDeleteRows = false;
            this.ArrayView.AllowUserToResizeColumns = false;
            this.ArrayView.AllowUserToResizeRows = false;
            this.ArrayView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ArrayView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ArrayView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayView.Location = new System.Drawing.Point(12, 99);
            this.ArrayView.Name = "ArrayView";
            this.ArrayView.ReadOnly = true;
            this.ArrayView.RowHeadersWidth = 51;
            this.ArrayView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ArrayView.RowTemplate.Height = 29;
            this.ArrayView.Size = new System.Drawing.Size(356, 188);
            this.ArrayView.TabIndex = 6;
            // 
            // Practos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 307);
            this.Controls.Add(this.ArrayView);
            this.Controls.Add(this.cmbRows);
            this.Controls.Add(this.cmbColl);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Practos2";
            this.Text = "Табличное представление данных на языке C#";
            ((System.ComponentModel.ISupportInitialize)(this.ArrayView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbColl;
        private System.Windows.Forms.ComboBox cmbRows;
        private System.Windows.Forms.DataGridView ArrayView;
    }
}

