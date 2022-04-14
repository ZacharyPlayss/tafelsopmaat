<template>
  <div class="about">
    <div class="aboutText">
      <h2>Over ons</h2>
      <p>Epoxy tafels, Epoxy gieterij en tafels die op maat gemaakt worden van massief oud en nieuwe houtsoorten en boomstambladen, om naar onze showroom/atelier en stel uw eigen tafel samen bij op Kuringersteenweg 275A 3500 Hasselt. Whatsapp 0466-308043</p>
      <button><router-link to="/Contact">Contact</router-link></button>
    </div>
    <div class="aboutImage">
      <img src="@\assets\gallery\foto22.jpg">
    </div>
  </div>
</template>
<style>
*{
  overflow:hidden;
}
.about{
  background:var(--overOnsImage) no-repeat 100%;
  height:var(--mainHeight);
  display:flex;
  flex-direction:column;
}
.aboutText{
  grid-column-start:1;
  grid-column-end:3;
  order:2;
}
.aboutText > h2{
  margin-left:calc(2 * var(--leftTextMargin));
}
.aboutText > p{
  margin-left:calc(2 * var(--leftTextMargin));
  padding-top:3%;
}
.aboutText > button{
   margin-left:calc(2 * var(--leftTextMargin));
  margin-top:5%;
}
.aboutImage{
  display:flex;
  justify-content:center;
  align-items:center;
  grid-column-start:3;
  grid-column-end:5;
  order:1;
  padding:2%;

}
.aboutImage > img {
  width:50%;
  height:auto;
  border-radius:50%;
}
a{
  text-decoration:none;
  color:var(--color2);
}
@media (min-width:768px) {
  .about{
  background:var(--overOnsImage) no-repeat 100%/100%;
  height:var(--mainHeight);
  display:grid;
  grid-template-columns: 1fr 1fr 1fr 1fr;
  }
  .aboutText{
    order:1;
  }
  .aboutImage{
    order:2;
  }
  .aboutText > p{
   font-size:1.75rem;
  }
}
@media (min-width:1385px) {

}
</style>