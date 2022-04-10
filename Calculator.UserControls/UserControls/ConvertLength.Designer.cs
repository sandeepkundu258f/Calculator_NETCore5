
namespace Calculator.UserControls.UserControls
{
    partial class ConvertLength
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.comboBoxInput = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = global::Calculator.UserControls.Properties.Resources.Back_Button_icon;
            this.btnBack.Location = new System.Drawing.Point(331, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 70);
            this.btnBack.TabIndex = 51;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(331, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 68);
            this.btnClear.TabIndex = 50;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(250, 230);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(76, 68);
            this.btnDecimal.TabIndex = 49;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btnDecimal.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(250, 304);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 70);
            this.btn0.TabIndex = 48;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn0.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(168, 304);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 70);
            this.btn9.TabIndex = 47;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn9.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(86, 304);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 70);
            this.btn8.TabIndex = 46;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn8.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(4, 304);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 70);
            this.btn7.TabIndex = 45;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn7.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(168, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 68);
            this.btn6.TabIndex = 44;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn6.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(86, 230);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 68);
            this.btn5.TabIndex = 43;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn5.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(4, 230);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 68);
            this.btn4.TabIndex = 42;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn4.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(168, 156);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 68);
            this.btn3.TabIndex = 41;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn3.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(86, 156);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 68);
            this.btn2.TabIndex = 40;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn2.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(4, 156);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 68);
            this.btn1.TabIndex = 39;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnStrConCat_Click);
            this.btn1.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOutput.Location = new System.Drawing.Point(4, 23);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxOutput.Size = new System.Drawing.Size(293, 45);
            this.textBoxOutput.TabIndex = 53;
            this.textBoxOutput.TabStop = false;
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOutput.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Location = new System.Drawing.Point(117, 37);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(59, 15);
            this.lblHidden.TabIndex = 54;
            this.lblHidden.Text = "lblHidden";
            this.lblHidden.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lblHidden_PreviewKeyDown);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(4, 92);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInput.Size = new System.Drawing.Size(293, 45);
            this.textBoxInput.TabIndex = 52;
            this.textBoxInput.TabStop = false;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxInput.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Location = new System.Drawing.Point(303, 34);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(97, 23);
            this.comboBoxOutput.TabIndex = 55;
            this.comboBoxOutput.TabStop = false;
            this.comboBoxOutput.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // comboBoxInput
            // 
            this.comboBoxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInput.FormattingEnabled = true;
            this.comboBoxInput.Location = new System.Drawing.Point(303, 103);
            this.comboBoxInput.Name = "comboBoxInput";
            this.comboBoxInput.Size = new System.Drawing.Size(97, 23);
            this.comboBoxInput.TabIndex = 56;
            this.comboBoxInput.TabStop = false;
            this.comboBoxInput.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(250, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 68);
            this.btnReset.TabIndex = 57;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Output";
            // 
            // ConvertTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxInput);
            this.Controls.Add(this.comboBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.lblHidden);
            this.Name = "ConvertLength";
            this.Size = new System.Drawing.Size(410, 377);
            this.Load += new System.EventHandler(this.ConvertLength_Load);
            this.Enter += new System.EventHandler(this.btnRemoveFocus_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
