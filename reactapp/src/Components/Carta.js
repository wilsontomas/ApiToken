import React from 'react'
import { Link, useHistory, useLocation } from 'react-router-dom'

const Carta = (props) => {
   const history =useHistory();
   const location = useLocation()
   const query = new URLSearchParams(location.search);

   const ver=(id)=>{
    query.set('id',1)
    history.push('/verNoticia',{search: "?id="+1});
   }
   
    return (
        <div>
            <div className="card mr-3" style={{width: '18rem'}}>
            <img className="card-img-top" alt={props.titulo}  src='/news.png' />
            <div className="card-body">
                <h5 className="card-title">{props.titulo}</h5>
                  <Link className="btn btn-primary" to={{
                    pathname: '/VerNoticia',
                    search: "?id="+props.idNoticias
                    }}> Ver Noticia </Link>
            </div>
            </div>
        </div>
    )
}

export default Carta
