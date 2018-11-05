namespace CashMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stickUpDown = new System.Windows.Forms.NumericUpDown();
            this.leafUpDown = new System.Windows.Forms.NumericUpDown();
            this.shellUpDown = new System.Windows.Forms.NumericUpDown();
            this.rockUpDown = new System.Windows.Forms.NumericUpDown();
            this.rockTag = new System.Windows.Forms.Label();
            this.shellTag = new System.Windows.Forms.Label();
            this.leafTag = new System.Windows.Forms.Label();
            this.stickTag = new System.Windows.Forms.Label();
            this.mrg = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.amountTendered = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stickUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // stickUpDown
            // 
            this.stickUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stickUpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickUpDown.Location = new System.Drawing.Point(137, 58);
            this.stickUpDown.Name = "stickUpDown";
            this.stickUpDown.Size = new System.Drawing.Size(62, 23);
            this.stickUpDown.TabIndex = 0;
            // 
            // leafUpDown
            // 
            this.leafUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leafUpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leafUpDown.Location = new System.Drawing.Point(137, 84);
            this.leafUpDown.Name = "leafUpDown";
            this.leafUpDown.Size = new System.Drawing.Size(62, 23);
            this.leafUpDown.TabIndex = 1;
            // 
            // shellUpDown
            // 
            this.shellUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shellUpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellUpDown.Location = new System.Drawing.Point(137, 110);
            this.shellUpDown.Name = "shellUpDown";
            this.shellUpDown.Size = new System.Drawing.Size(62, 23);
            this.shellUpDown.TabIndex = 2;
            // 
            // rockUpDown
            // 
            this.rockUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rockUpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockUpDown.Location = new System.Drawing.Point(137, 137);
            this.rockUpDown.Name = "rockUpDown";
            this.rockUpDown.Size = new System.Drawing.Size(62, 23);
            this.rockUpDown.TabIndex = 3;
            // 
            // rockTag
            // 
            this.rockTag.AutoSize = true;
            this.rockTag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockTag.Location = new System.Drawing.Point(22, 139);
            this.rockTag.Name = "rockTag";
            this.rockTag.Size = new System.Drawing.Size(32, 15);
            this.rockTag.TabIndex = 4;
            this.rockTag.Text = "Rock";
            // 
            // shellTag
            // 
            this.shellTag.AutoSize = true;
            this.shellTag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellTag.Location = new System.Drawing.Point(22, 112);
            this.shellTag.Name = "shellTag";
            this.shellTag.Size = new System.Drawing.Size(38, 15);
            this.shellTag.TabIndex = 5;
            this.shellTag.Text = "Shells";
            // 
            // leafTag
            // 
            this.leafTag.AutoSize = true;
            this.leafTag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leafTag.Location = new System.Drawing.Point(22, 86);
            this.leafTag.Name = "leafTag";
            this.leafTag.Size = new System.Drawing.Size(31, 15);
            this.leafTag.TabIndex = 6;
            this.leafTag.Text = "Leaf";
            // 
            // stickTag
            // 
            this.stickTag.AutoSize = true;
            this.stickTag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickTag.Location = new System.Drawing.Point(22, 60);
            this.stickTag.Name = "stickTag";
            this.stickTag.Size = new System.Drawing.Size(35, 15);
            this.stickTag.TabIndex = 7;
            this.stickTag.Text = "Stick";
            // 
            // mrg
            // 
            this.mrg.BackColor = System.Drawing.Color.Transparent;
            this.mrg.Image = ((System.Drawing.Image)(resources.GetObject("mrg.Image")));
            this.mrg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mrg.Location = new System.Drawing.Point(-463, 242);
            this.mrg.Name = "mrg";
            this.mrg.Size = new System.Drawing.Size(756, 484);
            this.mrg.TabIndex = 8;
            // 
            // buy
            // 
            this.buy.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.Location = new System.Drawing.Point(24, 174);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 9;
            this.buy.Text = "BUY";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buyButton);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(24, 238);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(121, 23);
            this.tenderedInput.TabIndex = 10;
            this.tenderedInput.Visible = false;
            // 
            // amountTendered
            // 
            this.amountTendered.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTendered.Location = new System.Drawing.Point(24, 210);
            this.amountTendered.Name = "amountTendered";
            this.amountTendered.Size = new System.Drawing.Size(121, 25);
            this.amountTendered.TabIndex = 11;
            this.amountTendered.Text = "Amount Tendered";
            this.amountTendered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amountTendered.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(151, 235);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 12;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // newOrder
            // 
            this.newOrder.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.Location = new System.Drawing.Point(24, 267);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(175, 23);
            this.newOrder.TabIndex = 13;
            this.newOrder.Text = "NEW ORDER";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 477);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.amountTendered);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.mrg);
            this.Controls.Add(this.stickTag);
            this.Controls.Add(this.leafTag);
            this.Controls.Add(this.shellTag);
            this.Controls.Add(this.rockTag);
            this.Controls.Add(this.rockUpDown);
            this.Controls.Add(this.shellUpDown);
            this.Controls.Add(this.leafUpDown);
            this.Controls.Add(this.stickUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stickUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown stickUpDown;
        private System.Windows.Forms.NumericUpDown leafUpDown;
        private System.Windows.Forms.NumericUpDown shellUpDown;
        private System.Windows.Forms.NumericUpDown rockUpDown;
        private System.Windows.Forms.Label rockTag;
        private System.Windows.Forms.Label shellTag;
        private System.Windows.Forms.Label leafTag;
        private System.Windows.Forms.Label stickTag;
        private System.Windows.Forms.Label mrg;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label amountTendered;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button newOrder;
    }
}

