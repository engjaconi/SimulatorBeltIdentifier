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
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Module1Type_Transparent = 87;

        /// <remarks />
        public const uint Module1Type_Metallic = 91;

        /// <remarks />
        public const uint Module1Type_NonMetallic = 95;

        /// <remarks />
        public const uint Module1Type_TransparentQuantity = 339;

        /// <remarks />
        public const uint Module1Type_MetallicQuantity = 346;

        /// <remarks />
        public const uint Module1Type_NonMetallicQuantity = 353;

        /// <remarks />
        public const uint Module2Type_Barrier1 = 121;

        /// <remarks />
        public const uint Module2Type_Barrier2 = 125;

        /// <remarks />
        public const uint Module2Type_Barrier3 = 129;

        /// <remarks />
        public const uint Module2Type_PhotoSensor = 133;

        /// <remarks />
        public const uint Module2Type_Capacitive = 137;

        /// <remarks />
        public const uint Module2Type_Inductive = 141;

        /// <remarks />
        public const uint BeltType_StartButton = 146;

        /// <remarks />
        public const uint BeltType_ResetButton = 150;

        /// <remarks />
        public const uint BeltType_IsAuto = 154;

        /// <remarks />
        public const uint BeltType_IsModule1 = 158;

        /// <remarks />
        public const uint BeltType_IsError = 162;

        /// <remarks />
        public const uint BeltType_IsBusy = 166;

        /// <remarks />
        public const uint BeltType_Motor = 170;

        /// <remarks />
        public const uint BeltType_Module1 = 174;

        /// <remarks />
        public const uint BeltType_Module1_Transparent = 175;

        /// <remarks />
        public const uint BeltType_Module1_Metallic = 179;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic = 183;

        /// <remarks />
        public const uint BeltType_Module1_TransparentQuantity = 360;

        /// <remarks />
        public const uint BeltType_Module1_MetallicQuantity = 367;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallicQuantity = 374;

        /// <remarks />
        public const uint BeltType_Module2 = 208;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1 = 209;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2 = 213;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3 = 217;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor = 221;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive = 225;

        /// <remarks />
        public const uint BeltType_Module2_Inductive = 229;

        /// <remarks />
        public const uint BeltServer = 233;

        /// <remarks />
        public const uint BeltServer_StartButton = 234;

        /// <remarks />
        public const uint BeltServer_ResetButton = 238;

        /// <remarks />
        public const uint BeltServer_IsAuto = 242;

        /// <remarks />
        public const uint BeltServer_IsModule1 = 246;

        /// <remarks />
        public const uint BeltServer_IsError = 250;

        /// <remarks />
        public const uint BeltServer_IsBusy = 254;

        /// <remarks />
        public const uint BeltServer_Motor = 258;

        /// <remarks />
        public const uint BeltServer_Module1 = 262;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent = 263;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic = 267;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic = 271;

        /// <remarks />
        public const uint BeltServer_Module1_TransparentQuantity = 381;

        /// <remarks />
        public const uint BeltServer_Module1_MetallicQuantity = 388;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallicQuantity = 395;

        /// <remarks />
        public const uint BeltServer_Module2 = 296;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1 = 297;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2 = 301;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3 = 305;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor = 309;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive = 313;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive = 317;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint StartButtonType = 1;

        /// <remarks />
        public const uint ResetButtonType = 5;

        /// <remarks />
        public const uint IsAutoIlumination = 9;

        /// <remarks />
        public const uint IsModule1Ilumination = 13;

        /// <remarks />
        public const uint IsBusyIlumination = 17;

        /// <remarks />
        public const uint IsErrorIlumination = 21;

        /// <remarks />
        public const uint MotorType = 25;

        /// <remarks />
        public const uint TransparentPiece = 29;

        /// <remarks />
        public const uint MetallicPiece = 33;

        /// <remarks />
        public const uint NonMetallicPiece = 37;

        /// <remarks />
        public const uint TransparentPieceQuantity = 41;

        /// <remarks />
        public const uint MetallicPieceQuantity = 48;

        /// <remarks />
        public const uint NonMetallicPieceQuantity = 55;

        /// <remarks />
        public const uint OpticalBarrier1 = 62;

        /// <remarks />
        public const uint OpticalBarrier2 = 66;

        /// <remarks />
        public const uint OpticalBarrier3 = 70;

        /// <remarks />
        public const uint ElectricPhotoSensor = 74;

        /// <remarks />
        public const uint CapacitiveSensor = 78;

        /// <remarks />
        public const uint InductiveSensor = 82;

        /// <remarks />
        public const uint Module1Type = 86;

        /// <remarks />
        public const uint Module2Type = 120;

        /// <remarks />
        public const uint BeltType = 145;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint StartButtonType_Started = 2;

        /// <remarks />
        public const uint ResetButtonType_Reseted = 6;

        /// <remarks />
        public const uint IsAutoIlumination_IsAutoOn = 10;

        /// <remarks />
        public const uint IsModule1Ilumination_IsModule1On = 14;

        /// <remarks />
        public const uint IsBusyIlumination_IsBusyOn = 18;

        /// <remarks />
        public const uint IsErrorIlumination_IsErrorOn = 22;

        /// <remarks />
        public const uint MotorType_MotorOn = 26;

        /// <remarks />
        public const uint TransparentPiece_IsTransparent = 30;

        /// <remarks />
        public const uint MetallicPiece_IsMetallic = 34;

        /// <remarks />
        public const uint NonMetallicPiece_IsNonMetallic = 38;

        /// <remarks />
        public const uint TransparentPieceQuantity_TransparentQty = 321;

        /// <remarks />
        public const uint TransparentPieceQuantity_TransparentQty_EURange = 325;

        /// <remarks />
        public const uint MetallicPieceQuantity_MetallicQty = 327;

        /// <remarks />
        public const uint MetallicPieceQuantity_MetallicQty_EURange = 331;

        /// <remarks />
        public const uint NonMetallicPieceQuantity_NonMetallicQty = 333;

        /// <remarks />
        public const uint NonMetallicPieceQuantity_NonMetallicQty_EURange = 337;

        /// <remarks />
        public const uint OpticalBarrier1_Barrier1On = 63;

        /// <remarks />
        public const uint OpticalBarrier2_Barrier2On = 67;

        /// <remarks />
        public const uint OpticalBarrier3_Barrier3On = 71;

        /// <remarks />
        public const uint ElectricPhotoSensor_PhotoSensorOn = 75;

        /// <remarks />
        public const uint CapacitiveSensor_CapacitiveOn = 79;

        /// <remarks />
        public const uint InductiveSensor_InductiveOn = 83;

        /// <remarks />
        public const uint Module1Type_Transparent_IsTransparent = 88;

        /// <remarks />
        public const uint Module1Type_Metallic_IsMetallic = 92;

        /// <remarks />
        public const uint Module1Type_NonMetallic_IsNonMetallic = 96;

        /// <remarks />
        public const uint Module1Type_TransparentQuantity_TransparentQty = 340;

        /// <remarks />
        public const uint Module1Type_TransparentQuantity_TransparentQty_EURange = 344;

        /// <remarks />
        public const uint Module1Type_MetallicQuantity_MetallicQty = 347;

        /// <remarks />
        public const uint Module1Type_MetallicQuantity_MetallicQty_EURange = 351;

        /// <remarks />
        public const uint Module1Type_NonMetallicQuantity_NonMetallicQty = 354;

        /// <remarks />
        public const uint Module1Type_NonMetallicQuantity_NonMetallicQty_EURange = 358;

        /// <remarks />
        public const uint Module2Type_Barrier1_Barrier1On = 122;

        /// <remarks />
        public const uint Module2Type_Barrier2_Barrier2On = 126;

        /// <remarks />
        public const uint Module2Type_Barrier3_Barrier3On = 130;

        /// <remarks />
        public const uint Module2Type_PhotoSensor_PhotoSensorOn = 134;

        /// <remarks />
        public const uint Module2Type_Capacitive_CapacitiveOn = 138;

        /// <remarks />
        public const uint Module2Type_Inductive_InductiveOn = 142;

        /// <remarks />
        public const uint BeltType_StartButton_Started = 147;

        /// <remarks />
        public const uint BeltType_ResetButton_Reseted = 151;

        /// <remarks />
        public const uint BeltType_IsAuto_IsAutoOn = 155;

        /// <remarks />
        public const uint BeltType_IsModule1_IsModule1On = 159;

        /// <remarks />
        public const uint BeltType_IsError_IsErrorOn = 163;

        /// <remarks />
        public const uint BeltType_IsBusy_IsBusyOn = 167;

        /// <remarks />
        public const uint BeltType_Motor_MotorOn = 171;

        /// <remarks />
        public const uint BeltType_Module1_Transparent_IsTransparent = 176;

        /// <remarks />
        public const uint BeltType_Module1_Metallic_IsMetallic = 180;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallic_IsNonMetallic = 184;

        /// <remarks />
        public const uint BeltType_Module1_TransparentQuantity_TransparentQty = 361;

        /// <remarks />
        public const uint BeltType_Module1_TransparentQuantity_TransparentQty_EURange = 365;

        /// <remarks />
        public const uint BeltType_Module1_MetallicQuantity_MetallicQty = 368;

        /// <remarks />
        public const uint BeltType_Module1_MetallicQuantity_MetallicQty_EURange = 372;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallicQuantity_NonMetallicQty = 375;

        /// <remarks />
        public const uint BeltType_Module1_NonMetallicQuantity_NonMetallicQty_EURange = 379;

        /// <remarks />
        public const uint BeltType_Module2_Barrier1_Barrier1On = 210;

        /// <remarks />
        public const uint BeltType_Module2_Barrier2_Barrier2On = 214;

        /// <remarks />
        public const uint BeltType_Module2_Barrier3_Barrier3On = 218;

        /// <remarks />
        public const uint BeltType_Module2_PhotoSensor_PhotoSensorOn = 222;

        /// <remarks />
        public const uint BeltType_Module2_Capacitive_CapacitiveOn = 226;

        /// <remarks />
        public const uint BeltType_Module2_Inductive_InductiveOn = 230;

        /// <remarks />
        public const uint BeltServer_StartButton_Started = 235;

        /// <remarks />
        public const uint BeltServer_ResetButton_Reseted = 239;

        /// <remarks />
        public const uint BeltServer_IsAuto_IsAutoOn = 243;

        /// <remarks />
        public const uint BeltServer_IsModule1_IsModule1On = 247;

        /// <remarks />
        public const uint BeltServer_IsError_IsErrorOn = 251;

        /// <remarks />
        public const uint BeltServer_IsBusy_IsBusyOn = 255;

        /// <remarks />
        public const uint BeltServer_Motor_MotorOn = 259;

        /// <remarks />
        public const uint BeltServer_Module1_Transparent_IsTransparent = 264;

        /// <remarks />
        public const uint BeltServer_Module1_Metallic_IsMetallic = 268;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallic_IsNonMetallic = 272;

        /// <remarks />
        public const uint BeltServer_Module1_TransparentQuantity_TransparentQty = 382;

        /// <remarks />
        public const uint BeltServer_Module1_TransparentQuantity_TransparentQty_EURange = 386;

        /// <remarks />
        public const uint BeltServer_Module1_MetallicQuantity_MetallicQty = 389;

        /// <remarks />
        public const uint BeltServer_Module1_MetallicQuantity_MetallicQty_EURange = 393;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallicQuantity_NonMetallicQty = 396;

        /// <remarks />
        public const uint BeltServer_Module1_NonMetallicQuantity_NonMetallicQty_EURange = 400;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier1_Barrier1On = 298;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier2_Barrier2On = 302;

        /// <remarks />
        public const uint BeltServer_Module2_Barrier3_Barrier3On = 306;

        /// <remarks />
        public const uint BeltServer_Module2_PhotoSensor_PhotoSensorOn = 310;

        /// <remarks />
        public const uint BeltServer_Module2_Capacitive_CapacitiveOn = 314;

        /// <remarks />
        public const uint BeltServer_Module2_Inductive_InductiveOn = 318;
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
        public static readonly ExpandedNodeId Module1Type_TransparentQuantity = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_TransparentQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_MetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_MetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.Module1Type_NonMetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltType_StartButton = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_StartButton, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_ResetButton = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_ResetButton, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltType_Module1_TransparentQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_TransparentQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_MetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_MetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_Module1_NonMetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltServer_StartButton = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_StartButton, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_ResetButton = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_ResetButton, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltServer_Module1_TransparentQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_TransparentQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_MetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_MetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallicQuantity = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_Module1_NonMetallicQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId StartButtonType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.StartButtonType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ResetButtonType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.ResetButtonType, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId TransparentPieceQuantity = new ExpandedNodeId(BeltIdentifier.ObjectTypes.TransparentPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPieceQuantity = new ExpandedNodeId(BeltIdentifier.ObjectTypes.MetallicPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPieceQuantity = new ExpandedNodeId(BeltIdentifier.ObjectTypes.NonMetallicPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier1 = new ExpandedNodeId(BeltIdentifier.ObjectTypes.OpticalBarrier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier2 = new ExpandedNodeId(BeltIdentifier.ObjectTypes.OpticalBarrier2, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier3 = new ExpandedNodeId(BeltIdentifier.ObjectTypes.OpticalBarrier3, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId StartButtonType_Started = new ExpandedNodeId(BeltIdentifier.Variables.StartButtonType_Started, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ResetButtonType_Reseted = new ExpandedNodeId(BeltIdentifier.Variables.ResetButtonType_Reseted, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsAutoIlumination_IsAutoOn = new ExpandedNodeId(BeltIdentifier.Variables.IsAutoIlumination_IsAutoOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsModule1Ilumination_IsModule1On = new ExpandedNodeId(BeltIdentifier.Variables.IsModule1Ilumination_IsModule1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsBusyIlumination_IsBusyOn = new ExpandedNodeId(BeltIdentifier.Variables.IsBusyIlumination_IsBusyOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IsErrorIlumination_IsErrorOn = new ExpandedNodeId(BeltIdentifier.Variables.IsErrorIlumination_IsErrorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_MotorOn = new ExpandedNodeId(BeltIdentifier.Variables.MotorType_MotorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPiece_IsTransparent = new ExpandedNodeId(BeltIdentifier.Variables.TransparentPiece_IsTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPiece_IsMetallic = new ExpandedNodeId(BeltIdentifier.Variables.MetallicPiece_IsMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPiece_IsNonMetallic = new ExpandedNodeId(BeltIdentifier.Variables.NonMetallicPiece_IsNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPieceQuantity_TransparentQty = new ExpandedNodeId(BeltIdentifier.Variables.TransparentPieceQuantity_TransparentQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId TransparentPieceQuantity_TransparentQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.TransparentPieceQuantity_TransparentQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPieceQuantity_MetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.MetallicPieceQuantity_MetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId MetallicPieceQuantity_MetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.MetallicPieceQuantity_MetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPieceQuantity_NonMetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.NonMetallicPieceQuantity_NonMetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId NonMetallicPieceQuantity_NonMetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.NonMetallicPieceQuantity_NonMetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier1_Barrier1On = new ExpandedNodeId(BeltIdentifier.Variables.OpticalBarrier1_Barrier1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier2_Barrier2On = new ExpandedNodeId(BeltIdentifier.Variables.OpticalBarrier2_Barrier2On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier3_Barrier3On = new ExpandedNodeId(BeltIdentifier.Variables.OpticalBarrier3_Barrier3On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricPhotoSensor_PhotoSensorOn = new ExpandedNodeId(BeltIdentifier.Variables.ElectricPhotoSensor_PhotoSensorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId CapacitiveSensor_CapacitiveOn = new ExpandedNodeId(BeltIdentifier.Variables.CapacitiveSensor_CapacitiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId InductiveSensor_InductiveOn = new ExpandedNodeId(BeltIdentifier.Variables.InductiveSensor_InductiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Transparent_IsTransparent = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Transparent_IsTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_Metallic_IsMetallic = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_Metallic_IsMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallic_IsNonMetallic = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallic_IsNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_TransparentQuantity_TransparentQty = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_TransparentQuantity_TransparentQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_TransparentQuantity_TransparentQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_TransparentQuantity_TransparentQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_MetallicQuantity_MetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_MetallicQuantity_MetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_MetallicQuantity_MetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_MetallicQuantity_MetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallicQuantity_NonMetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallicQuantity_NonMetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module1Type_NonMetallicQuantity_NonMetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.Module1Type_NonMetallicQuantity_NonMetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier1_Barrier1On = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier1_Barrier1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier2_Barrier2On = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier2_Barrier2On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Barrier3_Barrier3On = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Barrier3_Barrier3On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_PhotoSensor_PhotoSensorOn = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_PhotoSensor_PhotoSensorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Capacitive_CapacitiveOn = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Capacitive_CapacitiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId Module2Type_Inductive_InductiveOn = new ExpandedNodeId(BeltIdentifier.Variables.Module2Type_Inductive_InductiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_StartButton_Started = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_StartButton_Started, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_ResetButton_Reseted = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_ResetButton_Reseted, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsAuto_IsAutoOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsAuto_IsAutoOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsModule1_IsModule1On = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsModule1_IsModule1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsError_IsErrorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsError_IsErrorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_IsBusy_IsBusyOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_IsBusy_IsBusyOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Motor_MotorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Motor_MotorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Transparent_IsTransparent = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Transparent_IsTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_Metallic_IsMetallic = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_Metallic_IsMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallic_IsNonMetallic = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallic_IsNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_TransparentQuantity_TransparentQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_TransparentQuantity_TransparentQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_TransparentQuantity_TransparentQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_TransparentQuantity_TransparentQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_MetallicQuantity_MetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_MetallicQuantity_MetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_MetallicQuantity_MetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_MetallicQuantity_MetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallicQuantity_NonMetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallicQuantity_NonMetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module1_NonMetallicQuantity_NonMetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module1_NonMetallicQuantity_NonMetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier1_Barrier1On = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier1_Barrier1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier2_Barrier2On = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier2_Barrier2On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Barrier3_Barrier3On = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Barrier3_Barrier3On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_PhotoSensor_PhotoSensorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_PhotoSensor_PhotoSensorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Capacitive_CapacitiveOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Capacitive_CapacitiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_Module2_Inductive_InductiveOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_Module2_Inductive_InductiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StartButton_Started = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_StartButton_Started, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_ResetButton_Reseted = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_ResetButton_Reseted, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsAuto_IsAutoOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsAuto_IsAutoOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsModule1_IsModule1On = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsModule1_IsModule1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsError_IsErrorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsError_IsErrorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_IsBusy_IsBusyOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_IsBusy_IsBusyOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Motor_MotorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Motor_MotorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Transparent_IsTransparent = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Transparent_IsTransparent, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_Metallic_IsMetallic = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_Metallic_IsMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallic_IsNonMetallic = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallic_IsNonMetallic, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_TransparentQuantity_TransparentQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_TransparentQuantity_TransparentQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_TransparentQuantity_TransparentQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_TransparentQuantity_TransparentQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_MetallicQuantity_MetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_MetallicQuantity_MetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_MetallicQuantity_MetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_MetallicQuantity_MetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallicQuantity_NonMetallicQty = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallicQuantity_NonMetallicQty, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module1_NonMetallicQuantity_NonMetallicQty_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module1_NonMetallicQuantity_NonMetallicQty_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier1_Barrier1On = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier1_Barrier1On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier2_Barrier2On = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier2_Barrier2On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Barrier3_Barrier3On = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Barrier3_Barrier3On, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_PhotoSensor_PhotoSensorOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_PhotoSensor_PhotoSensorOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Capacitive_CapacitiveOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Capacitive_CapacitiveOn, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_Module2_Inductive_InductiveOn = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_Module2_Inductive_InductiveOn, BeltIdentifier.Namespaces.BeltIdentifier);
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
        public const string Barrier1On = "Barrier1On";

        /// <remarks />
        public const string Barrier2 = "Barrier2";

        /// <remarks />
        public const string Barrier2On = "Barrier2On";

        /// <remarks />
        public const string Barrier3 = "Barrier3";

        /// <remarks />
        public const string Barrier3On = "Barrier3On";

        /// <remarks />
        public const string BeltServer = "Belt Server #1";

        /// <remarks />
        public const string BeltType = "BeltType";

        /// <remarks />
        public const string Capacitive = "Capacitive";

        /// <remarks />
        public const string CapacitiveOn = "CapacitiveOn";

        /// <remarks />
        public const string CapacitiveSensor = "CapacitiveSensor";

        /// <remarks />
        public const string ElectricPhotoSensor = "ElectricPhotoSensor";

        /// <remarks />
        public const string Inductive = "Inductive";

        /// <remarks />
        public const string InductiveOn = "InductiveOn";

        /// <remarks />
        public const string InductiveSensor = "InductiveSensor";

        /// <remarks />
        public const string IsAuto = "IsAuto";

        /// <remarks />
        public const string IsAutoIlumination = "IsAutoIlumination";

        /// <remarks />
        public const string IsAutoOn = "IsAutoOn";

        /// <remarks />
        public const string IsBusy = "Busy";

        /// <remarks />
        public const string IsBusyIlumination = "IsBusyIlumination";

        /// <remarks />
        public const string IsBusyOn = "IsBusyOn";

        /// <remarks />
        public const string IsError = "Error";

        /// <remarks />
        public const string IsErrorIlumination = "IsErrorIlumination";

        /// <remarks />
        public const string IsErrorOn = "IsErrorOn";

        /// <remarks />
        public const string IsMetallic = "IsMetallic";

        /// <remarks />
        public const string IsModule1 = "IsModule1";

        /// <remarks />
        public const string IsModule1Ilumination = "IsModule1Ilumination";

        /// <remarks />
        public const string IsModule1On = "IsModule1On";

        /// <remarks />
        public const string IsNonMetallic = "IsNonMetallic";

        /// <remarks />
        public const string IsTransparent = "IsTransparent";

        /// <remarks />
        public const string Metallic = "Metallic";

        /// <remarks />
        public const string MetallicPiece = "MetallicPiece";

        /// <remarks />
        public const string MetallicPieceQuantity = "MetallicPieceQuantity";

        /// <remarks />
        public const string MetallicQty = "MetallicQty";

        /// <remarks />
        public const string MetallicQuantity = "MetallicQuantity";

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
        public const string MotorOn = "MotorOn";

        /// <remarks />
        public const string MotorType = "MotorType";

        /// <remarks />
        public const string NonMetallic = "NonMetallic";

        /// <remarks />
        public const string NonMetallicPiece = "NonMetallicPiece";

        /// <remarks />
        public const string NonMetallicPieceQuantity = "NonMetallicPieceQuantity";

        /// <remarks />
        public const string NonMetallicQty = "NonMetallicQty";

        /// <remarks />
        public const string NonMetallicQuantity = "NonMetallicQuantity";

        /// <remarks />
        public const string OpticalBarrier1 = "OpticalBarrier1";

        /// <remarks />
        public const string OpticalBarrier2 = "OpticalBarrier2";

        /// <remarks />
        public const string OpticalBarrier3 = "OpticalBarrier3";

        /// <remarks />
        public const string PhotoSensor = "PhotoSensor";

        /// <remarks />
        public const string PhotoSensorOn = "PhotoSensorOn";

        /// <remarks />
        public const string ResetButton = "ResetButton";

        /// <remarks />
        public const string ResetButtonType = "ResetButtonType";

        /// <remarks />
        public const string Reseted = "Reseted";

        /// <remarks />
        public const string StartButton = "StartButton";

        /// <remarks />
        public const string StartButtonType = "StartButtonType";

        /// <remarks />
        public const string Started = "Started";

        /// <remarks />
        public const string Transparent = "Transparent";

        /// <remarks />
        public const string TransparentPiece = "TransparentPiece";

        /// <remarks />
        public const string TransparentPieceQuantity = "TransparentPieceQuantity";

        /// <remarks />
        public const string TransparentQty = "TransparentQty";

        /// <remarks />
        public const string TransparentQuantity = "TransparentQuantity";
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