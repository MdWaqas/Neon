
export const appUser = {
    namespaced: true,
    state: {
        isAutenticated: false,
        email: null
    },
    mutations: {
        setUserAsAuthenticated(state, email) {
            state.isAutenticated = true;
            state.email = email;
        },
        removeAuthenticatedUser(state) {
            state.isAutenticated = false;
            state.email = false;
        }
    }
}