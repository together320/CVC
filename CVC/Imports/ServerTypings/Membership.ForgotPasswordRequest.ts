namespace CVC.Membership {
    export interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Username?: string;
        QuestionId?: number;
        QuestionAns?: string;
        Password?: string;
        PasswordConfirm?: string;
    }
}

