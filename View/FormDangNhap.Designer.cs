namespace CafeManagement
{
     partial class FormDangNhap
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
               this.pbLogo = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // pbLogo
               // 
               this.pbLogo.Location = new System.Drawing.Point(-268, -198);
               this.pbLogo.Name = "pbLogo";
               this.pbLogo.Size = new System.Drawing.Size(536, 523);
               this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pbLogo.TabIndex = 0;
               this.pbLogo.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(-1, 175);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(440, 188);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // FormDangNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(743, 426);
               this.Controls.Add(this.pbLogo);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormDangNhap";
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.PictureBox pbLogo;
          private System.Windows.Forms.PictureBox pictureBox1;
     }
}

