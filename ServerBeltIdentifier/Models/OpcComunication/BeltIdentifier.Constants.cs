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
        public const uint BeltType_StartModule1Process = 903;

        /// <remarks />
        public const uint BeltType_StopModule1Process = 904;

        /// <remarks />
        public const uint BeltType_ResetModule1Process = 905;

        /// <remarks />
        public const uint BeltType_StartModule2Process = 906;

        /// <remarks />
        public const uint BeltType_StopModule2Process = 907;

        /// <remarks />
        public const uint BeltType_ResetModule2Process = 908;

        /// <remarks />
        public const uint BeltServer_StartModule1Process = 909;

        /// <remarks />
        public const uint BeltServer_StopModule1Process = 910;

        /// <remarks />
        public const uint BeltServer_ResetModule1Process = 911;

        /// <remarks />
        public const uint BeltServer_StartModule2Process = 912;

        /// <remarks />
        public const uint BeltServer_StopModule2Process = 913;

        /// <remarks />
        public const uint BeltServer_ResetModule2Process = 914;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Module1Type_Error = 114;

        /// <remarks />
        public const uint Module1Type_Busy = 813;

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
        public const uint Module1Type_Motor = 163;

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
        public const uint Module2Type_Error = 213;

        /// <remarks />
        public const uint Module2Type_Busy = 820;

        /// <remarks />
        public const uint Module2Type_Motor = 220;

        /// <remarks />
        public const uint BeltType_Module1 = 228;

        /// <remarks />
        public const uint BeltType_Module1_Error = 229;

        /// <remarks />
        public const uint BeltType_Module1_Busy = 827;

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
        public const uint BeltType_Module1_Motor = 278;

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
        public const uint BeltType_Module2_Error = 328;

        /// <remarks />
        public const uint BeltType_Module2_Busy = 834;

        /// <remarks />
        public const uint BeltType_Module2_Motor = 335;

        /// <remarks />
        public const uint BeltServer = 345;

        /// <remarks />
        public const uint BeltServer_Module1 = 346;

        /// <remarks />
        public const uint BeltServer_Module1_Error = 347;

        /// <remarks />
        public const uint BeltServer_Module1_Busy = 841;

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
        public const uint BeltServer_Module1_Motor = 396;

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

        /// <remarks />
        public const uint BeltServer_Module2_Error = 446;

        /// <remarks />
        public const uint BeltServer_Module2_Busy = 848;

        /// <remarks />
        public const uint BeltServer_Module2_Motor = 453;
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
        public const uint OpticalBarrier = 29;

        /// <remarks />
        public const uint ElectricPhotoSensor = 36;

        /// <remarks />
        public const uint CapacitiveSensor = 43;

        /// <remarks />
        public const uint InductiveSensor = 50;

        /// <remarks />
        public const uint TransparentPiece = 915;

        /// <remarks />
        public const uint MetallicPiece = 64;

        /// <remarks />
        public const uint NonMetallicPiece = 71;

        /// <remarks />
        public const uint ErrorIlumination = 78;

        /// <remarks />
        public const uint BusyIlumination = 806;

        /// <remarks />
        public const uint QuantityTransparentPiece = 922;

        /// <remarks />
        public const uint QuantityMetallicPiece = 92;

        /// <remarks />
        public const uint QuantityNonMetallicPiece = 99;

        /// <remarks />
        public const uint MotorType = 799;

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
        public const uint GenericSensorType_Output_EURange = 6;

        /// <remarks />
        public const uint GenericActuatorType_Input = 9;

        /// <remarks />
        public const uint GenericActuatorType_Input_EURange = 13;

        /// <remarks />
        public const uint GenericDisplayType_Input = 16;

        /// <remarks />
        public const uint GenericDisplayType_Input_EURange = 20;

        /// <remarks />
        public const uint GenericMotorType_JourneyTime = 971;

        /// <remarks />
        public const uint GenericMotorType_JourneyTime_EURange = 975;

        /// <remarks />
        public const uint GenericMotorType_Status = 855;

        /// <remarks />
        public const uint GenericMotorType_Status_EURange = 859;

        /// <remarks />
        public const uint OpticalBarrier_Output_EURange = 34;

        /// <remarks />
        public const uint ElectricPhotoSensor_Output_EURange = 41;

        /// <remarks />
        public const uint CapacitiveSensor_Output_EURange = 48;

        /// <remarks />
        public const uint InductiveSensor_Output_EURange = 55;

        /// <remarks />
        public const uint TransparentPiece_Input_EURange = 920;

        /// <remarks />
        public const uint MetallicPiece_Input_EURange = 69;

        /// <remarks />
        public const uint NonMetallicPiece_Input_EURange = 76;

        /// <remarks />
        public const uint ErrorIlumination_Input_EURange = 83;

        /// <remarks />
        public const uint BusyIlumination_Input_EURange = 811;

        /// <remarks />
        public const uint QuantityTransparentPiece_Input_EURange = 927;

        /// <remarks />
        public const uint QuantityMetallicPiece_Input_EURange = 97;

        /// <remarks />
        public const uint QuantityNonMetallicPiece_Input_EURange = 104;

        /// <remarks />
        public const uint MotorType_JourneyTime_EURange = 981;

        /// <remarks />
        public const uint MotorType_Status_EURange = 865;

        /// <remarks />
        public const uint Module1Type_Error_Input = 115;

        /// <remarks />
        public const uint Module1Type_Error_Input_EURange = 119;

        /// <remarks />
        public const uint Module1Type_Busy_Input = 814;

        /// <remarks />
        public const uint Module1Type_Busy_Input_EURange = 818;

        /// <remarks />
        public const uint Module1Type_Transparent_Input = 930;

        /// <remarks />
        public const uint Module1Type_Transparent_Input_EURange = 934;

        /// <remarks />
        public const uint Module1Type_Metallic_Input = 129;

        /// <remarks />
        public const uint Module1Type_Metallic_Input_EURange = 133;

        /// <remarks />
        public const uint Module1Type_NonMetallic_Input = 136;

        /// <remarks />
        public const uint Module1Type_NonMetallic_Input_EURange = 140;

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
        public const uint Module1Type_Motor_JourneyTime = 983;

        /// <remarks />
        public const uint Module1Type_Motor_JourneyTime_EURange = 987;

        /// <remarks />
        public const uint Module1Type_Motor_Status = 867;

        /// <remarks />
        public const uint Module1Type_Motor_Status_EURange = 871;

        /// <remarks />
        public const uint Module2Type_Barrier1_Output = 172;

        /// <remarks />
        public const uint Module2Type_Barrier1_Output_EURange = 176;

        /// <remarks />
        public const uint Module2Type_Barrier2_Output = 179;

        /// <remarks />
        public const uint Module2Type_Barrier2_Output_EURange = 183;

        /// <remarks />
        public const uint Module2Type_Barrier3_Output = 186;

        /// <remarks />
        public const uint Module2Type_Barrier3_Output_EURange = 190;

        /// <remarks />
        public const uint Module2Type_PhotoSensor_Output = 193;

        /// <remarks />
        public const uint Module2Type_PhotoSensor_Output_EURange = 197;

        /// <remarks />
        public const uint Module2Type_Capacitive_Output = 200;

        /// <remarks />
        public const uint Module2Type_Capacitive_Output_EURange = 204;

        /// <remarks />
        public const uint Module2Type_Inductive_Output = 207;

        /// <remarks />
        public const uint Module2Type_Inductive_Output_EURange = 211;

        /// <remarks />
        public const uint Module2Type_Error_Input = 214;

        /// <remarks />
        public const uint Module2Type_Error_Input_EURange = 218;

        /// <remarks />
        public const uint Module2Type_Busy_Input = 821;

        /// <remarks />
        public const uint Module2Type_Busy_Input_EURange = 825;

        /// <remarks />
        public const uint Module2Type_Motor_JourneyTime = 989;

        /// <remarks />
        public const uint Module2Type_Motor_JourneyTime_EURange = 993;

        /// <remarks />
        public const uint Module2Type_Motor_Status = 873;

        /// <remarks />
        public const uint Module2Type_Motor_Status_EURange = 877;

        /// <remarks />
        public const uint BeltType_Module1_Error_Input = 230;

        /// <remarks />
        public const uint BeltType_Module1_Error_Input_EURange = 234;

        /// <remarks />
        public const uint BeltType_Module1_Busy_Input = 828;

        /// <remarks />
        public const uint BeltType_Module1_Busy_Input_EURange = 832;

        /// <remarks />
        public const uint BeltType_Module1_Transparent_Input = 944;

        /// <remarks />
        public const uint BeltType_Module1_Transparent_Input_EURange = 948;

        /// <remarks />
        public const uint BeltType_Module1_Metallic_Input = 244;

        /// <remarks />
        public const uint BeltType_Module1_Metallic_Input_EURange = 248;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic_Input = 251;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic_Input_EURange = 255;

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
        public const uint BeltType_Module1_Motor_JourneyTime = 995;

        /// <remarks />
        public const uint BeltType_Module1_Motor_JourneyTime_EURange = 999;

        /// <remarks />
        public const uint BeltType_Module1_Motor_Status = 879;

        /// <remarks />
        public const uint BeltType_Module1_Motor_Status_EURange = 883;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1_Output = 287;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1_Output_EURange = 291;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2_Output = 294;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2_Output_EURange = 298;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3_Output = 301;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3_Output_EURange = 305;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor_Output = 308;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor_Output_EURange = 312;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive_Output = 315;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive_Output_EURange = 319;

        /// <remarks />
        public const uint BeltType_Module2_Inductive_Output = 322;

        /// <remarks />
        public const uint BeltType_Module2_Inductive_Output_EURange = 326;

        /// <remarks />
        public const uint BeltType_Module2_Error_Input = 329;

        /// <remarks />
        public const uint BeltType_Module2_Error_Input_EURange = 333;

        /// <remarks />
        public const uint BeltType_Module2_Busy_Input = 835;

        /// <remarks />
        public const uint BeltType_Module2_Busy_Input_EURange = 839;

        /// <remarks />
        public const uint BeltType_Module2_Motor_JourneyTime = 1001;

        /// <remarks />
        public const uint BeltType_Module2_Motor_JourneyTime_EURange = 1005;

        /// <remarks />
        public const uint BeltType_Module2_Motor_Status = 885;

        /// <remarks />
        public const uint BeltType_Module2_Motor_Status_EURange = 889;

        /// <remarks />
        public const uint BeltServer_Module1_Error_Input = 348;

        /// <remarks />
        public const uint BeltServer_Module1_Error_Input_EURange = 352;

        /// <remarks />
        public const uint BeltServer_Module1_Busy_Input = 842;

        /// <remarks />
        public const uint BeltServer_Module1_Busy_Input_EURange = 846;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent_Input = 958;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent_Input_EURange = 962;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic_Input = 362;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic_Input_EURange = 366;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic_Input = 369;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic_Input_EURange = 373;

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
        public const uint BeltServer_Module1_Motor_JourneyTime = 1007;

        /// <remarks />
        public const uint BeltServer_Module1_Motor_JourneyTime_EURange = 1011;

        /// <remarks />
        public const uint BeltServer_Module1_Motor_Status = 891;

        /// <remarks />
        public const uint BeltServer_Module1_Motor_Status_EURange = 895;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1_Output = 405;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1_Output_EURange = 409;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2_Output = 412;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2_Output_EURange = 416;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3_Output = 419;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3_Output_EURange = 423;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor_Output = 426;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor_Output_EURange = 430;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive_Output = 433;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive_Output_EURange = 437;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive_Output = 440;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive_Output_EURange = 444;

        /// <remarks />
        public const uint BeltServer_Module2_Error_Input = 447;

        /// <remarks />
        public const uint BeltServer_Module2_Error_Input_EURange = 451;

        /// <remarks />
        public const uint BeltServer_Module2_Busy_Input = 849;

        /// <remarks />
        public const uint BeltServer_Module2_Busy_Input_EURange = 853;

        /// <remarks />
        public const uint BeltServer_Module2_Motor_JourneyTime = 1013;

        /// <remarks />
        public const uint BeltServer_Module2_Motor_JourneyTime_EURange = 1017;

        /// <remarks />
        public const uint BeltServer_Module2_Motor_Status = 897;

        /// <remarks />
        public const uint BeltServer_Module2_Motor_Status_EURange = 901;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StartModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StartModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StopModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StopModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_ResetModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_ResetModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StartModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StartModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StopModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_StopModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_ResetModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltType_ResetModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StartModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StartModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StopModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StopModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_ResetModule1Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_ResetModule1Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StartModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StartModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StopModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StopModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_ResetModule2Process = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_ResetModule2Process, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Error = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Busy = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId Module1Type_Motor = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId Module2Type_Error = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Busy = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Motor = new ExpandedNodeId(BeltIdentifier.Objects.Module2Type_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Error = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Busy = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltType_Module1_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltType_Module2_Error = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Busy = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module2_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Error = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Busy = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltServer_Module1_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_Motor, BeltIdentifier.Namespaces.BeltIdentifier);

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

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Error = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Error, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Busy = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Busy, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module2_Motor, BeltIdentifier.Namespaces.BeltIdentifier);
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
        public static readonly ExpandedNodeId OpticalBarrier = new ExpandedNodeId(BeltIdentifier.ObjectTypes.OpticalBarrier, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.ElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId CapacitiveSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.CapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId InductiveSensor = new ExpandedNodeId(BeltIdentifier.ObjectTypes.InductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.TransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.MetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.NonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ErrorIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.ErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BusyIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.BusyIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityTransparentPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityTransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityNonMetallicPiece = new ExpandedNodeId(BeltIdentifier.ObjectTypes.QuantityNonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.MotorType, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericSensorType_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericDisplayType_Input = new ExpandedNodeId(BeltIdentifier.Variables.GenericDisplayType_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericDisplayType_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericDisplayType_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Status = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.OpticalBarrier_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.ElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId CapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.CapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId InductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.InductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.TransparentPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.NonMetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.ErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BusyIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BusyIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityTransparentPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityTransparentPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityMetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityMetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId QuantityNonMetallicPiece_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.QuantityNonMetallicPiece_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MotorType_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MotorType_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Transparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Transparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Metallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Metallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId Module1Type_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier1_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier1_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier2_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier2_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier3_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier3_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_PhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_PhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Capacitive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Capacitive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Inductive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Inductive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Transparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Transparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Metallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Metallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltType_Module1_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier1_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier1_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier2_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier2_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier3_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier3_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_PhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_PhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Capacitive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Capacitive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Inductive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Inductive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Transparent_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Transparent_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Transparent_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Transparent_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Metallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Metallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Metallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Metallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallic_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallic_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallic_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallic_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltServer_Module1_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier1_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier1_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier1_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier1_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier2_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier2_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier2_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier2_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier3_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier3_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier3_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier3_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_PhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_PhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_PhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_PhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Capacitive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Capacitive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Capacitive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Capacitive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Inductive_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Inductive_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Inductive_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Inductive_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Error_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Error_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Error_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Error_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Busy_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Busy_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Busy_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Busy_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Motor_JourneyTime = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Motor_JourneyTime, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Motor_JourneyTime_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Motor_JourneyTime_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Motor_Status = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Motor_Status, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Motor_Status_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Motor_Status_EURange, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
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
        public const string Busy = "Busy";

        /// <remarks />
        public const string BusyIlumination = "BusyIlumination";

        /// <remarks />
        public const string Capacitive = "Capacitive";

        /// <remarks />
        public const string CapacitiveSensor = "CapacitiveSensor";

        /// <remarks />
        public const string ElectricPhotoSensor = "ElectricPhotoSensor";

        /// <remarks />
        public const string Error = "Error";

        /// <remarks />
        public const string ErrorIlumination = "ErrorIlumination";

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
        public const string ResetModule1Process = "ResetModule1Process";

        /// <remarks />
        public const string ResetModule2Process = "ResetModule2Process";

        /// <remarks />
        public const string StartModule1Process = "StartModule1Process";

        /// <remarks />
        public const string StartModule2Process = "StartModule2Process";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string StopModule1Process = "StopModule1Process";

        /// <remarks />
        public const string StopModule2Process = "StopModule2Process";

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