namespace Triangle
{
    partial class MainForm
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalculate.Location = new System.Drawing.Point(33, 197);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(426, 34);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Определить тип треугольника";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.OnCalculate);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(30, 74);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(77, 17);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Сторона А";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(30, 117);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(77, 17);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Сторона B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(30, 159);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(77, 17);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "Сторона C";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(113, 71);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ShortcutsEnabled = false;
            this.textBoxA.Size = new System.Drawing.Size(346, 22);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.textBoxA.Leave += new System.EventHandler(this.OnLeaveInput);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(113, 112);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ShortcutsEnabled = false;
            this.textBoxB.Size = new System.Drawing.Size(346, 22);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.textBoxB.Leave += new System.EventHandler(this.OnLeaveInput);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(113, 154);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ShortcutsEnabled = false;
            this.textBoxC.Size = new System.Drawing.Size(346, 22);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.textBoxC.Leave += new System.EventHandler(this.OnLeaveInput);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(30, 241);
            this.labelOutput.MaximumSize = new System.Drawing.Size(420, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 17);
            this.labelOutput.TabIndex = 8;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp.Location = new System.Drawing.Point(33, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(306, 34);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Инструкция пользования программой";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.OnHelp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(360, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnExit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Определение типа треугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button button1;
    }
}

