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
       
       if(id){
            (async ()=>{
                console.log(id)
                 await cliente.ObtenerNoticiaPorId(parseInt(id)).then(resultado=>setNoticias(resultado));
                 console.log(Noticias)
            })();
        }
        
    }, [])

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-light bg-primary">
  
            <Link className="navbar-brand text-white" to="/Noticias" >Noticias</Link>
            <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span className="navbar-toggler-icon"></span>
            </button>
            </nav>
            <br />
            <div className="container">
                
            </div>
        </div>
    )
}

export default VerNoticia
