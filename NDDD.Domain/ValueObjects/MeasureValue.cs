using DDD.Domain.ValueObjects;
using NDDD.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Value.RoundString(2) + "℃";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
