using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptions;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrlastucture.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(Shared.FakePath + "MeasureFake.csv");
                var value = lines[0].Split(',');
                return new MeasureEntity(Convert.ToInt32(value[0]), Convert.ToDateTime(value[1]), Convert.ToSingle(value[2]));
            }
            catch(Exception ex)
            {
                throw new FakeException("MeasureFakeの取得に失敗しました", ex);
                //return new MeasureEntity(9999, Convert.ToDateTime("2023/2/3 20:10:18"), 12.34f);
            }

        }

        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            var result = new List<MeasureEntity>();
            result.Add(new MeasureEntity(10, Convert.ToDateTime("2023/02/05 16:14:25"), 12.35f));
            result.Add(new MeasureEntity(20, Convert.ToDateTime("2023/02/05 17:14:25"), 10.35f));
            result.Add(new MeasureEntity(30, Convert.ToDateTime("2023/02/05 18:14:25"), 6.35f));

            return result;
        }
    }
}
