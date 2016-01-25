namespace Railnation
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbMojeBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLaboratoř = new System.Windows.Forms.TextBox();
            this.tbBanka = new System.Windows.Forms.TextBox();
            this.tbHotovost = new System.Windows.Forms.TextBox();
            this.tbObrat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level laboratoře:";
            // 
            // tbMojeBody
            // 
            this.tbMojeBody.Location = new System.Drawing.Point(289, 47);
            this.tbMojeBody.Name = "tbMojeBody";
            this.tbMojeBody.Size = new System.Drawing.Size(100, 26);
            this.tbMojeBody.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Počet uschvaných výzkumných bodů:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level banky:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hotovost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Obrat / h:";
            // 
            // tbLaboratoř
            // 
            this.tbLaboratoř.Location = new System.Drawing.Point(289, 10);
            this.tbLaboratoř.Name = "tbLaboratoř";
            this.tbLaboratoř.Size = new System.Drawing.Size(100, 26);
            this.tbLaboratoř.TabIndex = 1;
            // 
            // tbBanka
            // 
            this.tbBanka.Location = new System.Drawing.Point(289, 83);
            this.tbBanka.Name = "tbBanka";
            this.tbBanka.Size = new System.Drawing.Size(100, 26);
            this.tbBanka.TabIndex = 1;
            // 
            // tbHotovost
            // 
            this.tbHotovost.Location = new System.Drawing.Point(289, 118);
            this.tbHotovost.Name = "tbHotovost";
            this.tbHotovost.Size = new System.Drawing.Size(100, 26);
            this.tbHotovost.TabIndex = 1;
            // 
            // tbObrat
            // 
            this.tbObrat.Location = new System.Drawing.Point(289, 156);
            this.tbObrat.Name = "tbObrat";
            this.tbObrat.Size = new System.Drawing.Size(100, 26);
            this.tbObrat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObrat);
            this.Controls.Add(this.tbHotovost);
            this.Controls.Add(this.tbBanka);
            this.Controls.Add(this.tbLaboratoř);
            this.Controls.Add(this.tbMojeBody);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Railnation rozpočty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMojeBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLaboratoř;
        private System.Windows.Forms.TextBox tbBanka;
        private System.Windows.Forms.TextBox tbHotovost;
        private System.Windows.Forms.TextBox tbObrat;
    }
}

