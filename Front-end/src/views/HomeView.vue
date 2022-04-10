<template>
  <div class="home">
    <div class="homeText">
      <h1>Tafels op maat Hasselt</h1>
      <p>Epoxy, Tafels uit massief eikenhout, boomstambladen.</p>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  }
}
</script>
<style>
  *{
    margin:0;
    padding:0;
  }
  .home{
    background:url("../assets/images/Tafel_1.png") 100%/100% no-repeat  ;
    height:82vh;
    display:flex;
  }
  .homeText{
    align-self:center;
    width:100%;
    padding:2%;
  }
  h1{
    width:100%;
    color:var(--color2);
    font-size:3rem;
    margin-left:var(--leftTextMargin);
  }
  p{
    font-size:1.2rem;
    color:var(--color2);
    margin-left:var(--leftTextMargin);
  }
  @media (min-width:768px) {
    h1{
      width:50%;
      font-size:4rem;
    }
    p{
      font-size:2.5rem;
    }
  }
  @media (min-width:1385px) {
    h1{
      font-size:5.5rem;
    }
    p{
      font-size:2.3rem;
    }
  }
</style>