import React from 'react'

const Carta = (props) => {
   
    return (
        <div>
            <div className="card mr-3" style={{width: '18rem'}}>
            <img className="card-img-top" alt={props.titulo}  src='/news.png' />
            <div className="card-body">
                <h5 className="card-title">{props.titulo}</h5>
                 <a href="#" className="btn btn-primary">Ver Noticia</a>
            </div>
            </div>
        </div>
    )
}

export default Carta
