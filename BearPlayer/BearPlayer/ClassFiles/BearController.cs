using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearPlayer {
    class BearController {

        private bool play;   // Global variable for controling play/pause state
        private WMPLib.WindowsMediaPlayer Player;   //player object from WMP library
        private enum Repeat_Type { Off, Repeat_All, Repeat_One };

        private bool song_selected;
        private string curr_song;

        //Selected Song
        private string selected_artist, selected_album;

        //Special functions
        bool shuffle;
        Repeat_Type repeat_type;

        //Properties
        public double PlayerPosition {
            get { return Player.controls.currentPosition; }
            set { Player.controls.currentPosition = value; }
        }

        public string PlayerURL {
            get { return Player.URL; }
            set { Player.URL = value; }
        }

        public int PlayerVolume {
            get { return Player.settings.volume; }
            set { Player.settings.volume = value; }
        }


        public BearController() {
            play = true;   // Begin program with play button

            Player = new WMPLib.WindowsMediaPlayer();
            Player.settings.volume = 25;


            curr_song = null;
            song_selected = false;
            
            selected_artist = "";
            shuffle = false;
            repeat_type = Repeat_Type.Off;

        }

        public bool PlayPause() {

            bool ret = false;

            if (play) {

                if (!song_selected)
                    play = false;                //for case where nothing is selected and they try to click play
         
                else {
                    ret = true;
                    Player.controls.play();
                }
            }
            else
                Player.controls.pause(); // SHOULD BE CHANGED TO PAUSE EVENTUALLY BUT CURRENTLY PAUSE CAUSES IT TO REPEAT IMMEDIATELY

            play = !play;

            return ret;
        }

        public void playerPlay() {
            Player.controls.play();
        }

        public void playerPause() {
            Player.controls.pause();
        }

       
    }
}
