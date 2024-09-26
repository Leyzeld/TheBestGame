using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_bar
{
    class ExperienceBar:Scale
    {
        public ExperienceBar(PictureBox pictureBox, int exp) : base(pictureBox, exp)
        {
            value_rect_color = Brushes.Blue;
            anim_value_rect_color = Brushes.LightSkyBlue;
            DrawScale();
        }

        public ExperienceBar(PictureBox pictureBox, int max_exp, int cur_exp) : base(pictureBox, max_exp, cur_exp)
        {
            value_rect_color = Brushes.Blue;
            anim_value_rect_color = Brushes.LightSkyBlue;
            DrawScale();
        }
    }
}
