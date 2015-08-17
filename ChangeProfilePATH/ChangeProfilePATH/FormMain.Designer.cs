namespace ChangeProfilePATH
{
    partial class FormMain
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
            this.labelPATH = new System.Windows.Forms.Label();
            this.textBoxPATH = new System.Windows.Forms.TextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPATH
            // 
            this.labelPATH.AutoSize = true;
            this.labelPATH.Location = new System.Drawing.Point(12, 18);
            this.labelPATH.Name = "labelPATH";
            this.labelPATH.Size = new System.Drawing.Size(39, 13);
            this.labelPATH.TabIndex = 0;
            this.labelPATH.Text = "PATH:";
            // 
            // textBoxPATH
            // 
            this.textBoxPATH.Location = new System.Drawing.Point(57, 12);
            this.textBoxPATH.Name = "textBoxPATH";
            this.textBoxPATH.Size = new System.Drawing.Size(397, 20);
            this.textBoxPATH.TabIndex = 1;
            this.textBoxPATH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(471, 10);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Выбрать";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(471, 41);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 76);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxPATH);
            this.Controls.Add(this.labelPATH);
            this.Name = "FormMain";
            this.Text = "Изменить или добавил PATH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPATH;
        private System.Windows.Forms.TextBox textBoxPATH;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonApply;
    }
}

