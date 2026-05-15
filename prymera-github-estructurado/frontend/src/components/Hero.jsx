export default function Hero() {
  return (
    <section className="hero" id="inicio">
      <div className="hero-info">
        <span className="tag">Institución financiera peruana</span>
        <h1>Primero eres tú</h1>
        <p>
          Soluciones financieras para personas, emprendedores y empresas.
          Impulsa tu negocio, ahorra con seguridad y realiza tus pagos de forma sencilla.
        </p>
        <div className="hero-actions">
          <a href="#creditos" className="btn-primary">Ver productos</a>
          <a href="#agencias" className="btn-secondary">Ubicar agencias</a>
        </div>
      </div>
      <div className="hero-card">
        <h3>Acceso rápido</h3>
        <ul>
          <li>Crédito Capital de Trabajo</li>
          <li>Cuenta de Ahorros</li>
          <li>Depósito a Plazo Fijo</li>
          <li>Prymera Digital</li>
        </ul>
      </div>
    </section>
  )
}
