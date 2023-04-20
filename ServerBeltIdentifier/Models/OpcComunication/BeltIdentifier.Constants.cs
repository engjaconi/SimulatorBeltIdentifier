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
        public const uint BeltType_StartProcess = 236;

        /// <remarks />
        public const uint BeltType_StopProcess = 237;

        /// <remarks />
        public const uint BeltServer_StartProcess = 324;

        /// <remarks />
        public const uint BeltServer_StopProcess = 325;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierStart = 82;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle = 90;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierEnd = 98;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierElectricPhotoSensor = 106;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierCapacitiveSensor = 114;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierInductiveSensor = 122;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierErrorIlumination = 130;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierMotor = 143;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1 = 151;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart = 152;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle = 160;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd = 168;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor = 176;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor = 184;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor = 192;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination = 200;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierMotor = 213;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart = 220;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle = 222;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd = 224;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor = 226;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor = 228;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor = 230;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination = 232;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1Motor = 234;

        /// <remarks />
        public const uint BeltServer = 238;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1 = 239;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart = 240;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle = 248;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd = 256;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor = 264;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor = 272;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor = 280;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination = 288;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierMotor = 301;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart = 308;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle = 310;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd = 312;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor = 314;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor = 316;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor = 318;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination = 320;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1Motor = 322;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001 = 326;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart = 327;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle = 335;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd = 343;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor = 351;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor = 359;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor = 367;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination = 375;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierMotor = 388;
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
        public const uint BeltIdentifierType = 81;

        /// <remarks />
        public const uint BeltType = 150;
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
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output = 83;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output_EURange = 87;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Units = 89;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output = 91;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output_EURange = 95;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Units = 97;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output = 99;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output_EURange = 103;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Units = 105;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output = 107;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output_EURange = 111;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Units = 113;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output = 115;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output_EURange = 119;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierCapacitiveSensor_Units = 121;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierInductiveSensor_Output = 123;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierInductiveSensor_Output_EURange = 127;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierInductiveSensor_Units = 129;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierErrorIlumination_Input = 131;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierErrorIlumination_Input_EURange = 135;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierErrorIlumination_Output = 137;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierErrorIlumination_Output_EURange = 141;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierMotor_Speed = 144;

        /// <remarks />
        public const uint BeltIdentifierType_BeltIdentifierMotor_Speed_EURange = 148;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output = 153;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange = 157;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units = 159;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output = 161;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange = 165;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units = 167;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output = 169;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange = 173;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units = 175;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output = 177;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange = 181;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units = 183;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output = 185;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange = 189;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units = 191;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output = 193;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange = 197;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Units = 199;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input = 201;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange = 205;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output = 207;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange = 211;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed = 214;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange = 218;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output = 221;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output = 223;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output = 225;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output = 227;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output = 229;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output = 231;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input = 233;

        /// <remarks />
        public const uint BeltType_BeltIdentifier1_BeltIdentifier1Motor_Speed = 235;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output = 241;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange = 245;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units = 247;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output = 249;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange = 253;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units = 255;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output = 257;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange = 261;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units = 263;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output = 265;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange = 269;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units = 271;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output = 273;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange = 277;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units = 279;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output = 281;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange = 285;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Units = 287;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input = 289;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange = 293;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output = 295;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange = 299;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed = 302;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange = 306;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output = 309;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output = 311;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output = 313;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output = 315;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output = 317;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output = 319;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input = 321;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier1_BeltIdentifier1Motor_Speed = 323;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output = 328;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output_EURange = 332;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Units = 334;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output = 336;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output_EURange = 340;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Units = 342;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output = 344;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output_EURange = 348;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Units = 350;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output = 352;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output_EURange = 356;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Units = 358;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output = 360;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output_EURange = 364;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Units = 366;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output = 368;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output_EURange = 372;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Units = 374;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input = 376;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input_EURange = 380;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output = 382;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output_EURange = 386;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed = 389;

        /// <remarks />
        public const uint BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed_EURange = 393;
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
        public static readonly ExpandedNodeId BeltServer_StartProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StartProcess, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_StopProcess = new ExpandedNodeId(BeltIdentifier.Methods.BeltServer_StopProcess, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltIdentifierType_BeltIdentifierMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifierMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltType_BeltIdentifier1_BeltIdentifier1Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifierMotor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1Motor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier1_BeltIdentifier1Motor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001 = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierMotor = new ExpandedNodeId(BeltIdentifier.Objects.BeltServer_BeltIdentifier001_BeltIdentifierMotor, BeltIdentifier.Namespaces.BeltIdentifier);
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
        public static readonly ExpandedNodeId BeltIdentifierType = new ExpandedNodeId(BeltIdentifier.ObjectTypes.BeltIdentifierType, BeltIdentifier.Namespaces.BeltIdentifier);

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
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltIdentifierType_BeltIdentifierMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltIdentifierType_BeltIdentifierMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltType_BeltIdentifier1_BeltIdentifier1Motor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltType_BeltIdentifier1_BeltIdentifier1Motor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifierMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1OpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1ElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1CapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1InductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1ErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier1_BeltIdentifier1Motor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier1_BeltIdentifier1Motor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierStart_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierMiddle_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierOpticalBarrierEnd_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierElectricPhotoSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierCapacitiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Units = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierInductiveSensor_Units, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Input_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierErrorIlumination_Output_EURange, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed, BeltIdentifier.Namespaces.BeltIdentifier);

        /// <remarks />
        public static readonly ExpandedNodeId BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed_EURange = new ExpandedNodeId(BeltIdentifier.Variables.BeltServer_BeltIdentifier001_BeltIdentifierMotor_Speed_EURange, BeltIdentifier.Namespaces.BeltIdentifier);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string BeltIdentifier001 = "BeltIdentifier001";

        /// <remarks />
        public const string BeltIdentifier1 = "Belt Identifier #1";

        /// <remarks />
        public const string BeltIdentifierCapacitiveSensor = "CS001";

        /// <remarks />
        public const string BeltIdentifierElectricPhotoSensor = "ES001";

        /// <remarks />
        public const string BeltIdentifierErrorIlumination = "EI001";

        /// <remarks />
        public const string BeltIdentifierInductiveSensor = "IS001";

        /// <remarks />
        public const string BeltIdentifierMotor = "Motor01";

        /// <remarks />
        public const string BeltIdentifierOpticalBarrierEnd = "OB003";

        /// <remarks />
        public const string BeltIdentifierOpticalBarrierMiddle = "OB002";

        /// <remarks />
        public const string BeltIdentifierOpticalBarrierStart = "OB001";

        /// <remarks />
        public const string BeltIdentifierType = "BeltIdentifierType";

        /// <remarks />
        public const string BeltMotorType = "BeltMotorType";

        /// <remarks />
        public const string BeltServer = "Belt Server #1";

        /// <remarks />
        public const string BeltType = "BeltType";

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