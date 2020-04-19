import Axios from "axios";

const baseURL = "https://localhost:44317/api/";

const httpHandler = Axios.create({
    baseURL
});

httpHandler.interceptors.request.use(
    function(config){
        //TODO: Handle Progress Bar Here
        return config;
    },
    function(error){
        return Promise.reject(error);
    }
);

httpHandler.interceptors.response.use(undefined, async function(error){
    if(error.response.status===401){
        const originalRequest = error.config;
        //TODO: Will handle the Refresh Token and Access Token Logic Here for all requests.
        return Promise.reject(response.error);
    }
    return Promise.reject(error);
});

export default httpHandler;