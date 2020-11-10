using Quan_Ly_HS_GV_THPT.Properties;

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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Start));
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Gold;
               this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button1.Image = global::Quan_Ly_HS_GV_THPT.Properties.Resources.Science_Classroom_icon;
               this.button1.Location = new System.Drawing.Point(510, 269);
               this.button1.Margin = new System.Windows.Forms.Padding(4);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(173, 175);
               this.button1.TabIndex = 0;
               this.button1.Text = "LỚP";
               this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button2.Image = global::Quan_Ly_HS_GV_THPT.Properties.Resources.Science_Students_icon;
               this.button2.Location = new System.Drawing.Point(128, 269);
               this.button2.Margin = new System.Windows.Forms.Padding(4);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(173, 175);
               this.button2.TabIndex = 1;
               this.button2.Text = "HỌC SINH";
               this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.Color.HotPink;
               this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button3.Image = global::Quan_Ly_HS_GV_THPT.Properties.Resources._10225_woman_teacher_light_skin_tone_icon;
               this.button3.Location = new System.Drawing.Point(319, 269);
               this.button3.Margin = new System.Windows.Forms.Padding(4);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(173, 175);
               this.button3.TabIndex = 2;
               this.button3.Text = "GIÁO VIÊN";
               this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.Color.DodgerBlue;
               this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button4.Image = global::Quan_Ly_HS_GV_THPT.Properties.Resources.search_icon;
               this.button4.Location = new System.Drawing.Point(691, 269);
               this.button4.Margin = new System.Windows.Forms.Padding(4);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(173, 175);
               this.button4.TabIndex = 3;
               this.button4.Text = "Help";
               this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Green;
               this.label1.Location = new System.Drawing.Point(231, 180);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(561, 38);
               this.label1.TabIndex = 4;
               this.label1.Text = "Quản Lý Học Sinh - Giáo Viên THPT";
               // 
               // frm_Start
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.BackgroundImage = global::Quan_Ly_HS_GV_THPT.Properties.Resources.a660259e0ec5e8ce4e9927b96f8a7027;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(1001, 569);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "frm_Start";
               this.Text = "Quản lý THPT";
               this.Load += new System.EventHandler(this.frm_Start_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Label label1;
     }
}

