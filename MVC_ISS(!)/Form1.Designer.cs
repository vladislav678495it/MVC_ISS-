namespace MVC_ISS___
{
    partial class Form1
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
            this.lbl_ISS = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_dist_to_aster1 = new System.Windows.Forms.Label();
            this.lbl1_dist_aste1 = new System.Windows.Forms.Label();
            this.txt_dist_to_aster1 = new System.Windows.Forms.TextBox();
            this.txt_dist_aster2 = new System.Windows.Forms.TextBox();
            this.lbl_picture = new System.Windows.Forms.Label();
            this.lbl_output_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_output_date = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ISS
            // 
            this.lbl_ISS.AutoSize = true;
            this.lbl_ISS.Location = new System.Drawing.Point(13, 13);
            this.lbl_ISS.Name = "lbl_ISS";
            this.lbl_ISS.Size = new System.Drawing.Size(29, 17);
            this.lbl_ISS.TabIndex = 0;
            this.lbl_ISS.Text = "ISS";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(16, 64);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 22);
            this.txt_x.TabIndex = 1;
            this.txt_x.TextChanged += new System.EventHandler(this.txt_x_TextChanged);
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(16, 127);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 22);
            this.txt_y.TabIndex = 2;
            this.txt_y.TextChanged += new System.EventHandler(this.txt_y_TextChanged);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(16, 41);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(14, 17);
            this.lbl_x.TabIndex = 3;
            this.lbl_x.Text = "x";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(16, 104);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(15, 17);
            this.lbl_y.TabIndex = 4;
            this.lbl_y.Text = "y";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(16, 271);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_dist_to_aster1
            // 
            this.lbl_dist_to_aster1.AutoSize = true;
            this.lbl_dist_to_aster1.Location = new System.Drawing.Point(16, 174);
            this.lbl_dist_to_aster1.Name = "lbl_dist_to_aster1";
            this.lbl_dist_to_aster1.Size = new System.Drawing.Size(140, 17);
            this.lbl_dist_to_aster1.TabIndex = 6;
            this.lbl_dist_to_aster1.Text = "distance to asteroid1";
            // 
            // lbl1_dist_aste1
            // 
            this.lbl1_dist_aste1.AutoSize = true;
            this.lbl1_dist_aste1.Location = new System.Drawing.Point(16, 221);
            this.lbl1_dist_aste1.Name = "lbl1_dist_aste1";
            this.lbl1_dist_aste1.Size = new System.Drawing.Size(140, 17);
            this.lbl1_dist_aste1.TabIndex = 7;
            this.lbl1_dist_aste1.Text = "distance to asteroid2";
            // 
            // txt_dist_to_aster1
            // 
            this.txt_dist_to_aster1.Location = new System.Drawing.Point(16, 196);
            this.txt_dist_to_aster1.Name = "txt_dist_to_aster1";
            this.txt_dist_to_aster1.Size = new System.Drawing.Size(140, 22);
            this.txt_dist_to_aster1.TabIndex = 8;
            // 
            // txt_dist_aster2
            // 
            this.txt_dist_aster2.Location = new System.Drawing.Point(16, 243);
            this.txt_dist_aster2.Name = "txt_dist_aster2";
            this.txt_dist_aster2.Size = new System.Drawing.Size(140, 22);
            this.txt_dist_aster2.TabIndex = 9;
            this.txt_dist_aster2.TextChanged += new System.EventHandler(this.txt_dist_aster2_TextChanged);
            // 
            // lbl_picture
            // 
            this.lbl_picture.AutoSize = true;
            this.lbl_picture.Location = new System.Drawing.Point(307, 9);
            this.lbl_picture.Name = "lbl_picture";
            this.lbl_picture.Size = new System.Drawing.Size(51, 17);
            this.lbl_picture.TabIndex = 10;
            this.lbl_picture.Text = "picture";
            // 
            // lbl_output_date
            // 
            this.lbl_output_date.AutoSize = true;
            this.lbl_output_date.Location = new System.Drawing.Point(16, 322);
            this.lbl_output_date.Name = "lbl_output_date";
            this.lbl_output_date.Size = new System.Drawing.Size(80, 17);
            this.lbl_output_date.TabIndex = 12;
            this.lbl_output_date.Text = "output date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // list_output_date
            // 
            this.list_output_date.HideSelection = false;
            this.list_output_date.Location = new System.Drawing.Point(16, 343);
            this.list_output_date.Name = "list_output_date";
            this.list_output_date.Size = new System.Drawing.Size(231, 97);
            this.list_output_date.TabIndex = 13;
            this.list_output_date.UseCompatibleStateImageBehavior = false;
            this.list_output_date.SelectedIndexChanged += new System.EventHandler(this.list_output_date_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_output_date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_output_date);
            this.Controls.Add(this.lbl_picture);
            this.Controls.Add(this.txt_dist_aster2);
            this.Controls.Add(this.txt_dist_to_aster1);
            this.Controls.Add(this.lbl1_dist_aste1);
            this.Controls.Add(this.lbl_dist_to_aster1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.lbl_ISS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ISS;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_dist_to_aster1;
        private System.Windows.Forms.Label lbl1_dist_aste1;
        private System.Windows.Forms.TextBox txt_dist_to_aster1;
        private System.Windows.Forms.TextBox txt_dist_aster2;
        private System.Windows.Forms.Label lbl_picture;
        private System.Windows.Forms.Label lbl_output_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView list_output_date;
    }
}

