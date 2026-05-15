import Hero from '../components/Hero'
import ProductCard from '../components/ProductCard'

const productos = [
  {
    titulo: 'Capital de Trabajo',
    categoria: 'Créditos PYME',
    descripcion: 'Crédito pensado para hacer crecer tu negocio.',
    beneficio: 'Financia mercadería, campañas y operaciones.'
  },
  {
    titulo: 'Crédito Activo Fijo',
    categoria: 'Créditos PYME',
    descripcion: 'Financiamiento para herramientas, equipos o maquinaria.',
    beneficio: 'Mejora la productividad de tu negocio.'
  },
  {
    titulo: 'Préstamo Mi Cash',
    categoria: 'Persona',
    descripcion: 'Préstamo personal para gastos importantes.',
    beneficio: 'Opción para trabajadores dependientes o independientes.'
  },
  {
    titulo: 'Cuenta de Ahorros',
    categoria: 'Ahorros',
    descripcion: 'Cuenta para ahorrar sin cobros de mantenimiento.',
    beneficio: 'Sin monto mínimo de apertura.'
  },
  {
    titulo: 'Depósito a Plazo Fijo',
    categoria: 'Ahorros',
    descripcion: 'Producto para hacer crecer tus ahorros.',
    beneficio: 'Plazos disponibles desde 30 días.'
  },
  {
    titulo: 'Prymera Digital',
    categoria: 'Canales',
    descripcion: 'Realiza pagos y operaciones desde canales digitales.',
    beneficio: 'Atención digital de lunes a domingo.'
  }
]

export default function Home() {
  return (
    <>
      <Hero />

      <section className="section" id="creditos">
        <div className="section-title">
          <span>Productos financieros</span>
          <h2>Créditos, ahorros y canales para ti</h2>
        </div>

        <div className="products-grid">
          {productos.map((item) => (
            <ProductCard
              key={item.titulo}
              titulo={item.titulo}
              categoria={item.categoria}
              descripcion={item.descripcion}
              beneficio={item.beneficio}
            />
          ))}
        </div>
      </section>

      <section className="channels" id="canales">
        <h2>Canales de pago</h2>
        <p>
          Paga tus créditos mediante Prymera Digital, agencias y canales alternativos.
        </p>
      </section>

      <section className="agencies" id="agencias">
        <h2>Agencias principales</h2>
        <div className="agency-grid">
          <div><b>Miraflores</b><p>Av. República de Panamá 6251</p></div>
          <div><b>Plaza Norte</b><p>C.C. Plaza Norte, Independencia</p></div>
          <div><b>Mall del Sur</b><p>San Juan de Miraflores</p></div>
        </div>
      </section>
    </>
  )
}
