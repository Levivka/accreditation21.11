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
            ((System.ComponentModel.ISupportInitialize)buttonPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobsPB).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 324);
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
            buttonPB.Location = new Point(33, 324);
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
            damageLB.Location = new Point(48, 73);
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
            mobsPB.Location = new Point(543, 32);
            mobsPB.Name = "mobsPB";
            mobsPB.Size = new Size(211, 276);
            mobsPB.TabIndex = 5;
            mobsPB.TabStop = false;
            // 
            // clicks
            // 
            clicks.Interval = 500;
            clicks.Tick += clicks_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(mobsPB);
            Controls.Add(farmLB);
            Controls.Add(damageLB);
            Controls.Add(moneyLB);
            Controls.Add(buttonPB);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)buttonPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)mobsPB).EndInit();
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
    }
}