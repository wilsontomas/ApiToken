import axios from "axios";

/*axios.interceptors.request.use((config)=>{
    let token="";
    if(localStorage.getItem("Autenticacion")){
        const data = JSON.parse(localStorage.getItem("Autenticacion"));
        token = data.token;
    }
    if(token){
        config.headers.Authorization='Bearer '+token;
    }

});*/

const ObtenerPaises = async ()=>{
    let data =[];
    try{
        let token="";
        if(localStorage.getItem("Autenticacion")){
            const data = JSON.parse(localStorage.getItem("Autenticacion"));
            token = data.token;
        }
        const headers = {
            'Authorization': 'Bearer '+token
            
        };
       await axios.get("https://localhost:44394/api/Noticias/ObtenerPais",{headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}

const ObtenerCategorias = async ()=>{
    let data=[];
    try{
       await axios.get("https://localhost:44394/api/Noticias/ObtenerCategoria").then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}


const cliente ={
    ObtenerPaises,
    ObtenerCategorias
}

export default cliente;