import { ServiceFactory } from "../services/service.factory";
import router from "../router";

const authService = ServiceFactory.get("auth");

export const authentication = {
    namespaced: true,
    actions: {
        async login({ dispatch, commit }, { username, password }) {
            const isLoginSuccessfull = await authService.Login({ email: username, password: password });
            if (isLoginSuccessfull) {
                commit('appUser/setUserAsAuthenticated', { username }, { root: true });
                router.push('/');
            }
            else {
                dispatch('alert/error', error, { root: true });
            }
        },
        async logout({ commit }) {
            await authService.Logout();
            commit('appUser/removeAuthenticatedUser', null, { root: true });
        }
    }
}