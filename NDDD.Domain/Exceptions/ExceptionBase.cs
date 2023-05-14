﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// 例外基底クラス
    /// </summary>
    public abstract class ExceptionBase : Exception
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message"></param>
        public ExceptionBase(string message):base(message)
        {
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="exception">元の例外</param>
        public ExceptionBase(string message,Exception exception):base(message,exception)
        {
        }
        /// <summary>
        /// 例外区分
        /// </summary>
        public abstract ExceptionKind kind { get; }

        /// <summary>
        /// 例外区分
        /// </summary>
        public enum ExceptionKind
        {
            Info,
            Warning,
            Error,
        }
    }
}
