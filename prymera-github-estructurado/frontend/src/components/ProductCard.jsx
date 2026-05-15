export default function ProductCard({ titulo, categoria, descripcion, beneficio }) {
  return (
    <article className="product-card">
      <span>{categoria}</span>
      <h3>{titulo}</h3>
      <p>{descripcion}</p>
      <small>{beneficio}</small>
      <button>Más información</button>
    </article>
  )
}
