import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import OverOns from '../views/OverOns.vue'
import Realisaties from '../views/Realisaties.vue'
import Contact from '../views/Contact.vue'
import Productinformatie from '@/views/Productinformatie.vue'
import Admin from '@/views/Admin.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    component: OverOns
  },
  {
    path: '/Realisaties',
    name: 'Realisaties',
    component: Realisaties
  },
  {
    path: '/Contact',
    name: 'Contact',
    component: Contact
  },
  {
    path: '/Productinformatie',
    name: 'Productinformatie',
    component: Productinformatie
  },
  {
    path: '/Admin',
    name: 'Admin',
    component: Admin
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
