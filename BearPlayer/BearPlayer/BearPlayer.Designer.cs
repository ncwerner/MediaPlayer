namespace BearPlayer
{
    partial class Bear_Player
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Queue");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("New Playlist");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Playlists", new System.Windows.Forms.TreeNode[] {
            treeNode5});
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
            this.scrubBar = new System.Windows.Forms.TrackBar();
            this.Albums_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Songs_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Song_List = new System.Windows.Forms.ListView();
            this.TitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LengthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Queue_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Queue_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playlists_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Artists_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Current_position_label = new System.Windows.Forms.Label();
            this.Song_length_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle_toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrubBar)).BeginInit();
            this.Songs_View.SuspendLayout();
            this.Queue_View.SuspendLayout();
            this.Artists_View.SuspendLayout();
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
            this.albumViewToolStripMenuItem.Click += new System.EventHandler(this.albumViewToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
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
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            treeNode4.Name = "Queue";
            treeNode4.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Queue";
            treeNode5.Name = "New Playlist";
            treeNode5.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "New Playlist";
            treeNode6.Name = "Playlists";
            treeNode6.NodeFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "Playlists";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode6});
            this.treeView1.PathSeparator = "";
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(136, 478);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.scrubBar.Scroll += new System.EventHandler(this.scrubBar_Scroll);
            // 
            // Albums_View
            // 
            this.Albums_View.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Albums_View.Location = new System.Drawing.Point(136, 75);
            this.Albums_View.Name = "Albums_View";
            this.Albums_View.Size = new System.Drawing.Size(900, 428);
            this.Albums_View.TabIndex = 10;
            this.Albums_View.Visible = false;
            // 
            // Songs_View
            // 
            this.Songs_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Songs_View.Controls.Add(this.Song_List);
            this.Songs_View.Location = new System.Drawing.Point(180, 75);
            this.Songs_View.Name = "Songs_View";
            this.Songs_View.Size = new System.Drawing.Size(804, 428);
            this.Songs_View.TabIndex = 11;
            this.Songs_View.Visible = false;
            // 
            // Song_List
            // 
            this.Song_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleColumn,
            this.AlbumColumn,
            this.ArtistColumn,
            this.LengthColumn});
            this.Songs_View.SetFlowBreak(this.Song_List, true);
            this.Song_List.FullRowSelect = true;
            this.Song_List.Location = new System.Drawing.Point(3, 3);
            this.Song_List.Name = "Song_List";
            this.Song_List.Size = new System.Drawing.Size(801, 425);
            this.Song_List.TabIndex = 0;
            this.Song_List.UseCompatibleStateImageBehavior = false;
            this.Song_List.View = System.Windows.Forms.View.Details;
            this.Song_List.DoubleClick += new System.EventHandler(this.Song_List_SelectedIndexChanged);
            // 
            // TitleColumn
            // 
            this.TitleColumn.Text = "Title";
            this.TitleColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleColumn.Width = 265;
            // 
            // AlbumColumn
            // 
            this.AlbumColumn.Text = "Album";
            this.AlbumColumn.Width = 195;
            // 
            // ArtistColumn
            // 
            this.ArtistColumn.Text = "Artist";
            this.ArtistColumn.Width = 194;
            // 
            // LengthColumn
            // 
            this.LengthColumn.Text = "Length";
            this.LengthColumn.Width = 143;
            // 
            // Queue_View
            // 
            this.Queue_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Queue_View.Controls.Add(this.Queue_List);
            this.Queue_View.Location = new System.Drawing.Point(180, 75);
            this.Queue_View.Margin = new System.Windows.Forms.Padding(0);
            this.Queue_View.Name = "Queue_View";
            this.Queue_View.Size = new System.Drawing.Size(804, 428);
            this.Queue_View.TabIndex = 14;
            this.Queue_View.Visible = false;
            this.Queue_View.DoubleClick += new System.EventHandler(this.Song_List_SelectedIndexChanged);
            // 
            // Queue_List
            // 
            this.Queue_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Queue_View.SetFlowBreak(this.Queue_List, true);
            this.Queue_List.FullRowSelect = true;
            this.Queue_List.Location = new System.Drawing.Point(3, 3);
            this.Queue_List.Name = "Queue_List";
            this.Queue_List.Size = new System.Drawing.Size(801, 425);
            this.Queue_List.TabIndex = 1;
            this.Queue_List.UseCompatibleStateImageBehavior = false;
            this.Queue_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 265;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Album";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Artist";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Length";
            this.columnHeader4.Width = 143;
            // 
            // Playlists_View
            // 
            this.Playlists_View.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Playlists_View.Location = new System.Drawing.Point(136, 75);
            this.Playlists_View.Name = "Playlists_View";
            this.Playlists_View.Size = new System.Drawing.Size(900, 428);
            this.Playlists_View.TabIndex = 0;
            this.Playlists_View.Visible = false;
            // 
            // Artists_View
            // 
            this.Artists_View.BackColor = System.Drawing.SystemColors.Info;
            this.Artists_View.Controls.Add(this.listView1);
            this.Artists_View.Controls.Add(this.listView2);
            this.Artists_View.Location = new System.Drawing.Point(136, 75);
            this.Artists_View.Name = "Artists_View";
            this.Artists_View.Size = new System.Drawing.Size(900, 428);
            this.Artists_View.TabIndex = 0;
            // 
            // Current_position_label
            // 
            this.Current_position_label.AutoSize = true;
            this.Current_position_label.Location = new System.Drawing.Point(143, 522);
            this.Current_position_label.Name = "Current_position_label";
            this.Current_position_label.Size = new System.Drawing.Size(22, 13);
            this.Current_position_label.TabIndex = 12;
            this.Current_position_label.Text = "--:--";
            // 
            // Song_length_label
            // 
            this.Song_length_label.AutoSize = true;
            this.Song_length_label.Location = new System.Drawing.Point(1005, 522);
            this.Song_length_label.Name = "Song_length_label";
            this.Song_length_label.Size = new System.Drawing.Size(22, 13);
            this.Song_length_label.TabIndex = 13;
            this.Song_length_label.Text = "--:--";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 425);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(439, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(445, 425);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Bear_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 617);
            this.Controls.Add(this.Albums_View);
            this.Controls.Add(this.Queue_View);
            this.Controls.Add(this.Song_length_label);
            this.Controls.Add(this.Current_position_label);
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
            this.Controls.Add(this.Songs_View);
            this.Controls.Add(this.Playlists_View);
            this.Controls.Add(this.Artists_View);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Bear_Player";
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
            this.Songs_View.ResumeLayout(false);
            this.Queue_View.ResumeLayout(false);
            this.Artists_View.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar scrubBar;
        private System.Windows.Forms.FlowLayoutPanel Albums_View;
        private System.Windows.Forms.FlowLayoutPanel Songs_View;
        private System.Windows.Forms.FlowLayoutPanel Playlists_View;
        private System.Windows.Forms.ListView Song_List;
        private System.Windows.Forms.ColumnHeader TitleColumn;
        private System.Windows.Forms.ColumnHeader AlbumColumn;
        private System.Windows.Forms.ColumnHeader ArtistColumn;
        private System.Windows.Forms.ColumnHeader LengthColumn;
        private System.Windows.Forms.FlowLayoutPanel Artists_View;
        private System.Windows.Forms.Label Current_position_label;
        private System.Windows.Forms.Label Song_length_label;
        private System.Windows.Forms.FlowLayoutPanel Queue_View;
        private System.Windows.Forms.ListView Queue_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}

