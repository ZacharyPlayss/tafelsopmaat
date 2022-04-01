<template>
  <nav>
    <div class="nav-Items">
      <router-link to="/">Home</router-link> 
      <router-link to="/about">Over ons</router-link>
      <router-link to="/Realisaties">Realisaties</router-link>
      <router-link to="/Contact">Contact</router-link>
      <router-link to="/Productinformatie">Productinformatie</router-link>
    </div>
  </nav>
  <router-view/>
  <footer>
    <ul class="footerList">
      <li>+32 466 30 80 43</li>
      <li>Kuringersteenweg 275A 3500 Hasselt België</li>
      <li>info@hititbv.be</li>
    </ul>
  </footer>
</template>

<script>
import { Slide } from 'vue-burger-menu'  // import the CSS transitions you wish to use, in this case we are using `Slide`

export default {
   components: {
        Slide // Register your component
    },
 data(){
    return{
      pageHeight: window.innerHeight, 
      pageWidth: window.innerWidth
    }
  },
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Open+Sans:wght@300&display=swap');

body{
  margin:0;
  padding:0;
  font-size: 16px;
}
:root{
  /*colors*/
    --black : #000;
    --white: #fff;
    --color1 : #BF8654;
    --color2: #000;
  /*fonts*/
    --MainFont: 'Open Sans', sans-serif;
  /*heights*/
    --mainHeight: 82vh;
  /*background_images*/
    --contactImage: url("@/assets/images/contact_bg.jpg" );
    --overOnsImage : url("@/assets/images/overOns_bg.png");
    --realisatiesImage: url("@/assets/images/realisaties_bg.png");
    --productinfoImage: url("@/assets/images/productinformatie_bg.png");
  /*margins*/
    --leftTextMargin: 7%;
    --leftTextMarginTop: 3%;
}

#app {
 font-family: var(--MainFont);
}

nav {
  padding:0.5rem;
  width:99vw;
  height:7vh;

}
.nav-Items{
  width:50%;
  height:100%;
  margin:0 auto;
  margin-right:2%;
  display:flex;
  justify-content:space-around;
  align-items:center;
  float:right;
  font-weight:500;
}
nav a {
  color:var(--black);
  text-decoration:none;
  font-size:0.7rem;
}
footer{
  height:7vh;
  font-size:0.5rem;
}
.footerList{
  display:flex;
  flex-direction: row;
  justify-content:flex-start;
  list-style-type:none;
}
.footerList > li{
  margin-left:5%;
  margin-top:2%;
}
.router-link-exact-active{
  font-weight:900;
}
button{
  background:var(--white);
  border:5px solid var(--white);
  outline:none;
  padding: 0.75rem 1.5rem;
  font-size:1rem;
  font-weight:900;
  border-radius:50px;
  color:var(--color2);
}
button:hover{
  border:5px solid var(--white);
background:none;
  color:var(--white);
}
button:hover > a{
  color:white;
}
h2{
  margin-left:var(--leftTextMargin);
  font-size:2rem;
  color:var(--color2);
}

@media (min-width:768px) {
  footer{
    font-size:1rem;
  }
  nav {
  padding:0.5rem;
  width:99vw;
  height:7vh;
}
.nav-Items{
  width:50%;
  height:100%;
  margin:0 auto;
  margin-right:2%;
  display:flex;
  justify-content:space-around;
  align-items:center;
}

nav a {
  color:var(--black);
  text-decoration:none;
  margin:0 1%;
  font-size:1rem;
}
h2{
  font-size:5rem;
}
  
}
@media (min-width:1385px) {
  h2{
    font-size:6rem;
    margin-top:4%;
  }
  nav a {
  font-size:2rem;
}
}
</style>
