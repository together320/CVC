namespace CVC.Membership {
    export interface SignUpRequest extends Serenity.ServiceRequest {
        FirstName?: string;
        LastName?: string;
        Email?: string;
        Password?: string;
    }
}

