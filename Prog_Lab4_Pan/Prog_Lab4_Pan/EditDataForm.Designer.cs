
namespace Prog_Lab4_Pan
{
    partial class EditDataForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStorageNum = new System.Windows.Forms.TextBox();
            this.txtSupplyCost = new System.Windows.Forms.TextBox();
            this.txtSupplyAmmount = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateT1 = new System.Windows.Forms.Button();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.txtProviderID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateT2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTable1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTable2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1601, 778);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTable1
            // 
            this.dgvTable1.AllowUserToAddRows = false;
            this.dgvTable1.AllowUserToDeleteRows = false;
            this.dgvTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable1.Location = new System.Drawing.Point(3, 3);
            this.dgvTable1.MultiSelect = false;
            this.dgvTable1.Name = "dgvTable1";
            this.dgvTable1.ReadOnly = true;
            this.dgvTable1.RowHeadersWidth = 51;
            this.dgvTable1.RowTemplate.Height = 24;
            this.dgvTable1.Size = new System.Drawing.Size(794, 383);
            this.dgvTable1.TabIndex = 0;
            this.dgvTable1.SelectionChanged += new System.EventHandler(this.dgvTable1_SelectionChanged);
            // 
            // dgvTable2
            // 
            this.dgvTable2.AllowUserToAddRows = false;
            this.dgvTable2.AllowUserToDeleteRows = false;
            this.dgvTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable2.Location = new System.Drawing.Point(3, 392);
            this.dgvTable2.MultiSelect = false;
            this.dgvTable2.Name = "dgvTable2";
            this.dgvTable2.ReadOnly = true;
            this.dgvTable2.RowHeadersWidth = 51;
            this.dgvTable2.RowTemplate.Height = 24;
            this.dgvTable2.Size = new System.Drawing.Size(794, 383);
            this.dgvTable2.TabIndex = 1;
            this.dgvTable2.SelectionChanged += new System.EventHandler(this.dgvTable2_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Controls.Add(this.txtStorageNum, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtSupplyCost, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtSupplyAmmount, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtItemCode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateT1, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtitemName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpSupplyDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtProviderID, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(803, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(795, 383);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtStorageNum
            // 
            this.txtStorageNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStorageNum.Location = new System.Drawing.Point(184, 304);
            this.txtStorageNum.Name = "txtStorageNum";
            this.txtStorageNum.Size = new System.Drawing.Size(537, 22);
            this.txtStorageNum.TabIndex = 29;
            // 
            // txtSupplyCost
            // 
            this.txtSupplyCost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSupplyCost.Location = new System.Drawing.Point(184, 257);
            this.txtSupplyCost.Name = "txtSupplyCost";
            this.txtSupplyCost.Size = new System.Drawing.Size(537, 22);
            this.txtSupplyCost.TabIndex = 28;
            // 
            // txtSupplyAmmount
            // 
            this.txtSupplyAmmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSupplyAmmount.Location = new System.Drawing.Point(184, 210);
            this.txtSupplyAmmount.Name = "txtSupplyAmmount";
            this.txtSupplyAmmount.Size = new System.Drawing.Size(537, 22);
            this.txtSupplyAmmount.TabIndex = 27;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtItemCode.Location = new System.Drawing.Point(184, 69);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(537, 22);
            this.txtItemCode.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код поставщика";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шифр изделия";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата поставки";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер поставки";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стоимость поставки";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер склада";
            // 
            // btnUpdateT1
            // 
            this.btnUpdateT1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateT1.Location = new System.Drawing.Point(396, 338);
            this.btnUpdateT1.Name = "btnUpdateT1";
            this.btnUpdateT1.Size = new System.Drawing.Size(112, 36);
            this.btnUpdateT1.TabIndex = 7;
            this.btnUpdateT1.Text = "Обновить";
            this.btnUpdateT1.UseVisualStyleBackColor = true;
            this.btnUpdateT1.Click += new System.EventHandler(this.btnUpdateT1_Click);
            // 
            // txtitemName
            // 
            this.txtitemName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtitemName.Location = new System.Drawing.Point(184, 22);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(537, 22);
            this.txtitemName.TabIndex = 8;
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSupplyDate.Location = new System.Drawing.Point(184, 144);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSupplyDate.TabIndex = 30;
            // 
            // txtProviderID
            // 
            this.txtProviderID.FormattingEnabled = true;
            this.txtProviderID.Location = new System.Drawing.Point(184, 97);
            this.txtProviderID.Name = "txtProviderID";
            this.txtProviderID.Size = new System.Drawing.Size(200, 24);
            this.txtProviderID.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.79109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.20891F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtProviderName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateT2, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(803, 392);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(795, 153);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhoneNumber.Location = new System.Drawing.Point(182, 77);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(538, 22);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProviderName.Location = new System.Drawing.Point(182, 26);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(538, 22);
            this.txtProviderName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Номер телефона";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Поставщик";
            // 
            // btnUpdateT2
            // 
            this.btnUpdateT2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateT2.Location = new System.Drawing.Point(395, 109);
            this.btnUpdateT2.Name = "btnUpdateT2";
            this.btnUpdateT2.Size = new System.Drawing.Size(112, 36);
            this.btnUpdateT2.TabIndex = 8;
            this.btnUpdateT2.Text = "Обновить";
            this.btnUpdateT2.UseVisualStyleBackColor = true;
            this.btnUpdateT2.Click += new System.EventHandler(this.btnUpdateT2_Click);
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 778);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditDataForm";
            this.Text = "Редактировать исходные данные в таблицах";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTable1;
        private System.Windows.Forms.DataGridView dgvTable2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtStorageNum;
        private System.Windows.Forms.TextBox txtSupplyCost;
        private System.Windows.Forms.TextBox txtSupplyAmmount;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateT1;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.ComboBox txtProviderID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateT2;
    }
}