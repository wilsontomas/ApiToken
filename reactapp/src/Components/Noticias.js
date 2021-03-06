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
    useEffect(() => {
        //comprobamos que el token exista y si no es asi entonces redireccionamos al login
        if(localStorage.getItem('Autenticacion')==null){
            history.push("/Inicio");
        }
       
      (async ()=>{
        if(busqueda ===null && pais===null && categoria===null){
             await cliente.ObtenerNoticias().then(resultado=>setNoticias(resultado));             
        }
       
      })();

    },[])
   
    useEffect(() => {
        //alert("cambio la url")
       
        //se detecta si existe el termino de busqueda en la url y si existe se consulta la base de datos
        if(busqueda){
            (async ()=>{                                  
                     await cliente.ObtenerNoticiaPorBusqueda(busqueda).then(resultado=>setNoticias(resultado));                                                               
              })();
              
           }
        if(pais){
            (async()=>{
                await cliente.ObtenerNoticiasPorPais(pais).then(resultado=>setNoticias(resultado))
            })();
        }
        if(categoria){
            (async ()=>{
                await cliente.ObtenerNoticiasPorCategoria(categoria).then(resultado=>setNoticias(resultado));
            })();
        }
        (async ()=>{
            if(busqueda ===null && pais===null && categoria===null){
                 await cliente.ObtenerNoticias().then(resultado=>setNoticias(resultado));             
            }
           
          })();
        
    }, [location])
    return (
        <div>
            <NavbarComponent />
           <br />
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
                   {Noticias.length===0 ? <h3>No se encontraron registros</h3> :null}
                </div>
            </div>
            
           
        </div>
    )
}

export default Noticias
