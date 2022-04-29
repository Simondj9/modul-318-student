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
            this.ErsteVerbindungenBtn = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VerbindungenAusFirmaBtn
            // 
            this.VerbindungenAusFirmaBtn.Location = new System.Drawing.Point(610, 141);
            this.VerbindungenAusFirmaBtn.Name = "VerbindungenAusFirmaBtn";
            this.VerbindungenAusFirmaBtn.Size = new System.Drawing.Size(228, 203);
            this.VerbindungenAusFirmaBtn.TabIndex = 0;
            this.VerbindungenAusFirmaBtn.Text = "Abfahrtstafel";
            this.VerbindungenAusFirmaBtn.UseVisualStyleBackColor = true;
            this.VerbindungenAusFirmaBtn.Click += new System.EventHandler(this.VerbindungenAusFirmaBtn_Click);
            // 
            // VerbindungssucheBtn
            // 
            this.VerbindungssucheBtn.Location = new System.Drawing.Point(610, 409);
            this.VerbindungssucheBtn.Name = "VerbindungssucheBtn";
            this.VerbindungssucheBtn.Size = new System.Drawing.Size(228, 222);
            this.VerbindungssucheBtn.TabIndex = 1;
            this.VerbindungssucheBtn.Text = "Verbindungssuche";
            this.VerbindungssucheBtn.UseVisualStyleBackColor = true;
            this.VerbindungssucheBtn.Click += new System.EventHandler(this.VerbindungssucheBtn_Click);
            // 
            // ErsteVerbindungenBtn
            // 
            this.ErsteVerbindungenBtn.Location = new System.Drawing.Point(183, 409);
            this.ErsteVerbindungenBtn.Name = "ErsteVerbindungenBtn";
            this.ErsteVerbindungenBtn.Size = new System.Drawing.Size(236, 222);
            this.ErsteVerbindungenBtn.TabIndex = 2;
            this.ErsteVerbindungenBtn.UseVisualStyleBackColor = true;
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(183, 141);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(236, 203);
            this.k.TabIndex = 3;
            this.k.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menü";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1127, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.k);
            this.Controls.Add(this.ErsteVerbindungenBtn);
            this.Controls.Add(this.VerbindungssucheBtn);
            this.Controls.Add(this.VerbindungenAusFirmaBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button AlleVerbindungenbtn;
        private Button button2;
        private Button button3;
        private Button k;
        private Button VerbindungenAusFirmaBtn;
        private Button ErsteVerbindungenBtn;
        private Button VerbindungssucheBtn;
        private Label label1;
    }
}
#endregion