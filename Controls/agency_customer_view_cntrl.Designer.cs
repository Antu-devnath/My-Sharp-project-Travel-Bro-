﻿namespace TravelBro.Controls
{
    partial class agency_customer_view_cntrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pack_picbox = new System.Windows.Forms.PictureBox();
            this.lab_dest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_hotel = new System.Windows.Forms.Label();
            this.lab_person = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_duration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pack_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pack_picbox
            // 
            this.pack_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pack_picbox.Location = new System.Drawing.Point(1, -2);
            this.pack_picbox.Name = "pack_picbox";
            this.pack_picbox.Size = new System.Drawing.Size(225, 124);
            this.pack_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pack_picbox.TabIndex = 0;
            this.pack_picbox.TabStop = false;
            // 
            // lab_dest
            // 
            this.lab_dest.AutoSize = true;
            this.lab_dest.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dest.Location = new System.Drawing.Point(3, 125);
            this.lab_dest.Name = "lab_dest";
            this.lab_dest.Size = new System.Drawing.Size(122, 26);
            this.lab_dest.TabIndex = 2;
            this.lab_dest.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Persons :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab_hotel
            // 
            this.lab_hotel.AutoSize = true;
            this.lab_hotel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_hotel.Location = new System.Drawing.Point(64, 165);
            this.lab_hotel.Name = "lab_hotel";
            this.lab_hotel.Size = new System.Drawing.Size(21, 14);
            this.lab_hotel.TabIndex = 2;
            this.lab_hotel.Text = "##";
            this.lab_hotel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_person
            // 
            this.lab_person.AutoSize = true;
            this.lab_person.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_person.Location = new System.Drawing.Point(64, 189);
            this.lab_person.Name = "lab_person";
            this.lab_person.Size = new System.Drawing.Size(21, 14);
            this.lab_person.TabIndex = 2;
            this.lab_person.Text = "##";
            this.lab_person.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duration :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lab_duration
            // 
            this.lab_duration.AutoSize = true;
            this.lab_duration.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_duration.Location = new System.Drawing.Point(64, 214);
            this.lab_duration.Name = "lab_duration";
            this.lab_duration.Size = new System.Drawing.Size(21, 14);
            this.lab_duration.TabIndex = 2;
            this.lab_duration.Text = "##";
            this.lab_duration.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_price
            // 
            this.lab_price.AutoSize = true;
            this.lab_price.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_price.Location = new System.Drawing.Point(64, 239);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(21, 14);
            this.lab_price.TabIndex = 2;
            this.lab_price.Text = "##";
            this.lab_price.Click += new System.EventHandler(this.label1_Click);
            // 
            // agency_customer_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lab_dest);
            this.Controls.Add(this.lab_price);
            this.Controls.Add(this.pack_picbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_hotel);
            this.Controls.Add(this.lab_person);
            this.Name = "agency_customer_view";
            this.Size = new System.Drawing.Size(226, 301);
            ((System.ComponentModel.ISupportInitialize)(this.pack_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pack_picbox;
        private System.Windows.Forms.Label lab_dest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_hotel;
        private System.Windows.Forms.Label lab_person;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_price;
    }
}
