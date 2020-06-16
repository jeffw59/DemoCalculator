namespace DemoCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(2, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(348, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Location = new System.Drawing.Point(2, 39);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(388, 23);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            this.CalculationResultText.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.button1, 0, 4);
            this.ButtonPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonPanel.Location = new System.Drawing.Point(2, 65);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(388, 373);
            this.ButtonPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(91, 68);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.Name = "Form1";
            this.Text = "Basic Calulator";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button button1;
    }
}

