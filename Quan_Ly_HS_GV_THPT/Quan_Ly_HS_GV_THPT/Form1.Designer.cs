namespace Quan_Ly_HS_GV_THPT
{
     partial class frm_Start
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
               this.components = new System.ComponentModel.Container();
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.BackgroundImage = global::Quan_Ly_HS_GV_THPT.Properties.Resources.QuanLyTHPT;
               this.ClientSize = new System.Drawing.Size(1001, 569);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
               this.Name = "frm_Start";
               this.Text = "Quản lý THPT";
               this.Load += new System.EventHandler(this.frm_Start_Load);
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;



    }
}

