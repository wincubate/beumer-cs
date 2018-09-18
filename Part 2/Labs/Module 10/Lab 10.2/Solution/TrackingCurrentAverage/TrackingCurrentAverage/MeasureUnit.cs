using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wincubate.CS7x.TrackingCurrentAverageLab
{
    class MeasureUnit
    {
        private readonly Task _task;
        private readonly List<double> _data;

        // TODO 1: Define CurrentAverage property
        public ref readonly double CurrentAverage => ref _currentAverage;
        private double _currentAverage;

        public MeasureUnit()
        {
            _data = new List<double>( 10 );
            _task = new Task(async () =>
                   {
                       Random random = new Random();
                       while (true)
                       {
                            await Task
                            .Delay(random.Next(5000))
                            .ContinueWith(t =>
                            {
                                double measured = 100 * random.NextDouble();
                                Console.WriteLine($"Value measured: {measured:f2}");
                                Add(measured);
                            }
                            );
                        }
                   },
                TaskCreationOptions.LongRunning
            );
        }

        public void Start() => _task.Start();

        private void Add( double measured )
        {
            // TODO 2: Handle measurement
            _data.Add(measured);
            if( _data.Count > 10 )
            {
                _data.RemoveAt(0);
            }

            _currentAverage = _data.Average();
        }
    }
}