namespace accreditation2111
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            buttonPB = new PictureBox();
            moneyLB = new Label();
            damageLB = new Label();
            farmLB = new Label();
            mobsPB = new PictureBox();
            clicks = new System.Windows.Forms.Timer(components);
            updateTM = new System.Windows.Forms.Timer(components);
            mobBT = new Button();
            progressBar1 = new ProgressBar();
            upgradesLB = new Label();
            dubinaBT = new Button();
            knifeBT = new Button();
            axeBT = new Button();
            moneyringBT = new Button();
            wandBT = new Button();
            toolTip1 = new ToolTip(components);
            afkBT = new Button();
            afkfarmTM = new System.Windows.Forms.Timer(components);
            clickpowerLB = new Label();
            attackPB = new PictureBox();
            attackTM = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)buttonPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobsPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attackPB).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 330);
            button1.Name = "button1";
            button1.Size = new Size(108, 108);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPB
            // 
            buttonPB.Enabled = false;
            buttonPB.Image = Properties.Resources.buttonunclicked;
            buttonPB.Location = new Point(282, 330);
            buttonPB.Name = "buttonPB";
            buttonPB.Size = new Size(108, 108);
            buttonPB.TabIndex = 1;
            buttonPB.TabStop = false;
            // 
            // moneyLB
            // 
            moneyLB.AutoSize = true;
            moneyLB.Font = new Font("Silver", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            moneyLB.Location = new Point(48, 32);
            moneyLB.Name = "moneyLB";
            moneyLB.Size = new Size(87, 30);
            moneyLB.TabIndex = 2;
            moneyLB.Text = "Денюжка";
            // 
            // damageLB
            // 
            damageLB.AutoSize = true;
            damageLB.Font = new Font("Silver", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            damageLB.Location = new Point(48, 78);
            damageLB.Name = "damageLB";
            damageLB.Size = new Size(53, 30);
            damageLB.TabIndex = 3;
            damageLB.Text = "Урон";
            // 
            // farmLB
            // 
            farmLB.AutoSize = true;
            farmLB.Font = new Font("Silver", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            farmLB.Location = new Point(48, 125);
            farmLB.Name = "farmLB";
            farmLB.Size = new Size(202, 30);
            farmLB.TabIndex = 4;
            farmLB.Text = "Пассивный заработок";
            // 
            // mobsPB
            // 
            mobsPB.Enabled = false;
            mobsPB.ErrorImage = null;
            mobsPB.Location = new Point(562, 32);
            mobsPB.Name = "mobsPB";
            mobsPB.Size = new Size(211, 276);
            mobsPB.SizeMode = PictureBoxSizeMode.Zoom;
            mobsPB.TabIndex = 5;
            mobsPB.TabStop = false;
            // 
            // clicks
            // 
            clicks.Interval = 500;
            clicks.Tick += clicks_Tick;
            // 
            // updateTM
            // 
            updateTM.Tick += updateTM_Tick;
            // 
            // mobBT
            // 
            mobBT.Location = new Point(562, 32);
            mobBT.Name = "mobBT";
            mobBT.Size = new Size(211, 275);
            mobBT.TabIndex = 6;
            mobBT.Text = "button2";
            mobBT.UseVisualStyleBackColor = true;
            mobBT.Click += mobBT_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(562, 376);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(211, 56);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // upgradesLB
            // 
            upgradesLB.AutoSize = true;
            upgradesLB.Font = new Font("Silver", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            upgradesLB.Location = new Point(12, 173);
            upgradesLB.Name = "upgradesLB";
            upgradesLB.Size = new Size(113, 30);
            upgradesLB.TabIndex = 8;
            upgradesLB.Text = "Экипировка";
            // 
            // dubinaBT
            // 
            dubinaBT.Image = Properties.Resources.dubina;
            dubinaBT.Location = new Point(12, 206);
            dubinaBT.Name = "dubinaBT";
            dubinaBT.Size = new Size(58, 58);
            dubinaBT.TabIndex = 11;
            dubinaBT.UseVisualStyleBackColor = true;
            dubinaBT.Click += dubinaBT_Click;
            // 
            // knifeBT
            // 
            knifeBT.Image = Properties.Resources.knife;
            knifeBT.Location = new Point(77, 206);
            knifeBT.Name = "knifeBT";
            knifeBT.Size = new Size(58, 58);
            knifeBT.TabIndex = 12;
            knifeBT.UseVisualStyleBackColor = true;
            knifeBT.Click += knifeBT_Click;
            // 
            // axeBT
            // 
            axeBT.Image = Properties.Resources.axe;
            axeBT.Location = new Point(141, 206);
            axeBT.Name = "axeBT";
            axeBT.Size = new Size(58, 58);
            axeBT.TabIndex = 14;
            axeBT.UseVisualStyleBackColor = true;
            axeBT.Click += axeBT_Click;
            // 
            // moneyringBT
            // 
            moneyringBT.Image = Properties.Resources.moneyring;
            moneyringBT.Location = new Point(77, 278);
            moneyringBT.Name = "moneyringBT";
            moneyringBT.Size = new Size(58, 58);
            moneyringBT.TabIndex = 17;
            moneyringBT.UseVisualStyleBackColor = true;
            moneyringBT.Click += moneyRing_Click;
            // 
            // wandBT
            // 
            wandBT.Image = Properties.Resources.wand;
            wandBT.Location = new Point(12, 278);
            wandBT.Name = "wandBT";
            wandBT.Size = new Size(58, 58);
            wandBT.TabIndex = 18;
            wandBT.UseVisualStyleBackColor = true;
            wandBT.Click += wandBT_Click;
            // 
            // afkBT
            // 
            afkBT.Image = Properties.Resources.page;
            afkBT.Location = new Point(141, 278);
            afkBT.Name = "afkBT";
            afkBT.Size = new Size(58, 58);
            afkBT.TabIndex = 19;
            afkBT.UseVisualStyleBackColor = true;
            afkBT.Click += afkBT_Click;
            // 
            // afkfarmTM
            // 
            afkfarmTM.Interval = 500;
            afkfarmTM.Tick += afkfarmTM_Tick;
            // 
            // clickpowerLB
            // 
            clickpowerLB.AutoSize = true;
            clickpowerLB.Font = new Font("Silver", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            clickpowerLB.Location = new Point(12, 376);
            clickpowerLB.Name = "clickpowerLB";
            clickpowerLB.Size = new Size(111, 30);
            clickpowerLB.TabIndex = 20;
            clickpowerLB.Text = "Сила клика";
            // 
            // attackPB
            // 
            attackPB.BackColor = Color.Transparent;
            attackPB.BackgroundImageLayout = ImageLayout.None;
            attackPB.Enabled = false;
            attackPB.Image = Properties.Resources.wand;
            attackPB.Location = new Point(562, 32);
            attackPB.Name = "attackPB";
            attackPB.Size = new Size(211, 275);
            attackPB.TabIndex = 21;
            attackPB.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(attackPB);
            Controls.Add(clickpowerLB);
            Controls.Add(afkBT);
            Controls.Add(moneyringBT);
            Controls.Add(wandBT);
            Controls.Add(upgradesLB);
            Controls.Add(progressBar1);
            Controls.Add(mobsPB);
            Controls.Add(farmLB);
            Controls.Add(damageLB);
            Controls.Add(moneyLB);
            Controls.Add(buttonPB);
            Controls.Add(button1);
            Controls.Add(mobBT);
            Controls.Add(dubinaBT);
            Controls.Add(knifeBT);
            Controls.Add(axeBT);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)buttonPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)mobsPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)attackPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox buttonPB;
        private Label moneyLB;
        private Label damageLB;
        private Label farmLB;
        private PictureBox mobsPB;
        private System.Windows.Forms.Timer clicks;
        private System.Windows.Forms.Timer updateTM;
        private Button mobBT;
        private ProgressBar progressBar1;
        private Label upgradesLB;
        private Button dubinaBT;
        private Button knifeBT;
        private Button axeBT;
        private Button moneyringBT;
        private Button wandBT;
        private ToolTip toolTip1;
        private Button afkBT;
        private System.Windows.Forms.Timer afkfarmTM;
        private Label clickpowerLB;
        private PictureBox attackPB;
        private System.Windows.Forms.Timer attackTM;
    }
}