<template>
  <div class="Realisaties">
      <h2>Realisaties</h2>
        <div class="realisatiesImgContainer">
            <div class="images" id="image1">
                 <img src="https://www.travelalut.com/wp-content/uploads/2017/08/kameel-rijden.jpg">
            </div>
            <div class="images" id="image2">
                 <img src="https://www.travelalut.com/wp-content/uploads/2017/08/kameel-rijden.jpg">
            </div>
            <div class="images" id="image3">
                 <img src="https://www.travelalut.com/wp-content/uploads/2017/08/kameel-rijden.jpg">
            </div>
        </div>
  </div>
</template>
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