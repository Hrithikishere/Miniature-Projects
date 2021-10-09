
namespace StandardCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnXInverse = new System.Windows.Forms.Button();
            this.btnSqaure = new System.Windows.Forms.Button();
            this.btnRootOver = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSingleClear = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearE = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinus.Location = new System.Drawing.Point(8, 500);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(102, 64);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = " ± ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnZero.Location = new System.Drawing.Point(116, 500);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(102, 64);
            this.btnZero.TabIndex = 25;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPlus.Location = new System.Drawing.Point(331, 431);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(102, 64);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.basicOperations);
            // 
            // btnDot
            // 
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDot.Location = new System.Drawing.Point(223, 501);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(102, 64);
            this.btnDot.TabIndex = 3;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstraction.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSubstraction.Location = new System.Drawing.Point(331, 363);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(102, 64);
            this.btnSubstraction.TabIndex = 8;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.basicOperations);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThree.Location = new System.Drawing.Point(223, 431);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(102, 64);
            this.btnThree.TabIndex = 7;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTwo.Location = new System.Drawing.Point(116, 430);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(102, 64);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOne.Location = new System.Drawing.Point(8, 431);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(102, 64);
            this.btnOne.TabIndex = 5;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnMultiplication.Location = new System.Drawing.Point(331, 295);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(102, 64);
            this.btnMultiplication.TabIndex = 12;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.basicOperations);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Transparent;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSix.Location = new System.Drawing.Point(223, 363);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(102, 64);
            this.btnSix.TabIndex = 11;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Transparent;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFive.Location = new System.Drawing.Point(116, 363);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(102, 64);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFour.Location = new System.Drawing.Point(8, 362);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(102, 64);
            this.btnFour.TabIndex = 9;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnDevide
            // 
            this.btnDevide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDevide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevide.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDevide.Location = new System.Drawing.Point(331, 225);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(102, 64);
            this.btnDevide.TabIndex = 16;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = false;
            this.btnDevide.Click += new System.EventHandler(this.basicOperations);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Transparent;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNine.Location = new System.Drawing.Point(223, 295);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(102, 64);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Transparent;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEight.Location = new System.Drawing.Point(116, 295);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(102, 64);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.numbersOnly);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSeven.Location = new System.Drawing.Point(8, 294);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(102, 64);
            this.btnSeven.TabIndex = 13;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.numbersOnly);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(7, 86);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(425, 61);
            this.txtDisplay.TabIndex = 17;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnXInverse
            // 
            this.btnXInverse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXInverse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXInverse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnXInverse.Location = new System.Drawing.Point(8, 224);
            this.btnXInverse.Name = "btnXInverse";
            this.btnXInverse.Size = new System.Drawing.Size(102, 64);
            this.btnXInverse.TabIndex = 21;
            this.btnXInverse.Text = " x⁻¹";
            this.btnXInverse.UseVisualStyleBackColor = false;
            this.btnXInverse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSqaure
            // 
            this.btnSqaure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSqaure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqaure.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqaure.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSqaure.Location = new System.Drawing.Point(116, 224);
            this.btnSqaure.Name = "btnSqaure";
            this.btnSqaure.Size = new System.Drawing.Size(102, 64);
            this.btnSqaure.TabIndex = 20;
            this.btnSqaure.Text = "x²";
            this.btnSqaure.UseVisualStyleBackColor = false;
            this.btnSqaure.Click += new System.EventHandler(this.btnSqaure_Click);
            // 
            // btnRootOver
            // 
            this.btnRootOver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRootOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRootOver.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRootOver.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnRootOver.Location = new System.Drawing.Point(223, 224);
            this.btnRootOver.Name = "btnRootOver";
            this.btnRootOver.Size = new System.Drawing.Size(102, 64);
            this.btnRootOver.TabIndex = 19;
            this.btnRootOver.Text = "√";
            this.btnRootOver.UseVisualStyleBackColor = false;
            this.btnRootOver.Click += new System.EventHandler(this.btnRootOver_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPercentage.Location = new System.Drawing.Point(8, 155);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(102, 64);
            this.btnPercentage.TabIndex = 18;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(331, 501);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(102, 64);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSingleClear
            // 
            this.btnSingleClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSingleClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleClear.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleClear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSingleClear.Image = ((System.Drawing.Image)(resources.GetObject("btnSingleClear.Image")));
            this.btnSingleClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSingleClear.Location = new System.Drawing.Point(331, 155);
            this.btnSingleClear.Name = "btnSingleClear";
            this.btnSingleClear.Size = new System.Drawing.Size(102, 64);
            this.btnSingleClear.TabIndex = 24;
            this.btnSingleClear.Text = "⌫";
            this.btnSingleClear.UseVisualStyleBackColor = false;
            this.btnSingleClear.Click += new System.EventHandler(this.btnSingleClear_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnClear.Location = new System.Drawing.Point(223, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 64);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearE
            // 
            this.btnClearE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearE.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearE.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnClearE.Location = new System.Drawing.Point(115, 155);
            this.btnClearE.Name = "btnClearE";
            this.btnClearE.Size = new System.Drawing.Size(102, 64);
            this.btnClearE.TabIndex = 22;
            this.btnClearE.Text = "CE";
            this.btnClearE.UseVisualStyleBackColor = false;
            this.btnClearE.Click += new System.EventHandler(this.btnClearE_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOp.Location = new System.Drawing.Point(374, 58);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(59, 25);
            this.lblShowOp.TabIndex = 26;
            this.lblShowOp.Text = "Show";
            this.lblShowOp.Visible = false;
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(5, 9);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(182, 25);
            this.lblStandard.TabIndex = 27;
            this.lblStandard.Text = "Standard Calculator";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 572);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSingleClear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearE);
            this.Controls.Add(this.btnXInverse);
            this.Controls.Add(this.btnSqaure);
            this.Controls.Add(this.btnRootOver);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnXInverse;
        private System.Windows.Forms.Button btnSqaure;
        private System.Windows.Forms.Button btnRootOver;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSingleClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearE;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Label lblStandard;
    }
}

