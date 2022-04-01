<template>
    <div>
        Foto toevoegen:
    </div>
    <input type="file">
    <button v-on:click="submit"></button>
</template>
<script>
export default{
    data(){
        return{
            imageLocatie: ''
        }
    },
    methods:{
        submit: function (){
            this.image
        },
    }
}
</script>
<style>
</style>