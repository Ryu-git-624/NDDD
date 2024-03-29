﻿using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.StaticValues
{
    /// <summary>
    /// 計測値のリストクラス
    /// </summary>
    public static class Measures
    {
        /// <summary>
        /// 直近値のリスト
        /// </summary>
        private static List<MeasureEntity> _entities = new List<MeasureEntity>();

        /// <summary>
        /// リストの作成
        /// </summary>
        /// <param name="repository">計測レポジトリー</param>
        public static void Create(IMeasureRepository repository)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                _entities.Clear();
                _entities.AddRange(repository.GetLatests());
            }
        }

        /// <summary>
        /// 直近地の取得(エリアID指定)
        /// </summary>
        /// <param name="areaId">エリアID</param>
        /// <returns></returns>
        public static MeasureEntity GetLatest(AreaId areaId)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                return _entities.Find(x => x.AreaId == areaId);
            }
        }
    }
}
