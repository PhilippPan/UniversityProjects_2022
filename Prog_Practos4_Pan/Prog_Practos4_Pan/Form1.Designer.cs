
namespace Prog_Practos4_Pan
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
            this.components = new System.ComponentModel.Container();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.pr4LibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Prog_Practos4_Pan.DataSet1();
            this.txtBookAdd = new System.Windows.Forms.TextBox();
            this.txtAuthorAdd = new System.Windows.Forms.TextBox();
            this.txtStoreAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbBookEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoreEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBookDel = new System.Windows.Forms.ComboBox();
            this.pr4_LibraryTableAdapter = new Prog_Practos4_Pan.DataSet1TableAdapters.pr4_LibraryTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr4LibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AllowUserToResizeColumns = false;
            this.dgTable.AllowUserToResizeRows = false;
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(9, 10);
            this.dgTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.RowHeadersWidth = 51;
            this.dgTable.RowTemplate.Height = 24;
            this.dgTable.Size = new System.Drawing.Size(453, 166);
            this.dgTable.TabIndex = 0;
            // 
            // pr4LibraryBindingSource
            // 
            this.pr4LibraryBindingSource.DataMember = "pr4_Library";
            this.pr4LibraryBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBookAdd
            // 
            this.txtBookAdd.Location = new System.Drawing.Point(9, 201);
            this.txtBookAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookAdd.Name = "txtBookAdd";
            this.txtBookAdd.Size = new System.Drawing.Size(76, 20);
            this.txtBookAdd.TabIndex = 1;
            // 
            // txtAuthorAdd
            // 
            this.txtAuthorAdd.Location = new System.Drawing.Point(88, 201);
            this.txtAuthorAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAuthorAdd.Name = "txtAuthorAdd";
            this.txtAuthorAdd.Size = new System.Drawing.Size(76, 20);
            this.txtAuthorAdd.TabIndex = 2;
            // 
            // txtStoreAdd
            // 
            this.txtStoreAdd.Location = new System.Drawing.Point(168, 201);
            this.txtStoreAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStoreAdd.Name = "txtStoreAdd";
            this.txtStoreAdd.Size = new System.Drawing.Size(76, 20);
            this.txtStoreAdd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во на складе";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 200);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 19);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbBookEdit
            // 
            this.cmbBookEdit.DataSource = this.pr4LibraryBindingSource;
            this.cmbBookEdit.DisplayMember = "BookName";
            this.cmbBookEdit.FormattingEnabled = true;
            this.cmbBookEdit.Location = new System.Drawing.Point(9, 238);
            this.cmbBookEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBookEdit.Name = "cmbBookEdit";
            this.cmbBookEdit.Size = new System.Drawing.Size(76, 21);
            this.cmbBookEdit.TabIndex = 8;
            this.cmbBookEdit.ValueMember = "BookName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во на складе";
            // 
            // txtStoreEdit
            // 
            this.txtStoreEdit.Location = new System.Drawing.Point(88, 238);
            this.txtStoreEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStoreEdit.Name = "txtStoreEdit";
            this.txtStoreEdit.Size = new System.Drawing.Size(76, 20);
            this.txtStoreEdit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Название книги";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(168, 237);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 19);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(88, 280);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 19);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Название книги";
            // 
            // cmbBookDel
            // 
            this.cmbBookDel.DataSource = this.pr4LibraryBindingSource;
            this.cmbBookDel.DisplayMember = "BookName";
            this.cmbBookDel.FormattingEnabled = true;
            this.cmbBookDel.Location = new System.Drawing.Point(9, 280);
            this.cmbBookDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBookDel.Name = "cmbBookDel";
            this.cmbBookDel.Size = new System.Drawing.Size(76, 21);
            this.cmbBookDel.TabIndex = 14;
            this.cmbBookDel.ValueMember = "BookName";
            // 
            // pr4_LibraryTableAdapter
            // 
            this.pr4_LibraryTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Источник данных";
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Таблица 1",
            "Таблица 2"});
            this.cmbSource.Location = new System.Drawing.Point(370, 200);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(92, 21);
            this.cmbSource.TabIndex = 16;
            this.cmbSource.Text = "Таблица 1";
            this.cmbSource.ValueMember = "BookName";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(370, 223);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(92, 23);
            this.btnChoose.TabIndex = 18;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBookDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStoreEdit);
            this.Controls.Add(this.cmbBookEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStoreAdd);
            this.Controls.Add(this.txtAuthorAdd);
            this.Controls.Add(this.txtBookAdd);
            this.Controls.Add(this.dgTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Работа с базами данных в приложениях на языке C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr4LibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.TextBox txtBookAdd;
        private System.Windows.Forms.TextBox txtAuthorAdd;
        private System.Windows.Forms.TextBox txtStoreAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbBookEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoreEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBookDel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pr4LibraryBindingSource;
        private DataSet1TableAdapters.pr4_LibraryTableAdapter pr4_LibraryTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Button btnChoose;
    }
}

