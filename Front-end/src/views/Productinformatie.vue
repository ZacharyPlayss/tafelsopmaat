<template>
  <div class="Productinformatie">
      <h2>Productinformatie</h2>
      <ul>
          <li>Epoxy tafels</li>
          <li>Epoxy gieterij en tafels die op maat gemaakt worden van massieve houtsoorten en boomstambladen,</li>
          <li>kom naar onze showroom/atelier en stel uw eigen tafel samen bij op Kuringersteenweg 275A 3500 Hasselt. </li>
          <li>Whatsapp 0466-308043</li>
      </ul>
       <!-- <p>Kom vrijblijvend langs en stel zelf uw tafel samen!</p>-->
      <p>Geïnteresseerd? Neem snel contact met ons op!</p>
      <button><router-link to="/Contact">Contact</router-link></button>
  </div>
</template>
<style>
.Productinformatie{
    height:var(--mainHeight);
    background:var(--productinfoImage) 100% no-repeat;
}

.Productinformatie > ul{
    color:var(--color2);
    font-size:1.5rem;
    margin-left: var(--leftTextMargin);
    list-style-type:none;
    margin-top:5%;
}
.Productinformatie > p{
    color:var(--color2);
    font-size:1.5rem;
    margin-top:5%;
    margin-left: var(--leftTextMargin);
}
.Productinformatie > button{
    margin-left: var(--leftTextMargin);
    margin-top:1%;
}
@media (min-width:768px) {
    .Productinformatie{
        background:var(--productinfoImage) 100%/100% no-repeat;
    }
    .Productinformatie > ul{
        margin-top:3%;
         font-size:2rem;
    }
    .Productinformatie > p{
    margin-top:2%;
    font-size:1.5rem;
    }
}
@media (min-width:1385px) {
    .Productinformatie > ul{
         font-size:3rem;
         margin-top:0%;
    }
     .Productinformatie > p{
    margin-top:2%;
    font-size:2rem;
    }
}
</style>