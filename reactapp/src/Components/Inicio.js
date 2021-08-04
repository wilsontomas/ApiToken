import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { useHistory } from 'react-router-dom'
import '../Components/login.css'
const Inicio = () => {
    const history = useHistory();
    const [errorMsn, seterrorMsn] = useState(false);
    useEffect(() => {
        if(localStorage.getItem('Autenticacion')){
            history.push("/Noticias");
        }
        
    }, [])

   const _login = async (e)=>{
       e.preventDefault();
       try{
           
            const respuesta = await axios.post("https://localhost:44394/api/Cuenta/Autenticar",new FormData(e.target));
            localStorage.setItem('Autenticacion', JSON.stringify(respuesta.data));
            history.push("/Noticias");
       }catch(error){
           //alert(error.message);
           seterrorMsn(true);
        }
          }
    return (
        <div>
            <div className="wrapper fadeInDown">
            <div id="formContent">
               
                <form method="post" onSubmit={_login}>
                <input type="text" id="login" className="fadeIn second" name="nombre" placeholder="Inicio de sesion" />
                <input type="text" id="password" className="fadeIn third" name="clave" placeholder="clave" />
                {errorMsn ? 
                <span>Credenciales invalidas</span>: null
                }
                <input type="submit" className="fadeIn fourth" value="Log In" />
                </form>

            </div>
            </div>
        </div>
    )
}

export default Inicio
