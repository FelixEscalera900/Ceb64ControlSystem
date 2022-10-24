Vue.createApp({
    data() {
        return {
            Model: {},
            Id
        }
    },
    mounted() {
        let scope = this
        axios.get("Editdata/" + this.Id)
            .then(response => {
                scope.Model = response.data
            })
            .catch(error => {

            })
    },
    methods: {
        submit(route) {
            axios.post(route, this.Model)
                .then(() => {
                    Window.location = "/Home"
                })
                .catch(error => {

                })
        }
    },
    Computed: {
        NameValidation: function () {
            if (!this.Model.Name)
                return "Nombre inválido"
            
            this.submit("Edit")
            return ""
        },
        NameValidation: function () {
            if (this.Model.SemestreId)
                this.submit("Edit")
        }
    }

}).mount("#app")