namespace Serialisation
{
    partial class Form1
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
            this.btn_Serialization = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_Score = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Serialization
            // 
            this.btn_Serialization.Location = new System.Drawing.Point(229, 234);
            this.btn_Serialization.Name = "btn_Serialization";
            this.btn_Serialization.Size = new System.Drawing.Size(75, 23);
            this.btn_Serialization.TabIndex = 0;
            this.btn_Serialization.Text = "Sérialisation";
            this.btn_Serialization.UseVisualStyleBackColor = true;
            this.btn_Serialization.Click += new System.EventHandler(this.btn_Serialization_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Name.Location = new System.Drawing.Point(242, 44);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(100, 20);
            this.tbx_Name.TabIndex = 1;
            // 
            // tbx_Score
            // 
            this.tbx_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Score.Location = new System.Drawing.Point(242, 88);
            this.tbx_Score.Name = "tbx_Score";
            this.tbx_Score.Size = new System.Drawing.Size(100, 20);
            this.tbx_Score.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(201, 47);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Nom :";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(195, 91);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(41, 13);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "Score :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 292);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tbx_Score);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.btn_Serialization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Serialization;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_Score;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Score;
    }
}

