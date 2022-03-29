<template>
  <div class="Productinformatie">
      <h2>Productinformatie</h2>
      <ul>
          <li>Tafels op maat uit massief eikenhout en boomstambladen.</li>
          <li>Epoxy tafels</li>
          <li>Epoxy gieterij</li>
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
    margin-top:20%;
}
.Productinformatie > p{
    color:var(--color2);
    font-size:1.5rem;
    margin-top:20%;
    margin-left: var(--leftTextMargin);
}
.Productinformatie > button{
    margin-left: var(--leftTextMargin);
    margin-top:1%;
}
@media (min-width:768px) {
    .Productinformatie > ul{
         font-size:3rem;
    }
    .Productinformatie > p{
    margin-top:5%;
    font-size:2rem;
    }
}
@media (min-width:1385px) {
    .Productinformatie > ul{
         font-size:3rem;
         margin-top:5%;
    }
     .Productinformatie > p{
    margin-top:2%;
    font-size:2rem;
    }
}
</style>