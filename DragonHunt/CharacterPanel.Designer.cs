namespace DragonHunt
{
    partial class CharacterPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lablName = new Label();
            lblLevel = new Label();
            lblHp = new Label();
            pbHp = new ProgressBar();
            lblXp = new Label();
            pbXp = new ProgressBar();
            lblMp = new Label();
            pbMana = new ProgressBar();
            button1 = new Button();
            txtXp = new TextBox();
            btnAddXp = new Button();
            SuspendLayout();
            // 
            // lablName
            // 
            lablName.AutoSize = true;
            lablName.Location = new Point(6, 6);
            lablName.Name = "lablName";
            lablName.Size = new Size(80, 15);
            lablName.TabIndex = 0;
            lablName.Text = "Imię bohatera";
            // 
            // lblLevel
            // 
            lblLevel.Location = new Point(210, 6);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(72, 15);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Lvl 1";
            lblLevel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHp
            // 
            lblHp.AutoSize = true;
            lblHp.Location = new Point(6, 28);
            lblHp.Name = "lblHp";
            lblHp.Size = new Size(46, 15);
            lblHp.TabIndex = 2;
            lblHp.Text = "HP: 0/0";
            // 
            // pbHp
            // 
            pbHp.Location = new Point(6, 46);
            pbHp.Name = "pbHp";
            pbHp.Size = new Size(276, 14);
            pbHp.TabIndex = 3;
            // 
            // lblXp
            // 
            lblXp.AutoSize = true;
            lblXp.Location = new Point(6, 66);
            lblXp.Name = "lblXp";
            lblXp.Size = new Size(56, 15);
            lblXp.TabIndex = 4;
            lblXp.Text = "XP: 0/100";
            // 
            // pbXp
            // 
            pbXp.Location = new Point(6, 84);
            pbXp.Name = "pbXp";
            pbXp.Size = new Size(276, 14);
            pbXp.TabIndex = 5;
            // 
            // lblMp
            // 
            lblMp.AutoSize = true;
            lblMp.Location = new Point(6, 104);
            lblMp.Name = "lblMp";
            lblMp.Size = new Size(60, 15);
            lblMp.TabIndex = 6;
            lblMp.Text = "MP: 0/100";
            // 
            // pbMana
            // 
            pbMana.Location = new Point(6, 122);
            pbMana.Name = "pbMana";
            pbMana.Size = new Size(276, 14);
            pbMana.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(6, 144);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 8;
            button1.Text = "Wypij miksturę";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtXp
            // 
            txtXp.Location = new Point(142, 145);
            txtXp.Name = "txtXp";
            txtXp.Size = new Size(64, 23);
            txtXp.TabIndex = 9;
            txtXp.Text = "0";
            // 
            // btnAddXp
            // 
            btnAddXp.Location = new Point(212, 144);
            btnAddXp.Name = "btnAddXp";
            btnAddXp.Size = new Size(70, 26);
            btnAddXp.TabIndex = 10;
            btnAddXp.Text = "Dodaj XP";
            btnAddXp.UseVisualStyleBackColor = true;
            // 
            // CharacterPanel
            // 
            Controls.Add(btnAddXp);
            Controls.Add(txtXp);
            Controls.Add(button1);
            Controls.Add(pbMana);
            Controls.Add(lblMp);
            Controls.Add(pbXp);
            Controls.Add(lblXp);
            Controls.Add(pbHp);
            Controls.Add(lblHp);
            Controls.Add(lblLevel);
            Controls.Add(lablName);
            Name = "CharacterPanel";
            Size = new Size(290, 178);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLevel;
        private Label lablName;
        private Label lblHp;
        private ProgressBar pbHp;
        private Label lblXp;
        private ProgressBar pbXp;
        private Label lblMp;
        private ProgressBar pbMana;
        private Button button1;
        private TextBox txtXp;
        private Button btnAddXp;
    }
}
