using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
     public class Greyhound
    {
         public int StartingPosition; //Where the Picturebox starts
         public int RacetrackLength; //How long the racetrack is 
         public PictureBox MyPictureBox = null; //My picturebox object
         public int Location = 0; //my location on the racetrack
         public Random Randomizer = new Random(); //An instance of Random
         
        

         public bool Run()
         {
             int Location = Randomizer.Next(1, 4);
             MyPictureBox.Left = StartingPosition + Location;

             if (MyPictureBox.Left >= RacetrackLength)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
         public void TakeStartingPosition()
         {
             Location = 0;
             MyPictureBox.Left = 0;
         }
    }
}
