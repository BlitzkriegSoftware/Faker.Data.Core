//-----------------------------------------------------------------------
// <copyright file="YearAdjustable51.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Faker.Models
{
    /// <summary>
    /// Model for loading from the XML file
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "Value")]
    public class YearAdjustable51
    {
        /// <summary>
        /// Date
        /// </summary>
        [XmlAttribute("date")]
#pragma warning disable CA2235 // Mark all non-serializable fields
        public DateTime Date { get; set; }
#pragma warning restore CA2235 // Mark all non-serializable fields

        /// <summary>
        /// Percentage
        /// </summary>
        [XmlAttribute("percentage")]
        public double Percentage { get; set; }
    }
}
