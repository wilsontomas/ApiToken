import React, { useEffect, useState } from 'react'
import { useHistory } from 'react-router-dom';
import cliente from '../axiosConfig';

const NavbarComponent = () => {
const history = useHistory();


const [paises, setpaises] = useState([])
 useEffect(() => {
   (async ()=>{
     await cliente.ObtenerPaises().then(resultado=>setpaises(resultado));
  
   })();
  
 }, [])
  






  const cerrarSesion =()=>{
    
    localStorage.removeItem('Autenticacion');
    history.push("/Inicio");
  }
    return (
        <div>
             <nav className="navbar navbar-expand-lg navbar-light bg-primary">
          <a className="navbar-brand" href="#">Navbar</a>
          <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span className="navbar-toggler-icon"></span>
          </button>

        <div className="collapse navbar-collapse " id="navbarSupportedContent">
          <ul className="navbar-nav mr-auto">
            <li className="nav-item form-inline my-2 my-lg-0">
                 <select className="form-control"> 
                {paises.map(valor=><option key={valor.idPais} value={valor.idPais}>{valor.nombrePais}</option>
                )}
                {console.log(paises)}
                </select>
                <button className="btn btn-success">BuscarPorPais</button>
            </li>
          
          </ul>
          <div className="form-inline my-2 my-lg-0">
            <input className="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" ></input>
            <button className="btn btn-success my-2 my-sm-0" type="button">Search</button>
            <button type="button" onClick={cerrarSesion} className="btn btn-danger">Salir</button>
          </div>
          
        </div>
      </nav>
        </div>
    )
}

export default NavbarComponent
