<template>
  <div class="Contact">
      <h2>Contact</h2>
      <div class="contactContainer">
        <div class="onlineContact">
            <h3>Online</h3>
            <p>+32 466 30 80 43</p>
            <p>facebook.com/tafelsopmaathasselt</p>     
            <p>instagram.com/tafelsopmaat</p>
            <p>info@hitibv.be</p>
            </div>
        <div class="irlContact">
            <h3>Of kom langs te:</h3>
            <p>Kuringersteenweg 275A <br>
            3500 Hasselt België</p>
        </div>
      </div>
  </div>
</template>
<style>
.Contact{
    height:var(--mainHeight);
    background:var(--contactImage) no-repeat 100%/auto;
}

.Contact  h3{
    color:var(--color2);
    font-size:1.75rem;
}
.Contact p{
    color:var(--color2);
    font-size:1rem;
}
.contactContainer{
    width:100%;
    height:52vh;
    display:flex;
    flex-direction:column;
    align-items:center;
    justify-content:space-evenly;
}
.onlineContact{
    width:85%;
}
.irlContact{
width:85%;
}
@media (min-width:768px) {
    .Contact{
    height:var(--mainHeight);
    background:var(--contactImage) no-repeat 100%/100%;
}
    .contactContainer{
        flex-direction:row;
    }
    .onlineContact{
        width:75%;;
        margin-left:6vw;
    }
    .irlContact{
    margin-left:5vw;
    width:75%;
    }
   .Contact  h3{
    font-size:3rem;
    }
    .Contact p{
        font-size:2rem;
    }
}
@media (min-width:1385px) {
     .onlineContact{
        margin-left:10vw;
    }
}
</style>