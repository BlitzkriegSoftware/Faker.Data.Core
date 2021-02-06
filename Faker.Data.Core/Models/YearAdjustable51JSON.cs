//-----------------------------------------------------------------------
// <copyright file="YearAdjustable51JSON.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Models
{
    /// <summary>
    /// YearAdjustable51JSON
    /// </summary>
    public class YearAdjustable51JSON
    {
        /// <summary>
        /// DataSet
        /// </summary>
        public Dataset DataSet { get; set; }

        /// <summary>
        /// Dataset
        /// </summary>
#pragma warning disable CA1034 // Nested types should not be visible
        public class Dataset
#pragma warning restore CA1034 // Nested types should not be visible
        {
            /// <summary>
            /// Id
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// dataset_code
            /// </summary>
            public string dataset_code { get; set; }

            /// <summary>
            /// database_code
            /// </summary>
            public string database_code { get; set; }

            /// <summary>
            /// name
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// description
            /// </summary>
            public string description { get; set; }

            /// <summary>
            /// refreshed_at
            /// </summary>
            public string refreshed_at { get; set; }

            /// <summary>
            /// newest_available_date
            /// </summary>
            public string newest_available_date { get; set; }

            /// <summary>
            /// oldest_available_date
            /// </summary>
            public string oldest_available_date { get; set; }

            /// <summary>
            /// column_names
            /// </summary>
            public List<string> column_names { get; set; }

            /// <summary>
            /// frequency
            /// </summary>
            public string frequency { get; set; }

            /// <summary>
            /// type
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// premium
            /// </summary>
            public bool premium { get; set; }

            /// <summary>
            /// limit
            /// </summary>
            public object limit { get; set; }

            /// <summary>
            /// transform
            /// </summary>
            public object transform { get; set; }

            /// <summary>
            /// column_index
            /// </summary>
            public object column_index { get; set; }

            /// <summary>
            /// start_date
            /// </summary>
            public string start_date { get; set; }

            /// <summary>
            /// end_date
            /// </summary>
            public string end_date { get; set; }

            /// <summary>
            /// data
            /// </summary>
            public List<List<string>> data { get; set; }

            /// <summary>
            /// collapse
            /// </summary>
            public object collapse { get; set; }

            /// <summary>
            /// order
            /// </summary>
            public string order { get; set; }

            /// <summary>
            /// database_id
            /// </summary>
            public int database_id { get; set; }
        }
    }
}