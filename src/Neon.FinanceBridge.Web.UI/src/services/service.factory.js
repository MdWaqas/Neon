import AuthService from "./auth.service";

const services = {
    auth: AuthService
}
2
export const ServiceFactory = {
    get: name => services[name]
}