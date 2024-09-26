using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace health_bar
{
    class HealthBar : Scale
    {

        public HealthBar(PictureBox pictureBox, int hp) : base(pictureBox, hp)
        {
            value_rect_color = Brushes.Red;
            anim_value_rect_color = Brushes.Orange;
            DrawScale();
        }

        public HealthBar(PictureBox pictureBox, int max_hp, int cur_hp): base(pictureBox, max_hp, cur_hp)
        {
            value_rect_color = Brushes.Red;
            anim_value_rect_color = Brushes.Orange;
            DrawScale();
        }
    }
}
