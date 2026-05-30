namespace DragonHunt
{
    partial class MonsterPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            lblLevel = new Label();
            lblHp = new Label();
            pbHp = new ProgressBar();
            SuspendLayout();
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            lblName.Location = new Point(6, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Potwór";
            //
            // lblLevel
            //
            lblLevel.Location = new Point(820, 6);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(84, 15);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Lvl 10";
            lblLevel.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblHp
            //
            lblHp.AutoSize = true;
            lblHp.Location = new Point(6, 30);
            lblHp.Name = "lblHp";
            lblHp.Size = new Size(70, 15);
            lblHp.TabIndex = 1;
            lblHp.Text = "HP: 300/300";
            //
            // pbHp
            //
            pbHp.Location = new Point(6, 48);
            pbHp.Name = "pbHp";
            pbHp.Size = new Size(896, 16);
            pbHp.TabIndex = 2;
            //
            // MonsterPanel
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbHp);
            Controls.Add(lblHp);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Name = "MonsterPanel";
            Size = new Size(910, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLevel;
        private Label lblHp;
        private ProgressBar pbHp;
    }
}
