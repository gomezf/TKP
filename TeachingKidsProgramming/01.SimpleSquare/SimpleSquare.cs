using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main()
		{
			//	Show the tortoise --#1
              Tortoise.Show();
            //Tortoise MyTestTortoise;

			//  Make the tortoise move as fast as possible  --#6
              Tortoise.SetSpeed(8);
			//  Do the following 4 times --#5.1

              for (int i = 0; i < 4; i++)
              {


                  //     Change the color of the line the tortoise draws to blue --#4
                  Tortoise.SetPenColor("blue");
                  //     Move the tortoise 50 pixels --#2
                  Tortoise.Move(50);
                  //     Turn the tortoise 90 degrees to the right --#3
                  Tortoise.Turn(90);
                  //  Repeat --#5.2
              }
		}
	}
}