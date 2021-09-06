
using System.Threading.Tasks;

namespace ArquitecturaSoftware.MVP.DesktopView
{
    partial class NasaView
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
            if(disposing && (components != null))
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
        private async Task InitializeComponentAsync()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.logInForm = new System.Windows.Forms.GroupBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getImageButton = new System.Windows.Forms.Button();
            this.logInForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // logInForm
            // 
            this.logInForm.Controls.Add(this.logInButton);
            this.logInForm.Controls.Add(this.mailTextBox);
            this.logInForm.Location = new System.Drawing.Point(24, 53);
            this.logInForm.Name = "logInForm";
            this.logInForm.Size = new System.Drawing.Size(386, 106);
            this.logInForm.TabIndex = 1;
            this.logInForm.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(130, 51);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "Validate";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(6, 22);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(362, 23);
            this.mailTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 784);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // getImageButton
            // 
            this.getImageButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getImageButton.Location = new System.Drawing.Point(119, 375);
            this.getImageButton.Name = "getImageButton";
            this.getImageButton.Size = new System.Drawing.Size(201, 78);
            this.getImageButton.TabIndex = 3;
            this.getImageButton.Text = "Get Image";
            this.getImageButton.UseVisualStyleBackColor = true;
            this.getImageButton.Click += new System.EventHandler(this.getImageButton_ClickAsync);
            // 
            // NasaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 822);
            this.Controls.Add(this.getImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logInForm);
            this.Controls.Add(this.titleLabel);
            this.Name = "NasaView";
            this.Text = "NasaView";
            this.logInForm.ResumeLayout(false);
            this.logInForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox logInForm;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button getImageButton;
    }
}