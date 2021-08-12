using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1300;
            this.Height =900;
            bm = new Bitmap( img.Width,img.Height);  //bitmap'e çizip pixturebox'a gönderiyoruz          
            g = Graphics.FromImage(bm);            
            img.Image = bm;  
        }
        Graphics g;
        Bitmap bm;
        bool draw = false;
        int p_event;
        int linesize = 2;
        Point px, py;
        ColorDialog pickcolor = new ColorDialog();
        Pen p = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.LavenderBlush, 5);
        int x, y, cx, cy, sx, sy; //c-x y koordinatlarını atamak için s- x y boyutunu almak için
        private void color_btn_Click(object sender, EventArgs e)
        {
            pickcolor.ShowDialog();
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            linesize = int.Parse(combo_size.SelectedItem.ToString());
        }

       

        private void img_MouseDown(object sender, MouseEventArgs e) //mouse tıklandığında çizmeye başlar
        {
            draw = true;
            px = e.Location; //başlangıcı px ile atadık
            cx = e.X;
            cy = e.Y;
        }

      

        public void img_MouseMove(object sender, MouseEventArgs e)
        {
          Pen p = new Pen(pickcolor.Color,linesize);
           if (draw)
                 {
                    if (p_event==1)
                    {
                   
                    py = e.Location;
                    g.DrawLine(p, px, py); //cx, cy ile düz çizgi çizilebilir
                    px = py;
                    }

                }         
            x = e.X;         
            y = e.Y;
            sx = e.X - cx; //uzaklıklar
            sy = e.Y - cy;
        }

       
        private void img_MouseUp(object sender, MouseEventArgs e) //şekil çizimleri de ayrıca buraya yap
        {
            Pen eraser = new Pen(Color.LavenderBlush, linesize);//silginin boyutunu ayarlamak için
            Pen p = new Pen(pickcolor.Color, linesize);
            draw = false;
            sx = x - cx;
            sy = y - cy;
            if (p_event==2)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
                
            }
            if (p_event == 3)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (p_event==4)
            {
                g.DrawLine(p, cx, cy, x,y); //düz çizgi
            }
            if (p_event==5)
            {
                py = e.Location;
                g.DrawLine(eraser, px, py);
                py = px;
            }
            if (p_event==6)
            {
                px = e.Location; //noktaları birleştirerek çizer  
                g.DrawLine(p, px, py);
                py = px;
            }
            
           //.Invalidate()
            img.Refresh();
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            p_event = 5;
        }

        private void btn_dotjoin_Click(object sender, EventArgs e)
        {
            p_event = 6;
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            p_event = 1;
        }
        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            p_event = 2;
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            p_event = 3;

        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            p_event = 4;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LavenderBlush);
            img.Image = bm;
            p_event = 0;
        }
     //transparant kaydediyor ?
    private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";          
            if (save.ShowDialog()==DialogResult.OK)
            {  
                  img.Image.Save(save.FileName);
            }
      
        }

    }
}
