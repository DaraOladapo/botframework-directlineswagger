﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace ConsoleApplication2.Models
{
    public partial class GeoCoordinates
    {
        private double? _elevation;
        
        /// <summary>
        /// Optional. Elevation of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        public double? Elevation
        {
            get { return this._elevation; }
            set { this._elevation = value; }
        }
        
        private double? _latitude;
        
        /// <summary>
        /// Optional. Latitude of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        public double? Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }
        
        private double? _longitude;
        
        /// <summary>
        /// Optional. Longitude of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        public double? Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the thing
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. The type of the thing
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GeoCoordinates class.
        /// </summary>
        public GeoCoordinates()
        {
        }
    }
}
