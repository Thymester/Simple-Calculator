namespace Calculator
{
    partial class calcForm
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
            this.sfClear = new Syncfusion.WinForms.Controls.SfButton();
            this.sfGradLabel = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.sfDivide = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum7 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum8 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum9 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfTimes = new Syncfusion.WinForms.Controls.SfButton();
            this.sfMinus = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum6 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum5 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum4 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum3 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfEquals = new Syncfusion.WinForms.Controls.SfButton();
            this.sfBack = new Syncfusion.WinForms.Controls.SfButton();
            this.sfNum0 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfDecimal = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // sfClear
            // 
            this.sfClear.AccessibleName = "Button";
            this.sfClear.BackColor = System.Drawing.Color.Red;
            this.sfClear.CanApplyTheme = false;
            this.sfClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfClear.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfClear.ForeColor = System.Drawing.Color.Black;
            this.sfClear.Location = new System.Drawing.Point(9, 131);
            this.sfClear.Name = "sfClear";
            this.sfClear.Size = new System.Drawing.Size(70, 60);
            this.sfClear.Style.BackColor = System.Drawing.Color.Red;
            this.sfClear.Style.ForeColor = System.Drawing.Color.Black;
            this.sfClear.TabIndex = 0;
            this.sfClear.Text = "C";
            this.sfClear.UseVisualStyleBackColor = false;
            this.sfClear.Click += new System.EventHandler(this.sfClear_Click);
            // 
            // sfGradLabel
            // 
            this.sfGradLabel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.SystemColors.ScrollBar, System.Drawing.Color.LightSteelBlue);
            this.sfGradLabel.BeforeTouchSize = new System.Drawing.Size(330, 122);
            this.sfGradLabel.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.sfGradLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.sfGradLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sfGradLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sfGradLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfGradLabel.Location = new System.Drawing.Point(0, 0);
            this.sfGradLabel.Name = "sfGradLabel";
            this.sfGradLabel.Size = new System.Drawing.Size(330, 122);
            this.sfGradLabel.TabIndex = 1;
            this.sfGradLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sfGradLabel.TextChanged += new System.EventHandler(this.sfGradLabel_TextChanged);
            // 
            // sfDivide
            // 
            this.sfDivide.AccessibleName = "Button";
            this.sfDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDivide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfDivide.CanApplyTheme = false;
            this.sfDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfDivide.ForeColor = System.Drawing.Color.Black;
            this.sfDivide.Location = new System.Drawing.Point(171, 131);
            this.sfDivide.Name = "sfDivide";
            this.sfDivide.Size = new System.Drawing.Size(70, 60);
            this.sfDivide.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfDivide.Style.ForeColor = System.Drawing.Color.Black;
            this.sfDivide.TabIndex = 5;
            this.sfDivide.Text = "/";
            this.sfDivide.UseVisualStyleBackColor = false;
            this.sfDivide.Click += new System.EventHandler(this.sfDivide_Click);
            // 
            // sfNum7
            // 
            this.sfNum7.AccessibleName = "Button";
            this.sfNum7.BackColor = System.Drawing.Color.Lavender;
            this.sfNum7.CanApplyTheme = false;
            this.sfNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum7.ForeColor = System.Drawing.Color.Black;
            this.sfNum7.Location = new System.Drawing.Point(9, 197);
            this.sfNum7.Name = "sfNum7";
            this.sfNum7.Size = new System.Drawing.Size(70, 60);
            this.sfNum7.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum7.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum7.TabIndex = 6;
            this.sfNum7.Text = "7";
            this.sfNum7.UseVisualStyleBackColor = false;
            this.sfNum7.Click += new System.EventHandler(this.sfNum7_Click);
            // 
            // sfNum8
            // 
            this.sfNum8.AccessibleName = "Button";
            this.sfNum8.BackColor = System.Drawing.Color.Lavender;
            this.sfNum8.CanApplyTheme = false;
            this.sfNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum8.ForeColor = System.Drawing.Color.Black;
            this.sfNum8.Location = new System.Drawing.Point(90, 197);
            this.sfNum8.Name = "sfNum8";
            this.sfNum8.Size = new System.Drawing.Size(70, 60);
            this.sfNum8.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum8.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum8.TabIndex = 7;
            this.sfNum8.Text = "8";
            this.sfNum8.UseVisualStyleBackColor = false;
            this.sfNum8.Click += new System.EventHandler(this.sfNum8_Click);
            // 
            // sfNum9
            // 
            this.sfNum9.AccessibleName = "Button";
            this.sfNum9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfNum9.BackColor = System.Drawing.Color.Lavender;
            this.sfNum9.CanApplyTheme = false;
            this.sfNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum9.ForeColor = System.Drawing.Color.Black;
            this.sfNum9.Location = new System.Drawing.Point(171, 197);
            this.sfNum9.Name = "sfNum9";
            this.sfNum9.Size = new System.Drawing.Size(70, 60);
            this.sfNum9.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum9.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum9.TabIndex = 8;
            this.sfNum9.Text = "9";
            this.sfNum9.UseVisualStyleBackColor = false;
            this.sfNum9.Click += new System.EventHandler(this.sfNum9_Click);
            // 
            // sfTimes
            // 
            this.sfTimes.AccessibleName = "Button";
            this.sfTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfTimes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfTimes.CanApplyTheme = false;
            this.sfTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfTimes.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfTimes.ForeColor = System.Drawing.Color.Black;
            this.sfTimes.Location = new System.Drawing.Point(252, 131);
            this.sfTimes.Name = "sfTimes";
            this.sfTimes.Size = new System.Drawing.Size(70, 60);
            this.sfTimes.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfTimes.Style.ForeColor = System.Drawing.Color.Black;
            this.sfTimes.TabIndex = 9;
            this.sfTimes.Text = "X";
            this.sfTimes.UseVisualStyleBackColor = false;
            this.sfTimes.Click += new System.EventHandler(this.sfTimes_Click);
            // 
            // sfMinus
            // 
            this.sfMinus.AccessibleName = "Button";
            this.sfMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfMinus.CanApplyTheme = false;
            this.sfMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfMinus.ForeColor = System.Drawing.Color.Black;
            this.sfMinus.Location = new System.Drawing.Point(252, 197);
            this.sfMinus.Name = "sfMinus";
            this.sfMinus.Size = new System.Drawing.Size(70, 60);
            this.sfMinus.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfMinus.Style.ForeColor = System.Drawing.Color.Black;
            this.sfMinus.TabIndex = 13;
            this.sfMinus.Text = "-";
            this.sfMinus.UseVisualStyleBackColor = false;
            this.sfMinus.Click += new System.EventHandler(this.sfMinus_Click);
            // 
            // sfNum6
            // 
            this.sfNum6.AccessibleName = "Button";
            this.sfNum6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfNum6.BackColor = System.Drawing.Color.Lavender;
            this.sfNum6.CanApplyTheme = false;
            this.sfNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum6.ForeColor = System.Drawing.Color.Black;
            this.sfNum6.Location = new System.Drawing.Point(171, 263);
            this.sfNum6.Name = "sfNum6";
            this.sfNum6.Size = new System.Drawing.Size(70, 60);
            this.sfNum6.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum6.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum6.TabIndex = 12;
            this.sfNum6.Text = "6";
            this.sfNum6.UseVisualStyleBackColor = false;
            this.sfNum6.Click += new System.EventHandler(this.sfNum6_Click);
            // 
            // sfNum5
            // 
            this.sfNum5.AccessibleName = "Button";
            this.sfNum5.BackColor = System.Drawing.Color.Lavender;
            this.sfNum5.CanApplyTheme = false;
            this.sfNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum5.ForeColor = System.Drawing.Color.Black;
            this.sfNum5.Location = new System.Drawing.Point(90, 263);
            this.sfNum5.Name = "sfNum5";
            this.sfNum5.Size = new System.Drawing.Size(70, 60);
            this.sfNum5.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum5.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum5.TabIndex = 11;
            this.sfNum5.Text = "5";
            this.sfNum5.UseVisualStyleBackColor = false;
            this.sfNum5.Click += new System.EventHandler(this.sfNum5_Click);
            // 
            // sfNum4
            // 
            this.sfNum4.AccessibleName = "Button";
            this.sfNum4.BackColor = System.Drawing.Color.Lavender;
            this.sfNum4.CanApplyTheme = false;
            this.sfNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum4.ForeColor = System.Drawing.Color.Black;
            this.sfNum4.Location = new System.Drawing.Point(9, 263);
            this.sfNum4.Name = "sfNum4";
            this.sfNum4.Size = new System.Drawing.Size(70, 60);
            this.sfNum4.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum4.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum4.TabIndex = 10;
            this.sfNum4.Text = "4";
            this.sfNum4.UseVisualStyleBackColor = false;
            this.sfNum4.Click += new System.EventHandler(this.sfNum4_Click);
            // 
            // sfAdd
            // 
            this.sfAdd.AccessibleName = "Button";
            this.sfAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfAdd.CanApplyTheme = false;
            this.sfAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfAdd.ForeColor = System.Drawing.Color.Black;
            this.sfAdd.Location = new System.Drawing.Point(252, 263);
            this.sfAdd.Name = "sfAdd";
            this.sfAdd.Size = new System.Drawing.Size(70, 60);
            this.sfAdd.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfAdd.Style.ForeColor = System.Drawing.Color.Black;
            this.sfAdd.TabIndex = 17;
            this.sfAdd.Text = "+";
            this.sfAdd.UseVisualStyleBackColor = false;
            this.sfAdd.Click += new System.EventHandler(this.sfAdd_Click);
            // 
            // sfNum3
            // 
            this.sfNum3.AccessibleName = "Button";
            this.sfNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfNum3.BackColor = System.Drawing.Color.Lavender;
            this.sfNum3.CanApplyTheme = false;
            this.sfNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum3.ForeColor = System.Drawing.Color.Black;
            this.sfNum3.Location = new System.Drawing.Point(171, 329);
            this.sfNum3.Name = "sfNum3";
            this.sfNum3.Size = new System.Drawing.Size(70, 60);
            this.sfNum3.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum3.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum3.TabIndex = 16;
            this.sfNum3.Text = "3";
            this.sfNum3.UseVisualStyleBackColor = false;
            this.sfNum3.Click += new System.EventHandler(this.sfNum3_Click);
            // 
            // sfNum2
            // 
            this.sfNum2.AccessibleName = "Button";
            this.sfNum2.BackColor = System.Drawing.Color.Lavender;
            this.sfNum2.CanApplyTheme = false;
            this.sfNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum2.ForeColor = System.Drawing.Color.Black;
            this.sfNum2.Location = new System.Drawing.Point(90, 329);
            this.sfNum2.Name = "sfNum2";
            this.sfNum2.Size = new System.Drawing.Size(70, 60);
            this.sfNum2.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum2.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum2.TabIndex = 15;
            this.sfNum2.Text = "2";
            this.sfNum2.UseVisualStyleBackColor = false;
            this.sfNum2.Click += new System.EventHandler(this.sfNum2_Click);
            // 
            // sfNum1
            // 
            this.sfNum1.AccessibleName = "Button";
            this.sfNum1.BackColor = System.Drawing.Color.Lavender;
            this.sfNum1.CanApplyTheme = false;
            this.sfNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum1.ForeColor = System.Drawing.Color.Black;
            this.sfNum1.Location = new System.Drawing.Point(9, 329);
            this.sfNum1.Name = "sfNum1";
            this.sfNum1.Size = new System.Drawing.Size(70, 60);
            this.sfNum1.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum1.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum1.TabIndex = 14;
            this.sfNum1.Text = "1";
            this.sfNum1.UseVisualStyleBackColor = false;
            this.sfNum1.Click += new System.EventHandler(this.sfNum1_Click);
            // 
            // sfEquals
            // 
            this.sfEquals.AccessibleName = "Button";
            this.sfEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfEquals.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfEquals.CanApplyTheme = false;
            this.sfEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfEquals.ForeColor = System.Drawing.Color.Black;
            this.sfEquals.Location = new System.Drawing.Point(252, 329);
            this.sfEquals.Name = "sfEquals";
            this.sfEquals.Size = new System.Drawing.Size(70, 60);
            this.sfEquals.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sfEquals.Style.ForeColor = System.Drawing.Color.Black;
            this.sfEquals.TabIndex = 18;
            this.sfEquals.Text = "=";
            this.sfEquals.UseVisualStyleBackColor = false;
            this.sfEquals.Click += new System.EventHandler(this.sfEquals_Click);
            // 
            // sfBack
            // 
            this.sfBack.AccessibleName = "Button";
            this.sfBack.BackColor = System.Drawing.Color.Red;
            this.sfBack.CanApplyTheme = false;
            this.sfBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfBack.ForeColor = System.Drawing.Color.Black;
            this.sfBack.Location = new System.Drawing.Point(90, 131);
            this.sfBack.Name = "sfBack";
            this.sfBack.Size = new System.Drawing.Size(70, 60);
            this.sfBack.Style.BackColor = System.Drawing.Color.Red;
            this.sfBack.Style.ForeColor = System.Drawing.Color.Black;
            this.sfBack.TabIndex = 19;
            this.sfBack.Text = "Back";
            this.sfBack.UseVisualStyleBackColor = false;
            this.sfBack.Click += new System.EventHandler(this.sfBack_Click);
            // 
            // sfNum0
            // 
            this.sfNum0.AccessibleName = "Button";
            this.sfNum0.BackColor = System.Drawing.Color.Lavender;
            this.sfNum0.CanApplyTheme = false;
            this.sfNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfNum0.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfNum0.ForeColor = System.Drawing.Color.Black;
            this.sfNum0.Location = new System.Drawing.Point(9, 395);
            this.sfNum0.Name = "sfNum0";
            this.sfNum0.Size = new System.Drawing.Size(232, 60);
            this.sfNum0.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfNum0.Style.ForeColor = System.Drawing.Color.Black;
            this.sfNum0.TabIndex = 20;
            this.sfNum0.Text = "0";
            this.sfNum0.UseVisualStyleBackColor = false;
            this.sfNum0.Click += new System.EventHandler(this.sfNum0_Click);
            // 
            // sfDecimal
            // 
            this.sfDecimal.AccessibleName = "Button";
            this.sfDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDecimal.BackColor = System.Drawing.Color.Lavender;
            this.sfDecimal.CanApplyTheme = false;
            this.sfDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.sfDecimal.ForeColor = System.Drawing.Color.Black;
            this.sfDecimal.Location = new System.Drawing.Point(252, 395);
            this.sfDecimal.Name = "sfDecimal";
            this.sfDecimal.Size = new System.Drawing.Size(70, 60);
            this.sfDecimal.Style.BackColor = System.Drawing.Color.Lavender;
            this.sfDecimal.Style.ForeColor = System.Drawing.Color.Black;
            this.sfDecimal.TabIndex = 21;
            this.sfDecimal.Text = ".";
            this.sfDecimal.UseVisualStyleBackColor = false;
            this.sfDecimal.Click += new System.EventHandler(this.sfDecimal_Click);
            // 
            // calcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(330, 470);
            this.Controls.Add(this.sfDecimal);
            this.Controls.Add(this.sfNum0);
            this.Controls.Add(this.sfBack);
            this.Controls.Add(this.sfEquals);
            this.Controls.Add(this.sfAdd);
            this.Controls.Add(this.sfNum3);
            this.Controls.Add(this.sfNum2);
            this.Controls.Add(this.sfNum1);
            this.Controls.Add(this.sfMinus);
            this.Controls.Add(this.sfNum6);
            this.Controls.Add(this.sfNum5);
            this.Controls.Add(this.sfNum4);
            this.Controls.Add(this.sfTimes);
            this.Controls.Add(this.sfNum9);
            this.Controls.Add(this.sfNum8);
            this.Controls.Add(this.sfNum7);
            this.Controls.Add(this.sfDivide);
            this.Controls.Add(this.sfGradLabel);
            this.Controls.Add(this.sfClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calcForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton sfClear;
        private Syncfusion.Windows.Forms.Tools.GradientLabel sfGradLabel;
        private Syncfusion.WinForms.Controls.SfButton sfDivide;
        private Syncfusion.WinForms.Controls.SfButton sfNum7;
        private Syncfusion.WinForms.Controls.SfButton sfNum8;
        private Syncfusion.WinForms.Controls.SfButton sfNum9;
        private Syncfusion.WinForms.Controls.SfButton sfTimes;
        private Syncfusion.WinForms.Controls.SfButton sfMinus;
        private Syncfusion.WinForms.Controls.SfButton sfNum6;
        private Syncfusion.WinForms.Controls.SfButton sfNum5;
        private Syncfusion.WinForms.Controls.SfButton sfNum4;
        private Syncfusion.WinForms.Controls.SfButton sfAdd;
        private Syncfusion.WinForms.Controls.SfButton sfNum3;
        private Syncfusion.WinForms.Controls.SfButton sfNum2;
        private Syncfusion.WinForms.Controls.SfButton sfNum1;
        private Syncfusion.WinForms.Controls.SfButton sfEquals;
        private Syncfusion.WinForms.Controls.SfButton sfBack;
        private Syncfusion.WinForms.Controls.SfButton sfNum0;
        private Syncfusion.WinForms.Controls.SfButton sfDecimal;
    }
}

