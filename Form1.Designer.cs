namespace Calculator
{
    partial class iCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iCalculator));
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonThird = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCE
            // 
            this.buttonCE.AutoSize = true;
            this.buttonCE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.Location = new System.Drawing.Point(3, 305);
            this.buttonCE.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(72, 65);
            this.buttonCE.TabIndex = 3;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.AutoSize = true;
            this.buttonZero.BackColor = System.Drawing.SystemColors.Control;
            this.buttonZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZero.Location = new System.Drawing.Point(81, 305);
            this.buttonZero.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(72, 65);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.AutoSize = true;
            this.buttonDot.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(159, 305);
            this.buttonDot.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(72, 65);
            this.buttonDot.TabIndex = 2;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.AutoSize = true;
            this.buttonEqual.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonEqual, 4);
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.Location = new System.Drawing.Point(3, 376);
            this.buttonEqual.MinimumSize = new System.Drawing.Size(290, 61);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(308, 69);
            this.buttonEqual.TabIndex = 0;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.AutoSize = true;
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivision.Location = new System.Drawing.Point(237, 305);
            this.buttonDivision.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(74, 65);
            this.buttonDivision.TabIndex = 4;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.AutoSize = true;
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(237, 234);
            this.buttonMultiply.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(74, 65);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonThird
            // 
            this.buttonThird.AutoSize = true;
            this.buttonThird.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonThird.Location = new System.Drawing.Point(159, 234);
            this.buttonThird.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonThird.Name = "buttonThird";
            this.buttonThird.Size = new System.Drawing.Size(72, 65);
            this.buttonThird.TabIndex = 7;
            this.buttonThird.Text = "3";
            this.buttonThird.UseVisualStyleBackColor = false;
            this.buttonThird.Click += new System.EventHandler(this.buttonThird_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.AutoSize = true;
            this.buttonTwo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTwo.Location = new System.Drawing.Point(81, 234);
            this.buttonTwo.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(72, 65);
            this.buttonTwo.TabIndex = 6;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.AutoSize = true;
            this.buttonOne.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOne.Location = new System.Drawing.Point(3, 234);
            this.buttonOne.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(72, 65);
            this.buttonOne.TabIndex = 5;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.AutoSize = true;
            this.buttonMinus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(237, 163);
            this.buttonMinus.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(74, 65);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.AutoSize = true;
            this.buttonSix.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSix.Location = new System.Drawing.Point(159, 163);
            this.buttonSix.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(72, 65);
            this.buttonSix.TabIndex = 11;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.AutoSize = true;
            this.buttonFive.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFive.Location = new System.Drawing.Point(81, 163);
            this.buttonFive.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(72, 65);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.AutoSize = true;
            this.buttonFour.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFour.Location = new System.Drawing.Point(3, 163);
            this.buttonFour.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(72, 65);
            this.buttonFour.TabIndex = 9;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = true;
            this.buttonPlus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(237, 92);
            this.buttonPlus.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(74, 65);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.AutoSize = true;
            this.buttonNine.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNine.Location = new System.Drawing.Point(159, 92);
            this.buttonNine.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(72, 65);
            this.buttonNine.TabIndex = 15;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.AutoSize = true;
            this.buttonEight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEight.Location = new System.Drawing.Point(81, 92);
            this.buttonEight.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(72, 65);
            this.buttonEight.TabIndex = 14;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.AutoSize = true;
            this.buttonSeven.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSeven.Location = new System.Drawing.Point(3, 92);
            this.buttonSeven.MinimumSize = new System.Drawing.Size(68, 61);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(72, 65);
            this.buttonSeven.TabIndex = 13;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelResult, 4);
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.labelResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResult.Location = new System.Drawing.Point(27, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelResult.Size = new System.Drawing.Size(284, 89);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "22222222";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCE, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivision, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSeven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonThird, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelResult, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 448);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // iCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 768);
            this.MinimumSize = new System.Drawing.Size(332, 495);
            this.Name = "iCalculator";
            this.Text = "iCalculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iCalculator_KeyPress);
            this.Resize += new System.EventHandler(this.iCalculator_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonThird;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

