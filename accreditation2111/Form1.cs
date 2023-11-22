using System.Windows.Forms;

namespace accreditation2111
{
    public partial class Form1 : Form
    {
        int money = 1000000, afkfarm = 0, mobSwitch = 0;
        int moneyclick = 1, damage = 1, moneyinflation = 1, farminflation = 1, ngplus = 1;
        int mobhp, mobreward;
        string mobname;
        public Form1()
        {
            InitializeComponent();
            updateTM.Enabled = true;
            afkfarmTM.Enabled = true;
            toolTip1.SetToolTip(dubinaBT, "��������� 10 \n �������� ����� 1");
            toolTip1.SetToolTip(knifeBT, "��������� 100 \n �������� ����� 10");
            toolTip1.SetToolTip(axeBT, "��������� 1000 \n �������� ����� 100");
            toolTip1.SetToolTip(wandBT, "��������� 10000 \n �������� ����� 1000");
            mobrush();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPB.Image = accreditation2111.Properties.Resources.buttonclicked;
            clicks.Enabled = true;
        }

        private void mobrush()
        {
            switch (mobSwitch)
            {
                case 0:
                    mobsPB.Image = accreditation2111.Properties.Resources.goblin_8;
                    mob goblin = new mob();
                    goblin.name = "�������";
                    mobname = goblin.name;
                    goblin.hp = 100 * ngplus;
                    mobhp = goblin.hp;
                    progressBar1.Maximum = goblin.hp;
                    progressBar1.Value = goblin.hp;
                    goblin.reward = 100 * ngplus;
                    mobreward = goblin.reward;
                    if (ngplus > 1)
                    {
                        MessageBox.Show($"�� �������� 3 ����� ������� ������ � �������� �� ��� {10000000 * ngplus} �����");
                    }
                    break;
                case 1:
                    mobsPB.Image = accreditation2111.Properties.Resources.troll_1;
                    mob troll = new mob();
                    troll.name = "������";
                    mobname = troll.name;
                    troll.hp = 1000 * ngplus;
                    progressBar1.Maximum = troll.hp;
                    progressBar1.Value = troll.hp;
                    mobhp = troll.hp;
                    troll.reward = 10000 * ngplus;
                    mobreward = troll.reward;
                    MessageBox.Show($"�� �������� ������� � �������� �� ��� {100 * ngplus} �����");

                    break;
                case 2:
                    mobsPB.Image = accreditation2111.Properties.Resources.skeleton_6;
                    mob skeleton = new mob();
                    skeleton.name = "�������";
                    mobname = skeleton.name;
                    skeleton.hp = 10000 * ngplus;
                    progressBar1.Maximum = skeleton.hp;
                    progressBar1.Value = skeleton.hp;
                    mobhp = skeleton.hp;
                    skeleton.reward = 100000 * ngplus;
                    mobreward = skeleton.reward;
                    MessageBox.Show($"�� �������� ������ � �������� �� ��� {10000 * ngplus} �����");
                    break;
                case 3:
                    mobsPB.Image = accreditation2111.Properties.Resources.death_1;
                    mob death1form = new mob();
                    death1form.name = "1 ����� ������� ������";
                    mobname = death1form.name;
                    death1form.hp = 30000 * ngplus;
                    progressBar1.Maximum = death1form.hp;
                    progressBar1.Value = death1form.hp;
                    mobhp = death1form.hp;
                    death1form.reward = 1000000 * ngplus;
                    mobreward = death1form.reward;
                    MessageBox.Show($"�� �������� ������� � �������� �� ��� {100000 * ngplus} �����");
                    break;
                case 4:
                    mobsPB.Image = accreditation2111.Properties.Resources.death_2;
                    mob death2form = new mob();
                    death2form.name = "2 ����� ������� ������";
                    mobname = death2form.name;
                    death2form.hp = 40000 * ngplus;
                    progressBar1.Maximum = death2form.hp;
                    progressBar1.Value = death2form.hp;
                    mobhp = death2form.hp;
                    death2form.reward = 1000000 * ngplus;
                    mobreward = death2form.reward;
                    MessageBox.Show($"�� �������� 1 ����� ������� ������ � �������� �� ��� {1000000 * ngplus} �����");
                    break;
                case 5:
                    mobsPB.Image = accreditation2111.Properties.Resources.death_3;
                    mob death3form = new mob();
                    death3form.name = "3 ����� ������� ������";
                    mobname = death3form.name;
                    death3form.hp = 50000 * ngplus;
                    progressBar1.Maximum = death3form.hp;
                    progressBar1.Value = death3form.hp;
                    mobhp = death3form.hp;
                    death3form.reward = 10000000 * ngplus;
                    mobreward = death3form.reward;
                    mobSwitch = -1;
                    MessageBox.Show($"�� �������� 2 ����� ������� ������ � �������� �� ��� {1000000 * ngplus} �����");
                    ngplus++;
                    break;
            }

        }


        private void clicks_Tick(object sender, EventArgs e)
        {
            buttonPB.Image = accreditation2111.Properties.Resources.buttonunclicked;
            clicks.Enabled = false;
            money += moneyclick;
        }

        private void updateTM_Tick(object sender, EventArgs e)
        {
            moneyLB.Text = $"�������: {money}";
            moneyLB.Text = $"�������: {money}";
            damageLB.Text = $"����: {damage}";
            farmLB.Text = $"��������� �����: {afkfarm}";
            clickpowerLB.Text = $"���� �����: {moneyclick}";

            toolTip1.SetToolTip(moneyringBT, $"��������� {10 * moneyinflation} \n�������� � ������� � ����� {moneyinflation}");
            toolTip1.SetToolTip(afkBT, $"��������� {100 * farminflation} \n��������� �������� ����� {farminflation}");

            if (mobhp == 0)
            {
                money += mobreward;
                mobSwitch++;
                mobrush();


            }
        }
        class mob
        {
            public string name;
            public int hp;
            public int reward;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void mobBT_Click(object sender, EventArgs e)
        {
            mobhp -= damage;
            progressBar1.Step = damage;
            if (progressBar1.Value != 0)
            {
                if (progressBar1.Value < damage)
                {
                    mobhp = 0;
                }
                else
                {
                    progressBar1.Value -= progressBar1.Step;
                }
            }

        }

        private void dubinaBT_Click(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                money -= 10;
                damage += 1;
            }
        }

        private void knifeBT_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                damage += 10;
            }
        }

        private void axeBT_Click(object sender, EventArgs e)
        {
            if (money >= 1000)
            {
                money -= 1000;
                damage += 100;
            }
        }
        private void wandBT_Click(object sender, EventArgs e)
        {
            if (money >= 10000)
            {
                money -= 10000;
                damage += 1000;
            }
        }
        private void moneyRing_Click(object sender, EventArgs e)
        {
            if (money >= 10 * moneyinflation)
            {
                money -= 10 * moneyinflation;
                moneyclick += moneyinflation;
                moneyinflation++;
            }
        }

        private void wandPB_Click(object sender, EventArgs e)
        {

        }

        private void afkBT_Click(object sender, EventArgs e)
        {
            if (money >= 100 * farminflation)
            {
                money -= 100 * farminflation;
                afkfarm += farminflation;
                farminflation++;
            }
        }

        private void afkfarmTM_Tick(object sender, EventArgs e)
        {
            money += afkfarm;
        }

        private void helpBT_Click(object sender, EventArgs e)
        {
            Helpform hf = new Helpform();
            hf.Show();
        }
    }
}