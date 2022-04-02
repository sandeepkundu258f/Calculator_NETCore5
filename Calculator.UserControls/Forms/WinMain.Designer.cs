using Calculator.Class;

namespace Calculator
{
    partial class WinMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.menuBar = new Calculator.UserControls.UserControls.MenuBar();
            this.basicCalculator = new Calculator.UserControls.UserControls.Basic();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Location = new System.Drawing.Point(1, 1);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(410, 25);
            this.menuBar.TabIndex = 20;
            // 
            // basicCalculator
            // 
            this.basicCalculator.Location = new System.Drawing.Point(1, 32);
            this.basicCalculator.Name = "basicCalculator";
            this.basicCalculator.Size = new System.Drawing.Size(410, 377);
            this.basicCalculator.TabIndex = 1;
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(412, 409);
            this.Controls.Add(this.basicCalculator);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WinMain";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UserControls.MenuBar menuBar;
        private UserControls.UserControls.Basic basicCalculator;
    }
}

