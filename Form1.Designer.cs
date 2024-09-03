namespace pizza_project
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
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.CrustBox = new System.Windows.Forms.GroupBox();
            this.Think = new System.Windows.Forms.RadioButton();
            this.Thin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ToppingBox = new System.Windows.Forms.GroupBox();
            this.Green_Paper = new System.Windows.Forms.CheckBox();
            this.tomatoes = new System.Windows.Forms.CheckBox();
            this.olives = new System.Windows.Forms.CheckBox();
            this.mushroom = new System.Windows.Forms.CheckBox();
            this.Onion = new System.Windows.Forms.CheckBox();
            this.Chess = new System.Windows.Forms.CheckBox();
            this.WhereToEatBox = new System.Windows.Forms.GroupBox();
            this.Take_Out = new System.Windows.Forms.RadioButton();
            this.Eat_in = new System.Windows.Forms.RadioButton();
            this.Order_Pizza = new System.Windows.Forms.Button();
            this.Reset_Form = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Where_TO_Eat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Crust = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Additions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PizzaSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllPrice = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.SizeBox.SuspendLayout();
            this.CrustBox.SuspendLayout();
            this.ToppingBox.SuspendLayout();
            this.WhereToEatBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.Color.Transparent;
            this.SizeBox.Controls.Add(this.Large);
            this.SizeBox.Controls.Add(this.Medium);
            this.SizeBox.Controls.Add(this.Small);
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeBox.Location = new System.Drawing.Point(12, 46);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(155, 128);
            this.SizeBox.TabIndex = 0;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Size";
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Large.ForeColor = System.Drawing.Color.Transparent;
            this.Large.Location = new System.Drawing.Point(21, 88);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(67, 30);
            this.Large.TabIndex = 2;
            this.Large.Tag = "20";
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.CheckedChanged += new System.EventHandler(this.Large_CheckedChanged);
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.ForeColor = System.Drawing.Color.Transparent;
            this.Medium.Location = new System.Drawing.Point(18, 52);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(85, 30);
            this.Medium.TabIndex = 1;
            this.Medium.Tag = "15";
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Small.ForeColor = System.Drawing.Color.Transparent;
            this.Small.Location = new System.Drawing.Point(21, 25);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(66, 30);
            this.Small.TabIndex = 0;
            this.Small.Tag = "10";
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.CheckedChanged += new System.EventHandler(this.Small_CheckedChanged);
            // 
            // CrustBox
            // 
            this.CrustBox.BackColor = System.Drawing.Color.Transparent;
            this.CrustBox.Controls.Add(this.Think);
            this.CrustBox.Controls.Add(this.Thin);
            this.CrustBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CrustBox.Location = new System.Drawing.Point(12, 277);
            this.CrustBox.Name = "CrustBox";
            this.CrustBox.Size = new System.Drawing.Size(155, 98);
            this.CrustBox.TabIndex = 1;
            this.CrustBox.TabStop = false;
            this.CrustBox.Text = "Crust type";
            // 
            // Think
            // 
            this.Think.AutoSize = true;
            this.Think.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Think.ForeColor = System.Drawing.Color.Transparent;
            this.Think.Location = new System.Drawing.Point(18, 52);
            this.Think.Name = "Think";
            this.Think.Size = new System.Drawing.Size(106, 30);
            this.Think.TabIndex = 1;
            this.Think.TabStop = true;
            this.Think.Tag = "5";
            this.Think.Text = "Thick Crust";
            this.Think.UseVisualStyleBackColor = true;
            this.Think.CheckedChanged += new System.EventHandler(this.Think_CheckedChanged);
            // 
            // Thin
            // 
            this.Thin.AutoSize = true;
            this.Thin.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thin.ForeColor = System.Drawing.Color.Transparent;
            this.Thin.Location = new System.Drawing.Point(21, 25);
            this.Thin.Name = "Thin";
            this.Thin.Size = new System.Drawing.Size(100, 30);
            this.Thin.TabIndex = 0;
            this.Thin.TabStop = true;
            this.Thin.Tag = "0";
            this.Thin.Text = "Thin Crust";
            this.Thin.UseVisualStyleBackColor = true;
            this.Thin.CheckedChanged += new System.EventHandler(this.Thin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(304, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make Your Pizza";
            // 
            // ToppingBox
            // 
            this.ToppingBox.BackColor = System.Drawing.Color.Transparent;
            this.ToppingBox.Controls.Add(this.Green_Paper);
            this.ToppingBox.Controls.Add(this.tomatoes);
            this.ToppingBox.Controls.Add(this.olives);
            this.ToppingBox.Controls.Add(this.mushroom);
            this.ToppingBox.Controls.Add(this.Onion);
            this.ToppingBox.Controls.Add(this.Chess);
            this.ToppingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToppingBox.Location = new System.Drawing.Point(285, 71);
            this.ToppingBox.Name = "ToppingBox";
            this.ToppingBox.Size = new System.Drawing.Size(246, 112);
            this.ToppingBox.TabIndex = 3;
            this.ToppingBox.TabStop = false;
            this.ToppingBox.Text = "Toppings";
            // 
            // Green_Paper
            // 
            this.Green_Paper.AutoSize = true;
            this.Green_Paper.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green_Paper.ForeColor = System.Drawing.Color.Transparent;
            this.Green_Paper.Location = new System.Drawing.Point(133, 79);
            this.Green_Paper.Name = "Green_Paper";
            this.Green_Paper.Size = new System.Drawing.Size(113, 30);
            this.Green_Paper.TabIndex = 5;
            this.Green_Paper.Tag = "4";
            this.Green_Paper.Text = "Green Paper";
            this.Green_Paper.UseVisualStyleBackColor = true;
            this.Green_Paper.CheckedChanged += new System.EventHandler(this.Green_Paper_CheckedChanged);
            // 
            // tomatoes
            // 
            this.tomatoes.AutoSize = true;
            this.tomatoes.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomatoes.Location = new System.Drawing.Point(6, 79);
            this.tomatoes.Name = "tomatoes";
            this.tomatoes.Size = new System.Drawing.Size(94, 30);
            this.tomatoes.TabIndex = 4;
            this.tomatoes.Tag = "4";
            this.tomatoes.Text = "Tomatoes";
            this.tomatoes.UseVisualStyleBackColor = true;
            this.tomatoes.CheckedChanged += new System.EventHandler(this.tomatoes_CheckedChanged);
            // 
            // olives
            // 
            this.olives.AutoSize = true;
            this.olives.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olives.Location = new System.Drawing.Point(133, 55);
            this.olives.Name = "olives";
            this.olives.Size = new System.Drawing.Size(72, 30);
            this.olives.TabIndex = 3;
            this.olives.Tag = "4";
            this.olives.Text = "Olives";
            this.olives.UseVisualStyleBackColor = true;
            this.olives.CheckedChanged += new System.EventHandler(this.olives_CheckedChanged);
            // 
            // mushroom
            // 
            this.mushroom.AutoSize = true;
            this.mushroom.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mushroom.Location = new System.Drawing.Point(6, 55);
            this.mushroom.Name = "mushroom";
            this.mushroom.Size = new System.Drawing.Size(104, 30);
            this.mushroom.TabIndex = 2;
            this.mushroom.Tag = "10";
            this.mushroom.Text = "Mushroom";
            this.mushroom.UseVisualStyleBackColor = true;
            this.mushroom.CheckedChanged += new System.EventHandler(this.mushroom_CheckedChanged);
            // 
            // Onion
            // 
            this.Onion.AutoSize = true;
            this.Onion.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onion.Location = new System.Drawing.Point(133, 25);
            this.Onion.Name = "Onion";
            this.Onion.Size = new System.Drawing.Size(73, 30);
            this.Onion.TabIndex = 1;
            this.Onion.Tag = "4";
            this.Onion.Text = "Onion";
            this.Onion.UseVisualStyleBackColor = true;
            this.Onion.CheckedChanged += new System.EventHandler(this.Onion_CheckedChanged);
            // 
            // Chess
            // 
            this.Chess.AutoSize = true;
            this.Chess.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chess.Location = new System.Drawing.Point(6, 25);
            this.Chess.Name = "Chess";
            this.Chess.Size = new System.Drawing.Size(109, 30);
            this.Chess.TabIndex = 0;
            this.Chess.Tag = "7";
            this.Chess.Text = "Extra Chees";
            this.Chess.UseVisualStyleBackColor = true;
            this.Chess.CheckedChanged += new System.EventHandler(this.Chess_CheckedChanged);
            // 
            // WhereToEatBox
            // 
            this.WhereToEatBox.BackColor = System.Drawing.Color.Transparent;
            this.WhereToEatBox.Controls.Add(this.Take_Out);
            this.WhereToEatBox.Controls.Add(this.Eat_in);
            this.WhereToEatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereToEatBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WhereToEatBox.Location = new System.Drawing.Point(291, 302);
            this.WhereToEatBox.Name = "WhereToEatBox";
            this.WhereToEatBox.Size = new System.Drawing.Size(233, 66);
            this.WhereToEatBox.TabIndex = 4;
            this.WhereToEatBox.TabStop = false;
            this.WhereToEatBox.Text = "Where To Eat";
            // 
            // Take_Out
            // 
            this.Take_Out.AutoSize = true;
            this.Take_Out.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Take_Out.ForeColor = System.Drawing.Color.Transparent;
            this.Take_Out.Location = new System.Drawing.Point(119, 25);
            this.Take_Out.Name = "Take_Out";
            this.Take_Out.Size = new System.Drawing.Size(91, 30);
            this.Take_Out.TabIndex = 1;
            this.Take_Out.TabStop = true;
            this.Take_Out.Tag = "0";
            this.Take_Out.Text = "Take Out";
            this.Take_Out.UseVisualStyleBackColor = true;
            this.Take_Out.CheckedChanged += new System.EventHandler(this.Take_Out_CheckedChanged);
            // 
            // Eat_in
            // 
            this.Eat_in.AutoSize = true;
            this.Eat_in.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eat_in.ForeColor = System.Drawing.Color.Transparent;
            this.Eat_in.Location = new System.Drawing.Point(6, 25);
            this.Eat_in.Name = "Eat_in";
            this.Eat_in.Size = new System.Drawing.Size(69, 30);
            this.Eat_in.TabIndex = 0;
            this.Eat_in.TabStop = true;
            this.Eat_in.Tag = "7";
            this.Eat_in.Text = "Eat In";
            this.Eat_in.UseVisualStyleBackColor = true;
            this.Eat_in.CheckedChanged += new System.EventHandler(this.Eat_in_CheckedChanged);
            // 
            // Order_Pizza
            // 
            this.Order_Pizza.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Pizza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Order_Pizza.Location = new System.Drawing.Point(285, 415);
            this.Order_Pizza.Name = "Order_Pizza";
            this.Order_Pizza.Size = new System.Drawing.Size(91, 30);
            this.Order_Pizza.TabIndex = 5;
            this.Order_Pizza.Text = "Order Pizza";
            this.Order_Pizza.UseVisualStyleBackColor = true;
            this.Order_Pizza.Click += new System.EventHandler(this.Order_Pizza_Click);
            // 
            // Reset_Form
            // 
            this.Reset_Form.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Form.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reset_Form.Location = new System.Drawing.Point(440, 415);
            this.Reset_Form.Name = "Reset_Form";
            this.Reset_Form.Size = new System.Drawing.Size(91, 30);
            this.Reset_Form.TabIndex = 6;
            this.Reset_Form.Text = "Reset Form";
            this.Reset_Form.UseVisualStyleBackColor = true;
            this.Reset_Form.Click += new System.EventHandler(this.Reset_Form_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Where_TO_Eat);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Crust);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Additions);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.PizzaSize);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.AllPrice);
            this.groupBox4.Controls.Add(this.Price);
            this.groupBox4.Controls.Add(this.Total_Price);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(580, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 300);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Summary";
            // 
            // Where_TO_Eat
            // 
            this.Where_TO_Eat.AutoSize = true;
            this.Where_TO_Eat.ForeColor = System.Drawing.Color.Lime;
            this.Where_TO_Eat.Location = new System.Drawing.Point(173, 188);
            this.Where_TO_Eat.Name = "Where_TO_Eat";
            this.Where_TO_Eat.Size = new System.Drawing.Size(20, 21);
            this.Where_TO_Eat.TabIndex = 11;
            this.Where_TO_Eat.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Where To Eat : ";
            // 
            // Crust
            // 
            this.Crust.AutoSize = true;
            this.Crust.ForeColor = System.Drawing.Color.Lime;
            this.Crust.Location = new System.Drawing.Point(147, 142);
            this.Crust.Name = "Crust";
            this.Crust.Size = new System.Drawing.Size(20, 21);
            this.Crust.TabIndex = 9;
            this.Crust.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Crust Type : ";
            // 
            // Additions
            // 
            this.Additions.AutoSize = true;
            this.Additions.ForeColor = System.Drawing.Color.Lime;
            this.Additions.Location = new System.Drawing.Point(11, 99);
            this.Additions.Name = "Additions";
            this.Additions.Size = new System.Drawing.Size(101, 21);
            this.Additions.TabIndex = 7;
            this.Additions.Text = "No Topping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings : ";
            // 
            // PizzaSize
            // 
            this.PizzaSize.AutoSize = true;
            this.PizzaSize.ForeColor = System.Drawing.Color.Lime;
            this.PizzaSize.Location = new System.Drawing.Point(78, 34);
            this.PizzaSize.Name = "PizzaSize";
            this.PizzaSize.Size = new System.Drawing.Size(0, 21);
            this.PizzaSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size : ";
              // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(110, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // AllPrice
            // 
            this.AllPrice.AutoSize = true;
            this.AllPrice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPrice.ForeColor = System.Drawing.Color.Lime;
            this.AllPrice.Location = new System.Drawing.Point(128, 256);
            this.AllPrice.Name = "AllPrice";
            this.AllPrice.Size = new System.Drawing.Size(23, 25);
            this.AllPrice.TabIndex = 2;
            this.AllPrice.Text = "0";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Price.Location = new System.Drawing.Point(11, 222);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(136, 20);
            this.Price.TabIndex = 1;
            this.Price.Text = "Total Price : ";
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.Location = new System.Drawing.Point(97, 235);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(0, 21);
            this.Total_Price.TabIndex = 0;
            this.Total_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pizza_project.Properties.Resources.pizza;
            this.ClientSize = new System.Drawing.Size(871, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Reset_Form);
            this.Controls.Add(this.Order_Pizza);
            this.Controls.Add(this.WhereToEatBox);
            this.Controls.Add(this.ToppingBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrustBox);
            this.Controls.Add(this.SizeBox);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.CrustBox.ResumeLayout(false);
            this.CrustBox.PerformLayout();
            this.ToppingBox.ResumeLayout(false);
            this.ToppingBox.PerformLayout();
            this.WhereToEatBox.ResumeLayout(false);
            this.WhereToEatBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.GroupBox CrustBox;
        private System.Windows.Forms.RadioButton Think;
        private System.Windows.Forms.RadioButton Thin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ToppingBox;
        private System.Windows.Forms.CheckBox Green_Paper;
        private System.Windows.Forms.CheckBox tomatoes;
        private System.Windows.Forms.CheckBox olives;
        private System.Windows.Forms.CheckBox mushroom;
        private System.Windows.Forms.CheckBox Onion;
        private System.Windows.Forms.CheckBox Chess;
        private System.Windows.Forms.GroupBox WhereToEatBox;
        private System.Windows.Forms.RadioButton Take_Out;
        private System.Windows.Forms.RadioButton Eat_in;
        private System.Windows.Forms.Button Order_Pizza;
        private System.Windows.Forms.Button Reset_Form;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AllPrice;
        private System.Windows.Forms.Label PizzaSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Additions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Crust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Where_TO_Eat;
        private System.Windows.Forms.Label label6;
    }
}

