namespace SwissTransportGUI
{
    partial class VerbindungenAusFirma
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
            this.AbfahrtstafelDgv = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZugTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.VerbindungsvorschlagAbfahrtstafelCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AbfahrtstafelDgv
            // 
            this.AbfahrtstafelDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbfahrtstafelDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbfahrtstafelDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AbfahrtstafelDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtstafelDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort,
            this.Ankunftsort,
            this.ZugTyp});
            this.AbfahrtstafelDgv.Location = new System.Drawing.Point(12, 237);
            this.AbfahrtstafelDgv.Name = "AbfahrtstafelDgv";
            this.AbfahrtstafelDgv.RowHeadersWidth = 62;
            this.AbfahrtstafelDgv.RowTemplate.Height = 33;
            this.AbfahrtstafelDgv.Size = new System.Drawing.Size(1131, 608);
            this.AbfahrtstafelDgv.TabIndex = 2;
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.HeaderText = "Abfahrtsort";
            this.Abfahrtsort.MinimumWidth = 8;
            this.Abfahrtsort.Name = "Abfahrtsort";
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.MinimumWidth = 8;
            this.Ankunftsort.Name = "Ankunftsort";
            // 
            // ZugTyp
            // 
            this.ZugTyp.HeaderText = "Zug Typ";
            this.ZugTyp.MinimumWidth = 8;
            this.ZugTyp.Name = "ZugTyp";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(957, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abfahrtstafel";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ankunftsort";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(529, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Verbindungen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AbfahrtstafelBtn);
            // 
            // VerbindungsvorschlagAbfahrtstafelCbx
            // 
            this.VerbindungsvorschlagAbfahrtstafelCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerbindungsvorschlagAbfahrtstafelCbx.FormattingEnabled = true;
            this.VerbindungsvorschlagAbfahrtstafelCbx.Location = new System.Drawing.Point(441, 118);
            this.VerbindungsvorschlagAbfahrtstafelCbx.Name = "VerbindungsvorschlagAbfahrtstafelCbx";
            this.VerbindungsvorschlagAbfahrtstafelCbx.Size = new System.Drawing.Size(301, 33);
            this.VerbindungsvorschlagAbfahrtstafelCbx.TabIndex = 11;
            this.VerbindungsvorschlagAbfahrtstafelCbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VerbindungsvorschlagAbfahrtstafelCbx_KeyUp);
            // 
            // VerbindungenAusFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 857);
            this.Controls.Add(this.VerbindungsvorschlagAbfahrtstafelCbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbfahrtstafelDgv);
            this.Name = "VerbindungenAusFirma";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView AbfahrtstafelDgv;
        private Label label1;
        private Label label3;
        private Button button1;
        private DataGridViewTextBoxColumn Abfahrtsort;
        private DataGridViewTextBoxColumn Ankunftsort;
        private DataGridViewTextBoxColumn ZugTyp;
        private ComboBox VerbindungsvorschlagAbfahrtstafelCbx;
    }
}