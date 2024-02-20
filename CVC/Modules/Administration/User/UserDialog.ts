namespace CVC.Administration {
    @Serenity.Decorators.registerClass()
    export class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        protected getFormKey() { return UserForm.formKey; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getNameProperty() { return UserRow.nameProperty; }
        protected getService() { return UserService.baseUrl; }
        protected getDeletePermission() { return UserRow.deletePermission; }
        protected getInsertPermission() { return UserRow.insertPermission; }
        protected getUpdatePermission() { return UserRow.updatePermission; }

        protected form = new UserForm(this.idPrefix);
        constructor() {
            super();

        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = UserService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[UserRow.Fields.UserId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in User
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }
    }
}