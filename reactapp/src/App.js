import logo from './logo.svg';
import './App.css';
import NavbarComponent from './Components/NavbarComponent';
import Inicio from './Components/Inicio';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Noticias from './Components/Noticias';
import NotFound from './Components/NotFound';

function App() {
  return (
    <BrowserRouter >
      <Switch>
        <Route exact path="/login" component={Inicio} />
        <Route exact path="/Noticias" component={Noticias} />
        <Route exact path="/" component={Noticias} />
        <Route path="*" component={NotFound} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
