namespace ReadFromXCL
{
    partial class Queryfy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queryfy));
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.lblPath = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblExport = new System.Windows.Forms.ToolStripLabel();
            this.btnCSV = new System.Windows.Forms.ToolStripButton();
            this.btnSqlServer = new System.Windows.Forms.ToolStripButton();
            this.btnMySql = new System.Windows.Forms.ToolStripButton();
            this.svFile = new System.Windows.Forms.SaveFileDialog();
            this.ckRowNumber = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(7, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 31);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Excel";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToOrderColumns = true;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(0, 0);
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            this.dgResult.RowHeadersVisible = false;
            this.dgResult.Size = new System.Drawing.Size(690, 173);
            this.dgResult.TabIndex = 2;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoEllipsis = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(8, 42);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(529, 16);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(7, 66);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgResult);
            this.splitContainer1.Size = new System.Drawing.Size(690, 352);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtQuery
            // 
            this.txtQuery.AllowDrop = true;
            this.txtQuery.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtQuery.BackBrush = null;
            this.txtQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Enabled = false;
            this.txtQuery.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtQuery.IsReplaceMode = false;
            this.txtQuery.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.txtQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtQuery.Size = new System.Drawing.Size(690, 175);
            this.txtQuery.TabIndex = 3;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(558, 9);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(139, 31);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute Query (F5)";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // ofdExcel
            // 
            this.ofdExcel.Filter = "Excel Files|*.xlsx|Excel (97-2003)|*.xls";
            this.ofdExcel.Title = "Abrir Excel";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExport,
            this.btnCSV,
            this.btnSqlServer,
            this.btnMySql});
            this.toolStrip1.Location = new System.Drawing.Point(0, 424);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblExport
            // 
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(80, 22);
            this.lblExport.Text = "Export results:";
            // 
            // btnCSV
            // 
            this.btnCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCSV.Image = global::ReadFromXCL.Properties.Resources.csv;
            this.btnCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(23, 22);
            this.btnCSV.Text = "CSV";
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSqlServer.Enabled = false;
            this.btnSqlServer.Image = global::ReadFromXCL.Properties.Resources.sql_server;
            this.btnSqlServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Size = new System.Drawing.Size(23, 22);
            this.btnSqlServer.Text = "SQL Server";
            // 
            // btnMySql
            // 
            this.btnMySql.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMySql.Image = global::ReadFromXCL.Properties.Resources.mysql;
            this.btnMySql.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMySql.Name = "btnMySql";
            this.btnMySql.Size = new System.Drawing.Size(23, 22);
            this.btnMySql.Text = "MySQL";
            this.btnMySql.Click += new System.EventHandler(this.btnMySql_Click);
            // 
            // ckRowNumber
            // 
            this.ckRowNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckRowNumber.AutoSize = true;
            this.ckRowNumber.Location = new System.Drawing.Point(559, 43);
            this.ckRowNumber.Name = "ckRowNumber";
            this.ckRowNumber.Size = new System.Drawing.Size(119, 17);
            this.ckRowNumber.TabIndex = 7;
            this.ckRowNumber.Text = "retrieve row number";
            this.ckRowNumber.UseVisualStyleBackColor = true;
            // 
            // Queryfy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 449);
            this.Controls.Add(this.ckRowNumber);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Queryfy";
            this.Text = "Excel Queryfy";
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private FastColoredTextBoxNS.FastColoredTextBox txtQuery;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblExport;
        private System.Windows.Forms.ToolStripButton btnCSV;
        private System.Windows.Forms.ToolStripButton btnSqlServer;
        private System.Windows.Forms.ToolStripButton btnMySql;
        private System.Windows.Forms.SaveFileDialog svFile;
        private System.Windows.Forms.CheckBox ckRowNumber;
    }
}

