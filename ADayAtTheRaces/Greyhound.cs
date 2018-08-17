using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADayAtTheRaces
{
     public class Greyhound
    {
         public int StartingPosition; //Where the Picturebox starts
         public int RacetrackLength; //How long the racetrack is 
         public PictureBox MyPictureBox = null; //My picturebox object
         public int Location = 0; //my location on the racetrack
         public Random MyRandom; //An instance of Random
         
        

         public bool Run()
         {
             MyRandom = new Random();
             int distance = MyRandom.Next(1, 5);

             MoveMyPictureBox(distance);

             Location += distance;
             if (Location >= (RacetrackLength - StartingPosition)){
                 return true;
             }
             return false;
         }
         public void TakeStartingPosition()
         {
             MoveMyPictureBox(-Location);
             Location = 0;
         }

         public void MoveMyPictureBox(int distance) {
             Point p = MyPictureBox.Location;
             p.X += distance;
             MyPictureBox.Location = p;
         }
    }
}
