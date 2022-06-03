
namespace Gestion_conservatoire
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBox = new System.Windows.Forms.ListBox();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crediterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.txtBoxCredit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEtat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 20;
            this.lBox.Location = new System.Drawing.Point(515, 42);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(694, 264);
            this.lBox.TabIndex = 0;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cBox
            // 
            this.cBox.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(12, 42);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(487, 26);
            this.cBox.TabIndex = 1;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.crediterMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // crediterMenu
            // 
            this.crediterMenu.Name = "crediterMenu";
            this.crediterMenu.Size = new System.Drawing.Size(90, 29);
            this.crediterMenu.Text = "Créditer";
            this.crediterMenu.Visible = false;
            this.crediterMenu.Click += new System.EventHandler(this.crediterMenu_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(102, 421);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(241, 53);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Visible = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(1033, 421);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(152, 53);
            this.btnCredit.TabIndex = 4;
            this.btnCredit.Text = "Valider crédit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Visible = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // txtBoxCredit
            // 
            this.txtBoxCredit.Location = new System.Drawing.Point(728, 434);
            this.txtBoxCredit.Name = "txtBoxCredit";
            this.txtBoxCredit.Size = new System.Drawing.Size(257, 26);
            this.txtBoxCredit.TabIndex = 5;
            this.txtBoxCredit.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1148, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 57);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("ROG Fonts", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(986, 342);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(144, 34);
            this.lblEtat.TabIndex = 7;
            this.lblEtat.Text = "Etat : ";
            this.lblEtat.Visible = false;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 584);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxCredit);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Text = "Gestion conservatoire Zik-Mu";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.ToolStripMenuItem crediterMenu;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.TextBox txtBoxCredit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEtat;
    }
}

