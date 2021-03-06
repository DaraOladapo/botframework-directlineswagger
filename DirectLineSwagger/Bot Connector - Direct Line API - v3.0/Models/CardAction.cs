﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace ConsoleApplication2.Models
{
    public partial class CardAction
    {
        private string _image;
        
        /// <summary>
        /// Optional. URL Picture which will appear on the button, next to text
        /// label.
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }
        
        private string _title;
        
        /// <summary>
        /// Optional. Text description which appear on the button.
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Defines the type of action implemented by this button.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Supplementary parameter for action. Content of this
        /// property depends on the ActionType
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        public CardAction()
        {
        }
    }
}
