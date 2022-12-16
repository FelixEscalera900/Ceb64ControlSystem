
function CheckFormValues(formId){
    let form = $("#" + formId)
    form.append('<input value="true" type="hidden" name = "FormTransmuted" />')
    form.submit()
}
