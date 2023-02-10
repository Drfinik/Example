using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int count, time, distance, dogSpeed, secondFriendSpeed, firstFriendSpeed, friend, rast, max, stm, dtm;
        
        count = 0;
        distance = 20000;
        firstFriendSpeed = 2;
        secondFriendSpeed = 4;
        dogSpeed = 8;
        friend = 2;
        rast = 20;
        while (distance > 0)
        {
            if (friend == 1)
            {
                time = (int) ((double) rast / (dogSpeed + firstFriendSpeed));
                friend = 2;
            }
            else
            {
                time = (int) ((double) rast / (dogSpeed - secondFriendSpeed));
                friend = 1;
            }
            stm = time * secondFriendSpeed;
            if (stm <= distance)
            {
                rast = rast + (secondFriendSpeed - firstFriendSpeed) * time;
                distance = (int) (distance - stm);
                count = count + 1;
            }
            else
            {
                distance = 0;
            }
        }
        Console.WriteLine(count);
    }
}

