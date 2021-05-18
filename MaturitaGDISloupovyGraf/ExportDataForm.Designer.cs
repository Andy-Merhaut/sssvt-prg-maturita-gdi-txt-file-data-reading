
namespace MaturitaGDISloupovyGraf
{
    partial class ExportDataForm
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
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.TextFileTextBox = new System.Windows.Forms.TextBox();
            this.FunctionPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.AddButton);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 350);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(800, 100);
            this.FunctionPanel.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(334, 29);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Zmen Soubor";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Controls.Add(this.TextFileTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 350);
            this.MainPanel.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(12, 44);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(342, 13);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "DO POLICKA VEDLE ZADEJ HODNOTY A ODDEL JE STREDNIKEM";
            // 
            // TextFileTextBox
            // 
            this.TextFileTextBox.Location = new System.Drawing.Point(196, 71);
            this.TextFileTextBox.Multiline = true;
            this.TextFileTextBox.Name = "TextFileTextBox";
            this.TextFileTextBox.Size = new System.Drawing.Size(566, 256);
            this.TextFileTextBox.TabIndex = 0;
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FunctionPanel);
            this.Name = "ExportDataForm";
            this.Text = "ExportData";
            this.FunctionPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox TextFileTextBox;
    }
}