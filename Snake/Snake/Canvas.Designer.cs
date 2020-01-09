namespace Snake
{
    partial class Canvas
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pnlField = new System.Windows.Forms.Panel();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.tmrKeys = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(248, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(193, 23);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlField
            // 
            this.pnlField.BackColor = System.Drawing.Color.Black;
            this.pnlField.Location = new System.Drawing.Point(1, 26);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(480, 483);
            this.pnlField.TabIndex = 1;
            this.pnlField.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlField_Paint);
            // 
            // lblHighscore
            // 
            this.lblHighscore.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(0, 0);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(211, 23);
            this.lblHighscore.TabIndex = 1;
            this.lblHighscore.Text = "Highscore: 0";
            this.lblHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 510);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.pnlField);
            this.Controls.Add(this.lblScore);
            this.Name = "Canvas";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Canvas_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Canvas_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Timer tmrKeys;
    }
}

