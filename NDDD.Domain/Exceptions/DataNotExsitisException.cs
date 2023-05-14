using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// データなし例外
    /// </summary>
    public sealed class DataNotExsitisException : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DataNotExsitisException():base("データがありません")
        {
        }

        /// <summary>
        /// 区分
        /// </summary>
        public override ExceptionKind kind => ExceptionKind.Info;
    }
}
