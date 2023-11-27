
import { Route } from 'wouter'
import {Navbar} from './components/navbar'
import { CartProducts } from './routes/cart-products'

function App() {

  return (
    <>
      <Navbar></Navbar>

      <Route path="/">home</Route>
      <Route path="/cart-products" component={CartProducts} />
    </>
  )
}

export default App
