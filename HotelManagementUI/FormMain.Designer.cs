﻿namespace HotelManagementUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_logOff = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_roomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_roomer_mng = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_room = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_room_mng = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_checkin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_checkin_mng = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchAllLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_new_room = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_new_roomer = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textbox_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_now_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_room = new System.Windows.Forms.PictureBox();
            this.pictureBox1_roomer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToolStripMenuItem_changePsw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_roomer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_file,
            this.ToolStripMenuItem_roomer,
            this.ToolStripMenuItem_room,
            this.ToolStripMenuItem_checkin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_file
            // 
            this.ToolStripMenuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_changePsw,
            this.ToolStripMenuItem_logOff,
            this.ToolStripMenuItem_quit});
            this.ToolStripMenuItem_file.Name = "ToolStripMenuItem_file";
            this.ToolStripMenuItem_file.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_file.Text = "系统";
            // 
            // ToolStripMenuItem_logOff
            // 
            this.ToolStripMenuItem_logOff.Name = "ToolStripMenuItem_logOff";
            this.ToolStripMenuItem_logOff.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_logOff.Text = "注销";
            this.ToolStripMenuItem_logOff.Click += new System.EventHandler(this.ToolStripMenuItem_logOff_Click);
            // 
            // ToolStripMenuItem_quit
            // 
            this.ToolStripMenuItem_quit.Name = "ToolStripMenuItem_quit";
            this.ToolStripMenuItem_quit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_quit.Text = "退出";
            this.ToolStripMenuItem_quit.Click += new System.EventHandler(this.ToolStripMenuItem_quit_Click);
            // 
            // ToolStripMenuItem_roomer
            // 
            this.ToolStripMenuItem_roomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_roomer_mng});
            this.ToolStripMenuItem_roomer.Name = "ToolStripMenuItem_roomer";
            this.ToolStripMenuItem_roomer.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_roomer.Text = "住客";
            // 
            // ToolStripMenuItem_roomer_mng
            // 
            this.ToolStripMenuItem_roomer_mng.Name = "ToolStripMenuItem_roomer_mng";
            this.ToolStripMenuItem_roomer_mng.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_roomer_mng.Text = "住客管理";
            this.ToolStripMenuItem_roomer_mng.Click += new System.EventHandler(this.ToolStripMenuItem_roomer_mng_Click);
            // 
            // ToolStripMenuItem_room
            // 
            this.ToolStripMenuItem_room.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_room_mng});
            this.ToolStripMenuItem_room.Name = "ToolStripMenuItem_room";
            this.ToolStripMenuItem_room.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_room.Text = "住房";
            // 
            // ToolStripMenuItem_room_mng
            // 
            this.ToolStripMenuItem_room_mng.Name = "ToolStripMenuItem_room_mng";
            this.ToolStripMenuItem_room_mng.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_room_mng.Text = "住房管理";
            this.ToolStripMenuItem_room_mng.Click += new System.EventHandler(this.ToolStripMenuItem_room_mng_Click);
            // 
            // ToolStripMenuItem_checkin
            // 
            this.ToolStripMenuItem_checkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_checkin_mng,
            this.ToolStripMenuItemCheckOut,
            this.SearchAllLogToolStripMenuItem});
            this.ToolStripMenuItem_checkin.Name = "ToolStripMenuItem_checkin";
            this.ToolStripMenuItem_checkin.Size = new System.Drawing.Size(80, 21);
            this.ToolStripMenuItem_checkin.Text = "住退房管理";
            // 
            // ToolStripMenuItem_checkin_mng
            // 
            this.ToolStripMenuItem_checkin_mng.Name = "ToolStripMenuItem_checkin_mng";
            this.ToolStripMenuItem_checkin_mng.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_checkin_mng.Text = "入住管理";
            this.ToolStripMenuItem_checkin_mng.Click += new System.EventHandler(this.ToolStripMenuItem_checkin_mng_Click);
            // 
            // ToolStripMenuItemCheckOut
            // 
            this.ToolStripMenuItemCheckOut.Name = "ToolStripMenuItemCheckOut";
            this.ToolStripMenuItemCheckOut.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemCheckOut.Text = "退房管理";
            this.ToolStripMenuItemCheckOut.Click += new System.EventHandler(this.ToolStripMenuItemCheckOut_Click);
            // 
            // SearchAllLogToolStripMenuItem
            // 
            this.SearchAllLogToolStripMenuItem.Name = "SearchAllLogToolStripMenuItem";
            this.SearchAllLogToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SearchAllLogToolStripMenuItem.Text = "查询所有的住房记录";
            this.SearchAllLogToolStripMenuItem.Click += new System.EventHandler(this.SearchAllLogToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_new_room
            // 
            this.ToolStripMenuItem_new_room.Name = "ToolStripMenuItem_new_room";
            this.ToolStripMenuItem_new_room.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripMenuItem_new_roomer
            // 
            this.ToolStripMenuItem_new_roomer.Name = "ToolStripMenuItem_new_roomer";
            this.ToolStripMenuItem_new_roomer.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.textbox_time,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_now_user});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(495, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "系统时间：";
            // 
            // textbox_time
            // 
            this.textbox_time.Name = "textbox_time";
            this.textbox_time.Size = new System.Drawing.Size(130, 17);
            this.textbox_time.Text = "2015/12/17  00:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "当前用户：";
            // 
            // toolStripStatusLabel_now_user
            // 
            this.toolStripStatusLabel_now_user.Name = "toolStripStatusLabel_now_user";
            this.toolStripStatusLabel_now_user.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel_now_user.Text = "luckyone";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(305, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_room
            // 
            this.pictureBox_room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_room.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_room.BackgroundImage")));
            this.pictureBox_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_room.Location = new System.Drawing.Point(305, 85);
            this.pictureBox_room.Name = "pictureBox_room";
            this.pictureBox_room.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_room.TabIndex = 1;
            this.pictureBox_room.TabStop = false;
            this.pictureBox_room.Click += new System.EventHandler(this.pictureBox_room_Click);
            // 
            // pictureBox1_roomer
            // 
            this.pictureBox1_roomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1_roomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1_roomer.BackgroundImage")));
            this.pictureBox1_roomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1_roomer.Location = new System.Drawing.Point(91, 85);
            this.pictureBox1_roomer.Name = "pictureBox1_roomer";
            this.pictureBox1_roomer.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1_roomer.TabIndex = 2;
            this.pictureBox1_roomer.TabStop = false;
            this.pictureBox1_roomer.Click += new System.EventHandler(this.pictureBox1_roomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "住客管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "住房管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "入住管理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "退房管理";
            // 
            // ToolStripMenuItem_changePsw
            // 
            this.ToolStripMenuItem_changePsw.Name = "ToolStripMenuItem_changePsw";
            this.ToolStripMenuItem_changePsw.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_changePsw.Text = "修改密码";
            this.ToolStripMenuItem_changePsw.Click += new System.EventHandler(this.ToolStripMenuItem_changePsw_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_room);
            this.Controls.Add(this.pictureBox1_roomer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_roomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_file;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_room;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_roomer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel textbox_time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_now_user;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_room_mng;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_checkin;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_checkin_mng;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_new_room;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_new_roomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_logOff;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_quit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_roomer_mng;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_room;
        private System.Windows.Forms.PictureBox pictureBox1_roomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCheckOut;
        private System.Windows.Forms.ToolStripMenuItem SearchAllLogToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_changePsw;
    }
}