﻿using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.Infrlastucture;
using System;

namespace NDDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {

        private MeasureRepository _measurRrepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _MeasureValueText= string.Empty;

        public LatestViewModel() : this(Factories.CreateMeasure())
        {

        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measurRrepository =  new MeasureRepository(measureRepository);
        }

        public string AreaIdText
        {
            get { return _areaIdText; }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText
        {
            get { return _measureDateText; }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText
        {
            get { return _MeasureValueText; }
            set
            {
                SetProperty(ref _MeasureValueText, value);
            }
        }

        public void Search()
        {
            var measure = _measurRrepository.GetLatest();
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
        }
    }
}
