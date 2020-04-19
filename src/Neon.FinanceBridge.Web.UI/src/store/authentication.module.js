import { ServiceFactory } from "../services/service.factory";
import router from "../router";

const authService = ServiceFactory.get("auth");

const user = JSON.parse(localStorage.getItem('user'));
const initialState = user
    ? { status: { loggedIn: true }, user }
    : { status: {}, user: null };

export const authentication = {
    namespaced: true,
    state: initialState,
    actions: {
        async login({ dispatch, commit }, { email, password }) {
            const isLoginSuccessfull = await authService.Login(email, password);
            if (isLoginSuccessfull) {
                commit('loginRequest', { email });
                router.push('/');
            }
            else {
                commit('loginFailure', error);
                dispatch('alert/error', error, { root: true });
            }
        },
        async logout({ commit }) {
            await authService.Logout();
            commit('logout');
        }
    },
    mutations: {
        loginRequest(state, user) {
            state.status = { loggingIn: true };
            state.user = user;
        },
        loginSuccess(state, user) {
            state.status = { loggedIn: true };
            state.user = user;
        },
        loginFailure(state) {
            state.status = {};
            state.user = null;
        },
        logout(state) {
            state.status = {};
            state.user = null;
        }
    }
}