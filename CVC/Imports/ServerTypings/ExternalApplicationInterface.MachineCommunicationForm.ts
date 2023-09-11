namespace CVC.ExternalApplicationInterface {
    export interface MachineCommunicationForm {
        ProtocolTypeId: Serenity.LookupEditor;
        MachineId: Serenity.LookupEditor;
        IpAddress: Serenity.StringEditor;
        TcpipPort: Serenity.IntegerEditor;
        PollRate: Serenity.IntegerEditor;
        MDBPath: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        SecurityModeId: Serenity.LookupEditor;
        SecurityPolicyId: Serenity.LookupEditor;
        UserIdentityId: Serenity.LookupEditor;
        UserName: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        CpuTypeId: Serenity.LookupEditor;
        Rack: Serenity.IntegerEditor;
        Slot: Serenity.IntegerEditor;
    }

    export class MachineCommunicationForm extends Serenity.PrefixedContext {
        static formKey = 'ExternalApplicationInterface.MachineCommunication';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineCommunicationForm.init)  {
                MachineCommunicationForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.PasswordEditor;

                Q.initFormType(MachineCommunicationForm, [
                    'ProtocolTypeId', w0,
                    'MachineId', w0,
                    'IpAddress', w1,
                    'TcpipPort', w2,
                    'PollRate', w2,
                    'MDBPath', w1,
                    'StatusId', w0,
                    'SecurityModeId', w0,
                    'SecurityPolicyId', w0,
                    'UserIdentityId', w0,
                    'UserName', w1,
                    'Password', w3,
                    'CpuTypeId', w0,
                    'Rack', w2,
                    'Slot', w2
                ]);
            }
        }
    }
}

