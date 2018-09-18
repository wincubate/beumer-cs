using System;

namespace Wincubate.CS7x.TrackingCurrentAverageLab
{
    class Program
    {
        static void Main( string[] args )
        {
            MeasureUnit unit = new MeasureUnit();
            // TODO 3: initialize currentAverage variable to be read repeatedly in loop

            unit.Start();

            while (true)
            {
                _ = Console.ReadLine();

                // TODO 4: Comment in the line below to read currentAverage
                //Console.WriteLine($"Average read: {currentAverage:f2}" + Environment.NewLine);
            }
        }
    }
}