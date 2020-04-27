import BaseService from "./base.service";
import VueCookie from "vue-cookie";
import { authEndPoint } from "./api.endpoints";

export default {
    async Login(payload) {
        const accessToken = await BaseService.post(`${authEndPoint}/authenticate`, payload);
        return this.SetAuthHeaders(accessToken);
    },

    async Logout() {
        this.DeleteAuthHeader();
    },

    SetAuthHeaders(accessToken) {
        if (!accessToken)
            return false;
        VueCookie.set("access-token", accessToken);
        BaseService.defaults.headers.common["Authorization"] = `Bearer ${VueCookie.get("access-token")}`;
        return true;
    },

    DeleteAuthHeader() {
        VueCookie.delete("access-token");
        delete BaseService.defaults.headers.common["Authorization"];
    },

    SetAuthHeadersFromCookie() {
        BaseService.defaults.headers.common["Authorization"] = `Bearer ${VueCookie.get("auth")}`;
    }
}