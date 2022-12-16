Vue.createApp({
    data() {
        return {
            canBeDeleted: true,
            Id
        }
    },
    mounted() {
        let scope = this
        axios.get("/Grupoes/Delete/" + this.Id)
            .then(response => {
                scope.canBeDeleted = response.data.canBeDeleted
            })
            .catch(error => {

            })
    },
    methods: {
        deleteGrupo() {
            axios.delete("/Grupoes/Delete/" + this.Id, { headers: { RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val() } })
                .then(() => {
                    window.location.href = "/Grupoes"
                })
                .catch(error => {

                })
        }
    }

}).mount("#delete")