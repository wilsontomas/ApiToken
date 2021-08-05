import React, { useEffect, useState } from 'react'
import { useHistory, useLocation } from 'react-router-dom';
import cliente from '../axiosConfig';

const NavbarComponent = () => {
const history = useHistory();
const location =useLocation();
const query = new URLSearchParams(location.search);



const [paises, setpaises] = useState([]);
const [categoria, setcategoria] = useState([])
 useEffect(() => {
   (async ()=>{
     await cliente.ObtenerPaises().then(resultado=>setpaises(resultado));
    await cliente.ObtenerCategorias().then(resultado=>setcategoria(resultado));
   })();
  
 }, [])
  


 const manejarCategoria =()=>{
  let id = document.getElementById("categoria").value;
  console.log(id);
  query.delete('pais')
  query.delete('busqueda')
  query.set('categoria',id)
  history.push({search: query.toString()});
 }

 const manejarPais=()=>{
  let id = document.getElementById("pais").value;
  console.log(id);
  query.delete('busqueda')
  query.delete('categoria')
  query.set('pais',id)
  
  history.push({search: query.toString()});
  
 }

 const manejarBusqueda =()=>{
  let id = document.getElementById("busqueda").value;
  console.log(id);
  query.delete('pais')
  query.delete('categoria')
  query.set('busqueda',id)
  
  history.push({search: query.toString()});
  
 }



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
                 <select id='pais' className="form-control"> 
                {paises.map(valor=><option key={valor.idPais} value={valor.idPais}>{valor.nombrePais}</option>
                )}
               
                </select>
                <button onClick={manejarPais} className="btn btn-success">Pais</button>
            </li>
          

            <li className="nav-item form-inline my-2 my-lg-0">
                 <select id='categoria' className="form-control"> 
                {categoria.map(valor=><option key={valor.idCategoria} value={valor.idCategoria}>{valor.nombreCategoria}</option>
                )}
                
                </select>
                <button onClick={manejarCategoria} className="btn btn-success">Categoria</button>
            </li>
          </ul>
          <div className="form-inline my-2 my-lg-0">
            <input id="busqueda" className="form-control mr-sm-2" type="search" placeholder="Busqueda" aria-label="Search" ></input>
            <button onClick={manejarBusqueda} className="btn btn-success my-2 my-sm-0" type="button">Buscar</button>
            <button type="button" onClick={cerrarSesion} className="btn btn-danger">Salir</button>
          </div>
          
        </div>
      </nav>
        </div>
    )
}

export default NavbarComponent
