<template>
  <div class="Contact">
      <h2>Contact</h2>
      <div class="contactContainer">
       <form>
           <input type="text" name="Contact-Name" placeholder="Naam">
           <input type="email" name="Contact-Email" placeholder="E-mail">
           <textarea name="Contact-Message" rows="6" cols="20">
           </textarea>
           <button type="submit" value="Submit">Versturen</button>
       </form>
       <ul>
           <li>+32 466 30 80 43</li>
           <li><a href="http://www.facebook.com/tafelsopmaathasselt">facebook.com/tafelsopmaathasselt</a></li>
           <li><a href="http://www.instagram.com/tafelsopmaat">instagram.com/tafelsopmaat</a></li>
       </ul>
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
.contactContainer > form{
    display:flex;
    flex-direction:column;
    align-items:center;
}
input{
    margin-top:5%;
}
.onlineContact{
    width:85%;
}
.irlContact{
width:85%;
}
li{
    font-size:1.5rem;
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