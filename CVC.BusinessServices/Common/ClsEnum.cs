using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.BusinessServices.Common
{
    public class ClsEnum
    {
        public enum RoleFormField
        {
            [Description("Role Name(*)")]
            RoleName = 1,
            [Description("Parent")]
            ParentRoleId = 2,
            [Description("Status(*)")]
            StatusId = 3
        }

        public enum UserFormField
        {
            [Description("Employee Id")]
            EmployeeId = 1,
            [Description("First Name(*)")]
            FirstName = 2,
            [Description("Last Name(*)")]
            LastName = 3,
            [Description("Department Id(*)")]
            DepartmentId = 4,
            [Description("Designation")]
            Designation = 5,
            [Description("Mobile Code")]
            MobileCode = 6,
            [Description("Mobile Number")]
            MobileNumber = 7,
            [Description("BirthDate")]
            BirthDate = 8,
            [Description("Email")]
            Email = 9,
            [Description("UserName(*)")]
            UserName = 10,
            [Description("Password(*)")]
            Password = 11,
            [Description("Confirm Password(*)")]
            ConfirmPassword = 12,
            [Description("Role")]
            RoleId = 13,
            [Description("Address")]
            Address = 14,
            [Description("City(*)")]
            CityId = 15,
            [Description("Pin Code")]
            PinCode = 16,
            [Description("Status(*)")]
            StatusId = 17,
            [Description("Question(*)")]
            QuestionId = 18,
            [Description("Answer(*)")]
            QuestionAns = 19,
            [Description("Is LockOut")]
            IsLockOut = 20,
            [Description("Is ActiveDirectory")]
            IsActiveDirectory = 21

        }

        public enum BottleFormField
        {
            [Description("Bottle Name(*)")]
            BottleName = 1,
            [Description("Bottle Cc")]
            BottleCC = 2,
            [Description("Container Type")]
            ContainerTypeId = 3,
            [Description("Bottle Height")]
            BottleHeight = 4,
            [Description("Bottle Diameter")]
            BottleDiameter = 5,
            [Description("Bottle Mouth Opening (I/D)")]
            BottleMouthOpening_ID = 6,
            [Description("Bottle Mouth Opening (O/D)")]
            BottleMouthOpening_OD = 7,
            [Description("Supplier")]
            SupplierId = 8,
            [Description("Status(*)")]
            StatusId = 9,

        }

        public enum CapFormField
        {
            [Description("Cap Name(*)")]
            CapName = 1,
            [Description("Cap Cc")]
            CapCC = 2,
            [Description("Cap Type(*)")]
            CapTypeId = 3,
            [Description("Cap Diameter(*)")]
            CapDiameter = 4,
            [Description("Cap Height(*)")]
            CapHeight = 5,
            [Description("Supplier")]
            SupplierId = 6,
            [Description("Status(*)")]
            StatusId = 7,

        }

        public enum CottonFormField
        {
            [Description("Cotton Name(*)")]
            CottonName = 1,
            [Description("Cotton Type Id(*)")]
            CottonTypeId = 2,
            [Description("Gm Or Yard(*)")]
            GmOrYard = 3,
            [Description("Supplier")]
            SupplierId = 4,
            [Description("Status(*)")]
            StatusId = 5,

        }

        public enum LabelFormField
        {
            [Description("Label Name(*)")]
            LabelName = 1,
            [Description("Label Length(*)")]
            LabelLength = 2,
            [Description("Label Height(*)")]
            LabelHeight = 3,
            [Description("Label Type(*)")]
            LabelType = 4,
            [Description("Supplier")]
            SupplierId = 5,
            [Description("Status(*)")]
            StatusId = 6,
        }

        public enum OutsertFormField
        {
            [Description("Outsert Name(*)")]
            OutsertName = 1,
            [Description("Outsert Length(*)")]
            OutsertLength = 2,
            [Description("Outsert Width(*)")]
            OutsertWidth = 3,
            [Description("Outsert Thickness(*)")]
            OutsertThickness = 4,
            [Description("Supplier")]
            SupplierId = 5,
            [Description("Status(*)")]
            StatusId = 6,
        }

        public enum PackFormField
        {
            [Description("Pack Code(*)")]
            PackName = 1,
            [Description("Product(*)")]
            TabletId = 2,
            [Description("Product Quantity")]
            TabletCount = 3,
            [Description("Bottle")]
            BottleId = 4,
            [Description("Cap")]
            CapId = 5,
            [Description("Cotton")]
            CottonId = 6,
            [Description("Cotton Length")]
            CottonLength = 7,
            [Description("Number Of Cotton Pieces")]
            NumberOfCottonPieces = 8,
            [Description("Desiccant")]
            DesiccantId = 9,
            [Description("Number Of Desiccant Pieces")]
            NumberOfDesicantPieces = 10,
            [Description("Outsert")]
            OusertId = 11,
            [Description("Label")]
            LabelId = 12,
            [Description("End Of Line")]
            EndOfLineId = 13,
            [Description("Status(*)")]
            StatusId = 14

        }

        public enum TabletDetailsFormField
        {
            [Description("Product Name(*)")]
            TabletName = 1,
            [Description("Product Strength")]
            TabletStrength = 2,
            [Description("Product Type")]
            TabletTypeId = 3,
            [Description("Characteristics One")]
            TabletCharOneId = 4,
            [Description("Characteristics Two")]
            TabletCharTwoId = 5,
            [Description("Product Shape Id")]
            TabletShapeId = 6,
            [Description("Product Length")]
            TabletLength = 7,
            [Description("Product Thickness")]
            TabletThickness = 8,
            [Description("Product Width")]
            TabletWidth = 9,
            [Description("Status(*)")]
            StatusId = 10,

        }

        public enum CityFormField
        {
            [Description("Country(*)")]
            Country = 1,
            [Description("State(*)")]
            State = 2,
            [Description("City(*)")]
            City = 3,
            [Description("Status(*)")]
            StatusID = 4,
        }

        public enum DepartmentFormField
        {
            [Description("Department Code(*)")]
            DepartmentCode = 1,
            [Description("Department Name(*)")]
            DepartmentName = 2,
            [Description("Status(*)")]
            StatusId = 3,
        }

        public enum PickListValueFormField
        {
            [Description("Pick List(*)")]
            PickListId = 1,
            [Description("Pick List Value Name(*)")]
            PickListValueName = 2,
            [Description("Status(*)")]
            StatusId = 3,
        }

        public enum SupplierFormField
        {
            [Description("Supplier Name(*)")]
            SupplierName = 1,
            [Description("Supplier Address(*)")]
            SupplierAddress = 2,
            [Description("City(*)")]
            CityId = 3,
            [Description("Pin Code")]
            PinCode = 4,
            [Description("Mobile Code(*)")]
            MobileCode = 5,
            [Description("Mobile Number(*)")]
            MobileNumber = 6,
            [Description("Status(*)")]
            StatusId = 7,
        }

        public enum MachineFormField
        {
            [Description("Machine Name(*)")]
            MachineName = 1,
            [Description("Access IP Address(*)")]
            AccessIPAddress = 2,
            [Description("Machine Sequence(*)")]
            MachineSequence = 3,
            [Description("Description")]
            Description = 4,
            [Description("Model Number")]
            ModelNumber = 5,
            [Description("Serial Number")]
            SerialNumber = 6,
            [Description("Make")]
            Make = 7,
            [Description("Year")]
            Year = 8,
            [Description("Plc Make(*)")]
            PlcMake = 9,
            [Description("Plc Model Number")]
            PlcModelNumber = 10,
            [Description("Plc Serial Number")]
            PlcSerialNumber = 11,
            [Description("PLC Address")]
            PLCAddress = 12,
            [Description("Timer For Alarm (In Seconds)")]
            TimerForAlarm = 13,
            [Description("Status(*)")]
            StatusId = 14
        }

        public enum MachineParameterFormField
        {
            [Description("Parameter Name(*)")]
            ParameterName = 1,
            [Description("Machine(*)")]
            MachineId = 2,
            [Description("Description")]
            Description = 3,
            [Description("Data Type(*)")]
            DataTypeId = 4,
            [Description("Is Range Unlimited")]
            IsRangeUnlimited = 5,
            [Description("Min")]
            Min = 6,
            [Description("Max")]
            Max = 7,
            [Description("Is UseUnit")]
            IsUseUnit = 8,
            [Description("Unit")]
            UnitId = 9,
            [Description("Allow Decimal Point")]
            AllowDecimalPoint = 10,
            [Description("Is Read")]
            IsRead = 11,
            [Description("Is Write")]
            IsWrite = 12,
            [Description("Status(*)")]
            StatusId = 13,
            [Description("Type")]
            Type = 14,
            [Description("Row Id")]
            RowId = 15,
            [Description("Is Stop At")]
            IsStopAt = 16,
            [Description("Is BitWise")]
            IsBitWise = 17,
            [Description("Operation Type")]
            OperationType = 18,
            [Description("Is 32 Bit")]
            Is32Bit = 19,
            [Description("Is Show As Message")]
            IsShowAsMessage = 20,
            [Description("Is Reset On Batch Create")]
            IsResetOnBatchCreate = 21,
            [Description("Is Label Roll")]
            IsLabelRoll = 22,
            [Description("Disable Parameter")]
            DisableParameterId = 23,
            [Description("Disable Parameter Value")]
            DisableParameterValue = 24,
            [Description("Is Stop On Batch Stop")]
            IsStopOnBatchStop = 25,
            [Description("Bitwise Index")]
            BitWiseIndex = 26,
            [Description("Query Type Row Id")]
            QueryTypeRowId = 27,
            [Description("Operation Value")]
            OperationValue = 28,
            [Description("32Bit Row Id")]
            Bit32RowId = 29,
            [Description("Read Machine Parameter Id")]
            ReadMachineParameterId = 30,
            [Description("Reload Parameter Id")]
            ReloadMachineParameterId = 31,
            [Description("Is Batch Start Required")]
            IsBatchStartRequired = 32

        }


        public enum AlarmFormField
        {
            [Description("Alarm Name(*)")]
            AlarmName = 1,
            [Description("Machine(*)")]
            MachineId = 2,
            [Description("Machine Parameter(*)")]
            MachineParameterId = 3,
            [Description("Message(*)")]
            Message = 4,
            [Description("Description")]
            Description = 5,
            [Description("Is Reset Required")]
            IsResetRequired = 6,
            [Description("Is Comment Required")]
            IsCommentRequired = 7,
            [Description("Is Machine Required To Stop")]
            IsMachineRequiredToStop = 8,
            [Description("Machine Stop Machine Parameter")]
            MachineStopMachineParameterId = 9,
            [Description("Is Count For Reject")]
            IsCountForReject = 10,
            [Description("Bit Value")]
            BitValue = 11,
            [Description("Is Check At Machine Start")]
            IsCheckAtMachineStart = 12,
            [Description("Status(*)")]
            StatusId = 13,
            [Description("Is Refresh Machine Setting")]
            IsRefreshMachineSettings = 14,
            [Description("Is Hide Edit")]
            IsHideEdit = 15,
            [Description("Is Alarm For Counter")]
            IsAlarmForCounter = 16



        }

        public enum IpcParameterFormField
        {
            [Description("Machine(*)")]
            MachineId = 1,
            [Description("Machine Parameter Id(*)")]
            MachineParameterId = 2,
            [Description("Modbus Address")]
            IPCAddress = 3,
            [Description("Ipc Parameter Name(*)")]
            IPCParameterName = 4,
            [Description("Status(*)")]
            StatusId = 5,
            [Description("Is BitWise")]
            IsBitWise = 6,
            [Description("Is 32 Bit")]
            Is32Bit = 7,
            [Description("Is Word Swap")]
            IsWordSwap = 8,
            [Description("Is Byte Swap")]
            IsByteSwap = 9,
            [Description("Is Stop AT")]
            IsStopATIPC = 10,
            [Description("Is Show As Message")]
            IsShowAsMessageIPC = 11,
            [Description("Is Batch Start")]
            IsBatchStartRequiredIPC = 12,
            [Description("Is Reset On Batch Create")]
            IsResetOnBatchCreateIPC = 13,
            [Description("Is Label Roll(Lable remaining)")]
            IsLabelRollIPC = 14,
            [Description("Disable Parameter")]
            DisableParameterIdIPC = 15,
            [Description("Disable Parameter Value")]
            DisableParameterValueIPC = 16,
            [Description("Is Stop On Batch Stop")]
            IsStopOnBatchStopIPC = 17,
            [Description("Operation Type")]
            OperationTypeIPC = 18,
            [Description("Operation Value")]
            OperationValueIPC = 19,
            [Description("Is Alarm")]
            IsAlarm = 20,
            [Description("Is Machine Speed")]
            IsMachineSpeed = 21,
            [Description("Is Heart Beat")]
            IsHeartBeat = 22,
            [Description("Heart Beat Failed Time(In Secs)")]
            HeartBeatFailedTime = 23,
            [Description("Is Heart Beat Send")]
            IsHeartBeatSend = 24,
            [Description("Incremental Number")]
            IncrementalNumber = 25,
            [Description("Start Number")]
            StartNumber = 26,
            [Description("End Number")]
            EndNumber = 27,
            [Description("Is Write To PLC")]
            IsWriteToPLC = 28,
            [Description("Is Indicator Parameter")]
            IsIndicatorParameter = 29,
            [Description("Indicator Parameter")]
            IndicatorParameterId = 30,
            [Description("Is Good Bottles")]
            IsGoodBottles = 31,
            [Description("Is Reject Bottles")]
            IsRejectBottles = 32,
            [Description("Is Batch Size")]
            IsBatchSize = 33,
            [Description("Is Counter Reset")]
            IsCounterReset = 34,
            [Description("Is Conveyer")]
            IsConveyer = 35,
            [Description("Is Missing Label Counter")]
            IsMissingLabelCounter = 36,
            [Description("Node Id")]
            NodeId = 37,
            [Description("Attribute")]
            AttributeId = 38,
            [Description("32 Bit Address")]
            Bit32Address = 39

        }


        public enum ProtocolFormField
        {
            [Description("Protocol Name(*)")]
            ProtocolName = 1,
            [Description("Status(*)")]
            StatusId = 2,
        }


        public enum MachineCommunicationFormField
        {
            [Description("Protocol(*)")]
            ProtocolTypeId = 1,
            [Description("Machine(*)")]
            MachineiD = 2,
            [Description("Ip Address")]
            IpAddress = 3,
            [Description("Tcpip Port")]
            TCPIPPort = 4,
            [Description("Poll Rate")]
            PollRate = 5,
            [Description("Status(*)")]
            StatusId = 6,
            [Description("Security Mode")]
            SecurityModeId = 7,
            [Description("Security Policy")]
            SecurityPolicyId = 8,
            [Description("Authentication Settings")]
            UserIdentityId = 9,
            [Description("UserName")]
            UserName = 10,
            [Description("Password")]
            Password = 11,
            [Description("MDB Path")]
            MDBPath = 12,



        }

        public enum ShiftFormField
        {
            [Description("Shift Name(*)")]
            ShiftName = 1,
            [Description("Satrt Time(*)")]
            SatrtTime = 2,
            [Description("End Time(*)")]
            EndTime = 3,
            [Description("Status(*)")]
            StatusId = 4
        }

        public enum DesiccantFormField
        {
            [Description("Desiccant Name(*)")]
            DesiccantName = 1,
            [Description("Desiccant Type(*)")]
            DesiccantTypeId = 2,
            [Description("Grammage(*)")]
            Grammage = 3,
            [Description("Length Or Hieght(*)")]
            LengthOrHeight = 4,
            [Description("Diameter Or Width(*)")]
            DiameterOrWidth = 5,
            [Description("Identification(*)")]
            Identification = 6,
            [Description("Supplier")]
            SupplierId = 7,
            [Description("Status(*)")]
            StatusId = 8
        }

        public enum EndOfLineFormField
        {
            [Description("End Of Line Name(*)")]
            EndOfLineName = 1,
            [Description("Carton Length(*)")]
            CartonLength = 2,
            [Description("Carton Height(*)")]
            CartonHeight = 3,
            [Description("Carton Width(*)")]
            CartonWidth = 4,
            [Description("Carton Type(*)")]
            CartonType = 5,
            [Description("Bottle Configuration")]
            BottleConfiguration = 6,
            [Description("Medication Length")]
            MedicationLength = 7,
            [Description("Medication Width")]
            MedicationWidth = 8,
            [Description("No Of Medication")]
            NoOfMedication = 9,
            [Description("Inner Shipper Box Type")]
            InnerShipperBoxType = 10,
            [Description("Inner Shipper Box Length")]
            InnerShipperBoxLength = 11,
            [Description("Inner Shipper Box Width")]
            InnerShipperBoxWidth = 12,
            [Description("Inner Shipper Box Height")]
            InnerShipperBoxHeight = 13,
            [Description("Outer Shipper Box Length")]
            OuterShipperBoxLength = 14,
            [Description("Outer Shipper Box Width")]
            OuterShipperBoxWidth = 15,
            [Description("Outer Shipper Box Height")]
            OuterShipperBoxHeight = 16,
            [Description("Inner Shipper Matrix")]
            InnerShipperMatrix = 17,
            [Description("Outer Shipper Quantity")]
            OuterShipperQuantity = 18,
            [Description("Status")]
            Status = 19


        }

        public enum RecordAddedSorceType
        {
            Csv = 1, Excel = 2,Form=3
        }

    }
}
