import React, { useEffect, useState } from 'react'
import { Link, useHistory, useLocation } from 'react-router-dom'
import cliente from '../axiosConfig'

const VerNoticia = () => {
    const location = useLocation();
    const history = useHistory();
    const query =new URLSearchParams(location.search)
    const id=query.get('id')
    const [Noticias, setNoticias] = useState({})

    useEffect(() => {
       if(id===null || id===''){
           history.push('/Noticias')
       }
       if(id){
            (async ()=>{           
                 await cliente.ObtenerNoticiaPorId(parseInt(id)).then(resultado=> setNoticias(resultado));
                
            })();
        }
        
    }, [Noticias])

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-light bg-primary">
  
            <Link className="navbar-brand text-white" to="/Noticias" >Noticias</Link>
            
            </nav>
            <br />
            <div className="container">
                <h3>{Noticias.titulo}</h3>
                <br />
                <h5>Fecha: {Noticias.fecha}</h5>
                <h5>Categoria: {Noticias.nombreCategoria}</h5>
                <h5>Pais: {Noticias.nombrePais}</h5>
                <br />
                <p>{Noticias.articulo}</p>
                <br />
                <Link className="btn btn-primary" to="/Noticias">Volver a la pagina principal</Link>


            </div>
        </div>
    )
}

export default VerNoticia
