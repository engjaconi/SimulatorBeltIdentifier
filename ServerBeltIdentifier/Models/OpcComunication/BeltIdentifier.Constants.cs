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
        public const uint BeltIdentifierType_StartProcess = 220;

        /// <remarks />
        public const uint BeltIdentifierType_StopProcess = 221;

        /// <remarks />
        public const uint BeltIdentifierType_TypeOfObject = 222;

        /// <remarks />
        public const uint BeltIdentifier1_StartProcess = 293;

        /// <remarks />
        public const uint BeltIdentifier1_StopProcess = 294;

        /// <remarks />
        public const uint BeltIdentifier1_TypeOfObject = 295;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierStart = 82;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierMiddle = 90;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierEnd = 98;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltElectricPhotoSensor = 106;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltCapacitiveSensor = 114;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltInductiveSensor = 122;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltErrorIlumination = 130;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltMotor = 143;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier = 151;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart = 152;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle = 160;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd = 168;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor = 176;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor = 184;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor = 192;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination = 200;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor = 213;

        /// <remarks />
        public const uint BeltIdentifier1 = 223;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier = 224;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart = 225;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle = 233;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd = 241;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor = 249;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor = 257;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor = 265;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination = 273;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor = 286;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001 = 296;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart = 297;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle = 305;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd = 313;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor = 321;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor = 329;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor = 337;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination = 345;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor = 358;
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
        public const uint GenericActuatorType = 9;

        /// <remarks />
        public const uint GenericMotorType = 22;

        /// <remarks />
        public const uint OpticalBarrier = 29;

        /// <remarks />
        public const uint ElectricPhotoSensor = 37;

        /// <remarks />
        public const uint CapacitiveSensor = 45;

        /// <remarks />
        public const uint InductiveSensor = 53;

        /// <remarks />
        public const uint ErrorIlumination = 61;

        /// <remarks />
        public const uint BeltMotorType = 74;

        /// <remarks />
        public const uint IdentifierBelt = 81;

        /// <remarks />
        public const uint BeltIdentifierType = 150;
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
        public const uint GenericSensorType_Units = 8;

        /// <remarks />
        public const uint GenericActuatorType_Input = 10;

        /// <remarks />
        public const uint GenericActuatorType_Input_EURange = 14;

        /// <remarks />
        public const uint GenericActuatorType_Output = 16;

        /// <remarks />
        public const uint GenericActuatorType_Output_EURange = 20;

        /// <remarks />
        public const uint GenericMotorType_Speed = 23;

        /// <remarks />
        public const uint GenericMotorType_Speed_EURange = 27;

        /// <remarks />
        public const uint OpticalBarrier_Output_EURange = 34;

        /// <remarks />
        public const uint ElectricPhotoSensor_Output_EURange = 42;

        /// <remarks />
        public const uint CapacitiveSensor_Output_EURange = 50;

        /// <remarks />
        public const uint InductiveSensor_Output_EURange = 58;

        /// <remarks />
        public const uint ErrorIlumination_Input_EURange = 66;

        /// <remarks />
        public const uint ErrorIlumination_Output_EURange = 72;

        /// <remarks />
        public const uint BeltMotorType_Speed_EURange = 79;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output = 83;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output_EURange = 87;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierStart_Units = 89;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output = 91;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output_EURange = 95;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Units = 97;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output = 99;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output_EURange = 103;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Units = 105;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output = 107;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output_EURange = 111;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltElectricPhotoSensor_Units = 113;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltCapacitiveSensor_Output = 115;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltCapacitiveSensor_Output_EURange = 119;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltCapacitiveSensor_Units = 121;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltInductiveSensor_Output = 123;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltInductiveSensor_Output_EURange = 127;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltInductiveSensor_Units = 129;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltErrorIlumination_Input = 131;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltErrorIlumination_Input_EURange = 135;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltErrorIlumination_Output = 137;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltErrorIlumination_Output_EURange = 141;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltMotor_Speed = 144;

        /// <remarks />
        public const uint IdentifierBelt_IdentifierBeltMotor_Speed_EURange = 148;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output = 153;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange = 157;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units = 159;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output = 161;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange = 165;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units = 167;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output = 169;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange = 173;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units = 175;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output = 177;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange = 181;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units = 183;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output = 185;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange = 189;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units = 191;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output = 193;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange = 197;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Units = 199;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input = 201;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange = 205;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output = 207;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange = 211;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed = 214;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed_EURange = 218;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output = 226;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange = 230;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units = 232;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output = 234;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange = 238;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units = 240;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output = 242;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange = 246;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units = 248;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output = 250;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange = 254;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units = 256;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output = 258;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange = 262;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units = 264;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output = 266;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange = 270;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Units = 272;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input = 274;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange = 278;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output = 280;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange = 284;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed = 287;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed_EURange = 291;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output = 298;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output_EURange = 302;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Units = 304;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output = 306;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output_EURange = 310;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Units = 312;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output = 314;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output_EURange = 318;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Units = 320;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output = 322;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output_EURange = 326;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Units = 328;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output = 330;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output_EURange = 334;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Units = 336;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output = 338;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output_EURange = 342;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Units = 344;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input = 346;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input_EURange = 350;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output = 352;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output_EURange = 356;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed = 359;

        /// <remarks />
        public const uint BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed_EURange = 363;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_StartProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifierType_StartProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_StopProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifierType_StopProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_TypeOfObject = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifierType_TypeOfObject, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_StartProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifier1_StartProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_StopProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifier1_StopProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_TypeOfObject = new ExpandedNodeId(BeltIdentifier.Methods.BeltIdentifier1_TypeOfObject, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltMotor = new ExpandedNodeId(BeltIdentifier.Objects.IdentifierBelt_IdentifierBeltMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001 = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor, BeltIdentifier.Namespaces.BeltIdentifier);
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
        public static readonly ExpandedNodeId ErrorIlumination = new ExpandedNodeId(BeltIdentifier.ObjectTypes.ErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltMotorType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.BeltMotorType, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt = new ExpandedNodeId(BeltIdentifier.ObjectTypes.IdentifierBelt, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.BeltIdentifierType, BeltIdentifier.Namespaces.BeltIdentifier);
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
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(BeltIdentifier.Variables.GenericSensorType_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericActuatorType_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.GenericMotorType_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId OpticalBarrier_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.OpticalBarrier_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.ElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId CapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.CapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId InductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.InductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.ErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId ErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.ErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltMotorType_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltMotorType_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId IdentifierBelt_IdentifierBeltMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.IdentifierBelt_IdentifierBeltMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifier_IdentifierBeltMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier_IdentifierBeltMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifier1_BeltIdentifier001_IdentifierBeltMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string BeltIdentifier = "BeltIdentifier001";

        /// <remarks />
        public const string BeltIdentifier001 = "BeltIdentifier001";

        /// <remarks />
        public const string BeltIdentifier1 = "Belt Identifier #1";

        /// <remarks />
        public const string BeltIdentifierType = "BeltIdentifierType";

        /// <remarks />
        public const string BeltMotorType = "BeltMotorType";

        /// <remarks />
        public const string CapacitiveSensor = "CapacitiveSensor";

        /// <remarks />
        public const string ElectricPhotoSensor = "ElectricPhotoSensor";

        /// <remarks />
        public const string ErrorIlumination = "ErrorIlumination";

        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";

        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string IdentifierBelt = "IdentifierBelt";

        /// <remarks />
        public const string IdentifierBeltCapacitiveSensor = "CS001";

        /// <remarks />
        public const string IdentifierBeltElectricPhotoSensor = "ES001";

        /// <remarks />
        public const string IdentifierBeltErrorIlumination = "EI001";

        /// <remarks />
        public const string IdentifierBeltInductiveSensor = "IS001";

        /// <remarks />
        public const string IdentifierBeltMotor = "Motor01";

        /// <remarks />
        public const string IdentifierBeltOpticalBarrierEnd = "OB003";

        /// <remarks />
        public const string IdentifierBeltOpticalBarrierMiddle = "OB002";

        /// <remarks />
        public const string IdentifierBeltOpticalBarrierStart = "OB001";

        /// <remarks />
        public const string InductiveSensor = "InductiveSensor";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string OpticalBarrier = "OpticalBarrier";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string StopProcess = "StopProcess";

        /// <remarks />
        public const string TypeOfObject = "TypeOfObject";

        /// <remarks />
        public const string Units = "Units";
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