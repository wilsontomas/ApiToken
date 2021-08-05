import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router-dom'
import cliente from '../axiosConfig';
import Carta from './Carta';
import NavbarComponent from './NavbarComponent'

const Noticias = () => {
    const location = useLocation();
    const query =new URLSearchParams(location.search)
    const busqueda = query.get('busqueda');
    const pais = query.get('pais');
    const categoria = query.get('categoria');
    const [Noticias, setNoticias] = useState([])
    useEffect(() => {
      
      (async ()=>{
        if(busqueda ==null && pais==null && categoria==null){
             await cliente.ObtenerNoticias().then(resultado=>setNoticias(resultado));             
        }
       
      })();
    },[])
    return (
        <div>
            <NavbarComponent />
            <h3>Inicio</h3>
            <div className="container">
                <div className="row">
                    {console.log(Noticias)}
                    {Noticias.map(datos=><Carta key={datos.idNoticias} />
                    )}{console.log(Noticias)}
                </div>
            </div>
            
           
        </div>
    )
}

export default Noticias
