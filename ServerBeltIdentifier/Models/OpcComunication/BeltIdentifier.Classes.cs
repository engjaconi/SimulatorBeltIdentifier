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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BeltIdentifier
{
    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.GenericSensorType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABkAAABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wIAAAAVYIkKAgAAAAEA" +
           "BgAAAE91dHB1dAEBAgAALwEAQAkCAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBBgAALgBEBgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAQgAAC4ARAgA" +
           "AAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BeltIdentifier.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case BeltIdentifier.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_units;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.GenericActuatorType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABsAAABHZW5lcmljQWN0dWF0b3JUeXBlSW5zdGFuY2UBAQkAAQEJAAkAAAD/////AgAAABVgiQoCAAAA" +
           "AQAFAAAASW5wdXQBAQoAAC8BAEAJCgAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAQ4AAC4ARA4AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBEAAALwEA" +
           "QAkQAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBFAAALgBEFAAAAAEAdAP/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BeltIdentifier.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }

                case BeltIdentifier.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericMotorState Class
    #if (!OPCUA_EXCLUDE_GenericMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.GenericMotorType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABgAAABHZW5lcmljTW90b3JUeXBlSW5zdGFuY2UBARYAAQEWABYAAAD/////AQAAABVgiQoCAAAAAQAF" +
           "AAAAU3BlZWQBARcAAC8BAEAJFwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "ARsAAC4ARBsAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BeltIdentifier.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_speed;
        #endregion
    }
    #endif
    #endregion

    #region OpticalBarrierState Class
    #if (!OPCUA_EXCLUDE_OpticalBarrierState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalBarrierState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public OpticalBarrierState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.OpticalBarrier, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABYAAABPcHRpY2FsQmFycmllckluc3RhbmNlAQEdAAEBHQAdAAAA/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBHgAALwEAQAkeAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "IgAALgBEIgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBASQAAC4ARCQAAAAA" +
           "DP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ElectricPhotoSensorState Class
    #if (!OPCUA_EXCLUDE_ElectricPhotoSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ElectricPhotoSensorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public ElectricPhotoSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.ElectricPhotoSensor, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABsAAABFbGVjdHJpY1Bob3RvU2Vuc29ySW5zdGFuY2UBASUAAQElACUAAAD/////AgAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AQEmAAAvAQBACSYAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEqAAAuAEQqAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBLAAALgBE" +
           "LAAAAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CapacitiveSensorState Class
    #if (!OPCUA_EXCLUDE_CapacitiveSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CapacitiveSensorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public CapacitiveSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.CapacitiveSensor, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABgAAABDYXBhY2l0aXZlU2Vuc29ySW5zdGFuY2UBAS0AAQEtAC0AAAD/////AgAAABVgiQoCAAAAAQAG" +
           "AAAAT3V0cHV0AQEuAAAvAQBACS4AAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQEyAAAuAEQyAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBNAAALgBENAAA" +
           "AAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region InductiveSensorState Class
    #if (!OPCUA_EXCLUDE_InductiveSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InductiveSensorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public InductiveSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.InductiveSensor, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABcAAABJbmR1Y3RpdmVTZW5zb3JJbnN0YW5jZQEBNQABATUANQAAAP////8CAAAAFWCJCgIAAAABAAYA" +
           "AABPdXRwdXQBATYAAC8BAEAJNgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AToAAC4ARDoAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQE8AAAuAEQ8AAAA" +
           "AAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ErrorIluminationState Class
    #if (!OPCUA_EXCLUDE_ErrorIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ErrorIluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public ErrorIluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.ErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABgAAABFcnJvcklsdW1pbmF0aW9uSW5zdGFuY2UBAT0AAQE9AD0AAAD/////AgAAABVgiQoCAAAAAQAF" +
           "AAAASW5wdXQBAT4AAC8BAEAJPgAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AUIAAC4AREIAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBRAAALwEAQAlE" +
           "AAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBSAAALgBESAAAAAEAdAP/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BeltMotorState Class
    #if (!OPCUA_EXCLUDE_BeltMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BeltMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public BeltMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.BeltMotorType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABUAAABCZWx0TW90b3JUeXBlSW5zdGFuY2UBAUoAAQFKAEoAAAD/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "U3BlZWQBAUsAAC8BAEAJSwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAU8A" +
           "AC4ARE8AAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IdentifierBeltState Class
    #if (!OPCUA_EXCLUDE_IdentifierBeltState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IdentifierBeltState : FolderState
    {
        #region Constructors
        /// <remarks />
        public IdentifierBeltState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.IdentifierBelt, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABYAAABJZGVudGlmaWVyQmVsdEluc3RhbmNlAQFRAAEBUQBRAAAAAQAAAAAwAAEBUQAIAAAAhGDACgEA" +
           "AAAhAAAASWRlbnRpZmllckJlbHRPcHRpY2FsQmFycmllclN0YXJ0AQAFAAAAT0IwMDEBAVIAAC8BAR0A" +
           "UgAAAAH/////AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFTAAAvAQBACVMAAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFXAAAuAERXAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAUAAABVbml0cwEBWQAALgBEWQAAAAAM/////wMD/////wAAAACEYMAKAQAAACIAAABJZGVudGlm" +
           "aWVyQmVsdE9wdGljYWxCYXJyaWVyTWlkZGxlAQAFAAAAT0IwMDIBAVoAAC8BAR0AWgAAAAH/////AgAA" +
           "ABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFbAAAvAQBACVsAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQFfAAAuAERfAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0" +
           "cwEBYQAALgBEYQAAAAAM/////wMD/////wAAAACEYMAKAQAAAB8AAABJZGVudGlmaWVyQmVsdE9wdGlj" +
           "YWxCYXJyaWVyRW5kAQAFAAAAT0IwMDMBAWIAAC8BAR0AYgAAAAH/////AgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQFjAAAvAQBACWMAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFn" +
           "AAAuAERnAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBaQAALgBEaQAAAAAM" +
           "/////wMD/////wAAAACEYMAKAQAAACEAAABJZGVudGlmaWVyQmVsdEVsZWN0cmljUGhvdG9TZW5zb3IB" +
           "AAUAAABFUzAwMQEBagAALwEBJQBqAAAAAf////8CAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAWsAAC8B" +
           "AEAJawAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAW8AAC4ARG8AAAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFxAAAuAERxAAAAAAz/////AwP/////AAAA" +
           "AIRgwAoBAAAAHgAAAElkZW50aWZpZXJCZWx0Q2FwYWNpdGl2ZVNlbnNvcgEABQAAAENTMDAxAQFyAAAv" +
           "AQEtAHIAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBcwAALwEAQAlzAAAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBdwAALgBEdwAAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAFAAAAVW5pdHMBAXkAAC4ARHkAAAAADP////8DA/////8AAAAAhGDACgEAAAAdAAAASWRl" +
           "bnRpZmllckJlbHRJbmR1Y3RpdmVTZW5zb3IBAAUAAABJUzAwMQEBegAALwEBNQB6AAAAAf////8CAAAA" +
           "FWCJCgIAAAABAAYAAABPdXRwdXQBAXsAAC8BAEAJewAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAX8AAC4ARH8AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRz" +
           "AQGBAAAuAESBAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAHgAAAElkZW50aWZpZXJCZWx0RXJyb3JJ" +
           "bHVtaW5hdGlvbgEABQAAAEVJMDAxAQGCAAAvAQE9AIIAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElu" +
           "cHV0AQGDAAAvAQBACYMAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGHAAAu" +
           "AESHAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAYkAAC8BAEAJiQAAAAAL" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAY0AAC4ARI0AAAABAHQD/////wEB////" +
           "/wAAAACEYMAKAQAAABMAAABJZGVudGlmaWVyQmVsdE1vdG9yAQAHAAAATW90b3IwMQEBjwAALwEBSgCP" +
           "AAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBkAAALwEAQAmQAAAAAAv/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBlAAALgBElAAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public OpticalBarrierState IdentifierBeltOpticalBarrierStart
        {
            get
            {
                return m_identifierBeltOpticalBarrierStart;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltOpticalBarrierStart, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltOpticalBarrierStart = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState IdentifierBeltOpticalBarrierMiddle
        {
            get
            {
                return m_identifierBeltOpticalBarrierMiddle;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltOpticalBarrierMiddle, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltOpticalBarrierMiddle = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState IdentifierBeltOpticalBarrierEnd
        {
            get
            {
                return m_identifierBeltOpticalBarrierEnd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltOpticalBarrierEnd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltOpticalBarrierEnd = value;
            }
        }

        /// <remarks />
        public ElectricPhotoSensorState IdentifierBeltElectricPhotoSensor
        {
            get
            {
                return m_identifierBeltElectricPhotoSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltElectricPhotoSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltElectricPhotoSensor = value;
            }
        }

        /// <remarks />
        public CapacitiveSensorState IdentifierBeltCapacitiveSensor
        {
            get
            {
                return m_identifierBeltCapacitiveSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltCapacitiveSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltCapacitiveSensor = value;
            }
        }

        /// <remarks />
        public InductiveSensorState IdentifierBeltInductiveSensor
        {
            get
            {
                return m_identifierBeltInductiveSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltInductiveSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltInductiveSensor = value;
            }
        }

        /// <remarks />
        public ErrorIluminationState IdentifierBeltErrorIlumination
        {
            get
            {
                return m_identifierBeltErrorIlumination;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltErrorIlumination, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltErrorIlumination = value;
            }
        }

        /// <remarks />
        public BeltMotorState IdentifierBeltMotor
        {
            get
            {
                return m_identifierBeltMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifierBeltMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifierBeltMotor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_identifierBeltOpticalBarrierStart != null)
            {
                children.Add(m_identifierBeltOpticalBarrierStart);
            }

            if (m_identifierBeltOpticalBarrierMiddle != null)
            {
                children.Add(m_identifierBeltOpticalBarrierMiddle);
            }

            if (m_identifierBeltOpticalBarrierEnd != null)
            {
                children.Add(m_identifierBeltOpticalBarrierEnd);
            }

            if (m_identifierBeltElectricPhotoSensor != null)
            {
                children.Add(m_identifierBeltElectricPhotoSensor);
            }

            if (m_identifierBeltCapacitiveSensor != null)
            {
                children.Add(m_identifierBeltCapacitiveSensor);
            }

            if (m_identifierBeltInductiveSensor != null)
            {
                children.Add(m_identifierBeltInductiveSensor);
            }

            if (m_identifierBeltErrorIlumination != null)
            {
                children.Add(m_identifierBeltErrorIlumination);
            }

            if (m_identifierBeltMotor != null)
            {
                children.Add(m_identifierBeltMotor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BeltIdentifier.BrowseNames.IdentifierBeltOpticalBarrierStart:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltOpticalBarrierStart == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltOpticalBarrierStart = new OpticalBarrierState(this);
                            }
                            else
                            {
                                IdentifierBeltOpticalBarrierStart = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltOpticalBarrierStart;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltOpticalBarrierMiddle:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltOpticalBarrierMiddle == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltOpticalBarrierMiddle = new OpticalBarrierState(this);
                            }
                            else
                            {
                                IdentifierBeltOpticalBarrierMiddle = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltOpticalBarrierMiddle;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltOpticalBarrierEnd:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltOpticalBarrierEnd == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltOpticalBarrierEnd = new OpticalBarrierState(this);
                            }
                            else
                            {
                                IdentifierBeltOpticalBarrierEnd = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltOpticalBarrierEnd;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltElectricPhotoSensor:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltElectricPhotoSensor == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltElectricPhotoSensor = new ElectricPhotoSensorState(this);
                            }
                            else
                            {
                                IdentifierBeltElectricPhotoSensor = (ElectricPhotoSensorState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltElectricPhotoSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltCapacitiveSensor:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltCapacitiveSensor == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltCapacitiveSensor = new CapacitiveSensorState(this);
                            }
                            else
                            {
                                IdentifierBeltCapacitiveSensor = (CapacitiveSensorState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltCapacitiveSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltInductiveSensor:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltInductiveSensor == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltInductiveSensor = new InductiveSensorState(this);
                            }
                            else
                            {
                                IdentifierBeltInductiveSensor = (InductiveSensorState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltInductiveSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltErrorIlumination:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltErrorIlumination == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltErrorIlumination = new ErrorIluminationState(this);
                            }
                            else
                            {
                                IdentifierBeltErrorIlumination = (ErrorIluminationState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltErrorIlumination;
                    break;
                }

                case BeltIdentifier.BrowseNames.IdentifierBeltMotor:
                {
                    if (createOrReplace)
                    {
                        if (IdentifierBeltMotor == null)
                        {
                            if (replacement == null)
                            {
                                IdentifierBeltMotor = new BeltMotorState(this);
                            }
                            else
                            {
                                IdentifierBeltMotor = (BeltMotorState)replacement;
                            }
                        }
                    }

                    instance = IdentifierBeltMotor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private OpticalBarrierState m_identifierBeltOpticalBarrierStart;
        private OpticalBarrierState m_identifierBeltOpticalBarrierMiddle;
        private OpticalBarrierState m_identifierBeltOpticalBarrierEnd;
        private ElectricPhotoSensorState m_identifierBeltElectricPhotoSensor;
        private CapacitiveSensorState m_identifierBeltCapacitiveSensor;
        private InductiveSensorState m_identifierBeltInductiveSensor;
        private ErrorIluminationState m_identifierBeltErrorIlumination;
        private BeltMotorState m_identifierBeltMotor;
        #endregion
    }
    #endif
    #endregion

    #region BeltIdentifierState Class
    #if (!OPCUA_EXCLUDE_BeltIdentifierState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BeltIdentifierState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BeltIdentifierState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.BeltIdentifierType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////hGCAAgEAAAAB" +
           "ABoAAABCZWx0SWRlbnRpZmllclR5cGVJbnN0YW5jZQEBlgABAZYAlgAAAAEBAAAAADAAAQGXAAQAAACE" +
           "YMAKAQAAAA4AAABCZWx0SWRlbnRpZmllcgEAEQAAAEJlbHRJZGVudGlmaWVyMDAxAQGXAAAvAQFRAJcA" +
           "AAABAgAAAAAwAQEBlgAAMAABAZcACAAAAIRgwAoBAAAAIQAAAElkZW50aWZpZXJCZWx0T3B0aWNhbEJh" +
           "cnJpZXJTdGFydAEABQAAAE9CMDAxAQGYAAAvAQEdAJgAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91" +
           "dHB1dAEBmQAALwEAQAmZAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBnQAA" +
           "LgBEnQAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAZ8AAC4ARJ8AAAAADP//" +
           "//8DA/////8AAAAAhGDACgEAAAAiAAAASWRlbnRpZmllckJlbHRPcHRpY2FsQmFycmllck1pZGRsZQEA" +
           "BQAAAE9CMDAyAQGgAAAvAQEdAKAAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBoQAALwEA" +
           "QAmhAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpQAALgBEpQAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAacAAC4ARKcAAAAADP////8DA/////8AAAAA" +
           "hGDACgEAAAAfAAAASWRlbnRpZmllckJlbHRPcHRpY2FsQmFycmllckVuZAEABQAAAE9CMDAzAQGoAAAv" +
           "AQEdAKgAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBqQAALwEAQAmpAAAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrQAALgBErQAAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAFAAAAVW5pdHMBAa8AAC4ARK8AAAAADP////8DA/////8AAAAAhGDACgEAAAAhAAAASWRl" +
           "bnRpZmllckJlbHRFbGVjdHJpY1Bob3RvU2Vuc29yAQAFAAAARVMwMDEBAbAAAC8BASUAsAAAAAH/////" +
           "AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGxAAAvAQBACbEAAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQG1AAAuAES1AAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABV" +
           "bml0cwEBtwAALgBEtwAAAAAM/////wMD/////wAAAACEYMAKAQAAAB4AAABJZGVudGlmaWVyQmVsdENh" +
           "cGFjaXRpdmVTZW5zb3IBAAUAAABDUzAwMQEBuAAALwEBLQC4AAAAAf////8CAAAAFWCJCgIAAAABAAYA" +
           "AABPdXRwdXQBAbkAAC8BAEAJuQAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "Ab0AAC4ARL0AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQG/AAAuAES/AAAA" +
           "AAz/////AwP/////AAAAAIRgwAoBAAAAHQAAAElkZW50aWZpZXJCZWx0SW5kdWN0aXZlU2Vuc29yAQAF" +
           "AAAASVMwMDEBAcAAAC8BATUAwAAAAAH/////AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQHBAAAvAQBA" +
           "CcEAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHFAAAuAETFAAAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBxwAALgBExwAAAAAM/////wMD/////wAAAACE" +
           "YMAKAQAAAB4AAABJZGVudGlmaWVyQmVsdEVycm9ySWx1bWluYXRpb24BAAUAAABFSTAwMQEByAAALwEB" +
           "PQDIAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEByQAALwEAQAnJAAAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBzQAALgBEzQAAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAGAAAAT3V0cHV0AQHPAAAvAQBACc8AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHTAAAuAETTAAAAAQB0A/////8BAf////8AAAAAhGDACgEAAAATAAAASWRlbnRpZmllckJl" +
           "bHRNb3RvcgEABwAAAE1vdG9yMDEBAdUAAC8BAUoA1QAAAAH/////AQAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBAdYAAC8BAEAJ1gAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdoAAC4A" +
           "RNoAAAABAHQD/////wEB/////wAAAAAEYYIKBAAAAAEADAAAAFN0YXJ0UHJvY2VzcwEB3AAALwEB3ADc" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQALAAAAU3RvcFByb2Nlc3MBAd0AAC8BAd0A3QAAAAEB/////wAA" +
           "AAAEYYIKBAAAAAEADAAAAFR5cGVPZk9iamVjdAEB3gAALwEB3gDeAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public IdentifierBeltState BeltIdentifier
        {
            get
            {
                return m_beltIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifier = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState TypeOfObject
        {
            get
            {
                return m_typeOfObjectMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_typeOfObjectMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_typeOfObjectMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_beltIdentifier != null)
            {
                children.Add(m_beltIdentifier);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            if (m_typeOfObjectMethod != null)
            {
                children.Add(m_typeOfObjectMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BeltIdentifier.BrowseNames.BeltIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifier = new IdentifierBeltState(this);
                            }
                            else
                            {
                                BeltIdentifier = (IdentifierBeltState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifier;
                    break;
                }

                case BeltIdentifier.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.TypeOfObject:
                {
                    if (createOrReplace)
                    {
                        if (TypeOfObject == null)
                        {
                            if (replacement == null)
                            {
                                TypeOfObject = new MethodState(this);
                            }
                            else
                            {
                                TypeOfObject = (MethodState)replacement;
                            }
                        }
                    }

                    instance = TypeOfObject;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private IdentifierBeltState m_beltIdentifier;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        private MethodState m_typeOfObjectMethod;
        #endregion
    }
    #endif
    #endregion
}