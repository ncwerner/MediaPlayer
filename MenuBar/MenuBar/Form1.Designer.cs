namespace MenuBar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrubForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrubBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.importToolStripMenuItem,
            this.importSongToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.getInfoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeViewToolStripMenuItem,
            this.changeAppearanceToolStripMenuItem,
            this.sortByToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.scrubForwardToolStripMenuItem,
            this.scrubBackwardToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.repeatToolStripMenuItem,
            this.volumeUpToolStripMenuItem,
            this.volumeDownToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchUserToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newPlaylistToolStripMenuItem.Text = "New Playlist";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importToolStripMenuItem.Text = "Import Folder";
            // 
            // importSongToolStripMenuItem
            // 
            this.importSongToolStripMenuItem.Name = "importSongToolStripMenuItem";
            this.importSongToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importSongToolStripMenuItem.Text = "Import Song";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // getInfoToolStripMenuItem
            // 
            this.getInfoToolStripMenuItem.Name = "getInfoToolStripMenuItem";
            this.getInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getInfoToolStripMenuItem.Text = "Get Info";
            // 
            // changeViewToolStripMenuItem
            // 
            this.changeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumViewToolStripMenuItem,
            this.listViewToolStripMenuItem});
            this.changeViewToolStripMenuItem.Name = "changeViewToolStripMenuItem";
            this.changeViewToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changeViewToolStripMenuItem.Text = "Change View";
            // 
            // changeAppearanceToolStripMenuItem
            // 
            this.changeAppearanceToolStripMenuItem.Name = "changeAppearanceToolStripMenuItem";
            this.changeAppearanceToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changeAppearanceToolStripMenuItem.Text = "Change Appearance";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.songToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sortByToolStripMenuItem.Text = "Sort By...";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.songToolStripMenuItem.Text = "Song";
            // 
            // albumViewToolStripMenuItem
            // 
            this.albumViewToolStripMenuItem.Name = "albumViewToolStripMenuItem";
            this.albumViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albumViewToolStripMenuItem.Text = "Album View";
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // scrubForwardToolStripMenuItem
            // 
            this.scrubForwardToolStripMenuItem.Name = "scrubForwardToolStripMenuItem";
            this.scrubForwardToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.scrubForwardToolStripMenuItem.Text = "Scrub Forward";
            // 
            // scrubBackwardToolStripMenuItem
            // 
            this.scrubBackwardToolStripMenuItem.Name = "scrubBackwardToolStripMenuItem";
            this.scrubBackwardToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.scrubBackwardToolStripMenuItem.Text = "Scrub Backward";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // volumeUpToolStripMenuItem
            // 
            this.volumeUpToolStripMenuItem.Name = "volumeUpToolStripMenuItem";
            this.volumeUpToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.volumeUpToolStripMenuItem.Text = "Volume Up ";
            // 
            // volumeDownToolStripMenuItem
            // 
            this.volumeDownToolStripMenuItem.Name = "volumeDownToolStripMenuItem";
            this.volumeDownToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.volumeDownToolStripMenuItem.Text = "Volume Down";
            // 
            // switchUserToolStripMenuItem
            // 
            this.switchUserToolStripMenuItem.Name = "switchUserToolStripMenuItem";
            this.switchUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.switchUserToolStripMenuItem.Text = "Switch User";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 624);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAppearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrubForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrubBackwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}

