namespace Login_System_Tut_ecnrypted
{
    partial class main
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
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerstandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einheitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerplatzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerstandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einheitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerverwaltungDataSet = new Login_System_Tut_ecnrypted.LagerverwaltungDataSet();
            this.lagerTableAdapter = new Login_System_Tut_ecnrypted.LagerverwaltungDataSetTableAdapters.LagerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerverwaltungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // lagerplatzDataGridViewTextBoxColumn
            // 
            this.lagerplatzDataGridViewTextBoxColumn.DataPropertyName = "Lagerplatz";
            this.lagerplatzDataGridViewTextBoxColumn.HeaderText = "Lagerplatz";
            this.lagerplatzDataGridViewTextBoxColumn.Name = "lagerplatzDataGridViewTextBoxColumn";
            // 
            // herstellerDataGridViewTextBoxColumn
            // 
            this.herstellerDataGridViewTextBoxColumn.DataPropertyName = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.Name = "herstellerDataGridViewTextBoxColumn";
            // 
            // lagerstandDataGridViewTextBoxColumn
            // 
            this.lagerstandDataGridViewTextBoxColumn.DataPropertyName = "Lagerstand";
            this.lagerstandDataGridViewTextBoxColumn.HeaderText = "Lagerstand";
            this.lagerstandDataGridViewTextBoxColumn.Name = "lagerstandDataGridViewTextBoxColumn";
            // 
            // einheitDataGridViewTextBoxColumn
            // 
            this.einheitDataGridViewTextBoxColumn.DataPropertyName = "Einheit";
            this.einheitDataGridViewTextBoxColumn.HeaderText = "Einheit";
            this.einheitDataGridViewTextBoxColumn.Name = "einheitDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn1,
            this.pNameDataGridViewTextBoxColumn1,
            this.lagerplatzDataGridViewTextBoxColumn1,
            this.herstellerDataGridViewTextBoxColumn1,
            this.lagerstandDataGridViewTextBoxColumn1,
            this.einheitDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.lagerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn1
            // 
            this.pIDDataGridViewTextBoxColumn1.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn1.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn1.Name = "pIDDataGridViewTextBoxColumn1";
            this.pIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            this.pNameDataGridViewTextBoxColumn1.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn1.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn1.Name = "pNameDataGridViewTextBoxColumn1";
            // 
            // lagerplatzDataGridViewTextBoxColumn1
            // 
            this.lagerplatzDataGridViewTextBoxColumn1.DataPropertyName = "Lagerplatz";
            this.lagerplatzDataGridViewTextBoxColumn1.HeaderText = "Lagerplatz";
            this.lagerplatzDataGridViewTextBoxColumn1.Name = "lagerplatzDataGridViewTextBoxColumn1";
            // 
            // herstellerDataGridViewTextBoxColumn1
            // 
            this.herstellerDataGridViewTextBoxColumn1.DataPropertyName = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn1.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn1.Name = "herstellerDataGridViewTextBoxColumn1";
            // 
            // lagerstandDataGridViewTextBoxColumn1
            // 
            this.lagerstandDataGridViewTextBoxColumn1.DataPropertyName = "Lagerstand";
            this.lagerstandDataGridViewTextBoxColumn1.HeaderText = "Lagerstand";
            this.lagerstandDataGridViewTextBoxColumn1.Name = "lagerstandDataGridViewTextBoxColumn1";
            // 
            // einheitDataGridViewTextBoxColumn1
            // 
            this.einheitDataGridViewTextBoxColumn1.DataPropertyName = "Einheit";
            this.einheitDataGridViewTextBoxColumn1.HeaderText = "Einheit";
            this.einheitDataGridViewTextBoxColumn1.Name = "einheitDataGridViewTextBoxColumn1";
            // 
            // lagerBindingSource
            // 
            this.lagerBindingSource.DataMember = "Lager";
            this.lagerBindingSource.DataSource = this.lagerverwaltungDataSet;
            // 
            // lagerverwaltungDataSet
            // 
            this.lagerverwaltungDataSet.DataSetName = "LagerverwaltungDataSet";
            this.lagerverwaltungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lagerTableAdapter
            // 
            this.lagerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nutzer anlegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "main";
            this.Text = "Lager+";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerverwaltungDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagerplatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagerstandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einheitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LagerverwaltungDataSet lagerverwaltungDataSet;
        private System.Windows.Forms.BindingSource lagerBindingSource;
        private LagerverwaltungDataSetTableAdapters.LagerTableAdapter lagerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagerplatzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagerstandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn einheitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}