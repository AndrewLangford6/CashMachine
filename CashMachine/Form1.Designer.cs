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
            this.p1UpDown = new System.Windows.Forms.NumericUpDown();
            this.p2UpDown = new System.Windows.Forms.NumericUpDown();
            this.p3UpDown = new System.Windows.Forms.NumericUpDown();
            this.p4UpDown = new System.Windows.Forms.NumericUpDown();
            this.p4 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.mrg = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.tInput = new System.Windows.Forms.TextBox();
            this.amountTendered = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // p1UpDown
            // 
            this.p1UpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p1UpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1UpDown.Location = new System.Drawing.Point(137, 58);
            this.p1UpDown.Name = "p1UpDown";
            this.p1UpDown.Size = new System.Drawing.Size(62, 23);
            this.p1UpDown.TabIndex = 0;
            // 
            // p2UpDown
            // 
            this.p2UpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p2UpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2UpDown.Location = new System.Drawing.Point(137, 84);
            this.p2UpDown.Name = "p2UpDown";
            this.p2UpDown.Size = new System.Drawing.Size(62, 23);
            this.p2UpDown.TabIndex = 1;
            // 
            // p3UpDown
            // 
            this.p3UpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p3UpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3UpDown.Location = new System.Drawing.Point(137, 110);
            this.p3UpDown.Name = "p3UpDown";
            this.p3UpDown.Size = new System.Drawing.Size(62, 23);
            this.p3UpDown.TabIndex = 2;
            // 
            // p4UpDown
            // 
            this.p4UpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p4UpDown.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4UpDown.Location = new System.Drawing.Point(137, 137);
            this.p4UpDown.Name = "p4UpDown";
            this.p4UpDown.Size = new System.Drawing.Size(62, 23);
            this.p4UpDown.TabIndex = 3;
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.Location = new System.Drawing.Point(22, 139);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(32, 15);
            this.p4.TabIndex = 4;
            this.p4.Text = "Rock";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.Location = new System.Drawing.Point(22, 112);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(38, 15);
            this.p3.TabIndex = 5;
            this.p3.Text = "Shells";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(22, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(31, 15);
            this.p2.TabIndex = 6;
            this.p2.Text = "Leaf";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(22, 60);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(35, 15);
            this.p1.TabIndex = 7;
            this.p1.Text = "Stick";
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
            // tInput
            // 
            this.tInput.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInput.Location = new System.Drawing.Point(24, 238);
            this.tInput.Name = "tInput";
            this.tInput.Size = new System.Drawing.Size(121, 23);
            this.tInput.TabIndex = 10;
            this.tInput.Visible = false;
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
            this.BackgroundImage = global::CashMachine.Properties.Resources.murrrr;
            this.ClientSize = new System.Drawing.Size(611, 477);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.amountTendered);
            this.Controls.Add(this.tInput);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.mrg);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p4UpDown);
            this.Controls.Add(this.p3UpDown);
            this.Controls.Add(this.p2UpDown);
            this.Controls.Add(this.p1UpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown p1UpDown;
        private System.Windows.Forms.NumericUpDown p2UpDown;
        private System.Windows.Forms.NumericUpDown p3UpDown;
        private System.Windows.Forms.NumericUpDown p4UpDown;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label mrg;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.TextBox tInput;
        private System.Windows.Forms.Label amountTendered;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button newOrder;
    }
}

