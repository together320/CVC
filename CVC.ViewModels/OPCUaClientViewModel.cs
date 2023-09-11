using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class OPCUaClientViewModel
    {
        public string ServerAddress { get; set; }

        public string ServerPortNumber { get; set; }

        public int MachineId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string NodeId { get; set; }

        public uint AttributeId { get; set; }

        public object Value { get; set; }

        public int DataTypeId { get; set; }


        public List<OPCUaClientWriteValues> lstWriteValues { get; set; }

        public List<OPCUaClientReadValues> lstReadValues { get; set; }

    }

    public class OPCUaClientWriteValues
    {
        public string NodeId { get; set; }

        public uint AttributeId { get; set; }

        public object Value { get; set; }
    }

    public class OPCUaClientReadValues
    {
        public string NodeId { get; set; }

        public uint AttributeId { get; set; }

        public object Value { get; set; }

        public int ReadValueSequence { get; set; }
    }

    public class OPCUaClientAddressSpace
    {
        public object AccessRestrictions { get; set; }

        public string BrowseName { get; set; }

        public string DataLock { get; set; }

        public object Handle { get; set; }

        public object NodeClass { get; set; }

        public string NodeId { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public object References { get; set; }

        public object RolePermissions { get; set; }

        public string ReferenceTable { get; set; }

        public string TypeDefinitionId { get; set; }

        public string TypeId { get; set; }

        public string UserRolePermissions { get; set; }

        public string AccessLevel { get; set; }


        // public int MyProperty { get; set; }

        public List<MachineParameterList> machineParameterList { get; set; }

        public int MachineParameterId { get; set; }

        public List<NodeDetails> LstNodeDetails { get; set; }

        // public Node node { get; set; }

        public string Message { get; set; }
    }

    public class NodeDetails
    {
        public string DisplayName { get; set; }

        public string BrowseName { get; set; }

        public string NodeId { get; set; }

        public string NodeIdWithouSpecialCharacter { get; set; }
        
        public bool HasChildElement { get; set; }

        public string UniqueId { get; set; }

        public bool isChecked { get; set; }

        public int machineParameterId { get; set; }

        public bool isRead { get; set; }

        public bool isWrite { get; set; }


    }

    public class MachineParameterList
    {
        public int MachineParameterId { get; set; }

        public string ParameterName { get; set; }

        public string NodeId { get; set; }
    }

    public class NodeModel
    {
        public string nodeId { get; set; }

        public string displayName { get; set; }

        public int dataTypeId { get; set; }

        public bool isRead { get; set; }

        public bool isWrite { get; set; }


    }

    public class AddressSpaceModel
    {
        public int machineId { get; set; }

        public List<NodeModel> nodeModelList { get; set; }

        public List<MachineParameterList> machineParameterList { get; set; }


    }


}
