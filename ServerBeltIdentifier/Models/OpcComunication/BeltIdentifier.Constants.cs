/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BeltIdentifier
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint BeltType_StartProcess = 342;

        /// <remarks />
        public const uint BeltType_StopProcess = 343;

        /// <remarks />
        public const uint BeltType_ResetProcess = 344;

        /// <remarks />
        public const uint BeltType_AddTransparentPieceProcess = 1106;

        /// <remarks />
        public const uint BeltType_AddMetallicPieceProcess = 1107;

        /// <remarks />
        public const uint BeltType_AddNonMetallicPieceProcess = 1108;

        /// <remarks />
        public const uint BeltServer_StartProcess = 460;

        /// <remarks />
        public const uint BeltServer_StopProcess = 461;

        /// <remarks />
        public const uint BeltServer_ResetProcess = 462;

        /// <remarks />
        public const uint BeltServer_AddTransparentPieceProcess = 1165;

        /// <remarks />
        public const uint BeltServer_AddMetallicPieceProcess = 1166;

        /// <remarks />
        public const uint BeltServer_AddNonMetallicPieceProcess = 1167;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Module1Type_Transparent = 929;

        /// <remarks />
        public const uint Module1Type_Metallic = 128;

        /// <remarks />
        public const uint Module1Type_NonMetallic = 135;

        /// <remarks />
        public const uint Module1Type_QuantityTransparent = 936;

        /// <remarks />
        public const uint Module1Type_QuantityMetallic = 149;

        /// <remarks />
        public const uint Module1Type_QuantityNonMetallic = 156;

        /// <remarks />
        public const uint Module2Type_Barrier1 = 171;

        /// <remarks />
        public const uint Module2Type_Barrier2 = 178;

        /// <remarks />
        public const uint Module2Type_Barrier3 = 185;

        /// <remarks />
        public const uint Module2Type_PhotoSensor = 192;

        /// <remarks />
        public const uint Module2Type_Capacitive = 199;

        /// <remarks />
        public const uint Module2Type_Inductive = 206;

        /// <remarks />
        public const uint BeltType_IsAuto = 1051;

        /// <remarks />
        public const uint BeltType_IsModule1 = 1058;

        /// <remarks />
        public const uint BeltType_IsError = 1183;

        /// <remarks />
        public const uint BeltType_IsBusy = 1190;

        /// <remarks />
        public const uint BeltType_Motor = 1079;

        /// <remarks />
        public const uint BeltType_Module1 = 228;

        /// <remarks />
        public const uint BeltType_Module1_Transparent = 943;

        /// <remarks />
        public const uint BeltType_Module1_Metallic = 243;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic = 250;

        /// <remarks />
        public const uint BeltType_Module1_QuantityTransparent = 950;

        /// <remarks />
        public const uint BeltType_Module1_QuantityMetallic = 264;

        /// <remarks />
        public const uint BeltType_Module1_QuantityNonMetallic = 271;

        /// <remarks />
        public const uint BeltType_Module2 = 285;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1 = 286;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2 = 293;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3 = 300;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor = 307;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive = 314;

        /// <remarks />
        public const uint BeltType_Module2_Inductive = 321;

        /// <remarks />
        public const uint BeltServer = 345;

        /// <remarks />
        public const uint BeltServer_IsAuto = 1110;

        /// <remarks />
        public const uint BeltServer_IsModule1 = 1117;

        /// <remarks />
        public const uint BeltServer_IsError = 1197;

        /// <remarks />
        public const uint BeltServer_IsBusy = 1204;

        /// <remarks />
        public const uint BeltServer_Motor = 1138;

        /// <remarks />
        public const uint BeltServer_Module1 = 346;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent = 957;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic = 361;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic = 368;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityTransparent = 964;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityMetallic = 382;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityNonMetallic = 389;

        /// <remarks />
        public const uint BeltServer_Module2 = 403;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1 = 404;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2 = 411;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3 = 418;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor = 425;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive = 432;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive = 439;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericSensorType = 1;

        /// <remarks />
        public const uint GenericActuatorType = 8;

        /// <remarks />
        public const uint GenericDisplayType = 15;

        /// <remarks />
        public const uint GenericMotorType = 22;

        /// <remarks />
        public const uint IsAutoIlumination = 1025;

        /// <remarks />
        public const uint IsModule1Ilumination = 1032;

        /// <remarks />
        public const uint IsBusyIlumination = 1169;

        /// <remarks />
        public const uint IsErrorIlumination = 1176;

        /// <remarks />
        public const uint MotorType = 799;

        /// <remarks />
        public const uint TransparentPiece = 915;

        /// <remarks />
        public const uint MetallicPiece = 64;

        /// <remarks />
        public const uint NonMetallicPiece = 71;

        /// <remarks />
        public const uint QuantityTransparentPiece = 922;

        /// <remarks />
        public const uint QuantityMetallicPiece = 92;

        /// <remarks />
        public const uint QuantityNonMetallicPiece = 99;

        /// <remarks />
        public const uint OpticalBarrier = 29;

        /// <remarks />
        public const uint ElectricPhotoSensor = 36;

        /// <remarks />
        public const uint CapacitiveSensor = 43;

        /// <remarks />
        public const uint InductiveSensor = 50;

        /// <remarks />
        public const uint Module1Type = 113;

        /// <remarks />
        public const uint Module2Type = 170;

        /// <remarks />
        public const uint BeltType = 227;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericSensorType_Output = 2;

        /// <remarks />
        public const uint GenericActuatorType_Input = 9;

        /// <remarks />
        public const uint GenericDisplayType_Input = 16;

        /// <remarks />
        public const uint GenericDisplayType_Input_EURange = 20;

        /// <remarks />
        public const uint GenericMotorType_JourneyTime = 971;

        /// <remarks />
        public const uint GenericMotorType_JourneyTime_EURange = 975;

        /// <remarks />
        public const uint GenericMotorType_Interval = 1019;

        /// <remarks />
        public const uint GenericMotorType_Interval_EURange = 1023;

        /// <remarks />
        public const uint GenericMotorType_Status = 855;

        /// <remarks />
        public const uint MotorType_JourneyTime_EURange = 981;

        /// <remarks />
        public const uint MotorType_Interval_EURange = 1043;

        /// <remarks />
        public const uint QuantityTransparentPiece_Input_EURange = 927;

        /// <remarks />
        public const uint QuantityMetallicPiece_Input_EURange = 97;

        /// <remarks />
        public const uint QuantityNonMetallicPiece_Input_EURange = 104;

        /// <remarks />
        public const uint Module1Type_Transparent_Input = 930;

        /// <remarks />
        public const uint Module1Type_Metallic_Input = 129;

        /// <remarks />
        public const uint Module1Type_NonMetallic_Input = 136;

        /// <remarks />
        public const uint Module1Type_QuantityTransparent_Input = 937;

        /// <remarks />
        public const uint Module1Type_QuantityTransparent_Input_EURange = 941;

        /// <remarks />
        public const uint Module1Type_QuantityMetallic_Input = 150;

        /// <remarks />
        public const uint Module1Type_QuantityMetallic_Input_EURange = 154;

        /// <remarks />
        public const uint Module1Type_QuantityNonMetallic_Input = 157;

        /// <remarks />
        public const uint Module1Type_QuantityNonMetallic_Input_EURange = 161;

        /// <remarks />
        public const uint Module2Type_Barrier1_Output = 172;

        /// <remarks />
        public const uint Module2Type_Barrier2_Output = 179;

        /// <remarks />
        public const uint Module2Type_Barrier3_Output = 186;

        /// <remarks />
        public const uint Module2Type_PhotoSensor_Output = 193;

        /// <remarks />
        public const uint Module2Type_Capacitive_Output = 200;

        /// <remarks />
        public const uint Module2Type_Inductive_Output = 207;

        /// <remarks />
        public const uint BeltType_IsAuto_Input = 1052;

        /// <remarks />
        public const uint BeltType_IsModule1_Input = 1059;

        /// <remarks />
        public const uint BeltType_IsError_Input = 1184;

        /// <remarks />
        public const uint BeltType_IsBusy_Input = 1191;

        /// <remarks />
        public const uint BeltType_Motor_JourneyTime = 1080;

        /// <remarks />
        public const uint BeltType_Motor_JourneyTime_EURange = 1084;

        /// <remarks />
        public const uint BeltType_Motor_Interval = 1086;

        /// <remarks />
        public const uint BeltType_Motor_Interval_EURange = 1090;

        /// <remarks />
        public const uint BeltType_Motor_Status = 1092;

        /// <remarks />
        public const uint BeltType_Module1_Transparent_Input = 944;

        /// <remarks />
        public const uint BeltType_Module1_Metallic_Input = 244;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic_Input = 251;

        /// <remarks />
        public const uint BeltType_Module1_QuantityTransparent_Input = 951;

        /// <remarks />
        public const uint BeltType_Module1_QuantityTransparent_Input_EURange = 955;

        /// <remarks />
        public const uint BeltType_Module1_QuantityMetallic_Input = 265;

        /// <remarks />
        public const uint BeltType_Module1_QuantityMetallic_Input_EURange = 269;

        /// <remarks />
        public const uint BeltType_Module1_QuantityNonMetallic_Input = 272;

        /// <remarks />
        public const uint BeltType_Module1_QuantityNonMetallic_Input_EURange = 276;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1_Output = 287;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2_Output = 294;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3_Output = 301;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor_Output = 308;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive_Output = 315;

        /// <remarks />
        public const uint BeltType_Module2_Inductive_Output = 322;

        /// <remarks />
        public const uint BeltServer_IsAuto_Input = 1111;

        /// <remarks />
        public const uint BeltServer_IsModule1_Input = 1118;

        /// <remarks />
        public const uint BeltServer_IsError_Input = 1198;

        /// <remarks />
        public const uint BeltServer_IsBusy_Input = 1205;

        /// <remarks />
        public const uint BeltServer_Motor_JourneyTime = 1139;

        /// <remarks />
        public const uint BeltServer_Motor_JourneyTime_EURange = 1143;

        /// <remarks />
        public const uint BeltServer_Motor_Interval = 1145;

        /// <remarks />
        public const uint BeltServer_Motor_Interval_EURange = 1149;

        /// <remarks />
        public const uint BeltServer_Motor_Status = 1151;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent_Input = 958;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic_Input = 362;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic_Input = 369;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityTransparent_Input = 965;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityTransparent_Input_EURange = 969;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityMetallic_Input = 383;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityMetallic_Input_EURange = 387;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityNonMetallic_Input = 390;

        /// <remarks />
        public const uint BeltServer_Module1_QuantityNonMetallic_Input_EURange = 394;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1_Output = 405;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2_Output = 412;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3_Output = 419;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor_Output = 426;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive_Output = 433;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive_Output = 440;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StartProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StartProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StopProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StopProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_ResetProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_ResetProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_AddTransparentPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_AddTransparentPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_AddMetallicPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_AddMetallicPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_AddNonMetallicPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_AddNonMetallicPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StartProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StartProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StopProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StopProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_ResetProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_ResetProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_AddTransparentPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_AddTransparentPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_AddMetallicPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_AddMetallicPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_AddNonMetallicPieceProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_AddNonMetallicPieceProcess, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Transparent = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_Transparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Metallic = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_Metallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_NonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityTransparent = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_QuantityTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityMetallic = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_QuantityMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityNonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_QuantityNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier1 = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Barrier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier2 = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Barrier2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier3 = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Barrier3, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_PhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_PhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Capacitive = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Capacitive, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Inductive = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Inductive, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsAuto = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_IsAuto, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsModule1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_IsModule1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsError = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_IsError, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsBusy = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_IsBusy, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Transparent = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_Transparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Metallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_Metallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_NonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityTransparent = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_QuantityTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_QuantityMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityNonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_QuantityNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Barrier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier2 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Barrier2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier3 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Barrier3, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_PhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_PhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Capacitive = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Capacitive, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Inductive = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Inductive, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsAuto = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_IsAuto, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsModule1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_IsModule1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsError = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_IsError, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsBusy = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_IsBusy, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Transparent = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_Transparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Metallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_Metallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_NonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityTransparent = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_QuantityTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_QuantityMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityNonMetallic = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_QuantityNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Barrier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier2 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Barrier2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier3 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Barrier3, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_PhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_PhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Capacitive = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Capacitive, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Inductive = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Inductive, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.GenericSensorType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.GenericActuatorType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericDisplayType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.GenericDisplayType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.GenericMotorType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsAutoIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.IsAutoIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsModule1Ilumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.IsModule1Ilumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsBusyIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.IsBusyIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsErrorIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.IsErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.MotorType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.TransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.MetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.NonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityTransparentPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityTransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityNonMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityNonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier = new ExpandedNodeId(BeltIdentifier.ObjectTypes.OpticalBarrier, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.ElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId CapacitiveSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.CapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId InductiveSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.InductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type = new ExpandedNodeId(BeltIdentifier.ObjectTypes.Module1Type, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type = new ExpandedNodeId(BeltIdentifier.ObjectTypes.Module2Type, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.BeltType, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(BeltIdentifier.Variables.GenericSensorType_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericDisplayType_Input = new ExpandedNodeId(BeltIdentifier.Variables.GenericDisplayType_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericDisplayType_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericDisplayType_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Interval = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Interval, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Interval_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Interval_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Status = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MotorType_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Interval_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MotorType_Interval_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityTransparentPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityTransparentPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityMetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityMetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityNonMetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityNonMetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityTransparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityTransparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityTransparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityTransparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityNonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityNonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_QuantityNonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_QuantityNonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsAuto_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsAuto_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsModule1_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsModule1_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsError_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsError_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsBusy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsBusy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_Interval = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_Interval, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_Interval_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_Interval_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityTransparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityTransparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityTransparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityTransparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityNonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityNonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_QuantityNonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_QuantityNonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsAuto_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsAuto_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsModule1_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsModule1_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsError_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsError_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsBusy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsBusy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_Interval = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_Interval, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_Interval_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_Interval_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityTransparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityTransparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityTransparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityTransparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityNonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityNonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_QuantityNonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_QuantityNonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AddMetallicPieceProcess = "AddMetallicPieceProcess";

        /// <remarks />
        public const string AddNonMetallicPieceProcess = "AddNonMetallicPieceProcess";

        /// <remarks />
        public const string AddTransparentPieceProcess = "AddTransparentPieceProcess";

        /// <remarks />
        public const string Barrier1 = "Barrier1";

        /// <remarks />
        public const string Barrier2 = "Barrier2";

        /// <remarks />
        public const string Barrier3 = "Barrier3";

        /// <remarks />
        public const string BeltServer = "Belt Server #1";

        /// <remarks />
        public const string BeltType = "BeltType";

        /// <remarks />
        public const string Capacitive = "Capacitive";

        /// <remarks />
        public const string CapacitiveSensor = "CapacitiveSensor";

        /// <remarks />
        public const string ElectricPhotoSensor = "ElectricPhotoSensor";

        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";

        /// <remarks />
        public const string GenericDisplayType = "GenericDisplayType";

        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Inductive = "Inductive";

        /// <remarks />
        public const string InductiveSensor = "InductiveSensor";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string Interval = "Interval";

        /// <remarks />
        public const string IsAuto = "IsAuto";

        /// <remarks />
        public const string IsAutoIlumination = "IsAutoIlumination";

        /// <remarks />
        public const string IsBusy = "Busy";

        /// <remarks />
        public const string IsBusyIlumination = "IsBusyIlumination";

        /// <remarks />
        public const string IsError = "Error";

        /// <remarks />
        public const string IsErrorIlumination = "IsErrorIlumination";

        /// <remarks />
        public const string IsModule1 = "IsModule1";

        /// <remarks />
        public const string IsModule1Ilumination = "IsModule1Ilumination";

        /// <remarks />
        public const string JourneyTime = "JourneyTime";

        /// <remarks />
        public const string Metallic = "Metallic";

        /// <remarks />
        public const string MetallicPiece = "MetallicPiece";

        /// <remarks />
        public const string Module1 = "Belt Module 1";

        /// <remarks />
        public const string Module1Type = "Module1Type";

        /// <remarks />
        public const string Module2 = "Belt Module 2";

        /// <remarks />
        public const string Module2Type = "Module2Type";

        /// <remarks />
        public const string Motor = "Motor";

        /// <remarks />
        public const string MotorType = "MotorType";

        /// <remarks />
        public const string NonMetallic = "NonMetallic";

        /// <remarks />
        public const string NonMetallicPiece = "NonMetallicPiece";

        /// <remarks />
        public const string OpticalBarrier = "OpticalBarrier";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string PhotoSensor = "PhotoSensor";

        /// <remarks />
        public const string QuantityMetallic = "QuantityMetallic";

        /// <remarks />
        public const string QuantityMetallicPiece = "QuantityMetallicPiece";

        /// <remarks />
        public const string QuantityNonMetallic = "QuantityNonMetallic";

        /// <remarks />
        public const string QuantityNonMetallicPiece = "QuantityNonMetallicPiece";

        /// <remarks />
        public const string QuantityTransparent = "QuantityTransparent";

        /// <remarks />
        public const string QuantityTransparentPiece = "QuantityTransparentPiece";

        /// <remarks />
        public const string ResetProcess = "ResetProcess";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string StopProcess = "StopProcess";

        /// <remarks />
        public const string Transparent = "Transparent";

        /// <remarks />
        public const string TransparentPiece = "TransparentPiece";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the BeltIdentifier namespace (.NET code namespace is 'BeltIdentifier').
        /// </summary>
        public const string BeltIdentifier = "http://opcfoundation.org/BeltIdentifier";
    }
    #endregion
}