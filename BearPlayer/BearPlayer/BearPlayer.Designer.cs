namespace BearPlayer
{
    partial class BearPlayer
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Artists");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Albums");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Songs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("New Playlist");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Playlists", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrubForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrubBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.shuffle_toggle = new System.Windows.Forms.PictureBox();
            this.repeat_button = new System.Windows.Forms.PictureBox();
            this.previous_button = new System.Windows.Forms.PictureBox();
            this.next_button = new System.Windows.Forms.PictureBox();
            this.playBar = new System.Windows.Forms.PictureBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.path = new System.Windows.Forms.TextBox();
            this.scrubBar = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle_toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrubBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuBar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1048, 25);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.importToolStripMenuItem,
            this.importSongToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newPlaylistToolStripMenuItem.Text = "New Playlist";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importToolStripMenuItem.Text = "Import Folder";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // importSongToolStripMenuItem
            // 
            this.importSongToolStripMenuItem.Name = "importSongToolStripMenuItem";
            this.importSongToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importSongToolStripMenuItem.Text = "Import Song";
            this.importSongToolStripMenuItem.Click += new System.EventHandler(this.importSongToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // getInfoToolStripMenuItem
            // 
            this.getInfoToolStripMenuItem.Name = "getInfoToolStripMenuItem";
            this.getInfoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.getInfoToolStripMenuItem.Text = "Get Info";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeViewToolStripMenuItem,
            this.changeAppearanceToolStripMenuItem,
            this.sortByToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // changeViewToolStripMenuItem
            // 
            this.changeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumViewToolStripMenuItem,
            this.listViewToolStripMenuItem});
            this.changeViewToolStripMenuItem.Name = "changeViewToolStripMenuItem";
            this.changeViewToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.changeViewToolStripMenuItem.Text = "Change View";
            // 
            // albumViewToolStripMenuItem
            // 
            this.albumViewToolStripMenuItem.Name = "albumViewToolStripMenuItem";
            this.albumViewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.albumViewToolStripMenuItem.Text = "Album View";
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            // 
            // changeAppearanceToolStripMenuItem
            // 
            this.changeAppearanceToolStripMenuItem.Name = "changeAppearanceToolStripMenuItem";
            this.changeAppearanceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.changeAppearanceToolStripMenuItem.Text = "Change Appearance";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.songToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sortByToolStripMenuItem.Text = "Sort By...";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.songToolStripMenuItem.Text = "Song";
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
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // scrubForwardToolStripMenuItem
            // 
            this.scrubForwardToolStripMenuItem.Name = "scrubForwardToolStripMenuItem";
            this.scrubForwardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.scrubForwardToolStripMenuItem.Text = "Scrub Forward";
            // 
            // scrubBackwardToolStripMenuItem
            // 
            this.scrubBackwardToolStripMenuItem.Name = "scrubBackwardToolStripMenuItem";
            this.scrubBackwardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.scrubBackwardToolStripMenuItem.Text = "Scrub Backward";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // volumeUpToolStripMenuItem
            // 
            this.volumeUpToolStripMenuItem.Name = "volumeUpToolStripMenuItem";
            this.volumeUpToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.volumeUpToolStripMenuItem.Text = "Volume Up ";
            this.volumeUpToolStripMenuItem.Click += new System.EventHandler(this.volumeUpToolStripMenuItem_Click);
            // 
            // volumeDownToolStripMenuItem
            // 
            this.volumeDownToolStripMenuItem.Name = "volumeDownToolStripMenuItem";
            this.volumeDownToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.volumeDownToolStripMenuItem.Text = "Volume Down";
            this.volumeDownToolStripMenuItem.Click += new System.EventHandler(this.volumeDownToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchUserToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // switchUserToolStripMenuItem
            // 
            this.switchUserToolStripMenuItem.Name = "switchUserToolStripMenuItem";
            this.switchUserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.switchUserToolStripMenuItem.Text = "Switch User";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.DodgerBlue;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Indent = 7;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Artists";
            treeNode1.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Artists";
            treeNode2.Name = "Albums";
            treeNode2.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Albums";
            treeNode3.Name = "Songs";
            treeNode3.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.Text = "Songs";
            treeNode4.Name = "New Playlist";
            treeNode4.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "New Playlist";
            treeNode5.Name = "Playlists";
            treeNode5.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "Playlists";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode5});
            this.treeView1.PathSeparator = "";
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(136, 478);
            this.treeView1.TabIndex = 1;
            // 
            // shuffle_toggle
            // 
            this.shuffle_toggle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.shuffle_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffle_toggle.Image = global::BearPlayer.Properties.Resources.shuffleButton;
            this.shuffle_toggle.Location = new System.Drawing.Point(360, 554);
            this.shuffle_toggle.Name = "shuffle_toggle";
            this.shuffle_toggle.Size = new System.Drawing.Size(61, 40);
            this.shuffle_toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shuffle_toggle.TabIndex = 6;
            this.shuffle_toggle.TabStop = false;
            // 
            // repeat_button
            // 
            this.repeat_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat_button.Image = global::BearPlayer.Properties.Resources.Repeat;
            this.repeat_button.Location = new System.Drawing.Point(680, 553);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.Size = new System.Drawing.Size(57, 35);
            this.repeat_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repeat_button.TabIndex = 5;
            this.repeat_button.TabStop = false;
            // 
            // previous_button
            // 
            this.previous_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.Image = global::BearPlayer.Properties.Resources.Previous_Button;
            this.previous_button.Location = new System.Drawing.Point(460, 547);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(56, 45);
            this.previous_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previous_button.TabIndex = 4;
            this.previous_button.TabStop = false;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.Image = global::BearPlayer.Properties.Resources.Next_Previous;
            this.next_button.Location = new System.Drawing.Point(580, 547);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(56, 45);
            this.next_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next_button.TabIndex = 3;
            this.next_button.TabStop = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // playBar
            // 
            this.playBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBar.Image = global::BearPlayer.Properties.Resources.playButton;
            this.playBar.Location = new System.Drawing.Point(520, 544);
            this.playBar.Name = "playBar";
            this.playBar.Size = new System.Drawing.Size(56, 49);
            this.playBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playBar.TabIndex = 2;
            this.playBar.TabStop = false;
            this.playBar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(875, 28);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(161, 23);
            this.searchBar.TabIndex = 7;
            this.searchBar.Text = "Search ";
            // 
            // volumeSlider
            // 
            this.volumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeSlider.AutoSize = false;
            this.volumeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeSlider.Location = new System.Drawing.Point(827, 560);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(195, 28);
            this.volumeSlider.SmallChange = 5;
            this.volumeSlider.TabIndex = 0;
            this.volumeSlider.TickFrequency = 0;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeSlider.Value = 100;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeSlider_Scroll_1);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(580, 65);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(281, 20);
            this.path.TabIndex = 6;
            // 
            // scrubBar
            // 
            this.scrubBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scrubBar.AutoSize = false;
            this.scrubBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrubBar.LargeChange = 0;
            this.scrubBar.Location = new System.Drawing.Point(171, 517);
            this.scrubBar.Maximum = 100;
            this.scrubBar.Name = "scrubBar";
            this.scrubBar.Size = new System.Drawing.Size(830, 24);
            this.scrubBar.SmallChange = 0;
            this.scrubBar.TabIndex = 8;
            this.scrubBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(851, 368);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BearPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 617);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.shuffle_toggle);
            this.Controls.Add(this.repeat_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.playBar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.scrubBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "BearPlayer";
            this.Text = "Bear Player";
            this.Load += new System.EventHandler(this.BearPlayer_Load);
            this.MouseHover += new System.EventHandler(this.BearPlayer_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle_toggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrubBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox playBar;
        private System.Windows.Forms.PictureBox next_button;
        private System.Windows.Forms.PictureBox previous_button;
        private System.Windows.Forms.PictureBox repeat_button;
        private System.Windows.Forms.PictureBox shuffle_toggle;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TrackBar scrubBar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

