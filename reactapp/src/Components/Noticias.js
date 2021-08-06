import React, { useEffect, useState } from 'react'
import { useHistory, useLocation } from 'react-router-dom'
import cliente from '../axiosConfig';
import Carta from './Carta';
import NavbarComponent from './NavbarComponent'

const Noticias = () => {
    const location = useLocation();
    const history = useHistory();
    const query =new URLSearchParams(location.search)
    const busqueda = query.get('busqueda');
    const pais = query.get('pais');
    const categoria = query.get('categoria');
    const [Noticias, setNoticias] = useState([])
    const [Mensaje, setMensaje] = useState(false)
    useEffect(() => {
        //comprobamos que el token exista y si no es asi entonces redireccionamos al login
        if(localStorage.getItem('Autenticacion')==null){
            history.push("/Inicio");
        }
       
      (async ()=>{
        if(busqueda ==null && pais==null && categoria==null){
             await cliente.ObtenerNoticias().then(resultado=>setNoticias(resultado));             
        }
       
      })();

    },[])
   
    useEffect(() => {
        //alert("cambio la url")
       
        if(busqueda){
            (async ()=>{
                if(busqueda){                     
                     await cliente.ObtenerNoticiaPorBusqueda(busqueda).then(resultado=>setNoticias(resultado));                 
                   
                }
               
              })();
           }
    }, [location])
    return (
        <div>
            <NavbarComponent />
            <h3>Inicio</h3>
            <div className="container">
                <div className="row">
                   
                    {Noticias.map(datos=><Carta 
                    titulo={datos.titulo} 
                    idNoticias={datos.idNoticias} 
                    fecha={datos.fecha} 
                    nombreCategoria={datos.nombreCategoria}
                    nombrePais={datos.nombrePais}
                    articulo={datos.articulo}
                    key={datos.idNoticias} />
                    ) }
                   
                </div>
            </div>
            
           
        </div>
    )
}

export default Noticias
