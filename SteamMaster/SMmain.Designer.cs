﻿
namespace SteamMaster
{
    partial class SMmain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._RefreshGamesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this._AddGameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this._FilterGamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FilterDemosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FilterModsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FilterJunkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._GameLogoList = new System.Windows.Forms.ImageList(this.components);
            this._LogoWorker = new System.ComponentModel.BackgroundWorker();
            this.lblTests = new System.Windows.Forms.Label();
            this._GamesListView = new System.Windows.Forms.ListView();
            this._LoadGames = new System.ComponentModel.BackgroundWorker();
            this._TotalTime = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._RefreshGamesButton,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this._AddGameButton,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _RefreshGamesButton
            // 
            this._RefreshGamesButton.Image = global::SteamMaster.Properties.Resources.arrow_circle_double;
            this._RefreshGamesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._RefreshGamesButton.Name = "_RefreshGamesButton";
            this._RefreshGamesButton.Size = new System.Drawing.Size(105, 22);
            this._RefreshGamesButton.Text = "Refresh Games";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // _AddGameButton
            // 
            this._AddGameButton.Image = global::SteamMaster.Properties.Resources.magnifier;
            this._AddGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._AddGameButton.Name = "_AddGameButton";
            this._AddGameButton.Size = new System.Drawing.Size(83, 22);
            this._AddGameButton.Text = "Add Game";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._FilterGamesMenuItem,
            this._FilterDemosMenuItem,
            this._FilterModsMenuItem,
            this._FilterJunkMenuItem});
            this.toolStripDropDownButton1.Image = global::SteamMaster.Properties.Resources.television_test;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // _FilterGamesMenuItem
            // 
            this._FilterGamesMenuItem.Checked = true;
            this._FilterGamesMenuItem.CheckOnClick = true;
            this._FilterGamesMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._FilterGamesMenuItem.Name = "_FilterGamesMenuItem";
            this._FilterGamesMenuItem.Size = new System.Drawing.Size(142, 22);
            this._FilterGamesMenuItem.Text = "Show games";
            // 
            // _FilterDemosMenuItem
            // 
            this._FilterDemosMenuItem.CheckOnClick = true;
            this._FilterDemosMenuItem.Name = "_FilterDemosMenuItem";
            this._FilterDemosMenuItem.Size = new System.Drawing.Size(142, 22);
            this._FilterDemosMenuItem.Text = "Show demos";
            // 
            // _FilterModsMenuItem
            // 
            this._FilterModsMenuItem.CheckOnClick = true;
            this._FilterModsMenuItem.Name = "_FilterModsMenuItem";
            this._FilterModsMenuItem.Size = new System.Drawing.Size(142, 22);
            this._FilterModsMenuItem.Text = "Show mods";
            // 
            // _FilterJunkMenuItem
            // 
            this._FilterJunkMenuItem.CheckOnClick = true;
            this._FilterJunkMenuItem.Name = "_FilterJunkMenuItem";
            this._FilterJunkMenuItem.Size = new System.Drawing.Size(142, 22);
            this._FilterJunkMenuItem.Text = "Show junk";
            // 
            // _GameLogoList
            // 
            this._GameLogoList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this._GameLogoList.ImageSize = new System.Drawing.Size(184, 69);
            this._GameLogoList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _LogoWorker
            // 
            this._LogoWorker.WorkerSupportsCancellation = true;
            // 
            // lblTests
            // 
            this.lblTests.AllowDrop = true;
            this.lblTests.AutoSize = true;
            this.lblTests.BackColor = System.Drawing.Color.Black;
            this.lblTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTests.ForeColor = System.Drawing.Color.White;
            this.lblTests.Location = new System.Drawing.Point(0, 25);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(37, 15);
            this.lblTests.TabIndex = 1;
            this.lblTests.Text = "label1";
            // 
            // _GamesListView
            // 
            this._GamesListView.BackColor = System.Drawing.Color.Black;
            this._GamesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GamesListView.HideSelection = false;
            this._GamesListView.LargeImageList = this._GameLogoList;
            this._GamesListView.Location = new System.Drawing.Point(0, 25);
            this._GamesListView.MultiSelect = false;
            this._GamesListView.Name = "_GamesListView";
            this._GamesListView.Size = new System.Drawing.Size(742, 267);
            this._GamesListView.SmallImageList = this._GameLogoList;
            this._GamesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._GamesListView.TabIndex = 0;
            this._GamesListView.TileSize = new System.Drawing.Size(184, 69);
            this._GamesListView.UseCompatibleStateImageBehavior = false;
            this._GamesListView.VirtualMode = true;
            // 
            // _LoadGames
            // 
            this._LoadGames.WorkerReportsProgress = true;
            this._LoadGames.WorkerSupportsCancellation = true;
            this._LoadGames.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this._LoadGames.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._LoadGames_ProgressChanged);
            this._LoadGames.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._LoadGames_RunWorkerCompleted);
            // 
            // _TotalTime
            // 
            this._TotalTime.AutoSize = true;
            this._TotalTime.Location = new System.Drawing.Point(2, 115);
            this._TotalTime.Name = "_TotalTime";
            this._TotalTime.Size = new System.Drawing.Size(35, 13);
            this._TotalTime.TabIndex = 3;
            this._TotalTime.Text = "label2";
            // 
            // SMmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 292);
            this.Controls.Add(this._TotalTime);
            this.Controls.Add(this.lblTests);
            this.Controls.Add(this._GamesListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SMmain";
            this.Text = "Steam Master";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _RefreshGamesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton _AddGameButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem _FilterGamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterDemosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterModsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterJunkMenuItem;
        private System.Windows.Forms.ImageList _GameLogoList;
        private System.ComponentModel.BackgroundWorker _LogoWorker;
        private System.Windows.Forms.ListView _GamesListView;
        private System.ComponentModel.BackgroundWorker _LoadGames;
        internal System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label _TotalTime;
    }
}

