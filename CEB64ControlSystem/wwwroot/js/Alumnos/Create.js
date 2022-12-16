Vue.createApp({
    data() {
        return {
            model: {
                Name:null,
                ApellidoPaterno: null,
                ApellidoMaterno: null,
                Direccion: null,
                NumeroTelefonico: null,
                Mail: null,
                Id,
                FechaNacimiento: null,
                GrupoId: 0,
                SemestreId:0
            },
            semestres: [],
            grupos: [],
            validations:{},
            Id
        }
    },
    watch: {
        "model.SemestreId":function(){
            this.searchGrupos()
        }
    },
    methods: {
        searchGrupos() {
            let scope = this
            axios.get("/Alumnos/Grupos/" + scope.model.SemestreId, { headers: { RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val() } })
                .then(response => scope.grupos = response.data)
                .catch(error => {
                    console.log(error)
                })
        },
        requestInitialData() {
            let scope = this
            axios.get("/Alumnos/CreateInitialData/", { headers: { RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val() } })
                .then(response => scope.semestres = response.data)
                .catch(error => {
                    console.log(error)
                })
        },
        submit() {
            let scope = this
            let isValid = validator.submit()
            this.validations.updateTrigger = true

            if (isValid)
                axios.post("/Alumnos/Create", scope.model, { headers: { RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val() } })
                .then(() => {
                    Window.location = "/Home"
                })
                .catch(error => {

                })
        }
    },
    mounted() {
        this.requestInitialData()

        let validations = {
            Name: ["required"],
            ApellidoPaterno: ["required"],
            ApellidoMaterno: ["required"],
            Direccion: ["required"],
            NumeroTelefonico: ["required"],
            Mail: ["required"],
            FechaNacimiento: ["required"],
            GrupoId: ["required"],
            SemestreId: ["required"],
            FechaIngreso: ["required"]
        }
        validator.setValidators(validations, this.model, this.validations)

    }
}).mount("#app")