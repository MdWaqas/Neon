import Vue from "vue";
import VueRouter from "vue-router";
import Routes from "./routes";
import Store from "../store";

Vue.use(VueRouter);


const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes: Routes
});

router.beforeEach((to, from, next) => {
  // redirect to login page if not logged in and trying to access a restricted page
  if (to.matched.some(route => route.meta.requiresAuth)) {
    if(!Store.state.appUser.isAutenticated){
      return next('/login');
    }
    next();
  }
  next();
});

export default router;
