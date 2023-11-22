using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accreditation2111
{
    public partial class Helpform : Form
    {
        public Helpform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Helpform_Load(object sender, EventArgs e)
        {
            label2.Text = "- Нажатие на неё приносит\nденюжки эквивалетные\nвашей силе клика";
            damageLB.Text = "- Урон показывает сколько урона\nза клик вы наносите врагам";
            farmLB.Text = "- Пассивный доход\nпоказывает сколько денюжек вы получаете\nавтоматически, изначально равен 0";
            upgradesLB.Text = "- Покупка экипировки увеличивает урон, силу клика и пассивный доход";
            label7.Text = "Золотое кольцо, изначально стоит 10\nдобавляет 1 силу клика,\nувеличивет свою стоимость на 10 и силу клика на 1\nпосле покупки";
            label8.Text = "Контракт, изначально стоит 100 и\nдобавляет 1 к пассивному доходу,\nувеличивает свою стоимость на 100\nи количество пассивного дохода на 1\nпосле покупки";
            label9.Text = "- Монстры, нажатие по ним уменьшает их здоровье\nопустив здоровье до 0\nвы убиваете монстра и получаете награду";
        }
    }
}
