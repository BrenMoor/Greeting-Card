namespace Greeting_Card_Good
{
    partial class lepusConstellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lepusConstellation));
            this.labelLepusTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelParagraph = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLepusTitle
            // 
            this.labelLepusTitle.AutoSize = true;
            this.labelLepusTitle.Font = new System.Drawing.Font("Futura-Heavy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLepusTitle.Location = new System.Drawing.Point(425, 339);
            this.labelLepusTitle.Name = "labelLepusTitle";
            this.labelLepusTitle.Size = new System.Drawing.Size(1034, 121);
            this.labelLepusTitle.TabIndex = 0;
            this.labelLepusTitle.Text = "LEPUS CONSTELLATION";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Myriad Hebrew", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(793, 488);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(291, 39);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Brendan Moorehead";
            // 
            // labelParagraph
            // 
            this.labelParagraph.AutoSize = true;
            this.labelParagraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParagraph.Location = new System.Drawing.Point(246, 708);
            this.labelParagraph.Name = "labelParagraph";
            this.labelParagraph.Size = new System.Drawing.Size(1335, 128);
            this.labelParagraph.TabIndex = 2;
            this.labelParagraph.Text = resources.GetString("labelParagraph.Text");
            this.labelParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lepusConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Greeting_Card_Good.Properties.Resources.Stars;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelParagraph);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLepusTitle);
            this.Name = "lepusConstellation";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLepusTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelParagraph;
    }
}

