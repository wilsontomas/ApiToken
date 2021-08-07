import './App.css';
import Inicio from './Components/Inicio';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Noticias from './Components/Noticias';
import NotFound from './Components/NotFound';
import verNoticia from './Components/verNoticia';

function App() {
  return (
    <BrowserRouter >
      <Switch>
        <Route exact path="/Inicio" component={Inicio} />
        <Route exact path="/Noticias" component={Noticias} />
        <Route exact path="/verNoticia" component={verNoticia} />
        <Route exact path="/" component={Noticias} />
        <Route path="*" component={NotFound} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
