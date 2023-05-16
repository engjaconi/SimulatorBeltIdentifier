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
           "ABgAAABHZW5lcmljTW90b3JUeXBlSW5zdGFuY2UBARYAAQEWABYAAAD/////AwAAABVgiQoCAAAAAQAL" +
           "AAAASm91cm5leVRpbWUBAcsDAC8BAEAJywMAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAc8DAC4ARM8DAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEludGVydmFsAQH7" +
           "AwAvAQBACfsDAAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH/AwAuAET/AwAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABTdGF0dXMBAVcDAC8BAEAJVwMAAAAB/////wMD" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVsDAC4ARFsDAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<int> JourneyTime
        {
            get
            {
                return m_journeyTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_journeyTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_journeyTime = value;
            }
        }

        /// <remarks />
        public AnalogItemState<int> Interval
        {
            get
            {
                return m_interval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_interval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_interval = value;
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
            if (m_journeyTime != null)
            {
                children.Add(m_journeyTime);
            }

            if (m_interval != null)
            {
                children.Add(m_interval);
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
                case BeltIdentifier.BrowseNames.JourneyTime:
                {
                    if (createOrReplace)
                    {
                        if (JourneyTime == null)
                        {
                            if (replacement == null)
                            {
                                JourneyTime = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                JourneyTime = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = JourneyTime;
                    break;
                }

                case BeltIdentifier.BrowseNames.Interval:
                {
                    if (createOrReplace)
                    {
                        if (Interval == null)
                        {
                            if (replacement == null)
                            {
                                Interval = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                Interval = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = Interval;
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
        private AnalogItemState<int> m_journeyTime;
        private AnalogItemState<int> m_interval;
        private AnalogItemState<bool> m_status;
        #endregion
    }
    #endif
    #endregion

    #region IsAutoIluminationState Class
    #if (!OPCUA_EXCLUDE_IsAutoIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsAutoIluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public IsAutoIluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.IsAutoIlumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABkAAABJc0F1dG9JbHVtaW5hdGlvbkluc3RhbmNlAQEBBAEBAQQBBAAA/////wEAAAAVYIkKAgAAAAEA" +
           "BQAAAElucHV0AQECBAAvAQBACQIEAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQEGBAAuAEQGBAAAAQB0A/////8BAf////8AAAAA";
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

    #region IsModule1IluminationState Class
    #if (!OPCUA_EXCLUDE_IsModule1IluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsModule1IluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public IsModule1IluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.IsModule1Ilumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABwAAABJc01vZHVsZTFJbHVtaW5hdGlvbkluc3RhbmNlAQEIBAEBCAQIBAAA/////wEAAAAVYIkKAgAA" +
           "AAEABQAAAElucHV0AQEJBAAvAQBACQkEAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQENBAAuAEQNBAAAAQB0A/////8BAf////8AAAAA";
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

    #region IsBusyIluminationState Class
    #if (!OPCUA_EXCLUDE_IsBusyIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsBusyIluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public IsBusyIluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.IsBusyIlumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABkAAABJc0J1c3lJbHVtaW5hdGlvbkluc3RhbmNlAQGRBAEBkQSRBAAA/////wEAAAAVYIkKAgAAAAEA" +
           "BQAAAElucHV0AQGSBAAvAQBACZIEAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQGWBAAuAESWBAAAAQB0A/////8BAf////8AAAAA";
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

    #region IsErrorIluminationState Class
    #if (!OPCUA_EXCLUDE_IsErrorIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsErrorIluminationState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public IsErrorIluminationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.IsErrorIlumination, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABoAAABJc0Vycm9ySWx1bWluYXRpb25JbnN0YW5jZQEBmAQBAZgEmAQAAP////8BAAAAFWCJCgIAAAAB" +
           "AAUAAABJbnB1dAEBmQQALwEAQAmZBAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBnQQALgBEnQQAAAEAdAP/////AQH/////AAAAAA==";
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
           "ABEAAABNb3RvclR5cGVJbnN0YW5jZQEBHwMBAR8DHwMAAP////8DAAAAFWCJCgIAAAABAAsAAABKb3Vy" +
           "bmV5VGltZQEB0QMALwEAQAnRAwAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "1QMALgBE1QMAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAIAAAASW50ZXJ2YWwBAQ8EAC8BAEAJ" +
           "DwQAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARMEAC4ARBMEAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBXQMALwEAQAldAwAAAAH/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBYQMALgBEYQMAAAEAdAP/////AQH/////AAAAAA==";
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
           "ABMAAABNb2R1bGUxVHlwZUluc3RhbmNlAQFxAAEBcQBxAAAAAQAAAAAwAAEBoQMGAAAAhGCACgEAAAAB" +
           "AAsAAABUcmFuc3BhcmVudAEBoQMALwEBkwOhAwAAAQEAAAAAMAEBAXEAAQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAaIDAC8BAEAJogMAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAaYD" +
           "AC4ARKYDAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACAAAAE1ldGFsbGljAQGAAAAvAQFAAIAA" +
           "AAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQGBAAAvAQBACYEAAAAAAf////8DA/////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQGFAAAuAESFAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAAB" +
           "AAsAAABOb25NZXRhbGxpYwEBhwAALwEBRwCHAAAAAf////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB" +
           "iAAALwEAQAmIAAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBjAAALgBEjAAA" +
           "AAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQATAAAAUXVhbnRpdHlUcmFuc3BhcmVudAEBqAMALwEB" +
           "mgOoAwAAAf////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBqQMALwEAQAmpAwAAAAb/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrQMALgBErQMAAAEAdAP/////AQH/////AAAAAIRggAoB" +
           "AAAAAQAQAAAAUXVhbnRpdHlNZXRhbGxpYwEBlQAALwEBXACVAAAAAf////8BAAAAFWCJCgIAAAABAAUA" +
           "AABJbnB1dAEBlgAALwEAQAmWAAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "mgAALgBEmgAAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQATAAAAUXVhbnRpdHlOb25NZXRhbGxp" +
           "YwEBnAAALwEBYwCcAAAAAf////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBnQAALwEAQAmdAAAAAAb/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBoQAALgBEoQAAAAEAdAP/////AQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
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
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private TransparentPieceState m_transparent;
        private MetallicPieceState m_metallic;
        private NonMetallicPieceState m_nonMetallic;
        private QuantityTransparentPieceState m_quantityTransparent;
        private QuantityMetallicPieceState m_quantityMetallic;
        private QuantityNonMetallicPieceState m_quantityNonMetallic;
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
           "ABMAAABNb2R1bGUyVHlwZUluc3RhbmNlAQGqAAEBqgCqAAAAAQAAAAAwAAEBqwAGAAAAhGCACgEAAAAB" +
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
           "AAAARVVSYW5nZQEB0wAALgBE0wAAAAEAdAP/////AQH/////AAAAAA==";
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
           "ABAAAABCZWx0VHlwZUluc3RhbmNlAQHjAAEB4wDjAAAAAQEAAAAAMAABARsEEQAAAIRggAoBAAAAAQAG" +
           "AAAASXNBdXRvAQEbBAAvAQEBBBsEAAABAQAAAAAwAQEB4wABAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB" +
           "HAQALwEAQAkcBAAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBIAQALgBEIAQA" +
           "AAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAJAAAASXNNb2R1bGUxAQEiBAAvAQEIBCIEAAAB////" +
           "/wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQEjBAAvAQBACSMEAAAAAf////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEnBAAuAEQnBAAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAHAAAASXNF" +
           "cnJvcgEABQAAAEVycm9yAQGfBAAvAQGYBJ8EAAAB/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQGg" +
           "BAAvAQBACaAEAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGkBAAuAESkBAAA" +
           "AQB0A/////8BAf////8AAAAAhGDACgEAAAAGAAAASXNCdXN5AQAEAAAAQnVzeQEBpgQALwEBkQSmBAAA" +
           "Af////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBpwQALwEAQAmnBAAAAAH/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBqwQALgBEqwQAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAF" +
           "AAAATW90b3IBATcEAC8BAR8DNwQAAAH/////AwAAABVgiQoCAAAAAQALAAAASm91cm5leVRpbWUBATgE" +
           "AC8BAEAJOAQAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATwEAC4ARDwEAAAB" +
           "AHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEludGVydmFsAQE+BAAvAQBACT4EAAAABv////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFCBAAuAERCBAAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAYAAABTdGF0dXMBAUQEAC8BAEAJRAQAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAUgEAC4AREgEAAABAHQD/////wEB/////wAAAACEYMAKAQAAAAcAAABNb2R1bGUx" +
           "AQANAAAAQmVsdCBNb2R1bGUgMQEB5AAALwEBcQDkAAAAAQEAAAAAMAABAa8DBgAAAIRggAoBAAAAAQAL" +
           "AAAAVHJhbnNwYXJlbnQBAa8DAC8BAZMDrwMAAAEBAAAAADABAQHkAAEAAAAVYIkKAgAAAAEABQAAAElu" +
           "cHV0AQGwAwAvAQBACbADAAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQG0AwAu" +
           "AES0AwAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAgAAABNZXRhbGxpYwEB8wAALwEBQADzAAAA" +
           "Af////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB9AAALwEAQAn0AAAAAAH/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEB+AAALgBE+AAAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAL" +
           "AAAATm9uTWV0YWxsaWMBAfoAAC8BAUcA+gAAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAfsA" +
           "AC8BAEAJ+wAAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAf8AAC4ARP8AAAAB" +
           "AHQD/////wEB/////wAAAACEYIAKAQAAAAEAEwAAAFF1YW50aXR5VHJhbnNwYXJlbnQBAbYDAC8BAZoD" +
           "tgMAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAbcDAC8BAEAJtwMAAAAG/////wMD/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAbsDAC4ARLsDAAABAHQD/////wEB/////wAAAACEYIAKAQAA" +
           "AAEAEAAAAFF1YW50aXR5TWV0YWxsaWMBAQgBAC8BAVwACAEAAAH/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAQkBAC8BAEAJCQEAAAAG/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQ0B" +
           "AC4ARA0BAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEAEwAAAFF1YW50aXR5Tm9uTWV0YWxsaWMB" +
           "AQ8BAC8BAWMADwEAAAH/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBARABAC8BAEAJEAEAAAAG////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARQBAC4ARBQBAAABAHQD/////wEB/////wAA" +
           "AACEYMAKAQAAAAcAAABNb2R1bGUyAQANAAAAQmVsdCBNb2R1bGUgMgEBHQEALwEBqgAdAQAAAQEAAAAA" +
           "MAABAR4BBgAAAIRggAoBAAAAAQAIAAAAQmFycmllcjEBAR4BAC8BAR0AHgEAAAEBAAAAADABAQEdAQEA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEBHwEALwEAQAkfAQAAAAH/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBIwEALgBEIwEAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQAIAAAAQmFy" +
           "cmllcjIBASUBAC8BAR0AJQEAAAH/////AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEmAQAvAQBACSYB" +
           "AAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEqAQAuAEQqAQAAAQB0A/////8B" +
           "Af////8AAAAAhGCACgEAAAABAAgAAABCYXJyaWVyMwEBLAEALwEBHQAsAQAAAf////8BAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAS0BAC8BAEAJLQEAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBATEBAC4ARDEBAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACwAAAFBob3RvU2Vuc29y" +
           "AQEzAQAvAQEkADMBAAAB/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBNAEALwEAQAk0AQAAAAH/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBOAEALgBEOAEAAAEAdAP/////AQH/////" +
           "AAAAAIRggAoBAAAAAQAKAAAAQ2FwYWNpdGl2ZQEBOgEALwEBKwA6AQAAAf////8BAAAAFWCJCgIAAAAB" +
           "AAYAAABPdXRwdXQBATsBAC8BAEAJOwEAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAT8BAC4ARD8BAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACQAAAEluZHVjdGl2ZQEBQQEA" +
           "LwEBMgBBAQAAAf////8BAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAUIBAC8BAEAJQgEAAAAB/////wMD" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUYBAC4AREYBAAABAHQD/////wEB/////wAAAAAE" +
           "YYIKBAAAAAEADAAAAFN0YXJ0UHJvY2VzcwEBVgEALwEBVgFWAQAAAQH/////AAAAAARhggoEAAAAAQAL" +
           "AAAAU3RvcFByb2Nlc3MBAVcBAC8BAVcBVwEAAAEB/////wAAAAAEYYIKBAAAAAEADAAAAFJlc2V0UHJv" +
           "Y2VzcwEBWAEALwEBWAFYAQAAAQH/////AAAAAARhggoEAAAAAQAUAAAAU2VsZWN0TW9kdWxlMVByb2Nl" +
           "c3MBAVAEAC8BAVAEUAQAAAEB/////wAAAAAEYYIKBAAAAAEAFAAAAFNlbGVjdE1vZHVsZTJQcm9jZXNz" +
           "AQFRBAAvAQFRBFEEAAABAf////8AAAAABGGCCgQAAAABABoAAABBZGRUcmFuc3BhcmVudFBpZWNlUHJv" +
           "Y2VzcwEBUgQALwEBUgRSBAAAAQH/////AAAAAARhggoEAAAAAQAXAAAAQWRkTWV0YWxsaWNQaWVjZVBy" +
           "b2Nlc3MBAVMEAC8BAVMEUwQAAAEB/////wAAAAAEYYIKBAAAAAEAGgAAAEFkZE5vbk1ldGFsbGljUGll" +
           "Y2VQcm9jZXNzAQFUBAAvAQFUBFQEAAABAf////8AAAAABGGCCgQAAAABABMAAABTZWxlY3RNYW51YWxQ" +
           "cm9jZXNzAQG7BAAvAQG7BLsEAAABAf////8AAAAABGGCCgQAAAABABYAAABTZWxlY3RBdXRvbWF0aWNQ" +
           "cm9jZXNzAQFVBAAvAQFVBFUEAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public IsAutoIluminationState IsAuto
        {
            get
            {
                return m_isAuto;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isAuto, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isAuto = value;
            }
        }

        /// <remarks />
        public IsModule1IluminationState IsModule1
        {
            get
            {
                return m_isModule1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isModule1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isModule1 = value;
            }
        }

        /// <remarks />
        public IsErrorIluminationState IsError
        {
            get
            {
                return m_isError;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isError, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isError = value;
            }
        }

        /// <remarks />
        public IsBusyIluminationState IsBusy
        {
            get
            {
                return m_isBusy;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isBusy, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isBusy = value;
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
        public MethodState ResetProcess
        {
            get
            {
                return m_resetProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState SelectModule1Process
        {
            get
            {
                return m_selectModule1ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selectModule1ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selectModule1ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState SelectModule2Process
        {
            get
            {
                return m_selectModule2ProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selectModule2ProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selectModule2ProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState AddTransparentPieceProcess
        {
            get
            {
                return m_addTransparentPieceProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_addTransparentPieceProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addTransparentPieceProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState AddMetallicPieceProcess
        {
            get
            {
                return m_addMetallicPieceProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_addMetallicPieceProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addMetallicPieceProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState AddNonMetallicPieceProcess
        {
            get
            {
                return m_addNonMetallicPieceProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_addNonMetallicPieceProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addNonMetallicPieceProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState SelectManualProcess
        {
            get
            {
                return m_selectManualProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selectManualProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selectManualProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState SelectAutomaticProcess
        {
            get
            {
                return m_selectAutomaticProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selectAutomaticProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selectAutomaticProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isAuto != null)
            {
                children.Add(m_isAuto);
            }

            if (m_isModule1 != null)
            {
                children.Add(m_isModule1);
            }

            if (m_isError != null)
            {
                children.Add(m_isError);
            }

            if (m_isBusy != null)
            {
                children.Add(m_isBusy);
            }

            if (m_motor != null)
            {
                children.Add(m_motor);
            }

            if (m_module1 != null)
            {
                children.Add(m_module1);
            }

            if (m_module2 != null)
            {
                children.Add(m_module2);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            if (m_resetProcessMethod != null)
            {
                children.Add(m_resetProcessMethod);
            }

            if (m_selectModule1ProcessMethod != null)
            {
                children.Add(m_selectModule1ProcessMethod);
            }

            if (m_selectModule2ProcessMethod != null)
            {
                children.Add(m_selectModule2ProcessMethod);
            }

            if (m_addTransparentPieceProcessMethod != null)
            {
                children.Add(m_addTransparentPieceProcessMethod);
            }

            if (m_addMetallicPieceProcessMethod != null)
            {
                children.Add(m_addMetallicPieceProcessMethod);
            }

            if (m_addNonMetallicPieceProcessMethod != null)
            {
                children.Add(m_addNonMetallicPieceProcessMethod);
            }

            if (m_selectManualProcessMethod != null)
            {
                children.Add(m_selectManualProcessMethod);
            }

            if (m_selectAutomaticProcessMethod != null)
            {
                children.Add(m_selectAutomaticProcessMethod);
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
                case BeltIdentifier.BrowseNames.IsAuto:
                {
                    if (createOrReplace)
                    {
                        if (IsAuto == null)
                        {
                            if (replacement == null)
                            {
                                IsAuto = new IsAutoIluminationState(this);
                            }
                            else
                            {
                                IsAuto = (IsAutoIluminationState)replacement;
                            }
                        }
                    }

                    instance = IsAuto;
                    break;
                }

                case BeltIdentifier.BrowseNames.IsModule1:
                {
                    if (createOrReplace)
                    {
                        if (IsModule1 == null)
                        {
                            if (replacement == null)
                            {
                                IsModule1 = new IsModule1IluminationState(this);
                            }
                            else
                            {
                                IsModule1 = (IsModule1IluminationState)replacement;
                            }
                        }
                    }

                    instance = IsModule1;
                    break;
                }

                case BeltIdentifier.BrowseNames.IsError:
                {
                    if (createOrReplace)
                    {
                        if (IsError == null)
                        {
                            if (replacement == null)
                            {
                                IsError = new IsErrorIluminationState(this);
                            }
                            else
                            {
                                IsError = (IsErrorIluminationState)replacement;
                            }
                        }
                    }

                    instance = IsError;
                    break;
                }

                case BeltIdentifier.BrowseNames.IsBusy:
                {
                    if (createOrReplace)
                    {
                        if (IsBusy == null)
                        {
                            if (replacement == null)
                            {
                                IsBusy = new IsBusyIluminationState(this);
                            }
                            else
                            {
                                IsBusy = (IsBusyIluminationState)replacement;
                            }
                        }
                    }

                    instance = IsBusy;
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

                case BeltIdentifier.BrowseNames.ResetProcess:
                {
                    if (createOrReplace)
                    {
                        if (ResetProcess == null)
                        {
                            if (replacement == null)
                            {
                                ResetProcess = new MethodState(this);
                            }
                            else
                            {
                                ResetProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.SelectModule1Process:
                {
                    if (createOrReplace)
                    {
                        if (SelectModule1Process == null)
                        {
                            if (replacement == null)
                            {
                                SelectModule1Process = new MethodState(this);
                            }
                            else
                            {
                                SelectModule1Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SelectModule1Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.SelectModule2Process:
                {
                    if (createOrReplace)
                    {
                        if (SelectModule2Process == null)
                        {
                            if (replacement == null)
                            {
                                SelectModule2Process = new MethodState(this);
                            }
                            else
                            {
                                SelectModule2Process = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SelectModule2Process;
                    break;
                }

                case BeltIdentifier.BrowseNames.AddTransparentPieceProcess:
                {
                    if (createOrReplace)
                    {
                        if (AddTransparentPieceProcess == null)
                        {
                            if (replacement == null)
                            {
                                AddTransparentPieceProcess = new MethodState(this);
                            }
                            else
                            {
                                AddTransparentPieceProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = AddTransparentPieceProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.AddMetallicPieceProcess:
                {
                    if (createOrReplace)
                    {
                        if (AddMetallicPieceProcess == null)
                        {
                            if (replacement == null)
                            {
                                AddMetallicPieceProcess = new MethodState(this);
                            }
                            else
                            {
                                AddMetallicPieceProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = AddMetallicPieceProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.AddNonMetallicPieceProcess:
                {
                    if (createOrReplace)
                    {
                        if (AddNonMetallicPieceProcess == null)
                        {
                            if (replacement == null)
                            {
                                AddNonMetallicPieceProcess = new MethodState(this);
                            }
                            else
                            {
                                AddNonMetallicPieceProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = AddNonMetallicPieceProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.SelectManualProcess:
                {
                    if (createOrReplace)
                    {
                        if (SelectManualProcess == null)
                        {
                            if (replacement == null)
                            {
                                SelectManualProcess = new MethodState(this);
                            }
                            else
                            {
                                SelectManualProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SelectManualProcess;
                    break;
                }

                case BeltIdentifier.BrowseNames.SelectAutomaticProcess:
                {
                    if (createOrReplace)
                    {
                        if (SelectAutomaticProcess == null)
                        {
                            if (replacement == null)
                            {
                                SelectAutomaticProcess = new MethodState(this);
                            }
                            else
                            {
                                SelectAutomaticProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SelectAutomaticProcess;
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
        private IsAutoIluminationState m_isAuto;
        private IsModule1IluminationState m_isModule1;
        private IsErrorIluminationState m_isError;
        private IsBusyIluminationState m_isBusy;
        private MotorState m_motor;
        private Module1State m_module1;
        private Module2State m_module2;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        private MethodState m_resetProcessMethod;
        private MethodState m_selectModule1ProcessMethod;
        private MethodState m_selectModule2ProcessMethod;
        private MethodState m_addTransparentPieceProcessMethod;
        private MethodState m_addMetallicPieceProcessMethod;
        private MethodState m_addNonMetallicPieceProcessMethod;
        private MethodState m_selectManualProcessMethod;
        private MethodState m_selectAutomaticProcessMethod;
        #endregion
    }
    #endif
    #endregion
}