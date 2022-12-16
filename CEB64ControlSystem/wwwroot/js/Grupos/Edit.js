Vue.createApp({
    data() {
        return {
            Model: {},
            Id
        }
    },
    mounted() {
        let scope = this
        axios.get("/Grupoes/Editdata/" + this.Id)
            .then(response => {
                scope.Model = response.data
            })
            .catch(error => {

            })
    },
    methods: {
        submit() {
            axios.post("/Grupoes/Edit", this.Model, { headers: { RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val() }})
                .then(() => {
                    Window.location = "/Home"
                })
                .catch(error => {

                })
        }
    },
    computed: {
        NameValidation: function () {
            if (!this.Model.name)
                return "Nombre inválido"
            
            this.submit()

        },
        SemestreValidation: function () {
            if (this.Model.semestreId)
                this.submit()
        }
    }

}).mount("#app")