using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// 計測日時
    /// </summary>
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">値</param>
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        /// <summary>
        /// 値
        /// </summary>
        public DateTime Value { get; }

        /// <summary>
        /// 表示する値
        /// </summary>
        public string DisplayValue => Value.ToString("yyyy/MM/dd HH:mm:ss");

        /// <summary>
        /// EqualsCore
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}
