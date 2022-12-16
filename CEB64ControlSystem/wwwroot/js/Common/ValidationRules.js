
let validator = {
    setValidators(validations, source, validationMessages) {
        this.source = source
        this.validationMessages = validationMessages
        let validationTypes = this.validationTypes
        this.source = source
        for (const [key, value] of Object.entries(validations)) {
            let validations = []
            value.forEach(name => validations.push(validationTypes[name]) )
            this.createValidator(validations, key)
        }
    },
    validationTypes: {
        required(DataToValidate) {
            if (!DataToValidate)
                return "Campo obligtorio"
        },
    },
    validators: [],
    isValid() {
        let valid = true
        this.validators.forEach(validator => valid &= validator.validate())

        return valid
    },
    submited: false,
    submit() {
        this.submited = true
        let isValid = this.isValid()
        return isValid
    },
    createValidator(validators, Propname) {
        let source = this.source
        let validationMessages = this.validationMessages

        let validator = 
        {
            validate() {
                let errorMessage = this.getErrorMessage();
                validationMessages[Propname] = errorMessage

                return !errorMessage
                
            },
            getErrorMessage() {

                let propToValidate = source[Propname]
                let errorMessage = "";
                validators.forEach(
                    validator => {
                        let currentError = validator(propToValidate)
                        if (currentError) {
                            errorMessage = validator(propToValidate)
                        } 
                    })
                return errorMessage
            }
        }
        this.validationMessages[Propname] = null
        this.validators.push(validator)

    }

}

    






