<template>
  <div class="Realisaties">
      <h2>Realisaties</h2>
        <div class="realisatiesImgContainer">
            <div class="images">
                <img src="@\assets\gallery\foto1.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto2.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto4.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto5.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto6.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto7.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto8.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto9.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto10.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto12.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto13.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto14.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto15.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto16.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto17.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto18.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto19.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto20.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto21.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto22.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto23.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto24.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto25.jpg">
            </div>
            <div class="images">
                <img src="@\assets\gallery\foto26.jpg">
            </div>
        </div>
  </div>
</template>
<script>
export default{
    data(){
        return{
            galleryImages: []
        }
    },
    methods:{
        // fetchImages: function () {
        //     let url = "https://localhost:44328/api/Galleryimages";
        //     this.images = [];
        //     fetch(url)
        //     .then( (response) => {
        //         if(response.status == 200){
        //             return response.json();
        //         }
        //         else{
        //             throw `Error with status ${response.status}`;
        //         }
        //     } )
        //     .then((images) => {
        //         this.galleryImages = images;
        //     })
        //     .catch((error) => {
        //         this.error = error;
        //     })
        // }
    }
}
</script>
<style>
.Realisaties{
    height:var(--mainHeight);
    background:var(--realisatiesImage) 100%/100% no-repeat;
}
.realisatiesImgContainer{
    margin:0 auto;
    width:90%;
    height:83%;
    display:flex;
    flex-direction:column;
    overflow: hidden;
    flex-wrap: wrap;  
}
.images{
    margin-top:4%;
    height:15rem;
    display:flex;
    justify-content: center;
    align-items: center;
    background:white;
}
div img {
    height:100%;
    object-fit:contain;
}

    .realisatiesImgContainer{
    display:flex;
    flex-direction:row;
    overflow-y: scroll;
    overflow-x: hidden;
}
.images{
    margin-left:4%;
    width: 90vw;
}
@media (min-width:768px){
    .images{
        width:40vw;
    }
}
@media (min-width:1200px){
    .images{
        width:25vw;
    }
}
</style>