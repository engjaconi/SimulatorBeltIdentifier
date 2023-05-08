using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System.Configuration;
using System.Net;

namespace ClientBeltIdentifier
{
    public partial class Form1 : Form
    {
        private ApplicationInstance m_application;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;

            var selectedEndpoint = CoreClientUtils.SelectEndpoint("opc.tcp://engjaconi-acer:26543/ServerBeltIdentifier", useSecurity: true);

            using (var session = Session.Create(m_application.ApplicationConfiguration, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(m_application.ApplicationConfiguration)), false, "", 60000, null, null).GetAwaiter().GetResult())
            {
                // add the urls to the drop down.
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Step 3 - Browse the server namespace.");
                ReferenceDescriptionCollection refs;
                Byte[] cp;
                session.Browse(null, null, ObjectIds.ObjectsFolder, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out cp, out refs);
                comboBox1.Items.Add("DisplayName: BrowseName, NodeClass");
                foreach (var rd in refs)
                {
                    comboBox1.Items.Add($"{rd.DisplayName}, {rd.BrowseName}, {rd.NodeClass}, {rd.NodeId}");
                    ReferenceDescriptionCollection nextRefs;
                    byte[] nextCp;
                    session.Browse(null, null, ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out nextCp, out nextRefs);
                    foreach (var nextRd in nextRefs)
                    {
                        comboBox1.Items.Add($"{nextRd.DisplayName}, {nextRd.BrowseName}, {nextRd.NodeClass}, {nextRd.NodeId}");
                    }
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}