
namespace Paint_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dotjoin = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 928);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_save.Location = new System.Drawing.Point(0, 802);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 38);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.btn_dotjoin);
            this.panel2.Controls.Add(this.btn_line);
            this.panel2.Controls.Add(this.btn_rect);
            this.panel2.Controls.Add(this.btn_ellipse);
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 281);
            this.panel2.TabIndex = 2;
            // 
            // btn_dotjoin
            // 
            this.btn_dotjoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_dotjoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dotjoin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_dotjoin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_dotjoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dotjoin.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dotjoin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_dotjoin.Image = ((System.Drawing.Image)(resources.GetObject("btn_dotjoin.Image")));
            this.btn_dotjoin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dotjoin.Location = new System.Drawing.Point(10, 17);
            this.btn_dotjoin.Name = "btn_dotjoin";
            this.btn_dotjoin.Size = new System.Drawing.Size(95, 57);
            this.btn_dotjoin.TabIndex = 11;
            this.btn_dotjoin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_dotjoin.UseVisualStyleBackColor = false;
            this.btn_dotjoin.Click += new System.EventHandler(this.btn_dotjoin_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_clear.Location = new System.Drawing.Point(0, 863);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 36);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR ALL!";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.Location = new System.Drawing.Point(10, 80);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(95, 57);
            this.btn_line.TabIndex = 9;
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_rect.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.Image")));
            this.btn_rect.Location = new System.Drawing.Point(10, 143);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(95, 57);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ellipse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_ellipse.Image")));
            this.btn_ellipse.Location = new System.Drawing.Point(10, 206);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(95, 57);
            this.btn_ellipse.TabIndex = 8;
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightYellow;
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.combo_size);
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.color_btn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 426);
            this.panel3.TabIndex = 3;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eraser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(21, 310);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(74, 74);
            this.btn_eraser.TabIndex = 5;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // combo_size
            // 
            this.combo_size.BackColor = System.Drawing.Color.White;
            this.combo_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.combo_size.Location = new System.Drawing.Point(12, 390);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(95, 24);
            this.combo_size.TabIndex = 2;
            this.combo_size.Text = "        size";
            this.combo_size.SelectedIndexChanged += new System.EventHandler(this.combo_size_SelectedIndexChanged);
            // 
            // btn_pen
            // 
            this.btn_pen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pen.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_pen.Image = ((System.Drawing.Image)(resources.GetObject("btn_pen.Image")));
            this.btn_pen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pen.Location = new System.Drawing.Point(21, 122);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(74, 74);
            this.btn_pen.TabIndex = 4;
            this.btn_pen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_pen.UseVisualStyleBackColor = false;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fill.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(21, 217);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(74, 74);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // color_btn
            // 
            this.color_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.color_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.color_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.color_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_btn.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.color_btn.Image = ((System.Drawing.Image)(resources.GetObject("color_btn.Image")));
            this.color_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.color_btn.Location = new System.Drawing.Point(21, 28);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(74, 74);
            this.color_btn.TabIndex = 2;
            this.color_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.color_btn.UseVisualStyleBackColor = false;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.LavenderBlush;
            this.img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(1412, 928);
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            this.img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_MouseMove);
            this.img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1394, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 928);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 928);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_dotjoin;
        private System.Windows.Forms.Button btn_eraser;
    }
}

