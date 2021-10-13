
namespace IfStatements
{
    partial class Form1
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.sevenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(56, 68);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(81, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input an integer";
            // 
            // inputBox
            // 
            this.inputBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.inputBox.Location = new System.Drawing.Point(153, 65);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(104, 20);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(276, 60);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(71, 29);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(59, 140);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(288, 25);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Type in your integer.";
            // 
            // sevenLabel
            // 
            this.sevenLabel.Location = new System.Drawing.Point(59, 165);
            this.sevenLabel.Name = "sevenLabel";
            this.sevenLabel.Size = new System.Drawing.Size(288, 25);
            this.sevenLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 235);
            this.Controls.Add(this.sevenLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Integer app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label sevenLabel;
    }
}

