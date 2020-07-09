﻿namespace SimpleReports.Model.Domain.DataViewObjects
{
    public class LocationVolumeReportView
    {
        public string StockLocationCode { get; set; }

        public string MaterialPartNo { get; set; }

        public decimal LocationMaterialCapacity { get; set; }

        public decimal Quantity { get; set; }

        public decimal CountForFill { get; set; }

        public string VolumeStatus { get; set; }

        public string VolumeState { get; set; }
    }
}