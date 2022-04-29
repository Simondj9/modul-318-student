namespace SwissTransportGUI
{
    partial class Verbindungssuche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AbfahrtsortCbx = new System.Windows.Forms.ComboBox();
            this.ViaCbx = new System.Windows.Forms.ComboBox();
            this.AnkunftsortCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VerbindungssucheBtn = new System.Windows.Forms.Button();
            this.VerbindungssucheDgv = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GleisAbfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GleisAnkunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungssucheDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abfahrtort";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ankunftsort";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Via";
            // 
            // AbfahrtsortCbx
            // 
            this.AbfahrtsortCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AbfahrtsortCbx.FormattingEnabled = true;
            this.AbfahrtsortCbx.Location = new System.Drawing.Point(726, 33);
            this.AbfahrtsortCbx.Name = "AbfahrtsortCbx";
            this.AbfahrtsortCbx.Size = new System.Drawing.Size(339, 33);
            this.AbfahrtsortCbx.TabIndex = 4;
            this.AbfahrtsortCbx.SelectedIndexChanged += new System.EventHandler(this.AbfahrtsortCbx_SelectedIndexChanged);
            // 
            // ViaCbx
            // 
            this.ViaCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViaCbx.FormattingEnabled = true;
            this.ViaCbx.Location = new System.Drawing.Point(726, 159);
            this.ViaCbx.Name = "ViaCbx";
            this.ViaCbx.Size = new System.Drawing.Size(339, 33);
            this.ViaCbx.TabIndex = 5;
            this.ViaCbx.SelectedIndexChanged += new System.EventHandler(this.ViaCbx_SelectedIndexChanged);
            // 
            // AnkunftsortCbx
            // 
            this.AnkunftsortCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnkunftsortCbx.FormattingEnabled = true;
            this.AnkunftsortCbx.Location = new System.Drawing.Point(726, 94);
            this.AnkunftsortCbx.Name = "AnkunftsortCbx";
            this.AnkunftsortCbx.Size = new System.Drawing.Size(339, 33);
            this.AnkunftsortCbx.TabIndex = 6;
            this.AnkunftsortCbx.SelectedIndexChanged += new System.EventHandler(this.AnkunftsortCbx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1513, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verbindungen";
            // 
            // VerbindungssucheBtn
            // 
            this.VerbindungssucheBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerbindungssucheBtn.Location = new System.Drawing.Point(801, 301);
            this.VerbindungssucheBtn.Name = "VerbindungssucheBtn";
            this.VerbindungssucheBtn.Size = new System.Drawing.Size(173, 34);
            this.VerbindungssucheBtn.TabIndex = 8;
            this.VerbindungssucheBtn.Text = "Verbindungssuche";
            this.VerbindungssucheBtn.UseVisualStyleBackColor = true;
            this.VerbindungssucheBtn.Click += new System.EventHandler(this.VerbindungssucheBtn_Click);
            // 
            // VerbindungssucheDgv
            // 
            this.VerbindungssucheDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VerbindungssucheDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VerbindungssucheDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungssucheDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort,
            this.Ankunftsort,
            this.Abfahrt,
            this.Ankunft,
            this.GleisAbfahrt,
            this.GleisAnkunft});
            this.VerbindungssucheDgv.Location = new System.Drawing.Point(12, 341);
            this.VerbindungssucheDgv.Name = "VerbindungssucheDgv";
            this.VerbindungssucheDgv.RowHeadersWidth = 62;
            this.VerbindungssucheDgv.RowTemplate.Height = 33;
            this.VerbindungssucheDgv.Size = new System.Drawing.Size(1776, 581);
            this.VerbindungssucheDgv.TabIndex = 9;
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
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 8;
            this.Abfahrt.Name = "Abfahrt";
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 8;
            this.Ankunft.Name = "Ankunft";
            // 
            // GleisAbfahrt
            // 
            this.GleisAbfahrt.HeaderText = "Gleis oder Kante Abfahrt";
            this.GleisAbfahrt.MinimumWidth = 8;
            this.GleisAbfahrt.Name = "GleisAbfahrt";
            // 
            // GleisAnkunft
            // 
            this.GleisAnkunft.HeaderText = "Gleis oder Kante Ankunft";
            this.GleisAnkunft.MinimumWidth = 8;
            this.GleisAnkunft.Name = "GleisAnkunft";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum und Zeit";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Location = new System.Drawing.Point(726, 224);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(300, 31);
            this.datePicker.TabIndex = 11;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Location = new System.Drawing.Point(1032, 224);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(300, 31);
            this.timePicker.TabIndex = 12;
            // 
            // Verbindungssuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 934);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VerbindungssucheDgv);
            this.Controls.Add(this.VerbindungssucheBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnkunftsortCbx);
            this.Controls.Add(this.ViaCbx);
            this.Controls.Add(this.AbfahrtsortCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Verbindungssuche";
            this.Text = "Verbindungssuche";
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungssucheDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox AbfahrtsortCbx;
        private ComboBox ViaCbx;
        private ComboBox AnkunftsortCbx;
        private Label label4;
        private Button VerbindungssucheBtn;
        private DataGridView VerbindungssucheDgv;
        private DataGridViewTextBoxColumn Abfahrtsort;
        private DataGridViewTextBoxColumn Ankunftsort;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn GleisAbfahrt;
        private DataGridViewTextBoxColumn GleisAnkunft;
        private Label label5;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
    }
}