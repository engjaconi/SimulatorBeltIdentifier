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
    #region StartButtonState Class
    #if (!OPCUA_EXCLUDE_StartButtonState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartButtonState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public StartButtonState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.StartButtonType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABTdGFydEJ1dHRvblR5cGVJbnN0YW5jZQEBAQABAQEAAQAAAP////8BAAAAFWCJCgIAAAABAAcA" +
           "AABTdGFydGVkAQECAAAvAQBECQIAAAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> Started
        {
            get
            {
                return m_started;
            }

            set
            {
                if (!Object.ReferenceEquals(m_started, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_started = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_started != null)
            {
                children.Add(m_started);
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
                case BeltIdentifier.BrowseNames.Started:
                {
                    if (createOrReplace)
                    {
                        if (Started == null)
                        {
                            if (replacement == null)
                            {
                                Started = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                Started = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Started;
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
        private DiscreteItemState<bool> m_started;
        #endregion
    }
    #endif
    #endregion

    #region ResetButtonState Class
    #if (!OPCUA_EXCLUDE_ResetButtonState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResetButtonState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ResetButtonState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.ResetButtonType, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABSZXNldEJ1dHRvblR5cGVJbnN0YW5jZQEBBQABAQUABQAAAP////8BAAAAFWCJCgIAAAABAAcA" +
           "AABSZXNldGVkAQEGAAAvAQBECQYAAAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> Reseted
        {
            get
            {
                return m_reseted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_reseted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_reseted = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_reseted != null)
            {
                children.Add(m_reseted);
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
                case BeltIdentifier.BrowseNames.Reseted:
                {
                    if (createOrReplace)
                    {
                        if (Reseted == null)
                        {
                            if (replacement == null)
                            {
                                Reseted = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                Reseted = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Reseted;
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
        private DiscreteItemState<bool> m_reseted;
        #endregion
    }
    #endif
    #endregion

    #region IsAutoIluminationState Class
    #if (!OPCUA_EXCLUDE_IsAutoIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsAutoIluminationState : BaseObjectState
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
           "ABkAAABJc0F1dG9JbHVtaW5hdGlvbkluc3RhbmNlAQEJAAEBCQAJAAAA/////wEAAAAVYIkKAgAAAAEA" +
           "CAAAAElzQXV0b09uAQEKAAAvAQBECQoAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsAutoOn
        {
            get
            {
                return m_isAutoOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isAutoOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isAutoOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isAutoOn != null)
            {
                children.Add(m_isAutoOn);
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
                case BeltIdentifier.BrowseNames.IsAutoOn:
                {
                    if (createOrReplace)
                    {
                        if (IsAutoOn == null)
                        {
                            if (replacement == null)
                            {
                                IsAutoOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsAutoOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsAutoOn;
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
        private DiscreteItemState<bool> m_isAutoOn;
        #endregion
    }
    #endif
    #endregion

    #region IsModule1IluminationState Class
    #if (!OPCUA_EXCLUDE_IsModule1IluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsModule1IluminationState : BaseObjectState
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
           "ABwAAABJc01vZHVsZTFJbHVtaW5hdGlvbkluc3RhbmNlAQENAAEBDQANAAAA/////wEAAAAVYIkKAgAA" +
           "AAEACwAAAElzTW9kdWxlMU9uAQEOAAAvAQBECQ4AAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsModule1On
        {
            get
            {
                return m_isModule1On;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isModule1On, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isModule1On = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isModule1On != null)
            {
                children.Add(m_isModule1On);
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
                case BeltIdentifier.BrowseNames.IsModule1On:
                {
                    if (createOrReplace)
                    {
                        if (IsModule1On == null)
                        {
                            if (replacement == null)
                            {
                                IsModule1On = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsModule1On = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsModule1On;
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
        private DiscreteItemState<bool> m_isModule1On;
        #endregion
    }
    #endif
    #endregion

    #region IsBusyIluminationState Class
    #if (!OPCUA_EXCLUDE_IsBusyIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsBusyIluminationState : BaseObjectState
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
           "ABkAAABJc0J1c3lJbHVtaW5hdGlvbkluc3RhbmNlAQERAAEBEQARAAAA/////wEAAAAVYIkKAgAAAAEA" +
           "CAAAAElzQnVzeU9uAQESAAAvAQBECRIAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsBusyOn
        {
            get
            {
                return m_isBusyOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isBusyOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isBusyOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isBusyOn != null)
            {
                children.Add(m_isBusyOn);
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
                case BeltIdentifier.BrowseNames.IsBusyOn:
                {
                    if (createOrReplace)
                    {
                        if (IsBusyOn == null)
                        {
                            if (replacement == null)
                            {
                                IsBusyOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsBusyOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsBusyOn;
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
        private DiscreteItemState<bool> m_isBusyOn;
        #endregion
    }
    #endif
    #endregion

    #region IsErrorIluminationState Class
    #if (!OPCUA_EXCLUDE_IsErrorIluminationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IsErrorIluminationState : BaseObjectState
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
           "ABoAAABJc0Vycm9ySWx1bWluYXRpb25JbnN0YW5jZQEBFQABARUAFQAAAP////8BAAAAFWCJCgIAAAAB" +
           "AAkAAABJc0Vycm9yT24BARYAAC8BAEQJFgAAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsErrorOn
        {
            get
            {
                return m_isErrorOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isErrorOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isErrorOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isErrorOn != null)
            {
                children.Add(m_isErrorOn);
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
                case BeltIdentifier.BrowseNames.IsErrorOn:
                {
                    if (createOrReplace)
                    {
                        if (IsErrorOn == null)
                        {
                            if (replacement == null)
                            {
                                IsErrorOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsErrorOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsErrorOn;
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
        private DiscreteItemState<bool> m_isErrorOn;
        #endregion
    }
    #endif
    #endregion

    #region MotorState Class
    #if (!OPCUA_EXCLUDE_MotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MotorState : BaseObjectState
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
           "ABEAAABNb3RvclR5cGVJbnN0YW5jZQEBGQABARkAGQAAAP////8BAAAAFWCJCgIAAAABAAcAAABNb3Rv" +
           "ck9uAQEaAAAvAQBECRoAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> MotorOn
        {
            get
            {
                return m_motorOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motorOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motorOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_motorOn != null)
            {
                children.Add(m_motorOn);
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
                case BeltIdentifier.BrowseNames.MotorOn:
                {
                    if (createOrReplace)
                    {
                        if (MotorOn == null)
                        {
                            if (replacement == null)
                            {
                                MotorOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                MotorOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = MotorOn;
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
        private DiscreteItemState<bool> m_motorOn;
        #endregion
    }
    #endif
    #endregion

    #region TransparentPieceState Class
    #if (!OPCUA_EXCLUDE_TransparentPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransparentPieceState : BaseObjectState
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
           "ABgAAABUcmFuc3BhcmVudFBpZWNlSW5zdGFuY2UBAR0AAQEdAB0AAAD/////AQAAABVgiQoCAAAAAQAN" +
           "AAAASXNUcmFuc3BhcmVudAEBHgAALwEARAkeAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsTransparent
        {
            get
            {
                return m_isTransparent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isTransparent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isTransparent = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isTransparent != null)
            {
                children.Add(m_isTransparent);
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
                case BeltIdentifier.BrowseNames.IsTransparent:
                {
                    if (createOrReplace)
                    {
                        if (IsTransparent == null)
                        {
                            if (replacement == null)
                            {
                                IsTransparent = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsTransparent = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsTransparent;
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
        private DiscreteItemState<bool> m_isTransparent;
        #endregion
    }
    #endif
    #endregion

    #region MetallicPieceState Class
    #if (!OPCUA_EXCLUDE_MetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MetallicPieceState : BaseObjectState
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
           "ABUAAABNZXRhbGxpY1BpZWNlSW5zdGFuY2UBASEAAQEhACEAAAD/////AQAAABVgiQoCAAAAAQAKAAAA" +
           "SXNNZXRhbGxpYwEBIgAALwEARAkiAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsMetallic
        {
            get
            {
                return m_isMetallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isMetallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isMetallic = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isMetallic != null)
            {
                children.Add(m_isMetallic);
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
                case BeltIdentifier.BrowseNames.IsMetallic:
                {
                    if (createOrReplace)
                    {
                        if (IsMetallic == null)
                        {
                            if (replacement == null)
                            {
                                IsMetallic = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsMetallic = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsMetallic;
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
        private DiscreteItemState<bool> m_isMetallic;
        #endregion
    }
    #endif
    #endregion

    #region NonMetallicPieceState Class
    #if (!OPCUA_EXCLUDE_NonMetallicPieceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NonMetallicPieceState : BaseObjectState
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
           "ABgAAABOb25NZXRhbGxpY1BpZWNlSW5zdGFuY2UBASUAAQElACUAAAD/////AQAAABVgiQoCAAAAAQAN" +
           "AAAASXNOb25NZXRhbGxpYwEBJgAALwEARAkmAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> IsNonMetallic
        {
            get
            {
                return m_isNonMetallic;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isNonMetallic, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isNonMetallic = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isNonMetallic != null)
            {
                children.Add(m_isNonMetallic);
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
                case BeltIdentifier.BrowseNames.IsNonMetallic:
                {
                    if (createOrReplace)
                    {
                        if (IsNonMetallic == null)
                        {
                            if (replacement == null)
                            {
                                IsNonMetallic = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                IsNonMetallic = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsNonMetallic;
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
        private DiscreteItemState<bool> m_isNonMetallic;
        #endregion
    }
    #endif
    #endregion

    #region TransparentPieceQuantityState Class
    #if (!OPCUA_EXCLUDE_TransparentPieceQuantityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransparentPieceQuantityState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public TransparentPieceQuantityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.TransparentPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ACAAAABUcmFuc3BhcmVudFBpZWNlUXVhbnRpdHlJbnN0YW5jZQEBKQABASkAKQAAAP////8BAAAAFWCJ" +
           "CgIAAAABAA4AAABUcmFuc3BhcmVudFF0eQEBQQEALwEAQAlBAQAAAAf/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBRQEALgBERQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<uint> TransparentQty
        {
            get
            {
                return m_transparentQty;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transparentQty, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transparentQty = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_transparentQty != null)
            {
                children.Add(m_transparentQty);
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
                case BeltIdentifier.BrowseNames.TransparentQty:
                {
                    if (createOrReplace)
                    {
                        if (TransparentQty == null)
                        {
                            if (replacement == null)
                            {
                                TransparentQty = new AnalogItemState<uint>(this);
                            }
                            else
                            {
                                TransparentQty = (AnalogItemState<uint>)replacement;
                            }
                        }
                    }

                    instance = TransparentQty;
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
        private AnalogItemState<uint> m_transparentQty;
        #endregion
    }
    #endif
    #endregion

    #region MetallicPieceQuantityState Class
    #if (!OPCUA_EXCLUDE_MetallicPieceQuantityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MetallicPieceQuantityState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MetallicPieceQuantityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.MetallicPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "AB0AAABNZXRhbGxpY1BpZWNlUXVhbnRpdHlJbnN0YW5jZQEBMAABATAAMAAAAP////8BAAAAFWCJCgIA" +
           "AAABAAsAAABNZXRhbGxpY1F0eQEBRwEALwEAQAlHAQAAAAf/////AwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBSwEALgBESwEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<uint> MetallicQty
        {
            get
            {
                return m_metallicQty;
            }

            set
            {
                if (!Object.ReferenceEquals(m_metallicQty, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_metallicQty = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_metallicQty != null)
            {
                children.Add(m_metallicQty);
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
                case BeltIdentifier.BrowseNames.MetallicQty:
                {
                    if (createOrReplace)
                    {
                        if (MetallicQty == null)
                        {
                            if (replacement == null)
                            {
                                MetallicQty = new AnalogItemState<uint>(this);
                            }
                            else
                            {
                                MetallicQty = (AnalogItemState<uint>)replacement;
                            }
                        }
                    }

                    instance = MetallicQty;
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
        private AnalogItemState<uint> m_metallicQty;
        #endregion
    }
    #endif
    #endregion

    #region NonMetallicPieceQuantityState Class
    #if (!OPCUA_EXCLUDE_NonMetallicPieceQuantityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NonMetallicPieceQuantityState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public NonMetallicPieceQuantityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.NonMetallicPieceQuantity, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ACAAAABOb25NZXRhbGxpY1BpZWNlUXVhbnRpdHlJbnN0YW5jZQEBNwABATcANwAAAP////8BAAAAFWCJ" +
           "CgIAAAABAA4AAABOb25NZXRhbGxpY1F0eQEBTQEALwEAQAlNAQAAAAf/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBUQEALgBEUQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<uint> NonMetallicQty
        {
            get
            {
                return m_nonMetallicQty;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nonMetallicQty, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nonMetallicQty = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_nonMetallicQty != null)
            {
                children.Add(m_nonMetallicQty);
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
                case BeltIdentifier.BrowseNames.NonMetallicQty:
                {
                    if (createOrReplace)
                    {
                        if (NonMetallicQty == null)
                        {
                            if (replacement == null)
                            {
                                NonMetallicQty = new AnalogItemState<uint>(this);
                            }
                            else
                            {
                                NonMetallicQty = (AnalogItemState<uint>)replacement;
                            }
                        }
                    }

                    instance = NonMetallicQty;
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
        private AnalogItemState<uint> m_nonMetallicQty;
        #endregion
    }
    #endif
    #endregion

    #region OpticalBarrier1State Class
    #if (!OPCUA_EXCLUDE_OpticalBarrier1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalBarrier1State : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OpticalBarrier1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.OpticalBarrier1, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABPcHRpY2FsQmFycmllcjFJbnN0YW5jZQEBPgABAT4APgAAAP////8BAAAAFWCJCgIAAAABAAoA" +
           "AABCYXJyaWVyMU9uAQE/AAAvAQBECT8AAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> Barrier1On
        {
            get
            {
                return m_barrier1On;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier1On, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier1On = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_barrier1On != null)
            {
                children.Add(m_barrier1On);
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
                case BeltIdentifier.BrowseNames.Barrier1On:
                {
                    if (createOrReplace)
                    {
                        if (Barrier1On == null)
                        {
                            if (replacement == null)
                            {
                                Barrier1On = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                Barrier1On = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Barrier1On;
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
        private DiscreteItemState<bool> m_barrier1On;
        #endregion
    }
    #endif
    #endregion

    #region OpticalBarrier2State Class
    #if (!OPCUA_EXCLUDE_OpticalBarrier2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalBarrier2State : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OpticalBarrier2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.OpticalBarrier2, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABPcHRpY2FsQmFycmllcjJJbnN0YW5jZQEBQgABAUIAQgAAAP////8BAAAAFWCJCgIAAAABAAoA" +
           "AABCYXJyaWVyMk9uAQFDAAAvAQBECUMAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> Barrier2On
        {
            get
            {
                return m_barrier2On;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier2On, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier2On = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_barrier2On != null)
            {
                children.Add(m_barrier2On);
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
                case BeltIdentifier.BrowseNames.Barrier2On:
                {
                    if (createOrReplace)
                    {
                        if (Barrier2On == null)
                        {
                            if (replacement == null)
                            {
                                Barrier2On = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                Barrier2On = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Barrier2On;
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
        private DiscreteItemState<bool> m_barrier2On;
        #endregion
    }
    #endif
    #endregion

    #region OpticalBarrier3State Class
    #if (!OPCUA_EXCLUDE_OpticalBarrier3State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpticalBarrier3State : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OpticalBarrier3State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BeltIdentifier.ObjectTypes.OpticalBarrier3, BeltIdentifier.Namespaces.BeltIdentifier, namespaceUris);
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
           "ABcAAABPcHRpY2FsQmFycmllcjNJbnN0YW5jZQEBRgABAUYARgAAAP////8BAAAAFWCJCgIAAAABAAoA" +
           "AABCYXJyaWVyM09uAQFHAAAvAQBECUcAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> Barrier3On
        {
            get
            {
                return m_barrier3On;
            }

            set
            {
                if (!Object.ReferenceEquals(m_barrier3On, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_barrier3On = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_barrier3On != null)
            {
                children.Add(m_barrier3On);
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
                case BeltIdentifier.BrowseNames.Barrier3On:
                {
                    if (createOrReplace)
                    {
                        if (Barrier3On == null)
                        {
                            if (replacement == null)
                            {
                                Barrier3On = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                Barrier3On = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Barrier3On;
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
        private DiscreteItemState<bool> m_barrier3On;
        #endregion
    }
    #endif
    #endregion

    #region ElectricPhotoSensorState Class
    #if (!OPCUA_EXCLUDE_ElectricPhotoSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ElectricPhotoSensorState : BaseObjectState
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
           "ABsAAABFbGVjdHJpY1Bob3RvU2Vuc29ySW5zdGFuY2UBAUoAAQFKAEoAAAD/////AQAAABVgiQoCAAAA" +
           "AQANAAAAUGhvdG9TZW5zb3JPbgEBSwAALwEARAlLAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> PhotoSensorOn
        {
            get
            {
                return m_photoSensorOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_photoSensorOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_photoSensorOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_photoSensorOn != null)
            {
                children.Add(m_photoSensorOn);
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
                case BeltIdentifier.BrowseNames.PhotoSensorOn:
                {
                    if (createOrReplace)
                    {
                        if (PhotoSensorOn == null)
                        {
                            if (replacement == null)
                            {
                                PhotoSensorOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                PhotoSensorOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = PhotoSensorOn;
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
        private DiscreteItemState<bool> m_photoSensorOn;
        #endregion
    }
    #endif
    #endregion

    #region CapacitiveSensorState Class
    #if (!OPCUA_EXCLUDE_CapacitiveSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CapacitiveSensorState : BaseObjectState
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
           "ABgAAABDYXBhY2l0aXZlU2Vuc29ySW5zdGFuY2UBAU4AAQFOAE4AAAD/////AQAAABVgiQoCAAAAAQAM" +
           "AAAAQ2FwYWNpdGl2ZU9uAQFPAAAvAQBECU8AAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> CapacitiveOn
        {
            get
            {
                return m_capacitiveOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_capacitiveOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_capacitiveOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_capacitiveOn != null)
            {
                children.Add(m_capacitiveOn);
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
                case BeltIdentifier.BrowseNames.CapacitiveOn:
                {
                    if (createOrReplace)
                    {
                        if (CapacitiveOn == null)
                        {
                            if (replacement == null)
                            {
                                CapacitiveOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                CapacitiveOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = CapacitiveOn;
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
        private DiscreteItemState<bool> m_capacitiveOn;
        #endregion
    }
    #endif
    #endregion

    #region InductiveSensorState Class
    #if (!OPCUA_EXCLUDE_InductiveSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InductiveSensorState : BaseObjectState
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
           "ABcAAABJbmR1Y3RpdmVTZW5zb3JJbnN0YW5jZQEBUgABAVIAUgAAAP////8BAAAAFWCJCgIAAAABAAsA" +
           "AABJbmR1Y3RpdmVPbgEBUwAALwEARAlTAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DiscreteItemState<bool> InductiveOn
        {
            get
            {
                return m_inductiveOn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inductiveOn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inductiveOn = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_inductiveOn != null)
            {
                children.Add(m_inductiveOn);
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
                case BeltIdentifier.BrowseNames.InductiveOn:
                {
                    if (createOrReplace)
                    {
                        if (InductiveOn == null)
                        {
                            if (replacement == null)
                            {
                                InductiveOn = new DiscreteItemState<bool>(this);
                            }
                            else
                            {
                                InductiveOn = (DiscreteItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = InductiveOn;
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
        private DiscreteItemState<bool> m_inductiveOn;
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
           "ABMAAABNb2R1bGUxVHlwZUluc3RhbmNlAQFWAAEBVgBWAAAAAQAAAAAwAAEBVwAGAAAAhGCACgEAAAAB" +
           "AAsAAABUcmFuc3BhcmVudAEBVwAALwEBHQBXAAAAAQEAAAAAMAEBAVYAAQAAABVgiQoCAAAAAQANAAAA" +
           "SXNUcmFuc3BhcmVudAEBWAAALwEARAlYAAAAAAH/////AQH/////AAAAAIRggAoBAAAAAQAIAAAATWV0" +
           "YWxsaWMBAVsAAC8BASEAWwAAAAH/////AQAAABVgiQoCAAAAAQAKAAAASXNNZXRhbGxpYwEBXAAALwEA" +
           "RAlcAAAAAAH/////AQH/////AAAAAIRggAoBAAAAAQALAAAATm9uTWV0YWxsaWMBAV8AAC8BASUAXwAA" +
           "AAH/////AQAAABVgiQoCAAAAAQANAAAASXNOb25NZXRhbGxpYwEBYAAALwEARAlgAAAAAAH/////AQH/" +
           "////AAAAAIRggAoBAAAAAQATAAAAVHJhbnNwYXJlbnRRdWFudGl0eQEBUwEALwEBKQBTAQAAAf////8B" +
           "AAAAFWCJCgIAAAABAA4AAABUcmFuc3BhcmVudFF0eQEBVAEALwEAQAlUAQAAAAf/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBWAEALgBEWAEAAAEAdAP/////AQH/////AAAAAIRggAoBAAAA" +
           "AQAQAAAATWV0YWxsaWNRdWFudGl0eQEBWgEALwEBMABaAQAAAf////8BAAAAFWCJCgIAAAABAAsAAABN" +
           "ZXRhbGxpY1F0eQEBWwEALwEAQAlbAQAAAAf/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBXwEALgBEXwEAAAEAdAP/////AQH/////AAAAAIRggAoBAAAAAQATAAAATm9uTWV0YWxsaWNRdWFu" +
           "dGl0eQEBYQEALwEBNwBhAQAAAf////8BAAAAFWCJCgIAAAABAA4AAABOb25NZXRhbGxpY1F0eQEBYgEA" +
           "LwEAQAliAQAAAAf/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBZgEALgBEZgEAAAEA" +
           "dAP/////AQH/////AAAAAA==";
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
        public TransparentPieceQuantityState TransparentQuantity
        {
            get
            {
                return m_transparentQuantity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transparentQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transparentQuantity = value;
            }
        }

        /// <remarks />
        public MetallicPieceQuantityState MetallicQuantity
        {
            get
            {
                return m_metallicQuantity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_metallicQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_metallicQuantity = value;
            }
        }

        /// <remarks />
        public NonMetallicPieceQuantityState NonMetallicQuantity
        {
            get
            {
                return m_nonMetallicQuantity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nonMetallicQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nonMetallicQuantity = value;
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

            if (m_transparentQuantity != null)
            {
                children.Add(m_transparentQuantity);
            }

            if (m_metallicQuantity != null)
            {
                children.Add(m_metallicQuantity);
            }

            if (m_nonMetallicQuantity != null)
            {
                children.Add(m_nonMetallicQuantity);
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

                case BeltIdentifier.BrowseNames.TransparentQuantity:
                {
                    if (createOrReplace)
                    {
                        if (TransparentQuantity == null)
                        {
                            if (replacement == null)
                            {
                                TransparentQuantity = new TransparentPieceQuantityState(this);
                            }
                            else
                            {
                                TransparentQuantity = (TransparentPieceQuantityState)replacement;
                            }
                        }
                    }

                    instance = TransparentQuantity;
                    break;
                }

                case BeltIdentifier.BrowseNames.MetallicQuantity:
                {
                    if (createOrReplace)
                    {
                        if (MetallicQuantity == null)
                        {
                            if (replacement == null)
                            {
                                MetallicQuantity = new MetallicPieceQuantityState(this);
                            }
                            else
                            {
                                MetallicQuantity = (MetallicPieceQuantityState)replacement;
                            }
                        }
                    }

                    instance = MetallicQuantity;
                    break;
                }

                case BeltIdentifier.BrowseNames.NonMetallicQuantity:
                {
                    if (createOrReplace)
                    {
                        if (NonMetallicQuantity == null)
                        {
                            if (replacement == null)
                            {
                                NonMetallicQuantity = new NonMetallicPieceQuantityState(this);
                            }
                            else
                            {
                                NonMetallicQuantity = (NonMetallicPieceQuantityState)replacement;
                            }
                        }
                    }

                    instance = NonMetallicQuantity;
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
        private TransparentPieceQuantityState m_transparentQuantity;
        private MetallicPieceQuantityState m_metallicQuantity;
        private NonMetallicPieceQuantityState m_nonMetallicQuantity;
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
           "ABMAAABNb2R1bGUyVHlwZUluc3RhbmNlAQF4AAEBeAB4AAAAAQAAAAAwAAEBeQAGAAAAhGCACgEAAAAB" +
           "AAgAAABCYXJyaWVyMQEBeQAALwEBPgB5AAAAAQEAAAAAMAEBAXgAAQAAABVgiQoCAAAAAQAKAAAAQmFy" +
           "cmllcjFPbgEBegAALwEARAl6AAAAAAH/////AQH/////AAAAAIRggAoBAAAAAQAIAAAAQmFycmllcjIB" +
           "AX0AAC8BAUIAfQAAAAH/////AQAAABVgiQoCAAAAAQAKAAAAQmFycmllcjJPbgEBfgAALwEARAl+AAAA" +
           "AAH/////AQH/////AAAAAIRggAoBAAAAAQAIAAAAQmFycmllcjMBAYEAAC8BAUYAgQAAAAH/////AQAA" +
           "ABVgiQoCAAAAAQAKAAAAQmFycmllcjNPbgEBggAALwEARAmCAAAAAAH/////AQH/////AAAAAIRggAoB" +
           "AAAAAQALAAAAUGhvdG9TZW5zb3IBAYUAAC8BAUoAhQAAAAH/////AQAAABVgiQoCAAAAAQANAAAAUGhv" +
           "dG9TZW5zb3JPbgEBhgAALwEARAmGAAAAAAH/////AQH/////AAAAAIRggAoBAAAAAQAKAAAAQ2FwYWNp" +
           "dGl2ZQEBiQAALwEBTgCJAAAAAf////8BAAAAFWCJCgIAAAABAAwAAABDYXBhY2l0aXZlT24BAYoAAC8B" +
           "AEQJigAAAAAB/////wEB/////wAAAACEYIAKAQAAAAEACQAAAEluZHVjdGl2ZQEBjQAALwEBUgCNAAAA" +
           "Af////8BAAAAFWCJCgIAAAABAAsAAABJbmR1Y3RpdmVPbgEBjgAALwEARAmOAAAAAAH/////AQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public OpticalBarrier1State Barrier1
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
        public OpticalBarrier2State Barrier2
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
        public OpticalBarrier3State Barrier3
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
                                Barrier1 = new OpticalBarrier1State(this);
                            }
                            else
                            {
                                Barrier1 = (OpticalBarrier1State)replacement;
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
                                Barrier2 = new OpticalBarrier2State(this);
                            }
                            else
                            {
                                Barrier2 = (OpticalBarrier2State)replacement;
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
                                Barrier3 = new OpticalBarrier3State(this);
                            }
                            else
                            {
                                Barrier3 = (OpticalBarrier3State)replacement;
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
        private OpticalBarrier1State m_barrier1;
        private OpticalBarrier2State m_barrier2;
        private OpticalBarrier3State m_barrier3;
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
           "ABAAAABCZWx0VHlwZUluc3RhbmNlAQGRAAEBkQCRAAAAAQEAAAAAMAABAZoACQAAAIRggAoBAAAAAQAL" +
           "AAAAU3RhcnRCdXR0b24BAZIAAC8BAQEAkgAAAAH/////AQAAABVgiQoCAAAAAQAHAAAAU3RhcnRlZAEB" +
           "kwAALwEARAmTAAAAAAH/////AwP/////AAAAAIRggAoBAAAAAQALAAAAUmVzZXRCdXR0b24BAZYAAC8B" +
           "AQUAlgAAAAH/////AQAAABVgiQoCAAAAAQAHAAAAUmVzZXRlZAEBlwAALwEARAmXAAAAAAH/////AwP/" +
           "////AAAAAIRggAoBAAAAAQAGAAAASXNBdXRvAQGaAAAvAQEJAJoAAAABAQAAAAAwAQEBkQABAAAAFWCJ" +
           "CgIAAAABAAgAAABJc0F1dG9PbgEBmwAALwEARAmbAAAAAAH/////AQH/////AAAAAIRggAoBAAAAAQAJ" +
           "AAAASXNNb2R1bGUxAQGeAAAvAQENAJ4AAAAB/////wEAAAAVYIkKAgAAAAEACwAAAElzTW9kdWxlMU9u" +
           "AQGfAAAvAQBECZ8AAAAAAf////8BAf////8AAAAAhGDACgEAAAAHAAAASXNFcnJvcgEABQAAAEVycm9y" +
           "AQGiAAAvAQEVAKIAAAAB/////wEAAAAVYIkKAgAAAAEACQAAAElzRXJyb3JPbgEBowAALwEARAmjAAAA" +
           "AAH/////AQH/////AAAAAIRgwAoBAAAABgAAAElzQnVzeQEABAAAAEJ1c3kBAaYAAC8BAREApgAAAAH/" +
           "////AQAAABVgiQoCAAAAAQAIAAAASXNCdXN5T24BAacAAC8BAEQJpwAAAAAB/////wEB/////wAAAACE" +
           "YIAKAQAAAAEABQAAAE1vdG9yAQGqAAAvAQEZAKoAAAAB/////wEAAAAVYIkKAgAAAAEABwAAAE1vdG9y" +
           "T24BAasAAC8BAEQJqwAAAAAB/////wEB/////wAAAACEYMAKAQAAAAcAAABNb2R1bGUxAQANAAAAQmVs" +
           "dCBNb2R1bGUgMQEBrgAALwEBVgCuAAAAAQEAAAAAMAABAa8ABgAAAIRggAoBAAAAAQALAAAAVHJhbnNw" +
           "YXJlbnQBAa8AAC8BAR0ArwAAAAEBAAAAADABAQGuAAEAAAAVYIkKAgAAAAEADQAAAElzVHJhbnNwYXJl" +
           "bnQBAbAAAC8BAEQJsAAAAAAB/////wEB/////wAAAACEYIAKAQAAAAEACAAAAE1ldGFsbGljAQGzAAAv" +
           "AQEhALMAAAAB/////wEAAAAVYIkKAgAAAAEACgAAAElzTWV0YWxsaWMBAbQAAC8BAEQJtAAAAAAB////" +
           "/wEB/////wAAAACEYIAKAQAAAAEACwAAAE5vbk1ldGFsbGljAQG3AAAvAQElALcAAAAB/////wEAAAAV" +
           "YIkKAgAAAAEADQAAAElzTm9uTWV0YWxsaWMBAbgAAC8BAEQJuAAAAAAB/////wEB/////wAAAACEYIAK" +
           "AQAAAAEAEwAAAFRyYW5zcGFyZW50UXVhbnRpdHkBAWgBAC8BASkAaAEAAAH/////AQAAABVgiQoCAAAA" +
           "AQAOAAAAVHJhbnNwYXJlbnRRdHkBAWkBAC8BAEAJaQEAAAAH/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAW0BAC4ARG0BAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEAEAAAAE1ldGFs" +
           "bGljUXVhbnRpdHkBAW8BAC8BATAAbwEAAAH/////AQAAABVgiQoCAAAAAQALAAAATWV0YWxsaWNRdHkB" +
           "AXABAC8BAEAJcAEAAAAH/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXQBAC4ARHQB" +
           "AAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEAEwAAAE5vbk1ldGFsbGljUXVhbnRpdHkBAXYBAC8B" +
           "ATcAdgEAAAH/////AQAAABVgiQoCAAAAAQAOAAAATm9uTWV0YWxsaWNRdHkBAXcBAC8BAEAJdwEAAAAH" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXsBAC4ARHsBAAABAHQD/////wEB////" +
           "/wAAAACEYMAKAQAAAAcAAABNb2R1bGUyAQANAAAAQmVsdCBNb2R1bGUgMgEB0AAALwEBeADQAAAAAQEA" +
           "AAAAMAABAdEABgAAAIRggAoBAAAAAQAIAAAAQmFycmllcjEBAdEAAC8BAT4A0QAAAAEBAAAAADABAQHQ" +
           "AAEAAAAVYIkKAgAAAAEACgAAAEJhcnJpZXIxT24BAdIAAC8BAEQJ0gAAAAAB/////wEB/////wAAAACE" +
           "YIAKAQAAAAEACAAAAEJhcnJpZXIyAQHVAAAvAQFCANUAAAAB/////wEAAAAVYIkKAgAAAAEACgAAAEJh" +
           "cnJpZXIyT24BAdYAAC8BAEQJ1gAAAAAB/////wEB/////wAAAACEYIAKAQAAAAEACAAAAEJhcnJpZXIz" +
           "AQHZAAAvAQFGANkAAAAB/////wEAAAAVYIkKAgAAAAEACgAAAEJhcnJpZXIzT24BAdoAAC8BAEQJ2gAA" +
           "AAAB/////wEB/////wAAAACEYIAKAQAAAAEACwAAAFBob3RvU2Vuc29yAQHdAAAvAQFKAN0AAAAB////" +
           "/wEAAAAVYIkKAgAAAAEADQAAAFBob3RvU2Vuc29yT24BAd4AAC8BAEQJ3gAAAAAB/////wEB/////wAA" +
           "AACEYIAKAQAAAAEACgAAAENhcGFjaXRpdmUBAeEAAC8BAU4A4QAAAAH/////AQAAABVgiQoCAAAAAQAM" +
           "AAAAQ2FwYWNpdGl2ZU9uAQHiAAAvAQBECeIAAAAAAf////8BAf////8AAAAAhGCACgEAAAABAAkAAABJ" +
           "bmR1Y3RpdmUBAeUAAC8BAVIA5QAAAAH/////AQAAABVgiQoCAAAAAQALAAAASW5kdWN0aXZlT24BAeYA" +
           "AC8BAEQJ5gAAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public StartButtonState StartButton
        {
            get
            {
                return m_startButton;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startButton, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startButton = value;
            }
        }

        /// <remarks />
        public ResetButtonState ResetButton
        {
            get
            {
                return m_resetButton;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetButton, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetButton = value;
            }
        }

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
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startButton != null)
            {
                children.Add(m_startButton);
            }

            if (m_resetButton != null)
            {
                children.Add(m_resetButton);
            }

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
                case BeltIdentifier.BrowseNames.StartButton:
                {
                    if (createOrReplace)
                    {
                        if (StartButton == null)
                        {
                            if (replacement == null)
                            {
                                StartButton = new StartButtonState(this);
                            }
                            else
                            {
                                StartButton = (StartButtonState)replacement;
                            }
                        }
                    }

                    instance = StartButton;
                    break;
                }

                case BeltIdentifier.BrowseNames.ResetButton:
                {
                    if (createOrReplace)
                    {
                        if (ResetButton == null)
                        {
                            if (replacement == null)
                            {
                                ResetButton = new ResetButtonState(this);
                            }
                            else
                            {
                                ResetButton = (ResetButtonState)replacement;
                            }
                        }
                    }

                    instance = ResetButton;
                    break;
                }

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
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private StartButtonState m_startButton;
        private ResetButtonState m_resetButton;
        private IsAutoIluminationState m_isAuto;
        private IsModule1IluminationState m_isModule1;
        private IsErrorIluminationState m_isError;
        private IsBusyIluminationState m_isBusy;
        private MotorState m_motor;
        private Module1State m_module1;
        private Module2State m_module2;
        #endregion
    }
    #endif
    #endregion
}