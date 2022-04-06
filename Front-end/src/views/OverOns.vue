<template>
  <div class="about">
    <div class="aboutText">
      <h2>Over ons</h2>
      <p>Onze specialisatie ligt bij tafels op maat.
        Op zoek naar een prachtige eettafel, kleine bijzettafel, salontafels, tuintafels, horecatafels...
        Dan bent  bij ons aan het juiste adress!
      </p>
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
  background:var(--overOnsImage) no-repeat 100%;
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
   font-size:2rem;
  }
}
@media (min-width:1385px) {

}
</style>