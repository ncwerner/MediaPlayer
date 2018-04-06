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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Artists");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Albums");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Songs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Queue");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("New Playlist");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Playlists", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bear_Player));
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
            this.SideBar = new System.Windows.Forms.TreeView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.scrubBar = new System.Windows.Forms.TrackBar();
            this.Albums_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Album_List = new System.Windows.Forms.ListView();
            this.Artwork_List = new System.Windows.Forms.ImageList(this.components);
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
            this.Playlist_List = new System.Windows.Forms.ListView();
            this.PlaylistList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Current_position_label = new System.Windows.Forms.Label();
            this.Song_length_label = new System.Windows.Forms.Label();
            this.Artist_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Artist_List = new System.Windows.Forms.ListView();
            this.ArtistList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Song_List = new System.Windows.Forms.ListView();
            this.ArtistList_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistList_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistList_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistList_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.curAlbumLabel = new System.Windows.Forms.Label();
            this.Artist_Song_View = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bear_logo = new System.Windows.Forms.PictureBox();
            this.shuffle_toggle = new System.Windows.Forms.PictureBox();
            this.repeat_button = new System.Windows.Forms.PictureBox();
            this.previous_button = new System.Windows.Forms.PictureBox();
            this.next_button = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.Album_Song_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Album_Song_List = new System.Windows.Forms.ListView();
            this.AlbumSong_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumSong_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumSong_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumSong_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search_View = new System.Windows.Forms.FlowLayoutPanel();
            this.Search_List = new System.Windows.Forms.ListView();
            this.SearchTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchArtistColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchAlbumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchDurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NewPlaylist_Panel = new System.Windows.Forms.Panel();
            this.NewPlaylist_Label = new System.Windows.Forms.Label();
            this.NewPlaylist_CancelButton = new System.Windows.Forms.Button();
            this.NewPlaylist_EnterButton = new System.Windows.Forms.Button();
            this.NewPlaylist_TextBox = new System.Windows.Forms.TextBox();
            this.View_Label = new System.Windows.Forms.Label();
            this.Playlist_Song_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Playlist_Song_List = new System.Windows.Forms.ListView();
            this.Playlist_Song_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playlist_Song_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playlist_Song_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playlist_Song_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrubBar)).BeginInit();
            this.Albums_View.SuspendLayout();
            this.Songs_View.SuspendLayout();
            this.Queue_View.SuspendLayout();
            this.Playlists_View.SuspendLayout();
            this.Artist_View.SuspendLayout();
            this.Artist_Song_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bear_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle_toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.Album_Song_View.SuspendLayout();
            this.Search_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.NewPlaylist_Panel.SuspendLayout();
            this.Playlist_Song_Panel.SuspendLayout();
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
            this.albumViewToolStripMenuItem.Click += new System.EventHandler(this.AlbumViewToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.ListViewToolStripMenuItem_Click);
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
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.SideBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SideBar.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.SideBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideBar.HotTracking = true;
            this.SideBar.Indent = 7;
            this.SideBar.ItemHeight = 30;
            this.SideBar.Location = new System.Drawing.Point(0, 25);
            this.SideBar.Name = "SideBar";
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
            this.SideBar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode6});
            this.SideBar.PathSeparator = "";
            this.SideBar.ShowLines = false;
            this.SideBar.ShowPlusMinus = false;
            this.SideBar.Size = new System.Drawing.Size(136, 478);
            this.SideBar.TabIndex = 1;
            this.SideBar.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.SideBar_DrawNode);
            this.SideBar.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SideBar_MouseClick);
            // 
            // searchBar
            // 
            this.searchBar.AcceptsReturn = true;
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(875, 28);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(161, 23);
            this.searchBar.TabIndex = 7;
            this.searchBar.Text = "Search ";
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
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
            this.volumeSlider.Value = 25;
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
            this.scrubBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scrubBar_MouseDown);
            this.scrubBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scrubBar_MouseUp);
            // 
            // Albums_View
            // 
            this.Albums_View.AutoScroll = true;
            this.Albums_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Albums_View.Controls.Add(this.Album_List);
            this.Albums_View.Location = new System.Drawing.Point(180, 75);
            this.Albums_View.Name = "Albums_View";
            this.Albums_View.Size = new System.Drawing.Size(804, 416);
            this.Albums_View.TabIndex = 10;
            this.Albums_View.Visible = false;
            // 
            // Album_List
            // 
            this.Album_List.LargeImageList = this.Artwork_List;
            this.Album_List.Location = new System.Drawing.Point(3, 3);
            this.Album_List.Name = "Album_List";
            this.Album_List.Size = new System.Drawing.Size(798, 410);
            this.Album_List.SmallImageList = this.Artwork_List;
            this.Album_List.TabIndex = 0;
            this.Album_List.UseCompatibleStateImageBehavior = false;
            this.Album_List.View = System.Windows.Forms.View.Details;
            this.Album_List.DoubleClick += new System.EventHandler(this.Album_List_SelectedIndexChanged);
            // 
            // Artwork_List
            // 
            this.Artwork_List.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Artwork_List.ImageSize = new System.Drawing.Size(16, 16);
            this.Artwork_List.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Songs_View
            // 
            this.Songs_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Songs_View.Controls.Add(this.Song_List);
            this.Songs_View.Location = new System.Drawing.Point(180, 75);
            this.Songs_View.Name = "Songs_View";
            this.Songs_View.Size = new System.Drawing.Size(804, 416);
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
            this.Song_List.Size = new System.Drawing.Size(801, 413);
            this.Song_List.TabIndex = 0;
            this.Song_List.UseCompatibleStateImageBehavior = false;
            this.Song_List.View = System.Windows.Forms.View.Details;
            this.Song_List.Click += new System.EventHandler(this.Song_List_Click);
            this.Song_List.DoubleClick += new System.EventHandler(this.Song_List_SelectedIndexChanged);
            this.Song_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Song_List_MouseDown);
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
            this.ArtistColumn.Width = 195;
            // 
            // LengthColumn
            // 
            this.LengthColumn.Text = "Length";
            this.LengthColumn.Width = 142;
            // 
            // Queue_View
            // 
            this.Queue_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Queue_View.Controls.Add(this.Queue_List);
            this.Queue_View.Location = new System.Drawing.Point(180, 75);
            this.Queue_View.Margin = new System.Windows.Forms.Padding(0);
            this.Queue_View.Name = "Queue_View";
            this.Queue_View.Size = new System.Drawing.Size(804, 416);
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
            this.Queue_List.Size = new System.Drawing.Size(801, 413);
            this.Queue_List.TabIndex = 1;
            this.Queue_List.UseCompatibleStateImageBehavior = false;
            this.Queue_List.View = System.Windows.Forms.View.Details;
            this.Queue_List.DoubleClick += new System.EventHandler(this.Queue_List_SelectedIndexChanged);
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
            this.Playlists_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Playlists_View.Controls.Add(this.Playlist_List);
            this.Playlists_View.Controls.Add(this.flowLayoutPanel1);
            this.Playlists_View.Location = new System.Drawing.Point(180, 75);
            this.Playlists_View.Name = "Playlists_View";
            this.Playlists_View.Size = new System.Drawing.Size(804, 416);
            this.Playlists_View.TabIndex = 0;
            this.Playlists_View.Visible = false;
            // 
            // Playlist_List
            // 
            this.Playlist_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlaylistList});
            this.Playlist_List.Location = new System.Drawing.Point(3, 3);
            this.Playlist_List.Name = "Playlist_List";
            this.Playlist_List.Size = new System.Drawing.Size(801, 413);
            this.Playlist_List.TabIndex = 0;
            this.Playlist_List.UseCompatibleStateImageBehavior = false;
            this.Playlist_List.View = System.Windows.Forms.View.Details;
            // 
            // PlaylistList
            // 
            this.PlaylistList.Text = "Playlists";
            this.PlaylistList.Width = 792;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 422);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Current_position_label
            // 
            this.Current_position_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Current_position_label.AutoSize = true;
            this.Current_position_label.Location = new System.Drawing.Point(143, 522);
            this.Current_position_label.Name = "Current_position_label";
            this.Current_position_label.Size = new System.Drawing.Size(22, 13);
            this.Current_position_label.TabIndex = 12;
            this.Current_position_label.Text = "--:--";
            // 
            // Song_length_label
            // 
            this.Song_length_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Song_length_label.AutoSize = true;
            this.Song_length_label.Location = new System.Drawing.Point(1005, 522);
            this.Song_length_label.Name = "Song_length_label";
            this.Song_length_label.Size = new System.Drawing.Size(22, 13);
            this.Song_length_label.TabIndex = 13;
            this.Song_length_label.Text = "--:--";
            // 
            // Artist_View
            // 
            this.Artist_View.Controls.Add(this.Artist_List);
            this.Artist_View.Location = new System.Drawing.Point(180, 75);
            this.Artist_View.Name = "Artist_View";
            this.Artist_View.Size = new System.Drawing.Size(804, 416);
            this.Artist_View.TabIndex = 15;
            // 
            // Artist_List
            // 
            this.Artist_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArtistList});
            this.Artist_List.FullRowSelect = true;
            this.Artist_List.Location = new System.Drawing.Point(3, 3);
            this.Artist_List.Name = "Artist_List";
            this.Artist_List.Size = new System.Drawing.Size(801, 413);
            this.Artist_List.TabIndex = 0;
            this.Artist_List.UseCompatibleStateImageBehavior = false;
            this.Artist_List.View = System.Windows.Forms.View.Details;
            this.Artist_List.DoubleClick += new System.EventHandler(this.Artist_List_SelectedIndexChanged);
            // 
            // ArtistList
            // 
            this.ArtistList.Text = "Artist";
            this.ArtistList.Width = 795;
            // 
            // Artist_Song_List
            // 
            this.Artist_Song_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArtistList_Title,
            this.ArtistList_Album,
            this.ArtistList_Artist,
            this.ArtistList_Duration});
            this.Artist_Song_List.FullRowSelect = true;
            this.Artist_Song_List.Location = new System.Drawing.Point(3, 3);
            this.Artist_Song_List.Name = "Artist_Song_List";
            this.Artist_Song_List.Size = new System.Drawing.Size(801, 413);
            this.Artist_Song_List.TabIndex = 1;
            this.Artist_Song_List.UseCompatibleStateImageBehavior = false;
            this.Artist_Song_List.View = System.Windows.Forms.View.Details;
            this.Artist_Song_List.Click += new System.EventHandler(this.Artist_Song_List_Click);
            this.Artist_Song_List.DoubleClick += new System.EventHandler(this.Artist_Song_List_SelectedIndexChanged);
            // 
            // ArtistList_Title
            // 
            this.ArtistList_Title.Text = "Title";
            this.ArtistList_Title.Width = 265;
            // 
            // ArtistList_Album
            // 
            this.ArtistList_Album.Text = "Album";
            this.ArtistList_Album.Width = 195;
            // 
            // ArtistList_Artist
            // 
            this.ArtistList_Artist.Text = "Artist";
            this.ArtistList_Artist.Width = 194;
            // 
            // ArtistList_Duration
            // 
            this.ArtistList_Duration.Text = "Length";
            this.ArtistList_Duration.Width = 143;
            // 
            // artistLabel
            // 
            this.artistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(136, 560);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(22, 13);
            this.artistLabel.TabIndex = 17;
            this.artistLabel.Text = "     ";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(136, 575);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(25, 13);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "      ";
            // 
            // curAlbumLabel
            // 
            this.curAlbumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.curAlbumLabel.AutoSize = true;
            this.curAlbumLabel.Location = new System.Drawing.Point(136, 590);
            this.curAlbumLabel.Name = "curAlbumLabel";
            this.curAlbumLabel.Size = new System.Drawing.Size(22, 13);
            this.curAlbumLabel.TabIndex = 19;
            this.curAlbumLabel.Text = "     ";
            // 
            // Artist_Song_View
            // 
            this.Artist_Song_View.Controls.Add(this.Artist_Song_List);
            this.Artist_Song_View.Location = new System.Drawing.Point(180, 75);
            this.Artist_Song_View.Name = "Artist_Song_View";
            this.Artist_Song_View.Size = new System.Drawing.Size(804, 416);
            this.Artist_Song_View.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(19, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bear_logo
            // 
            this.bear_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bear_logo.BackColor = System.Drawing.Color.DodgerBlue;
            this.bear_logo.Image = global::BearPlayer.Properties.Resources.bear;
            this.bear_logo.Location = new System.Drawing.Point(21, 404);
            this.bear_logo.Name = "bear_logo";
            this.bear_logo.Size = new System.Drawing.Size(100, 99);
            this.bear_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bear_logo.TabIndex = 0;
            this.bear_logo.TabStop = false;
            // 
            // shuffle_toggle
            // 
            this.shuffle_toggle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.shuffle_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffle_toggle.Image = global::BearPlayer.Properties.Resources.shuffleButtonOff;
            this.shuffle_toggle.Location = new System.Drawing.Point(359, 547);
            this.shuffle_toggle.Name = "shuffle_toggle";
            this.shuffle_toggle.Size = new System.Drawing.Size(61, 50);
            this.shuffle_toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shuffle_toggle.TabIndex = 6;
            this.shuffle_toggle.TabStop = false;
            this.shuffle_toggle.Click += new System.EventHandler(this.Shuffle_Toggle_Click);
            // 
            // repeat_button
            // 
            this.repeat_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat_button.Image = global::BearPlayer.Properties.Resources.Repeat;
            this.repeat_button.Location = new System.Drawing.Point(680, 547);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.Size = new System.Drawing.Size(45, 45);
            this.repeat_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repeat_button.TabIndex = 5;
            this.repeat_button.TabStop = false;
            this.repeat_button.Click += new System.EventHandler(this.Repeat_Button_Click);
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
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Image = global::BearPlayer.Properties.Resources.playButton;
            this.playButton.Location = new System.Drawing.Point(520, 544);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(56, 49);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Album_Song_View
            // 
            this.Album_Song_View.Controls.Add(this.Album_Song_List);
            this.Album_Song_View.Location = new System.Drawing.Point(180, 75);
            this.Album_Song_View.Name = "Album_Song_View";
            this.Album_Song_View.Size = new System.Drawing.Size(804, 416);
            this.Album_Song_View.TabIndex = 20;
            this.Album_Song_View.Visible = false;
            // 
            // Album_Song_List
            // 
            this.Album_Song_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Album_Song_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AlbumSong_Title,
            this.AlbumSong_Album,
            this.AlbumSong_Artist,
            this.AlbumSong_Duration});
            this.Album_Song_List.FullRowSelect = true;
            this.Album_Song_List.Location = new System.Drawing.Point(3, 3);
            this.Album_Song_List.Name = "Album_Song_List";
            this.Album_Song_List.Size = new System.Drawing.Size(801, 413);
            this.Album_Song_List.TabIndex = 0;
            this.Album_Song_List.UseCompatibleStateImageBehavior = false;
            this.Album_Song_List.View = System.Windows.Forms.View.Details;
            this.Album_Song_List.Click += new System.EventHandler(this.Album_Song_List_Click);
            this.Album_Song_List.DoubleClick += new System.EventHandler(this.Album_Song_List_SelectedIndexChanged);
            // 
            // AlbumSong_Title
            // 
            this.AlbumSong_Title.Text = "Title";
            this.AlbumSong_Title.Width = 265;
            // 
            // AlbumSong_Album
            // 
            this.AlbumSong_Album.Text = "Album";
            this.AlbumSong_Album.Width = 195;
            // 
            // AlbumSong_Artist
            // 
            this.AlbumSong_Artist.Text = "Artist";
            this.AlbumSong_Artist.Width = 194;
            // 
            // AlbumSong_Duration
            // 
            this.AlbumSong_Duration.Text = "Length";
            this.AlbumSong_Duration.Width = 143;
            // 
            // Search_View
            // 
            this.Search_View.Controls.Add(this.Search_List);
            this.Search_View.Location = new System.Drawing.Point(180, 75);
            this.Search_View.Name = "Search_View";
            this.Search_View.Size = new System.Drawing.Size(804, 416);
            this.Search_View.TabIndex = 21;
            // 
            // Search_List
            // 
            this.Search_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SearchTitleColumn,
            this.SearchArtistColumn,
            this.SearchAlbumColumn,
            this.SearchDurationColumn});
            this.Search_List.FullRowSelect = true;
            this.Search_List.Location = new System.Drawing.Point(3, 3);
            this.Search_List.MultiSelect = false;
            this.Search_List.Name = "Search_List";
            this.Search_List.Size = new System.Drawing.Size(801, 413);
            this.Search_List.TabIndex = 0;
            this.Search_List.UseCompatibleStateImageBehavior = false;
            this.Search_List.View = System.Windows.Forms.View.Details;
            this.Search_List.SelectedIndexChanged += new System.EventHandler(this.Search_List_SelectedIndexChanged);
            this.Search_List.Click += new System.EventHandler(this.Search_List_Click);
            // 
            // SearchTitleColumn
            // 
            this.SearchTitleColumn.Text = "Title";
            this.SearchTitleColumn.Width = 265;
            // 
            // SearchArtistColumn
            // 
            this.SearchArtistColumn.Text = "Artist";
            this.SearchArtistColumn.Width = 195;
            // 
            // SearchAlbumColumn
            // 
            this.SearchAlbumColumn.Text = "Album";
            this.SearchAlbumColumn.Width = 195;
            // 
            // SearchDurationColumn
            // 
            this.SearchDurationColumn.Text = "Length";
            this.SearchDurationColumn.Width = 140;
            // 
            // NewPlaylist_Panel
            // 
            this.NewPlaylist_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPlaylist_Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NewPlaylist_Panel.Controls.Add(this.NewPlaylist_Label);
            this.NewPlaylist_Panel.Controls.Add(this.NewPlaylist_CancelButton);
            this.NewPlaylist_Panel.Controls.Add(this.NewPlaylist_EnterButton);
            this.NewPlaylist_Panel.Controls.Add(this.NewPlaylist_TextBox);
            this.NewPlaylist_Panel.Location = new System.Drawing.Point(359, 206);
            this.NewPlaylist_Panel.Name = "NewPlaylist_Panel";
            this.NewPlaylist_Panel.Size = new System.Drawing.Size(366, 134);
            this.NewPlaylist_Panel.TabIndex = 22;
            this.NewPlaylist_Panel.Visible = false;
            // 
            // NewPlaylist_Label
            // 
            this.NewPlaylist_Label.AutoSize = true;
            this.NewPlaylist_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlaylist_Label.Location = new System.Drawing.Point(21, 18);
            this.NewPlaylist_Label.Name = "NewPlaylist_Label";
            this.NewPlaylist_Label.Size = new System.Drawing.Size(110, 20);
            this.NewPlaylist_Label.TabIndex = 3;
            this.NewPlaylist_Label.Text = "New Playlist";
            // 
            // NewPlaylist_CancelButton
            // 
            this.NewPlaylist_CancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPlaylist_CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewPlaylist_CancelButton.Location = new System.Drawing.Point(257, 87);
            this.NewPlaylist_CancelButton.Name = "NewPlaylist_CancelButton";
            this.NewPlaylist_CancelButton.Size = new System.Drawing.Size(84, 30);
            this.NewPlaylist_CancelButton.TabIndex = 2;
            this.NewPlaylist_CancelButton.Text = "Cancel";
            this.NewPlaylist_CancelButton.UseVisualStyleBackColor = false;
            this.NewPlaylist_CancelButton.Click += new System.EventHandler(this.NewPlaylist_CancelButton_Click);
            // 
            // NewPlaylist_EnterButton
            // 
            this.NewPlaylist_EnterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPlaylist_EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewPlaylist_EnterButton.Location = new System.Drawing.Point(25, 87);
            this.NewPlaylist_EnterButton.Name = "NewPlaylist_EnterButton";
            this.NewPlaylist_EnterButton.Size = new System.Drawing.Size(84, 30);
            this.NewPlaylist_EnterButton.TabIndex = 1;
            this.NewPlaylist_EnterButton.Text = "Create";
            this.NewPlaylist_EnterButton.UseVisualStyleBackColor = false;
            this.NewPlaylist_EnterButton.Click += new System.EventHandler(this.NewPlaylist_EnterButton_Click);
            // 
            // NewPlaylist_TextBox
            // 
            this.NewPlaylist_TextBox.AcceptsReturn = true;
            this.NewPlaylist_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlaylist_TextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlaylist_TextBox.Location = new System.Drawing.Point(92, 50);
            this.NewPlaylist_TextBox.MaxLength = 50;
            this.NewPlaylist_TextBox.Name = "NewPlaylist_TextBox";
            this.NewPlaylist_TextBox.Size = new System.Drawing.Size(185, 23);
            this.NewPlaylist_TextBox.TabIndex = 7;
            this.NewPlaylist_TextBox.Text = "Name New Playlist";
            this.NewPlaylist_TextBox.Enter += new System.EventHandler(this.NewPlaylist_TextBox_Enter);
            this.NewPlaylist_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPlaylist_TextBox_KeyDown);
            this.NewPlaylist_TextBox.Leave += new System.EventHandler(this.NewPlaylist_TextBox_Leave);
            // 
            // View_Label
            // 
            this.View_Label.AutoSize = true;
            this.View_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Label.Location = new System.Drawing.Point(177, 32);
            this.View_Label.Name = "View_Label";
            this.View_Label.Size = new System.Drawing.Size(109, 35);
            this.View_Label.TabIndex = 23;
            this.View_Label.Text = "Songs";
            // 
            // Playlist_Song_Panel
            // 
            this.Playlist_Song_Panel.Controls.Add(this.Playlist_Song_List);
            this.Playlist_Song_Panel.Location = new System.Drawing.Point(180, 75);
            this.Playlist_Song_Panel.Name = "Playlist_Song_Panel";
            this.Playlist_Song_Panel.Size = new System.Drawing.Size(804, 416);
            this.Playlist_Song_Panel.TabIndex = 24;
            this.Playlist_Song_Panel.Visible = false;
            // 
            // Playlist_Song_List
            // 
            this.Playlist_Song_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Playlist_Song_Title,
            this.Playlist_Song_Album,
            this.Playlist_Song_Artist,
            this.Playlist_Song_Length});
            this.Playlist_Song_List.Location = new System.Drawing.Point(3, 3);
            this.Playlist_Song_List.Name = "Playlist_Song_List";
            this.Playlist_Song_List.Size = new System.Drawing.Size(801, 413);
            this.Playlist_Song_List.TabIndex = 0;
            this.Playlist_Song_List.UseCompatibleStateImageBehavior = false;
            this.Playlist_Song_List.View = System.Windows.Forms.View.Details;
            // 
            // Playlist_Song_Title
            // 
            this.Playlist_Song_Title.Text = "Title";
            this.Playlist_Song_Title.Width = 265;
            // 
            // Playlist_Song_Album
            // 
            this.Playlist_Song_Album.Text = "Album";
            this.Playlist_Song_Album.Width = 195;
            // 
            // Playlist_Song_Artist
            // 
            this.Playlist_Song_Artist.Text = "Artist";
            this.Playlist_Song_Artist.Width = 195;
            // 
            // Playlist_Song_Length
            // 
            this.Playlist_Song_Length.Text = "Length";
            this.Playlist_Song_Length.Width = 142;
            // 
            // Bear_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 617);
            this.Controls.Add(this.View_Label);
            this.Controls.Add(this.NewPlaylist_Panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.curAlbumLabel);
            this.Controls.Add(this.bear_logo);
            this.Controls.Add(this.Song_length_label);
            this.Controls.Add(this.Current_position_label);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.shuffle_toggle);
            this.Controls.Add(this.repeat_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.scrubBar);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Playlists_View);
            this.Controls.Add(this.Queue_View);
            this.Controls.Add(this.Artist_View);
            this.Controls.Add(this.Album_Song_View);
            this.Controls.Add(this.Artist_Song_View);
            this.Controls.Add(this.Search_View);
            this.Controls.Add(this.Songs_View);
            this.Controls.Add(this.Playlist_Song_Panel);
            this.Controls.Add(this.Albums_View);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Bear_Player";
            this.Text = "Bear Player";
            this.Load += new System.EventHandler(this.BearPlayer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bear_Player_KeyDown);
            this.MouseHover += new System.EventHandler(this.BearPlayer_Load);
            this.Resize += new System.EventHandler(this.Bear_Player_Resize);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrubBar)).EndInit();
            this.Albums_View.ResumeLayout(false);
            this.Songs_View.ResumeLayout(false);
            this.Queue_View.ResumeLayout(false);
            this.Playlists_View.ResumeLayout(false);
            this.Artist_View.ResumeLayout(false);
            this.Artist_Song_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bear_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffle_toggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.Album_Song_View.ResumeLayout(false);
            this.Search_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.NewPlaylist_Panel.ResumeLayout(false);
            this.NewPlaylist_Panel.PerformLayout();
            this.Playlist_Song_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.TreeView SideBar;
        private System.Windows.Forms.PictureBox playButton;
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
        private System.Windows.Forms.Label Current_position_label;
        private System.Windows.Forms.Label Song_length_label;
        private System.Windows.Forms.FlowLayoutPanel Queue_View;
        private System.Windows.Forms.ListView Queue_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel Artist_View;
        private System.Windows.Forms.ListView Artist_List;
        private System.Windows.Forms.ColumnHeader ArtistList;
        private System.Windows.Forms.ListView Artist_Song_List;
        private System.Windows.Forms.ColumnHeader ArtistList_Title;
        private System.Windows.Forms.ColumnHeader ArtistList_Album;
        private System.Windows.Forms.ColumnHeader ArtistList_Duration;
        private System.Windows.Forms.ColumnHeader ArtistList_Artist;
        private System.Windows.Forms.PictureBox bear_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label curAlbumLabel;
        private System.Windows.Forms.FlowLayoutPanel Artist_Song_View;
        private System.Windows.Forms.ImageList Artwork_List;
        private System.Windows.Forms.ListView Album_List;
        private System.Windows.Forms.FlowLayoutPanel Album_Song_View;
        private System.Windows.Forms.ListView Album_Song_List;
        private System.Windows.Forms.ColumnHeader AlbumSong_Title;
        private System.Windows.Forms.ColumnHeader AlbumSong_Album;
        private System.Windows.Forms.ColumnHeader AlbumSong_Artist;
        private System.Windows.Forms.ColumnHeader AlbumSong_Duration;
        private System.Windows.Forms.FlowLayoutPanel Search_View;
        private System.Windows.Forms.ListView Search_List;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColumnHeader SearchTitleColumn;
        private System.Windows.Forms.ColumnHeader SearchArtistColumn;
        private System.Windows.Forms.ColumnHeader SearchAlbumColumn;
        private System.Windows.Forms.ColumnHeader SearchDurationColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel NewPlaylist_Panel;
        private System.Windows.Forms.TextBox NewPlaylist_TextBox;
        private System.Windows.Forms.Label NewPlaylist_Label;
        private System.Windows.Forms.Button NewPlaylist_CancelButton;
        private System.Windows.Forms.Button NewPlaylist_EnterButton;
        private System.Windows.Forms.ListView Playlist_List;
        private System.Windows.Forms.ColumnHeader PlaylistList;
        private System.Windows.Forms.Label View_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel Playlist_Song_Panel;
        private System.Windows.Forms.ListView Playlist_Song_List;
        private System.Windows.Forms.ColumnHeader Playlist_Song_Title;
        private System.Windows.Forms.ColumnHeader Playlist_Song_Album;
        private System.Windows.Forms.ColumnHeader Playlist_Song_Artist;
        private System.Windows.Forms.ColumnHeader Playlist_Song_Length;
        private System.Windows.Forms.ColumnHeader Playlist_Title;
        private System.Windows.Forms.ColumnHeader Playlist_Album;
        private System.Windows.Forms.ColumnHeader Playlist_Artist;
        private System.Windows.Forms.ColumnHeader Playlist_Length;
    }
}

