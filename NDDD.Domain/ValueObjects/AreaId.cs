using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// エリアID
    /// </summary>
    public sealed class AreaId : ValueObject<AreaId>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public AreaId(int value)
        {
            Value = value;
        }

        /// <summary>
        /// 値
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// 表示する値
        /// </summary>
        public string DisplayValue => Value.ToString().PadLeft(4, '0');

        /// <summary>
        /// EqulsCore
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected override bool EqualsCore(AreaId other)
        {
            return this.Value == other.Value;
        }
    }
}
