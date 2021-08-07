import './App.css';
import Inicio from './Components/Inicio';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Noticias from './Components/Noticias';
import NotFound from './Components/NotFound';
import VerNoticia from './Components/VerNoticia';

function App() {
  return (
    <BrowserRouter >
      <Switch>
        <Route exact path="/Inicio" component={Inicio} />
        <Route exact path="/Noticias" component={Noticias} />
        <Route exact path="/VerNoticia" component={VerNoticia} />
        <Route exact path="/" component={Noticias} />
        <Route path="*" component={NotFound} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
