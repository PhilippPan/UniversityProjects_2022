
namespace Prog_Lab3_Pan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.tbD1 = new System.Windows.Forms.TrackBar();
            this.tbD2 = new System.Windows.Forms.TrackBar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.txtErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название предприятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Общее число рабочих";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(389, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число рабочих должностей, замещенных рабочими необходимого разряда";
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(389, 59);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(304, 27);
            this.txtD2.TabIndex = 3;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(208, 59);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(165, 27);
            this.txtD1.TabIndex = 4;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(12, 59);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(172, 27);
            this.txtPName.TabIndex = 5;
            // 
            // tbD1
            // 
            this.tbD1.Location = new System.Drawing.Point(208, 92);
            this.tbD1.Maximum = 100;
            this.tbD1.Minimum = 1;
            this.tbD1.Name = "tbD1";
            this.tbD1.Size = new System.Drawing.Size(165, 56);
            this.tbD1.TabIndex = 6;
            this.tbD1.Value = 10;
            this.tbD1.Scroll += new System.EventHandler(this.tbD1_Scroll);
            // 
            // tbD2
            // 
            this.tbD2.Location = new System.Drawing.Point(389, 92);
            this.tbD2.Maximum = 100;
            this.tbD2.Minimum = 1;
            this.tbD2.Name = "tbD2";
            this.tbD2.Size = new System.Drawing.Size(304, 56);
            this.tbD2.TabIndex = 7;
            this.tbD2.Value = 5;
            this.tbD2.Scroll += new System.EventHandler(this.tbD2_Scroll);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить данные";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить выбранную строку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(415, 145);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(279, 29);
            this.btnNote.TabIndex = 10;
            this.btnNote.Text = "Получить справку по предприятию";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AllowUserToResizeColumns = false;
            this.dgTable.AllowUserToResizeRows = false;
            this.dgTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(12, 180);
            this.dgTable.MultiSelect = false;
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.RowHeadersWidth = 51;
            this.dgTable.RowTemplate.Height = 29;
            this.dgTable.Size = new System.Drawing.Size(697, 258);
            this.dgTable.TabIndex = 11;
            // 
            // txtErr
            // 
            this.txtErr.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtErr.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtErr.Location = new System.Drawing.Point(13, 92);
            this.txtErr.Name = "txtErr";
            this.txtErr.Size = new System.Drawing.Size(171, 50);
            this.txtErr.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.txtErr);
            this.Controls.Add(this.dgTable);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbD2);
            this.Controls.Add(this.tbD1);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(740, 500);
            this.MinimumSize = new System.Drawing.Size(739, 497);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение GUI-приложений на С# - Pan";
            ((System.ComponentModel.ISupportInitialize)(this.tbD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TrackBar tbD1;
        private System.Windows.Forms.TrackBar tbD2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Label txtErr;
    }
}

