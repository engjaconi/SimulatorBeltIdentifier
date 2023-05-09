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
           "ABkAAABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wEAAAAVYIkKAgAAAAEA" +
           "BgAAAE91dHB1dAEBAgAALwEAQAkCAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBBgAALgBEBgAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<bool> Output
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
                case BeltIdentifier.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<bool>)replacement;
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
        private AnalogItemState<bool> m_output;
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
           "ABsAAABHZW5lcmljQWN0dWF0b3JUeXBlSW5zdGFuY2UBAQgAAQEIAAgAAAD/////AQAAABVgiQoCAAAA" +
           "AQAFAAAASW5wdXQBAQkAAC8BAEAJCQAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAQ0AAC4ARA0AAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<bool> Input
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
                                Input = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Input;
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
        private AnalogItemState<bool> m_input;
        #endregion
    }
    #endif
    #endregion

    #region GenericDisplayState Class
    #if (!OPCUA_EXCLUDE_GenericDisplayState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericDisplayState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericDisplayState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.GenericDisplayType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABoAAABHZW5lcmljRGlzcGxheVR5cGVJbnN0YW5jZQEBDwABAQ8ADwAAAP////8BAAAAFWCJCgIAAAAB" +
           "AAUAAABJbnB1dAEBEAAALwEAQAkQAAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBFAAALgBEFAAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<int> Input
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
                                Input = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = Input;
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
        private AnalogItemState<int> m_input;
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
           "ABgAAABHZW5lcmljTW90b3JUeXBlSW5zdGFuY2UBARYAAQEWABYAAAD/////AgAAABVgiQoCAAAAAQAF" +
           "AAAAU3BlZWQBARcAAC8BAEAJFwAAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "ARsAAC4ARBsAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBVwMALwEAQAlX" +
           "AwAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBWwMALgBEWwMAAAEAdAP/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<int> Speed
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

        /// <remarks />
        public AnalogItemState<bool> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
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

            if (m_status != null)
            {
                children.Add(m_status);
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
                                Speed = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }

                case BeltIdentifier.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Status = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Status;
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
        private AnalogItemState<int> m_speed;
        private AnalogItemState<bool> m_status;
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
           "ABYAAABPcHRpY2FsQmFycmllckluc3RhbmNlAQEdAAEBHQAdAAAA/////wEAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBHgAALwEAQAkeAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "IgAALgBEIgAAAAEAdAP/////AQH/////AAAAAA==";
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
           "ABsAAABFbGVjdHJpY1Bob3RvU2Vuc29ySW5zdGFuY2UBASQAAQEkACQAAAD/////AQAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AQElAAAvAQBACSUAAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEpAAAuAEQpAAAAAQB0A/////8BAf////8AAAAA";
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
           "ABgAAABDYXBhY2l0aXZlU2Vuc29ySW5zdGFuY2UBASsAAQErACsAAAD/////AQAAABVgiQoCAAAAAQAG" +
           "AAAAT3V0cHV0AQEsAAAvAQBACSwAAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQEwAAAuAEQwAAAAAQB0A/////8BAf////8AAAAA";
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
           "ABcAAABJbmR1Y3RpdmVTZW5zb3JJbnN0YW5jZQEBMgABATIAMgAAAP////8BAAAAFWCJCgIAAAABAAYA" +
           "AABPdXRwdXQBATMAAC8BAEAJMwAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "ATcAAC4ARDcAAAABAHQD/////wEB/////wAAAAA=";
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

    #region TransparentPieceState Class
    #if (!OPCUA_EXCLUDE_TransparentPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransparentPieceState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public TransparentPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.TransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABgAAABUcmFuc3BhcmVudFBpZWNlSW5zdGFuY2UBAZMDAQGTA5MDAAD/////AQAAABVgiQoCAAAAAQAF" +
           "AAAASW5wdXQBAZQDAC8BAEAJlAMAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AZgDAC4ARJgDAAABAHQD/////wEB/////wAAAAA=";
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

    #region MetallicPieceState Class
    #if (!OPCUA_EXCLUDE_MetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MetallicPieceState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public MetallicPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.MetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABUAAABNZXRhbGxpY1BpZWNlSW5zdGFuY2UBAUAAAQFAAEAAAAD/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAUEAAC8BAEAJQQAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUUA" +
           "AC4AREUAAAABAHQD/////wEB/////wAAAAA=";
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

    #region NonMetallicPieceState Class
    #if (!OPCUA_EXCLUDE_NonMetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NonMetallicPieceState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public NonMetallicPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.NonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABgAAABOb25NZXRhbGxpY1BpZWNlSW5zdGFuY2UBAUcAAQFHAEcAAAD/////AQAAABVgiQoCAAAAAQAF" +
           "AAAASW5wdXQBAUgAAC8BAEAJSAAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AUwAAC4AREwAAAABAHQD/////wEB/////wAAAAA=";
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
           "ABgAAABFcnJvcklsdW1pbmF0aW9uSW5zdGFuY2UBAU4AAQFOAE4AAAD/////AQAAABVgiQoCAAAAAQAF" +
           "AAAASW5wdXQBAU8AAC8BAEAJTwAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UB" +
           "AVMAAC4ARFMAAAABAHQD/////wEB/////wAAAAA=";
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

    #region BusyIluminationState Class
    #if (!OPCUA_EXCLUDE_BusyIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BusyIluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public BusyIluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.BusyIlumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABCdXN5SWx1bWluYXRpb25JbnN0YW5jZQEBJgMBASYDJgMAAP////8BAAAAFWCJCgIAAAABAAUA" +
           "AABJbnB1dAEBJwMALwEAQAknAwAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "KwMALgBEKwMAAAEAdAP/////AQH/////AAAAAA==";
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

    #region QuantityTransparentPieceState Class
    #if (!OPCUA_EXCLUDE_QuantityTransparentPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class QuantityTransparentPieceState : GenericDisplayState
    {
        #region Constructors
        /// <remarks />
        public QuantityTransparentPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.QuantityTransparentPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ACAAAABRdWFudGl0eVRyYW5zcGFyZW50UGllY2VJbnN0YW5jZQEBmgMBAZoDmgMAAP////8BAAAAFWCJ" +
           "CgIAAAABAAUAAABJbnB1dAEBmwMALwEAQAmbAwAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBnwMALgBEnwMAAAEAdAP/////AQH/////AAAAAA==";
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

    #region QuantityMetallicPieceState Class
    #if (!OPCUA_EXCLUDE_QuantityMetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class QuantityMetallicPieceState : GenericDisplayState
    {
        #region Constructors
        /// <remarks />
        public QuantityMetallicPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.QuantityMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "AB0AAABRdWFudGl0eU1ldGFsbGljUGllY2VJbnN0YW5jZQEBXAABAVwAXAAAAP////8BAAAAFWCJCgIA" +
           "AAABAAUAAABJbnB1dAEBXQAALwEAQAldAAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBYQAALgBEYQAAAAEAdAP/////AQH/////AAAAAA==";
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

    #region QuantityNonMetallicPieceState Class
    #if (!OPCUA_EXCLUDE_QuantityNonMetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class QuantityNonMetallicPieceState : GenericDisplayState
    {
        #region Constructors
        /// <remarks />
        public QuantityNonMetallicPieceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.QuantityNonMetallicPiece, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ACAAAABRdWFudGl0eU5vbk1ldGFsbGljUGllY2VJbnN0YW5jZQEBYwABAWMAYwAAAP////8BAAAAFWCJ" +
           "CgIAAAABAAUAAABJbnB1dAEBZAAALwEAQAlkAAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBaAAALgBEaAAAAAEAdAP/////AQH/////AAAAAA==";
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

    #region MotorState Class
    #if (!OPCUA_EXCLUDE_MotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public MotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.MotorType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABEAAABNb3RvclR5cGVJbnN0YW5jZQEBHwMBAR8DHwMAAP////8CAAAAFWCJCgIAAAABAAUAAABTcGVl" +
           "ZAEBIAMALwEAQAkgAwAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBJAMALgBE" +
           "JAMAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAU3RhdHVzAQFdAwAvAQBACV0DAAAAAf//" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFhAwAuAERhAwAAAQB0A/////8BAf////8A" +
           "AAAA";
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

    #region Module1State Class
    #if (!OPCUA_EXCLUDE_Module1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Module1State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Module1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.Module1Type, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABMAAABNb2R1bGUxVHlwZUluc3RhbmNlAQFxAAEBcQBxAAAAAQAAAAAwAAEBcgAJAAAAhGCACgEAAAAB" +
           "AAUAAABFcnJvcgEBcgAALwEBTgByAAAAAQEAAAAAMAEBAXEAAQAAABVgiQoCAAAAAQAFAAAASW5wdXQB" +
           "AXMAAC8BAEAJcwAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXcAAC4ARHcA" +
           "AAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEABAAAAEJ1c3kBAS0DAC8BASYDLQMAAAH/////AQAA" +
           "ABVgiQoCAAAAAQAFAAAASW5wdXQBAS4DAC8BAEAJLgMAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBATIDAC4ARDIDAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACwAAAFRyYW5z" +
           "cGFyZW50AQGhAwAvAQGTA6EDAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQGiAwAvAQBACaID" +
           "AAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGmAwAuAESmAwAAAQB0A/////8B" +
           "Af////8AAAAAhGCACgEAAAABAAgAAABNZXRhbGxpYwEBgAAALwEBQACAAAAAAf////8BAAAAFWCJCgIA" +
           "AAABAAUAAABJbnB1dAEBgQAALwEAQAmBAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBhQAALgBEhQAAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQALAAAATm9uTWV0YWxsaWMB" +
           "AYcAAC8BAUcAhwAAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAYgAAC8BAEAJiAAAAAAB////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAYwAAC4ARIwAAAABAHQD/////wEB/////wAA" +
           "AACEYIAKAQAAAAEAEwAAAFF1YW50aXR5VHJhbnNwYXJlbnQBAagDAC8BAZoDqAMAAAH/////AQAAABVg" +
           "iQoCAAAAAQAFAAAASW5wdXQBAakDAC8BAEAJqQMAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAa0DAC4ARK0DAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEAEAAAAFF1YW50aXR5" +
           "TWV0YWxsaWMBAZUAAC8BAVwAlQAAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAZYAAC8BAEAJ" +
           "lgAAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZoAAC4ARJoAAAABAHQD////" +
           "/wEB/////wAAAACEYIAKAQAAAAEAEwAAAFF1YW50aXR5Tm9uTWV0YWxsaWMBAZwAAC8BAWMAnAAAAAH/" +
           "////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAZ0AAC8BAEAJnQAAAAAG/////wMD/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAaEAAC4ARKEAAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEABQAA" +
           "AE1vdG9yAQGjAAAvAQEfA6MAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGkAAAvAQBACaQA" +
           "AAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGoAAAuAESoAAAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABTdGF0dXMBAWMDAC8BAEAJYwMAAAAB/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAWcDAC4ARGcDAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ErrorIluminationState Error
        {
            get
            {
                return m_error;
            }

            set
            {
                if (!Object.ReferenceEquals(m_error, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_error = value;
            }
        }

        /// <remarks />
        public BusyIluminationState Busy
        {
            get
            {
                return m_busy;
            }

            set
            {
                if (!Object.ReferenceEquals(m_busy, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_busy = value;
            }
        }

        /// <remarks />
        public TransparentPieceState Transparent
        {
            get
            {
                return m_transparent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transparent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transparent = value;
            }
        }

        /// <remarks />
        public MetallicPieceState Metallic
        {
            get
            {
                return m_metallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_metallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_metallic = value;
            }
        }

        /// <remarks />
        public NonMetallicPieceState NonMetallic
        {
            get
            {
                return m_nonMetallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nonMetallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nonMetallic = value;
            }
        }

        /// <remarks />
        public QuantityTransparentPieceState QuantityTransparent
        {
            get
            {
                return m_quantityTransparent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quantityTransparent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quantityTransparent = value;
            }
        }

        /// <remarks />
        public QuantityMetallicPieceState QuantityMetallic
        {
            get
            {
                return m_quantityMetallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quantityMetallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quantityMetallic = value;
            }
        }

        /// <remarks />
        public QuantityNonMetallicPieceState QuantityNonMetallic
        {
            get
            {
                return m_quantityNonMetallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_quantityNonMetallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_quantityNonMetallic = value;
            }
        }

        /// <remarks />
        public MotorState Motor
        {
            get
            {
                return m_motor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_error != null)
            {
                children.Add(m_error);
            }

            if (m_busy != null)
            {
                children.Add(m_busy);
            }

            if (m_transparent != null)
            {
                children.Add(m_transparent);
            }

            if (m_metallic != null)
            {
                children.Add(m_metallic);
            }

            if (m_nonMetallic != null)
            {
                children.Add(m_nonMetallic);
            }

            if (m_quantityTransparent != null)
            {
                children.Add(m_quantityTransparent);
            }

            if (m_quantityMetallic != null)
            {
                children.Add(m_quantityMetallic);
            }

            if (m_quantityNonMetallic != null)
            {
                children.Add(m_quantityNonMetallic);
            }

            if (m_motor != null)
            {
                children.Add(m_motor);
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
                case BeltIdentifier.BrowseNames.Error:
                {
                    if (createOrReplace)
                    {
                        if (Error == null)
                        {
                            if (replacement == null)
                            {
                                Error = new ErrorIluminationState(this);
                            }
                            else
                            {
                                Error = (ErrorIluminationState)replacement;
                            }
                        }
                    }

                    instance = Error;
                    break;
                }

                case BeltIdentifier.BrowseNames.Busy:
                {
                    if (createOrReplace)
                    {
                        if (Busy == null)
                        {
                            if (replacement == null)
                            {
                                Busy = new BusyIluminationState(this);
                            }
                            else
                            {
                                Busy = (BusyIluminationState)replacement;
                            }
                        }
                    }

                    instance = Busy;
                    break;
                }

                case BeltIdentifier.BrowseNames.Transparent:
                {
                    if (createOrReplace)
                    {
                        if (Transparent == null)
                        {
                            if (replacement == null)
                            {
                                Transparent = new TransparentPieceState(this);
                            }
                            else
                            {
                                Transparent = (TransparentPieceState)replacement;
                            }
                        }
                    }

                    instance = Transparent;
                    break;
                }

                case BeltIdentifier.BrowseNames.Metallic:
                {
                    if (createOrReplace)
                    {
                        if (Metallic == null)
                        {
                            if (replacement == null)
                            {
                                Metallic = new MetallicPieceState(this);
                            }
                            else
                            {
                                Metallic = (MetallicPieceState)replacement;
                            }
                        }
                    }

                    instance = Metallic;
                    break;
                }

                case BeltIdentifier.BrowseNames.NonMetallic:
                {
                    if (createOrReplace)
                    {
                        if (NonMetallic == null)
                        {
                            if (replacement == null)
                            {
                                NonMetallic = new NonMetallicPieceState(this);
                            }
                            else
                            {
                                NonMetallic = (NonMetallicPieceState)replacement;
                            }
                        }
                    }

                    instance = NonMetallic;
                    break;
                }

                case BeltIdentifier.BrowseNames.QuantityTransparent:
                {
                    if (createOrReplace)
                    {
                        if (QuantityTransparent == null)
                        {
                            if (replacement == null)
                            {
                                QuantityTransparent = new QuantityTransparentPieceState(this);
                            }
                            else
                            {
                                QuantityTransparent = (QuantityTransparentPieceState)replacement;
                            }
                        }
                    }

                    instance = QuantityTransparent;
                    break;
                }

                case BeltIdentifier.BrowseNames.QuantityMetallic:
                {
                    if (createOrReplace)
                    {
                        if (QuantityMetallic == null)
                        {
                            if (replacement == null)
                            {
                                QuantityMetallic = new QuantityMetallicPieceState(this);
                            }
                            else
                            {
                                QuantityMetallic = (QuantityMetallicPieceState)replacement;
                            }
                        }
                    }

                    instance = QuantityMetallic;
                    break;
                }

                case BeltIdentifier.BrowseNames.QuantityNonMetallic:
                {
                    if (createOrReplace)
                    {
                        if (QuantityNonMetallic == null)
                        {
                            if (replacement == null)
                            {
                                QuantityNonMetallic = new QuantityNonMetallicPieceState(this);
                            }
                            else
                            {
                                QuantityNonMetallic = (QuantityNonMetallicPieceState)replacement;
                            }
                        }
                    }

                    instance = QuantityNonMetallic;
                    break;
                }

                case BeltIdentifier.BrowseNames.Motor:
                {
                    if (createOrReplace)
                    {
                        if (Motor == null)
                        {
                            if (replacement == null)
                            {
                                Motor = new MotorState(this);
                            }
                            else
                            {
                                Motor = (MotorState)replacement;
                            }
                        }
                    }

                    instance = Motor;
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
        private ErrorIluminationState m_error;
        private BusyIluminationState m_busy;
        private TransparentPieceState m_transparent;
        private MetallicPieceState m_metallic;
        private NonMetallicPieceState m_nonMetallic;
        private QuantityTransparentPieceState m_quantityTransparent;
        private QuantityMetallicPieceState m_quantityMetallic;
        private QuantityNonMetallicPieceState m_quantityNonMetallic;
        private MotorState m_motor;
        #endregion
    }
    #endif
    #endregion

    #region Module2State Class
    #if (!OPCUA_EXCLUDE_Module2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Module2State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Module2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.Module2Type, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABMAAABNb2R1bGUyVHlwZUluc3RhbmNlAQGqAAEBqgCqAAAAAQAAAAAwAAEBqwAJAAAAhGCACgEAAAAB" +
           "AAgAAABCYXJyaWVyMQEBqwAALwEBHQCrAAAAAQEAAAAAMAEBAaoAAQAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGsAAAvAQBACawAAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGwAAAu" +
           "AESwAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAgAAABCYXJyaWVyMgEBsgAALwEBHQCyAAAA" +
           "Af////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAbMAAC8BAEAJswAAAAAB/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAbcAAC4ARLcAAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEA" +
           "CAAAAEJhcnJpZXIzAQG5AAAvAQEdALkAAAAB/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBugAA" +
           "LwEAQAm6AAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBvgAALgBEvgAAAAEA" +
           "dAP/////AQH/////AAAAAIRggAoBAAAAAQALAAAAUGhvdG9TZW5zb3IBAcAAAC8BASQAwAAAAAH/////" +
           "AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQHBAAAvAQBACcEAAAAAAf////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQHFAAAuAETFAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAoAAABD" +
           "YXBhY2l0aXZlAQHHAAAvAQErAMcAAAAB/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEByAAALwEA" +
           "QAnIAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBzAAALgBEzAAAAAEAdAP/" +
           "////AQH/////AAAAAIRggAoBAAAAAQAJAAAASW5kdWN0aXZlAQHOAAAvAQEyAM4AAAAB/////wEAAAAV" +
           "YIkKAgAAAAEABgAAAE91dHB1dAEBzwAALwEAQAnPAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEB0wAALgBE0wAAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAFAAAARXJyb3IB" +
           "AdUAAC8BAU4A1QAAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAdYAAC8BAEAJ1gAAAAAB////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdoAAC4ARNoAAAABAHQD/////wEB/////wAA" +
           "AACEYIAKAQAAAAEABAAAAEJ1c3kBATQDAC8BASYDNAMAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5w" +
           "dXQBATUDAC8BAEAJNQMAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATkDAC4A" +
           "RDkDAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEABQAAAE1vdG9yAQHcAAAvAQEfA9wAAAAB////" +
           "/wIAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQHdAAAvAQBACd0AAAAABv////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQHhAAAuAEThAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABT" +
           "dGF0dXMBAWkDAC8BAEAJaQMAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAW0D" +
           "AC4ARG0DAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public OpticalBarrierState Barrier1
        {
            get
            {
                return m_barrier1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier1 = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState Barrier2
        {
            get
            {
                return m_barrier2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier2 = value;
            }
        }

        /// <remarks />
        public OpticalBarrierState Barrier3
        {
            get
            {
                return m_barrier3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier3 = value;
            }
        }

        /// <remarks />
        public ElectricPhotoSensorState PhotoSensor
        {
            get
            {
                return m_photoSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_photoSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_photoSensor = value;
            }
        }

        /// <remarks />
        public CapacitiveSensorState Capacitive
        {
            get
            {
                return m_capacitive;
            }

            set
            {
                if (!Object.ReferenceEquals(m_capacitive, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_capacitive = value;
            }
        }

        /// <remarks />
        public InductiveSensorState Inductive
        {
            get
            {
                return m_inductive;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inductive, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inductive = value;
            }
        }

        /// <remarks />
        public ErrorIluminationState Error
        {
            get
            {
                return m_error;
            }

            set
            {
                if (!Object.ReferenceEquals(m_error, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_error = value;
            }
        }

        /// <remarks />
        public BusyIluminationState Busy
        {
            get
            {
                return m_busy;
            }

            set
            {
                if (!Object.ReferenceEquals(m_busy, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_busy = value;
            }
        }

        /// <remarks />
        public MotorState Motor
        {
            get
            {
                return m_motor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_barrier1 != null)
            {
                children.Add(m_barrier1);
            }

            if (m_barrier2 != null)
            {
                children.Add(m_barrier2);
            }

            if (m_barrier3 != null)
            {
                children.Add(m_barrier3);
            }

            if (m_photoSensor != null)
            {
                children.Add(m_photoSensor);
            }

            if (m_capacitive != null)
            {
                children.Add(m_capacitive);
            }

            if (m_inductive != null)
            {
                children.Add(m_inductive);
            }

            if (m_error != null)
            {
                children.Add(m_error);
            }

            if (m_busy != null)
            {
                children.Add(m_busy);
            }

            if (m_motor != null)
            {
                children.Add(m_motor);
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
                case BeltIdentifier.BrowseNames.Barrier1:
                {
                    if (createOrReplace)
                    {
                        if (Barrier1 == null)
                        {
                            if (replacement == null)
                            {
                                Barrier1 = new OpticalBarrierState(this);
                            }
                            else
                            {
                                Barrier1 = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = Barrier1;
                    break;
                }

                case BeltIdentifier.BrowseNames.Barrier2:
                {
                    if (createOrReplace)
                    {
                        if (Barrier2 == null)
                        {
                            if (replacement == null)
                            {
                                Barrier2 = new OpticalBarrierState(this);
                            }
                            else
                            {
                                Barrier2 = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = Barrier2;
                    break;
                }

                case BeltIdentifier.BrowseNames.Barrier3:
                {
                    if (createOrReplace)
                    {
                        if (Barrier3 == null)
                        {
                            if (replacement == null)
                            {
                                Barrier3 = new OpticalBarrierState(this);
                            }
                            else
                            {
                                Barrier3 = (OpticalBarrierState)replacement;
                            }
                        }
                    }

                    instance = Barrier3;
                    break;
                }

                case BeltIdentifier.BrowseNames.PhotoSensor:
                {
                    if (createOrReplace)
                    {
                        if (PhotoSensor == null)
                        {
                            if (replacement == null)
                            {
                                PhotoSensor = new ElectricPhotoSensorState(this);
                            }
                            else
                            {
                                PhotoSensor = (ElectricPhotoSensorState)replacement;
                            }
                        }
                    }

                    instance = PhotoSensor;
                    break;
                }

                case BeltIdentifier.BrowseNames.Capacitive:
                {
                    if (createOrReplace)
                    {
                        if (Capacitive == null)
                        {
                            if (replacement == null)
                            {
                                Capacitive = new CapacitiveSensorState(this);
                            }
                            else
                            {
                                Capacitive = (CapacitiveSensorState)replacement;
                            }
                        }
                    }

                    instance = Capacitive;
                    break;
                }

                case BeltIdentifier.BrowseNames.Inductive:
                {
                    if (createOrReplace)
                    {
                        if (Inductive == null)
                        {
                            if (replacement == null)
                            {
                                Inductive = new InductiveSensorState(this);
                            }
                            else
                            {
                                Inductive = (InductiveSensorState)replacement;
                            }
                        }
                    }

                    instance = Inductive;
                    break;
                }

                case BeltIdentifier.BrowseNames.Error:
                {
                    if (createOrReplace)
                    {
                        if (Error == null)
                        {
                            if (replacement == null)
                            {
                                Error = new ErrorIluminationState(this);
                            }
                            else
                            {
                                Error = (ErrorIluminationState)replacement;
                            }
                        }
                    }

                    instance = Error;
                    break;
                }

                case BeltIdentifier.BrowseNames.Busy:
                {
                    if (createOrReplace)
                    {
                        if (Busy == null)
                        {
                            if (replacement == null)
                            {
                                Busy = new BusyIluminationState(this);
                            }
                            else
                            {
                                Busy = (BusyIluminationState)replacement;
                            }
                        }
                    }

                    instance = Busy;
                    break;
                }

                case BeltIdentifier.BrowseNames.Motor:
                {
                    if (createOrReplace)
                    {
                        if (Motor == null)
                        {
                            if (replacement == null)
                            {
                                Motor = new MotorState(this);
                            }
                            else
                            {
                                Motor = (MotorState)replacement;
                            }
                        }
                    }

                    instance = Motor;
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
        private OpticalBarrierState m_barrier1;
        private OpticalBarrierState m_barrier2;
        private OpticalBarrierState m_barrier3;
        private ElectricPhotoSensorState m_photoSensor;
        private CapacitiveSensorState m_capacitive;
        private InductiveSensorState m_inductive;
        private ErrorIluminationState m_error;
        private BusyIluminationState m_busy;
        private MotorState m_motor;
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
           "ABAAAABCZWx0VHlwZUluc3RhbmNlAQHjAAEB4wDjAAAAAQEAAAAAMAABAeQACAAAAIRgwAoBAAAABwAA" +
           "AE1vZHVsZTEBAA0AAABCZWx0IE1vZHVsZSAxAQHkAAAvAQFxAOQAAAABAgAAAAAwAQEB4wAAMAABAeUA" +
           "CQAAAIRggAoBAAAAAQAFAAAARXJyb3IBAeUAAC8BAU4A5QAAAAEBAAAAADABAQHkAAEAAAAVYIkKAgAA" +
           "AAEABQAAAElucHV0AQHmAAAvAQBACeYAAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQHqAAAuAETqAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAQAAABCdXN5AQE7AwAvAQEm" +
           "AzsDAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQE8AwAvAQBACTwDAAAAAf////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFAAwAuAERAAwAAAQB0A/////8BAf////8AAAAAhGCACgEA" +
           "AAABAAsAAABUcmFuc3BhcmVudAEBrwMALwEBkwOvAwAAAf////8BAAAAFWCJCgIAAAABAAUAAABJbnB1" +
           "dAEBsAMALwEAQAmwAwAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtAMALgBE" +
           "tAMAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAIAAAATWV0YWxsaWMBAfMAAC8BAUAA8wAAAAH/" +
           "////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAfQAAC8BAEAJ9AAAAAAB/////wMD/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAfgAAC4ARPgAAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACwAA" +
           "AE5vbk1ldGFsbGljAQH6AAAvAQFHAPoAAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQH7AAAv" +
           "AQBACfsAAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH/AAAuAET/AAAAAQB0" +
           "A/////8BAf////8AAAAAhGCACgEAAAABABMAAABRdWFudGl0eVRyYW5zcGFyZW50AQG2AwAvAQGaA7YD" +
           "AAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQG3AwAvAQBACbcDAAAABv////8DA/////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQG7AwAuAES7AwAAAQB0A/////8BAf////8AAAAAhGCACgEAAAAB" +
           "ABAAAABRdWFudGl0eU1ldGFsbGljAQEIAQAvAQFcAAgBAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElu" +
           "cHV0AQEJAQAvAQBACQkBAAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQENAQAu" +
           "AEQNAQAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABABMAAABRdWFudGl0eU5vbk1ldGFsbGljAQEP" +
           "AQAvAQFjAA8BAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQEQAQAvAQBACRABAAAABv////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEUAQAuAEQUAQAAAQB0A/////8BAf////8AAAAA" +
           "hGCACgEAAAABAAUAAABNb3RvcgEBFgEALwEBHwMWAQAAAf////8CAAAAFWCJCgIAAAABAAUAAABTcGVl" +
           "ZAEBFwEALwEAQAkXAQAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBGwEALgBE" +
           "GwEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAU3RhdHVzAQFvAwAvAQBACW8DAAAAAf//" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFzAwAuAERzAwAAAQB0A/////8BAf////8A" +
           "AAAAhGDACgEAAAAHAAAATW9kdWxlMgEADQAAAEJlbHQgTW9kdWxlIDIBAR0BAC8BAaoAHQEAAAEBAAAA" +
           "ADAAAQEeAQkAAACEYIAKAQAAAAEACAAAAEJhcnJpZXIxAQEeAQAvAQEdAB4BAAABAQAAAAAwAQEBHQEB" +
           "AAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAR8BAC8BAEAJHwEAAAAB/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBASMBAC4ARCMBAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACAAAAEJh" +
           "cnJpZXIyAQElAQAvAQEdACUBAAAB/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBJgEALwEAQAkm" +
           "AQAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBKgEALgBEKgEAAAEAdAP/////" +
           "AQH/////AAAAAIRggAoBAAAAAQAIAAAAQmFycmllcjMBASwBAC8BAR0ALAEAAAH/////AQAAABVgiQoC" +
           "AAAAAQAGAAAAT3V0cHV0AQEtAQAvAQBACS0BAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQExAQAuAEQxAQAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAsAAABQaG90b1NlbnNv" +
           "cgEBMwEALwEBJAAzAQAAAf////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBATQBAC8BAEAJNAEAAAAB" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATgBAC4ARDgBAAABAHQD/////wEB////" +
           "/wAAAACEYIAKAQAAAAEACgAAAENhcGFjaXRpdmUBAToBAC8BASsAOgEAAAH/////AQAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AQE7AQAvAQBACTsBAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQE/AQAuAEQ/AQAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAkAAABJbmR1Y3RpdmUBAUEB" +
           "AC8BATIAQQEAAAH/////AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFCAQAvAQBACUIBAAAAAf////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFGAQAuAERGAQAAAQB0A/////8BAf////8AAAAA" +
           "hGCACgEAAAABAAUAAABFcnJvcgEBSAEALwEBTgBIAQAAAf////8BAAAAFWCJCgIAAAABAAUAAABJbnB1" +
           "dAEBSQEALwEAQAlJAQAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBTQEALgBE" +
           "TQEAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAEAAAAQnVzeQEBQgMALwEBJgNCAwAAAf////8B" +
           "AAAAFWCJCgIAAAABAAUAAABJbnB1dAEBQwMALwEAQAlDAwAAAAH/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBRwMALgBERwMAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAFAAAATW90" +
           "b3IBAU8BAC8BAR8DTwEAAAH/////AgAAABVgiQoCAAAAAQAFAAAAU3BlZWQBAVABAC8BAEAJUAEAAAAG" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVQBAC4ARFQBAAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBdQMALwEAQAl1AwAAAAH/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBeQMALgBEeQMAAAEAdAP/////AQH/////AAAAAARhggoEAAAAAQATAAAA" +
           "U3RhcnRNb2R1bGUxUHJvY2VzcwEBhwMALwEBhwOHAwAAAQH/////AAAAAARhggoEAAAAAQASAAAAU3Rv" +
           "cE1vZHVsZTFQcm9jZXNzAQGIAwAvAQGIA4gDAAABAf////8AAAAABGGCCgQAAAABABMAAABSZXNldE1v" +
           "ZHVsZTFQcm9jZXNzAQGJAwAvAQGJA4kDAAABAf////8AAAAABGGCCgQAAAABABMAAABTdGFydE1vZHVs" +
           "ZTJQcm9jZXNzAQGKAwAvAQGKA4oDAAABAf////8AAAAABGGCCgQAAAABABIAAABTdG9wTW9kdWxlMlBy" +
           "b2Nlc3MBAYsDAC8BAYsDiwMAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAFJlc2V0TW9kdWxlMlByb2Nl" +
           "c3MBAYwDAC8BAYwDjAMAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public Module1State Module1
        {
            get
            {
                return m_module1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_module1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_module1 = value;
            }
        }

        /// <remarks />
        public Module2State Module2
        {
            get
            {
                return m_module2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_module2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_module2 = value;
            }
        }

        /// <remarks />
        public MethodState StartModule1Process
        {
            get
            {
                return m_startModule1ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startModule1ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startModule1ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopModule1Process
        {
            get
            {
                return m_stopModule1ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopModule1ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopModule1ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState ResetModule1Process
        {
            get
            {
                return m_resetModule1ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetModule1ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetModule1ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StartModule2Process
        {
            get
            {
                return m_startModule2ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startModule2ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startModule2ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopModule2Process
        {
            get
            {
                return m_stopModule2ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopModule2ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopModule2ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState ResetModule2Process
        {
            get
            {
                return m_resetModule2ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetModule2ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetModule2ProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_module1 != null)
            {
                children.Add(m_module1);
            }

            if (m_module2 != null)
            {
                children.Add(m_module2);
            }

            if (m_startModule1ProcessMethod != null)
            {
                children.Add(m_startModule1ProcessMethod);
            }

            if (m_stopModule1ProcessMethod != null)
            {
                children.Add(m_stopModule1ProcessMethod);
            }

            if (m_resetModule1ProcessMethod != null)
            {
                children.Add(m_resetModule1ProcessMethod);
            }

            if (m_startModule2ProcessMethod != null)
            {
                children.Add(m_startModule2ProcessMethod);
            }

            if (m_stopModule2ProcessMethod != null)
            {
                children.Add(m_stopModule2ProcessMethod);
            }

            if (m_resetModule2ProcessMethod != null)
            {
                children.Add(m_resetModule2ProcessMethod);
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
                case BeltIdentifier.BrowseNames.Module1:
                {
                    if (createOrReplace)
                    {
                        if (Module1 == null)
                        {
                            if (replacement == null)
                            {
                                Module1 = new Module1State(this);
                            }
                            else
                            {
                                Module1 = (Module1State)replacement;
                            }
                        }
                    }

                    instance = Module1;
                    break;
                }

                case BeltIdentifier.BrowseNames.Module2:
                {
                    if (createOrReplace)
                    {
                        if (Module2 == null)
                        {
                            if (replacement == null)
                            {
                                Module2 = new Module2State(this);
                            }
                            else
                            {
                                Module2 = (Module2State)replacement;
                            }
                        }
                    }

                    instance = Module2;
                    break;
                }

                case BeltIdentifier.BrowseNames.StartModule1Process:
                {
                    if (createOrReplace)
                    {
                        if (StartModule1Process == null)
                        {
                            if (replacement == null)
                            {
                                StartModule1Process = new MethodState(this);
                            }
                            else
                            {
                                StartModule1Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartModule1Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.StopModule1Process:
                {
                    if (createOrReplace)
                    {
                        if (StopModule1Process == null)
                        {
                            if (replacement == null)
                            {
                                StopModule1Process = new MethodState(this);
                            }
                            else
                            {
                                StopModule1Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopModule1Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.ResetModule1Process:
                {
                    if (createOrReplace)
                    {
                        if (ResetModule1Process == null)
                        {
                            if (replacement == null)
                            {
                                ResetModule1Process = new MethodState(this);
                            }
                            else
                            {
                                ResetModule1Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetModule1Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.StartModule2Process:
                {
                    if (createOrReplace)
                    {
                        if (StartModule2Process == null)
                        {
                            if (replacement == null)
                            {
                                StartModule2Process = new MethodState(this);
                            }
                            else
                            {
                                StartModule2Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartModule2Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.StopModule2Process:
                {
                    if (createOrReplace)
                    {
                        if (StopModule2Process == null)
                        {
                            if (replacement == null)
                            {
                                StopModule2Process = new MethodState(this);
                            }
                            else
                            {
                                StopModule2Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopModule2Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.ResetModule2Process:
                {
                    if (createOrReplace)
                    {
                        if (ResetModule2Process == null)
                        {
                            if (replacement == null)
                            {
                                ResetModule2Process = new MethodState(this);
                            }
                            else
                            {
                                ResetModule2Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetModule2Process;
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
        private Module1State m_module1;
        private Module2State m_module2;
        private MethodState m_startModule1ProcessMethod;
        private MethodState m_stopModule1ProcessMethod;
        private MethodState m_resetModule1ProcessMethod;
        private MethodState m_startModule2ProcessMethod;
        private MethodState m_stopModule2ProcessMethod;
        private MethodState m_resetModule2ProcessMethod;
        #endregion
    }
    #endif
    #endregion
}