namespace PetesPizza
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpPizzas = new System.Windows.Forms.GroupBox();
            this.lblCheese = new System.Windows.Forms.Label();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.lblPepperoni = new System.Windows.Forms.Label();
            this.picPepperoni = new System.Windows.Forms.PictureBox();
            this.lblVegi = new System.Windows.Forms.Label();
            this.picVegi = new System.Windows.Forms.PictureBox();
            this.lblHawaiian = new System.Windows.Forms.Label();
            this.picHawaiian = new System.Windows.Forms.PictureBox();
            this.lblHotSpicy = new System.Windows.Forms.Label();
            this.lblTuna = new System.Windows.Forms.Label();
            this.picHotSpicy = new System.Windows.Forms.PictureBox();
            this.picTuna = new System.Windows.Forms.PictureBox();
            this.lstDetails = new System.Windows.Forms.ListBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.grpPizzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVegi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHawaiian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHotSpicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuna)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlLeft.Controls.Add(this.btnInvoice);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.lblWelcome);
            this.pnlLeft.Location = new System.Drawing.Point(-1, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(158, 830);
            this.pnlLeft.TabIndex = 2;
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoice.Location = new System.Drawing.Point(0, 355);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(158, 43);
            this.btnInvoice.TabIndex = 4;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(0, 306);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 43);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(-1, 754);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(60, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Order";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(3, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(118, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome -";
            // 
            // grpPizzas
            // 
            this.grpPizzas.Controls.Add(this.lblCheese);
            this.grpPizzas.Controls.Add(this.picCheese);
            this.grpPizzas.Controls.Add(this.lblPepperoni);
            this.grpPizzas.Controls.Add(this.picPepperoni);
            this.grpPizzas.Controls.Add(this.lblVegi);
            this.grpPizzas.Controls.Add(this.picVegi);
            this.grpPizzas.Controls.Add(this.lblHawaiian);
            this.grpPizzas.Controls.Add(this.picHawaiian);
            this.grpPizzas.Controls.Add(this.lblHotSpicy);
            this.grpPizzas.Controls.Add(this.lblTuna);
            this.grpPizzas.Controls.Add(this.picHotSpicy);
            this.grpPizzas.Controls.Add(this.picTuna);
            this.grpPizzas.Location = new System.Drawing.Point(163, 12);
            this.grpPizzas.Name = "grpPizzas";
            this.grpPizzas.Size = new System.Drawing.Size(481, 804);
            this.grpPizzas.TabIndex = 3;
            this.grpPizzas.TabStop = false;
            this.grpPizzas.Text = "Pizzas";
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Location = new System.Drawing.Point(296, 750);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(109, 30);
            this.lblCheese.TabIndex = 11;
            this.lblCheese.Text = "Cheese";
            // 
            // picCheese
            // 
            this.picCheese.Image = ((System.Drawing.Image)(resources.GetObject("picCheese.Image")));
            this.picCheese.Location = new System.Drawing.Point(251, 537);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(206, 210);
            this.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheese.TabIndex = 10;
            this.picCheese.TabStop = false;
            this.picCheese.Click += new System.EventHandler(this.picCheese_Click);
            this.picCheese.MouseLeave += new System.EventHandler(this.picCheese_MouseLeave);
            this.picCheese.MouseHover += new System.EventHandler(this.picCheese_MouseHover);
            // 
            // lblPepperoni
            // 
            this.lblPepperoni.AutoSize = true;
            this.lblPepperoni.Location = new System.Drawing.Point(39, 750);
            this.lblPepperoni.Name = "lblPepperoni";
            this.lblPepperoni.Size = new System.Drawing.Size(157, 30);
            this.lblPepperoni.TabIndex = 9;
            this.lblPepperoni.Text = "Pepperoni";
            // 
            // picPepperoni
            // 
            this.picPepperoni.Image = ((System.Drawing.Image)(resources.GetObject("picPepperoni.Image")));
            this.picPepperoni.Location = new System.Drawing.Point(22, 537);
            this.picPepperoni.Name = "picPepperoni";
            this.picPepperoni.Size = new System.Drawing.Size(206, 210);
            this.picPepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPepperoni.TabIndex = 8;
            this.picPepperoni.TabStop = false;
            this.picPepperoni.Click += new System.EventHandler(this.picPepperoni_Click);
            this.picPepperoni.MouseLeave += new System.EventHandler(this.picPepperoni_MouseLeave);
            this.picPepperoni.MouseHover += new System.EventHandler(this.picPepperoni_MouseHover);
            // 
            // lblVegi
            // 
            this.lblVegi.AutoSize = true;
            this.lblVegi.Location = new System.Drawing.Point(309, 504);
            this.lblVegi.Name = "lblVegi";
            this.lblVegi.Size = new System.Drawing.Size(77, 30);
            this.lblVegi.TabIndex = 7;
            this.lblVegi.Text = "Vegi";
            // 
            // picVegi
            // 
            this.picVegi.Image = ((System.Drawing.Image)(resources.GetObject("picVegi.Image")));
            this.picVegi.Location = new System.Drawing.Point(251, 291);
            this.picVegi.Name = "picVegi";
            this.picVegi.Size = new System.Drawing.Size(206, 210);
            this.picVegi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVegi.TabIndex = 6;
            this.picVegi.TabStop = false;
            this.picVegi.Click += new System.EventHandler(this.picVegi_Click);
            this.picVegi.MouseLeave += new System.EventHandler(this.picVegi_MouseLeave);
            this.picVegi.MouseHover += new System.EventHandler(this.picVegi_MouseHover);
            // 
            // lblHawaiian
            // 
            this.lblHawaiian.AutoSize = true;
            this.lblHawaiian.Location = new System.Drawing.Point(55, 504);
            this.lblHawaiian.Name = "lblHawaiian";
            this.lblHawaiian.Size = new System.Drawing.Size(141, 30);
            this.lblHawaiian.TabIndex = 5;
            this.lblHawaiian.Text = "Hawaiian";
            // 
            // picHawaiian
            // 
            this.picHawaiian.Image = ((System.Drawing.Image)(resources.GetObject("picHawaiian.Image")));
            this.picHawaiian.Location = new System.Drawing.Point(22, 291);
            this.picHawaiian.Name = "picHawaiian";
            this.picHawaiian.Size = new System.Drawing.Size(206, 210);
            this.picHawaiian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHawaiian.TabIndex = 4;
            this.picHawaiian.TabStop = false;
            this.picHawaiian.Click += new System.EventHandler(this.picHawaiian_Click);
            this.picHawaiian.MouseLeave += new System.EventHandler(this.picHawaiian_MouseLeave);
            this.picHawaiian.MouseHover += new System.EventHandler(this.picHawaiian_MouseHover);
            // 
            // lblHotSpicy
            // 
            this.lblHotSpicy.AutoSize = true;
            this.lblHotSpicy.Location = new System.Drawing.Point(246, 258);
            this.lblHotSpicy.Name = "lblHotSpicy";
            this.lblHotSpicy.Size = new System.Drawing.Size(221, 30);
            this.lblHotSpicy.TabIndex = 3;
            this.lblHotSpicy.Text = "Hot and Spicy";
            // 
            // lblTuna
            // 
            this.lblTuna.AutoSize = true;
            this.lblTuna.Location = new System.Drawing.Point(76, 258);
            this.lblTuna.Name = "lblTuna";
            this.lblTuna.Size = new System.Drawing.Size(77, 30);
            this.lblTuna.TabIndex = 2;
            this.lblTuna.Text = "Tuna";
            // 
            // picHotSpicy
            // 
            this.picHotSpicy.Image = ((System.Drawing.Image)(resources.GetObject("picHotSpicy.Image")));
            this.picHotSpicy.Location = new System.Drawing.Point(251, 45);
            this.picHotSpicy.Name = "picHotSpicy";
            this.picHotSpicy.Size = new System.Drawing.Size(206, 210);
            this.picHotSpicy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHotSpicy.TabIndex = 1;
            this.picHotSpicy.TabStop = false;
            this.picHotSpicy.Click += new System.EventHandler(this.picHotSpicy_Click);
            this.picHotSpicy.MouseLeave += new System.EventHandler(this.picHotSpicy_MouseLeave);
            this.picHotSpicy.MouseHover += new System.EventHandler(this.picHotSpicy_MouseHover);
            // 
            // picTuna
            // 
            this.picTuna.Image = ((System.Drawing.Image)(resources.GetObject("picTuna.Image")));
            this.picTuna.Location = new System.Drawing.Point(22, 45);
            this.picTuna.Name = "picTuna";
            this.picTuna.Size = new System.Drawing.Size(206, 210);
            this.picTuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTuna.TabIndex = 0;
            this.picTuna.TabStop = false;
            this.picTuna.Click += new System.EventHandler(this.picTuna_Click);
            this.picTuna.MouseLeave += new System.EventHandler(this.picTuna_MouseLeave);
            this.picTuna.MouseHover += new System.EventHandler(this.picTuna_MouseHover);
            // 
            // lstDetails
            // 
            this.lstDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstDetails.FormattingEnabled = true;
            this.lstDetails.ItemHeight = 29;
            this.lstDetails.Location = new System.Drawing.Point(650, 73);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(555, 265);
            this.lstDetails.TabIndex = 4;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(650, 40);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(141, 30);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Details:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(650, 358);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(93, 30);
            this.lblCart.TabIndex = 7;
            this.lblCart.Text = "Cart:";
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 29;
            this.lstCart.Location = new System.Drawing.Point(650, 391);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(555, 178);
            this.lstCart.TabIndex = 6;
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(865, 581);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(147, 34);
            this.chkRegular.TabIndex = 8;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Location = new System.Drawing.Point(650, 766);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(555, 50);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(650, 710);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(555, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1217, 828);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.chkRegular);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.grpPizzas);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.grpPizzas.ResumeLayout(false);
            this.grpPizzas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVegi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHawaiian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHotSpicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpPizzas;
        private System.Windows.Forms.PictureBox picHotSpicy;
        private System.Windows.Forms.PictureBox picTuna;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.Label lblPepperoni;
        private System.Windows.Forms.PictureBox picPepperoni;
        private System.Windows.Forms.Label lblVegi;
        private System.Windows.Forms.PictureBox picVegi;
        private System.Windows.Forms.Label lblHawaiian;
        private System.Windows.Forms.PictureBox picHawaiian;
        private System.Windows.Forms.Label lblHotSpicy;
        private System.Windows.Forms.Label lblTuna;
        private System.Windows.Forms.ListBox lstDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
    }
}