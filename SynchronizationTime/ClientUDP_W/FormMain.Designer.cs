namespace ClientUDP_W
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
            this.labelIPComputer = new System.Windows.Forms.Label();
            this.TextBoxIPComputer = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIPComputer
            // 
            this.labelIPComputer.AutoSize = true;
            this.labelIPComputer.Location = new System.Drawing.Point(12, 20);
            this.labelIPComputer.Name = "labelIPComputer";
            this.labelIPComputer.Size = new System.Drawing.Size(53, 13);
            this.labelIPComputer.TabIndex = 0;
            this.labelIPComputer.Text = "IP-адрес:";
            // 
            // TextBoxIPComputer
            // 
            this.TextBoxIPComputer.Location = new System.Drawing.Point(71, 17);
            this.TextBoxIPComputer.Name = "TextBoxIPComputer";
            this.TextBoxIPComputer.Size = new System.Drawing.Size(91, 20);
            this.TextBoxIPComputer.TabIndex = 1;
            this.TextBoxIPComputer.Text = "192.168.17.223";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(180, 15);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 48);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.TextBoxIPComputer);
            this.Controls.Add(this.labelIPComputer);
            this.Name = "FormMain";
            this.Text = "Синхронизация времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIPComputer;
        private System.Windows.Forms.TextBox TextBoxIPComputer;
        private System.Windows.Forms.Button buttonApply;
    }
}

