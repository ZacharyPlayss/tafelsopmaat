<template>
    <div>
        Foto toevoegen:
    </div>
    <input type="file" accept=".jpg, .jpeg, .png" id="inputFile" @change="onFileSelected">
    <button v-on:click="submit"></button>
</template>
<script>
export default{
    data(){
        return{
            selectedFile: null
        }
    },
    methods:{
        onFileSelected(event){
            this.selectedFile = event.target.files[0];
        },
        submit: function (){
            this.imageLocatie = document.getElementById("inputFile");
        },
    }
}
</script>
<style>
</style>