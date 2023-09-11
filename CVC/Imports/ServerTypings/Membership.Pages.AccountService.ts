namespace CVC.Membership.Pages {
    export namespace AccountService {
        export const baseUrl = '~/Account';

        export declare function ChangePassword(request: ChangePasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ForgotPassword(request: ForgotPasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ResetPassword(request: ResetPasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function SignUp(request: SignUpRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            ChangePassword = "~/Account/ChangePassword",
            ForgotPassword = "~/Account/ForgotPassword",
            ResetPassword = "~/Account/ResetPassword",
            SignUp = "~/Account/SignUp"
        }

        [
            'ChangePassword', 
            'ForgotPassword', 
            'ResetPassword', 
            'SignUp'
        ].forEach(x => {
            (<any>AccountService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

