namespace Wincubate.Module07.Slide19
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
            this._btn = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _btn
            // 
            this._btn.Location = new System.Drawing.Point(12, 12);
            this._btn.Name = "_btn";
            this._btn.Size = new System.Drawing.Size(199, 23);
            this._btn.TabIndex = 0;
            this._btn.Text = "Await Mouse Over";
            this._btn.UseVisualStyleBackColor = true;
            this._btn.Click += new System.EventHandler(this.OnClick);
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.Color.Tomato;
            this._pictureBox.Location = new System.Drawing.Point(12, 240);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(528, 172);
            this._pictureBox.TabIndex = 1;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 424);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btn;
        private System.Windows.Forms.PictureBox _pictureBox;
    }
}

