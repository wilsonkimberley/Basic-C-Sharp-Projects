using System;

class BooleanLoopApp
{
    static void Main()
    {
        // WHILE LOOP
        int counter = 1;
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("While loop iteration: " + counter);
            counter++;

            if (counter > 5)
            {
                keepRunning = false;
            }
        }

        // DO-WHILE LOOP
        int doCounter = 1;
        bool continueLoop = true;

        do
        {
            Console.WriteLine("Do-While loop iteration: " + doCounter);
            doCounter++;

            if (doCounter > 3)
            {
                continueLoop = false;
            }
        } while (continueLoop);
    }
}
