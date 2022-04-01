<template>
  <div class="Realisaties">
      <h2>Realisaties</h2>
        <div class="realisatiesImgContainer">
            <!-- <div v-for="image in galleryImages" class="images">
                <img src=" @\assets\images\{{image.locatie}}">
            </div> -->
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
        fetchImages: function () {
            let url = "https://localhost:44328/api/Galleryimages";
            this.images = [];
            fetch(url)
            .then( (response) => {
                if(response.status == 200){
                    return response.json();
                }
                else{
                    throw `Error with status ${response.status}`;
                }
            } )
            .then((images) => {
                this.galleryImages = images;
            })
            .catch((error) => {
                this.error = error;
            })
        }
    }
}
</script>
<style>
.Realisaties{
    height:var(--mainHeight);
    background:var(--realisatiesImage) 100% no-repeat;
}
.realisatiesImgContainer{
    margin:0 auto;
    width:90%;
    height:83%;
    display:flex;
    flex-direction:column;
    overflow: hidden;
}
.images{
    margin-top:4%;
    height:500px;
}
@media (min-width:768px) {
    .realisatiesImgContainer{
    display:flex;
    flex-direction:row;
    overflow:hidden;
}
.images{
    margin-left:4%;
}
}
</style>