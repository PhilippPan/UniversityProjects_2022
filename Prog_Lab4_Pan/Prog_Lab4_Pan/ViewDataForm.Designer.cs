
namespace Prog_Lab4_Pan
{
    partial class ViewDataForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTable1 = new System.Windows.Forms.DataGridView();
            this.dgvTable2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTable1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTable2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1495, 758);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTable1
            // 
            this.dgvTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable1.Location = new System.Drawing.Point(3, 3);
            this.dgvTable1.Name = "dgvTable1";
            this.dgvTable1.RowHeadersWidth = 51;
            this.dgvTable1.RowTemplate.Height = 24;
            this.dgvTable1.Size = new System.Drawing.Size(1489, 373);
            this.dgvTable1.TabIndex = 0;
            // 
            // dgvTable2
            // 
            this.dgvTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable2.Location = new System.Drawing.Point(4, 478);
            this.dgvTable2.Name = "dgvTable2";
            this.dgvTable2.RowHeadersWidth = 51;
            this.dgvTable2.RowTemplate.Height = 24;
            this.dgvTable2.Size = new System.Drawing.Size(1861, 466);
            this.dgvTable2.TabIndex = 1;
            // 
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewDataForm";
            this.Text = "Отображение данных из таблицы";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTable1;
        private System.Windows.Forms.DataGridView dgvTable2;
    }
}