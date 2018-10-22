namespace WindowsFormsUSB
{
  partial class Form2
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.sandboxDataSet = new WindowsFormsUSB.sandboxDataSet();
      this.sandboxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customerTableAdapter = new WindowsFormsUSB.sandboxDataSetTableAdapters.customerTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnShowForm1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sandboxDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sandboxDataSetBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.customerBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(23, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(257, 150);
      this.dataGridView1.TabIndex = 0;
      // 
      // sandboxDataSet
      // 
      this.sandboxDataSet.DataSetName = "sandboxDataSet";
      this.sandboxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // sandboxDataSetBindingSource
      // 
      this.sandboxDataSetBindingSource.DataSource = this.sandboxDataSet;
      this.sandboxDataSetBindingSource.Position = 0;
      // 
      // customerBindingSource
      // 
      this.customerBindingSource.DataMember = "customer";
      this.customerBindingSource.DataSource = this.sandboxDataSetBindingSource;
      // 
      // customerTableAdapter
      // 
      this.customerTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
      this.idDataGridViewTextBoxColumn.HeaderText = "ID";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // btnShowForm1
      // 
      this.btnShowForm1.Location = new System.Drawing.Point(236, 195);
      this.btnShowForm1.Name = "btnShowForm1";
      this.btnShowForm1.Size = new System.Drawing.Size(75, 23);
      this.btnShowForm1.TabIndex = 1;
      this.btnShowForm1.Text = "Show Form1";
      this.btnShowForm1.UseVisualStyleBackColor = true;
      this.btnShowForm1.Click += new System.EventHandler(this.btnShowForm1_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnShowForm1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sandboxDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sandboxDataSetBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource sandboxDataSetBindingSource;
    private sandboxDataSet sandboxDataSet;
    private System.Windows.Forms.BindingSource customerBindingSource;
    private sandboxDataSetTableAdapters.customerTableAdapter customerTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnShowForm1;
  }
}