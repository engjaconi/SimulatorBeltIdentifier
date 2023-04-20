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

    #region BeltIdentifierState Class
    #if (!OPCUA_EXCLUDE_BeltIdentifierState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BeltIdentifierState : FolderState
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
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmVsdElkZW50aWZpZXL/////BGCAAgEAAAAB" +
           "ABoAAABCZWx0SWRlbnRpZmllclR5cGVJbnN0YW5jZQEBUQABAVEAUQAAAAEAAAAAMAABAVIACAAAAIRg" +
           "wAoBAAAAIQAAAEJlbHRJZGVudGlmaWVyT3B0aWNhbEJhcnJpZXJTdGFydAEABQAAAE9CMDAxAQFSAAAv" +
           "AQEdAFIAAAABAQAAAAAwAQEBUQACAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAVMAAC8BAEAJUwAAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVcAAC4ARFcAAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFZAAAuAERZAAAAAAz/////AwP/////AAAAAIRgwAoBAAAA" +
           "IgAAAEJlbHRJZGVudGlmaWVyT3B0aWNhbEJhcnJpZXJNaWRkbGUBAAUAAABPQjAwMgEBWgAALwEBHQBa" +
           "AAAAAf////8CAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAVsAAC8BAEAJWwAAAAAL/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAV8AAC4ARF8AAAABAHQD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABQAAAFVuaXRzAQFhAAAuAERhAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAHwAAAEJlbHRJZGVu" +
           "dGlmaWVyT3B0aWNhbEJhcnJpZXJFbmQBAAUAAABPQjAwMwEBYgAALwEBHQBiAAAAAf////8CAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAWMAAC8BAEAJYwAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAWcAAC4ARGcAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFp" +
           "AAAuAERpAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAIQAAAEJlbHRJZGVudGlmaWVyRWxlY3RyaWNQ" +
           "aG90b1NlbnNvcgEABQAAAEVTMDAxAQFqAAAvAQElAGoAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91" +
           "dHB1dAEBawAALwEAQAlrAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBbwAA" +
           "LgBEbwAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAXEAAC4ARHEAAAAADP//" +
           "//8DA/////8AAAAAhGDACgEAAAAeAAAAQmVsdElkZW50aWZpZXJDYXBhY2l0aXZlU2Vuc29yAQAFAAAA" +
           "Q1MwMDEBAXIAAC8BAS0AcgAAAAH/////AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFzAAAvAQBACXMA" +
           "AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQF3AAAuAER3AAAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBeQAALgBEeQAAAAAM/////wMD/////wAAAACEYMAK" +
           "AQAAAB0AAABCZWx0SWRlbnRpZmllckluZHVjdGl2ZVNlbnNvcgEABQAAAElTMDAxAQF6AAAvAQE1AHoA" +
           "AAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBewAALwEAQAl7AAAAAAv/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBfwAALgBEfwAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAFAAAAVW5pdHMBAYEAAC4ARIEAAAAADP////8DA/////8AAAAAhGDACgEAAAAeAAAAQmVsdElkZW50" +
           "aWZpZXJFcnJvcklsdW1pbmF0aW9uAQAFAAAARUkwMDEBAYIAAC8BAT0AggAAAAH/////AgAAABVgiQoC" +
           "AAAAAQAFAAAASW5wdXQBAYMAAC8BAEAJgwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAYcAAC4ARIcAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBiQAA" +
           "LwEAQAmJAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBjQAALgBEjQAAAAEA" +
           "dAP/////AQH/////AAAAAIRgwAoBAAAAEwAAAEJlbHRJZGVudGlmaWVyTW90b3IBAAcAAABNb3RvcjAx" +
           "AQGPAAAvAQFKAI8AAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGQAAAvAQBACZAAAAAAC///" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGUAAAuAESUAAAAAQB0A/////8BAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public OpticalBarrierState BeltIdentifierOpticalBarrierStart
        {
            get
            {
                return m_beltIdentifierOpticalBarrierStart;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierOpticalBarrierStart, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierOpticalBarrierStart = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState BeltIdentifierOpticalBarrierMiddle
        {
            get
            {
                return m_beltIdentifierOpticalBarrierMiddle;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierOpticalBarrierMiddle, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierOpticalBarrierMiddle = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState BeltIdentifierOpticalBarrierEnd
        {
            get
            {
                return m_beltIdentifierOpticalBarrierEnd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierOpticalBarrierEnd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierOpticalBarrierEnd = value;
            }
        }

        /// <remarks />
        public ElectricPhotoSensorState BeltIdentifierElectricPhotoSensor
        {
            get
            {
                return m_beltIdentifierElectricPhotoSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierElectricPhotoSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierElectricPhotoSensor = value;
            }
        }

        /// <remarks />
        public CapacitiveSensorState BeltIdentifierCapacitiveSensor
        {
            get
            {
                return m_beltIdentifierCapacitiveSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierCapacitiveSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierCapacitiveSensor = value;
            }
        }

        /// <remarks />
        public InductiveSensorState BeltIdentifierInductiveSensor
        {
            get
            {
                return m_beltIdentifierInductiveSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierInductiveSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierInductiveSensor = value;
            }
        }

        /// <remarks />
        public ErrorIluminationState BeltIdentifierErrorIlumination
        {
            get
            {
                return m_beltIdentifierErrorIlumination;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierErrorIlumination, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierErrorIlumination = value;
            }
        }

        /// <remarks />
        public BeltMotorState BeltIdentifierMotor
        {
            get
            {
                return m_beltIdentifierMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifierMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifierMotor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_beltIdentifierOpticalBarrierStart != null)
            {
                children.Add(m_beltIdentifierOpticalBarrierStart);
            }

            if (m_beltIdentifierOpticalBarrierMiddle != null)
            {
                children.Add(m_beltIdentifierOpticalBarrierMiddle);
            }

            if (m_beltIdentifierOpticalBarrierEnd != null)
            {
                children.Add(m_beltIdentifierOpticalBarrierEnd);
            }

            if (m_beltIdentifierElectricPhotoSensor != null)
            {
                children.Add(m_beltIdentifierElectricPhotoSensor);
            }

            if (m_beltIdentifierCapacitiveSensor != null)
            {
                children.Add(m_beltIdentifierCapacitiveSensor);
            }

            if (m_beltIdentifierInductiveSensor != null)
            {
                children.Add(m_beltIdentifierInductiveSensor);
            }

            if (m_beltIdentifierErrorIlumination != null)
            {
                children.Add(m_beltIdentifierErrorIlumination);
            }

            if (m_beltIdentifierMotor != null)
            {
                children.Add(m_beltIdentifierMotor);
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
                case BeltIdentifier.BrowseNames.BeltIdentifierOpticalBarrierStart:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierOpticalBarrierStart == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierOpticalBarrierStart = new OpticalBarrierState(this);
                            }
                            else
                            {
                                BeltIdentifierOpticalBarrierStart = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierOpticalBarrierStart;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierOpticalBarrierMiddle:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierOpticalBarrierMiddle == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierOpticalBarrierMiddle = new OpticalBarrierState(this);
                            }
                            else
                            {
                                BeltIdentifierOpticalBarrierMiddle = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierOpticalBarrierMiddle;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierOpticalBarrierEnd:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierOpticalBarrierEnd == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierOpticalBarrierEnd = new OpticalBarrierState(this);
                            }
                            else
                            {
                                BeltIdentifierOpticalBarrierEnd = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierOpticalBarrierEnd;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierElectricPhotoSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierElectricPhotoSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierElectricPhotoSensor = new ElectricPhotoSensorState(this);
                            }
                            else
                            {
                                BeltIdentifierElectricPhotoSensor = (ElectricPhotoSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierElectricPhotoSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierCapacitiveSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierCapacitiveSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierCapacitiveSensor = new CapacitiveSensorState(this);
                            }
                            else
                            {
                                BeltIdentifierCapacitiveSensor = (CapacitiveSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierCapacitiveSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierInductiveSensor:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierInductiveSensor == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierInductiveSensor = new InductiveSensorState(this);
                            }
                            else
                            {
                                BeltIdentifierInductiveSensor = (InductiveSensorState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierInductiveSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierErrorIlumination:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierErrorIlumination == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierErrorIlumination = new ErrorIluminationState(this);
                            }
                            else
                            {
                                BeltIdentifierErrorIlumination = (ErrorIluminationState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierErrorIlumination;
                    break;
                }

                case BeltIdentifier.BrowseNames.BeltIdentifierMotor:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifierMotor == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifierMotor = new BeltMotorState(this);
                            }
                            else
                            {
                                BeltIdentifierMotor = (BeltMotorState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifierMotor;
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
        private OpticalBarrierState m_beltIdentifierOpticalBarrierStart;
        private OpticalBarrierState m_beltIdentifierOpticalBarrierMiddle;
        private OpticalBarrierState m_beltIdentifierOpticalBarrierEnd;
        private ElectricPhotoSensorState m_beltIdentifierElectricPhotoSensor;
        private CapacitiveSensorState m_beltIdentifierCapacitiveSensor;
        private InductiveSensorState m_beltIdentifierInductiveSensor;
        private ErrorIluminationState m_beltIdentifierErrorIlumination;
        private BeltMotorState m_beltIdentifierMotor;
        #endregion
    }
    #endif
    #endregion

    #region BeltState Class
    #if (!OPCUA_EXCLUDE_BeltState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BeltState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BeltState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.BeltType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABAAAABCZWx0VHlwZUluc3RhbmNlAQGWAAEBlgCWAAAAAQEAAAAAMAABAZcAAwAAAIRgwAoBAAAADwAA" +
           "AEJlbHRJZGVudGlmaWVyMQEAEgAAAEJlbHQgSWRlbnRpZmllciAjMQEBlwAALwEBUQCXAAAAAQIAAAAA" +
           "MAEBAZYAADAAAQGYABAAAACEYMAKAQAAACEAAABCZWx0SWRlbnRpZmllck9wdGljYWxCYXJyaWVyU3Rh" +
           "cnQBAAUAAABPQjAwMQEBmAAALwEBHQCYAAAAAQEAAAAAMAEBAZcAAgAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGZAAAvAQBACZkAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGdAAAu" +
           "AESdAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBnwAALgBEnwAAAAAM////" +
           "/wMD/////wAAAACEYMAKAQAAACIAAABCZWx0SWRlbnRpZmllck9wdGljYWxCYXJyaWVyTWlkZGxlAQAF" +
           "AAAAT0IwMDIBAaAAAC8BAR0AoAAAAAH/////AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGhAAAvAQBA" +
           "CaEAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGlAAAuAESlAAAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBpwAALgBEpwAAAAAM/////wMD/////wAAAACE" +
           "YMAKAQAAAB8AAABCZWx0SWRlbnRpZmllck9wdGljYWxCYXJyaWVyRW5kAQAFAAAAT0IwMDMBAagAAC8B" +
           "AR0AqAAAAAH/////AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGpAAAvAQBACakAAAAAC/////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGtAAAuAEStAAAAAQB0A/////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAUAAABVbml0cwEBrwAALgBErwAAAAAM/////wMD/////wAAAACEYMAKAQAAACEAAABCZWx0" +
           "SWRlbnRpZmllckVsZWN0cmljUGhvdG9TZW5zb3IBAAUAAABFUzAwMQEBsAAALwEBJQCwAAAAAf////8C" +
           "AAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAbEAAC8BAEAJsQAAAAAL/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAbUAAC4ARLUAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVu" +
           "aXRzAQG3AAAuAES3AAAAAAz/////AwP/////AAAAAIRgwAoBAAAAHgAAAEJlbHRJZGVudGlmaWVyQ2Fw" +
           "YWNpdGl2ZVNlbnNvcgEABQAAAENTMDAxAQG4AAAvAQEtALgAAAAB/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBuQAALwEAQAm5AAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "vQAALgBEvQAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAb8AAC4ARL8AAAAA" +
           "DP////8DA/////8AAAAAhGDACgEAAAAdAAAAQmVsdElkZW50aWZpZXJJbmR1Y3RpdmVTZW5zb3IBAAUA" +
           "AABJUzAwMQEBwAAALwEBNQDAAAAAAf////8CAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAcEAAC8BAEAJ" +
           "wQAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcUAAC4ARMUAAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQHHAAAuAETHAAAAAAz/////AwP/////AAAAAIRg" +
           "wAoBAAAAHgAAAEJlbHRJZGVudGlmaWVyRXJyb3JJbHVtaW5hdGlvbgEABQAAAEVJMDAxAQHIAAAvAQE9" +
           "AMgAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQHJAAAvAQBACckAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHNAAAuAETNAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAc8AAC8BAEAJzwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAdMAAC4ARNMAAAABAHQD/////wEB/////wAAAACEYMAKAQAAABMAAABCZWx0SWRlbnRpZmll" +
           "ck1vdG9yAQAHAAAATW90b3IwMQEB1QAALwEBSgDVAAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVl" +
           "ZAEB1gAALwEAQAnWAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB2gAALgBE" +
           "2gAAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAQAiAAAAQmVsdElkZW50aWZpZXIxT3B0aWNhbEJh" +
           "cnJpZXJTdGFydAEB3AAALwA63AAAAP////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAd0AAC8AP90A" +
           "AAAAGP////8BAf////8AAAAABGCACgEAAAABACMAAABCZWx0SWRlbnRpZmllcjFPcHRpY2FsQmFycmll" +
           "ck1pZGRsZQEB3gAALwA63gAAAP////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAd8AAC8AP98AAAAA" +
           "GP////8BAf////8AAAAABGCACgEAAAABACAAAABCZWx0SWRlbnRpZmllcjFPcHRpY2FsQmFycmllckVu" +
           "ZAEB4AAALwA64AAAAP////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAeEAAC8AP+EAAAAAGP////8B" +
           "Af////8AAAAABGCACgEAAAABACIAAABCZWx0SWRlbnRpZmllcjFFbGVjdHJpY1Bob3RvU2Vuc29yAQHi" +
           "AAAvADriAAAA/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB4wAALwA/4wAAAAAY/////wEB////" +
           "/wAAAAAEYIAKAQAAAAEAHwAAAEJlbHRJZGVudGlmaWVyMUNhcGFjaXRpdmVTZW5zb3IBAeQAAC8AOuQA" +
           "AAD/////AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQHlAAAvAD/lAAAAABj/////AQH/////AAAAAARg" +
           "gAoBAAAAAQAeAAAAQmVsdElkZW50aWZpZXIxSW5kdWN0aXZlU2Vuc29yAQHmAAAvADrmAAAA/////wEA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEB5wAALwA/5wAAAAAY/////wEB/////wAAAAAEYIAKAQAAAAEA" +
           "HwAAAEJlbHRJZGVudGlmaWVyMUVycm9ySWx1bWluYXRpb24BAegAAC8AOugAAAD/////AQAAABVgiQoC" +
           "AAAAAQAFAAAASW5wdXQBAekAAC8AP+kAAAAAGP////8BAf////8AAAAABGCACgEAAAABABQAAABCZWx0" +
           "SWRlbnRpZmllcjFNb3RvcgEB6gAALwA66gAAAP////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEB6wAA" +
           "LwA/6wAAAAAY/////wEB/////wAAAAAEYYIKBAAAAAEADAAAAFN0YXJ0UHJvY2VzcwEB7AAALwEB7ADs" +
           "AAAAAQH/////AAAAAARhggoEAAAAAQALAAAAU3RvcFByb2Nlc3MBAe0AAC8BAe0A7QAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BeltIdentifierState BeltIdentifier1
        {
            get
            {
                return m_beltIdentifier1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_beltIdentifier1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_beltIdentifier1 = value;
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
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_beltIdentifier1 != null)
            {
                children.Add(m_beltIdentifier1);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
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
                case BeltIdentifier.BrowseNames.BeltIdentifier1:
                {
                    if (createOrReplace)
                    {
                        if (BeltIdentifier1 == null)
                        {
                            if (replacement == null)
                            {
                                BeltIdentifier1 = new BeltIdentifierState(this);
                            }
                            else
                            {
                                BeltIdentifier1 = (BeltIdentifierState)replacement;
                            }
                        }
                    }

                    instance = BeltIdentifier1;
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
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BeltIdentifierState m_beltIdentifier1;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}