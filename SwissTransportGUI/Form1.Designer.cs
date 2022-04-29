namespace SwissTransportGUI
{
    partial class Form1
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
            this.VerbindungenAusFirmaBtn = new System.Windows.Forms.Button();
            this.VerbindungssucheBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VerbindungenAusFirmaBtn
            // 
            this.VerbindungenAusFirmaBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VerbindungenAusFirmaBtn.Location = new System.Drawing.Point(177, 263);
            this.VerbindungenAusFirmaBtn.Name = "VerbindungenAusFirmaBtn";
            this.VerbindungenAusFirmaBtn.Size = new System.Drawing.Size(228, 203);
            this.VerbindungenAusFirmaBtn.TabIndex = 0;
            this.VerbindungenAusFirmaBtn.Text = "Abfahrtstafel";
            this.VerbindungenAusFirmaBtn.UseVisualStyleBackColor = true;
            this.VerbindungenAusFirmaBtn.Click += new System.EventHandler(this.VerbindungenAusFirmaBtn_Click);
            // 
            // VerbindungssucheBtn
            // 
            this.VerbindungssucheBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VerbindungssucheBtn.Location = new System.Drawing.Point(601, 263);
            this.VerbindungssucheBtn.Name = "VerbindungssucheBtn";
            this.VerbindungssucheBtn.Size = new System.Drawing.Size(219, 203);
            this.VerbindungssucheBtn.TabIndex = 1;
            this.VerbindungssucheBtn.Text = "Verbindungssuche";
            this.VerbindungssucheBtn.UseVisualStyleBackColor = true;
            this.VerbindungssucheBtn.Click += new System.EventHandler(this.VerbindungssucheBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menü";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1127, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerbindungssucheBtn);
            this.Controls.Add(this.VerbindungenAusFirmaBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button VerbindungenAusFirmaBtn;
        private Button VerbindungssucheBtn;
        private Label label1;
    }
}
#endregion