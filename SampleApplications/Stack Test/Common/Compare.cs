/* ========================================================================
 * Copyright (c) 2005-2013 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Reflection;

using Opc.Ua;

namespace Opc.Ua.StackTest
{
    /// <summary>
    /// This class contains the compare functions for built in types and structure types..
    /// </summary>
    public class Compare
    {
        /// <summary>
        /// The message context to use for comparisons.
        /// </summary>
        public static ServiceMessageContext MessageContext = ServiceMessageContext.GlobalContext;

        #region Boolean Functions

        /// <summary>
        /// This method compares two Boolean values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareBoolean(bool value1, bool value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }
            return true;
        }
        #endregion

        #region SByte Functions
        /// <summary>
        /// This method compares two SByte values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareSByte(sbyte value1, sbyte value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region Byte Functions
        /// <summary>
        /// This method compares two Byte values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareByte(byte value1, byte value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region Int16 Functions
        /// <summary>
        /// This method compares two Int16 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareInt16(short value1, short value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region UInt16 Functions
        /// <summary>
        /// This method compares two UInt16 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareUInt16(ushort value1, ushort value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region Int32 Functions
        /// <summary>
        /// This method compares two Int32 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareInt32(int value1, int value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region UInt32 Functions
        /// <summary>
        /// This method compares two UInt32 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareUInt32(uint value1, uint value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region Int64 Functions
        /// <summary>
        /// This method compares two Int64 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareInt64(long value1, long value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region UInt64 Functions
        /// <summary>
        /// This method compares two UInt64 values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareUInt64(ulong value1, ulong value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region Float Functions
        /// <summary>
        /// This method compares two Float values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareFloat(float value1, float value2)
        {
            if (value1 != value2)
            {
                if (!(float.IsNaN(value1) && float.IsNaN(value2)))
                {
                    return ReportError(value1, value2);
                }
            }
            return true;
        }
        #endregion

        #region Double Functions
        /// <summary>
        /// This method compares two Double values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareDouble(double value1, double value2)
        {
            if (value1 != value2)
            {
                if (!(Double.IsNaN(value1) && Double.IsNaN(value2)))
                {
                    return ReportError(value1, value2);
                }
            }

            return true;
        }
        #endregion

        #region String Functions
        /// <summary>
        /// This method compares two String values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareString(string value1, string value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (value1.Length != value2.Length)
            {
                return ReportError(value1, value2);
            }

            for (int ii = 0; ii < value1.Length; ii++)
            {
                if (value1[ii] != value2[ii])
                {
                    return ReportError(value1, value2);
                }
            }

            return true;
        }
        #endregion

        #region DateTime Functions
        /// <summary>
        /// This method compares two DateTime values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareDateTime(DateTime value1, DateTime value2)
        {
            if (value1.Kind != value2.Kind)
            {
                if (value1.Kind == DateTimeKind.Local)
                {
                    value1 = value1.ToUniversalTime();
                }

                if (value2.Kind == DateTimeKind.Local)
                {
                    value2 = value2.ToUniversalTime();
                }
            }

            if (value1 < Utils.TimeBase)
            {
                value1 = DateTime.MinValue;
            }

            if (value2 < Utils.TimeBase)
            {
                value2 = DateTime.MinValue;
            }

            return value1 == value2;

        }
        #endregion

        #region Guid Functions
        /// <summary>
        /// This method compares two Guid values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareUuid(Uuid value1, Uuid value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region ByteString Functions
        /// <summary>
        /// This method compares two ByteString values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareByteString(byte[] value1, byte[] value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (value1.Length != value2.Length)
            {
                return ReportError(value1, value2);
            }

            for (int ii = 0; ii < value1.Length; ii++)
            {
                if (value1[ii] != value2[ii])
                {
                    return ReportError(value1[ii], value1[ii]);
                }
            }

            return true;
        }
        #endregion

        #region XmlElement Functions
        /// <summary>
        /// This method compares two XmlElement values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareXmlElement(XmlElement value1, XmlElement value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (value1.LocalName != value2.LocalName)
            {
                return ReportError(value1.LocalName, value2.LocalName);
            }

            if (value1.NamespaceURI != value2.NamespaceURI)
            {
                return ReportError(value1.NamespaceURI, value2.NamespaceURI);
            }

            foreach (XmlAttribute attribute1 in value1.Attributes)
            {
                XmlAttribute attribute2 = value2.GetAttributeNode(attribute1.Name);

                if (attribute2 == null)
                {
                    if (!attribute1.Name.StartsWith("xmlns", StringComparison.Ordinal))
                    {
                        return ReportError(attribute1, attribute2);
                    }

                    string prefix = (attribute1.Name.Length > 5) ? attribute1.Name.Substring(6) : String.Empty;

                    if (attribute1.Value != value2.GetNamespaceOfPrefix(prefix))
                    {
                        return ReportError(attribute1.Value, value2.GetNamespaceOfPrefix(prefix));
                    }
                }
                else
                {
                    if (attribute2.Value != attribute1.Value)
                    {
                        return ReportError(attribute2.Value, attribute1.Value);
                    }
                }
            }

            XmlNode child1 = value1.FirstChild;
            XmlNode child2 = value2.FirstChild;

            while (child1 != null && child2 != null)
            {
                while (child1 != null)
                {
                    if (child1.NodeType == XmlNodeType.Element)
                    {
                        break;
                    }

                    child1 = child1.NextSibling;
                }

                while (child2 != null)
                {
                    if (child2.NodeType == XmlNodeType.Element)
                    {
                        break;
                    }

                    child2 = child2.NextSibling;
                }

                if (!CompareXmlElement((XmlElement)child1, (XmlElement)child2))
                {
                    return false;
                }

                if (child1 != null)
                {
                    child1 = child1.NextSibling;
                }

                if (child2 != null)
                {
                    child2 = child2.NextSibling;
                }
            }

            if (child1 != child2)
            {
                return ReportError(child1, child2);
            }

            return true;
        }
        #endregion

        #region NodeId Functions
        /// <summary>
        /// This method compares two NodeId values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareNodeId(NodeId value1, NodeId value2)
        {
            if (NodeId.IsNull(value1) && NodeId.IsNull(value2))
            {
                return true;
            }

            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region ExpandedNodeId Functions
        /// <summary>
        /// This method compares two ExpandedNodeId values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareExpandedNodeId(ExpandedNodeId value1, ExpandedNodeId value2)
        {
            if (NodeId.IsNull(value1) && NodeId.IsNull(value2))
            {
                return true;
            }

            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return false;
                }

                return true;
            }

            if (value1 != value2)
            {
                NodeId nodeId1 = ExpandedNodeId.ToNodeId(value1, MessageContext.NamespaceUris);
                NodeId nodeId2 = ExpandedNodeId.ToNodeId(value2, MessageContext.NamespaceUris);

                if (nodeId1 != nodeId2)
                {
                    return ReportError(value1, value2);
                }
            }

            return true;
        }
        #endregion

        #region StatusCode Functions
        /// <summary>
        /// This method compares two StatusCode values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareStatusCode(StatusCode value1, StatusCode value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region DiagnosticInfo Functions
        /// <summary>
        /// This method compares two DiagnosticInfo values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareDiagnosticInfo(DiagnosticInfo value1, DiagnosticInfo value2)
        {
            if (value1 == null && value2 == null)
            {
                return true;
            }

            if (value1 == null)
            {
                value1 = new DiagnosticInfo();
            }

            if (value2 == null)
            {
                value2 = new DiagnosticInfo();
            }

            if (!CompareInt32(value1.SymbolicId, value2.SymbolicId))
            {
                return false;
            }

            if (!CompareInt32(value1.NamespaceUri, value2.NamespaceUri))
            {
                return false;
            }

            if (!CompareInt32(value1.Locale, value2.Locale))
            {
                return false;
            }

            if (!CompareInt32(value1.LocalizedText, value2.LocalizedText))
            {
                return false;
            }

            if (!CompareString(value1.AdditionalInfo, value2.AdditionalInfo))
            {
                return false;
            }

            if (!CompareStatusCode(value1.InnerStatusCode, value2.InnerStatusCode))
            {
                return false;
            }

            if (!CompareDiagnosticInfo(value1.InnerDiagnosticInfo, value2.InnerDiagnosticInfo))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region QualifiedName Functions
        /// <summary>
        /// This method compares two QualifiedName values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareQualifiedName(QualifiedName value1, QualifiedName value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == QualifiedName.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == QualifiedName.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!value1.Equals(value2))
            {
                return ReportError(value1, value1);
            }
            return true;
        }
        #endregion

        #region LocalizedText Functions
        /// <summary>
        /// This method compares two LocalizedText values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareLocalizedText(LocalizedText value1, LocalizedText value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == LocalizedText.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == LocalizedText.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!value1.Equals(value2))
            {
                return ReportError(value1, value1);
            }
            return true;
        }
        #endregion

        #region Variant Functions
        /// <summary>
        /// This method compares two Variant values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareVariant(Variant value1, Variant value2)
        {
            if (value1.Value == null && value2.Value == null)
            {
                return true;
            }

            System.Type systemType = null;

            if (value1.Value != null)
            {
                systemType = value1.Value.GetType();

                if (value2.Value != null && systemType != value2.Value.GetType())
                {
                    return ReportError(value1.Value, value2.Value);
                }
            }

            if (systemType == null)
            {
                systemType = value2.Value.GetType();
            }


            if (!systemType.IsArray || systemType == typeof(byte[]))
            {
                if (systemType == typeof(string)) { return CompareString((string)value1.Value, (string)value2.Value); }
                if (systemType == typeof(Uuid)) { return CompareUuid((Uuid)value1.Value, (Uuid)value2.Value); }
                if (systemType == typeof(byte[])) { return CompareByteString((byte[])value1.Value, (byte[])value2.Value); }
                if (systemType == typeof(XmlElement)) { return CompareXmlElement((XmlElement)value1.Value, (XmlElement)value2.Value); }
                if (systemType == typeof(NodeId)) { return CompareNodeId((NodeId)value1.Value, (NodeId)value2.Value); }
                if (systemType == typeof(ExpandedNodeId)) { return CompareExpandedNodeId((ExpandedNodeId)value1.Value, (ExpandedNodeId)value2.Value); }
                if (systemType == typeof(StatusCode)) { return CompareStatusCode((StatusCode)value1.Value, (StatusCode)value2.Value); }
                if (systemType == typeof(DiagnosticInfo)) { return CompareDiagnosticInfo((DiagnosticInfo)value1.Value, (DiagnosticInfo)value2.Value); }
                if (systemType == typeof(QualifiedName)) { return CompareQualifiedName((QualifiedName)value1.Value, (QualifiedName)value2.Value); }
                if (systemType == typeof(LocalizedText)) { return CompareLocalizedText((LocalizedText)value1.Value, (LocalizedText)value2.Value); }
                if (systemType == typeof(ExtensionObject)) { return CompareExtensionObject((ExtensionObject)value1.Value, (ExtensionObject)value2.Value); }
                if (systemType == typeof(DataValue)) { return CompareDataValue((DataValue)value1.Value, (DataValue)value2.Value); }
                if (systemType == typeof(Variant)) { return CompareVariant((Variant)value1.Value, (Variant)value2.Value); }
                if (systemType == typeof(Matrix)) { return CompareMatrix((Matrix)value1.Value, (Matrix)value2.Value); }
                
                if (value1.Value == null || value2.Value == null)
                {
                    return ReportError(value1.Value, value2.Value);
                }

                if (systemType == typeof(bool)) { return CompareBoolean((bool)value1.Value, (bool)value2.Value); }
                if (systemType == typeof(sbyte)) { return CompareSByte((sbyte)value1.Value, (sbyte)value2.Value); }
                if (systemType == typeof(byte)) { return CompareByte((byte)value1.Value, (byte)value2.Value); }
                if (systemType == typeof(short)) { return CompareInt16((short)value1.Value, (short)value2.Value); }
                if (systemType == typeof(ushort)) { return CompareUInt16((ushort)value1.Value, (ushort)value2.Value); }
                if (systemType == typeof(int)) { return CompareInt32((int)value1.Value, (int)value2.Value); }
                if (systemType == typeof(uint)) { return CompareUInt32((uint)value1.Value, (uint)value2.Value); }
                if (systemType == typeof(long)) { return CompareInt64((long)value1.Value, (long)value2.Value); }
                if (systemType == typeof(ulong)) { return CompareUInt64((ulong)value1.Value, (ulong)value2.Value); }
                if (systemType == typeof(float)) { return CompareFloat((float)value1.Value, (float)value2.Value); }
                if (systemType == typeof(double)) { return CompareDouble((double)value1.Value, (double)value2.Value); }
                if (systemType == typeof(DateTime)) { return CompareDateTime((DateTime)value1.Value, (DateTime)value2.Value); }
            }
            else
            {
                if (systemType == typeof(bool[])) { return CompareArray<bool>((bool[])value1.Value, (bool[])value2.Value, CompareBoolean); }
                if (systemType == typeof(sbyte[])) { return CompareArray<sbyte>((sbyte[])value1.Value, (sbyte[])value2.Value, CompareSByte); }
                if (systemType == typeof(short[])) { return CompareArray<short>((short[])value1.Value, (short[])value2.Value, CompareInt16); }
                if (systemType == typeof(ushort[])) { return CompareArray<ushort>((ushort[])value1.Value, (ushort[])value2.Value, CompareUInt16); }
                if (systemType == typeof(int[])) { return CompareArray<int>((int[])value1.Value, (int[])value2.Value, CompareInt32); }
                if (systemType == typeof(uint[])) { return CompareArray<uint>((uint[])value1.Value, (uint[])value2.Value, CompareUInt32); }
                if (systemType == typeof(long[])) { return CompareArray<long>((long[])value1.Value, (long[])value2.Value, CompareInt64); }
                if (systemType == typeof(ulong[])) { return CompareArray<ulong>((ulong[])value1.Value, (ulong[])value2.Value, CompareUInt64); }
                if (systemType == typeof(float[])) { return CompareArray<float>((float[])value1.Value, (float[])value2.Value, CompareFloat); }
                if (systemType == typeof(double[])) { return CompareArray<double>((double[])value1.Value, (double[])value2.Value, CompareDouble); }
                if (systemType == typeof(string[])) { return CompareArray<string>((string[])value1.Value, (string[])value2.Value, CompareString); }
                if (systemType == typeof(DateTime[])) { return CompareArray<DateTime>((DateTime[])value1.Value, (DateTime[])value2.Value, CompareDateTime); }
                if (systemType == typeof(Uuid[])) { return CompareArray<Uuid>((Uuid[])value1.Value, (Uuid[])value2.Value, CompareUuid); }
                if (systemType == typeof(byte[][])) { return CompareArray<byte[]>((byte[][])value1.Value, (byte[][])value2.Value, CompareByteString); }
                if (systemType == typeof(XmlElement[])) { return CompareArray<XmlElement>((XmlElement[])value1.Value, (XmlElement[])value2.Value, CompareXmlElement); }
                if (systemType == typeof(NodeId[])) { return CompareArray<NodeId>((NodeId[])value1.Value, (NodeId[])value2.Value, CompareNodeId); }
                if (systemType == typeof(ExpandedNodeId[])) { return CompareArray<ExpandedNodeId>((ExpandedNodeId[])value1.Value, (ExpandedNodeId[])value2.Value, CompareExpandedNodeId); }
                if (systemType == typeof(StatusCode[])) { return CompareArray<StatusCode>((StatusCode[])value1.Value, (StatusCode[])value2.Value, CompareStatusCode); }
                if (systemType == typeof(DiagnosticInfo[])) { return CompareArray<DiagnosticInfo>((DiagnosticInfo[])value1.Value, (DiagnosticInfo[])value2.Value, CompareDiagnosticInfo); }
                if (systemType == typeof(QualifiedName[])) { return CompareArray<QualifiedName>((QualifiedName[])value1.Value, (QualifiedName[])value2.Value, CompareQualifiedName); }
                if (systemType == typeof(LocalizedText[])) { return CompareArray<LocalizedText>((LocalizedText[])value1.Value, (LocalizedText[])value2.Value, CompareLocalizedText); }
                if (systemType == typeof(ExtensionObject[])) { return CompareArray<ExtensionObject>((ExtensionObject[])value1.Value, (ExtensionObject[])value2.Value, CompareExtensionObject); }
                if (systemType == typeof(DataValue[])) { return CompareArray<DataValue>((DataValue[])value1.Value, (DataValue[])value2.Value, CompareDataValue); }
                if (systemType == typeof(Variant[])) { return CompareArray<Variant>((Variant[])value1.Value, (Variant[])value2.Value, CompareVariant); }
            }

            return ReportError(value1.Value, value2.Value);
        }
        #endregion

        #region DataValue Functions
        /// <summary>
        /// This method compares two DataValues.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns> 
        public static bool CompareDataValue(DataValue value1, DataValue value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (!CompareVariant(value1.WrappedValue, value2.WrappedValue))
            {
                return false;
            }

            if (!CompareStatusCode(value1.StatusCode, value2.StatusCode))
            {
                return false;
            }

            if (!CompareDateTime(value1.SourceTimestamp, value2.SourceTimestamp))
            {
                return false;
            }

            if (!CompareUInt16(value1.SourcePicoseconds, value2.SourcePicoseconds))
            {
                return false;
            }

            if (!CompareDateTime(value1.ServerTimestamp, value2.ServerTimestamp))
            {
                return false;
            }

            if (!CompareUInt16(value1.ServerPicoseconds, value2.ServerPicoseconds))
            {
                return false;
            }

            return true;
        }
        #endregion
        
        #region Matrix Functions
        /// <summary>
        /// This method compares two DataValues.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns> 
        public static bool CompareMatrix(Matrix value1, Matrix value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            if (!CompareVariant(new Variant(value1.Elements), new Variant(value2.Elements)))
            {
                return false;
            }

            if (!CompareArray<Int32>(value1.Dimensions, value2.Dimensions, CompareInt32))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region ExtensionObject Functions
        /// <summary>
        /// The factory to use when decoding extension objects.
        /// </summary>        
        public static EncodeableFactory EncodeableFactory
        {
            get
            {
                if (m_Factory == null)
                {
                    m_Factory = new EncodeableFactory();
                    m_Factory.AddEncodeableTypes(Assembly.GetExecutingAssembly());
                }

                return m_Factory;
            }
        }
       
        // It stores encodable types of the executing assembly.       
        private static EncodeableFactory m_Factory = new EncodeableFactory();

        /// <summary>
        /// Extracts the extension object body.
        /// </summary>
        /// <param name="value">Extension object.</param>
        /// <returns>IEncodeable object</returns>
        public static object GetExtensionObjectBody(ExtensionObject value)
        {
            object body = value.Body;

            if (body is IEncodeable)
            {
                return (IEncodeable)body;
            }

            Type expectedType = EncodeableFactory.GetSystemType(value.TypeId);

            if (expectedType == null)
            {
                throw new ServiceResultException(StatusCodes.BadInvalidState, Utils.Format("Cannot decode extension object with type '{0}'.", value.TypeId));
            }

            ServiceMessageContext context = new ServiceMessageContext();
            context.Factory = EncodeableFactory;

            if (body is XmlElement)
            {
                XmlQualifiedName xmlName = EncodeableFactory.GetXmlName(expectedType);
                XmlDecoder decoder = new XmlDecoder((XmlElement)body, context);

                decoder.PushNamespace(xmlName.Namespace);
                body = decoder.ReadEncodeable(xmlName.Name, expectedType);
                decoder.PopNamespace();
                decoder.Close();

                return (IEncodeable)body;
            }

            if (body is byte[])
            {
                BinaryDecoder decoder = new BinaryDecoder((byte[])body, context);
                body = decoder.ReadEncodeable(null, expectedType);
                decoder.Close();

                return (IEncodeable)body;
            }

            return body;
        }

        /// <summary>
        /// This method compares two ExtensionObject values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareExtensionObject(ExtensionObject value1, ExtensionObject value2)
        {
            if (value1 == null || value2 == null)
            {
                if (value1 != value2)
                {
                    return ReportError(value1, value2);
                }

                return true;
            }

            object body1 = value1.Body;
            object body2 = value2.Body;

            if (body1 == null || body2 == null)
            {
                return body1 == body2;
            }

            if (body1 is byte[] && body2 is byte[])
            {
                if (!CompareExpandedNodeId(value1.TypeId, value2.TypeId))
                {
                    return ReportError(value1.TypeId, value2.TypeId);
                }

                return CompareByteString((byte[])body1, (byte[])body2);
            }

            if (body1 is XmlElement && body2 is XmlElement)
            {
                if (!CompareExpandedNodeId(value1.TypeId, value2.TypeId))
                {
                    return ReportError(value1.TypeId, value2.TypeId);
                }

                return CompareXmlElement((XmlElement)body1, (XmlElement)body2);
            }

            body1 = GetExtensionObjectBody(value1);
            body2 = GetExtensionObjectBody(value2);

            if (body1 is AcmeWidget)
            {
                return CompareAcmeWidget((AcmeWidget)body1, (AcmeWidget)body2);
            }

            if (body1 is CoyoteGadget)
            {
                return CompareCoyoteGadget((CoyoteGadget)body1, (CoyoteGadget)body2);
            }

            if (body1 is SkyNetRobot)
            {
                return CompareSkyNetRobot((SkyNetRobot)body1, (SkyNetRobot)body2);
            }

            if (body1 is S88Phase)
            {
                return CompareS88Phase((S88Phase)body1, (S88Phase)body2);
            }

            if (body1 is S88Batch)
            {
                return CompareS88Batch((S88Batch)body1, (S88Batch)body2);
            }

            if (body1 is S88Operation)
            {
                return CompareS88Operation((S88Operation)body1, (S88Operation)body2);
            }

            if (body1 is S88UnitProcedure)
            {
                return CompareS88UnitProcedure((S88UnitProcedure)body1, (S88UnitProcedure)body2);
            }

            if (body1 is ScalarTestType)
            {
                return CompareScalarTestType((ScalarTestType)body1, (ScalarTestType)body2);
            }

            if (body1 is ArrayTestType)
            {
                return CompareArrayTestType((ArrayTestType)body1, (ArrayTestType)body2);
            }

            if (body1 is Driver)
            {
                return CompareDriver((Driver)body1, (Driver)body2);
            }

            if (body1 is Car)
            {
                return CompareCar((Car)body1, (Car)body2);
            }

            if (body1 is Truck)
            {
                return CompareTruck((Truck)body1, (Truck)body2);
            }

            return ReportError(body1, body2);
        }
        #endregion

        #region EnumeratedTestType Functions
        /// <summary>
        /// This method compares two EnumeratedTestType values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareEnumeratedTestType(EnumeratedTestType value1, EnumeratedTestType value2)
        {
            if (value1 != value2)
            {
                return ReportError(value1, value2);
            }

            return true;
        }
        #endregion

        #region AcmeWidget Functions
        /// <summary>
        /// This method compares two AcmeWidget objects.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareAcmeWidget(AcmeWidget value1, AcmeWidget value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == AcmeWidget.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == AcmeWidget.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!CompareString(value1.Color, value2.Color)) return false;
            if (!CompareInt32(value1.Quantity, value2.Quantity)) return false;
            if (!CompareDateTime(value1.BuildDate, value2.BuildDate)) return false;

            return true;
        }
        #endregion

        #region CoyoteGadget Functions
        /// <summary>
        /// This method compares two CoyoteGadget objects.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareCoyoteGadget(CoyoteGadget value1, CoyoteGadget value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == CoyoteGadget.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == CoyoteGadget.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!CompareAcmeWidget(value1, value2))
            {
                return false;
            }

            if (!CompareUInt32(value1.CookTime, value2.CookTime)) return false;
            if (!CompareArray<string>(value1.Spices, value2.Spices, CompareString)) return false;

            return true;
        }
        #endregion

        #region SkyNetRobot Functions
        /// <summary>
        /// This method compares two SkyNetRobot values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareSkyNetRobot(SkyNetRobot value1, SkyNetRobot value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == SkyNetRobot.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == SkyNetRobot.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!CompareString(value1.Model, value2.Model)) return false;
            if (!CompareAcmeWidget(value1.TargetSensor, value2.TargetSensor)) return false;
            if (!CompareDateTime(value1.BuildDate, value2.BuildDate)) return false;

            return true;
        }
        #endregion

        #region S88Batch functions
        /// <summary>
        /// This method compares two S88Batch values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareS88Batch(S88Batch value1, S88Batch value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == S88Batch.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == S88Batch.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!CompareInt32(value1.BatchID, value2.BatchID)) return false;
            if (!CompareUInt16(value1.RecipeID, value2.RecipeID)) return false;
            if (!CompareDateTime(value1.StartTime, value2.StartTime)) return false;
            if (!CompareDateTime(value1.EndTime, value2.EndTime)) return false;
            if (!CompareArray<S88UnitProcedure>((S88UnitProcedure[])value1.UnitProcedures, (S88UnitProcedure[])value2.UnitProcedures, CompareS88UnitProcedure)) return false;
            return true;
        }
        #endregion

        #region S88UnitProcedure functions
        /// <summary>
        /// This method compares two S88UnitProcedure values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareS88UnitProcedure(S88UnitProcedure value1, S88UnitProcedure value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == S88UnitProcedure.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == S88UnitProcedure.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (!CompareString(value1.UnitProcedureName, value2.UnitProcedureName)) return false;
            if (!CompareQualifiedName(value1.UnitId, value2.UnitId)) return false;
            if (!CompareDateTime(value1.StartTime, value2.StartTime)) return false;
            if (!CompareDateTime(value1.EndTime, value2.EndTime)) return false;

            return true;
        }
        #endregion

        #region S88Operation functions
        /// <summary>
        /// This method compares two S88Operation values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareS88Operation(S88Operation value1, S88Operation value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == S88Operation.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == S88Operation.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (!CompareString(value1.OperationName, value2.OperationName)) return false;
            if (!CompareDateTime(value1.StartTime, value2.StartTime)) return false;
            if (!CompareDateTime(value1.EndTime, value2.EndTime)) return false;
            if (!CompareArray<S88Phase>((S88Phase[])value1.Phases, (S88Phase[])value2.Phases, CompareS88Phase)) return false;

            return true;
        }
        #endregion

        #region S88Phase functions
        /// <summary>
        /// This method compares two S88Phase values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareS88Phase(S88Phase value1, S88Phase value2)
        {
            if (value1 == null)
            {
                if (value2 == null || value2 == S88Phase.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1 == S88Phase.Null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (!CompareString(value1.PhaseName, value2.PhaseName)) return false;
            if (!CompareDateTime(value1.StartTime, value2.StartTime)) return false;
            if (!CompareDateTime(value1.EndTime, value2.EndTime)) return false;

            return true;
        }
        #endregion
        
        #region ScalarTestType functions
        /// <summary>
        /// This method compares two ScalarTestType values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareScalarTestType(ScalarTestType value1, ScalarTestType value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareBoolean(value1.Boolean, value2.Boolean)) return false;
            if (!CompareSByte(value1.SByte, value2.SByte)) return false;
            if (!CompareByte(value1.Byte, value2.Byte)) return false;
            if (!CompareInt16(value1.Int16, value2.Int16)) return false;
            if (!CompareUInt16(value1.UInt16, value2.UInt16)) return false;
            if (!CompareInt32(value1.Int32, value2.Int32)) return false;
            if (!CompareUInt32(value1.UInt32, value2.UInt32)) return false;
            if (!CompareInt64(value1.Int64, value2.Int64)) return false;
            if (!CompareUInt64(value1.UInt64, value2.UInt64)) return false;
            if (!CompareFloat(value1.Float, value2.Float)) return false;
            if (!CompareDouble(value1.Double, value2.Double)) return false;
            if (!CompareString(value1.String, value2.String)) return false;
            if (!CompareDateTime(value1.DateTime, value2.DateTime)) return false;
            if (!CompareUuid(value1.Guid, value2.Guid)) return false;
            if (!CompareByteString(value1.ByteString, value2.ByteString)) return false;
            if (!CompareXmlElement(value1.XmlElement, value2.XmlElement)) return false;
            if (!CompareNodeId(value1.NodeId, value2.NodeId)) return false;
            if (!CompareExpandedNodeId(value1.ExpandedNodeId, value2.ExpandedNodeId)) return false;
            if (!CompareStatusCode(value1.StatusCode, value2.StatusCode)) return false;
            if (!CompareDiagnosticInfo(value1.DiagnosticInfo, value2.DiagnosticInfo)) return false;
            if (!CompareQualifiedName(value1.QualifiedName, value2.QualifiedName)) return false;
            if (!CompareLocalizedText(value1.LocalizedText, value2.LocalizedText)) return false;
            if (!CompareExtensionObject(value1.ExtensionObject, value2.ExtensionObject)) return false;
            if (!CompareDataValue(value1.DataValue, value2.DataValue)) return false;
            if (!CompareEnumeratedTestType(value1.EnumeratedValue, value2.EnumeratedValue)) return false;

            return true;
        }
        #endregion
        
        #region ArrayTestType functions
        /// <summary>
        /// This method compares two ArrayTestType values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareArrayTestType(ArrayTestType value1, ArrayTestType value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareArray<bool>(value1.Booleans, value2.Booleans, CompareBoolean)) return false;
            if (!CompareArray<sbyte>(value1.SBytes, value2.SBytes, CompareSByte)) return false;
            if (!CompareArray<short>(value1.Int16s, value2.Int16s, CompareInt16)) return false;
            if (!CompareArray<ushort>(value1.UInt16s, value2.UInt16s, CompareUInt16)) return false;
            if (!CompareArray<int>(value1.Int32s, value2.Int32s, CompareInt32)) return false;
            if (!CompareArray<uint>(value1.UInt32s, value2.UInt32s, CompareUInt32)) return false;
            if (!CompareArray<long>(value1.Int64s, value2.Int64s, CompareInt64)) return false;
            if (!CompareArray<ulong>(value1.UInt64s, value2.UInt64s, CompareUInt64)) return false;
            if (!CompareArray<float>(value1.Floats, value2.Floats, CompareFloat)) return false;
            if (!CompareArray<double>(value1.Doubles, value2.Doubles, CompareDouble)) return false;
            if (!CompareArray<string>(value1.Strings, value2.Strings, CompareString)) return false;
            if (!CompareArray<DateTime>(value1.DateTimes, value2.DateTimes, CompareDateTime)) return false;
            if (!CompareArray<Uuid>(value1.Guids, value2.Guids, CompareUuid)) return false;
            if (!CompareArray<byte[]>(value1.ByteStrings, value2.ByteStrings, CompareByteString)) return false;
            if (!CompareArray<XmlElement>(value1.XmlElements, value2.XmlElements, CompareXmlElement)) return false;
            if (!CompareArray<NodeId>(value1.NodeIds, value2.NodeIds, CompareNodeId)) return false;
            if (!CompareArray<ExpandedNodeId>(value1.ExpandedNodeIds, value2.ExpandedNodeIds, CompareExpandedNodeId)) return false;
            if (!CompareArray<StatusCode>(value1.StatusCodes, value2.StatusCodes, CompareStatusCode)) return false;
            if (!CompareArray<DiagnosticInfo>(value1.DiagnosticInfos, value2.DiagnosticInfos, CompareDiagnosticInfo)) return false;
            if (!CompareArray<QualifiedName>(value1.QualifiedNames, value2.QualifiedNames, CompareQualifiedName)) return false;
            if (!CompareArray<LocalizedText>(value1.LocalizedTexts, value2.LocalizedTexts, CompareLocalizedText)) return false;
            if (!CompareArray<ExtensionObject>(value1.ExtensionObjects, value2.ExtensionObjects, CompareExtensionObject)) return false;
            if (!CompareArray<DataValue>(value1.DataValues, value2.DataValues, CompareDataValue)) return false;
            if (!CompareArray<EnumeratedTestType>(value1.EnumeratedValues, value2.EnumeratedValues, CompareEnumeratedTestType)) return false;

            return true;
        }
        #endregion
        
        #region CompositeTestType functions
        /// <summary>
        /// This method compares two CompositeTestType values.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        public static bool CompareCompositeTestType(CompositeTestType value1, CompositeTestType value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareScalarTestType(value1.Field1, value2.Field1)) return false;
            if (!CompareArrayTestType(value1.Field2, value2.Field2)) return false;

            return true;
        }
        #endregion

        #region Driver functions
        /// <summary>
        /// This method compares two Driver values.
        /// </summary>
        public static bool CompareDriver(Driver value1, Driver value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareLocalizedText(value1.Name, value2.Name)) return false;
            if (!CompareExtensionObject(value1.Vehicle, value2.Vehicle)) return false;
            if (!CompareUuid(value1.LicenseNumber, value2.LicenseNumber)) return false;

            return true;
        }

        /// <summary>
        /// This method compares two Vehicle values.
        /// </summary>
        public static bool CompareVehicle(Vehicle value1, Vehicle value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareString(value1.Make, value2.Make)) return false;
            if (!CompareString(value1.Model, value2.Model)) return false;
            if (!CompareUInt16(value1.Year, value2.Year)) return false;
            if (!CompareArray<Wheel>((Wheel[])value1.Wheels, (Wheel[])value2.Wheels, CompareWheel)) return false;

            return true;
        }

        /// <summary>
        /// This method compares two Car values.
        /// </summary>
        public static bool CompareCar(Car value1, Car value2)
        {
            if (!CompareVehicle(value1, value2))
            {
                return false;
            }

            if (!CompareBoolean(value1.IsHatchback, value2.IsHatchback)) return false;

            return true;
        }

        /// <summary>
        /// This method compares two Truck values.
        /// </summary>
        public static bool CompareTruck(Truck value1, Truck value2)
        {
            if (!CompareVehicle(value1, value2))
            {
                return false;
            }

            if (!CompareUInt32(value1.Capacity, value2.Capacity)) return false;

            return true;
        }

        /// <summary>
        /// This method compares two Wheel values.
        /// </summary>
        public static bool CompareWheel(Wheel value1, Wheel value2)
        {
            if (value1 == null || value2 == null)
            {
                return value1 == value2;
            }

            if (!CompareString(value1.Manufacturer, value2.Manufacturer)) return false;
            if (!CompareDateTime(value1.Installed, value2.Installed)) return false;

            return true;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method compares two arrays.
        /// </summary>      
        /// <param name="value1">IEnumerable object of type T</param>
        /// <param name="value2">IEnumerable object of type T</param>
        /// <param name="comparator">Method name to compare the arrays.</param>
        /// <returns>True in case of equal values.
        /// False or ServiceResultException in case of unequal values.</returns>
        private static bool CompareArray<T>(IEnumerable<T> value1, IEnumerable<T> value2, Comparator<T> comparator)
        {
            if (value1 == null)
            {
                if (value2 == null || value2.GetEnumerator().MoveNext() == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1.GetEnumerator().MoveNext() == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (value2 == null)
            {
                if (value1 == null || value1.GetEnumerator().MoveNext() == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            IEnumerator<T> enumerator1 = value1.GetEnumerator();
            IEnumerator<T> enumerator2 = value2.GetEnumerator();

            while (enumerator1.MoveNext())
            {
                if (!enumerator2.MoveNext())
                {
                    return ReportError(value1, value2);
                }

                if (!comparator(enumerator1.Current, enumerator2.Current))
                {
                    return false;
                }
            }

            if (enumerator2.MoveNext())
            {
                return ReportError(value1, value2);
            }

            return true;
        }

        /// <summary>
        /// In case of errors, throw exception.
        /// </summary>
        /// <param name="value1">First Value.</param>
        /// <param name="value2">Second Value.</param>
        /// <returns>Throws ServiceResultException in case of unequal values.</returns>
        private static bool ReportError(object value1, object value2)
        {
            throw ServiceResultException.Create(
                StatusCodes.BadUnexpectedError,
                "'{0}' is not equal to '{1}'.", 
                value1, 
                value2);
        }
        #endregion
    }
}
