//-----------------------------------------------------------------------
// <copyright file="FuelPricesModel.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Faker.Models
{
    /// <summary>
    /// Model: Fuel Prices
    /// </summary>
    [Serializable]
    [XmlRoot("fuelPrices")]
    public class FuelPricesModel
    {
        /// <summary>
        /// Compressed Natural Gas
        /// </summary>
        [XmlElement("cng")]
        public double CompressedNaturalGas { get; set; }

        /// <summary>
        /// Diesel
        /// </summary>
        [XmlElement("diesel")]
        public double Diesel { get; set; }

        /// <summary>
        /// E85
        /// </summary>
        [XmlElement("e85")]
        public double E85 { get; set; }

        /// <summary>
        /// Electric
        /// </summary>
        [XmlElement("electric")]
        public double Electric { get; set; }

        /// <summary>
        /// LPG
        /// </summary>
        [XmlElement("lpg")]
        public double LPG { get; set; }

        /// <summary>
        /// Midgrade
        /// </summary>
        [XmlElement("midgrade")]
        public double Midgrade { get; set; }

        /// <summary>
        /// Premium
        /// </summary>
        [XmlElement("premium")]
        public double Premium { get; set; }

        /// <summary>
        /// Regular
        /// </summary>
        [XmlElement("regular")]
        public double Regular { get; set; }
    }
}
