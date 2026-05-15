import Navbar from './components/Navbar'
import Home from './pages/Home'

export default function App() {
  return (
    <div>
      <Navbar />
      <Home />
      <footer className="footer">
        <p>Proyecto académico inspirado en Prymera. No es una web oficial.</p>
      </footer>
    </div>
  )
}
