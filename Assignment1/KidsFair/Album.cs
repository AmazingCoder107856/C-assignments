using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 
{
    class Album
    {
        //base variables and datatype declaration
        private string albumName; //name of the album
        private string artistName; //name of the artist
        private int numOfTracks; //number of tracks

        public void Favorites()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Hello! Greetings from P1 Music Sounds."); //greeting phrase
            Console.WriteLine(); //blankline

            FavoriteAlbumArtistInfo(); //method for album, artist and tracks information

        }

        public void FavoriteAlbumArtistInfo()
        {
            //Read a line of text
            Console.WriteLine("This is Gloria speaking! I'm your DJ for tonight. So let's start with your request. What is the name of your favorite album?");
            string albumName = Console.ReadLine();

            //Read a line of text
            Console.WriteLine("And, the name of the artist or band of " + albumName + "?");
            string artistName = Console.ReadLine();

            //read a whole number and converting string to number
            Console.WriteLine("How many tracks does " + albumName + " have?");
            int numOfTracks = Convert.ToInt32(Console.ReadLine());

            //display album name, artist name and no. of tracks
            Console.WriteLine(); //blankline
            Console.WriteLine("+++++++++ Here's the summary of your request ++++++++++");
            Console.WriteLine(); //blankline
            Console.WriteLine("Music album name: " + albumName);
            Console.WriteLine("Music artist name: " + artistName);
            Console.WriteLine("Number of tracks: " + numOfTracks);
            Console.WriteLine(); //blankline
            Console.WriteLine("Enjoy listening and have a good day!");
            Console.WriteLine(); //blankline
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.ReadKey(); //wait before closing
        }
    }
}       
