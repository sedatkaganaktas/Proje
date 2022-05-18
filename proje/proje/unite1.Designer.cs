
namespace proje
{
    partial class unite1
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
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisDataSet1 = new proje.girisDataSet1();
            this.unit1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisDataSet = new proje.girisDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unit1TableAdapter = new proje.girisDataSetTableAdapters.unit1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.table_1TableAdapter = new proje.girisDataSet1TableAdapters.Table_1TableAdapter();
            this.girisDataSet2 = new proje.girisDataSet2();
            this.sorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sorularTableAdapter = new proje.girisDataSet2TableAdapters.SorularTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.girisDataSet3 = new proje.girisDataSet3();
            this.soruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruTableAdapter = new proje.girisDataSet3TableAdapters.SoruTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.süre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Doğru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yanlış = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.girisDataSet1;
            // 
            // girisDataSet1
            // 
            this.girisDataSet1.DataSetName = "girisDataSet1";
            this.girisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unit1BindingSource
            // 
            this.unit1BindingSource.DataMember = "unit1";
            this.unit1BindingSource.DataSource = this.girisDataSet;
            // 
            // girisDataSet
            // 
            this.girisDataSet.DataSetName = "girisDataSet";
            this.girisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(476, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 625);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // unit1TableAdapter
            // 
            this.unit1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // girisDataSet2
            // 
            this.girisDataSet2.DataSetName = "girisDataSet2";
            this.girisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorularBindingSource
            // 
            this.sorularBindingSource.DataMember = "Sorular";
            this.sorularBindingSource.DataSource = this.girisDataSet2;
            // 
            // sorularTableAdapter
            // 
            this.sorularTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 283);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 4;
            // 
            // girisDataSet3
            // 
            this.girisDataSet3.DataSetName = "girisDataSet3";
            this.girisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soruBindingSource
            // 
            this.soruBindingSource.DataMember = "Soru";
            this.soruBindingSource.DataSource = this.girisDataSet3;
            // 
            // soruTableAdapter
            // 
            this.soruTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(223, 694);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // süre
            // 
            this.süre.AutoSize = true;
            this.süre.Location = new System.Drawing.Point(247, 20);
            this.süre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.süre.Name = "süre";
            this.süre.Size = new System.Drawing.Size(36, 17);
            this.süre.TabIndex = 6;
            this.süre.Text = "süre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 7;
            // 
            // Doğru
            // 
            this.Doğru.AutoSize = true;
            this.Doğru.Location = new System.Drawing.Point(247, 71);
            this.Doğru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Doğru.Name = "Doğru";
            this.Doğru.Size = new System.Drawing.Size(45, 17);
            this.Doğru.TabIndex = 8;
            this.Doğru.Text = "doğru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // yanlış
            // 
            this.yanlış.AutoSize = true;
            this.yanlış.Location = new System.Drawing.Point(247, 135);
            this.yanlış.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yanlış.Name = "yanlış";
            this.yanlış.Size = new System.Drawing.Size(44, 17);
            this.yanlış.TabIndex = 10;
            this.yanlış.Text = "yanlış";
            this.yanlış.Click += new System.EventHandler(this.yanlış_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 121);
            this.button2.TabIndex = 12;
            this.button2.Text = "sınavı bitir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // unite1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1092, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yanlış);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Doğru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.süre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "unite1";
            this.Text = "unite1";
            this.Load += new System.EventHandler(this.unite1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private girisDataSet girisDataSet;
        private System.Windows.Forms.BindingSource unit1BindingSource;
        private girisDataSetTableAdapters.unit1TableAdapter unit1TableAdapter;
        private System.Windows.Forms.Button button1;
        private girisDataSet1 girisDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private girisDataSet1TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private girisDataSet2 girisDataSet2;
        private System.Windows.Forms.BindingSource sorularBindingSource;
        private girisDataSet2TableAdapters.SorularTableAdapter sorularTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private girisDataSet3 girisDataSet3;
        private System.Windows.Forms.BindingSource soruBindingSource;
        private girisDataSet3TableAdapters.SoruTableAdapter soruTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label süre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Doğru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label yanlış;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}