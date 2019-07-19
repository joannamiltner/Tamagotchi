using System;

namespace Tamagotchi.Models
{
    public class Grumpson
    {


        //ranges from 100 to 0
        //if it hits zero, happiness decreases
        public int hunger;

       //ranges from 100 to 0
       //if it hits zero, your couch gets destroyed
        public int play;

       //range from 100 to 0
       //if sleep hits zero, snore meter activated
        public int sleep;

       //range from 100 to 0
       //if happiness hits zero, you spend all your money on puppy toys from guilt
        public int happiness;

        public static Random rand = new Random();

        public string name;

        public string image;

        // public string restart;

        public string message = "You encounterd a Grumpson!";

        public Grumpson(string name)
        {
            hunger = 20;
            play = 20;
            sleep = 20;
            happiness = 20;
            this.name = name;
            this.image="default.gif";
        }


        public void Feed()
        {
            if(rand.Next(5) < 3)
            {
                this.message = "Grumpson loved his food";
                this.hunger += rand.Next(10, 21);
                this.happiness += rand.Next(5, 11);
                this.image="eat.gif";
            }
            else{
                this.message = "This food is not up to Grumpson's standards.";
                this.hunger -= rand.Next(5, 11);
                this.happiness -= rand.Next(5, 15);
                this.image="angry.gif";
            }
        }

        public void Play()
        {
            if(rand.Next(5) < 3)
            {
                this.message = "Grumpson successfully defluffed his toy!";
                this.hunger -= rand.Next(2, 6);
                this.play += 20;
                this.happiness += rand.Next(12,15);
                this.sleep -= 10;
                this.image="happy.gif";
            }
            else{
                this.message = "Grumpson is butthurt for no reason.";
                this.hunger -= rand.Next(3, 11);
                this.play -= rand.Next(5,11);
                this.happiness -= rand.Next(2,5);
                this.image="angry.gif";
            }
        }

        public void Sleep()
        {
            if(rand.Next(5) < 3)
            {
                this.message = "Shhh, Grumpson is sleeping!";
                this.hunger -= rand.Next(8, 12);
                this.sleep += rand.Next(15, 21);
                this.image="sleep.gif";
            }
            else{
                this.message = "You woke him up...";
                this.happiness -= rand.Next(2,5);
                this.sleep -= 15;
                this.image="angry.gif";
            }
        }

        public void Pet()
        {
            if(rand.Next(5) < 3)
            {
                this.message = "Grumpson is a happy pupper.";
                this.happiness += rand.Next(12,18);
                this.image="happy.gif";
            }
            else{
                this.message = "Grumpson ran away.";
                this.happiness -= rand.Next(5, 10);
                this.image="runaway.png";
            }
        }

        public void Check()
        {
            if(hunger <= 0)
            {
                this.hunger =0;
            }
            if(happiness <= 0)
            {
                this.message ="You go into massive debt spending all your money on dog toys because of all the unbearable guilt. Game Over.";
                this.happiness = 0;
            }
            else if(play <=0)
            {
                this.message ="Grumpson eats the couch out of boredom. You have a heart attack from the stress. You Lose.";
                this.play = 0;
            }
            else if(sleep <=0)
            {
                this.message ="Grumpson snores throughout the night. You don't get any sleep. You messed up a huge project at work and got fired due to delirium. You Lose.";
                this.sleep=0;
            }
            else if(happiness > 99 && hunger > 99 && play > 99 && sleep > 99)
            {
                this.message="CONGRATULATIONS. You have won Grumpson's unconditional love! I haven't even done that shit. YOU WIN. Now take him because I need to sleep.";
            }




        }



    }
}