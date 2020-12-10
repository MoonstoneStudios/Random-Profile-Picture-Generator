
namespace RandomProfile
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
            this.display = new System.Windows.Forms.PictureBox();
            this.generate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.useCustom = new System.Windows.Forms.CheckBox();
            this.twoRand = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackgroundImage = global::RandomProfile.Properties.Resources.checkergrid;
            this.display.Location = new System.Drawing.Point(141, 26);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(500, 500);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(141, 542);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(500, 94);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(226, 652);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(328, 54);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(35, 56);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(50, 50);
            this.color1.TabIndex = 3;
            this.color1.UseVisualStyleBackColor = true;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(35, 131);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(50, 50);
            this.color2.TabIndex = 4;
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Colors:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useCustom
            // 
            this.useCustom.Location = new System.Drawing.Point(18, 565);
            this.useCustom.Name = "useCustom";
            this.useCustom.Size = new System.Drawing.Size(109, 36);
            this.useCustom.TabIndex = 6;
            this.useCustom.Text = "Use Custom Colors";
            this.useCustom.UseVisualStyleBackColor = true;
            // 
            // twoRand
            // 
            this.twoRand.Location = new System.Drawing.Point(12, 607);
            this.twoRand.Name = "twoRand";
            this.twoRand.Size = new System.Drawing.Size(109, 36);
            this.twoRand.TabIndex = 7;
            this.twoRand.Text = "Gnerate TwoRandom";
            this.twoRand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 718);
            this.Controls.Add(this.twoRand);
            this.Controls.Add(this.useCustom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useCustom;
        private System.Windows.Forms.CheckBox twoRand;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

