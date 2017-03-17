namespace TheQuest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batPic = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ghoulPic = new System.Windows.Forms.PictureBox();
            this.ghostPic = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.mace = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            this.SuspendLayout();
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.Image = ((System.Drawing.Image)(resources.GetObject("inventorySword.Image")));
            this.inventorySword.Location = new System.Drawing.Point(67, 313);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(50, 50);
            this.inventorySword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventorySword.TabIndex = 0;
            this.inventorySword.TabStop = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBow.Image")));
            this.inventoryBow.Location = new System.Drawing.Point(123, 313);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(50, 50);
            this.inventoryBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventoryBow.TabIndex = 1;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventoryBow_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.Image = ((System.Drawing.Image)(resources.GetObject("inventoryMace.Image")));
            this.inventoryMace.Location = new System.Drawing.Point(179, 313);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(50, 50);
            this.inventoryMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventoryMace.TabIndex = 2;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventoryMace_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBluePotion.Image")));
            this.inventoryBluePotion.Location = new System.Drawing.Point(235, 313);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventoryBluePotion.TabIndex = 3;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventoryBluePotion_Click);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryRedPotion.Image")));
            this.inventoryRedPotion.Location = new System.Drawing.Point(287, 313);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inventoryRedPotion.TabIndex = 4;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventoryRedPotion_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(31, 20);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(26, 23);
            this.moveUp.TabIndex = 5;
            this.moveUp.TabStop = false;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(5, 39);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(26, 23);
            this.moveLeft.TabIndex = 6;
            this.moveLeft.TabStop = false;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(59, 39);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(25, 23);
            this.moveRight.TabIndex = 7;
            this.moveRight.TabStop = false;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(31, 49);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(26, 23);
            this.moveDown.TabIndex = 8;
            this.moveDown.TabStop = false;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Location = new System.Drawing.Point(343, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.99379F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.00621F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(364, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(129, 62);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ghoulHitPoints.Location = new System.Drawing.Point(55, 45);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(71, 17);
            this.ghoulHitPoints.TabIndex = 19;
            this.ghoulHitPoints.Text = "0";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ghostHitPoints.Location = new System.Drawing.Point(55, 30);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(71, 15);
            this.ghostHitPoints.TabIndex = 19;
            this.ghostHitPoints.Text = "0";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batHitPoints.Location = new System.Drawing.Point(55, 15);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(71, 15);
            this.batHitPoints.TabIndex = 19;
            this.batHitPoints.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerHitPoints.Location = new System.Drawing.Point(55, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(71, 15);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "0";
            // 
            // batPic
            // 
            this.batPic.BackColor = System.Drawing.Color.Transparent;
            this.batPic.Image = ((System.Drawing.Image)(resources.GetObject("batPic.Image")));
            this.batPic.Location = new System.Drawing.Point(195, 135);
            this.batPic.Name = "batPic";
            this.batPic.Size = new System.Drawing.Size(30, 30);
            this.batPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batPic.TabIndex = 11;
            this.batPic.TabStop = false;
            this.batPic.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(159, 135);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // ghoulPic
            // 
            this.ghoulPic.BackColor = System.Drawing.Color.Transparent;
            this.ghoulPic.Image = ((System.Drawing.Image)(resources.GetObject("ghoulPic.Image")));
            this.ghoulPic.Location = new System.Drawing.Point(271, 135);
            this.ghoulPic.Name = "ghoulPic";
            this.ghoulPic.Size = new System.Drawing.Size(30, 30);
            this.ghoulPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoulPic.TabIndex = 13;
            this.ghoulPic.TabStop = false;
            this.ghoulPic.Visible = false;
            // 
            // ghostPic
            // 
            this.ghostPic.BackColor = System.Drawing.Color.Transparent;
            this.ghostPic.Image = ((System.Drawing.Image)(resources.GetObject("ghostPic.Image")));
            this.ghostPic.Location = new System.Drawing.Point(231, 135);
            this.ghostPic.Name = "ghostPic";
            this.ghostPic.Size = new System.Drawing.Size(30, 30);
            this.ghostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghostPic.TabIndex = 14;
            this.ghostPic.TabStop = false;
            this.ghostPic.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(307, 135);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 15;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(343, 135);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 16;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(379, 135);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 17;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Location = new System.Drawing.Point(439, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 76);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(65, 41);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(26, 23);
            this.attackRight.TabIndex = 7;
            this.attackRight.TabStop = false;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(38, 41);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(25, 23);
            this.attackDown.TabIndex = 8;
            this.attackDown.TabStop = false;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(22, 12);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(58, 23);
            this.attackUp.TabIndex = 5;
            this.attackUp.TabStop = false;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(6, 41);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(26, 23);
            this.attackLeft.TabIndex = 6;
            this.attackLeft.TabStop = false;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(451, 135);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 19;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(415, 135);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 20;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.ghostPic);
            this.Controls.Add(this.ghoulPic);
            this.Controls.Add(this.batPic);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox batPic;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ghoulPic;
        private System.Windows.Forms.PictureBox ghostPic;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.Timer timer1;
    }
}

