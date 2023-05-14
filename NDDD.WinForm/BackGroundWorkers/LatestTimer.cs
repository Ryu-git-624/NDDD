using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NDDD.Domain.StaticValues;
using NDDD.Infrlastucture;

namespace NDDD.WinForm.BackGroundWorkers
{
    internal static class LatestTimer
    {
        private static Timer _timer;
        private static bool _isWork = false;

        static LatestTimer()
        {
            _timer = new Timer(Callback);
        }

        internal static void Start()
        {
            _timer.Change(10000, 10000);
        }

        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private static void Callback(Object o)
        {
            if (_isWork)
            {
                return;
            }

            try
            {
                _isWork = true;
                Measures.Create(Factories.CreateMeasure());
            }
            finally
            {
                _isWork = false;
            }
        }
    }
}
