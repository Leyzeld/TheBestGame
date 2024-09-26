using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_bar
{
    class Scale
    {
        private PictureBox scale_pictureBox;

        private int max_value;
        private int cur_value;

        private Label value_label;

        private int X;
        private int Y;

        private int border_rect_width;
        private int border_rect_height;
        private Color border_color;
        private int border_width;

        private int value_rect_width;
        private int value_rect_height;
        protected Brush value_rect_color;

        private int prev_value_rect_width;
        protected Brush anim_value_rect_color;
        private int anim_rect_width;

        private Timer anim_timer;


        public Scale(PictureBox pictureBox, int value)
        {
            anim_timer = new Timer();
            anim_timer.Interval = 1;
            anim_timer.Tick += new EventHandler(anim_timer_Tick);
            scale_pictureBox = pictureBox;
            max_value = value;
            cur_value = value;
            X = border_width;
            Y = border_width;
            InitValueLabel();
            border_rect_width = pictureBox.Width - border_width * 2;
            border_rect_height = pictureBox.Height - border_width * 2;
            border_color = Color.Black;
            border_width = 4;
            value_rect_height = border_rect_height;
            value_rect_width = CalculateValueRectWidth();
            value_rect_color = Brushes.Red;
            anim_value_rect_color = Brushes.Orange;
            DrawScale();
        }

        public Scale(PictureBox pictureBox, int max_value, int cur_value)
        {
            anim_timer = new Timer();
            anim_timer.Interval = 20;
            anim_timer.Tick += new EventHandler(anim_timer_Tick);
            scale_pictureBox = pictureBox;
            this.max_value = max_value;
            this.cur_value = cur_value;
            X = border_width;
            Y = border_width;
            InitValueLabel();
            border_rect_width = pictureBox.Width - border_width * 2;
            border_rect_height = pictureBox.Height - border_width * 2;
            border_color = Color.Black;
            border_width = 4;
            value_rect_height = border_rect_height;
            value_rect_width = CalculateValueRectWidth();
            value_rect_color = Brushes.Red;
            anim_value_rect_color = Brushes.Orange;
            DrawScale();
        }
        private void InitValueLabel()
        {
            value_label = new Label();
            value_label.Parent = scale_pictureBox;
            value_label.Dock = DockStyle.Fill;
            value_label.BackColor = Color.Transparent;
            value_label.Font = new Font("Tobota", scale_pictureBox.Height / 3, FontStyle.Regular);
            value_label.TextAlign = ContentAlignment.MiddleCenter;
            value_label.Text = cur_value.ToString() + " / " + max_value.ToString();
        }
        private void UpdateValueLabel()
        {
            value_label.Text = cur_value.ToString() + " / " + max_value.ToString();
        }
        private void anim_timer_Tick(object sender, EventArgs e)
        {
            int reducing_width = 1;
            DrawAnimOfReducing();

            anim_rect_width -= reducing_width;
            if (anim_rect_width < 0)
            {
                anim_timer.Stop();
                //DrawHealthBar();
            }
        }

        private int CalculateValueRectWidth()
        {
            double result_width;
            double one_hp_width = CalculateValueWidth();
            result_width = one_hp_width * cur_value;

            prev_value_rect_width = value_rect_width;

            return (int)result_width;
        }

        private double CalculateValueWidth()
        {
            return (double)border_rect_width / max_value;
        }

        public void DrawScale()
        {
            Bitmap bmp = new Bitmap(scale_pictureBox.Width, scale_pictureBox.Height); ;
            Graphics g = Graphics.FromImage(bmp);
            Rectangle border_rectangle = new Rectangle(X, Y, border_rect_width, border_rect_height);
            Rectangle health_rectangle = new Rectangle(X, Y, value_rect_width, value_rect_height);
            g.FillRectangle(value_rect_color, health_rectangle);
            g.DrawRectangle(new Pen(border_color, border_width), border_rectangle);
            scale_pictureBox.Image = bmp;
            UpdateValueLabel();
        }

        public void IncreaseValue(int value)
        {
            if (value < 0)
            {
                throw new Exception("Negative value!");
            }
            if (cur_value + value > max_value)
            {
                cur_value = max_value;
            }
            else
            {
                cur_value += value;
            }
            value_rect_width = CalculateValueRectWidth();
            DrawScale();
        }

        public void ReduceValue(int value)
        {
            if (value < 0)
            {
                throw new Exception("Negative value!");
            }
            if (cur_value - value < 0)
            {
                cur_value = 0;
            }
            else
            {
                cur_value -= value;
            }
            value_rect_width = CalculateValueRectWidth();
            anim_rect_width = prev_value_rect_width - value_rect_width;
            DrawScale();
            AnimationOfReducingValue();
        }

        private void AnimationOfReducingValue()
        {
            anim_timer.Start();
        }

        private void DrawAnimOfReducing()
        {
            Rectangle anim_rectangle = new Rectangle(X + value_rect_width, Y, anim_rect_width, value_rect_height);
            Bitmap bmp = new Bitmap(scale_pictureBox.Width, scale_pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle border_rectangle = new Rectangle(X, Y, border_rect_width, border_rect_height);
            Rectangle health_rectangle = new Rectangle(X, Y, value_rect_width, value_rect_height);
            g.FillRectangle(value_rect_color, health_rectangle);
            g.FillRectangle(anim_value_rect_color, anim_rectangle);
            g.DrawRectangle(new Pen(border_color, border_width), border_rectangle);
            scale_pictureBox.Image = bmp;
        }
    }
}
