import Vue from 'vue';
import Vuex from 'vuex';

import { alert } from './alert.module';
import { authentication } from './authentication.module';
import { appUser } from "./appusers.module";

Vue.use(Vuex);

const store = new Vuex.Store({
    strict: true,
    modules: {
        alert,
        authentication,
        appUser
    }
});

export default store;