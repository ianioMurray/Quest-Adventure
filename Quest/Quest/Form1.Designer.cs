namespace Quest
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
            this.PlayerImage = new System.Windows.Forms.PictureBox();
            this.BatImage = new System.Windows.Forms.PictureBox();
            this.GhoulImage = new System.Windows.Forms.PictureBox();
            this.GhostImage = new System.Windows.Forms.PictureBox();
            this.BowImage = new System.Windows.Forms.PictureBox();
            this.MaceImage = new System.Windows.Forms.PictureBox();
            this.SwordImage = new System.Windows.Forms.PictureBox();
            this.BluePotionImage = new System.Windows.Forms.PictureBox();
            this.RedPotionImage = new System.Windows.Forms.PictureBox();
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerImage
            // 
            this.PlayerImage.BackColor = System.Drawing.Color.Transparent;
            this.PlayerImage.BackgroundImage = global::Quest.Properties.Resources.player;
            this.PlayerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerImage.Location = new System.Drawing.Point(147, 101);
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.Size = new System.Drawing.Size(60, 60);
            this.PlayerImage.TabIndex = 0;
            this.PlayerImage.TabStop = false;
            // 
            // BatImage
            // 
            this.BatImage.BackColor = System.Drawing.Color.Transparent;
            this.BatImage.BackgroundImage = global::Quest.Properties.Resources.bat1;
            this.BatImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BatImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatImage.Location = new System.Drawing.Point(229, 101);
            this.BatImage.Name = "BatImage";
            this.BatImage.Size = new System.Drawing.Size(60, 60);
            this.BatImage.TabIndex = 1;
            this.BatImage.TabStop = false;
            // 
            // GhoulImage
            // 
            this.GhoulImage.BackColor = System.Drawing.Color.Transparent;
            this.GhoulImage.BackgroundImage = global::Quest.Properties.Resources.ghoul;
            this.GhoulImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GhoulImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GhoulImage.Location = new System.Drawing.Point(314, 101);
            this.GhoulImage.Name = "GhoulImage";
            this.GhoulImage.Size = new System.Drawing.Size(60, 60);
            this.GhoulImage.TabIndex = 2;
            this.GhoulImage.TabStop = false;
            // 
            // GhostImage
            // 
            this.GhostImage.BackColor = System.Drawing.Color.Transparent;
            this.GhostImage.BackgroundImage = global::Quest.Properties.Resources.ghost;
            this.GhostImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GhostImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GhostImage.Location = new System.Drawing.Point(394, 101);
            this.GhostImage.Name = "GhostImage";
            this.GhostImage.Size = new System.Drawing.Size(60, 60);
            this.GhostImage.TabIndex = 3;
            this.GhostImage.TabStop = false;
            // 
            // BowImage
            // 
            this.BowImage.BackColor = System.Drawing.Color.Transparent;
            this.BowImage.BackgroundImage = global::Quest.Properties.Resources.bow;
            this.BowImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BowImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BowImage.Location = new System.Drawing.Point(473, 101);
            this.BowImage.Name = "BowImage";
            this.BowImage.Size = new System.Drawing.Size(60, 60);
            this.BowImage.TabIndex = 4;
            this.BowImage.TabStop = false;
            // 
            // MaceImage
            // 
            this.MaceImage.BackColor = System.Drawing.Color.Transparent;
            this.MaceImage.BackgroundImage = global::Quest.Properties.Resources.mace;
            this.MaceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaceImage.Location = new System.Drawing.Point(558, 101);
            this.MaceImage.Name = "MaceImage";
            this.MaceImage.Size = new System.Drawing.Size(60, 60);
            this.MaceImage.TabIndex = 5;
            this.MaceImage.TabStop = false;
            // 
            // SwordImage
            // 
            this.SwordImage.BackColor = System.Drawing.Color.Transparent;
            this.SwordImage.BackgroundImage = global::Quest.Properties.Resources.sword;
            this.SwordImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwordImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwordImage.Location = new System.Drawing.Point(638, 101);
            this.SwordImage.Name = "SwordImage";
            this.SwordImage.Size = new System.Drawing.Size(60, 60);
            this.SwordImage.TabIndex = 6;
            this.SwordImage.TabStop = false;
            // 
            // BluePotionImage
            // 
            this.BluePotionImage.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionImage.BackgroundImage = global::Quest.Properties.Resources.potion_blue;
            this.BluePotionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BluePotionImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BluePotionImage.Location = new System.Drawing.Point(714, 101);
            this.BluePotionImage.Name = "BluePotionImage";
            this.BluePotionImage.Size = new System.Drawing.Size(60, 60);
            this.BluePotionImage.TabIndex = 7;
            this.BluePotionImage.TabStop = false;
            // 
            // RedPotionImage
            // 
            this.RedPotionImage.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionImage.BackgroundImage = global::Quest.Properties.Resources.potion_red;
            this.RedPotionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedPotionImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedPotionImage.Location = new System.Drawing.Point(811, 109);
            this.RedPotionImage.Name = "RedPotionImage";
            this.RedPotionImage.Size = new System.Drawing.Size(60, 60);
            this.RedPotionImage.TabIndex = 8;
            this.RedPotionImage.TabStop = false;
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.BackgroundImage = global::Quest.Properties.Resources.sword;
            this.inventorySword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySword.Location = new System.Drawing.Point(127, 492);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(80, 80);
            this.inventorySword.TabIndex = 9;
            this.inventorySword.TabStop = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_DoubleClick);
            this.inventorySword.DoubleClick += new System.EventHandler(this.inventorySword_DoubleClick);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.BackgroundImage = global::Quest.Properties.Resources.mace;
            this.inventoryMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryMace.Location = new System.Drawing.Point(213, 492);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(80, 80);
            this.inventoryMace.TabIndex = 10;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventoryMace_DoubleClick);
            this.inventoryMace.DoubleClick += new System.EventHandler(this.inventoryMace_DoubleClick);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.BackgroundImage = global::Quest.Properties.Resources.bow;
            this.inventoryBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryBow.Location = new System.Drawing.Point(299, 492);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(80, 80);
            this.inventoryBow.TabIndex = 11;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventoryBow_DoubleClick);
            this.inventoryBow.DoubleClick += new System.EventHandler(this.inventoryBow_DoubleClick);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.BackgroundImage = global::Quest.Properties.Resources.potion_blue;
            this.inventoryBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryBluePotion.Location = new System.Drawing.Point(385, 492);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(80, 80);
            this.inventoryBluePotion.TabIndex = 12;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventoryBluePotion_DoubleClick);
            this.inventoryBluePotion.DoubleClick += new System.EventHandler(this.inventoryBluePotion_DoubleClick);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.BackgroundImage = global::Quest.Properties.Resources.potion_red;
            this.inventoryRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryRedPotion.Location = new System.Drawing.Point(471, 492);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(80, 80);
            this.inventoryRedPotion.TabIndex = 13;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventoryRedPotion_DoubleClick);
            this.inventoryRedPotion.DoubleClick += new System.EventHandler(this.inventoryRedPotion_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.91403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.08597F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(670, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 84);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(89, 25);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(129, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            this.batHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(89, 46);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(129, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            this.ghostHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(89, 67);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(129, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            this.ghoulHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(89, 4);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(129, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            this.playerHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Peru;
            this.groupBox1.Controls.Add(this.moveRightButton);
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.moveLeftButton);
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(557, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveRightButton
            // 
            this.moveRightButton.BackColor = System.Drawing.Color.White;
            this.moveRightButton.FlatAppearance.BorderSize = 0;
            this.moveRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRightButton.Location = new System.Drawing.Point(111, 40);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(51, 28);
            this.moveRightButton.TabIndex = 3;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = false;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            this.moveRightButton.Paint += new System.Windows.Forms.PaintEventHandler(this.moveRightButton_Paint);
            this.moveRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveRightButton_MouseDown);
            this.moveRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveRightButton_MouseUp);
            // 
            // moveDownButton
            // 
            this.moveDownButton.BackColor = System.Drawing.Color.White;
            this.moveDownButton.FlatAppearance.BorderSize = 0;
            this.moveDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownButton.Location = new System.Drawing.Point(58, 73);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(51, 28);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "↓";
            this.moveDownButton.UseVisualStyleBackColor = false;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            this.moveDownButton.Paint += new System.Windows.Forms.PaintEventHandler(this.moveDownButton_Paint);
            this.moveDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveDownButton_MouseDown);
            this.moveDownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveDownButton_MouseUp);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.BackColor = System.Drawing.Color.White;
            this.moveLeftButton.FlatAppearance.BorderSize = 0;
            this.moveLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeftButton.Location = new System.Drawing.Point(6, 40);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(51, 28);
            this.moveLeftButton.TabIndex = 1;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = false;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            this.moveLeftButton.Paint += new System.Windows.Forms.PaintEventHandler(this.moveLeftButton_Paint);
            this.moveLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveLeftButton_MouseDown);
            this.moveLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveLeftButton_MouseUp);
            // 
            // moveUpButton
            // 
            this.moveUpButton.BackColor = System.Drawing.Color.White;
            this.moveUpButton.FlatAppearance.BorderSize = 0;
            this.moveUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpButton.Location = new System.Drawing.Point(58, 9);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(51, 28);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.Text = "↑";
            this.moveUpButton.UseVisualStyleBackColor = false;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            this.moveUpButton.Paint += new System.Windows.Forms.PaintEventHandler(this.moveUpButton_Paint);
            this.moveUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveUpButton_MouseDown);
            this.moveUpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveUpButton_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Peru;
            this.groupBox2.Controls.Add(this.attackRightButton);
            this.groupBox2.Controls.Add(this.attackDownButton);
            this.groupBox2.Controls.Add(this.attackLeftButton);
            this.groupBox2.Controls.Add(this.attackUpButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(737, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 107);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackRightButton
            // 
            this.attackRightButton.BackColor = System.Drawing.Color.White;
            this.attackRightButton.FlatAppearance.BorderSize = 0;
            this.attackRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.attackRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackRightButton.Location = new System.Drawing.Point(122, 40);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(51, 28);
            this.attackRightButton.TabIndex = 3;
            this.attackRightButton.Text = "→";
            this.attackRightButton.UseVisualStyleBackColor = false;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            this.attackRightButton.Paint += new System.Windows.Forms.PaintEventHandler(this.attackRightButton_Paint);
            this.attackRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.attackRightButton_MouseDown);
            this.attackRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.attackRightButton_MouseUp);
            // 
            // attackDownButton
            // 
            this.attackDownButton.BackColor = System.Drawing.Color.White;
            this.attackDownButton.FlatAppearance.BorderSize = 0;
            this.attackDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.attackDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackDownButton.Location = new System.Drawing.Point(69, 71);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(51, 28);
            this.attackDownButton.TabIndex = 2;
            this.attackDownButton.Text = "↓";
            this.attackDownButton.UseVisualStyleBackColor = false;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            this.attackDownButton.Paint += new System.Windows.Forms.PaintEventHandler(this.attackDownButton_Paint);
            this.attackDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.attackDownButton_MouseDown);
            this.attackDownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.attackDownButton_MouseUp);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.BackColor = System.Drawing.Color.White;
            this.attackLeftButton.FlatAppearance.BorderSize = 0;
            this.attackLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.attackLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackLeftButton.Location = new System.Drawing.Point(12, 38);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(51, 28);
            this.attackLeftButton.TabIndex = 1;
            this.attackLeftButton.Text = "←";
            this.attackLeftButton.UseVisualStyleBackColor = false;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            this.attackLeftButton.Paint += new System.Windows.Forms.PaintEventHandler(this.attackLeftButton_Paint);
            this.attackLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.attackLeftButton_MouseDown);
            this.attackLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.attackLeftButton_MouseUp);
            // 
            // attackUpButton
            // 
            this.attackUpButton.BackColor = System.Drawing.Color.White;
            this.attackUpButton.FlatAppearance.BorderSize = 0;
            this.attackUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.attackUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackUpButton.Location = new System.Drawing.Point(69, 9);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(51, 28);
            this.attackUpButton.TabIndex = 0;
            this.attackUpButton.Text = "↑";
            this.attackUpButton.UseVisualStyleBackColor = false;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            this.attackUpButton.Paint += new System.Windows.Forms.PaintEventHandler(this.attackUpButton_Paint);
            this.attackUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.attackUpButton_MouseDown);
            this.attackUpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.attackUpButton_MouseUp);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(147, 392);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(510, 80);
            this.outputText.TabIndex = 17;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(839, 30);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 21);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(839, 57);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(96, 21);
            this.loadButton.TabIndex = 19;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Quest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 633);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.RedPotionImage);
            this.Controls.Add(this.BluePotionImage);
            this.Controls.Add(this.SwordImage);
            this.Controls.Add(this.MaceImage);
            this.Controls.Add(this.BowImage);
            this.Controls.Add(this.GhostImage);
            this.Controls.Add(this.GhoulImage);
            this.Controls.Add(this.BatImage);
            this.Controls.Add(this.PlayerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerImage;
        private System.Windows.Forms.PictureBox BatImage;
        private System.Windows.Forms.PictureBox GhoulImage;
        private System.Windows.Forms.PictureBox GhostImage;
        private System.Windows.Forms.PictureBox BowImage;
        private System.Windows.Forms.PictureBox MaceImage;
        private System.Windows.Forms.PictureBox SwordImage;
        private System.Windows.Forms.PictureBox BluePotionImage;
        private System.Windows.Forms.PictureBox RedPotionImage;
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button attackUpButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

