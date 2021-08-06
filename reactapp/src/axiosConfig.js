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
        let token="";
        if(localStorage.getItem("Autenticacion")){
            const data = JSON.parse(localStorage.getItem("Autenticacion"));
            token = data.token;
        }
        const headers = {
            'Authorization': 'Bearer '+token
            
        };
const ObtenerPaises = async ()=>{
    let data =[];
    try{
       
       await axios.get("https://localhost:44394/api/Noticias/ObtenerPais",{headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}

const ObtenerNoticias = async ()=>{
    let data =[];
    try{
       await axios.get("https://localhost:44394/api/Noticias/ObtenerNoticias",{headers}).then(respuesta=>{
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
       await axios.get("https://localhost:44394/api/Noticias/ObtenerCategoria", {headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}

const ObtenerNoticiaPorBusqueda = async (terminoNoticia)=>{
    let data=[];
    try{

        let parametros ={termino:'terminoNoticia'}
        
       await axios.post("https://localhost:44394/api/Noticias/ObtenerNoticiaPorBusqueda",parametros, {headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}
const ObtenerNoticiaPorId = async (idNoticia)=>{
    let data=[];
    try{
        let parametros ={id:idNoticia}
       await axios.get("https://localhost:44394/api/Noticias/ObtenerNoticiaPorId",parametros, {headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}

const ObtenerNoticiasPorCategoria = async (idCategoria)=>{
    let data=[];
    try{
        let parametros ={id:idCategoria}
       await axios.get("https://localhost:44394/api/Noticias/ObtenerNoticiasPorCategoria",parametros, {headers}).then(respuesta=>{
        data = respuesta.data;
       }).catch(error=>{console.log(error)});
      // console.log(data);
       return data;
    }catch{
        return null;
    }
}

const ObtenerNoticiasPorPais = async (idPais)=>{
    let data=[];
    try{
        let parametros ={id:idPais}
       await axios.get("https://localhost:44394/api/Noticias/ObtenerNoticiasPorPais",parametros, {headers}).then(respuesta=>{
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
    ObtenerCategorias,
    ObtenerNoticias,
    ObtenerNoticiaPorBusqueda,
    ObtenerNoticiaPorId,
    ObtenerNoticiasPorPais,
    ObtenerNoticiasPorCategoria
}

export default cliente;