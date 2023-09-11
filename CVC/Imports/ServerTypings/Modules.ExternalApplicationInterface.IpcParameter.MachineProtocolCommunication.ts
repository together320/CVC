namespace CVC.Modules.ExternalApplicationInterface.IpcParameter {
    export interface MachineProtocolCommunication {
        MachineCommunicatonId?: number;
        ProtocolTypeId?: number;
        MachineId?: number;
        IpAddress?: string;
        MDBPath?: string;
        TcpipPort?: number;
        PollRate?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ProtocolName?: string;
        MachineMachineName?: string;
    }

    export namespace MachineProtocolCommunication {
        export const idProperty = 'ProtocolTypeId';
        export const nameProperty = 'ProtocolName';
        export const localTextPrefix = 'ExternalApplicationInterface.MachineCommunication';
        export const lookupKey = 'ExternalApplicationInterface.MachineProtocolCommunication';

        export function getLookup(): Q.Lookup<MachineProtocolCommunication> {
            return Q.getLookup<MachineProtocolCommunication>('ExternalApplicationInterface.MachineProtocolCommunication');
        }
        export const deletePermission = 'EAI:MachineCommunication:Modify';
        export const insertPermission = 'EAI:MachineCommunication:Modify';
        export const readPermission = 'EAI:MachineCommunication:Read';
        export const updatePermission = 'EAI:MachineCommunication:Modify';

        export declare const enum Fields {
            MachineCommunicatonId = "MachineCommunicatonId",
            ProtocolTypeId = "ProtocolTypeId",
            MachineId = "MachineId",
            IpAddress = "IpAddress",
            MDBPath = "MDBPath",
            TcpipPort = "TcpipPort",
            PollRate = "PollRate",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ProtocolName = "ProtocolName",
            MachineMachineName = "MachineMachineName"
        }
    }
}

