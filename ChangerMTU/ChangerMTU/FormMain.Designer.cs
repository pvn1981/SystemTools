namespace ChangerMTU
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
            this.labelActive = new System.Windows.Forms.Label();
            this.comboBoxActiveNetworkConnection = new System.Windows.Forms.ComboBox();
            this.labelCurrentMTU = new System.Windows.Forms.Label();
            this.textBoxCurrentMTU = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(12, 9);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(169, 13);
            this.labelActive.TabIndex = 0;
            this.labelActive.Text = "Активные сетевые соединения:";
            // 
            // comboBoxActiveNetworkConnection
            // 
            this.comboBoxActiveNetworkConnection.FormattingEnabled = true;
            this.comboBoxActiveNetworkConnection.Location = new System.Drawing.Point(187, 6);
            this.comboBoxActiveNetworkConnection.Name = "comboBoxActiveNetworkConnection";
            this.comboBoxActiveNetworkConnection.Size = new System.Drawing.Size(201, 21);
            this.comboBoxActiveNetworkConnection.TabIndex = 1;
            this.comboBoxActiveNetworkConnection.SelectionChangeCommitted += new System.EventHandler(this.comboBoxActiveNetworkConnection_SelectionChangeCommitted);
            // 
            // labelCurrentMTU
            // 
            this.labelCurrentMTU.AutoSize = true;
            this.labelCurrentMTU.Location = new System.Drawing.Point(12, 44);
            this.labelCurrentMTU.Name = "labelCurrentMTU";
            this.labelCurrentMTU.Size = new System.Drawing.Size(132, 13);
            this.labelCurrentMTU.TabIndex = 2;
            this.labelCurrentMTU.Text = "Текущее значение MTU:";
            // 
            // textBoxCurrentMTU
            // 
            this.textBoxCurrentMTU.Location = new System.Drawing.Point(187, 41);
            this.textBoxCurrentMTU.Name = "textBoxCurrentMTU";
            this.textBoxCurrentMTU.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentMTU.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(313, 39);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 74);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel.Text = "Тут напишем что-то";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 96);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxCurrentMTU);
            this.Controls.Add(this.labelCurrentMTU);
            this.Controls.Add(this.comboBoxActiveNetworkConnection);
            this.Controls.Add(this.labelActive);
            this.Name = "FormMain";
            this.Text = "Изменение MTU";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.ComboBox comboBoxActiveNetworkConnection;
        private System.Windows.Forms.Label labelCurrentMTU;
        private System.Windows.Forms.TextBox textBoxCurrentMTU;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

