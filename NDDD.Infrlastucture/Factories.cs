using NDDD.Domain;
using NDDD.Domain.Repositories;
using NDDD.Infrlastucture.Fake;
using NDDD.Infrlastucture.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrlastucture
{
    public static class Factories
    {

        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif

            return new MeasureSqlServer();

        }
    }
}
