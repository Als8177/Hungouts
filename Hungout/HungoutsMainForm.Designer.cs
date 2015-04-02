﻿namespace Hungout
{
    partial class HungoutsMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.conversationPicker = new System.Windows.Forms.ListBox();
            this.appPanel = new System.Windows.Forms.Panel();
            this.messageListBox = new Hungout.ChatMessageListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.appPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 77);
            this.panel1.TabIndex = 5;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = global::Hungout.Properties.Resources.ic_action_menu;
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(90, 75);
            this.menuButton.TabIndex = 6;
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Image = global::Hungout.Properties.Resources.ic_action_content_add;
            this.loadButton.Location = new System.Drawing.Point(840, 0);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(92, 75);
            this.loadButton.TabIndex = 1;
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-2, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(935, 77);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Hungouts";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer.Location = new System.Drawing.Point(0, 78);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.conversationPicker);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(8);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.messageListBox);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer.Size = new System.Drawing.Size(937, 835);
            this.splitContainer.SplitterDistance = 312;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 7;
            // 
            // conversationPicker
            // 
            this.conversationPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conversationPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversationPicker.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversationPicker.FormattingEnabled = true;
            this.conversationPicker.ItemHeight = 36;
            this.conversationPicker.Location = new System.Drawing.Point(8, 8);
            this.conversationPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conversationPicker.Name = "conversationPicker";
            this.conversationPicker.Size = new System.Drawing.Size(296, 819);
            this.conversationPicker.TabIndex = 0;
            this.conversationPicker.SelectedIndexChanged += new System.EventHandler(this.conversationPicker_SelectedIndexChanged);
            // 
            // appPanel
            // 
            this.appPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appPanel.Controls.Add(this.panel1);
            this.appPanel.Controls.Add(this.splitContainer);
            this.appPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appPanel.Location = new System.Drawing.Point(0, 0);
            this.appPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(936, 912);
            this.appPanel.TabIndex = 8;
            // 
            // messageListBox
            // 
            this.messageListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 20;
            this.messageListBox.Location = new System.Drawing.Point(8, 8);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(606, 819);
            this.messageListBox.TabIndex = 0;
            // 
            // HungoutsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(936, 912);
            this.Controls.Add(this.appPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HungoutsMainForm";
            this.Text = "Hungouts";
            this.panel1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.appPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox conversationPicker;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel appPanel;
        private ChatMessageListBox messageListBox;
    }
}

