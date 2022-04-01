
namespace Dice
{
    partial class Form1
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
            this.diceControl1 = new Dice.DiceControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diceControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diceControl1
            // 
            this.diceControl1.BackColor = System.Drawing.Color.White;
            this.diceControl1.Count = 6;
            this.diceControl1.Location = new System.Drawing.Point(63, 45);
            this.diceControl1.Name = "diceControl1";
            this.diceControl1.NumberColor = System.Drawing.Color.Black;
            this.diceControl1.Size = new System.Drawing.Size(100, 100);
            this.diceControl1.TabIndex = 0;
            this.diceControl1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diceControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diceControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiceControl diceControl1;
        private System.Windows.Forms.Button button1;
    }
}

