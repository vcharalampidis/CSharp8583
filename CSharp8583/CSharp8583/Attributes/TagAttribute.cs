﻿using CSharp8583.Common;
using System;

namespace CSharp8583.Attributes
{
    /// <summary>
    /// Used To Decorate Properties for Reserved Fields Parsing
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Property, Inherited = false)]
    public class TagAttribute : Attribute
    {
        /// <summary>
        /// Constructor of Tag Field Value
        /// </summary>
        /// <param name="position">position in TLV</param>
        /// <param name="tagName">tag value name</param>
        /// <param name="lenBytesLen">number of bytes to parse for Length</param>
        /// <param name="isTlv">whether is TLV (Tag Lentgh Value) or LTV (Lentgh Tag Value)</param>
        /// <param name="dataType">datatype of Value</param>
        /// <param name="lenDataType">datatype of lentgh value</param>
        /// <param name="encoding">Encoding type in case that the bytes are not in Common ASCII char set</param>
        public TagAttribute(int position, string tagName, int lenBytesLen = 2, bool isTlv = true,  
                    DataType dataType = DataType.ASCII, DataType lenDataType = DataType.ASCII, EncodingType encoding = EncodingType.None)
        {
            Position = position;
            TagName = tagName;
            LenBytesLen = lenBytesLen;
            DataType = dataType;
            LenDataType = lenDataType;
            Encoding = encoding;
            IsTLV = isTlv;
        }

        /// <summary>
        /// Tag Position
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Tag Name Value
        /// </summary>
        public string TagName { get; }

        /// <summary>
        /// Lentgh of Length Bytes
        /// </summary>
        public int LenBytesLen { get; }

        /// <summary>
        /// Data Type of Field
        /// </summary>
        public DataType DataType { get; }

        /// <summary>
        /// Len Data Type of Field
        /// </summary>
        public DataType LenDataType { get; }

        /// <summary>
        /// Encoding
        /// </summary>
        public EncodingType Encoding { get; }

        /// <summary>
        /// IsTLV
        /// </summary>
        public bool IsTLV { get; }
    }
}
